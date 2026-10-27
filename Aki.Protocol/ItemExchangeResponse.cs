using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000850 RID: 2128
	[NetMessage(EMessageId.ItemExchangeResponse)]
	public sealed class ItemExchangeResponse : IMessage<ItemExchangeResponse>, IMessage, IEquatable<ItemExchangeResponse>, IDeepCloneable<ItemExchangeResponse>, IBufferMessage
	{
		// Token: 0x0600BDCF RID: 48591 RVA: 0x001C3284 File Offset: 0x001C1484
		[NullableContext(1)]
		public static ItemExchangeResponse Create()
		{
			return new ItemExchangeResponse();
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x0600BDD0 RID: 48592 RVA: 0x001C328B File Offset: 0x001C148B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x001C328E File Offset: 0x001C148E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeResponse.Descriptor;
			}
		}

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x001C3295 File Offset: 0x001C1495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse()
		{
		}

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x001C329D File Offset: 0x001C149D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse(ItemExchangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x001C32DA File Offset: 0x001C14DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeResponse Clone()
		{
			return new ItemExchangeResponse(this);
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x0600BDD5 RID: 48597 RVA: 0x001C32E2 File Offset: 0x001C14E2
		// (set) Token: 0x0600BDD6 RID: 48598 RVA: 0x001C32EA File Offset: 0x001C14EA
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

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x0600BDD7 RID: 48599 RVA: 0x001C32F3 File Offset: 0x001C14F3
		// (set) Token: 0x0600BDD8 RID: 48600 RVA: 0x001C32FB File Offset: 0x001C14FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x0600BDD9 RID: 48601 RVA: 0x001C3304 File Offset: 0x001C1504
		// (set) Token: 0x0600BDDA RID: 48602 RVA: 0x001C330C File Offset: 0x001C150C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x001C3315 File Offset: 0x001C1515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeResponse);
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x001C3324 File Offset: 0x001C1524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x001C3380 File Offset: 0x001C1580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x001C33F7 File Offset: 0x001C15F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x001C3404 File Offset: 0x001C1604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x001C3410 File Offset: 0x001C1610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x001C3488 File Offset: 0x001C1688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x001C34F8 File Offset: 0x001C16F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x001C355C File Offset: 0x001C175C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x001C3568 File Offset: 0x001C1768
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemCount = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040052DF RID: 21215
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052E0 RID: 21216
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040052E1 RID: 21217
		private ErrorCode errorCode_;

		// Token: 0x040052E2 RID: 21218
		public const int ItemIdFieldNumber = 8;

		// Token: 0x040052E3 RID: 21219
		private int itemId_;

		// Token: 0x040052E4 RID: 21220
		public const int ItemCountFieldNumber = 12;

		// Token: 0x040052E5 RID: 21221
		private int itemCount_;
	}
}
