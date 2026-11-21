using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122B RID: 4651
	[NetMessage(EMessageId.ShopBuyResponse)]
	public sealed class ShopBuyResponse : IMessage<ShopBuyResponse>, IMessage, IEquatable<ShopBuyResponse>, IDeepCloneable<ShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06018D6E RID: 101742 RVA: 0x0039EE29 File Offset: 0x0039D029
		[NullableContext(1)]
		public static ShopBuyResponse Create()
		{
			return new ShopBuyResponse();
		}

		// Token: 0x170053E6 RID: 21478
		// (get) Token: 0x06018D6F RID: 101743 RVA: 0x0039EE30 File Offset: 0x0039D030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x06018D70 RID: 101744 RVA: 0x0039EE33 File Offset: 0x0039D033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06018D71 RID: 101745 RVA: 0x0039EE3A File Offset: 0x0039D03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse()
		{
		}

		// Token: 0x06018D72 RID: 101746 RVA: 0x0039EE44 File Offset: 0x0039D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse(ShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shopId_ = other.shopId_;
			this.id_ = other.id_;
			this.boughtCount_ = other.boughtCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D73 RID: 101747 RVA: 0x0039EE98 File Offset: 0x0039D098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyResponse Clone()
		{
			return new ShopBuyResponse(this);
		}

		// Token: 0x170053E8 RID: 21480
		// (get) Token: 0x06018D74 RID: 101748 RVA: 0x0039EEA0 File Offset: 0x0039D0A0
		// (set) Token: 0x06018D75 RID: 101749 RVA: 0x0039EEA8 File Offset: 0x0039D0A8
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

		// Token: 0x170053E9 RID: 21481
		// (get) Token: 0x06018D76 RID: 101750 RVA: 0x0039EEB1 File Offset: 0x0039D0B1
		// (set) Token: 0x06018D77 RID: 101751 RVA: 0x0039EEB9 File Offset: 0x0039D0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x06018D78 RID: 101752 RVA: 0x0039EEC2 File Offset: 0x0039D0C2
		// (set) Token: 0x06018D79 RID: 101753 RVA: 0x0039EECA File Offset: 0x0039D0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170053EB RID: 21483
		// (get) Token: 0x06018D7A RID: 101754 RVA: 0x0039EED3 File Offset: 0x0039D0D3
		// (set) Token: 0x06018D7B RID: 101755 RVA: 0x0039EEDB File Offset: 0x0039D0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoughtCount
		{
			get
			{
				return this.boughtCount_;
			}
			set
			{
				this.boughtCount_ = value;
			}
		}

		// Token: 0x06018D7C RID: 101756 RVA: 0x0039EEE4 File Offset: 0x0039D0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyResponse);
		}

		// Token: 0x06018D7D RID: 101757 RVA: 0x0039EEF4 File Offset: 0x0039D0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ShopId == other.ShopId && this.Id == other.Id && this.BoughtCount == other.BoughtCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D7E RID: 101758 RVA: 0x0039EF60 File Offset: 0x0039D160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BoughtCount != 0)
			{
				num ^= this.BoughtCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D7F RID: 101759 RVA: 0x0039EFF0 File Offset: 0x0039D1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D80 RID: 101760 RVA: 0x0039EFFD File Offset: 0x0039D1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D81 RID: 101761 RVA: 0x0039F008 File Offset: 0x0039D208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ShopId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ShopId);
			}
			if (this.BoughtCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BoughtCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D82 RID: 101762 RVA: 0x0039F098 File Offset: 0x0039D298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BoughtCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoughtCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D83 RID: 101763 RVA: 0x0039F120 File Offset: 0x0039D320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BoughtCount != 0)
			{
				this.BoughtCount = other.BoughtCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D84 RID: 101764 RVA: 0x0039F198 File Offset: 0x0039D398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D85 RID: 101765 RVA: 0x0039F1A4 File Offset: 0x0039D3A4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ShopId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.BoughtCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400935E RID: 37726
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400935F RID: 37727
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009360 RID: 37728
		private ErrorCode errorCode_;

		// Token: 0x04009361 RID: 37729
		public const int ShopIdFieldNumber = 6;

		// Token: 0x04009362 RID: 37730
		private int shopId_;

		// Token: 0x04009363 RID: 37731
		public const int IdFieldNumber = 1;

		// Token: 0x04009364 RID: 37732
		private int id_;

		// Token: 0x04009365 RID: 37733
		public const int BoughtCountFieldNumber = 14;

		// Token: 0x04009366 RID: 37734
		private int boughtCount_;
	}
}
