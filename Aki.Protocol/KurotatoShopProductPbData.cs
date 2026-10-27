using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C5 RID: 2245
	public sealed class KurotatoShopProductPbData : IMessage<KurotatoShopProductPbData>, IMessage, IEquatable<KurotatoShopProductPbData>, IDeepCloneable<KurotatoShopProductPbData>, IBufferMessage
	{
		// Token: 0x0600C702 RID: 50946 RVA: 0x001D6F40 File Offset: 0x001D5140
		[NullableContext(1)]
		public static KurotatoShopProductPbData Create()
		{
			return new KurotatoShopProductPbData();
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x0600C703 RID: 50947 RVA: 0x001D6F47 File Offset: 0x001D5147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoShopProductPbData> Parser
		{
			get
			{
				return KurotatoShopProductPbData._parser;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x0600C704 RID: 50948 RVA: 0x001D6F4E File Offset: 0x001D514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x0600C705 RID: 50949 RVA: 0x001D6F51 File Offset: 0x001D5151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x001D6F58 File Offset: 0x001D5158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData()
		{
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x001D6F60 File Offset: 0x001D5160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData(KurotatoShopProductPbData other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this.cost_ = other.cost_;
			this.originalCost_ = other.originalCost_;
			this.isLocked_ = other.isLocked_;
			this.isBought_ = other.isBought_;
			KurotatoShopProductPbData.ProductDataOneofCase productDataCase = other.ProductDataCase;
			if (productDataCase != KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
			{
				if (productDataCase == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
				{
					this.WeaponData = other.WeaponData.Clone();
				}
			}
			else
			{
				this.ItemData = other.ItemData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x001D6FF5 File Offset: 0x001D51F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData Clone()
		{
			return new KurotatoShopProductPbData(this);
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600C709 RID: 50953 RVA: 0x001D6FFD File Offset: 0x001D51FD
		// (set) Token: 0x0600C70A RID: 50954 RVA: 0x001D7005 File Offset: 0x001D5205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
		{
			get
			{
				return this.selectionId_;
			}
			set
			{
				this.selectionId_ = value;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600C70B RID: 50955 RVA: 0x001D700E File Offset: 0x001D520E
		// (set) Token: 0x0600C70C RID: 50956 RVA: 0x001D7016 File Offset: 0x001D5216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cost
		{
			get
			{
				return this.cost_;
			}
			set
			{
				this.cost_ = value;
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600C70D RID: 50957 RVA: 0x001D701F File Offset: 0x001D521F
		// (set) Token: 0x0600C70E RID: 50958 RVA: 0x001D7027 File Offset: 0x001D5227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginalCost
		{
			get
			{
				return this.originalCost_;
			}
			set
			{
				this.originalCost_ = value;
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x0600C70F RID: 50959 RVA: 0x001D7030 File Offset: 0x001D5230
		// (set) Token: 0x0600C710 RID: 50960 RVA: 0x001D7038 File Offset: 0x001D5238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLocked
		{
			get
			{
				return this.isLocked_;
			}
			set
			{
				this.isLocked_ = value;
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x0600C711 RID: 50961 RVA: 0x001D7041 File Offset: 0x001D5241
		// (set) Token: 0x0600C712 RID: 50962 RVA: 0x001D7049 File Offset: 0x001D5249
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

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600C713 RID: 50963 RVA: 0x001D7052 File Offset: 0x001D5252
		// (set) Token: 0x0600C714 RID: 50964 RVA: 0x001D706A File Offset: 0x001D526A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopItemProductPbData ItemData
		{
			get
			{
				if (this.productDataCase_ != KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
				{
					return null;
				}
				return (KurotatoShopItemProductPbData)this.productData_;
			}
			set
			{
				this.productData_ = value;
				this.productDataCase_ = ((value == null) ? KurotatoShopProductPbData.ProductDataOneofCase.None : KurotatoShopProductPbData.ProductDataOneofCase.ItemData);
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x0600C715 RID: 50965 RVA: 0x001D7080 File Offset: 0x001D5280
		// (set) Token: 0x0600C716 RID: 50966 RVA: 0x001D7098 File Offset: 0x001D5298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData WeaponData
		{
			get
			{
				if (this.productDataCase_ != KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
				{
					return null;
				}
				return (KurotatoShopWeaponProductPbData)this.productData_;
			}
			set
			{
				this.productData_ = value;
				this.productDataCase_ = ((value == null) ? KurotatoShopProductPbData.ProductDataOneofCase.None : KurotatoShopProductPbData.ProductDataOneofCase.WeaponData);
			}
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x0600C717 RID: 50967 RVA: 0x001D70AE File Offset: 0x001D52AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData.ProductDataOneofCase ProductDataCase
		{
			get
			{
				return this.productDataCase_;
			}
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x001D70B6 File Offset: 0x001D52B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProductData()
		{
			this.productDataCase_ = KurotatoShopProductPbData.ProductDataOneofCase.None;
			this.productData_ = null;
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x001D70C6 File Offset: 0x001D52C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopProductPbData);
		}

		// Token: 0x0600C71A RID: 50970 RVA: 0x001D70D4 File Offset: 0x001D52D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopProductPbData other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && this.Cost == other.Cost && this.OriginalCost == other.OriginalCost && this.IsLocked == other.IsLocked && this.IsBought == other.IsBought && object.Equals(this.ItemData, other.ItemData) && object.Equals(this.WeaponData, other.WeaponData) && this.ProductDataCase == other.ProductDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x001D7188 File Offset: 0x001D5388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectionId != 0)
			{
				num ^= this.SelectionId.GetHashCode();
			}
			if (this.Cost != 0)
			{
				num ^= this.Cost.GetHashCode();
			}
			if (this.OriginalCost != 0)
			{
				num ^= this.OriginalCost.GetHashCode();
			}
			if (this.IsLocked)
			{
				num ^= this.IsLocked.GetHashCode();
			}
			if (this.IsBought)
			{
				num ^= this.IsBought.GetHashCode();
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
			{
				num ^= this.ItemData.GetHashCode();
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
			{
				num ^= this.WeaponData.GetHashCode();
			}
			num ^= (int)this.productDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x001D7262 File Offset: 0x001D5462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x001D726F File Offset: 0x001D546F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x001D7278 File Offset: 0x001D5478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SelectionId);
			}
			if (this.Cost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Cost);
			}
			if (this.OriginalCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OriginalCost);
			}
			if (this.IsLocked)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsLocked);
			}
			if (this.IsBought)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsBought);
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ItemData);
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.WeaponData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x001D7360 File Offset: 0x001D5560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectionId);
			}
			if (this.Cost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cost);
			}
			if (this.OriginalCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginalCost);
			}
			if (this.IsLocked)
			{
				num += 2;
			}
			if (this.IsBought)
			{
				num += 2;
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemData);
			}
			if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x001D7418 File Offset: 0x001D5618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopProductPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectionId != 0)
			{
				this.SelectionId = other.SelectionId;
			}
			if (other.Cost != 0)
			{
				this.Cost = other.Cost;
			}
			if (other.OriginalCost != 0)
			{
				this.OriginalCost = other.OriginalCost;
			}
			if (other.IsLocked)
			{
				this.IsLocked = other.IsLocked;
			}
			if (other.IsBought)
			{
				this.IsBought = other.IsBought;
			}
			KurotatoShopProductPbData.ProductDataOneofCase productDataCase = other.ProductDataCase;
			if (productDataCase != KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
			{
				if (productDataCase == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
				{
					if (this.WeaponData == null)
					{
						this.WeaponData = new KurotatoShopWeaponProductPbData();
					}
					this.WeaponData.MergeFrom(other.WeaponData);
				}
			}
			else
			{
				if (this.ItemData == null)
				{
					this.ItemData = new KurotatoShopItemProductPbData();
				}
				this.ItemData.MergeFrom(other.ItemData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x001D74FF File Offset: 0x001D56FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x001D7508 File Offset: 0x001D5708
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
						this.SelectionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Cost = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.OriginalCost = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.IsLocked = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsBought = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						KurotatoShopItemProductPbData kurotatoShopItemProductPbData = new KurotatoShopItemProductPbData();
						if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.ItemData)
						{
							kurotatoShopItemProductPbData.MergeFrom(this.ItemData);
						}
						input.ReadMessage(kurotatoShopItemProductPbData);
						this.ItemData = kurotatoShopItemProductPbData;
						continue;
					}
					if (num == 58U)
					{
						KurotatoShopWeaponProductPbData kurotatoShopWeaponProductPbData = new KurotatoShopWeaponProductPbData();
						if (this.productDataCase_ == KurotatoShopProductPbData.ProductDataOneofCase.WeaponData)
						{
							kurotatoShopWeaponProductPbData.MergeFrom(this.WeaponData);
						}
						input.ReadMessage(kurotatoShopWeaponProductPbData);
						this.WeaponData = kurotatoShopWeaponProductPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400555F RID: 21855
		private static readonly MessageParser<KurotatoShopProductPbData> _parser = new MessageParser<KurotatoShopProductPbData>(() => new KurotatoShopProductPbData());

		// Token: 0x04005560 RID: 21856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005561 RID: 21857
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x04005562 RID: 21858
		private int selectionId_;

		// Token: 0x04005563 RID: 21859
		public const int CostFieldNumber = 2;

		// Token: 0x04005564 RID: 21860
		private int cost_;

		// Token: 0x04005565 RID: 21861
		public const int OriginalCostFieldNumber = 3;

		// Token: 0x04005566 RID: 21862
		private int originalCost_;

		// Token: 0x04005567 RID: 21863
		public const int IsLockedFieldNumber = 4;

		// Token: 0x04005568 RID: 21864
		private bool isLocked_;

		// Token: 0x04005569 RID: 21865
		public const int IsBoughtFieldNumber = 5;

		// Token: 0x0400556A RID: 21866
		private bool isBought_;

		// Token: 0x0400556B RID: 21867
		public const int ItemDataFieldNumber = 6;

		// Token: 0x0400556C RID: 21868
		public const int WeaponDataFieldNumber = 7;

		// Token: 0x0400556D RID: 21869
		private object productData_;

		// Token: 0x0400556E RID: 21870
		private KurotatoShopProductPbData.ProductDataOneofCase productDataCase_;

		// Token: 0x02001812 RID: 6162
		public enum ProductDataOneofCase
		{
			// Token: 0x0400C7C3 RID: 51139
			None,
			// Token: 0x0400C7C4 RID: 51140
			ItemData = 6,
			// Token: 0x0400C7C5 RID: 51141
			WeaponData
		}
	}
}
