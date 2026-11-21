using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECE RID: 3790
	public sealed class RegressData : IMessage<RegressData>, IMessage, IEquatable<RegressData>, IDeepCloneable<RegressData>, IBufferMessage
	{
		// Token: 0x06014577 RID: 83319 RVA: 0x002F52F0 File Offset: 0x002F34F0
		[NullableContext(1)]
		public static RegressData Create()
		{
			return new RegressData();
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x06014578 RID: 83320 RVA: 0x002F52F7 File Offset: 0x002F34F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x06014579 RID: 83321 RVA: 0x002F52FA File Offset: 0x002F34FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressData.Descriptor;
			}
		}

		// Token: 0x0601457A RID: 83322 RVA: 0x002F5304 File Offset: 0x002F3504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData()
		{
		}

		// Token: 0x0601457B RID: 83323 RVA: 0x002F5364 File Offset: 0x002F3564
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

		// Token: 0x0601457C RID: 83324 RVA: 0x002F5493 File Offset: 0x002F3693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressData Clone()
		{
			return new RegressData(this);
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x0601457D RID: 83325 RVA: 0x002F549B File Offset: 0x002F369B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x0601457E RID: 83326 RVA: 0x002F54A3 File Offset: 0x002F36A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SignRewards
		{
			get
			{
				return this.signRewards_;
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x0601457F RID: 83327 RVA: 0x002F54AB File Offset: 0x002F36AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewards
		{
			get
			{
				return this.scoreRewards_;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x06014580 RID: 83328 RVA: 0x002F54B3 File Offset: 0x002F36B3
		// (set) Token: 0x06014581 RID: 83329 RVA: 0x002F54BB File Offset: 0x002F36BB
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

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x06014582 RID: 83330 RVA: 0x002F54C4 File Offset: 0x002F36C4
		// (set) Token: 0x06014583 RID: 83331 RVA: 0x002F54CC File Offset: 0x002F36CC
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

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x06014584 RID: 83332 RVA: 0x002F54D5 File Offset: 0x002F36D5
		// (set) Token: 0x06014585 RID: 83333 RVA: 0x002F54DD File Offset: 0x002F36DD
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

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x06014586 RID: 83334 RVA: 0x002F54E6 File Offset: 0x002F36E6
		// (set) Token: 0x06014587 RID: 83335 RVA: 0x002F54EE File Offset: 0x002F36EE
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

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x06014588 RID: 83336 RVA: 0x002F54F7 File Offset: 0x002F36F7
		// (set) Token: 0x06014589 RID: 83337 RVA: 0x002F54FF File Offset: 0x002F36FF
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

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x0601458A RID: 83338 RVA: 0x002F5508 File Offset: 0x002F3708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Questionnaire
		{
			get
			{
				return this.questionnaire_;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x0601458B RID: 83339 RVA: 0x002F5510 File Offset: 0x002F3710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestionTask> Question
		{
			get
			{
				return this.question_;
			}
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x0601458C RID: 83340 RVA: 0x002F5518 File Offset: 0x002F3718
		// (set) Token: 0x0601458D RID: 83341 RVA: 0x002F5520 File Offset: 0x002F3720
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

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x0601458E RID: 83342 RVA: 0x002F5529 File Offset: 0x002F3729
		// (set) Token: 0x0601458F RID: 83343 RVA: 0x002F5531 File Offset: 0x002F3731
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

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x06014590 RID: 83344 RVA: 0x002F553A File Offset: 0x002F373A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PayScoreRewards
		{
			get
			{
				return this.payScoreRewards_;
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x06014591 RID: 83345 RVA: 0x002F5542 File Offset: 0x002F3742
		// (set) Token: 0x06014592 RID: 83346 RVA: 0x002F554A File Offset: 0x002F374A
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

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x06014593 RID: 83347 RVA: 0x002F5553 File Offset: 0x002F3753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x06014594 RID: 83348 RVA: 0x002F555B File Offset: 0x002F375B
		// (set) Token: 0x06014595 RID: 83349 RVA: 0x002F5563 File Offset: 0x002F3763
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

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x06014596 RID: 83350 RVA: 0x002F556C File Offset: 0x002F376C
		// (set) Token: 0x06014597 RID: 83351 RVA: 0x002F5574 File Offset: 0x002F3774
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

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x06014598 RID: 83352 RVA: 0x002F557D File Offset: 0x002F377D
		// (set) Token: 0x06014599 RID: 83353 RVA: 0x002F5585 File Offset: 0x002F3785
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

		// Token: 0x0601459A RID: 83354 RVA: 0x002F558E File Offset: 0x002F378E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressData);
		}

		// Token: 0x0601459B RID: 83355 RVA: 0x002F559C File Offset: 0x002F379C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.signRewards_.Equals(other.signRewards_) && this.scoreRewards_.Equals(other.scoreRewards_) && this.GradeId == other.GradeId && this.EndTime == other.EndTime && this.NextRefreshTime == other.NextRefreshTime && this.BossDoubleCount == other.BossDoubleCount && this.WeekDoubleCount == other.WeekDoubleCount && this.questionnaire_.Equals(other.questionnaire_) && this.question_.Equals(other.question_) && this.BossDoubleUnLock == other.BossDoubleUnLock && this.WeekDoubleUnLock == other.WeekDoubleUnLock && this.payScoreRewards_.Equals(other.payScoreRewards_) && this.DisposableReward == other.DisposableReward && this.roleInfo_.Equals(other.roleInfo_) && this.PayRewardUnlock == other.PayRewardUnlock && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601459C RID: 83356 RVA: 0x002F5710 File Offset: 0x002F3910
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

		// Token: 0x0601459D RID: 83357 RVA: 0x002F58A8 File Offset: 0x002F3AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601459E RID: 83358 RVA: 0x002F58B5 File Offset: 0x002F3AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601459F RID: 83359 RVA: 0x002F58C0 File Offset: 0x002F3AC0
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

		// Token: 0x060145A0 RID: 83360 RVA: 0x002F5A98 File Offset: 0x002F3C98
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

		// Token: 0x060145A1 RID: 83361 RVA: 0x002F5C1C File Offset: 0x002F3E1C
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

		// Token: 0x060145A2 RID: 83362 RVA: 0x002F5DAF File Offset: 0x002F3FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145A3 RID: 83363 RVA: 0x002F5DB8 File Offset: 0x002F3FB8
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

		// Token: 0x04007BED RID: 31725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BEE RID: 31726
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04007BEF RID: 31727
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04007BF0 RID: 31728
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04007BF1 RID: 31729
		public const int SignRewardsFieldNumber = 2;

		// Token: 0x04007BF2 RID: 31730
		private static readonly FieldCodec<ActivityTask> _repeated_signRewards_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04007BF3 RID: 31731
		private readonly RepeatedField<ActivityTask> signRewards_ = new RepeatedField<ActivityTask>();

		// Token: 0x04007BF4 RID: 31732
		public const int ScoreRewardsFieldNumber = 3;

		// Token: 0x04007BF5 RID: 31733
		private static readonly FieldCodec<int> _repeated_scoreRewards_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007BF6 RID: 31734
		private readonly RepeatedField<int> scoreRewards_ = new RepeatedField<int>();

		// Token: 0x04007BF7 RID: 31735
		public const int GradeIdFieldNumber = 4;

		// Token: 0x04007BF8 RID: 31736
		private int gradeId_;

		// Token: 0x04007BF9 RID: 31737
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04007BFA RID: 31738
		private long endTime_;

		// Token: 0x04007BFB RID: 31739
		public const int NextRefreshTimeFieldNumber = 7;

		// Token: 0x04007BFC RID: 31740
		private long nextRefreshTime_;

		// Token: 0x04007BFD RID: 31741
		public const int BossDoubleCountFieldNumber = 8;

		// Token: 0x04007BFE RID: 31742
		private int bossDoubleCount_;

		// Token: 0x04007BFF RID: 31743
		public const int WeekDoubleCountFieldNumber = 9;

		// Token: 0x04007C00 RID: 31744
		private int weekDoubleCount_;

		// Token: 0x04007C01 RID: 31745
		public const int QuestionnaireFieldNumber = 10;

		// Token: 0x04007C02 RID: 31746
		private static readonly FieldCodec<int> _repeated_questionnaire_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007C03 RID: 31747
		private readonly RepeatedField<int> questionnaire_ = new RepeatedField<int>();

		// Token: 0x04007C04 RID: 31748
		public const int QuestionFieldNumber = 13;

		// Token: 0x04007C05 RID: 31749
		private static readonly FieldCodec<QuestionTask> _repeated_question_codec = FieldCodec.ForMessage<QuestionTask>(106U, QuestionTask.Parser);

		// Token: 0x04007C06 RID: 31750
		private readonly RepeatedField<QuestionTask> question_ = new RepeatedField<QuestionTask>();

		// Token: 0x04007C07 RID: 31751
		public const int BossDoubleUnLockFieldNumber = 11;

		// Token: 0x04007C08 RID: 31752
		private bool bossDoubleUnLock_;

		// Token: 0x04007C09 RID: 31753
		public const int WeekDoubleUnLockFieldNumber = 12;

		// Token: 0x04007C0A RID: 31754
		private bool weekDoubleUnLock_;

		// Token: 0x04007C0B RID: 31755
		public const int PayScoreRewardsFieldNumber = 14;

		// Token: 0x04007C0C RID: 31756
		private static readonly FieldCodec<int> _repeated_payScoreRewards_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04007C0D RID: 31757
		private readonly RepeatedField<int> payScoreRewards_ = new RepeatedField<int>();

		// Token: 0x04007C0E RID: 31758
		public const int DisposableRewardFieldNumber = 15;

		// Token: 0x04007C0F RID: 31759
		private bool disposableReward_;

		// Token: 0x04007C10 RID: 31760
		public const int RoleInfoFieldNumber = 16;

		// Token: 0x04007C11 RID: 31761
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_roleInfo_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(130U, NewTrialRoleInfo.Parser);

		// Token: 0x04007C12 RID: 31762
		private readonly RepeatedField<NewTrialRoleInfo> roleInfo_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04007C13 RID: 31763
		public const int PayRewardUnlockFieldNumber = 17;

		// Token: 0x04007C14 RID: 31764
		private bool payRewardUnlock_;

		// Token: 0x04007C15 RID: 31765
		public const int CurUseTrialRoleIdFieldNumber = 18;

		// Token: 0x04007C16 RID: 31766
		private int curUseTrialRoleId_;

		// Token: 0x04007C17 RID: 31767
		public const int CurUseRoleInfoFieldNumber = 19;

		// Token: 0x04007C18 RID: 31768
		private roleInfo curUseRoleInfo_;
	}
}
