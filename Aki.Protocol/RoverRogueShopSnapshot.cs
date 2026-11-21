using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001162 RID: 4450
	public sealed class RoverRogueShopSnapshot : IMessage<RoverRogueShopSnapshot>, IMessage, IEquatable<RoverRogueShopSnapshot>, IDeepCloneable<RoverRogueShopSnapshot>, IBufferMessage
	{
		// Token: 0x06017C7F RID: 97407 RVA: 0x003766F7 File Offset: 0x003748F7
		[NullableContext(1)]
		public static RoverRogueShopSnapshot Create()
		{
			return new RoverRogueShopSnapshot();
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06017C80 RID: 97408 RVA: 0x003766FE File Offset: 0x003748FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x06017C81 RID: 97409 RVA: 0x00376701 File Offset: 0x00374901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopSnapshot.Descriptor;
			}
		}

		// Token: 0x06017C82 RID: 97410 RVA: 0x00376708 File Offset: 0x00374908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot()
		{
		}

		// Token: 0x06017C83 RID: 97411 RVA: 0x00376728 File Offset: 0x00374928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot(RoverRogueShopSnapshot other) : this()
		{
			this.shopConfigId_ = other.shopConfigId_;
			this.goods_ = other.goods_.Clone();
			this.boughtIncIds_ = other.boughtIncIds_.Clone();
			this.refreshCount_ = other.refreshCount_;
			this.nextRefreshCost_ = other.nextRefreshCost_;
			this.maxRefreshCount_ = other.maxRefreshCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C84 RID: 97412 RVA: 0x0037679E File Offset: 0x0037499E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Clone()
		{
			return new RoverRogueShopSnapshot(this);
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x06017C85 RID: 97413 RVA: 0x003767A6 File Offset: 0x003749A6
		// (set) Token: 0x06017C86 RID: 97414 RVA: 0x003767AE File Offset: 0x003749AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopConfigId
		{
			get
			{
				return this.shopConfigId_;
			}
			set
			{
				this.shopConfigId_ = value;
			}
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x06017C87 RID: 97415 RVA: 0x003767B7 File Offset: 0x003749B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueShopGood> Goods
		{
			get
			{
				return this.goods_;
			}
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x06017C88 RID: 97416 RVA: 0x003767BF File Offset: 0x003749BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BoughtIncIds
		{
			get
			{
				return this.boughtIncIds_;
			}
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x06017C89 RID: 97417 RVA: 0x003767C7 File Offset: 0x003749C7
		// (set) Token: 0x06017C8A RID: 97418 RVA: 0x003767CF File Offset: 0x003749CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCount
		{
			get
			{
				return this.refreshCount_;
			}
			set
			{
				this.refreshCount_ = value;
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x06017C8B RID: 97419 RVA: 0x003767D8 File Offset: 0x003749D8
		// (set) Token: 0x06017C8C RID: 97420 RVA: 0x003767E0 File Offset: 0x003749E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextRefreshCost
		{
			get
			{
				return this.nextRefreshCost_;
			}
			set
			{
				this.nextRefreshCost_ = value;
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x06017C8D RID: 97421 RVA: 0x003767E9 File Offset: 0x003749E9
		// (set) Token: 0x06017C8E RID: 97422 RVA: 0x003767F1 File Offset: 0x003749F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxRefreshCount
		{
			get
			{
				return this.maxRefreshCount_;
			}
			set
			{
				this.maxRefreshCount_ = value;
			}
		}

		// Token: 0x06017C8F RID: 97423 RVA: 0x003767FA File Offset: 0x003749FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopSnapshot);
		}

		// Token: 0x06017C90 RID: 97424 RVA: 0x00376808 File Offset: 0x00374A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopSnapshot other)
		{
			return other != null && (other == this || (this.ShopConfigId == other.ShopConfigId && this.goods_.Equals(other.goods_) && this.boughtIncIds_.Equals(other.boughtIncIds_) && this.RefreshCount == other.RefreshCount && this.NextRefreshCost == other.NextRefreshCost && this.MaxRefreshCount == other.MaxRefreshCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C91 RID: 97425 RVA: 0x0037689C File Offset: 0x00374A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopConfigId != 0)
			{
				num ^= this.ShopConfigId.GetHashCode();
			}
			num ^= this.goods_.GetHashCode();
			num ^= this.boughtIncIds_.GetHashCode();
			if (this.RefreshCount != 0)
			{
				num ^= this.RefreshCount.GetHashCode();
			}
			if (this.NextRefreshCost != 0)
			{
				num ^= this.NextRefreshCost.GetHashCode();
			}
			if (this.MaxRefreshCount != 0)
			{
				num ^= this.MaxRefreshCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C92 RID: 97426 RVA: 0x00376942 File Offset: 0x00374B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C93 RID: 97427 RVA: 0x0037694F File Offset: 0x00374B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C94 RID: 97428 RVA: 0x00376958 File Offset: 0x00374B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopConfigId);
			}
			this.goods_.WriteTo(ref output, RoverRogueShopSnapshot._repeated_goods_codec);
			this.boughtIncIds_.WriteTo(ref output, RoverRogueShopSnapshot._repeated_boughtIncIds_codec);
			if (this.RefreshCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RefreshCount);
			}
			if (this.NextRefreshCost != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NextRefreshCost);
			}
			if (this.MaxRefreshCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxRefreshCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C95 RID: 97429 RVA: 0x00376A0C File Offset: 0x00374C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopConfigId);
			}
			num += this.goods_.CalculateSize(RoverRogueShopSnapshot._repeated_goods_codec);
			num += this.boughtIncIds_.CalculateSize(RoverRogueShopSnapshot._repeated_boughtIncIds_codec);
			if (this.RefreshCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCount);
			}
			if (this.NextRefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextRefreshCost);
			}
			if (this.MaxRefreshCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxRefreshCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C96 RID: 97430 RVA: 0x00376AB8 File Offset: 0x00374CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopSnapshot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopConfigId != 0)
			{
				this.ShopConfigId = other.ShopConfigId;
			}
			this.goods_.Add(other.goods_);
			this.boughtIncIds_.Add(other.boughtIncIds_);
			if (other.RefreshCount != 0)
			{
				this.RefreshCount = other.RefreshCount;
			}
			if (other.NextRefreshCost != 0)
			{
				this.NextRefreshCost = other.NextRefreshCost;
			}
			if (other.MaxRefreshCount != 0)
			{
				this.MaxRefreshCount = other.MaxRefreshCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x00376B52 File Offset: 0x00374D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C98 RID: 97432 RVA: 0x00376B5C File Offset: 0x00374D5C
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
						this.ShopConfigId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.goods_.AddEntriesFrom(ref input, RoverRogueShopSnapshot._repeated_goods_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_71;
					}
				}
				else if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_71;
					}
					if (num == 32U)
					{
						this.RefreshCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.NextRefreshCost = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MaxRefreshCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_71:
				this.boughtIncIds_.AddEntriesFrom(ref input, RoverRogueShopSnapshot._repeated_boughtIncIds_codec);
			}
		}

		// Token: 0x04008DE8 RID: 36328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DE9 RID: 36329
		public const int ShopConfigIdFieldNumber = 1;

		// Token: 0x04008DEA RID: 36330
		private int shopConfigId_;

		// Token: 0x04008DEB RID: 36331
		public const int GoodsFieldNumber = 2;

		// Token: 0x04008DEC RID: 36332
		private static readonly FieldCodec<RoverRogueShopGood> _repeated_goods_codec = FieldCodec.ForMessage<RoverRogueShopGood>(18U, RoverRogueShopGood.Parser);

		// Token: 0x04008DED RID: 36333
		private readonly RepeatedField<RoverRogueShopGood> goods_ = new RepeatedField<RoverRogueShopGood>();

		// Token: 0x04008DEE RID: 36334
		public const int BoughtIncIdsFieldNumber = 3;

		// Token: 0x04008DEF RID: 36335
		private static readonly FieldCodec<int> _repeated_boughtIncIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008DF0 RID: 36336
		private readonly RepeatedField<int> boughtIncIds_ = new RepeatedField<int>();

		// Token: 0x04008DF1 RID: 36337
		public const int RefreshCountFieldNumber = 4;

		// Token: 0x04008DF2 RID: 36338
		private int refreshCount_;

		// Token: 0x04008DF3 RID: 36339
		public const int NextRefreshCostFieldNumber = 5;

		// Token: 0x04008DF4 RID: 36340
		private int nextRefreshCost_;

		// Token: 0x04008DF5 RID: 36341
		public const int MaxRefreshCountFieldNumber = 6;

		// Token: 0x04008DF6 RID: 36342
		private int maxRefreshCount_;
	}
}
