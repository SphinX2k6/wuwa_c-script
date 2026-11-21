using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B6 RID: 4278
	public sealed class RoleTowerActivityData : IMessage<RoleTowerActivityData>, IMessage, IEquatable<RoleTowerActivityData>, IDeepCloneable<RoleTowerActivityData>, IBufferMessage
	{
		// Token: 0x06016DBA RID: 93626 RVA: 0x00352338 File Offset: 0x00350538
		[NullableContext(1)]
		public static RoleTowerActivityData Create()
		{
			return new RoleTowerActivityData();
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x06016DBB RID: 93627 RVA: 0x0035233F File Offset: 0x0035053F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x06016DBC RID: 93628 RVA: 0x00352342 File Offset: 0x00350542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerActivityData.Descriptor;
			}
		}

		// Token: 0x06016DBD RID: 93629 RVA: 0x00352349 File Offset: 0x00350549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerActivityData()
		{
		}

		// Token: 0x06016DBE RID: 93630 RVA: 0x00352380 File Offset: 0x00350580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerActivityData(RoleTowerActivityData other) : this()
		{
			this.rankRewardSettleTime_ = other.rankRewardSettleTime_;
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this.unlockTokens_ = other.unlockTokens_.Clone();
			this.scoreTasks_ = other.scoreTasks_.Clone();
			this.limitTasks_ = other.limitTasks_.Clone();
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DBF RID: 93631 RVA: 0x00352400 File Offset: 0x00350600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerActivityData Clone()
		{
			return new RoleTowerActivityData(this);
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x06016DC0 RID: 93632 RVA: 0x00352408 File Offset: 0x00350608
		// (set) Token: 0x06016DC1 RID: 93633 RVA: 0x00352410 File Offset: 0x00350610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RankRewardSettleTime
		{
			get
			{
				return this.rankRewardSettleTime_;
			}
			set
			{
				this.rankRewardSettleTime_ = value;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x06016DC2 RID: 93634 RVA: 0x00352419 File Offset: 0x00350619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x06016DC3 RID: 93635 RVA: 0x00352421 File Offset: 0x00350621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTokens
		{
			get
			{
				return this.unlockTokens_;
			}
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x06016DC4 RID: 93636 RVA: 0x00352429 File Offset: 0x00350629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x06016DC5 RID: 93637 RVA: 0x00352431 File Offset: 0x00350631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> LimitTasks
		{
			get
			{
				return this.limitTasks_;
			}
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x06016DC6 RID: 93638 RVA: 0x00352439 File Offset: 0x00350639
		// (set) Token: 0x06016DC7 RID: 93639 RVA: 0x00352441 File Offset: 0x00350641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x06016DC8 RID: 93640 RVA: 0x0035244A File Offset: 0x0035064A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerActivityData);
		}

		// Token: 0x06016DC9 RID: 93641 RVA: 0x00352458 File Offset: 0x00350658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerActivityData other)
		{
			return other != null && (other == this || (this.RankRewardSettleTime == other.RankRewardSettleTime && this.challengeInfos_.Equals(other.challengeInfos_) && this.unlockTokens_.Equals(other.unlockTokens_) && this.scoreTasks_.Equals(other.scoreTasks_) && this.limitTasks_.Equals(other.limitTasks_) && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DCA RID: 93642 RVA: 0x003524F8 File Offset: 0x003506F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RankRewardSettleTime != 0L)
			{
				num ^= this.RankRewardSettleTime.GetHashCode();
			}
			num ^= this.challengeInfos_.GetHashCode();
			num ^= this.unlockTokens_.GetHashCode();
			num ^= this.scoreTasks_.GetHashCode();
			num ^= this.limitTasks_.GetHashCode();
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016DCB RID: 93643 RVA: 0x00352588 File Offset: 0x00350788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DCC RID: 93644 RVA: 0x00352595 File Offset: 0x00350795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DCD RID: 93645 RVA: 0x003525A0 File Offset: 0x003507A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RankRewardSettleTime != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.RankRewardSettleTime);
			}
			this.challengeInfos_.WriteTo(ref output, RoleTowerActivityData._repeated_challengeInfos_codec);
			this.unlockTokens_.WriteTo(ref output, RoleTowerActivityData._repeated_unlockTokens_codec);
			this.scoreTasks_.WriteTo(ref output, RoleTowerActivityData._repeated_scoreTasks_codec);
			this.limitTasks_.WriteTo(ref output, RoleTowerActivityData._repeated_limitTasks_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DCE RID: 93646 RVA: 0x0035263C File Offset: 0x0035083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RankRewardSettleTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RankRewardSettleTime);
			}
			num += this.challengeInfos_.CalculateSize(RoleTowerActivityData._repeated_challengeInfos_codec);
			num += this.unlockTokens_.CalculateSize(RoleTowerActivityData._repeated_unlockTokens_codec);
			num += this.scoreTasks_.CalculateSize(RoleTowerActivityData._repeated_scoreTasks_codec);
			num += this.limitTasks_.CalculateSize(RoleTowerActivityData._repeated_limitTasks_codec);
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DCF RID: 93647 RVA: 0x003526E0 File Offset: 0x003508E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RankRewardSettleTime != 0L)
			{
				this.RankRewardSettleTime = other.RankRewardSettleTime;
			}
			this.challengeInfos_.Add(other.challengeInfos_);
			this.unlockTokens_.Add(other.unlockTokens_);
			this.scoreTasks_.Add(other.scoreTasks_);
			this.limitTasks_.Add(other.limitTasks_);
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DD0 RID: 93648 RVA: 0x00352774 File Offset: 0x00350974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DD1 RID: 93649 RVA: 0x00352780 File Offset: 0x00350980
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
				if (num <= 26U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.RankRewardSettleTime = input.ReadInt64();
							continue;
						}
						if (num == 18U)
						{
							this.challengeInfos_.AddEntriesFrom(ref input, RoleTowerActivityData._repeated_challengeInfos_codec);
							continue;
						}
					}
					else if (num == 24U || num == 26U)
					{
						this.unlockTokens_.AddEntriesFrom(ref input, RoleTowerActivityData._repeated_unlockTokens_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.scoreTasks_.AddEntriesFrom(ref input, RoleTowerActivityData._repeated_scoreTasks_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.limitTasks_.AddEntriesFrom(ref input, RoleTowerActivityData._repeated_limitTasks_codec);
						continue;
					}
					if (num == 48U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088B5 RID: 34997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088B6 RID: 34998
		public const int RankRewardSettleTimeFieldNumber = 1;

		// Token: 0x040088B7 RID: 34999
		private long rankRewardSettleTime_;

		// Token: 0x040088B8 RID: 35000
		public const int ChallengeInfosFieldNumber = 2;

		// Token: 0x040088B9 RID: 35001
		private static readonly FieldCodec<RoleTowerChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<RoleTowerChallengeInfo>(18U, RoleTowerChallengeInfo.Parser);

		// Token: 0x040088BA RID: 35002
		private readonly RepeatedField<RoleTowerChallengeInfo> challengeInfos_ = new RepeatedField<RoleTowerChallengeInfo>();

		// Token: 0x040088BB RID: 35003
		public const int UnlockTokensFieldNumber = 3;

		// Token: 0x040088BC RID: 35004
		private static readonly FieldCodec<int> _repeated_unlockTokens_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040088BD RID: 35005
		private readonly RepeatedField<int> unlockTokens_ = new RepeatedField<int>();

		// Token: 0x040088BE RID: 35006
		public const int ScoreTasksFieldNumber = 4;

		// Token: 0x040088BF RID: 35007
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040088C0 RID: 35008
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x040088C1 RID: 35009
		public const int LimitTasksFieldNumber = 5;

		// Token: 0x040088C2 RID: 35010
		private static readonly FieldCodec<ConditionTask> _repeated_limitTasks_codec = FieldCodec.ForMessage<ConditionTask>(42U, ConditionTask.Parser);

		// Token: 0x040088C3 RID: 35011
		private readonly RepeatedField<ConditionTask> limitTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040088C4 RID: 35012
		public const int ScoreFieldNumber = 6;

		// Token: 0x040088C5 RID: 35013
		private int score_;
	}
}
