using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088B RID: 2187
	public sealed class KurotatoItemRewardPanelPbData : IMessage<KurotatoItemRewardPanelPbData>, IMessage, IEquatable<KurotatoItemRewardPanelPbData>, IDeepCloneable<KurotatoItemRewardPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C2C2 RID: 49858 RVA: 0x001CE692 File Offset: 0x001CC892
		[NullableContext(1)]
		public static KurotatoItemRewardPanelPbData Create()
		{
			return new KurotatoItemRewardPanelPbData();
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x001CE699 File Offset: 0x001CC899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600C2C4 RID: 49860 RVA: 0x001CE69C File Offset: 0x001CC89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemRewardPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x001CE6A3 File Offset: 0x001CC8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData()
		{
		}

		// Token: 0x0600C2C6 RID: 49862 RVA: 0x001CE6B8 File Offset: 0x001CC8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData(KurotatoItemRewardPanelPbData other) : this()
		{
			this.rewardItemDatas_ = other.rewardItemDatas_.Clone();
			this.refreshCost_ = other.refreshCost_;
			this.rewardIndex_ = other.rewardIndex_;
			this.totalRewardCount_ = other.totalRewardCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x001CE711 File Offset: 0x001CC911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData Clone()
		{
			return new KurotatoItemRewardPanelPbData(this);
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600C2C8 RID: 49864 RVA: 0x001CE719 File Offset: 0x001CC919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoItemRewardPbData> RewardItemDatas
		{
			get
			{
				return this.rewardItemDatas_;
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x0600C2C9 RID: 49865 RVA: 0x001CE721 File Offset: 0x001CC921
		// (set) Token: 0x0600C2CA RID: 49866 RVA: 0x001CE729 File Offset: 0x001CC929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshCost
		{
			get
			{
				return this.refreshCost_;
			}
			set
			{
				this.refreshCost_ = value;
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x0600C2CB RID: 49867 RVA: 0x001CE732 File Offset: 0x001CC932
		// (set) Token: 0x0600C2CC RID: 49868 RVA: 0x001CE73A File Offset: 0x001CC93A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
			set
			{
				this.rewardIndex_ = value;
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x001CE743 File Offset: 0x001CC943
		// (set) Token: 0x0600C2CE RID: 49870 RVA: 0x001CE74B File Offset: 0x001CC94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRewardCount
		{
			get
			{
				return this.totalRewardCount_;
			}
			set
			{
				this.totalRewardCount_ = value;
			}
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x001CE754 File Offset: 0x001CC954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemRewardPanelPbData);
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x001CE764 File Offset: 0x001CC964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemRewardPanelPbData other)
		{
			return other != null && (other == this || (this.rewardItemDatas_.Equals(other.rewardItemDatas_) && this.RefreshCost == other.RefreshCost && this.RewardIndex == other.RewardIndex && this.TotalRewardCount == other.TotalRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x001CE7D4 File Offset: 0x001CC9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardItemDatas_.GetHashCode();
			if (this.RefreshCost != 0)
			{
				num ^= this.RefreshCost.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			if (this.TotalRewardCount != 0)
			{
				num ^= this.TotalRewardCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x001CE853 File Offset: 0x001CCA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x001CE860 File Offset: 0x001CCA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2D4 RID: 49876 RVA: 0x001CE86C File Offset: 0x001CCA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardItemDatas_.WriteTo(ref output, KurotatoItemRewardPanelPbData._repeated_rewardItemDatas_codec);
			if (this.RefreshCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RefreshCost);
			}
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.TotalRewardCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalRewardCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x001CE8F4 File Offset: 0x001CCAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardItemDatas_.CalculateSize(KurotatoItemRewardPanelPbData._repeated_rewardItemDatas_codec);
			if (this.RefreshCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshCost);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			if (this.TotalRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRewardCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x001CE978 File Offset: 0x001CCB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemRewardPanelPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardItemDatas_.Add(other.rewardItemDatas_);
			if (other.RefreshCost != 0)
			{
				this.RefreshCost = other.RefreshCost;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			if (other.TotalRewardCount != 0)
			{
				this.TotalRewardCount = other.TotalRewardCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x001CE9ED File Offset: 0x001CCBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x001CE9F8 File Offset: 0x001CCBF8
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
						this.rewardItemDatas_.AddEntriesFrom(ref input, KurotatoItemRewardPanelPbData._repeated_rewardItemDatas_codec);
						continue;
					}
					if (num == 16U)
					{
						this.RefreshCost = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TotalRewardCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005497 RID: 21655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005498 RID: 21656
		public const int RewardItemDatasFieldNumber = 1;

		// Token: 0x04005499 RID: 21657
		private static readonly FieldCodec<KurotatoItemRewardPbData> _repeated_rewardItemDatas_codec = FieldCodec.ForMessage<KurotatoItemRewardPbData>(10U, KurotatoItemRewardPbData.Parser);

		// Token: 0x0400549A RID: 21658
		private readonly RepeatedField<KurotatoItemRewardPbData> rewardItemDatas_ = new RepeatedField<KurotatoItemRewardPbData>();

		// Token: 0x0400549B RID: 21659
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x0400549C RID: 21660
		private int refreshCost_;

		// Token: 0x0400549D RID: 21661
		public const int RewardIndexFieldNumber = 3;

		// Token: 0x0400549E RID: 21662
		private int rewardIndex_;

		// Token: 0x0400549F RID: 21663
		public const int TotalRewardCountFieldNumber = 4;

		// Token: 0x040054A0 RID: 21664
		private int totalRewardCount_;
	}
}
