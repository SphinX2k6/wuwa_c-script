using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2E RID: 2862
	public sealed class NewTowerClimbingActivityData : IMessage<NewTowerClimbingActivityData>, IMessage, IEquatable<NewTowerClimbingActivityData>, IDeepCloneable<NewTowerClimbingActivityData>, IBufferMessage
	{
		// Token: 0x0600F864 RID: 63588 RVA: 0x002436E1 File Offset: 0x002418E1
		[NullableContext(1)]
		public static NewTowerClimbingActivityData Create()
		{
			return new NewTowerClimbingActivityData();
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600F865 RID: 63589 RVA: 0x002436E8 File Offset: 0x002418E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x002436EB File Offset: 0x002418EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingActivityData.Descriptor;
			}
		}

		// Token: 0x0600F867 RID: 63591 RVA: 0x002436F2 File Offset: 0x002418F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData()
		{
		}

		// Token: 0x0600F868 RID: 63592 RVA: 0x00243728 File Offset: 0x00241928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData(NewTowerClimbingActivityData other) : this()
		{
			this.cycleId_ = other.cycleId_;
			this.records_ = other.records_.Clone();
			this.scoreTasks_ = other.scoreTasks_.Clone();
			this.activityTasks_ = other.activityTasks_.Clone();
			this.cycleBeginTime_ = other.cycleBeginTime_;
			this.cycleCloseTime_ = other.cycleCloseTime_;
			this.seasonId_ = other.seasonId_;
			this.seasonBeginTime_ = other.seasonBeginTime_;
			this.seasonCloseTime_ = other.seasonCloseTime_;
			this.seasonTasks_ = other.seasonTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x002437D8 File Offset: 0x002419D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData Clone()
		{
			return new NewTowerClimbingActivityData(this);
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600F86A RID: 63594 RVA: 0x002437E0 File Offset: 0x002419E0
		// (set) Token: 0x0600F86B RID: 63595 RVA: 0x002437E8 File Offset: 0x002419E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600F86C RID: 63596 RVA: 0x002437F1 File Offset: 0x002419F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerClimbingLevelRecord> Records
		{
			get
			{
				return this.records_;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600F86D RID: 63597 RVA: 0x002437F9 File Offset: 0x002419F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600F86E RID: 63598 RVA: 0x00243801 File Offset: 0x00241A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600F86F RID: 63599 RVA: 0x00243809 File Offset: 0x00241A09
		// (set) Token: 0x0600F870 RID: 63600 RVA: 0x00243811 File Offset: 0x00241A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CycleBeginTime
		{
			get
			{
				return this.cycleBeginTime_;
			}
			set
			{
				this.cycleBeginTime_ = value;
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600F871 RID: 63601 RVA: 0x0024381A File Offset: 0x00241A1A
		// (set) Token: 0x0600F872 RID: 63602 RVA: 0x00243822 File Offset: 0x00241A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CycleCloseTime
		{
			get
			{
				return this.cycleCloseTime_;
			}
			set
			{
				this.cycleCloseTime_ = value;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600F873 RID: 63603 RVA: 0x0024382B File Offset: 0x00241A2B
		// (set) Token: 0x0600F874 RID: 63604 RVA: 0x00243833 File Offset: 0x00241A33
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

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600F875 RID: 63605 RVA: 0x0024383C File Offset: 0x00241A3C
		// (set) Token: 0x0600F876 RID: 63606 RVA: 0x00243844 File Offset: 0x00241A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SeasonBeginTime
		{
			get
			{
				return this.seasonBeginTime_;
			}
			set
			{
				this.seasonBeginTime_ = value;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600F877 RID: 63607 RVA: 0x0024384D File Offset: 0x00241A4D
		// (set) Token: 0x0600F878 RID: 63608 RVA: 0x00243855 File Offset: 0x00241A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SeasonCloseTime
		{
			get
			{
				return this.seasonCloseTime_;
			}
			set
			{
				this.seasonCloseTime_ = value;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600F879 RID: 63609 RVA: 0x0024385E File Offset: 0x00241A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x0600F87A RID: 63610 RVA: 0x00243866 File Offset: 0x00241A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingActivityData);
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x00243874 File Offset: 0x00241A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingActivityData other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.records_.Equals(other.records_) && this.scoreTasks_.Equals(other.scoreTasks_) && this.activityTasks_.Equals(other.activityTasks_) && this.CycleBeginTime == other.CycleBeginTime && this.CycleCloseTime == other.CycleCloseTime && this.SeasonId == other.SeasonId && this.SeasonBeginTime == other.SeasonBeginTime && this.SeasonCloseTime == other.SeasonCloseTime && this.seasonTasks_.Equals(other.seasonTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x00243954 File Offset: 0x00241B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			num ^= this.records_.GetHashCode();
			num ^= this.scoreTasks_.GetHashCode();
			num ^= this.activityTasks_.GetHashCode();
			if (this.CycleBeginTime != 0L)
			{
				num ^= this.CycleBeginTime.GetHashCode();
			}
			if (this.CycleCloseTime != 0L)
			{
				num ^= this.CycleCloseTime.GetHashCode();
			}
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.SeasonBeginTime != 0L)
			{
				num ^= this.SeasonBeginTime.GetHashCode();
			}
			if (this.SeasonCloseTime != 0L)
			{
				num ^= this.SeasonCloseTime.GetHashCode();
			}
			num ^= this.seasonTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x00243A48 File Offset: 0x00241C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x00243A55 File Offset: 0x00241C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F87F RID: 63615 RVA: 0x00243A60 File Offset: 0x00241C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CycleId);
			}
			this.records_.WriteTo(ref output, NewTowerClimbingActivityData._repeated_records_codec);
			this.scoreTasks_.WriteTo(ref output, NewTowerClimbingActivityData._repeated_scoreTasks_codec);
			this.activityTasks_.WriteTo(ref output, NewTowerClimbingActivityData._repeated_activityTasks_codec);
			if (this.CycleBeginTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CycleBeginTime);
			}
			if (this.CycleCloseTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CycleCloseTime);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SeasonId);
			}
			if (this.SeasonBeginTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.SeasonBeginTime);
			}
			if (this.SeasonCloseTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SeasonCloseTime);
			}
			this.seasonTasks_.WriteTo(ref output, NewTowerClimbingActivityData._repeated_seasonTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F880 RID: 63616 RVA: 0x00243B6C File Offset: 0x00241D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			num += this.records_.CalculateSize(NewTowerClimbingActivityData._repeated_records_codec);
			num += this.scoreTasks_.CalculateSize(NewTowerClimbingActivityData._repeated_scoreTasks_codec);
			num += this.activityTasks_.CalculateSize(NewTowerClimbingActivityData._repeated_activityTasks_codec);
			if (this.CycleBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CycleBeginTime);
			}
			if (this.CycleCloseTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CycleCloseTime);
			}
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.SeasonBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SeasonBeginTime);
			}
			if (this.SeasonCloseTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SeasonCloseTime);
			}
			num += this.seasonTasks_.CalculateSize(NewTowerClimbingActivityData._repeated_seasonTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F881 RID: 63617 RVA: 0x00243C70 File Offset: 0x00241E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClimbingActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			this.records_.Add(other.records_);
			this.scoreTasks_.Add(other.scoreTasks_);
			this.activityTasks_.Add(other.activityTasks_);
			if (other.CycleBeginTime != 0L)
			{
				this.CycleBeginTime = other.CycleBeginTime;
			}
			if (other.CycleCloseTime != 0L)
			{
				this.CycleCloseTime = other.CycleCloseTime;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.SeasonBeginTime != 0L)
			{
				this.SeasonBeginTime = other.SeasonBeginTime;
			}
			if (other.SeasonCloseTime != 0L)
			{
				this.SeasonCloseTime = other.SeasonCloseTime;
			}
			this.seasonTasks_.Add(other.seasonTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F882 RID: 63618 RVA: 0x00243D54 File Offset: 0x00241F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F883 RID: 63619 RVA: 0x00243D60 File Offset: 0x00241F60
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
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.CycleId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.records_.AddEntriesFrom(ref input, NewTowerClimbingActivityData._repeated_records_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U || num == 26U)
						{
							this.scoreTasks_.AddEntriesFrom(ref input, NewTowerClimbingActivityData._repeated_scoreTasks_codec);
							continue;
						}
						if (num == 34U)
						{
							this.activityTasks_.AddEntriesFrom(ref input, NewTowerClimbingActivityData._repeated_activityTasks_codec);
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 40U)
					{
						this.CycleBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.CycleCloseTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.SeasonBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.SeasonCloseTime = input.ReadInt64();
						continue;
					}
					if (num == 82U)
					{
						this.seasonTasks_.AddEntriesFrom(ref input, NewTowerClimbingActivityData._repeated_seasonTasks_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400638E RID: 25486
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400638F RID: 25487
		public const int CycleIdFieldNumber = 1;

		// Token: 0x04006390 RID: 25488
		private int cycleId_;

		// Token: 0x04006391 RID: 25489
		public const int RecordsFieldNumber = 2;

		// Token: 0x04006392 RID: 25490
		private static readonly FieldCodec<NewTowerClimbingLevelRecord> _repeated_records_codec = FieldCodec.ForMessage<NewTowerClimbingLevelRecord>(18U, NewTowerClimbingLevelRecord.Parser);

		// Token: 0x04006393 RID: 25491
		private readonly RepeatedField<NewTowerClimbingLevelRecord> records_ = new RepeatedField<NewTowerClimbingLevelRecord>();

		// Token: 0x04006394 RID: 25492
		public const int ScoreTasksFieldNumber = 3;

		// Token: 0x04006395 RID: 25493
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006396 RID: 25494
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x04006397 RID: 25495
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x04006398 RID: 25496
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04006399 RID: 25497
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x0400639A RID: 25498
		public const int CycleBeginTimeFieldNumber = 5;

		// Token: 0x0400639B RID: 25499
		private long cycleBeginTime_;

		// Token: 0x0400639C RID: 25500
		public const int CycleCloseTimeFieldNumber = 6;

		// Token: 0x0400639D RID: 25501
		private long cycleCloseTime_;

		// Token: 0x0400639E RID: 25502
		public const int SeasonIdFieldNumber = 7;

		// Token: 0x0400639F RID: 25503
		private int seasonId_;

		// Token: 0x040063A0 RID: 25504
		public const int SeasonBeginTimeFieldNumber = 8;

		// Token: 0x040063A1 RID: 25505
		private long seasonBeginTime_;

		// Token: 0x040063A2 RID: 25506
		public const int SeasonCloseTimeFieldNumber = 9;

		// Token: 0x040063A3 RID: 25507
		private long seasonCloseTime_;

		// Token: 0x040063A4 RID: 25508
		public const int SeasonTasksFieldNumber = 10;

		// Token: 0x040063A5 RID: 25509
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(82U, ActivityTask.Parser);

		// Token: 0x040063A6 RID: 25510
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();
	}
}
