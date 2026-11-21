using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001005 RID: 4101
	public sealed class RogueSeasonData : IMessage<RogueSeasonData>, IMessage, IEquatable<RogueSeasonData>, IDeepCloneable<RogueSeasonData>, IBufferMessage
	{
		// Token: 0x06015F4A RID: 89930 RVA: 0x00331B1C File Offset: 0x0032FD1C
		[NullableContext(1)]
		public static RogueSeasonData Create()
		{
			return new RogueSeasonData();
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06015F4B RID: 89931 RVA: 0x00331B23 File Offset: 0x0032FD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x06015F4C RID: 89932 RVA: 0x00331B26 File Offset: 0x0032FD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSeasonData.Descriptor;
			}
		}

		// Token: 0x06015F4D RID: 89933 RVA: 0x00331B2D File Offset: 0x0032FD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData()
		{
		}

		// Token: 0x06015F4E RID: 89934 RVA: 0x00331B4C File Offset: 0x0032FD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData(RogueSeasonData other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.roguelikeTokenList_ = other.roguelikeTokenList_.Clone();
			this.seasonRewardList_ = other.seasonRewardList_.Clone();
			this.tokenItemCount_ = other.tokenItemCount_;
			this.blackFlowerUseCount_ = other.blackFlowerUseCount_;
			this.blackFlowerMaxCount_ = other.blackFlowerMaxCount_;
			this.towerTrialBestClearCount_ = other.towerTrialBestClearCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F4F RID: 89935 RVA: 0x00331BE6 File Offset: 0x0032FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData Clone()
		{
			return new RogueSeasonData(this);
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x06015F50 RID: 89936 RVA: 0x00331BEE File Offset: 0x0032FDEE
		// (set) Token: 0x06015F51 RID: 89937 RVA: 0x00331BF6 File Offset: 0x0032FDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x06015F52 RID: 89938 RVA: 0x00331BFF File Offset: 0x0032FDFF
		// (set) Token: 0x06015F53 RID: 89939 RVA: 0x00331C07 File Offset: 0x0032FE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x06015F54 RID: 89940 RVA: 0x00331C10 File Offset: 0x0032FE10
		// (set) Token: 0x06015F55 RID: 89941 RVA: 0x00331C18 File Offset: 0x0032FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06015F56 RID: 89942 RVA: 0x00331C21 File Offset: 0x0032FE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueToken> RoguelikeTokenList
		{
			get
			{
				return this.roguelikeTokenList_;
			}
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06015F57 RID: 89943 RVA: 0x00331C29 File Offset: 0x0032FE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueSeasonReward> SeasonRewardList
		{
			get
			{
				return this.seasonRewardList_;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06015F58 RID: 89944 RVA: 0x00331C31 File Offset: 0x0032FE31
		// (set) Token: 0x06015F59 RID: 89945 RVA: 0x00331C39 File Offset: 0x0032FE39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenItemCount
		{
			get
			{
				return this.tokenItemCount_;
			}
			set
			{
				this.tokenItemCount_ = value;
			}
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06015F5A RID: 89946 RVA: 0x00331C42 File Offset: 0x0032FE42
		// (set) Token: 0x06015F5B RID: 89947 RVA: 0x00331C4A File Offset: 0x0032FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlackFlowerUseCount
		{
			get
			{
				return this.blackFlowerUseCount_;
			}
			set
			{
				this.blackFlowerUseCount_ = value;
			}
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06015F5C RID: 89948 RVA: 0x00331C53 File Offset: 0x0032FE53
		// (set) Token: 0x06015F5D RID: 89949 RVA: 0x00331C5B File Offset: 0x0032FE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlackFlowerMaxCount
		{
			get
			{
				return this.blackFlowerMaxCount_;
			}
			set
			{
				this.blackFlowerMaxCount_ = value;
			}
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x06015F5E RID: 89950 RVA: 0x00331C64 File Offset: 0x0032FE64
		// (set) Token: 0x06015F5F RID: 89951 RVA: 0x00331C6C File Offset: 0x0032FE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerTrialBestClearCount
		{
			get
			{
				return this.towerTrialBestClearCount_;
			}
			set
			{
				this.towerTrialBestClearCount_ = value;
			}
		}

		// Token: 0x06015F60 RID: 89952 RVA: 0x00331C75 File Offset: 0x0032FE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSeasonData);
		}

		// Token: 0x06015F61 RID: 89953 RVA: 0x00331C84 File Offset: 0x0032FE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.roguelikeTokenList_.Equals(other.roguelikeTokenList_) && this.seasonRewardList_.Equals(other.seasonRewardList_) && this.TokenItemCount == other.TokenItemCount && this.BlackFlowerUseCount == other.BlackFlowerUseCount && this.BlackFlowerMaxCount == other.BlackFlowerMaxCount && this.TowerTrialBestClearCount == other.TowerTrialBestClearCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F62 RID: 89954 RVA: 0x00331D48 File Offset: 0x0032FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.roguelikeTokenList_.GetHashCode();
			num ^= this.seasonRewardList_.GetHashCode();
			if (this.TokenItemCount != 0)
			{
				num ^= this.TokenItemCount.GetHashCode();
			}
			if (this.BlackFlowerUseCount != 0)
			{
				num ^= this.BlackFlowerUseCount.GetHashCode();
			}
			if (this.BlackFlowerMaxCount != 0)
			{
				num ^= this.BlackFlowerMaxCount.GetHashCode();
			}
			if (this.TowerTrialBestClearCount != 0)
			{
				num ^= this.TowerTrialBestClearCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F63 RID: 89955 RVA: 0x00331E39 File Offset: 0x00330039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F64 RID: 89956 RVA: 0x00331E46 File Offset: 0x00330046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F65 RID: 89957 RVA: 0x00331E50 File Offset: 0x00330050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			this.roguelikeTokenList_.WriteTo(ref output, RogueSeasonData._repeated_roguelikeTokenList_codec);
			this.seasonRewardList_.WriteTo(ref output, RogueSeasonData._repeated_seasonRewardList_codec);
			if (this.TokenItemCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TokenItemCount);
			}
			if (this.BlackFlowerUseCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BlackFlowerUseCount);
			}
			if (this.BlackFlowerMaxCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BlackFlowerMaxCount);
			}
			if (this.TowerTrialBestClearCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TowerTrialBestClearCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F66 RID: 89958 RVA: 0x00331F58 File Offset: 0x00330158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.roguelikeTokenList_.CalculateSize(RogueSeasonData._repeated_roguelikeTokenList_codec);
			num += this.seasonRewardList_.CalculateSize(RogueSeasonData._repeated_seasonRewardList_codec);
			if (this.TokenItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenItemCount);
			}
			if (this.BlackFlowerUseCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlackFlowerUseCount);
			}
			if (this.BlackFlowerMaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlackFlowerMaxCount);
			}
			if (this.TowerTrialBestClearCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerTrialBestClearCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F67 RID: 89959 RVA: 0x0033204C File Offset: 0x0033024C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueSeasonData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.roguelikeTokenList_.Add(other.roguelikeTokenList_);
			this.seasonRewardList_.Add(other.seasonRewardList_);
			if (other.TokenItemCount != 0)
			{
				this.TokenItemCount = other.TokenItemCount;
			}
			if (other.BlackFlowerUseCount != 0)
			{
				this.BlackFlowerUseCount = other.BlackFlowerUseCount;
			}
			if (other.BlackFlowerMaxCount != 0)
			{
				this.BlackFlowerMaxCount = other.BlackFlowerMaxCount;
			}
			if (other.TowerTrialBestClearCount != 0)
			{
				this.TowerTrialBestClearCount = other.TowerTrialBestClearCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F68 RID: 89960 RVA: 0x00332122 File Offset: 0x00330322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F69 RID: 89961 RVA: 0x0033212C File Offset: 0x0033032C
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.SeasonId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.StartTime = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.EndTime = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							this.roguelikeTokenList_.AddEntriesFrom(ref input, RogueSeasonData._repeated_roguelikeTokenList_codec);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						this.seasonRewardList_.AddEntriesFrom(ref input, RogueSeasonData._repeated_seasonRewardList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.TokenItemCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BlackFlowerUseCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.BlackFlowerMaxCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.TowerTrialBestClearCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400842B RID: 33835
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400842C RID: 33836
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x0400842D RID: 33837
		private int seasonId_;

		// Token: 0x0400842E RID: 33838
		public const int StartTimeFieldNumber = 2;

		// Token: 0x0400842F RID: 33839
		private long startTime_;

		// Token: 0x04008430 RID: 33840
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04008431 RID: 33841
		private long endTime_;

		// Token: 0x04008432 RID: 33842
		public const int RoguelikeTokenListFieldNumber = 4;

		// Token: 0x04008433 RID: 33843
		private static readonly FieldCodec<RogueToken> _repeated_roguelikeTokenList_codec = FieldCodec.ForMessage<RogueToken>(34U, RogueToken.Parser);

		// Token: 0x04008434 RID: 33844
		private readonly RepeatedField<RogueToken> roguelikeTokenList_ = new RepeatedField<RogueToken>();

		// Token: 0x04008435 RID: 33845
		public const int SeasonRewardListFieldNumber = 5;

		// Token: 0x04008436 RID: 33846
		private static readonly FieldCodec<RogueSeasonReward> _repeated_seasonRewardList_codec = FieldCodec.ForMessage<RogueSeasonReward>(42U, RogueSeasonReward.Parser);

		// Token: 0x04008437 RID: 33847
		private readonly RepeatedField<RogueSeasonReward> seasonRewardList_ = new RepeatedField<RogueSeasonReward>();

		// Token: 0x04008438 RID: 33848
		public const int TokenItemCountFieldNumber = 6;

		// Token: 0x04008439 RID: 33849
		private int tokenItemCount_;

		// Token: 0x0400843A RID: 33850
		public const int BlackFlowerUseCountFieldNumber = 7;

		// Token: 0x0400843B RID: 33851
		private int blackFlowerUseCount_;

		// Token: 0x0400843C RID: 33852
		public const int BlackFlowerMaxCountFieldNumber = 8;

		// Token: 0x0400843D RID: 33853
		private int blackFlowerMaxCount_;

		// Token: 0x0400843E RID: 33854
		public const int TowerTrialBestClearCountFieldNumber = 10;

		// Token: 0x0400843F RID: 33855
		private int towerTrialBestClearCount_;
	}
}
