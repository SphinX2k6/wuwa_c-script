using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001123 RID: 4387
	public sealed class RoverRogueShopGood : IMessage<RoverRogueShopGood>, IMessage, IEquatable<RoverRogueShopGood>, IDeepCloneable<RoverRogueShopGood>, IBufferMessage
	{
		// Token: 0x0601766E RID: 95854 RVA: 0x003662C9 File Offset: 0x003644C9
		[NullableContext(1)]
		public static RoverRogueShopGood Create()
		{
			return new RoverRogueShopGood();
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x0601766F RID: 95855 RVA: 0x003662D0 File Offset: 0x003644D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueShopGood> Parser
		{
			get
			{
				return RoverRogueShopGood._parser;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x06017670 RID: 95856 RVA: 0x003662D7 File Offset: 0x003644D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x06017671 RID: 95857 RVA: 0x003662DA File Offset: 0x003644DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopGood.Descriptor;
			}
		}

		// Token: 0x06017672 RID: 95858 RVA: 0x003662E1 File Offset: 0x003644E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopGood()
		{
		}

		// Token: 0x06017673 RID: 95859 RVA: 0x003662EC File Offset: 0x003644EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopGood(RoverRogueShopGood other) : this()
		{
			this.incId_ = other.incId_;
			this.shopItemId_ = other.shopItemId_;
			this.runtimeParam_ = other.runtimeParam_;
			this.finalPrice_ = other.finalPrice_;
			this.price_ = other.price_;
			this.isBought_ = other.isBought_;
			this.showItemId_ = other.showItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017674 RID: 95860 RVA: 0x00366364 File Offset: 0x00364564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopGood Clone()
		{
			return new RoverRogueShopGood(this);
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x06017675 RID: 95861 RVA: 0x0036636C File Offset: 0x0036456C
		// (set) Token: 0x06017676 RID: 95862 RVA: 0x00366374 File Offset: 0x00364574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x06017677 RID: 95863 RVA: 0x0036637D File Offset: 0x0036457D
		// (set) Token: 0x06017678 RID: 95864 RVA: 0x00366385 File Offset: 0x00364585
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

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x06017679 RID: 95865 RVA: 0x0036638E File Offset: 0x0036458E
		// (set) Token: 0x0601767A RID: 95866 RVA: 0x00366396 File Offset: 0x00364596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RuntimeParam
		{
			get
			{
				return this.runtimeParam_;
			}
			set
			{
				this.runtimeParam_ = value;
			}
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x0601767B RID: 95867 RVA: 0x0036639F File Offset: 0x0036459F
		// (set) Token: 0x0601767C RID: 95868 RVA: 0x003663A7 File Offset: 0x003645A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinalPrice
		{
			get
			{
				return this.finalPrice_;
			}
			set
			{
				this.finalPrice_ = value;
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x0601767D RID: 95869 RVA: 0x003663B0 File Offset: 0x003645B0
		// (set) Token: 0x0601767E RID: 95870 RVA: 0x003663B8 File Offset: 0x003645B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Price
		{
			get
			{
				return this.price_;
			}
			set
			{
				this.price_ = value;
			}
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x0601767F RID: 95871 RVA: 0x003663C1 File Offset: 0x003645C1
		// (set) Token: 0x06017680 RID: 95872 RVA: 0x003663C9 File Offset: 0x003645C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBought
		{
			get
			{
				return this.isBought_;
			}
			set
			{
				this.isBought_ = value;
			}
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x06017681 RID: 95873 RVA: 0x003663D2 File Offset: 0x003645D2
		// (set) Token: 0x06017682 RID: 95874 RVA: 0x003663DA File Offset: 0x003645DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowItemId
		{
			get
			{
				return this.showItemId_;
			}
			set
			{
				this.showItemId_ = value;
			}
		}

		// Token: 0x06017683 RID: 95875 RVA: 0x003663E3 File Offset: 0x003645E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopGood);
		}

		// Token: 0x06017684 RID: 95876 RVA: 0x003663F4 File Offset: 0x003645F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopGood other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ShopItemId == other.ShopItemId && this.RuntimeParam == other.RuntimeParam && this.FinalPrice == other.FinalPrice && this.Price == other.Price && this.IsBought == other.IsBought && this.ShowItemId == other.ShowItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017685 RID: 95877 RVA: 0x00366490 File Offset: 0x00364690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ShopItemId != 0)
			{
				num ^= this.ShopItemId.GetHashCode();
			}
			if (this.RuntimeParam != 0)
			{
				num ^= this.RuntimeParam.GetHashCode();
			}
			if (this.FinalPrice != 0)
			{
				num ^= this.FinalPrice.GetHashCode();
			}
			if (this.Price != 0)
			{
				num ^= this.Price.GetHashCode();
			}
			if (this.IsBought)
			{
				num ^= this.IsBought.GetHashCode();
			}
			if (this.ShowItemId != 0)
			{
				num ^= this.ShowItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017686 RID: 95878 RVA: 0x00366565 File Offset: 0x00364765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017687 RID: 95879 RVA: 0x00366572 File Offset: 0x00364772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017688 RID: 95880 RVA: 0x0036657C File Offset: 0x0036477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.ShopItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ShopItemId);
			}
			if (this.RuntimeParam != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RuntimeParam);
			}
			if (this.FinalPrice != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FinalPrice);
			}
			if (this.Price != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Price);
			}
			if (this.IsBought)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsBought);
			}
			if (this.ShowItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ShowItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017689 RID: 95881 RVA: 0x00366660 File Offset: 0x00364860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ShopItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopItemId);
			}
			if (this.RuntimeParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RuntimeParam);
			}
			if (this.FinalPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinalPrice);
			}
			if (this.Price != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Price);
			}
			if (this.IsBought)
			{
				num += 2;
			}
			if (this.ShowItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601768A RID: 95882 RVA: 0x00366724 File Offset: 0x00364924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopGood other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ShopItemId != 0)
			{
				this.ShopItemId = other.ShopItemId;
			}
			if (other.RuntimeParam != 0)
			{
				this.RuntimeParam = other.RuntimeParam;
			}
			if (other.FinalPrice != 0)
			{
				this.FinalPrice = other.FinalPrice;
			}
			if (other.Price != 0)
			{
				this.Price = other.Price;
			}
			if (other.IsBought)
			{
				this.IsBought = other.IsBought;
			}
			if (other.ShowItemId != 0)
			{
				this.ShowItemId = other.ShowItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601768B RID: 95883 RVA: 0x003667D8 File Offset: 0x003649D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601768C RID: 95884 RVA: 0x003667E4 File Offset: 0x003649E4
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
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ShopItemId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.RuntimeParam = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.FinalPrice = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Price = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.IsBought = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.ShowItemId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B31 RID: 35633
		private static readonly MessageParser<RoverRogueShopGood> _parser = new MessageParser<RoverRogueShopGood>(() => new RoverRogueShopGood());

		// Token: 0x04008B32 RID: 35634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B33 RID: 35635
		public const int IncIdFieldNumber = 1;

		// Token: 0x04008B34 RID: 35636
		private int incId_;

		// Token: 0x04008B35 RID: 35637
		public const int ShopItemIdFieldNumber = 2;

		// Token: 0x04008B36 RID: 35638
		private int shopItemId_;

		// Token: 0x04008B37 RID: 35639
		public const int RuntimeParamFieldNumber = 3;

		// Token: 0x04008B38 RID: 35640
		private int runtimeParam_;

		// Token: 0x04008B39 RID: 35641
		public const int FinalPriceFieldNumber = 4;

		// Token: 0x04008B3A RID: 35642
		private int finalPrice_;

		// Token: 0x04008B3B RID: 35643
		public const int PriceFieldNumber = 5;

		// Token: 0x04008B3C RID: 35644
		private int price_;

		// Token: 0x04008B3D RID: 35645
		public const int IsBoughtFieldNumber = 6;

		// Token: 0x04008B3E RID: 35646
		private bool isBought_;

		// Token: 0x04008B3F RID: 35647
		public const int ShowItemIdFieldNumber = 7;

		// Token: 0x04008B40 RID: 35648
		private int showItemId_;
	}
}
