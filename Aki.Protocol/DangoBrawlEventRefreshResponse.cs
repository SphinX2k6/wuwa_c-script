using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034B RID: 843
	[NetMessage(EMessageId.DangoBrawlEventRefreshResponse)]
	public sealed class DangoBrawlEventRefreshResponse : IMessage<DangoBrawlEventRefreshResponse>, IMessage, IEquatable<DangoBrawlEventRefreshResponse>, IDeepCloneable<DangoBrawlEventRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600548A RID: 21642 RVA: 0x000CE3B5 File Offset: 0x000CC5B5
		[NullableContext(1)]
		public static DangoBrawlEventRefreshResponse Create()
		{
			return new DangoBrawlEventRefreshResponse();
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x000CE3BC File Offset: 0x000CC5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x000CE3BF File Offset: 0x000CC5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x000CE3C6 File Offset: 0x000CC5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse()
		{
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x000CE3D0 File Offset: 0x000CC5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse(DangoBrawlEventRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.slotIndex_ = other.slotIndex_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x000CE428 File Offset: 0x000CC628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse Clone()
		{
			return new DangoBrawlEventRefreshResponse(this);
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x000CE430 File Offset: 0x000CC630
		// (set) Token: 0x06005491 RID: 21649 RVA: 0x000CE438 File Offset: 0x000CC638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x000CE441 File Offset: 0x000CC641
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x000CE449 File Offset: 0x000CC649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x000CE452 File Offset: 0x000CC652
		// (set) Token: 0x06005495 RID: 21653 RVA: 0x000CE45A File Offset: 0x000CC65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x000CE463 File Offset: 0x000CC663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventRefreshResponse);
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x000CE474 File Offset: 0x000CC674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SlotIndex == other.SlotIndex && object.Equals(this.Slot, other.Slot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x000CE4D4 File Offset: 0x000CC6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.slot_ != null)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x000CE548 File Offset: 0x000CC748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x000CE555 File Offset: 0x000CC755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x000CE560 File Offset: 0x000CC760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.slot_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Slot);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x000CE5D8 File Offset: 0x000CC7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this.slot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x000CE648 File Offset: 0x000CC848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.slot_ != null)
			{
				if (this.slot_ == null)
				{
					this.Slot = new DangoBrawlEventSlotInfo();
				}
				this.Slot.MergeFrom(other.Slot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x000CE6C4 File Offset: 0x000CC8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x000CE6D0 File Offset: 0x000CC8D0
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.SlotIndex = input.ReadInt32();
					}
				}
				else
				{
					if (this.slot_ == null)
					{
						this.Slot = new DangoBrawlEventSlotInfo();
					}
					input.ReadMessage(this.Slot);
				}
			}
		}

		// Token: 0x04003424 RID: 13348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003425 RID: 13349
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003426 RID: 13350
		private ErrorCode errorCode_;

		// Token: 0x04003427 RID: 13351
		public const int SlotIndexFieldNumber = 5;

		// Token: 0x04003428 RID: 13352
		private int slotIndex_;

		// Token: 0x04003429 RID: 13353
		public const int SlotFieldNumber = 2;

		// Token: 0x0400342A RID: 13354
		private DangoBrawlEventSlotInfo slot_;
	}
}
