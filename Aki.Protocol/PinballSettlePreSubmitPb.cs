using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D50 RID: 3408
	public sealed class PinballSettlePreSubmitPb : IMessage<PinballSettlePreSubmitPb>, IMessage, IEquatable<PinballSettlePreSubmitPb>, IDeepCloneable<PinballSettlePreSubmitPb>, IBufferMessage
	{
		// Token: 0x06012684 RID: 75396 RVA: 0x002B036D File Offset: 0x002AE56D
		[NullableContext(1)]
		public static PinballSettlePreSubmitPb Create()
		{
			return new PinballSettlePreSubmitPb();
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x06012685 RID: 75397 RVA: 0x002B0374 File Offset: 0x002AE574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x06012686 RID: 75398 RVA: 0x002B0377 File Offset: 0x002AE577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettlePreSubmitPb.Descriptor;
			}
		}

		// Token: 0x06012687 RID: 75399 RVA: 0x002B037E File Offset: 0x002AE57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb()
		{
		}

		// Token: 0x06012688 RID: 75400 RVA: 0x002B0386 File Offset: 0x002AE586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb(PinballSettlePreSubmitPb other) : this()
		{
			this.reviveTimesCost_ = other.reviveTimesCost_;
			this.maxReviveTimes_ = other.maxReviveTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012689 RID: 75401 RVA: 0x002B03B7 File Offset: 0x002AE5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePreSubmitPb Clone()
		{
			return new PinballSettlePreSubmitPb(this);
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0601268A RID: 75402 RVA: 0x002B03BF File Offset: 0x002AE5BF
		// (set) Token: 0x0601268B RID: 75403 RVA: 0x002B03C7 File Offset: 0x002AE5C7
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

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0601268C RID: 75404 RVA: 0x002B03D0 File Offset: 0x002AE5D0
		// (set) Token: 0x0601268D RID: 75405 RVA: 0x002B03D8 File Offset: 0x002AE5D8
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

		// Token: 0x0601268E RID: 75406 RVA: 0x002B03E1 File Offset: 0x002AE5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettlePreSubmitPb);
		}

		// Token: 0x0601268F RID: 75407 RVA: 0x002B03EF File Offset: 0x002AE5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettlePreSubmitPb other)
		{
			return other != null && (other == this || (this.ReviveTimesCost == other.ReviveTimesCost && this.MaxReviveTimes == other.MaxReviveTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012690 RID: 75408 RVA: 0x002B0430 File Offset: 0x002AE630
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

		// Token: 0x06012691 RID: 75409 RVA: 0x002B0488 File Offset: 0x002AE688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012692 RID: 75410 RVA: 0x002B0495 File Offset: 0x002AE695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012693 RID: 75411 RVA: 0x002B04A0 File Offset: 0x002AE6A0
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

		// Token: 0x06012694 RID: 75412 RVA: 0x002B04FC File Offset: 0x002AE6FC
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

		// Token: 0x06012695 RID: 75413 RVA: 0x002B0554 File Offset: 0x002AE754
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

		// Token: 0x06012696 RID: 75414 RVA: 0x002B05A4 File Offset: 0x002AE7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012697 RID: 75415 RVA: 0x002B05B0 File Offset: 0x002AE7B0
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

		// Token: 0x04007302 RID: 29442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007303 RID: 29443
		public const int ReviveTimesCostFieldNumber = 3;

		// Token: 0x04007304 RID: 29444
		private int reviveTimesCost_;

		// Token: 0x04007305 RID: 29445
		public const int MaxReviveTimesFieldNumber = 4;

		// Token: 0x04007306 RID: 29446
		private int maxReviveTimes_;
	}
}
