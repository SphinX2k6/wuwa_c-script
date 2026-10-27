using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000343 RID: 835
	[NetMessage(EMessageId.DangoBrawlEventRefreshResponse)]
	public sealed class DangoBrawlEventRefreshResponse : IMessage<DangoBrawlEventRefreshResponse>, IMessage, IEquatable<DangoBrawlEventRefreshResponse>, IDeepCloneable<DangoBrawlEventRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600539D RID: 21405 RVA: 0x000CBD31 File Offset: 0x000C9F31
		[NullableContext(1)]
		public static DangoBrawlEventRefreshResponse Create()
		{
			return new DangoBrawlEventRefreshResponse();
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x000CBD38 File Offset: 0x000C9F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x000CBD3B File Offset: 0x000C9F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventRefreshResponse.Descriptor;
			}
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x000CBD42 File Offset: 0x000C9F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse()
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x000CBD4C File Offset: 0x000C9F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse(DangoBrawlEventRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.slotIndex_ = other.slotIndex_;
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x000CBDA4 File Offset: 0x000C9FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshResponse Clone()
		{
			return new DangoBrawlEventRefreshResponse(this);
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x000CBDAC File Offset: 0x000C9FAC
		// (set) Token: 0x060053A4 RID: 21412 RVA: 0x000CBDB4 File Offset: 0x000C9FB4
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

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x000CBDBD File Offset: 0x000C9FBD
		// (set) Token: 0x060053A6 RID: 21414 RVA: 0x000CBDC5 File Offset: 0x000C9FC5
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

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x000CBDCE File Offset: 0x000C9FCE
		// (set) Token: 0x060053A8 RID: 21416 RVA: 0x000CBDD6 File Offset: 0x000C9FD6
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

		// Token: 0x060053A9 RID: 21417 RVA: 0x000CBDDF File Offset: 0x000C9FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventRefreshResponse);
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x000CBDF0 File Offset: 0x000C9FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SlotIndex == other.SlotIndex && object.Equals(this.Slot, other.Slot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x000CBE50 File Offset: 0x000CA050
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

		// Token: 0x060053AC RID: 21420 RVA: 0x000CBEC4 File Offset: 0x000CA0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x000CBED1 File Offset: 0x000CA0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x000CBEDC File Offset: 0x000CA0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.slot_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Slot);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x000CBF50 File Offset: 0x000CA150
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

		// Token: 0x060053B0 RID: 21424 RVA: 0x000CBFC0 File Offset: 0x000CA1C0
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

		// Token: 0x060053B1 RID: 21425 RVA: 0x000CC03C File Offset: 0x000CA23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x000CC048 File Offset: 0x000CA248
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003388 RID: 13192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003389 RID: 13193
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400338A RID: 13194
		private ErrorCode errorCode_;

		// Token: 0x0400338B RID: 13195
		public const int SlotIndexFieldNumber = 3;

		// Token: 0x0400338C RID: 13196
		private int slotIndex_;

		// Token: 0x0400338D RID: 13197
		public const int SlotFieldNumber = 2;

		// Token: 0x0400338E RID: 13198
		private DangoBrawlEventSlotInfo slot_;
	}
}
