using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BB RID: 4283
	public sealed class RoleTowerBestRecord : IMessage<RoleTowerBestRecord>, IMessage, IEquatable<RoleTowerBestRecord>, IDeepCloneable<RoleTowerBestRecord>, IBufferMessage
	{
		// Token: 0x06016E27 RID: 93735 RVA: 0x00353480 File Offset: 0x00351680
		[NullableContext(1)]
		public static RoleTowerBestRecord Create()
		{
			return new RoleTowerBestRecord();
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x06016E28 RID: 93736 RVA: 0x00353487 File Offset: 0x00351687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x06016E29 RID: 93737 RVA: 0x0035348A File Offset: 0x0035168A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerBestRecord.Descriptor;
			}
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x00353491 File Offset: 0x00351691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord()
		{
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x003534A4 File Offset: 0x003516A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord(RoleTowerBestRecord other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.mainRoleId_ = other.mainRoleId_;
			this.passedFloorCount_ = other.passedFloorCount_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.costTimeMs_ = other.costTimeMs_;
			this.settleTime_ = other.settleTime_;
			this.isAllPassed_ = other.isAllPassed_;
			this.stageRecords_ = other.stageRecords_.Clone();
			this.isNewRecord_ = other.isNewRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00353539 File Offset: 0x00351739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord Clone()
		{
			return new RoleTowerBestRecord(this);
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x06016E2D RID: 93741 RVA: 0x00353541 File Offset: 0x00351741
		// (set) Token: 0x06016E2E RID: 93742 RVA: 0x00353549 File Offset: 0x00351749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x06016E2F RID: 93743 RVA: 0x00353552 File Offset: 0x00351752
		// (set) Token: 0x06016E30 RID: 93744 RVA: 0x0035355A File Offset: 0x0035175A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MainRoleId
		{
			get
			{
				return this.mainRoleId_;
			}
			set
			{
				this.mainRoleId_ = value;
			}
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x06016E31 RID: 93745 RVA: 0x00353563 File Offset: 0x00351763
		// (set) Token: 0x06016E32 RID: 93746 RVA: 0x0035356B File Offset: 0x0035176B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassedFloorCount
		{
			get
			{
				return this.passedFloorCount_;
			}
			set
			{
				this.passedFloorCount_ = value;
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x06016E33 RID: 93747 RVA: 0x00353574 File Offset: 0x00351774
		// (set) Token: 0x06016E34 RID: 93748 RVA: 0x0035357C File Offset: 0x0035177C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RemainTimeMs
		{
			get
			{
				return this.remainTimeMs_;
			}
			set
			{
				this.remainTimeMs_ = value;
			}
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x06016E35 RID: 93749 RVA: 0x00353585 File Offset: 0x00351785
		// (set) Token: 0x06016E36 RID: 93750 RVA: 0x0035358D File Offset: 0x0035178D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CostTimeMs
		{
			get
			{
				return this.costTimeMs_;
			}
			set
			{
				this.costTimeMs_ = value;
			}
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x06016E37 RID: 93751 RVA: 0x00353596 File Offset: 0x00351796
		// (set) Token: 0x06016E38 RID: 93752 RVA: 0x0035359E File Offset: 0x0035179E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SettleTime
		{
			get
			{
				return this.settleTime_;
			}
			set
			{
				this.settleTime_ = value;
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x06016E39 RID: 93753 RVA: 0x003535A7 File Offset: 0x003517A7
		// (set) Token: 0x06016E3A RID: 93754 RVA: 0x003535AF File Offset: 0x003517AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAllPassed
		{
			get
			{
				return this.isAllPassed_;
			}
			set
			{
				this.isAllPassed_ = value;
			}
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x06016E3B RID: 93755 RVA: 0x003535B8 File Offset: 0x003517B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerStageRecord> StageRecords
		{
			get
			{
				return this.stageRecords_;
			}
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x06016E3C RID: 93756 RVA: 0x003535C0 File Offset: 0x003517C0
		// (set) Token: 0x06016E3D RID: 93757 RVA: 0x003535C8 File Offset: 0x003517C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x06016E3E RID: 93758 RVA: 0x003535D1 File Offset: 0x003517D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerBestRecord);
		}

		// Token: 0x06016E3F RID: 93759 RVA: 0x003535E0 File Offset: 0x003517E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerBestRecord other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.MainRoleId == other.MainRoleId && this.PassedFloorCount == other.PassedFloorCount && this.RemainTimeMs == other.RemainTimeMs && this.CostTimeMs == other.CostTimeMs && this.SettleTime == other.SettleTime && this.IsAllPassed == other.IsAllPassed && this.stageRecords_.Equals(other.stageRecords_) && this.IsNewRecord == other.IsNewRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E40 RID: 93760 RVA: 0x003536A0 File Offset: 0x003518A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.MainRoleId != 0)
			{
				num ^= this.MainRoleId.GetHashCode();
			}
			if (this.PassedFloorCount != 0)
			{
				num ^= this.PassedFloorCount.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			if (this.CostTimeMs != 0L)
			{
				num ^= this.CostTimeMs.GetHashCode();
			}
			if (this.SettleTime != 0L)
			{
				num ^= this.SettleTime.GetHashCode();
			}
			if (this.IsAllPassed)
			{
				num ^= this.IsAllPassed.GetHashCode();
			}
			num ^= this.stageRecords_.GetHashCode();
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E41 RID: 93761 RVA: 0x0035379C File Offset: 0x0035199C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E42 RID: 93762 RVA: 0x003537A9 File Offset: 0x003519A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E43 RID: 93763 RVA: 0x003537B4 File Offset: 0x003519B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.MainRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MainRoleId);
			}
			if (this.PassedFloorCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PassedFloorCount);
			}
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RemainTimeMs);
			}
			if (this.CostTimeMs != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CostTimeMs);
			}
			if (this.SettleTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.SettleTime);
			}
			if (this.IsAllPassed)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsAllPassed);
			}
			this.stageRecords_.WriteTo(ref output, RoleTowerBestRecord._repeated_stageRecords_codec);
			if (this.IsNewRecord)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsNewRecord);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E44 RID: 93764 RVA: 0x003538C8 File Offset: 0x00351AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.MainRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MainRoleId);
			}
			if (this.PassedFloorCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassedFloorCount);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			if (this.CostTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTimeMs);
			}
			if (this.SettleTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SettleTime);
			}
			if (this.IsAllPassed)
			{
				num += 2;
			}
			num += this.stageRecords_.CalculateSize(RoleTowerBestRecord._repeated_stageRecords_codec);
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E45 RID: 93765 RVA: 0x003539AC File Offset: 0x00351BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerBestRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.MainRoleId != 0)
			{
				this.MainRoleId = other.MainRoleId;
			}
			if (other.PassedFloorCount != 0)
			{
				this.PassedFloorCount = other.PassedFloorCount;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			if (other.CostTimeMs != 0L)
			{
				this.CostTimeMs = other.CostTimeMs;
			}
			if (other.SettleTime != 0L)
			{
				this.SettleTime = other.SettleTime;
			}
			if (other.IsAllPassed)
			{
				this.IsAllPassed = other.IsAllPassed;
			}
			this.stageRecords_.Add(other.stageRecords_);
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E46 RID: 93766 RVA: 0x00353A85 File Offset: 0x00351C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E47 RID: 93767 RVA: 0x00353A90 File Offset: 0x00351C90
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.MainRoleId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.PassedFloorCount = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.RemainTimeMs = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.CostTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.SettleTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.IsAllPassed = input.ReadBool();
						continue;
					}
					if (num == 66U)
					{
						this.stageRecords_.AddEntriesFrom(ref input, RoleTowerBestRecord._repeated_stageRecords_codec);
						continue;
					}
					if (num == 72U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088DF RID: 35039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088E0 RID: 35040
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040088E1 RID: 35041
		private int challengeId_;

		// Token: 0x040088E2 RID: 35042
		public const int MainRoleIdFieldNumber = 2;

		// Token: 0x040088E3 RID: 35043
		private int mainRoleId_;

		// Token: 0x040088E4 RID: 35044
		public const int PassedFloorCountFieldNumber = 3;

		// Token: 0x040088E5 RID: 35045
		private int passedFloorCount_;

		// Token: 0x040088E6 RID: 35046
		public const int RemainTimeMsFieldNumber = 4;

		// Token: 0x040088E7 RID: 35047
		private long remainTimeMs_;

		// Token: 0x040088E8 RID: 35048
		public const int CostTimeMsFieldNumber = 5;

		// Token: 0x040088E9 RID: 35049
		private long costTimeMs_;

		// Token: 0x040088EA RID: 35050
		public const int SettleTimeFieldNumber = 6;

		// Token: 0x040088EB RID: 35051
		private long settleTime_;

		// Token: 0x040088EC RID: 35052
		public const int IsAllPassedFieldNumber = 7;

		// Token: 0x040088ED RID: 35053
		private bool isAllPassed_;

		// Token: 0x040088EE RID: 35054
		public const int StageRecordsFieldNumber = 8;

		// Token: 0x040088EF RID: 35055
		private static readonly FieldCodec<RoleTowerStageRecord> _repeated_stageRecords_codec = FieldCodec.ForMessage<RoleTowerStageRecord>(66U, RoleTowerStageRecord.Parser);

		// Token: 0x040088F0 RID: 35056
		private readonly RepeatedField<RoleTowerStageRecord> stageRecords_ = new RepeatedField<RoleTowerStageRecord>();

		// Token: 0x040088F1 RID: 35057
		public const int IsNewRecordFieldNumber = 9;

		// Token: 0x040088F2 RID: 35058
		private bool isNewRecord_;
	}
}
