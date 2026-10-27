using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EDE RID: 3806
	public sealed class RegressData : IMessage<RegressData>, IMessage, IEquatable<RegressData>, IDeepCloneable<RegressData>, IBufferMessage
	{
		// Token: 0x0601465C RID: 83548 RVA: 0x002F699F File Offset: 0x002F4B9F
		[NullableContext(1)]
		public static RegressData Create()
		{
			return new RegressData();
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0601465D RID: 83549 RVA: 0x002F69A6 File Offset: 0x002F4BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x0601465E RID: 83550 RVA: 0x002F69A9 File Offset: 0x002F4BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressData.Descriptor;
			}
		}

		// Token: 0x0601465F RID: 83551 RVA: 0x002F69B0 File Offset: 0x002F4BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData()
		{
		}

		// Token: 0x06014660 RID: 83552 RVA: 0x002F6A10 File Offset: 0x002F4C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData(RegressData other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this.signRewards_ = other.signRewards_.Clone();
			this.scoreRewards_ = other.scoreRewards_.Clone();
			this.gradeId_ = other.gradeId_;
			this.endTime_ = other.endTime_;
			this.nextRefreshTime_ = other.nextRefreshTime_;
			this.bossDoubleCount_ = other.bossDoubleCount_;
			this.weekDoubleCount_ = other.weekDoubleCount_;
			this.questionnaire_ = other.questionnaire_.Clone();
			this.question_ = other.question_.Clone();
			this.bossDoubleUnLock_ = other.bossDoubleUnLock_;
			this.weekDoubleUnLock_ = other.weekDoubleUnLock_;
			this.payScoreRewards_ = other.payScoreRewards_.Clone();
			this.disposableReward_ = other.disposableReward_;
			this.roleInfo_ = other.roleInfo_.Clone();
			this.payRewardUnlock_ = other.payRewardUnlock_;
			this.curUseTrialRoleId_ = other.curUseTrialRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014661 RID: 83553 RVA: 0x002F6B3F File Offset: 0x002F4D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData Clone()
		{
			return new RegressData(this);
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x06014662 RID: 83554 RVA: 0x002F6B47 File Offset: 0x002F4D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x06014663 RID: 83555 RVA: 0x002F6B4F File Offset: 0x002F4D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SignRewards
		{
			get
			{
				return this.signRewards_;
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x06014664 RID: 83556 RVA: 0x002F6B57 File Offset: 0x002F4D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewards
		{
			get
			{
				return this.scoreRewards_;
			}
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x06014665 RID: 83557 RVA: 0x002F6B5F File Offset: 0x002F4D5F
		// (set) Token: 0x06014666 RID: 83558 RVA: 0x002F6B67 File Offset: 0x002F4D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GradeId
		{
			get
			{
				return this.gradeId_;
			}
			set
			{
				this.gradeId_ = value;
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x06014667 RID: 83559 RVA: 0x002F6B70 File Offset: 0x002F4D70
		// (set) Token: 0x06014668 RID: 83560 RVA: 0x002F6B78 File Offset: 0x002F4D78
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

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x06014669 RID: 83561 RVA: 0x002F6B81 File Offset: 0x002F4D81
		// (set) Token: 0x0601466A RID: 83562 RVA: 0x002F6B89 File Offset: 0x002F4D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRefreshTime
		{
			get
			{
				return this.nextRefreshTime_;
			}
			set
			{
				this.nextRefreshTime_ = value;
			}
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x0601466B RID: 83563 RVA: 0x002F6B92 File Offset: 0x002F4D92
		// (set) Token: 0x0601466C RID: 83564 RVA: 0x002F6B9A File Offset: 0x002F4D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossDoubleCount
		{
			get
			{
				return this.bossDoubleCount_;
			}
			set
			{
				this.bossDoubleCount_ = value;
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x0601466D RID: 83565 RVA: 0x002F6BA3 File Offset: 0x002F4DA3
		// (set) Token: 0x0601466E RID: 83566 RVA: 0x002F6BAB File Offset: 0x002F4DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekDoubleCount
		{
			get
			{
				return this.weekDoubleCount_;
			}
			set
			{
				this.weekDoubleCount_ = value;
			}
		}

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x0601466F RID: 83567 RVA: 0x002F6BB4 File Offset: 0x002F4DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Questionnaire
		{
			get
			{
				return this.questionnaire_;
			}
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x06014670 RID: 83568 RVA: 0x002F6BBC File Offset: 0x002F4DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestionTask> Question
		{
			get
			{
				return this.question_;
			}
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x06014671 RID: 83569 RVA: 0x002F6BC4 File Offset: 0x002F4DC4
		// (set) Token: 0x06014672 RID: 83570 RVA: 0x002F6BCC File Offset: 0x002F4DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BossDoubleUnLock
		{
			get
			{
				return this.bossDoubleUnLock_;
			}
			set
			{
				this.bossDoubleUnLock_ = value;
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x06014673 RID: 83571 RVA: 0x002F6BD5 File Offset: 0x002F4DD5
		// (set) Token: 0x06014674 RID: 83572 RVA: 0x002F6BDD File Offset: 0x002F4DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool WeekDoubleUnLock
		{
			get
			{
				return this.weekDoubleUnLock_;
			}
			set
			{
				this.weekDoubleUnLock_ = value;
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x06014675 RID: 83573 RVA: 0x002F6BE6 File Offset: 0x002F4DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PayScoreRewards
		{
			get
			{
				return this.payScoreRewards_;
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x06014676 RID: 83574 RVA: 0x002F6BEE File Offset: 0x002F4DEE
		// (set) Token: 0x06014677 RID: 83575 RVA: 0x002F6BF6 File Offset: 0x002F4DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DisposableReward
		{
			get
			{
				return this.disposableReward_;
			}
			set
			{
				this.disposableReward_ = value;
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x06014678 RID: 83576 RVA: 0x002F6BFF File Offset: 0x002F4DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x06014679 RID: 83577 RVA: 0x002F6C07 File Offset: 0x002F4E07
		// (set) Token: 0x0601467A RID: 83578 RVA: 0x002F6C0F File Offset: 0x002F4E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PayRewardUnlock
		{
			get
			{
				return this.payRewardUnlock_;
			}
			set
			{
				this.payRewardUnlock_ = value;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x0601467B RID: 83579 RVA: 0x002F6C18 File Offset: 0x002F4E18
		// (set) Token: 0x0601467C RID: 83580 RVA: 0x002F6C20 File Offset: 0x002F4E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurUseTrialRoleId
		{
			get
			{
				return this.curUseTrialRoleId_;
			}
			set
			{
				this.curUseTrialRoleId_ = value;
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0601467D RID: 83581 RVA: 0x002F6C29 File Offset: 0x002F4E29
		// (set) Token: 0x0601467E RID: 83582 RVA: 0x002F6C31 File Offset: 0x002F4E31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo CurUseRoleInfo
		{
			get
			{
				return this.curUseRoleInfo_;
			}
			set
			{
				this.curUseRoleInfo_ = value;
			}
		}

		// Token: 0x0601467F RID: 83583 RVA: 0x002F6C3A File Offset: 0x002F4E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressData);
		}

		// Token: 0x06014680 RID: 83584 RVA: 0x002F6C48 File Offset: 0x002F4E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.signRewards_.Equals(other.signRewards_) && this.scoreRewards_.Equals(other.scoreRewards_) && this.GradeId == other.GradeId && this.EndTime == other.EndTime && this.NextRefreshTime == other.NextRefreshTime && this.BossDoubleCount == other.BossDoubleCount && this.WeekDoubleCount == other.WeekDoubleCount && this.questionnaire_.Equals(other.questionnaire_) && this.question_.Equals(other.question_) && this.BossDoubleUnLock == other.BossDoubleUnLock && this.WeekDoubleUnLock == other.WeekDoubleUnLock && this.payScoreRewards_.Equals(other.payScoreRewards_) && this.DisposableReward == other.DisposableReward && this.roleInfo_.Equals(other.roleInfo_) && this.PayRewardUnlock == other.PayRewardUnlock && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014681 RID: 83585 RVA: 0x002F6DBC File Offset: 0x002F4FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			num ^= this.signRewards_.GetHashCode();
			num ^= this.scoreRewards_.GetHashCode();
			if (this.GradeId != 0)
			{
				num ^= this.GradeId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.NextRefreshTime != 0L)
			{
				num ^= this.NextRefreshTime.GetHashCode();
			}
			if (this.BossDoubleCount != 0)
			{
				num ^= this.BossDoubleCount.GetHashCode();
			}
			if (this.WeekDoubleCount != 0)
			{
				num ^= this.WeekDoubleCount.GetHashCode();
			}
			num ^= this.questionnaire_.GetHashCode();
			num ^= this.question_.GetHashCode();
			if (this.BossDoubleUnLock)
			{
				num ^= this.BossDoubleUnLock.GetHashCode();
			}
			if (this.WeekDoubleUnLock)
			{
				num ^= this.WeekDoubleUnLock.GetHashCode();
			}
			num ^= this.payScoreRewards_.GetHashCode();
			if (this.DisposableReward)
			{
				num ^= this.DisposableReward.GetHashCode();
			}
			num ^= this.roleInfo_.GetHashCode();
			if (this.PayRewardUnlock)
			{
				num ^= this.PayRewardUnlock.GetHashCode();
			}
			if (this.CurUseTrialRoleId != 0)
			{
				num ^= this.CurUseTrialRoleId.GetHashCode();
			}
			if (this.curUseRoleInfo_ != null)
			{
				num ^= this.CurUseRoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014682 RID: 83586 RVA: 0x002F6F54 File Offset: 0x002F5154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014683 RID: 83587 RVA: 0x002F6F61 File Offset: 0x002F5161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014684 RID: 83588 RVA: 0x002F6F6C File Offset: 0x002F516C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, RegressData._repeated_activityTasks_codec);
			this.signRewards_.WriteTo(ref output, RegressData._repeated_signRewards_codec);
			this.scoreRewards_.WriteTo(ref output, RegressData._repeated_scoreRewards_codec);
			if (this.GradeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GradeId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EndTime);
			}
			if (this.NextRefreshTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.NextRefreshTime);
			}
			if (this.BossDoubleCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BossDoubleCount);
			}
			if (this.WeekDoubleCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeekDoubleCount);
			}
			this.questionnaire_.WriteTo(ref output, RegressData._repeated_questionnaire_codec);
			if (this.BossDoubleUnLock)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.BossDoubleUnLock);
			}
			if (this.WeekDoubleUnLock)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.WeekDoubleUnLock);
			}
			this.question_.WriteTo(ref output, RegressData._repeated_question_codec);
			this.payScoreRewards_.WriteTo(ref output, RegressData._repeated_payScoreRewards_codec);
			if (this.DisposableReward)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.DisposableReward);
			}
			this.roleInfo_.WriteTo(ref output, RegressData._repeated_roleInfo_codec);
			if (this.PayRewardUnlock)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.PayRewardUnlock);
			}
			if (this.CurUseTrialRoleId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014685 RID: 83589 RVA: 0x002F7144 File Offset: 0x002F5344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(RegressData._repeated_activityTasks_codec);
			num += this.signRewards_.CalculateSize(RegressData._repeated_signRewards_codec);
			num += this.scoreRewards_.CalculateSize(RegressData._repeated_scoreRewards_codec);
			if (this.GradeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GradeId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.NextRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRefreshTime);
			}
			if (this.BossDoubleCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossDoubleCount);
			}
			if (this.WeekDoubleCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekDoubleCount);
			}
			num += this.questionnaire_.CalculateSize(RegressData._repeated_questionnaire_codec);
			num += this.question_.CalculateSize(RegressData._repeated_question_codec);
			if (this.BossDoubleUnLock)
			{
				num += 2;
			}
			if (this.WeekDoubleUnLock)
			{
				num += 2;
			}
			num += this.payScoreRewards_.CalculateSize(RegressData._repeated_payScoreRewards_codec);
			if (this.DisposableReward)
			{
				num += 2;
			}
			num += this.roleInfo_.CalculateSize(RegressData._repeated_roleInfo_codec);
			if (this.PayRewardUnlock)
			{
				num += 3;
			}
			if (this.CurUseTrialRoleId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CurUseRoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014686 RID: 83590 RVA: 0x002F72C8 File Offset: 0x002F54C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressData other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this.signRewards_.Add(other.signRewards_);
			this.scoreRewards_.Add(other.scoreRewards_);
			if (other.GradeId != 0)
			{
				this.GradeId = other.GradeId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.NextRefreshTime != 0L)
			{
				this.NextRefreshTime = other.NextRefreshTime;
			}
			if (other.BossDoubleCount != 0)
			{
				this.BossDoubleCount = other.BossDoubleCount;
			}
			if (other.WeekDoubleCount != 0)
			{
				this.WeekDoubleCount = other.WeekDoubleCount;
			}
			this.questionnaire_.Add(other.questionnaire_);
			this.question_.Add(other.question_);
			if (other.BossDoubleUnLock)
			{
				this.BossDoubleUnLock = other.BossDoubleUnLock;
			}
			if (other.WeekDoubleUnLock)
			{
				this.WeekDoubleUnLock = other.WeekDoubleUnLock;
			}
			this.payScoreRewards_.Add(other.payScoreRewards_);
			if (other.DisposableReward)
			{
				this.DisposableReward = other.DisposableReward;
			}
			this.roleInfo_.Add(other.roleInfo_);
			if (other.PayRewardUnlock)
			{
				this.PayRewardUnlock = other.PayRewardUnlock;
			}
			if (other.CurUseTrialRoleId != 0)
			{
				this.CurUseTrialRoleId = other.CurUseTrialRoleId;
			}
			if (other.curUseRoleInfo_ != null)
			{
				if (this.curUseRoleInfo_ == null)
				{
					this.CurUseRoleInfo = new roleInfo();
				}
				this.CurUseRoleInfo.MergeFrom(other.CurUseRoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x002F745B File Offset: 0x002F565B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014688 RID: 83592 RVA: 0x002F7464 File Offset: 0x002F5664
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
				if (num > 80U)
				{
					if (num <= 112U)
					{
						if (num <= 88U)
						{
							if (num == 82U)
							{
								goto IL_1AB;
							}
							if (num != 88U)
							{
								goto IL_FD;
							}
							this.BossDoubleUnLock = input.ReadBool();
							continue;
						}
						else
						{
							if (num == 96U)
							{
								this.WeekDoubleUnLock = input.ReadBool();
								continue;
							}
							if (num == 106U)
							{
								this.question_.AddEntriesFrom(ref input, RegressData._repeated_question_codec);
								continue;
							}
							if (num != 112U)
							{
								goto IL_FD;
							}
						}
					}
					else if (num <= 130U)
					{
						if (num != 114U)
						{
							if (num == 120U)
							{
								this.DisposableReward = input.ReadBool();
								continue;
							}
							if (num != 130U)
							{
								goto IL_FD;
							}
							this.roleInfo_.AddEntriesFrom(ref input, RegressData._repeated_roleInfo_codec);
							continue;
						}
					}
					else
					{
						if (num == 136U)
						{
							this.PayRewardUnlock = input.ReadBool();
							continue;
						}
						if (num == 144U)
						{
							this.CurUseTrialRoleId = input.ReadInt32();
							continue;
						}
						if (num != 154U)
						{
							goto IL_FD;
						}
						if (this.curUseRoleInfo_ == null)
						{
							this.CurUseRoleInfo = new roleInfo();
						}
						input.ReadMessage(this.CurUseRoleInfo);
						continue;
					}
					this.payScoreRewards_.AddEntriesFrom(ref input, RegressData._repeated_payScoreRewards_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							this.activityTasks_.AddEntriesFrom(ref input, RegressData._repeated_activityTasks_codec);
							continue;
						}
						if (num == 18U)
						{
							this.signRewards_.AddEntriesFrom(ref input, RegressData._repeated_signRewards_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U || num == 26U)
						{
							this.scoreRewards_.AddEntriesFrom(ref input, RegressData._repeated_scoreRewards_codec);
							continue;
						}
						if (num == 32U)
						{
							this.GradeId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.NextRefreshTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.BossDoubleCount = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.WeekDoubleCount = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						goto IL_1AB;
					}
				}
				IL_FD:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_1AB:
				this.questionnaire_.AddEntriesFrom(ref input, RegressData._repeated_questionnaire_codec);
			}
		}

		// Token: 0x04007BC3 RID: 31683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BC4 RID: 31684
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007BC5 RID: 31685
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04007BC6 RID: 31686
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04007BC7 RID: 31687
		public const int SignRewardsFieldNumber = 2;

		// Token: 0x04007BC8 RID: 31688
		private static readonly FieldCodec<ActivityTask> _repeated_signRewards_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04007BC9 RID: 31689
		private readonly RepeatedField<ActivityTask> signRewards_ = new RepeatedField<ActivityTask>();

		// Token: 0x04007BCA RID: 31690
		public const int ScoreRewardsFieldNumber = 3;

		// Token: 0x04007BCB RID: 31691
		private static readonly FieldCodec<int> _repeated_scoreRewards_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007BCC RID: 31692
		private readonly RepeatedField<int> scoreRewards_ = new RepeatedField<int>();

		// Token: 0x04007BCD RID: 31693
		public const int GradeIdFieldNumber = 4;

		// Token: 0x04007BCE RID: 31694
		private int gradeId_;

		// Token: 0x04007BCF RID: 31695
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04007BD0 RID: 31696
		private long endTime_;

		// Token: 0x04007BD1 RID: 31697
		public const int NextRefreshTimeFieldNumber = 7;

		// Token: 0x04007BD2 RID: 31698
		private long nextRefreshTime_;

		// Token: 0x04007BD3 RID: 31699
		public const int BossDoubleCountFieldNumber = 8;

		// Token: 0x04007BD4 RID: 31700
		private int bossDoubleCount_;

		// Token: 0x04007BD5 RID: 31701
		public const int WeekDoubleCountFieldNumber = 9;

		// Token: 0x04007BD6 RID: 31702
		private int weekDoubleCount_;

		// Token: 0x04007BD7 RID: 31703
		public const int QuestionnaireFieldNumber = 10;

		// Token: 0x04007BD8 RID: 31704
		private static readonly FieldCodec<int> _repeated_questionnaire_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007BD9 RID: 31705
		private readonly RepeatedField<int> questionnaire_ = new RepeatedField<int>();

		// Token: 0x04007BDA RID: 31706
		public const int QuestionFieldNumber = 13;

		// Token: 0x04007BDB RID: 31707
		private static readonly FieldCodec<QuestionTask> _repeated_question_codec = FieldCodec.ForMessage<QuestionTask>(106U, QuestionTask.Parser);

		// Token: 0x04007BDC RID: 31708
		private readonly RepeatedField<QuestionTask> question_ = new RepeatedField<QuestionTask>();

		// Token: 0x04007BDD RID: 31709
		public const int BossDoubleUnLockFieldNumber = 11;

		// Token: 0x04007BDE RID: 31710
		private bool bossDoubleUnLock_;

		// Token: 0x04007BDF RID: 31711
		public const int WeekDoubleUnLockFieldNumber = 12;

		// Token: 0x04007BE0 RID: 31712
		private bool weekDoubleUnLock_;

		// Token: 0x04007BE1 RID: 31713
		public const int PayScoreRewardsFieldNumber = 14;

		// Token: 0x04007BE2 RID: 31714
		private static readonly FieldCodec<int> _repeated_payScoreRewards_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04007BE3 RID: 31715
		private readonly RepeatedField<int> payScoreRewards_ = new RepeatedField<int>();

		// Token: 0x04007BE4 RID: 31716
		public const int DisposableRewardFieldNumber = 15;

		// Token: 0x04007BE5 RID: 31717
		private bool disposableReward_;

		// Token: 0x04007BE6 RID: 31718
		public const int RoleInfoFieldNumber = 16;

		// Token: 0x04007BE7 RID: 31719
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(130U, NewTrialRoleInfo.Parser);

		// Token: 0x04007BE8 RID: 31720
		private readonly RepeatedField<NewTrialRoleInfo> roleInfo_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04007BE9 RID: 31721
		public const int PayRewardUnlockFieldNumber = 17;

		// Token: 0x04007BEA RID: 31722
		private bool payRewardUnlock_;

		// Token: 0x04007BEB RID: 31723
		public const int CurUseTrialRoleIdFieldNumber = 18;

		// Token: 0x04007BEC RID: 31724
		private int curUseTrialRoleId_;

		// Token: 0x04007BED RID: 31725
		public const int CurUseRoleInfoFieldNumber = 19;

		// Token: 0x04007BEE RID: 31726
		private roleInfo curUseRoleInfo_;
	}
}
