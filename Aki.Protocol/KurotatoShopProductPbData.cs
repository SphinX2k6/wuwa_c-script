using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B4 RID: 2228
	public sealed class KurotatoShopProductPbData : IMessage<KurotatoShopProductPbData>, IMessage, IEquatable<KurotatoShopProductPbData>, IDeepCloneable<KurotatoShopProductPbData>, IBufferMessage
	{
		// Token: 0x0600C5E6 RID: 50662 RVA: 0x001D4C54 File Offset: 0x001D2E54
		[NullableContext(1)]
		public static KurotatoShopProductPbData Create()
		{
			return new KurotatoShopProductPbData();
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x001D4C5B File Offset: 0x001D2E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoShopProductPbData> Parser
		{
			get
			{
				return KurotatoShopProductPbData._parser;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600C5E8 RID: 50664 RVA: 0x001D4C62 File Offset: 0x001D2E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x001D4C65 File Offset: 0x001D2E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x001D4C6C File Offset: 0x001D2E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData()
		{
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x001D4C74 File Offset: 0x001D2E74
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

		// Token: 0x0600C5EC RID: 50668 RVA: 0x001D4D09 File Offset: 0x001D2F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData Clone()
		{
			return new KurotatoShopProductPbData(this);
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x001D4D11 File Offset: 0x001D2F11
		// (set) Token: 0x0600C5EE RID: 50670 RVA: 0x001D4D19 File Offset: 0x001D2F19
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

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x0600C5EF RID: 50671 RVA: 0x001D4D22 File Offset: 0x001D2F22
		// (set) Token: 0x0600C5F0 RID: 50672 RVA: 0x001D4D2A File Offset: 0x001D2F2A
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

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x001D4D33 File Offset: 0x001D2F33
		// (set) Token: 0x0600C5F2 RID: 50674 RVA: 0x001D4D3B File Offset: 0x001D2F3B
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

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x001D4D44 File Offset: 0x001D2F44
		// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x001D4D4C File Offset: 0x001D2F4C
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

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x001D4D55 File Offset: 0x001D2F55
		// (set) Token: 0x0600C5F6 RID: 50678 RVA: 0x001D4D5D File Offset: 0x001D2F5D
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

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600C5F7 RID: 50679 RVA: 0x001D4D66 File Offset: 0x001D2F66
		// (set) Token: 0x0600C5F8 RID: 50680 RVA: 0x001D4D7E File Offset: 0x001D2F7E
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

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x0600C5F9 RID: 50681 RVA: 0x001D4D94 File Offset: 0x001D2F94
		// (set) Token: 0x0600C5FA RID: 50682 RVA: 0x001D4DAC File Offset: 0x001D2FAC
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

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600C5FB RID: 50683 RVA: 0x001D4DC2 File Offset: 0x001D2FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopProductPbData.ProductDataOneofCase ProductDataCase
		{
			get
			{
				return this.productDataCase_;
			}
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x001D4DCA File Offset: 0x001D2FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProductData()
		{
			this.productDataCase_ = KurotatoShopProductPbData.ProductDataOneofCase.None;
			this.productData_ = null;
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x001D4DDA File Offset: 0x001D2FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopProductPbData);
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x001D4DE8 File Offset: 0x001D2FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopProductPbData other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && this.Cost == other.Cost && this.OriginalCost == other.OriginalCost && this.IsLocked == other.IsLocked && this.IsBought == other.IsBought && object.Equals(this.ItemData, other.ItemData) && object.Equals(this.WeaponData, other.WeaponData) && this.ProductDataCase == other.ProductDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x001D4E9C File Offset: 0x001D309C
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

		// Token: 0x0600C600 RID: 50688 RVA: 0x001D4F76 File Offset: 0x001D3176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x001D4F83 File Offset: 0x001D3183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x001D4F8C File Offset: 0x001D318C
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

		// Token: 0x0600C603 RID: 50691 RVA: 0x001D5074 File Offset: 0x001D3274
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

		// Token: 0x0600C604 RID: 50692 RVA: 0x001D512C File Offset: 0x001D332C
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

		// Token: 0x0600C605 RID: 50693 RVA: 0x001D5213 File Offset: 0x001D3413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x001D521C File Offset: 0x001D341C
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

		// Token: 0x04005566 RID: 21862
		private static readonly MessageParser<KurotatoShopProductPbData> _parser = new MessageParser<KurotatoShopProductPbData>(() => new KurotatoShopProductPbData());

		// Token: 0x04005567 RID: 21863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005568 RID: 21864
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x04005569 RID: 21865
		private int selectionId_;

		// Token: 0x0400556A RID: 21866
		public const int CostFieldNumber = 2;

		// Token: 0x0400556B RID: 21867
		private int cost_;

		// Token: 0x0400556C RID: 21868
		public const int OriginalCostFieldNumber = 3;

		// Token: 0x0400556D RID: 21869
		private int originalCost_;

		// Token: 0x0400556E RID: 21870
		public const int IsLockedFieldNumber = 4;

		// Token: 0x0400556F RID: 21871
		private bool isLocked_;

		// Token: 0x04005570 RID: 21872
		public const int IsBoughtFieldNumber = 5;

		// Token: 0x04005571 RID: 21873
		private bool isBought_;

		// Token: 0x04005572 RID: 21874
		public const int ItemDataFieldNumber = 6;

		// Token: 0x04005573 RID: 21875
		public const int WeaponDataFieldNumber = 7;

		// Token: 0x04005574 RID: 21876
		private object productData_;

		// Token: 0x04005575 RID: 21877
		private KurotatoShopProductPbData.ProductDataOneofCase productDataCase_;

		// Token: 0x0200188A RID: 6282
		public enum ProductDataOneofCase
		{
			// Token: 0x0400CCEE RID: 52462
			None,
			// Token: 0x0400CCEF RID: 52463
			ItemData = 6,
			// Token: 0x0400CCF0 RID: 52464
			WeaponData
		}
	}
}
