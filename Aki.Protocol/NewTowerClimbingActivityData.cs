using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1D RID: 2845
	public sealed class NewTowerClimbingActivityData : IMessage<NewTowerClimbingActivityData>, IMessage, IEquatable<NewTowerClimbingActivityData>, IDeepCloneable<NewTowerClimbingActivityData>, IBufferMessage
	{
		// Token: 0x0600F74A RID: 63306 RVA: 0x002414C5 File Offset: 0x0023F6C5
		[NullableContext(1)]
		public static NewTowerClimbingActivityData Create()
		{
			return new NewTowerClimbingActivityData();
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600F74B RID: 63307 RVA: 0x002414CC File Offset: 0x0023F6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600F74C RID: 63308 RVA: 0x002414CF File Offset: 0x0023F6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingActivityData.Descriptor;
			}
		}

		// Token: 0x0600F74D RID: 63309 RVA: 0x002414D6 File Offset: 0x0023F6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData()
		{
		}

		// Token: 0x0600F74E RID: 63310 RVA: 0x0024150C File Offset: 0x0023F70C
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

		// Token: 0x0600F74F RID: 63311 RVA: 0x002415BC File Offset: 0x0023F7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingActivityData Clone()
		{
			return new NewTowerClimbingActivityData(this);
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600F750 RID: 63312 RVA: 0x002415C4 File Offset: 0x0023F7C4
		// (set) Token: 0x0600F751 RID: 63313 RVA: 0x002415CC File Offset: 0x0023F7CC
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

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600F752 RID: 63314 RVA: 0x002415D5 File Offset: 0x0023F7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerClimbingLevelRecord> Records
		{
			get
			{
				return this.records_;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600F753 RID: 63315 RVA: 0x002415DD File Offset: 0x0023F7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTasks
		{
			get
			{
				return this.scoreTasks_;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600F754 RID: 63316 RVA: 0x002415E5 File Offset: 0x0023F7E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600F755 RID: 63317 RVA: 0x002415ED File Offset: 0x0023F7ED
		// (set) Token: 0x0600F756 RID: 63318 RVA: 0x002415F5 File Offset: 0x0023F7F5
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

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600F757 RID: 63319 RVA: 0x002415FE File Offset: 0x0023F7FE
		// (set) Token: 0x0600F758 RID: 63320 RVA: 0x00241606 File Offset: 0x0023F806
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

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600F759 RID: 63321 RVA: 0x0024160F File Offset: 0x0023F80F
		// (set) Token: 0x0600F75A RID: 63322 RVA: 0x00241617 File Offset: 0x0023F817
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

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600F75B RID: 63323 RVA: 0x00241620 File Offset: 0x0023F820
		// (set) Token: 0x0600F75C RID: 63324 RVA: 0x00241628 File Offset: 0x0023F828
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

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600F75D RID: 63325 RVA: 0x00241631 File Offset: 0x0023F831
		// (set) Token: 0x0600F75E RID: 63326 RVA: 0x00241639 File Offset: 0x0023F839
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

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600F75F RID: 63327 RVA: 0x00241642 File Offset: 0x0023F842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x0600F760 RID: 63328 RVA: 0x0024164A File Offset: 0x0023F84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingActivityData);
		}

		// Token: 0x0600F761 RID: 63329 RVA: 0x00241658 File Offset: 0x0023F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingActivityData other)
		{
			return other != null && (other == this || (this.CycleId == other.CycleId && this.records_.Equals(other.records_) && this.scoreTasks_.Equals(other.scoreTasks_) && this.activityTasks_.Equals(other.activityTasks_) && this.CycleBeginTime == other.CycleBeginTime && this.CycleCloseTime == other.CycleCloseTime && this.SeasonId == other.SeasonId && this.SeasonBeginTime == other.SeasonBeginTime && this.SeasonCloseTime == other.SeasonCloseTime && this.seasonTasks_.Equals(other.seasonTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F762 RID: 63330 RVA: 0x00241738 File Offset: 0x0023F938
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

		// Token: 0x0600F763 RID: 63331 RVA: 0x0024182C File Offset: 0x0023FA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F764 RID: 63332 RVA: 0x00241839 File Offset: 0x0023FA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F765 RID: 63333 RVA: 0x00241844 File Offset: 0x0023FA44
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

		// Token: 0x0600F766 RID: 63334 RVA: 0x00241950 File Offset: 0x0023FB50
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

		// Token: 0x0600F767 RID: 63335 RVA: 0x00241A54 File Offset: 0x0023FC54
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

		// Token: 0x0600F768 RID: 63336 RVA: 0x00241B38 File Offset: 0x0023FD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F769 RID: 63337 RVA: 0x00241B44 File Offset: 0x0023FD44
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

		// Token: 0x04006397 RID: 25495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006398 RID: 25496
		public const int CycleIdFieldNumber = 1;

		// Token: 0x04006399 RID: 25497
		private int cycleId_;

		// Token: 0x0400639A RID: 25498
		public const int RecordsFieldNumber = 2;

		// Token: 0x0400639B RID: 25499
		private static readonly FieldCodec<NewTowerClimbingLevelRecord> _repeated_records_codec = FieldCodec.ForMessage<NewTowerClimbingLevelRecord>(18U, NewTowerClimbingLevelRecord.Parser);

		// Token: 0x0400639C RID: 25500
		private readonly RepeatedField<NewTowerClimbingLevelRecord> records_ = new RepeatedField<NewTowerClimbingLevelRecord>();

		// Token: 0x0400639D RID: 25501
		public const int ScoreTasksFieldNumber = 3;

		// Token: 0x0400639E RID: 25502
		private static readonly FieldCodec<int> _repeated_scoreTasks_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400639F RID: 25503
		private readonly RepeatedField<int> scoreTasks_ = new RepeatedField<int>();

		// Token: 0x040063A0 RID: 25504
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x040063A1 RID: 25505
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x040063A2 RID: 25506
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x040063A3 RID: 25507
		public const int CycleBeginTimeFieldNumber = 5;

		// Token: 0x040063A4 RID: 25508
		private long cycleBeginTime_;

		// Token: 0x040063A5 RID: 25509
		public const int CycleCloseTimeFieldNumber = 6;

		// Token: 0x040063A6 RID: 25510
		private long cycleCloseTime_;

		// Token: 0x040063A7 RID: 25511
		public const int SeasonIdFieldNumber = 7;

		// Token: 0x040063A8 RID: 25512
		private int seasonId_;

		// Token: 0x040063A9 RID: 25513
		public const int SeasonBeginTimeFieldNumber = 8;

		// Token: 0x040063AA RID: 25514
		private long seasonBeginTime_;

		// Token: 0x040063AB RID: 25515
		public const int SeasonCloseTimeFieldNumber = 9;

		// Token: 0x040063AC RID: 25516
		private long seasonCloseTime_;

		// Token: 0x040063AD RID: 25517
		public const int SeasonTasksFieldNumber = 10;

		// Token: 0x040063AE RID: 25518
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(82U, ActivityTask.Parser);

		// Token: 0x040063AF RID: 25519
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();
	}
}
