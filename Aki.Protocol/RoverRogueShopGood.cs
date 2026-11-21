using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115D RID: 4445
	public sealed class RoverRogueShopGood : IMessage<RoverRogueShopGood>, IMessage, IEquatable<RoverRogueShopGood>, IDeepCloneable<RoverRogueShopGood>, IBufferMessage
	{
		// Token: 0x06017C0F RID: 97295 RVA: 0x00375615 File Offset: 0x00373815
		[NullableContext(1)]
		public static RoverRogueShopGood Create()
		{
			return new RoverRogueShopGood();
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x06017C10 RID: 97296 RVA: 0x0037561C File Offset: 0x0037381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueShopGood> Parser
		{
			get
			{
				return RoverRogueShopGood._parser;
			}
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x06017C11 RID: 97297 RVA: 0x00375623 File Offset: 0x00373823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x06017C12 RID: 97298 RVA: 0x00375626 File Offset: 0x00373826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopGood.Descriptor;
			}
		}

		// Token: 0x06017C13 RID: 97299 RVA: 0x0037562D File Offset: 0x0037382D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopGood()
		{
		}

		// Token: 0x06017C14 RID: 97300 RVA: 0x00375638 File Offset: 0x00373838
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

		// Token: 0x06017C15 RID: 97301 RVA: 0x003756B0 File Offset: 0x003738B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopGood Clone()
		{
			return new RoverRogueShopGood(this);
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x06017C16 RID: 97302 RVA: 0x003756B8 File Offset: 0x003738B8
		// (set) Token: 0x06017C17 RID: 97303 RVA: 0x003756C0 File Offset: 0x003738C0
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

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x06017C18 RID: 97304 RVA: 0x003756C9 File Offset: 0x003738C9
		// (set) Token: 0x06017C19 RID: 97305 RVA: 0x003756D1 File Offset: 0x003738D1
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

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x06017C1A RID: 97306 RVA: 0x003756DA File Offset: 0x003738DA
		// (set) Token: 0x06017C1B RID: 97307 RVA: 0x003756E2 File Offset: 0x003738E2
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

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x06017C1C RID: 97308 RVA: 0x003756EB File Offset: 0x003738EB
		// (set) Token: 0x06017C1D RID: 97309 RVA: 0x003756F3 File Offset: 0x003738F3
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

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x06017C1E RID: 97310 RVA: 0x003756FC File Offset: 0x003738FC
		// (set) Token: 0x06017C1F RID: 97311 RVA: 0x00375704 File Offset: 0x00373904
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

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x06017C20 RID: 97312 RVA: 0x0037570D File Offset: 0x0037390D
		// (set) Token: 0x06017C21 RID: 97313 RVA: 0x00375715 File Offset: 0x00373915
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

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x06017C22 RID: 97314 RVA: 0x0037571E File Offset: 0x0037391E
		// (set) Token: 0x06017C23 RID: 97315 RVA: 0x00375726 File Offset: 0x00373926
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

		// Token: 0x06017C24 RID: 97316 RVA: 0x0037572F File Offset: 0x0037392F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopGood);
		}

		// Token: 0x06017C25 RID: 97317 RVA: 0x00375740 File Offset: 0x00373940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopGood other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ShopItemId == other.ShopItemId && this.RuntimeParam == other.RuntimeParam && this.FinalPrice == other.FinalPrice && this.Price == other.Price && this.IsBought == other.IsBought && this.ShowItemId == other.ShowItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C26 RID: 97318 RVA: 0x003757DC File Offset: 0x003739DC
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

		// Token: 0x06017C27 RID: 97319 RVA: 0x003758B1 File Offset: 0x00373AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C28 RID: 97320 RVA: 0x003758BE File Offset: 0x00373ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C29 RID: 97321 RVA: 0x003758C8 File Offset: 0x00373AC8
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

		// Token: 0x06017C2A RID: 97322 RVA: 0x003759AC File Offset: 0x00373BAC
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

		// Token: 0x06017C2B RID: 97323 RVA: 0x00375A70 File Offset: 0x00373C70
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

		// Token: 0x06017C2C RID: 97324 RVA: 0x00375B24 File Offset: 0x00373D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C2D RID: 97325 RVA: 0x00375B30 File Offset: 0x00373D30
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

		// Token: 0x04008DC4 RID: 36292
		private static readonly MessageParser<RoverRogueShopGood> _parser = new MessageParser<RoverRogueShopGood>(() => new RoverRogueShopGood());

		// Token: 0x04008DC5 RID: 36293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DC6 RID: 36294
		public const int IncIdFieldNumber = 1;

		// Token: 0x04008DC7 RID: 36295
		private int incId_;

		// Token: 0x04008DC8 RID: 36296
		public const int ShopItemIdFieldNumber = 2;

		// Token: 0x04008DC9 RID: 36297
		private int shopItemId_;

		// Token: 0x04008DCA RID: 36298
		public const int RuntimeParamFieldNumber = 3;

		// Token: 0x04008DCB RID: 36299
		private int runtimeParam_;

		// Token: 0x04008DCC RID: 36300
		public const int FinalPriceFieldNumber = 4;

		// Token: 0x04008DCD RID: 36301
		private int finalPrice_;

		// Token: 0x04008DCE RID: 36302
		public const int PriceFieldNumber = 5;

		// Token: 0x04008DCF RID: 36303
		private int price_;

		// Token: 0x04008DD0 RID: 36304
		public const int IsBoughtFieldNumber = 6;

		// Token: 0x04008DD1 RID: 36305
		private bool isBought_;

		// Token: 0x04008DD2 RID: 36306
		public const int ShowItemIdFieldNumber = 7;

		// Token: 0x04008DD3 RID: 36307
		private int showItemId_;
	}
}
