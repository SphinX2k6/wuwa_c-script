using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BC RID: 5308
	public sealed class TrapDefenseShopProductPbInfo : IMessage<TrapDefenseShopProductPbInfo>, IMessage, IEquatable<TrapDefenseShopProductPbInfo>, IDeepCloneable<TrapDefenseShopProductPbInfo>, IBufferMessage
	{
		// Token: 0x0601C297 RID: 115351 RVA: 0x00416784 File Offset: 0x00414984
		[NullableContext(1)]
		public static TrapDefenseShopProductPbInfo Create()
		{
			return new TrapDefenseShopProductPbInfo();
		}

		// Token: 0x17005F51 RID: 24401
		// (get) Token: 0x0601C298 RID: 115352 RVA: 0x0041678B File Offset: 0x0041498B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseShopProductPbInfo> Parser
		{
			get
			{
				return TrapDefenseShopProductPbInfo._parser;
			}
		}

		// Token: 0x17005F52 RID: 24402
		// (get) Token: 0x0601C299 RID: 115353 RVA: 0x00416792 File Offset: 0x00414992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F53 RID: 24403
		// (get) Token: 0x0601C29A RID: 115354 RVA: 0x00416795 File Offset: 0x00414995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseShopProductPbInfo.Descriptor;
			}
		}

		// Token: 0x0601C29B RID: 115355 RVA: 0x0041679C File Offset: 0x0041499C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo()
		{
		}

		// Token: 0x0601C29C RID: 115356 RVA: 0x004167A4 File Offset: 0x004149A4
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

		// Token: 0x0601C29D RID: 115357 RVA: 0x00416815 File Offset: 0x00414A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo Clone()
		{
			return new TrapDefenseShopProductPbInfo(this);
		}

		// Token: 0x17005F54 RID: 24404
		// (get) Token: 0x0601C29E RID: 115358 RVA: 0x0041681D File Offset: 0x00414A1D
		// (set) Token: 0x0601C29F RID: 115359 RVA: 0x00416825 File Offset: 0x00414A25
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

		// Token: 0x17005F55 RID: 24405
		// (get) Token: 0x0601C2A0 RID: 115360 RVA: 0x0041682E File Offset: 0x00414A2E
		// (set) Token: 0x0601C2A1 RID: 115361 RVA: 0x00416836 File Offset: 0x00414A36
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

		// Token: 0x17005F56 RID: 24406
		// (get) Token: 0x0601C2A2 RID: 115362 RVA: 0x0041683F File Offset: 0x00414A3F
		// (set) Token: 0x0601C2A3 RID: 115363 RVA: 0x00416857 File Offset: 0x00414A57
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

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x0601C2A4 RID: 115364 RVA: 0x0041686D File Offset: 0x00414A6D
		// (set) Token: 0x0601C2A5 RID: 115365 RVA: 0x00416885 File Offset: 0x00414A85
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

		// Token: 0x17005F58 RID: 24408
		// (get) Token: 0x0601C2A6 RID: 115366 RVA: 0x0041689B File Offset: 0x00414A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopProductPbInfo.ProductInfoOneofCase ProductInfoCase
		{
			get
			{
				return this.productInfoCase_;
			}
		}

		// Token: 0x0601C2A7 RID: 115367 RVA: 0x004168A3 File Offset: 0x00414AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProductInfo()
		{
			this.productInfoCase_ = TrapDefenseShopProductPbInfo.ProductInfoOneofCase.None;
			this.productInfo_ = null;
		}

		// Token: 0x0601C2A8 RID: 115368 RVA: 0x004168B3 File Offset: 0x00414AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseShopProductPbInfo);
		}

		// Token: 0x0601C2A9 RID: 115369 RVA: 0x004168C4 File Offset: 0x00414AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseShopProductPbInfo other)
		{
			return other != null && (other == this || (this.OriginalPrice == other.OriginalPrice && this.DiscountPrice == other.DiscountPrice && object.Equals(this.ItemPbInfo, other.ItemPbInfo) && object.Equals(this.BdGroupPbInfo, other.BdGroupPbInfo) && this.ProductInfoCase == other.ProductInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2AA RID: 115370 RVA: 0x00416948 File Offset: 0x00414B48
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

		// Token: 0x0601C2AB RID: 115371 RVA: 0x004169D7 File Offset: 0x00414BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2AC RID: 115372 RVA: 0x004169E4 File Offset: 0x00414BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2AD RID: 115373 RVA: 0x004169F0 File Offset: 0x00414BF0
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

		// Token: 0x0601C2AE RID: 115374 RVA: 0x00416A84 File Offset: 0x00414C84
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

		// Token: 0x0601C2AF RID: 115375 RVA: 0x00416B0C File Offset: 0x00414D0C
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

		// Token: 0x0601C2B0 RID: 115376 RVA: 0x00416BB7 File Offset: 0x00414DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2B1 RID: 115377 RVA: 0x00416BC0 File Offset: 0x00414DC0
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

		// Token: 0x0400A2EB RID: 41707
		private static readonly MessageParser<TrapDefenseShopProductPbInfo> _parser = new MessageParser<TrapDefenseShopProductPbInfo>(() => new TrapDefenseShopProductPbInfo());

		// Token: 0x0400A2EC RID: 41708
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2ED RID: 41709
		public const int OriginalPriceFieldNumber = 1;

		// Token: 0x0400A2EE RID: 41710
		private int originalPrice_;

		// Token: 0x0400A2EF RID: 41711
		public const int DiscountPriceFieldNumber = 2;

		// Token: 0x0400A2F0 RID: 41712
		private int discountPrice_;

		// Token: 0x0400A2F1 RID: 41713
		public const int ItemPbInfoFieldNumber = 3;

		// Token: 0x0400A2F2 RID: 41714
		public const int BdGroupPbInfoFieldNumber = 4;

		// Token: 0x0400A2F3 RID: 41715
		private object productInfo_;

		// Token: 0x0400A2F4 RID: 41716
		private TrapDefenseShopProductPbInfo.ProductInfoOneofCase productInfoCase_;

		// Token: 0x02001A7F RID: 6783
		public enum ProductInfoOneofCase
		{
			// Token: 0x0400D018 RID: 53272
			None,
			// Token: 0x0400D019 RID: 53273
			ItemPbInfo = 3,
			// Token: 0x0400D01A RID: 53274
			BdGroupPbInfo
		}
	}
}
