using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001015 RID: 4117
	public sealed class RogueSeasonData : IMessage<RogueSeasonData>, IMessage, IEquatable<RogueSeasonData>, IDeepCloneable<RogueSeasonData>, IBufferMessage
	{
		// Token: 0x0601602F RID: 90159 RVA: 0x003331D8 File Offset: 0x003313D8
		[NullableContext(1)]
		public static RogueSeasonData Create()
		{
			return new RogueSeasonData();
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x06016030 RID: 90160 RVA: 0x003331DF File Offset: 0x003313DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x06016031 RID: 90161 RVA: 0x003331E2 File Offset: 0x003313E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSeasonData.Descriptor;
			}
		}

		// Token: 0x06016032 RID: 90162 RVA: 0x003331E9 File Offset: 0x003313E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData()
		{
		}

		// Token: 0x06016033 RID: 90163 RVA: 0x00333208 File Offset: 0x00331408
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

		// Token: 0x06016034 RID: 90164 RVA: 0x003332A2 File Offset: 0x003314A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonData Clone()
		{
			return new RogueSeasonData(this);
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x06016035 RID: 90165 RVA: 0x003332AA File Offset: 0x003314AA
		// (set) Token: 0x06016036 RID: 90166 RVA: 0x003332B2 File Offset: 0x003314B2
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

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x06016037 RID: 90167 RVA: 0x003332BB File Offset: 0x003314BB
		// (set) Token: 0x06016038 RID: 90168 RVA: 0x003332C3 File Offset: 0x003314C3
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

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x06016039 RID: 90169 RVA: 0x003332CC File Offset: 0x003314CC
		// (set) Token: 0x0601603A RID: 90170 RVA: 0x003332D4 File Offset: 0x003314D4
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

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x0601603B RID: 90171 RVA: 0x003332DD File Offset: 0x003314DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueToken> RoguelikeTokenList
		{
			get
			{
				return this.roguelikeTokenList_;
			}
		}

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x0601603C RID: 90172 RVA: 0x003332E5 File Offset: 0x003314E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueSeasonReward> SeasonRewardList
		{
			get
			{
				return this.seasonRewardList_;
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x0601603D RID: 90173 RVA: 0x003332ED File Offset: 0x003314ED
		// (set) Token: 0x0601603E RID: 90174 RVA: 0x003332F5 File Offset: 0x003314F5
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

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x0601603F RID: 90175 RVA: 0x003332FE File Offset: 0x003314FE
		// (set) Token: 0x06016040 RID: 90176 RVA: 0x00333306 File Offset: 0x00331506
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

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x06016041 RID: 90177 RVA: 0x0033330F File Offset: 0x0033150F
		// (set) Token: 0x06016042 RID: 90178 RVA: 0x00333317 File Offset: 0x00331517
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

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x06016043 RID: 90179 RVA: 0x00333320 File Offset: 0x00331520
		// (set) Token: 0x06016044 RID: 90180 RVA: 0x00333328 File Offset: 0x00331528
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

		// Token: 0x06016045 RID: 90181 RVA: 0x00333331 File Offset: 0x00331531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSeasonData);
		}

		// Token: 0x06016046 RID: 90182 RVA: 0x00333340 File Offset: 0x00331540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.roguelikeTokenList_.Equals(other.roguelikeTokenList_) && this.seasonRewardList_.Equals(other.seasonRewardList_) && this.TokenItemCount == other.TokenItemCount && this.BlackFlowerUseCount == other.BlackFlowerUseCount && this.BlackFlowerMaxCount == other.BlackFlowerMaxCount && this.TowerTrialBestClearCount == other.TowerTrialBestClearCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016047 RID: 90183 RVA: 0x00333404 File Offset: 0x00331604
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

		// Token: 0x06016048 RID: 90184 RVA: 0x003334F5 File Offset: 0x003316F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016049 RID: 90185 RVA: 0x00333502 File Offset: 0x00331702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601604A RID: 90186 RVA: 0x0033350C File Offset: 0x0033170C
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

		// Token: 0x0601604B RID: 90187 RVA: 0x00333614 File Offset: 0x00331814
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

		// Token: 0x0601604C RID: 90188 RVA: 0x00333708 File Offset: 0x00331908
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

		// Token: 0x0601604D RID: 90189 RVA: 0x003337DE File Offset: 0x003319DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601604E RID: 90190 RVA: 0x003337E8 File Offset: 0x003319E8
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

		// Token: 0x04008401 RID: 33793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008402 RID: 33794
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x04008403 RID: 33795
		private int seasonId_;

		// Token: 0x04008404 RID: 33796
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04008405 RID: 33797
		private long startTime_;

		// Token: 0x04008406 RID: 33798
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04008407 RID: 33799
		private long endTime_;

		// Token: 0x04008408 RID: 33800
		public const int RoguelikeTokenListFieldNumber = 4;

		// Token: 0x04008409 RID: 33801
		private static readonly FieldCodec<RogueToken> _repeated_roguelikeTokenList_codec = FieldCodec.ForMessage<RogueToken>(34U, RogueToken.Parser);

		// Token: 0x0400840A RID: 33802
		private readonly RepeatedField<RogueToken> roguelikeTokenList_ = new RepeatedField<RogueToken>();

		// Token: 0x0400840B RID: 33803
		public const int SeasonRewardListFieldNumber = 5;

		// Token: 0x0400840C RID: 33804
		private static readonly FieldCodec<RogueSeasonReward> _repeated_seasonRewardList_codec = FieldCodec.ForMessage<RogueSeasonReward>(42U, RogueSeasonReward.Parser);

		// Token: 0x0400840D RID: 33805
		private readonly RepeatedField<RogueSeasonReward> seasonRewardList_ = new RepeatedField<RogueSeasonReward>();

		// Token: 0x0400840E RID: 33806
		public const int TokenItemCountFieldNumber = 6;

		// Token: 0x0400840F RID: 33807
		private int tokenItemCount_;

		// Token: 0x04008410 RID: 33808
		public const int BlackFlowerUseCountFieldNumber = 7;

		// Token: 0x04008411 RID: 33809
		private int blackFlowerUseCount_;

		// Token: 0x04008412 RID: 33810
		public const int BlackFlowerMaxCountFieldNumber = 8;

		// Token: 0x04008413 RID: 33811
		private int blackFlowerMaxCount_;

		// Token: 0x04008414 RID: 33812
		public const int TowerTrialBestClearCountFieldNumber = 10;

		// Token: 0x04008415 RID: 33813
		private int towerTrialBestClearCount_;
	}
}
