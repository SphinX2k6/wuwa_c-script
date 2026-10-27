using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B8 RID: 1464
	public sealed class FloroRanchPlayerInfo : IMessage<FloroRanchPlayerInfo>, IMessage, IEquatable<FloroRanchPlayerInfo>, IDeepCloneable<FloroRanchPlayerInfo>, IBufferMessage
	{
		// Token: 0x06008739 RID: 34617 RVA: 0x00144ECA File Offset: 0x001430CA
		[NullableContext(1)]
		public static FloroRanchPlayerInfo Create()
		{
			return new FloroRanchPlayerInfo();
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00144ED1 File Offset: 0x001430D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x00144ED4 File Offset: 0x001430D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayerInfo.Descriptor;
			}
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x00144EDC File Offset: 0x001430DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo()
		{
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x00144F68 File Offset: 0x00143168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo(FloroRanchPlayerInfo other) : this()
		{
			this.unlockCards_ = other.unlockCards_.Clone();
			this.unlockTech_ = other.unlockTech_.Clone();
			this.unlockToys_ = other.unlockToys_.Clone();
			this.unlockSkillIds_ = other.unlockSkillIds_.Clone();
			this.rewardMilestones_ = other.rewardMilestones_.Clone();
			this.raceUnLockInfo_ = other.raceUnLockInfo_.Clone();
			this.floroSubInsInfo_ = other.floroSubInsInfo_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.subInsHistory_ = other.subInsHistory_.Clone();
			this.readSubInsId_ = other.readSubInsId_.Clone();
			this.animation_ = other.animation_;
			this.limitOpenTime_ = other.limitOpenTime_;
			this.limitCloseTime_ = other.limitCloseTime_;
			this.insUnLockCondition_ = other.insUnLockCondition_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x0014506B File Offset: 0x0014326B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo Clone()
		{
			return new FloroRanchPlayerInfo(this);
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x00145073 File Offset: 0x00143273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockCards
		{
			get
			{
				return this.unlockCards_;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06008740 RID: 34624 RVA: 0x0014507B File Offset: 0x0014327B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTech
		{
			get
			{
				return this.unlockTech_;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x00145083 File Offset: 0x00143283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockToys
		{
			get
			{
				return this.unlockToys_;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06008742 RID: 34626 RVA: 0x0014508B File Offset: 0x0014328B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockSkillIds
		{
			get
			{
				return this.unlockSkillIds_;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x00145093 File Offset: 0x00143293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardMilestones
		{
			get
			{
				return this.rewardMilestones_;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06008744 RID: 34628 RVA: 0x0014509B File Offset: 0x0014329B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> RaceUnLockInfo
		{
			get
			{
				return this.raceUnLockInfo_;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06008745 RID: 34629 RVA: 0x001450A3 File Offset: 0x001432A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroSubInsInfo> FloroSubInsInfo
		{
			get
			{
				return this.floroSubInsInfo_;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06008746 RID: 34630 RVA: 0x001450AB File Offset: 0x001432AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x001450B3 File Offset: 0x001432B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsRecord> SubInsHistory
		{
			get
			{
				return this.subInsHistory_;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008748 RID: 34632 RVA: 0x001450BB File Offset: 0x001432BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadSubInsId
		{
			get
			{
				return this.readSubInsId_;
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x001450C3 File Offset: 0x001432C3
		// (set) Token: 0x0600874A RID: 34634 RVA: 0x001450CB File Offset: 0x001432CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Animation
		{
			get
			{
				return this.animation_;
			}
			set
			{
				this.animation_ = value;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x0600874B RID: 34635 RVA: 0x001450D4 File Offset: 0x001432D4
		// (set) Token: 0x0600874C RID: 34636 RVA: 0x001450DC File Offset: 0x001432DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitOpenTime
		{
			get
			{
				return this.limitOpenTime_;
			}
			set
			{
				this.limitOpenTime_ = value;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600874D RID: 34637 RVA: 0x001450E5 File Offset: 0x001432E5
		// (set) Token: 0x0600874E RID: 34638 RVA: 0x001450ED File Offset: 0x001432ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitCloseTime
		{
			get
			{
				return this.limitCloseTime_;
			}
			set
			{
				this.limitCloseTime_ = value;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x0600874F RID: 34639 RVA: 0x001450F6 File Offset: 0x001432F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> InsUnLockCondition
		{
			get
			{
				return this.insUnLockCondition_;
			}
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x001450FE File Offset: 0x001432FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayerInfo);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x0014510C File Offset: 0x0014330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayerInfo other)
		{
			return other != null && (other == this || (this.unlockCards_.Equals(other.unlockCards_) && this.unlockTech_.Equals(other.unlockTech_) && this.unlockToys_.Equals(other.unlockToys_) && this.unlockSkillIds_.Equals(other.unlockSkillIds_) && this.rewardMilestones_.Equals(other.rewardMilestones_) && this.raceUnLockInfo_.Equals(other.raceUnLockInfo_) && this.floroSubInsInfo_.Equals(other.floroSubInsInfo_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.subInsHistory_.Equals(other.subInsHistory_) && this.readSubInsId_.Equals(other.readSubInsId_) && this.Animation == other.Animation && this.LimitOpenTime == other.LimitOpenTime && this.LimitCloseTime == other.LimitCloseTime && this.insUnLockCondition_.Equals(other.insUnLockCondition_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x0014524C File Offset: 0x0014344C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockCards_.GetHashCode();
			num ^= this.unlockTech_.GetHashCode();
			num ^= this.unlockToys_.GetHashCode();
			num ^= this.unlockSkillIds_.GetHashCode();
			num ^= this.rewardMilestones_.GetHashCode();
			num ^= this.raceUnLockInfo_.GetHashCode();
			num ^= this.floroSubInsInfo_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.subInsHistory_.GetHashCode();
			num ^= this.readSubInsId_.GetHashCode();
			if (this.Animation)
			{
				num ^= this.Animation.GetHashCode();
			}
			if (this.LimitOpenTime != 0L)
			{
				num ^= this.LimitOpenTime.GetHashCode();
			}
			if (this.LimitCloseTime != 0L)
			{
				num ^= this.LimitCloseTime.GetHashCode();
			}
			num ^= this.insUnLockCondition_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008753 RID: 34643 RVA: 0x00145357 File Offset: 0x00143557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00145364 File Offset: 0x00143564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00145370 File Offset: 0x00143570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockCards_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_unlockCards_codec);
			this.unlockTech_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_unlockTech_codec);
			this.unlockToys_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_unlockToys_codec);
			this.unlockSkillIds_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_unlockSkillIds_codec);
			this.rewardMilestones_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_rewardMilestones_codec);
			this.raceUnLockInfo_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_raceUnLockInfo_codec);
			this.floroSubInsInfo_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_floroSubInsInfo_codec);
			this.conditionTasks_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_conditionTasks_codec);
			this.subInsHistory_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_subInsHistory_codec);
			this.readSubInsId_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_readSubInsId_codec);
			if (this.Animation)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Animation);
			}
			if (this.LimitOpenTime != 0L)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt64(this.LimitOpenTime);
			}
			if (this.LimitCloseTime != 0L)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt64(this.LimitCloseTime);
			}
			this.insUnLockCondition_.WriteTo(ref output, FloroRanchPlayerInfo._repeated_insUnLockCondition_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x001454A8 File Offset: 0x001436A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockCards_.CalculateSize(FloroRanchPlayerInfo._repeated_unlockCards_codec);
			num += this.unlockTech_.CalculateSize(FloroRanchPlayerInfo._repeated_unlockTech_codec);
			num += this.unlockToys_.CalculateSize(FloroRanchPlayerInfo._repeated_unlockToys_codec);
			num += this.unlockSkillIds_.CalculateSize(FloroRanchPlayerInfo._repeated_unlockSkillIds_codec);
			num += this.rewardMilestones_.CalculateSize(FloroRanchPlayerInfo._repeated_rewardMilestones_codec);
			num += this.raceUnLockInfo_.CalculateSize(FloroRanchPlayerInfo._repeated_raceUnLockInfo_codec);
			num += this.floroSubInsInfo_.CalculateSize(FloroRanchPlayerInfo._repeated_floroSubInsInfo_codec);
			num += this.conditionTasks_.CalculateSize(FloroRanchPlayerInfo._repeated_conditionTasks_codec);
			num += this.subInsHistory_.CalculateSize(FloroRanchPlayerInfo._repeated_subInsHistory_codec);
			num += this.readSubInsId_.CalculateSize(FloroRanchPlayerInfo._repeated_readSubInsId_codec);
			if (this.Animation)
			{
				num += 2;
			}
			if (this.LimitOpenTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitOpenTime);
			}
			if (this.LimitCloseTime != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LimitCloseTime);
			}
			num += this.insUnLockCondition_.CalculateSize(FloroRanchPlayerInfo._repeated_insUnLockCondition_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x001455DC File Offset: 0x001437DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayerInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockCards_.Add(other.unlockCards_);
			this.unlockTech_.Add(other.unlockTech_);
			this.unlockToys_.Add(other.unlockToys_);
			this.unlockSkillIds_.Add(other.unlockSkillIds_);
			this.rewardMilestones_.Add(other.rewardMilestones_);
			this.raceUnLockInfo_.Add(other.raceUnLockInfo_);
			this.floroSubInsInfo_.Add(other.floroSubInsInfo_);
			this.conditionTasks_.Add(other.conditionTasks_);
			this.subInsHistory_.Add(other.subInsHistory_);
			this.readSubInsId_.Add(other.readSubInsId_);
			if (other.Animation)
			{
				this.Animation = other.Animation;
			}
			if (other.LimitOpenTime != 0L)
			{
				this.LimitOpenTime = other.LimitOpenTime;
			}
			if (other.LimitCloseTime != 0L)
			{
				this.LimitCloseTime = other.LimitCloseTime;
			}
			this.insUnLockCondition_.Add(other.insUnLockCondition_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x001456FB File Offset: 0x001438FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00145704 File Offset: 0x00143904
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
				if (num > 74U)
				{
					if (num <= 112U)
					{
						if (num <= 90U)
						{
							if (num == 82U)
							{
								this.floroSubInsInfo_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_floroSubInsInfo_codec);
								continue;
							}
							if (num != 90U)
							{
								goto IL_D4;
							}
							this.conditionTasks_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_conditionTasks_codec);
							continue;
						}
						else
						{
							if (num == 106U)
							{
								this.subInsHistory_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_subInsHistory_codec);
								continue;
							}
							if (num != 112U)
							{
								goto IL_D4;
							}
						}
					}
					else if (num <= 120U)
					{
						if (num != 114U)
						{
							if (num != 120U)
							{
								goto IL_D4;
							}
							this.Animation = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 128U)
						{
							this.LimitOpenTime = input.ReadInt64();
							continue;
						}
						if (num == 136U)
						{
							this.LimitCloseTime = input.ReadInt64();
							continue;
						}
						if (num != 146U)
						{
							goto IL_D4;
						}
						this.insUnLockCondition_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_insUnLockCondition_codec);
						continue;
					}
					this.readSubInsId_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_readSubInsId_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.unlockCards_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_unlockCards_codec);
							continue;
						}
						if (num != 16U)
						{
							goto IL_D4;
						}
					}
					else if (num != 18U)
					{
						if (num != 26U)
						{
							goto IL_D4;
						}
						this.unlockToys_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_unlockToys_codec);
						continue;
					}
					this.unlockTech_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_unlockTech_codec);
					continue;
				}
				if (num <= 56U)
				{
					if (num == 42U)
					{
						this.unlockSkillIds_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_unlockSkillIds_codec);
						continue;
					}
					if (num != 56U)
					{
						goto IL_D4;
					}
				}
				else if (num != 58U)
				{
					if (num != 74U)
					{
						goto IL_D4;
					}
					this.raceUnLockInfo_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_raceUnLockInfo_codec);
					continue;
				}
				this.rewardMilestones_.AddEntriesFrom(ref input, FloroRanchPlayerInfo._repeated_rewardMilestones_codec);
				continue;
				IL_D4:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004290 RID: 17040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004291 RID: 17041
		public const int UnlockCardsFieldNumber = 1;

		// Token: 0x04004292 RID: 17042
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockCards_codec = FieldCodec.ForMessage<FloroUnLockInfo>(10U, FloroUnLockInfo.Parser);

		// Token: 0x04004293 RID: 17043
		private readonly RepeatedField<FloroUnLockInfo> unlockCards_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x04004294 RID: 17044
		public const int UnlockTechFieldNumber = 2;

		// Token: 0x04004295 RID: 17045
		private static readonly FieldCodec<int> _repeated_unlockTech_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004296 RID: 17046
		private readonly RepeatedField<int> unlockTech_ = new RepeatedField<int>();

		// Token: 0x04004297 RID: 17047
		public const int UnlockToysFieldNumber = 3;

		// Token: 0x04004298 RID: 17048
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockToys_codec = FieldCodec.ForMessage<FloroUnLockInfo>(26U, FloroUnLockInfo.Parser);

		// Token: 0x04004299 RID: 17049
		private readonly RepeatedField<FloroUnLockInfo> unlockToys_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x0400429A RID: 17050
		public const int UnlockSkillIdsFieldNumber = 5;

		// Token: 0x0400429B RID: 17051
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockSkillIds_codec = FieldCodec.ForMessage<FloroUnLockInfo>(42U, FloroUnLockInfo.Parser);

		// Token: 0x0400429C RID: 17052
		private readonly RepeatedField<FloroUnLockInfo> unlockSkillIds_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x0400429D RID: 17053
		public const int RewardMilestonesFieldNumber = 7;

		// Token: 0x0400429E RID: 17054
		private static readonly FieldCodec<int> _repeated_rewardMilestones_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400429F RID: 17055
		private readonly RepeatedField<int> rewardMilestones_ = new RepeatedField<int>();

		// Token: 0x040042A0 RID: 17056
		public const int RaceUnLockInfoFieldNumber = 9;

		// Token: 0x040042A1 RID: 17057
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_raceUnLockInfo_codec = FieldCodec.ForMessage<FloroUnLockInfo>(74U, FloroUnLockInfo.Parser);

		// Token: 0x040042A2 RID: 17058
		private readonly RepeatedField<FloroUnLockInfo> raceUnLockInfo_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x040042A3 RID: 17059
		public const int FloroSubInsInfoFieldNumber = 10;

		// Token: 0x040042A4 RID: 17060
		private static readonly FieldCodec<FloroSubInsInfo> _repeated_floroSubInsInfo_codec = FieldCodec.ForMessage<FloroSubInsInfo>(82U, Aki.Protocol.FloroSubInsInfo.Parser);

		// Token: 0x040042A5 RID: 17061
		private readonly RepeatedField<FloroSubInsInfo> floroSubInsInfo_ = new RepeatedField<FloroSubInsInfo>();

		// Token: 0x040042A6 RID: 17062
		public const int ConditionTasksFieldNumber = 11;

		// Token: 0x040042A7 RID: 17063
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(90U, ConditionTask.Parser);

		// Token: 0x040042A8 RID: 17064
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040042A9 RID: 17065
		public const int SubInsHistoryFieldNumber = 13;

		// Token: 0x040042AA RID: 17066
		private static readonly FieldCodec<FloroRanchSubInsRecord> _repeated_subInsHistory_codec = FieldCodec.ForMessage<FloroRanchSubInsRecord>(106U, FloroRanchSubInsRecord.Parser);

		// Token: 0x040042AB RID: 17067
		private readonly RepeatedField<FloroRanchSubInsRecord> subInsHistory_ = new RepeatedField<FloroRanchSubInsRecord>();

		// Token: 0x040042AC RID: 17068
		public const int ReadSubInsIdFieldNumber = 14;

		// Token: 0x040042AD RID: 17069
		private static readonly FieldCodec<int> _repeated_readSubInsId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040042AE RID: 17070
		private readonly RepeatedField<int> readSubInsId_ = new RepeatedField<int>();

		// Token: 0x040042AF RID: 17071
		public const int AnimationFieldNumber = 15;

		// Token: 0x040042B0 RID: 17072
		private bool animation_;

		// Token: 0x040042B1 RID: 17073
		public const int LimitOpenTimeFieldNumber = 16;

		// Token: 0x040042B2 RID: 17074
		private long limitOpenTime_;

		// Token: 0x040042B3 RID: 17075
		public const int LimitCloseTimeFieldNumber = 17;

		// Token: 0x040042B4 RID: 17076
		private long limitCloseTime_;

		// Token: 0x040042B5 RID: 17077
		public const int InsUnLockConditionFieldNumber = 18;

		// Token: 0x040042B6 RID: 17078
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_insUnLockCondition_codec = FieldCodec.ForMessage<FloroUnLockInfo>(146U, FloroUnLockInfo.Parser);

		// Token: 0x040042B7 RID: 17079
		private readonly RepeatedField<FloroUnLockInfo> insUnLockCondition_ = new RepeatedField<FloroUnLockInfo>();
	}
}
