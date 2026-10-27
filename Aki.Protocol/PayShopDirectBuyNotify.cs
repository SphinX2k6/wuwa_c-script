using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEB RID: 3051
	[NetMessage(EMessageId.PayShopDirectBuyNotify)]
	public sealed class PayShopDirectBuyNotify : IMessage<PayShopDirectBuyNotify>, IMessage, IEquatable<PayShopDirectBuyNotify>, IDeepCloneable<PayShopDirectBuyNotify>, IBufferMessage
	{
		// Token: 0x06010888 RID: 67720 RVA: 0x0026A071 File Offset: 0x00268271
		[NullableContext(1)]
		public static PayShopDirectBuyNotify Create()
		{
			return new PayShopDirectBuyNotify();
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x06010889 RID: 67721 RVA: 0x0026A078 File Offset: 0x00268278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0601088A RID: 67722 RVA: 0x0026A07B File Offset: 0x0026827B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyNotify.Descriptor;
			}
		}

		// Token: 0x0601088B RID: 67723 RVA: 0x0026A082 File Offset: 0x00268282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyNotify()
		{
		}

		// Token: 0x0601088C RID: 67724 RVA: 0x0026A098 File Offset: 0x00268298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyNotify(PayShopDirectBuyNotify other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.shopItemId_ = other.shopItemId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601088D RID: 67725 RVA: 0x0026A0EC File Offset: 0x002682EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyNotify Clone()
		{
			return new PayShopDirectBuyNotify(this);
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0601088E RID: 67726 RVA: 0x0026A0F4 File Offset: 0x002682F4
		// (set) Token: 0x0601088F RID: 67727 RVA: 0x0026A0FC File Offset: 0x002682FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReceiptId
		{
			get
			{
				return this.receiptId_;
			}
			set
			{
				this.receiptId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x06010890 RID: 67728 RVA: 0x0026A10F File Offset: 0x0026830F
		// (set) Token: 0x06010891 RID: 67729 RVA: 0x0026A117 File Offset: 0x00268317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopItemId
		{
			get
			{
				return this.shopItemId_;
			}
			set
			{
				this.shopItemId_ = value;
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x06010892 RID: 67730 RVA: 0x0026A120 File Offset: 0x00268320
		// (set) Token: 0x06010893 RID: 67731 RVA: 0x0026A128 File Offset: 0x00268328
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x06010894 RID: 67732 RVA: 0x0026A131 File Offset: 0x00268331
		// (set) Token: 0x06010895 RID: 67733 RVA: 0x0026A139 File Offset: 0x00268339
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

		// Token: 0x06010896 RID: 67734 RVA: 0x0026A142 File Offset: 0x00268342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyNotify);
		}

		// Token: 0x06010897 RID: 67735 RVA: 0x0026A150 File Offset: 0x00268350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyNotify other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ShopItemId == other.ShopItemId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010898 RID: 67736 RVA: 0x0026A1C0 File Offset: 0x002683C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReceiptId.Length != 0)
			{
				num ^= this.ReceiptId.GetHashCode();
			}
			if (this.ShopItemId != 0)
			{
				num ^= this.ShopItemId.GetHashCode();
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

		// Token: 0x06010899 RID: 67737 RVA: 0x0026A24C File Offset: 0x0026844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601089A RID: 67738 RVA: 0x0026A259 File Offset: 0x00268459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601089B RID: 67739 RVA: 0x0026A264 File Offset: 0x00268464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ReceiptId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.ShopItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ShopItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601089C RID: 67740 RVA: 0x0026A2FC File Offset: 0x002684FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReceiptId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReceiptId);
			}
			if (this.ShopItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopItemId);
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

		// Token: 0x0601089D RID: 67741 RVA: 0x0026A388 File Offset: 0x00268588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopDirectBuyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReceiptId.Length != 0)
			{
				this.ReceiptId = other.ReceiptId;
			}
			if (other.ShopItemId != 0)
			{
				this.ShopItemId = other.ShopItemId;
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

		// Token: 0x0601089E RID: 67742 RVA: 0x0026A405 File Offset: 0x00268605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601089F RID: 67743 RVA: 0x0026A410 File Offset: 0x00268610
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.ItemCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ShopItemId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040068E0 RID: 26848
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068E1 RID: 26849
		public const int ReceiptIdFieldNumber = 1;

		// Token: 0x040068E2 RID: 26850
		private string receiptId_ = "";

		// Token: 0x040068E3 RID: 26851
		public const int ShopItemIdFieldNumber = 8;

		// Token: 0x040068E4 RID: 26852
		private int shopItemId_;

		// Token: 0x040068E5 RID: 26853
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040068E6 RID: 26854
		private int itemId_;

		// Token: 0x040068E7 RID: 26855
		public const int ItemCountFieldNumber = 2;

		// Token: 0x040068E8 RID: 26856
		private int itemCount_;
	}
}
