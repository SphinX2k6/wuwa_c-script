using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200066D RID: 1645
	public sealed class FurnitureComponentPb : IMessage<FurnitureComponentPb>, IMessage, IEquatable<FurnitureComponentPb>, IDeepCloneable<FurnitureComponentPb>, IBufferMessage
	{
		// Token: 0x06009724 RID: 38692 RVA: 0x0016CB58 File Offset: 0x0016AD58
		[NullableContext(1)]
		public static FurnitureComponentPb Create()
		{
			return new FurnitureComponentPb();
		}

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x0016CB5F File Offset: 0x0016AD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x0016CB62 File Offset: 0x0016AD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FurnitureComponentPb.Descriptor;
			}
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0016CB69 File Offset: 0x0016AD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb()
		{
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x0016CB71 File Offset: 0x0016AD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb(FurnitureComponentPb other) : this()
		{
			this.slotId_ = other.slotId_;
			this.furnitureId_ = other.furnitureId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009729 RID: 38697 RVA: 0x0016CBA2 File Offset: 0x0016ADA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb Clone()
		{
			return new FurnitureComponentPb(this);
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x0600972A RID: 38698 RVA: 0x0016CBAA File Offset: 0x0016ADAA
		// (set) Token: 0x0600972B RID: 38699 RVA: 0x0016CBB2 File Offset: 0x0016ADB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x0600972C RID: 38700 RVA: 0x0016CBBB File Offset: 0x0016ADBB
		// (set) Token: 0x0600972D RID: 38701 RVA: 0x0016CBC3 File Offset: 0x0016ADC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FurnitureId
		{
			get
			{
				return this.furnitureId_;
			}
			set
			{
				this.furnitureId_ = value;
			}
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x0016CBCC File Offset: 0x0016ADCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FurnitureComponentPb);
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x0016CBDA File Offset: 0x0016ADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FurnitureComponentPb other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.FurnitureId == other.FurnitureId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x0016CC18 File Offset: 0x0016AE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.FurnitureId != 0)
			{
				num ^= this.FurnitureId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x0016CC70 File Offset: 0x0016AE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x0016CC7D File Offset: 0x0016AE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x0016CC88 File Offset: 0x0016AE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.FurnitureId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FurnitureId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x0016CCE0 File Offset: 0x0016AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.FurnitureId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FurnitureId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x0016CD38 File Offset: 0x0016AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FurnitureComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.FurnitureId != 0)
			{
				this.FurnitureId = other.FurnitureId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x0016CD88 File Offset: 0x0016AF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x0016CD94 File Offset: 0x0016AF94
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FurnitureId = input.ReadInt32();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400483D RID: 18493
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400483E RID: 18494
		public const int SlotIdFieldNumber = 1;

		// Token: 0x0400483F RID: 18495
		private int slotId_;

		// Token: 0x04004840 RID: 18496
		public const int FurnitureIdFieldNumber = 2;

		// Token: 0x04004841 RID: 18497
		private int furnitureId_;
	}
}
