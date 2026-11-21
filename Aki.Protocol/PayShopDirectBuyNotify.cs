using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDB RID: 3035
	[NetMessage(EMessageId.PayShopDirectBuyNotify)]
	public sealed class PayShopDirectBuyNotify : IMessage<PayShopDirectBuyNotify>, IMessage, IEquatable<PayShopDirectBuyNotify>, IDeepCloneable<PayShopDirectBuyNotify>, IBufferMessage
	{
		// Token: 0x06010784 RID: 67460 RVA: 0x002681AD File Offset: 0x002663AD
		[NullableContext(1)]
		public static PayShopDirectBuyNotify Create()
		{
			return new PayShopDirectBuyNotify();
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x06010785 RID: 67461 RVA: 0x002681B4 File Offset: 0x002663B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x06010786 RID: 67462 RVA: 0x002681B7 File Offset: 0x002663B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyNotify.Descriptor;
			}
		}

		// Token: 0x06010787 RID: 67463 RVA: 0x002681BE File Offset: 0x002663BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyNotify()
		{
		}

		// Token: 0x06010788 RID: 67464 RVA: 0x002681D4 File Offset: 0x002663D4
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

		// Token: 0x06010789 RID: 67465 RVA: 0x00268228 File Offset: 0x00266428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyNotify Clone()
		{
			return new PayShopDirectBuyNotify(this);
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0601078A RID: 67466 RVA: 0x00268230 File Offset: 0x00266430
		// (set) Token: 0x0601078B RID: 67467 RVA: 0x00268238 File Offset: 0x00266438
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

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0601078C RID: 67468 RVA: 0x0026824B File Offset: 0x0026644B
		// (set) Token: 0x0601078D RID: 67469 RVA: 0x00268253 File Offset: 0x00266453
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

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0601078E RID: 67470 RVA: 0x0026825C File Offset: 0x0026645C
		// (set) Token: 0x0601078F RID: 67471 RVA: 0x00268264 File Offset: 0x00266464
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

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x06010790 RID: 67472 RVA: 0x0026826D File Offset: 0x0026646D
		// (set) Token: 0x06010791 RID: 67473 RVA: 0x00268275 File Offset: 0x00266475
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

		// Token: 0x06010792 RID: 67474 RVA: 0x0026827E File Offset: 0x0026647E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyNotify);
		}

		// Token: 0x06010793 RID: 67475 RVA: 0x0026828C File Offset: 0x0026648C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyNotify other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ShopItemId == other.ShopItemId && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010794 RID: 67476 RVA: 0x002682FC File Offset: 0x002664FC
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

		// Token: 0x06010795 RID: 67477 RVA: 0x00268388 File Offset: 0x00266588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010796 RID: 67478 RVA: 0x00268395 File Offset: 0x00266595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010797 RID: 67479 RVA: 0x002683A0 File Offset: 0x002665A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ReceiptId);
			}
			if (this.ShopItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ShopItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010798 RID: 67480 RVA: 0x00268438 File Offset: 0x00266638
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

		// Token: 0x06010799 RID: 67481 RVA: 0x002684C4 File Offset: 0x002666C4
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

		// Token: 0x0601079A RID: 67482 RVA: 0x00268541 File Offset: 0x00266741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601079B RID: 67483 RVA: 0x0026854C File Offset: 0x0026674C
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ShopItemId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ItemCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040068F0 RID: 26864
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068F1 RID: 26865
		public const int ReceiptIdFieldNumber = 6;

		// Token: 0x040068F2 RID: 26866
		private string receiptId_ = "";

		// Token: 0x040068F3 RID: 26867
		public const int ShopItemIdFieldNumber = 12;

		// Token: 0x040068F4 RID: 26868
		private int shopItemId_;

		// Token: 0x040068F5 RID: 26869
		public const int ItemIdFieldNumber = 2;

		// Token: 0x040068F6 RID: 26870
		private int itemId_;

		// Token: 0x040068F7 RID: 26871
		public const int ItemCountFieldNumber = 13;

		// Token: 0x040068F8 RID: 26872
		private int itemCount_;
	}
}
