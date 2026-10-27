using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D60 RID: 3424
	public sealed class PinballSettlePreSubmitPb : IMessage<PinballSettlePreSubmitPb>, IMessage, IEquatable<PinballSettlePreSubmitPb>, IDeepCloneable<PinballSettlePreSubmitPb>, IBufferMessage
	{
		// Token: 0x06012780 RID: 75648 RVA: 0x002B1F91 File Offset: 0x002B0191
		[NullableContext(1)]
		public static PinballSettlePreSubmitPb Create()
		{
			return new PinballSettlePreSubmitPb();
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x06012781 RID: 75649 RVA: 0x002B1F98 File Offset: 0x002B0198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x06012782 RID: 75650 RVA: 0x002B1F9B File Offset: 0x002B019B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettlePreSubmitPb.Descriptor;
			}
		}

		// Token: 0x06012783 RID: 75651 RVA: 0x002B1FA2 File Offset: 0x002B01A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb()
		{
		}

		// Token: 0x06012784 RID: 75652 RVA: 0x002B1FAA File Offset: 0x002B01AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb(PinballSettlePreSubmitPb other) : this()
		{
			this.reviveTimesCost_ = other.reviveTimesCost_;
			this.maxReviveTimes_ = other.maxReviveTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012785 RID: 75653 RVA: 0x002B1FDB File Offset: 0x002B01DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb Clone()
		{
			return new PinballSettlePreSubmitPb(this);
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x06012786 RID: 75654 RVA: 0x002B1FE3 File Offset: 0x002B01E3
		// (set) Token: 0x06012787 RID: 75655 RVA: 0x002B1FEB File Offset: 0x002B01EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimesCost
		{
			get
			{
				return this.reviveTimesCost_;
			}
			set
			{
				this.reviveTimesCost_ = value;
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x06012788 RID: 75656 RVA: 0x002B1FF4 File Offset: 0x002B01F4
		// (set) Token: 0x06012789 RID: 75657 RVA: 0x002B1FFC File Offset: 0x002B01FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReviveTimes
		{
			get
			{
				return this.maxReviveTimes_;
			}
			set
			{
				this.maxReviveTimes_ = value;
			}
		}

		// Token: 0x0601278A RID: 75658 RVA: 0x002B2005 File Offset: 0x002B0205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettlePreSubmitPb);
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x002B2013 File Offset: 0x002B0213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettlePreSubmitPb other)
		{
			return other != null && (other == this || (this.ReviveTimesCost == other.ReviveTimesCost && this.MaxReviveTimes == other.MaxReviveTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601278C RID: 75660 RVA: 0x002B2054 File Offset: 0x002B0254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReviveTimesCost != 0)
			{
				num ^= this.ReviveTimesCost.GetHashCode();
			}
			if (this.MaxReviveTimes != 0)
			{
				num ^= this.MaxReviveTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601278D RID: 75661 RVA: 0x002B20AC File Offset: 0x002B02AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601278E RID: 75662 RVA: 0x002B20B9 File Offset: 0x002B02B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601278F RID: 75663 RVA: 0x002B20C4 File Offset: 0x002B02C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveTimesCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ReviveTimesCost);
			}
			if (this.MaxReviveTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxReviveTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012790 RID: 75664 RVA: 0x002B2120 File Offset: 0x002B0320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReviveTimesCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimesCost);
			}
			if (this.MaxReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReviveTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012791 RID: 75665 RVA: 0x002B2178 File Offset: 0x002B0378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSettlePreSubmitPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReviveTimesCost != 0)
			{
				this.ReviveTimesCost = other.ReviveTimesCost;
			}
			if (other.MaxReviveTimes != 0)
			{
				this.MaxReviveTimes = other.MaxReviveTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012792 RID: 75666 RVA: 0x002B21C8 File Offset: 0x002B03C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012793 RID: 75667 RVA: 0x002B21D4 File Offset: 0x002B03D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 24U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxReviveTimes = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveTimesCost = input.ReadInt32();
				}
			}
		}

		// Token: 0x040072EA RID: 29418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072EB RID: 29419
		public const int ReviveTimesCostFieldNumber = 3;

		// Token: 0x040072EC RID: 29420
		private int reviveTimesCost_;

		// Token: 0x040072ED RID: 29421
		public const int MaxReviveTimesFieldNumber = 4;

		// Token: 0x040072EE RID: 29422
		private int maxReviveTimes_;
	}
}
