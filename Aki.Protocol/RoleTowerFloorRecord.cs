using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C9 RID: 4297
	public sealed class RoleTowerFloorRecord : IMessage<RoleTowerFloorRecord>, IMessage, IEquatable<RoleTowerFloorRecord>, IDeepCloneable<RoleTowerFloorRecord>, IBufferMessage
	{
		// Token: 0x06016F74 RID: 94068 RVA: 0x00356ED2 File Offset: 0x003550D2
		[NullableContext(1)]
		public static RoleTowerFloorRecord Create()
		{
			return new RoleTowerFloorRecord();
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x06016F75 RID: 94069 RVA: 0x00356ED9 File Offset: 0x003550D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerFloorRecord> Parser
		{
			get
			{
				return RoleTowerFloorRecord._parser;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06016F76 RID: 94070 RVA: 0x00356EE0 File Offset: 0x003550E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x06016F77 RID: 94071 RVA: 0x00356EE3 File Offset: 0x003550E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerFloorRecord.Descriptor;
			}
		}

		// Token: 0x06016F78 RID: 94072 RVA: 0x00356EEA File Offset: 0x003550EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorRecord()
		{
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x00356EF4 File Offset: 0x003550F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorRecord(RoleTowerFloorRecord other) : this()
		{
			this.floorId_ = other.floorId_;
			this.isPassed_ = other.isPassed_;
			this.branchIndex_ = other.branchIndex_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.costTimeMs_ = other.costTimeMs_;
			this.gainTimeMs_ = other.gainTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x00356F60 File Offset: 0x00355160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorRecord Clone()
		{
			return new RoleTowerFloorRecord(this);
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x06016F7B RID: 94075 RVA: 0x00356F68 File Offset: 0x00355168
		// (set) Token: 0x06016F7C RID: 94076 RVA: 0x00356F70 File Offset: 0x00355170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x06016F7D RID: 94077 RVA: 0x00356F79 File Offset: 0x00355179
		// (set) Token: 0x06016F7E RID: 94078 RVA: 0x00356F81 File Offset: 0x00355181
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

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06016F7F RID: 94079 RVA: 0x00356F8A File Offset: 0x0035518A
		// (set) Token: 0x06016F80 RID: 94080 RVA: 0x00356F92 File Offset: 0x00355192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchIndex
		{
			get
			{
				return this.branchIndex_;
			}
			set
			{
				this.branchIndex_ = value;
			}
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x06016F81 RID: 94081 RVA: 0x00356F9B File Offset: 0x0035519B
		// (set) Token: 0x06016F82 RID: 94082 RVA: 0x00356FA3 File Offset: 0x003551A3
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

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x06016F83 RID: 94083 RVA: 0x00356FAC File Offset: 0x003551AC
		// (set) Token: 0x06016F84 RID: 94084 RVA: 0x00356FB4 File Offset: 0x003551B4
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

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x06016F85 RID: 94085 RVA: 0x00356FBD File Offset: 0x003551BD
		// (set) Token: 0x06016F86 RID: 94086 RVA: 0x00356FC5 File Offset: 0x003551C5
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

		// Token: 0x06016F87 RID: 94087 RVA: 0x00356FCE File Offset: 0x003551CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerFloorRecord);
		}

		// Token: 0x06016F88 RID: 94088 RVA: 0x00356FDC File Offset: 0x003551DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerFloorRecord other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.IsPassed == other.IsPassed && this.BranchIndex == other.BranchIndex && this.RemainTimeMs == other.RemainTimeMs && this.CostTimeMs == other.CostTimeMs && this.GainTimeMs == other.GainTimeMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F89 RID: 94089 RVA: 0x00357068 File Offset: 0x00355268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.IsPassed)
			{
				num ^= this.IsPassed.GetHashCode();
			}
			if (this.BranchIndex != 0)
			{
				num ^= this.BranchIndex.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			if (this.CostTimeMs != 0L)
			{
				num ^= this.CostTimeMs.GetHashCode();
			}
			if (this.GainTimeMs != 0L)
			{
				num ^= this.GainTimeMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F8A RID: 94090 RVA: 0x00357124 File Offset: 0x00355324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F8B RID: 94091 RVA: 0x00357131 File Offset: 0x00355331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F8C RID: 94092 RVA: 0x0035713C File Offset: 0x0035533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FloorId);
			}
			if (this.IsPassed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPassed);
			}
			if (this.BranchIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BranchIndex);
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
			if (this.GainTimeMs != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.GainTimeMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F8D RID: 94093 RVA: 0x00357204 File Offset: 0x00355404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FloorId);
			}
			if (this.IsPassed)
			{
				num += 2;
			}
			if (this.BranchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchIndex);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			if (this.CostTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTimeMs);
			}
			if (this.GainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GainTimeMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F8E RID: 94094 RVA: 0x003572B0 File Offset: 0x003554B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerFloorRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0)
			{
				this.FloorId = other.FloorId;
			}
			if (other.IsPassed)
			{
				this.IsPassed = other.IsPassed;
			}
			if (other.BranchIndex != 0)
			{
				this.BranchIndex = other.BranchIndex;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			if (other.CostTimeMs != 0L)
			{
				this.CostTimeMs = other.CostTimeMs;
			}
			if (other.GainTimeMs != 0L)
			{
				this.GainTimeMs = other.GainTimeMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x00357350 File Offset: 0x00355550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F90 RID: 94096 RVA: 0x0035735C File Offset: 0x0035555C
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
						this.FloorId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsPassed = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.BranchIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.RemainTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.CostTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.GainTimeMs = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008970 RID: 35184
		private static readonly MessageParser<RoleTowerFloorRecord> _parser = new MessageParser<RoleTowerFloorRecord>(() => new RoleTowerFloorRecord());

		// Token: 0x04008971 RID: 35185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008972 RID: 35186
		public const int FloorIdFieldNumber = 1;

		// Token: 0x04008973 RID: 35187
		private int floorId_;

		// Token: 0x04008974 RID: 35188
		public const int IsPassedFieldNumber = 2;

		// Token: 0x04008975 RID: 35189
		private bool isPassed_;

		// Token: 0x04008976 RID: 35190
		public const int BranchIndexFieldNumber = 3;

		// Token: 0x04008977 RID: 35191
		private int branchIndex_;

		// Token: 0x04008978 RID: 35192
		public const int RemainTimeMsFieldNumber = 4;

		// Token: 0x04008979 RID: 35193
		private long remainTimeMs_;

		// Token: 0x0400897A RID: 35194
		public const int CostTimeMsFieldNumber = 5;

		// Token: 0x0400897B RID: 35195
		private long costTimeMs_;

		// Token: 0x0400897C RID: 35196
		public const int GainTimeMsFieldNumber = 6;

		// Token: 0x0400897D RID: 35197
		private long gainTimeMs_;
	}
}
