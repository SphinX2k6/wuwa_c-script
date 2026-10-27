using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089C RID: 2204
	public sealed class KurotatoItemRewardPanelPbData : IMessage<KurotatoItemRewardPanelPbData>, IMessage, IEquatable<KurotatoItemRewardPanelPbData>, IDeepCloneable<KurotatoItemRewardPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C3DE RID: 50142 RVA: 0x001D0976 File Offset: 0x001CEB76
		[NullableContext(1)]
		public static KurotatoItemRewardPanelPbData Create()
		{
			return new KurotatoItemRewardPanelPbData();
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600C3DF RID: 50143 RVA: 0x001D097D File Offset: 0x001CEB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x001D0980 File Offset: 0x001CEB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemRewardPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x001D0987 File Offset: 0x001CEB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData()
		{
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x001D099C File Offset: 0x001CEB9C
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

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x001D09F5 File Offset: 0x001CEBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData Clone()
		{
			return new KurotatoItemRewardPanelPbData(this);
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x0600C3E4 RID: 50148 RVA: 0x001D09FD File Offset: 0x001CEBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoItemRewardPbData> RewardItemDatas
		{
			get
			{
				return this.rewardItemDatas_;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x0600C3E5 RID: 50149 RVA: 0x001D0A05 File Offset: 0x001CEC05
		// (set) Token: 0x0600C3E6 RID: 50150 RVA: 0x001D0A0D File Offset: 0x001CEC0D
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

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x001D0A16 File Offset: 0x001CEC16
		// (set) Token: 0x0600C3E8 RID: 50152 RVA: 0x001D0A1E File Offset: 0x001CEC1E
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

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600C3E9 RID: 50153 RVA: 0x001D0A27 File Offset: 0x001CEC27
		// (set) Token: 0x0600C3EA RID: 50154 RVA: 0x001D0A2F File Offset: 0x001CEC2F
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

		// Token: 0x0600C3EB RID: 50155 RVA: 0x001D0A38 File Offset: 0x001CEC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemRewardPanelPbData);
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x001D0A48 File Offset: 0x001CEC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemRewardPanelPbData other)
		{
			return other != null && (other == this || (this.rewardItemDatas_.Equals(other.rewardItemDatas_) && this.RefreshCost == other.RefreshCost && this.RewardIndex == other.RewardIndex && this.TotalRewardCount == other.TotalRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x001D0AB8 File Offset: 0x001CECB8
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

		// Token: 0x0600C3EE RID: 50158 RVA: 0x001D0B37 File Offset: 0x001CED37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3EF RID: 50159 RVA: 0x001D0B44 File Offset: 0x001CED44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3F0 RID: 50160 RVA: 0x001D0B50 File Offset: 0x001CED50
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

		// Token: 0x0600C3F1 RID: 50161 RVA: 0x001D0BD8 File Offset: 0x001CEDD8
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

		// Token: 0x0600C3F2 RID: 50162 RVA: 0x001D0C5C File Offset: 0x001CEE5C
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

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x001D0CD1 File Offset: 0x001CEED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x001D0CDC File Offset: 0x001CEEDC
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

		// Token: 0x04005490 RID: 21648
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005491 RID: 21649
		public const int RewardItemDatasFieldNumber = 1;

		// Token: 0x04005492 RID: 21650
		private static readonly FieldCodec<KurotatoItemRewardPbData> _repeated_rewardItemDatas_codec = FieldCodec.ForMessage<KurotatoItemRewardPbData>(10U, KurotatoItemRewardPbData.Parser);

		// Token: 0x04005493 RID: 21651
		private readonly RepeatedField<KurotatoItemRewardPbData> rewardItemDatas_ = new RepeatedField<KurotatoItemRewardPbData>();

		// Token: 0x04005494 RID: 21652
		public const int RefreshCostFieldNumber = 2;

		// Token: 0x04005495 RID: 21653
		private int refreshCost_;

		// Token: 0x04005496 RID: 21654
		public const int RewardIndexFieldNumber = 3;

		// Token: 0x04005497 RID: 21655
		private int rewardIndex_;

		// Token: 0x04005498 RID: 21656
		public const int TotalRewardCountFieldNumber = 4;

		// Token: 0x04005499 RID: 21657
		private int totalRewardCount_;
	}
}
