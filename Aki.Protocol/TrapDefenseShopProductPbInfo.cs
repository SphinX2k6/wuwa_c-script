using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001449 RID: 5193
	public sealed class TrapDefenseShopProductPbInfo : IMessage<TrapDefenseShopProductPbInfo>, IMessage, IEquatable<TrapDefenseShopProductPbInfo>, IDeepCloneable<TrapDefenseShopProductPbInfo>, IBufferMessage
	{
		// Token: 0x0601B80C RID: 112652 RVA: 0x003FB4B0 File Offset: 0x003F96B0
		[NullableContext(1)]
		public static TrapDefenseShopProductPbInfo Create()
		{
			return new TrapDefenseShopProductPbInfo();
		}

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x0601B80D RID: 112653 RVA: 0x003FB4B7 File Offset: 0x003F96B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseShopProductPbInfo> Parser
		{
			get
			{
				return TrapDefenseShopProductPbInfo._parser;
			}
		}

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x0601B80E RID: 112654 RVA: 0x003FB4BE File Offset: 0x003F96BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x0601B80F RID: 112655 RVA: 0x003FB4C1 File Offset: 0x003F96C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopProductPbInfo.Descriptor;
			}
		}

		// Token: 0x0601B810 RID: 112656 RVA: 0x003FB4C8 File Offset: 0x003F96C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo()
		{
		}

		// Token: 0x0601B811 RID: 112657 RVA: 0x003FB4D0 File Offset: 0x003F96D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo(TrapDefenseShopProductPbInfo other) : this()
		{
			this.originalPrice_ = other.originalPrice_;
			this.discountPrice_ = other.discountPrice_;
			TrapDefenseShopProductPbInfo.ProductInfoOneofCase productInfoCase = other.ProductInfoCase;
			if (productInfoCase != TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
			{
				if (productInfoCase == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
				{
					this.BdGroupPbInfo = other.BdGroupPbInfo.Clone();
				}
			}
			else
			{
				this.ItemPbInfo = other.ItemPbInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B812 RID: 112658 RVA: 0x003FB541 File Offset: 0x003F9741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo Clone()
		{
			return new TrapDefenseShopProductPbInfo(this);
		}

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0601B813 RID: 112659 RVA: 0x003FB549 File Offset: 0x003F9749
		// (set) Token: 0x0601B814 RID: 112660 RVA: 0x003FB551 File Offset: 0x003F9751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginalPrice
		{
			get
			{
				return this.originalPrice_;
			}
			set
			{
				this.originalPrice_ = value;
			}
		}

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0601B815 RID: 112661 RVA: 0x003FB55A File Offset: 0x003F975A
		// (set) Token: 0x0601B816 RID: 112662 RVA: 0x003FB562 File Offset: 0x003F9762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscountPrice
		{
			get
			{
				return this.discountPrice_;
			}
			set
			{
				this.discountPrice_ = value;
			}
		}

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0601B817 RID: 112663 RVA: 0x003FB56B File Offset: 0x003F976B
		// (set) Token: 0x0601B818 RID: 112664 RVA: 0x003FB583 File Offset: 0x003F9783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopItemPbInfo ItemPbInfo
		{
			get
			{
				if (this.productInfoCase_ != TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
				{
					return null;
				}
				return (TrapDefenseShopItemPbInfo)this.productInfo_;
			}
			set
			{
				this.productInfo_ = value;
				this.productInfoCase_ = ((value == null) ? TrapDefenseShopProductPbInfo.ProductInfoOneofCase.None : TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo);
			}
		}

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x0601B819 RID: 112665 RVA: 0x003FB599 File Offset: 0x003F9799
		// (set) Token: 0x0601B81A RID: 112666 RVA: 0x003FB5B1 File Offset: 0x003F97B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopBdGroupPbInfo BdGroupPbInfo
		{
			get
			{
				if (this.productInfoCase_ != TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
				{
					return null;
				}
				return (TrapDefenseShopBdGroupPbInfo)this.productInfo_;
			}
			set
			{
				this.productInfo_ = value;
				this.productInfoCase_ = ((value == null) ? TrapDefenseShopProductPbInfo.ProductInfoOneofCase.None : TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo);
			}
		}

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x0601B81B RID: 112667 RVA: 0x003FB5C7 File Offset: 0x003F97C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo.ProductInfoOneofCase ProductInfoCase
		{
			get
			{
				return this.productInfoCase_;
			}
		}

		// Token: 0x0601B81C RID: 112668 RVA: 0x003FB5CF File Offset: 0x003F97CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProductInfo()
		{
			this.productInfoCase_ = TrapDefenseShopProductPbInfo.ProductInfoOneofCase.None;
			this.productInfo_ = null;
		}

		// Token: 0x0601B81D RID: 112669 RVA: 0x003FB5DF File Offset: 0x003F97DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopProductPbInfo);
		}

		// Token: 0x0601B81E RID: 112670 RVA: 0x003FB5F0 File Offset: 0x003F97F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopProductPbInfo other)
		{
			return other != null && (other == this || (this.OriginalPrice == other.OriginalPrice && this.DiscountPrice == other.DiscountPrice && object.Equals(this.ItemPbInfo, other.ItemPbInfo) && object.Equals(this.BdGroupPbInfo, other.BdGroupPbInfo) && this.ProductInfoCase == other.ProductInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B81F RID: 112671 RVA: 0x003FB674 File Offset: 0x003F9874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OriginalPrice != 0)
			{
				num ^= this.OriginalPrice.GetHashCode();
			}
			if (this.DiscountPrice != 0)
			{
				num ^= this.DiscountPrice.GetHashCode();
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
			{
				num ^= this.ItemPbInfo.GetHashCode();
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
			{
				num ^= this.BdGroupPbInfo.GetHashCode();
			}
			num ^= (int)this.productInfoCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B820 RID: 112672 RVA: 0x003FB703 File Offset: 0x003F9903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B821 RID: 112673 RVA: 0x003FB710 File Offset: 0x003F9910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x003FB71C File Offset: 0x003F991C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OriginalPrice != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.OriginalPrice);
			}
			if (this.DiscountPrice != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DiscountPrice);
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ItemPbInfo);
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.BdGroupPbInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B823 RID: 112675 RVA: 0x003FB7B0 File Offset: 0x003F99B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OriginalPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginalPrice);
			}
			if (this.DiscountPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscountPrice);
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemPbInfo);
			}
			if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BdGroupPbInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B824 RID: 112676 RVA: 0x003FB838 File Offset: 0x003F9A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseShopProductPbInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OriginalPrice != 0)
			{
				this.OriginalPrice = other.OriginalPrice;
			}
			if (other.DiscountPrice != 0)
			{
				this.DiscountPrice = other.DiscountPrice;
			}
			TrapDefenseShopProductPbInfo.ProductInfoOneofCase productInfoCase = other.ProductInfoCase;
			if (productInfoCase != TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
			{
				if (productInfoCase == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
				{
					if (this.BdGroupPbInfo == null)
					{
						this.BdGroupPbInfo = new TrapDefenseShopBdGroupPbInfo();
					}
					this.BdGroupPbInfo.MergeFrom(other.BdGroupPbInfo);
				}
			}
			else
			{
				if (this.ItemPbInfo == null)
				{
					this.ItemPbInfo = new TrapDefenseShopItemPbInfo();
				}
				this.ItemPbInfo.MergeFrom(other.ItemPbInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B825 RID: 112677 RVA: 0x003FB8E3 File Offset: 0x003F9AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B826 RID: 112678 RVA: 0x003FB8EC File Offset: 0x003F9AEC
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
					if (num == 8U)
					{
						this.OriginalPrice = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DiscountPrice = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						TrapDefenseShopItemPbInfo trapDefenseShopItemPbInfo = new TrapDefenseShopItemPbInfo();
						if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.ItemPbInfo)
						{
							trapDefenseShopItemPbInfo.MergeFrom(this.ItemPbInfo);
						}
						input.ReadMessage(trapDefenseShopItemPbInfo);
						this.ItemPbInfo = trapDefenseShopItemPbInfo;
						continue;
					}
					if (num == 34U)
					{
						TrapDefenseShopBdGroupPbInfo trapDefenseShopBdGroupPbInfo = new TrapDefenseShopBdGroupPbInfo();
						if (this.productInfoCase_ == TrapDefenseShopProductPbInfo.ProductInfoOneofCase.BdGroupPbInfo)
						{
							trapDefenseShopBdGroupPbInfo.MergeFrom(this.BdGroupPbInfo);
						}
						input.ReadMessage(trapDefenseShopBdGroupPbInfo);
						this.BdGroupPbInfo = trapDefenseShopBdGroupPbInfo;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009EA4 RID: 40612
		private static readonly MessageParser<TrapDefenseShopProductPbInfo> _parser = new MessageParser<TrapDefenseShopProductPbInfo>(() => new TrapDefenseShopProductPbInfo());

		// Token: 0x04009EA5 RID: 40613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EA6 RID: 40614
		public const int OriginalPriceFieldNumber = 1;

		// Token: 0x04009EA7 RID: 40615
		private int originalPrice_;

		// Token: 0x04009EA8 RID: 40616
		public const int DiscountPriceFieldNumber = 2;

		// Token: 0x04009EA9 RID: 40617
		private int discountPrice_;

		// Token: 0x04009EAA RID: 40618
		public const int ItemPbInfoFieldNumber = 3;

		// Token: 0x04009EAB RID: 40619
		public const int BdGroupPbInfoFieldNumber = 4;

		// Token: 0x04009EAC RID: 40620
		private object productInfo_;

		// Token: 0x04009EAD RID: 40621
		private TrapDefenseShopProductPbInfo.ProductInfoOneofCase productInfoCase_;

		// Token: 0x020019DD RID: 6621
		public enum ProductInfoOneofCase
		{
			// Token: 0x0400CAAD RID: 51885
			None,
			// Token: 0x0400CAAE RID: 51886
			ItemPbInfo = 3,
			// Token: 0x0400CAAF RID: 51887
			BdGroupPbInfo
		}
	}
}
