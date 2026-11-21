using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EE RID: 4334
	public sealed class RoleTowerStageRecord : IMessage<RoleTowerStageRecord>, IMessage, IEquatable<RoleTowerStageRecord>, IDeepCloneable<RoleTowerStageRecord>, IBufferMessage
	{
		// Token: 0x060172AD RID: 94893 RVA: 0x0035EC92 File Offset: 0x0035CE92
		[NullableContext(1)]
		public static RoleTowerStageRecord Create()
		{
			return new RoleTowerStageRecord();
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x060172AE RID: 94894 RVA: 0x0035EC99 File Offset: 0x0035CE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerStageRecord> Parser
		{
			get
			{
				return RoleTowerStageRecord._parser;
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x060172AF RID: 94895 RVA: 0x0035ECA0 File Offset: 0x0035CEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x060172B0 RID: 94896 RVA: 0x0035ECA3 File Offset: 0x0035CEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageRecord.Descriptor;
			}
		}

		// Token: 0x060172B1 RID: 94897 RVA: 0x0035ECAA File Offset: 0x0035CEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRecord()
		{
		}

		// Token: 0x060172B2 RID: 94898 RVA: 0x0035ECC8 File Offset: 0x0035CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRecord(RoleTowerStageRecord other) : this()
		{
			this.stageId_ = other.stageId_;
			this.isPassed_ = other.isPassed_;
			this.gainTimeMs_ = other.gainTimeMs_;
			this.costTimeMs_ = other.costTimeMs_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.roles_ = other.roles_.Clone();
			this.floorRecords_ = other.floorRecords_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x0035ED4A File Offset: 0x0035CF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRecord Clone()
		{
			return new RoleTowerStageRecord(this);
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x060172B4 RID: 94900 RVA: 0x0035ED52 File Offset: 0x0035CF52
		// (set) Token: 0x060172B5 RID: 94901 RVA: 0x0035ED5A File Offset: 0x0035CF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x060172B6 RID: 94902 RVA: 0x0035ED63 File Offset: 0x0035CF63
		// (set) Token: 0x060172B7 RID: 94903 RVA: 0x0035ED6B File Offset: 0x0035CF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPassed
		{
			get
			{
				return this.isPassed_;
			}
			set
			{
				this.isPassed_ = value;
			}
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x060172B8 RID: 94904 RVA: 0x0035ED74 File Offset: 0x0035CF74
		// (set) Token: 0x060172B9 RID: 94905 RVA: 0x0035ED7C File Offset: 0x0035CF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GainTimeMs
		{
			get
			{
				return this.gainTimeMs_;
			}
			set
			{
				this.gainTimeMs_ = value;
			}
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x060172BA RID: 94906 RVA: 0x0035ED85 File Offset: 0x0035CF85
		// (set) Token: 0x060172BB RID: 94907 RVA: 0x0035ED8D File Offset: 0x0035CF8D
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

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x060172BC RID: 94908 RVA: 0x0035ED96 File Offset: 0x0035CF96
		// (set) Token: 0x060172BD RID: 94909 RVA: 0x0035ED9E File Offset: 0x0035CF9E
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

		// Token: 0x17004DD4 RID: 19924
		// (get) Token: 0x060172BE RID: 94910 RVA: 0x0035EDA7 File Offset: 0x0035CFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleBrief> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x060172BF RID: 94911 RVA: 0x0035EDAF File Offset: 0x0035CFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerFloorRecord> FloorRecords
		{
			get
			{
				return this.floorRecords_;
			}
		}

		// Token: 0x060172C0 RID: 94912 RVA: 0x0035EDB7 File Offset: 0x0035CFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageRecord);
		}

		// Token: 0x060172C1 RID: 94913 RVA: 0x0035EDC8 File Offset: 0x0035CFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageRecord other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.IsPassed == other.IsPassed && this.GainTimeMs == other.GainTimeMs && this.CostTimeMs == other.CostTimeMs && this.RemainTimeMs == other.RemainTimeMs && this.roles_.Equals(other.roles_) && this.floorRecords_.Equals(other.floorRecords_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172C2 RID: 94914 RVA: 0x0035EE6C File Offset: 0x0035D06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.IsPassed)
			{
				num ^= this.IsPassed.GetHashCode();
			}
			if (this.GainTimeMs != 0L)
			{
				num ^= this.GainTimeMs.GetHashCode();
			}
			if (this.CostTimeMs != 0L)
			{
				num ^= this.CostTimeMs.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			num ^= this.floorRecords_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172C3 RID: 94915 RVA: 0x0035EF2B File Offset: 0x0035D12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172C4 RID: 94916 RVA: 0x0035EF38 File Offset: 0x0035D138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172C5 RID: 94917 RVA: 0x0035EF44 File Offset: 0x0035D144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StageId);
			}
			if (this.IsPassed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPassed);
			}
			if (this.GainTimeMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.GainTimeMs);
			}
			if (this.CostTimeMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.CostTimeMs);
			}
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.RemainTimeMs);
			}
			this.roles_.WriteTo(ref output, RoleTowerStageRecord._repeated_roles_codec);
			this.floorRecords_.WriteTo(ref output, RoleTowerStageRecord._repeated_floorRecords_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172C6 RID: 94918 RVA: 0x0035F014 File Offset: 0x0035D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StageId);
			}
			if (this.IsPassed)
			{
				num += 2;
			}
			if (this.GainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GainTimeMs);
			}
			if (this.CostTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTimeMs);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			num += this.roles_.CalculateSize(RoleTowerStageRecord._repeated_roles_codec);
			num += this.floorRecords_.CalculateSize(RoleTowerStageRecord._repeated_floorRecords_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172C7 RID: 94919 RVA: 0x0035F0CC File Offset: 0x0035D2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0)
			{
				this.StageId = other.StageId;
			}
			if (other.IsPassed)
			{
				this.IsPassed = other.IsPassed;
			}
			if (other.GainTimeMs != 0L)
			{
				this.GainTimeMs = other.GainTimeMs;
			}
			if (other.CostTimeMs != 0L)
			{
				this.CostTimeMs = other.CostTimeMs;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			this.roles_.Add(other.roles_);
			this.floorRecords_.Add(other.floorRecords_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172C8 RID: 94920 RVA: 0x0035F17A File Offset: 0x0035D37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172C9 RID: 94921 RVA: 0x0035F184 File Offset: 0x0035D384
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.StageId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsPassed = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.GainTimeMs = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.CostTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.RemainTimeMs = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.roles_.AddEntriesFrom(ref input, RoleTowerStageRecord._repeated_roles_codec);
						continue;
					}
					if (num == 58U)
					{
						this.floorRecords_.AddEntriesFrom(ref input, RoleTowerStageRecord._repeated_floorRecords_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A9C RID: 35484
		private static readonly MessageParser<RoleTowerStageRecord> _parser = new MessageParser<RoleTowerStageRecord>(() => new RoleTowerStageRecord());

		// Token: 0x04008A9D RID: 35485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A9E RID: 35486
		public const int StageIdFieldNumber = 1;

		// Token: 0x04008A9F RID: 35487
		private int stageId_;

		// Token: 0x04008AA0 RID: 35488
		public const int IsPassedFieldNumber = 2;

		// Token: 0x04008AA1 RID: 35489
		private bool isPassed_;

		// Token: 0x04008AA2 RID: 35490
		public const int GainTimeMsFieldNumber = 3;

		// Token: 0x04008AA3 RID: 35491
		private long gainTimeMs_;

		// Token: 0x04008AA4 RID: 35492
		public const int CostTimeMsFieldNumber = 4;

		// Token: 0x04008AA5 RID: 35493
		private long costTimeMs_;

		// Token: 0x04008AA6 RID: 35494
		public const int RemainTimeMsFieldNumber = 5;

		// Token: 0x04008AA7 RID: 35495
		private long remainTimeMs_;

		// Token: 0x04008AA8 RID: 35496
		public const int RolesFieldNumber = 6;

		// Token: 0x04008AA9 RID: 35497
		private static readonly FieldCodec<RoleTowerRoleBrief> _repeated_roles_codec = FieldCodec.ForMessage<RoleTowerRoleBrief>(50U, RoleTowerRoleBrief.Parser);

		// Token: 0x04008AAA RID: 35498
		private readonly RepeatedField<RoleTowerRoleBrief> roles_ = new RepeatedField<RoleTowerRoleBrief>();

		// Token: 0x04008AAB RID: 35499
		public const int FloorRecordsFieldNumber = 7;

		// Token: 0x04008AAC RID: 35500
		private static readonly FieldCodec<RoleTowerFloorRecord> _repeated_floorRecords_codec = FieldCodec.ForMessage<RoleTowerFloorRecord>(58U, RoleTowerFloorRecord.Parser);

		// Token: 0x04008AAD RID: 35501
		private readonly RepeatedField<RoleTowerFloorRecord> floorRecords_ = new RepeatedField<RoleTowerFloorRecord>();
	}
}
