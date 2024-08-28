//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.polkadot_runtime_parachains.paras
{
    
    
    /// <summary>
    /// >> 775 - Composite[polkadot_runtime_parachains.paras.ParaPastCodeMeta]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParaPastCodeMeta : BaseType
    {
        
        /// <summary>
        /// >> upgrade_times
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes> UpgradeTimes { get; set; }
        /// <summary>
        /// >> last_pruned
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> LastPruned { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ParaPastCodeMeta";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpgradeTimes.Encode());
            result.AddRange(LastPruned.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpgradeTimes = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes>();
            UpgradeTimes.Decode(byteArray, ref p);
            LastPruned = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            LastPruned.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}