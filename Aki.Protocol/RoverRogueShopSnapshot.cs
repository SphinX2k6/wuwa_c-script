using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001128 RID: 4392
	public sealed class RoverRogueShopSnapshot : IMessage<RoverRogueShopSnapshot>, IMessage, IEquatable<RoverRogueShopSnapshot>, IDeepCloneable<RoverRogueShopSnapshot>, IBufferMessage
	{
		// Token: 0x060176DE RID: 95966 RVA: 0x003673AB File Offset: 0x003655AB
		[NullableContext(1)]
		public static RoverRogueShopSnapshot Create()
		{
			return new RoverRogueShopSnapshot();
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x060176DF RID: 95967 RVA: 0x003673B2 File Offset: 0x003655B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x060176E0 RID: 95968 RVA: 0x003673B5 File Offset: 0x003655B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopSnapshot.Descriptor;
			}
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x003673BC File Offset: 0x003655BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot()
		{
		}

		// Token: 0x060176E2 RID: 95970 RVA: 0x003673DC File Offset: 0x003655DC
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

		// Token: 0x060176E3 RID: 95971 RVA: 0x00367452 File Offset: 0x00365652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Clone()
		{
			return new RoverRogueShopSnapshot(this);
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x060176E4 RID: 95972 RVA: 0x0036745A File Offset: 0x0036565A
		// (set) Token: 0x060176E5 RID: 95973 RVA: 0x00367462 File Offset: 0x00365662
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

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x060176E6 RID: 95974 RVA: 0x0036746B File Offset: 0x0036566B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueShopGood> Goods
		{
			get
			{
				return this.goods_;
			}
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x060176E7 RID: 95975 RVA: 0x00367473 File Offset: 0x00365673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BoughtIncIds
		{
			get
			{
				return this.boughtIncIds_;
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x060176E8 RID: 95976 RVA: 0x0036747B File Offset: 0x0036567B
		// (set) Token: 0x060176E9 RID: 95977 RVA: 0x00367483 File Offset: 0x00365683
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

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x060176EA RID: 95978 RVA: 0x0036748C File Offset: 0x0036568C
		// (set) Token: 0x060176EB RID: 95979 RVA: 0x00367494 File Offset: 0x00365694
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

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x060176EC RID: 95980 RVA: 0x0036749D File Offset: 0x0036569D
		// (set) Token: 0x060176ED RID: 95981 RVA: 0x003674A5 File Offset: 0x003656A5
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

		// Token: 0x060176EE RID: 95982 RVA: 0x003674AE File Offset: 0x003656AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopSnapshot);
		}

		// Token: 0x060176EF RID: 95983 RVA: 0x003674BC File Offset: 0x003656BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopSnapshot other)
		{
			return other != null && (other == this || (this.ShopConfigId == other.ShopConfigId && this.goods_.Equals(other.goods_) && this.boughtIncIds_.Equals(other.boughtIncIds_) && this.RefreshCount == other.RefreshCount && this.NextRefreshCost == other.NextRefreshCost && this.MaxRefreshCount == other.MaxRefreshCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176F0 RID: 95984 RVA: 0x00367550 File Offset: 0x00365750
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

		// Token: 0x060176F1 RID: 95985 RVA: 0x003675F6 File Offset: 0x003657F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176F2 RID: 95986 RVA: 0x00367603 File Offset: 0x00365803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176F3 RID: 95987 RVA: 0x0036760C File Offset: 0x0036580C
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

		// Token: 0x060176F4 RID: 95988 RVA: 0x003676C0 File Offset: 0x003658C0
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

		// Token: 0x060176F5 RID: 95989 RVA: 0x0036776C File Offset: 0x0036596C
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

		// Token: 0x060176F6 RID: 95990 RVA: 0x00367806 File Offset: 0x00365A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x00367810 File Offset: 0x00365A10
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

		// Token: 0x04008B55 RID: 35669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B56 RID: 35670
		public const int ShopConfigIdFieldNumber = 1;

		// Token: 0x04008B57 RID: 35671
		private int shopConfigId_;

		// Token: 0x04008B58 RID: 35672
		public const int GoodsFieldNumber = 2;

		// Token: 0x04008B59 RID: 35673
		private static readonly FieldCodec<RoverRogueShopGood> _repeated_goods_codec = FieldCodec.ForMessage<RoverRogueShopGood>(18U, RoverRogueShopGood.Parser);

		// Token: 0x04008B5A RID: 35674
		private readonly RepeatedField<RoverRogueShopGood> goods_ = new RepeatedField<RoverRogueShopGood>();

		// Token: 0x04008B5B RID: 35675
		public const int BoughtIncIdsFieldNumber = 3;

		// Token: 0x04008B5C RID: 35676
		private static readonly FieldCodec<int> _repeated_boughtIncIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008B5D RID: 35677
		private readonly RepeatedField<int> boughtIncIds_ = new RepeatedField<int>();

		// Token: 0x04008B5E RID: 35678
		public const int RefreshCountFieldNumber = 4;

		// Token: 0x04008B5F RID: 35679
		private int refreshCount_;

		// Token: 0x04008B60 RID: 35680
		public const int NextRefreshCostFieldNumber = 5;

		// Token: 0x04008B61 RID: 35681
		private int nextRefreshCost_;

		// Token: 0x04008B62 RID: 35682
		public const int MaxRefreshCountFieldNumber = 6;

		// Token: 0x04008B63 RID: 35683
		private int maxRefreshCount_;
	}
}
