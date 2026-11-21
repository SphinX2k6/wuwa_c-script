using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A3 RID: 1443
	public sealed class FloroRanchPlayerInfo : IMessage<FloroRanchPlayerInfo>, IMessage, IEquatable<FloroRanchPlayerInfo>, IDeepCloneable<FloroRanchPlayerInfo>, IBufferMessage
	{
		// Token: 0x060085D1 RID: 34257 RVA: 0x001422BA File Offset: 0x001404BA
		[NullableContext(1)]
		public static FloroRanchPlayerInfo Create()
		{
			return new FloroRanchPlayerInfo();
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x001422C1 File Offset: 0x001404C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x001422C4 File Offset: 0x001404C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayerInfo.Descriptor;
			}
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x001422CC File Offset: 0x001404CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo()
		{
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x00142358 File Offset: 0x00140558
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

		// Token: 0x060085D6 RID: 34262 RVA: 0x0014245B File Offset: 0x0014065B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayerInfo Clone()
		{
			return new FloroRanchPlayerInfo(this);
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060085D7 RID: 34263 RVA: 0x00142463 File Offset: 0x00140663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockCards
		{
			get
			{
				return this.unlockCards_;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060085D8 RID: 34264 RVA: 0x0014246B File Offset: 0x0014066B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTech
		{
			get
			{
				return this.unlockTech_;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060085D9 RID: 34265 RVA: 0x00142473 File Offset: 0x00140673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockToys
		{
			get
			{
				return this.unlockToys_;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060085DA RID: 34266 RVA: 0x0014247B File Offset: 0x0014067B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> UnlockSkillIds
		{
			get
			{
				return this.unlockSkillIds_;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060085DB RID: 34267 RVA: 0x00142483 File Offset: 0x00140683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardMilestones
		{
			get
			{
				return this.rewardMilestones_;
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x0014248B File Offset: 0x0014068B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> RaceUnLockInfo
		{
			get
			{
				return this.raceUnLockInfo_;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x00142493 File Offset: 0x00140693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroSubInsInfo> FloroSubInsInfo
		{
			get
			{
				return this.floroSubInsInfo_;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x0014249B File Offset: 0x0014069B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x001424A3 File Offset: 0x001406A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsRecord> SubInsHistory
		{
			get
			{
				return this.subInsHistory_;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060085E0 RID: 34272 RVA: 0x001424AB File Offset: 0x001406AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadSubInsId
		{
			get
			{
				return this.readSubInsId_;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x001424B3 File Offset: 0x001406B3
		// (set) Token: 0x060085E2 RID: 34274 RVA: 0x001424BB File Offset: 0x001406BB
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

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x001424C4 File Offset: 0x001406C4
		// (set) Token: 0x060085E4 RID: 34276 RVA: 0x001424CC File Offset: 0x001406CC
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

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x060085E5 RID: 34277 RVA: 0x001424D5 File Offset: 0x001406D5
		// (set) Token: 0x060085E6 RID: 34278 RVA: 0x001424DD File Offset: 0x001406DD
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

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x060085E7 RID: 34279 RVA: 0x001424E6 File Offset: 0x001406E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroUnLockInfo> InsUnLockCondition
		{
			get
			{
				return this.insUnLockCondition_;
			}
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x001424EE File Offset: 0x001406EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayerInfo);
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x001424FC File Offset: 0x001406FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayerInfo other)
		{
			return other != null && (other == this || (this.unlockCards_.Equals(other.unlockCards_) && this.unlockTech_.Equals(other.unlockTech_) && this.unlockToys_.Equals(other.unlockToys_) && this.unlockSkillIds_.Equals(other.unlockSkillIds_) && this.rewardMilestones_.Equals(other.rewardMilestones_) && this.raceUnLockInfo_.Equals(other.raceUnLockInfo_) && this.floroSubInsInfo_.Equals(other.floroSubInsInfo_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.subInsHistory_.Equals(other.subInsHistory_) && this.readSubInsId_.Equals(other.readSubInsId_) && this.Animation == other.Animation && this.LimitOpenTime == other.LimitOpenTime && this.LimitCloseTime == other.LimitCloseTime && this.insUnLockCondition_.Equals(other.insUnLockCondition_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x0014263C File Offset: 0x0014083C
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

		// Token: 0x060085EB RID: 34283 RVA: 0x00142747 File Offset: 0x00140947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x00142754 File Offset: 0x00140954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x00142760 File Offset: 0x00140960
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

		// Token: 0x060085EE RID: 34286 RVA: 0x00142898 File Offset: 0x00140A98
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

		// Token: 0x060085EF RID: 34287 RVA: 0x001429CC File Offset: 0x00140BCC
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

		// Token: 0x060085F0 RID: 34288 RVA: 0x00142AEB File Offset: 0x00140CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x00142AF4 File Offset: 0x00140CF4
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

		// Token: 0x04004286 RID: 17030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004287 RID: 17031
		public const int UnlockCardsFieldNumber = 1;

		// Token: 0x04004288 RID: 17032
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockCards_codec = FieldCodec.ForMessage<FloroUnLockInfo>(10U, FloroUnLockInfo.Parser);

		// Token: 0x04004289 RID: 17033
		private readonly RepeatedField<FloroUnLockInfo> unlockCards_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x0400428A RID: 17034
		public const int UnlockTechFieldNumber = 2;

		// Token: 0x0400428B RID: 17035
		private static readonly FieldCodec<int> _repeated_unlockTech_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400428C RID: 17036
		private readonly RepeatedField<int> unlockTech_ = new RepeatedField<int>();

		// Token: 0x0400428D RID: 17037
		public const int UnlockToysFieldNumber = 3;

		// Token: 0x0400428E RID: 17038
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockToys_codec = FieldCodec.ForMessage<FloroUnLockInfo>(26U, FloroUnLockInfo.Parser);

		// Token: 0x0400428F RID: 17039
		private readonly RepeatedField<FloroUnLockInfo> unlockToys_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x04004290 RID: 17040
		public const int UnlockSkillIdsFieldNumber = 5;

		// Token: 0x04004291 RID: 17041
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_unlockSkillIds_codec = FieldCodec.ForMessage<FloroUnLockInfo>(42U, FloroUnLockInfo.Parser);

		// Token: 0x04004292 RID: 17042
		private readonly RepeatedField<FloroUnLockInfo> unlockSkillIds_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x04004293 RID: 17043
		public const int RewardMilestonesFieldNumber = 7;

		// Token: 0x04004294 RID: 17044
		private static readonly FieldCodec<int> _repeated_rewardMilestones_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004295 RID: 17045
		private readonly RepeatedField<int> rewardMilestones_ = new RepeatedField<int>();

		// Token: 0x04004296 RID: 17046
		public const int RaceUnLockInfoFieldNumber = 9;

		// Token: 0x04004297 RID: 17047
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_raceUnLockInfo_codec = FieldCodec.ForMessage<FloroUnLockInfo>(74U, FloroUnLockInfo.Parser);

		// Token: 0x04004298 RID: 17048
		private readonly RepeatedField<FloroUnLockInfo> raceUnLockInfo_ = new RepeatedField<FloroUnLockInfo>();

		// Token: 0x04004299 RID: 17049
		public const int FloroSubInsInfoFieldNumber = 10;

		// Token: 0x0400429A RID: 17050
		private static readonly FieldCodec<FloroSubInsInfo> _repeated_floroSubInsInfo_codec = FieldCodec.ForMessage<FloroSubInsInfo>(82U, Aki.Protocol.FloroSubInsInfo.Parser);

		// Token: 0x0400429B RID: 17051
		private readonly RepeatedField<FloroSubInsInfo> floroSubInsInfo_ = new RepeatedField<FloroSubInsInfo>();

		// Token: 0x0400429C RID: 17052
		public const int ConditionTasksFieldNumber = 11;

		// Token: 0x0400429D RID: 17053
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(90U, ConditionTask.Parser);

		// Token: 0x0400429E RID: 17054
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400429F RID: 17055
		public const int SubInsHistoryFieldNumber = 13;

		// Token: 0x040042A0 RID: 17056
		private static readonly FieldCodec<FloroRanchSubInsRecord> _repeated_subInsHistory_codec = FieldCodec.ForMessage<FloroRanchSubInsRecord>(106U, FloroRanchSubInsRecord.Parser);

		// Token: 0x040042A1 RID: 17057
		private readonly RepeatedField<FloroRanchSubInsRecord> subInsHistory_ = new RepeatedField<FloroRanchSubInsRecord>();

		// Token: 0x040042A2 RID: 17058
		public const int ReadSubInsIdFieldNumber = 14;

		// Token: 0x040042A3 RID: 17059
		private static readonly FieldCodec<int> _repeated_readSubInsId_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040042A4 RID: 17060
		private readonly RepeatedField<int> readSubInsId_ = new RepeatedField<int>();

		// Token: 0x040042A5 RID: 17061
		public const int AnimationFieldNumber = 15;

		// Token: 0x040042A6 RID: 17062
		private bool animation_;

		// Token: 0x040042A7 RID: 17063
		public const int LimitOpenTimeFieldNumber = 16;

		// Token: 0x040042A8 RID: 17064
		private long limitOpenTime_;

		// Token: 0x040042A9 RID: 17065
		public const int LimitCloseTimeFieldNumber = 17;

		// Token: 0x040042AA RID: 17066
		private long limitCloseTime_;

		// Token: 0x040042AB RID: 17067
		public const int InsUnLockConditionFieldNumber = 18;

		// Token: 0x040042AC RID: 17068
		private static readonly FieldCodec<FloroUnLockInfo> _repeated_insUnLockCondition_codec = FieldCodec.ForMessage<FloroUnLockInfo>(146U, FloroUnLockInfo.Parser);

		// Token: 0x040042AD RID: 17069
		private readonly RepeatedField<FloroUnLockInfo> insUnLockCondition_ = new RepeatedField<FloroUnLockInfo>();
	}
}
