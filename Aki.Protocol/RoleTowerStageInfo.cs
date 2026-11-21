using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010ED RID: 4333
	public sealed class RoleTowerStageInfo : IMessage<RoleTowerStageInfo>, IMessage, IEquatable<RoleTowerStageInfo>, IDeepCloneable<RoleTowerStageInfo>, IBufferMessage
	{
		// Token: 0x06017290 RID: 94864 RVA: 0x0035E66C File Offset: 0x0035C86C
		[NullableContext(1)]
		public static RoleTowerStageInfo Create()
		{
			return new RoleTowerStageInfo();
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x06017291 RID: 94865 RVA: 0x0035E673 File Offset: 0x0035C873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerStageInfo> Parser
		{
			get
			{
				return RoleTowerStageInfo._parser;
			}
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x06017292 RID: 94866 RVA: 0x0035E67A File Offset: 0x0035C87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06017293 RID: 94867 RVA: 0x0035E67D File Offset: 0x0035C87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageInfo.Descriptor;
			}
		}

		// Token: 0x06017294 RID: 94868 RVA: 0x0035E684 File Offset: 0x0035C884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageInfo()
		{
		}

		// Token: 0x06017295 RID: 94869 RVA: 0x0035E6B0 File Offset: 0x0035C8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageInfo(RoleTowerStageInfo other) : this()
		{
			this.stageId_ = other.stageId_;
			this.state_ = other.state_;
			this.energyCost_ = other.energyCost_;
			this.passRemainTimeMs_ = other.passRemainTimeMs_;
			this.passRoles_ = other.passRoles_.Clone();
			this.floorInfos_ = other.floorInfos_.Clone();
			this.roleSnapshots_ = other.roleSnapshots_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x0035E737 File Offset: 0x0035C937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageInfo Clone()
		{
			return new RoleTowerStageInfo(this);
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06017297 RID: 94871 RVA: 0x0035E73F File Offset: 0x0035C93F
		// (set) Token: 0x06017298 RID: 94872 RVA: 0x0035E747 File Offset: 0x0035C947
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

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x06017299 RID: 94873 RVA: 0x0035E750 File Offset: 0x0035C950
		// (set) Token: 0x0601729A RID: 94874 RVA: 0x0035E758 File Offset: 0x0035C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x0601729B RID: 94875 RVA: 0x0035E761 File Offset: 0x0035C961
		// (set) Token: 0x0601729C RID: 94876 RVA: 0x0035E769 File Offset: 0x0035C969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnergyCost
		{
			get
			{
				return this.energyCost_;
			}
			set
			{
				this.energyCost_ = value;
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x0601729D RID: 94877 RVA: 0x0035E772 File Offset: 0x0035C972
		// (set) Token: 0x0601729E RID: 94878 RVA: 0x0035E77A File Offset: 0x0035C97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassRemainTimeMs
		{
			get
			{
				return this.passRemainTimeMs_;
			}
			set
			{
				this.passRemainTimeMs_ = value;
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x0601729F RID: 94879 RVA: 0x0035E783 File Offset: 0x0035C983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleBrief> PassRoles
		{
			get
			{
				return this.passRoles_;
			}
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x060172A0 RID: 94880 RVA: 0x0035E78B File Offset: 0x0035C98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerFloorInfo> FloorInfos
		{
			get
			{
				return this.floorInfos_;
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x060172A1 RID: 94881 RVA: 0x0035E793 File Offset: 0x0035C993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleSnapshot> RoleSnapshots
		{
			get
			{
				return this.roleSnapshots_;
			}
		}

		// Token: 0x060172A2 RID: 94882 RVA: 0x0035E79B File Offset: 0x0035C99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageInfo);
		}

		// Token: 0x060172A3 RID: 94883 RVA: 0x0035E7AC File Offset: 0x0035C9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageInfo other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.State == other.State && this.EnergyCost == other.EnergyCost && this.PassRemainTimeMs == other.PassRemainTimeMs && this.passRoles_.Equals(other.passRoles_) && this.floorInfos_.Equals(other.floorInfos_) && this.roleSnapshots_.Equals(other.roleSnapshots_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060172A4 RID: 94884 RVA: 0x0035E854 File Offset: 0x0035CA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.State != RoleTowerStageState.NotPass)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.EnergyCost != 0)
			{
				num ^= this.EnergyCost.GetHashCode();
			}
			if (this.PassRemainTimeMs != 0L)
			{
				num ^= this.PassRemainTimeMs.GetHashCode();
			}
			num ^= this.passRoles_.GetHashCode();
			num ^= this.floorInfos_.GetHashCode();
			num ^= this.roleSnapshots_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060172A5 RID: 94885 RVA: 0x0035E90E File Offset: 0x0035CB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060172A6 RID: 94886 RVA: 0x0035E91B File Offset: 0x0035CB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060172A7 RID: 94887 RVA: 0x0035E924 File Offset: 0x0035CB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StageId);
			}
			if (this.State != RoleTowerStageState.NotPass)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.EnergyCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EnergyCost);
			}
			if (this.PassRemainTimeMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PassRemainTimeMs);
			}
			this.passRoles_.WriteTo(ref output, RoleTowerStageInfo._repeated_passRoles_codec);
			this.floorInfos_.WriteTo(ref output, RoleTowerStageInfo._repeated_floorInfos_codec);
			this.roleSnapshots_.WriteTo(ref output, RoleTowerStageInfo._repeated_roleSnapshots_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060172A8 RID: 94888 RVA: 0x0035E9E8 File Offset: 0x0035CBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StageId);
			}
			if (this.State != RoleTowerStageState.NotPass)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.EnergyCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnergyCost);
			}
			if (this.PassRemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassRemainTimeMs);
			}
			num += this.passRoles_.CalculateSize(RoleTowerStageInfo._repeated_passRoles_codec);
			num += this.floorInfos_.CalculateSize(RoleTowerStageInfo._repeated_floorInfos_codec);
			num += this.roleSnapshots_.CalculateSize(RoleTowerStageInfo._repeated_roleSnapshots_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060172A9 RID: 94889 RVA: 0x0035EAA8 File Offset: 0x0035CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0)
			{
				this.StageId = other.StageId;
			}
			if (other.State != RoleTowerStageState.NotPass)
			{
				this.State = other.State;
			}
			if (other.EnergyCost != 0)
			{
				this.EnergyCost = other.EnergyCost;
			}
			if (other.PassRemainTimeMs != 0L)
			{
				this.PassRemainTimeMs = other.PassRemainTimeMs;
			}
			this.passRoles_.Add(other.passRoles_);
			this.floorInfos_.Add(other.floorInfos_);
			this.roleSnapshots_.Add(other.roleSnapshots_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060172AA RID: 94890 RVA: 0x0035EB53 File Offset: 0x0035CD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060172AB RID: 94891 RVA: 0x0035EB5C File Offset: 0x0035CD5C
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
						this.State = (RoleTowerStageState)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.EnergyCost = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 32U)
					{
						this.PassRemainTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.passRoles_.AddEntriesFrom(ref input, RoleTowerStageInfo._repeated_passRoles_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.floorInfos_.AddEntriesFrom(ref input, RoleTowerStageInfo._repeated_floorInfos_codec);
						continue;
					}
					if (num == 58U)
					{
						this.roleSnapshots_.AddEntriesFrom(ref input, RoleTowerStageInfo._repeated_roleSnapshots_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A89 RID: 35465
		private static readonly MessageParser<RoleTowerStageInfo> _parser = new MessageParser<RoleTowerStageInfo>(() => new RoleTowerStageInfo());

		// Token: 0x04008A8A RID: 35466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A8B RID: 35467
		public const int StageIdFieldNumber = 1;

		// Token: 0x04008A8C RID: 35468
		private int stageId_;

		// Token: 0x04008A8D RID: 35469
		public const int StateFieldNumber = 2;

		// Token: 0x04008A8E RID: 35470
		private RoleTowerStageState state_;

		// Token: 0x04008A8F RID: 35471
		public const int EnergyCostFieldNumber = 3;

		// Token: 0x04008A90 RID: 35472
		private int energyCost_;

		// Token: 0x04008A91 RID: 35473
		public const int PassRemainTimeMsFieldNumber = 4;

		// Token: 0x04008A92 RID: 35474
		private long passRemainTimeMs_;

		// Token: 0x04008A93 RID: 35475
		public const int PassRolesFieldNumber = 5;

		// Token: 0x04008A94 RID: 35476
		private static readonly FieldCodec<RoleTowerRoleBrief> _repeated_passRoles_codec = FieldCodec.ForMessage<RoleTowerRoleBrief>(42U, RoleTowerRoleBrief.Parser);

		// Token: 0x04008A95 RID: 35477
		private readonly RepeatedField<RoleTowerRoleBrief> passRoles_ = new RepeatedField<RoleTowerRoleBrief>();

		// Token: 0x04008A96 RID: 35478
		public const int FloorInfosFieldNumber = 6;

		// Token: 0x04008A97 RID: 35479
		private static readonly FieldCodec<RoleTowerFloorInfo> _repeated_floorInfos_codec = FieldCodec.ForMessage<RoleTowerFloorInfo>(50U, RoleTowerFloorInfo.Parser);

		// Token: 0x04008A98 RID: 35480
		private readonly RepeatedField<RoleTowerFloorInfo> floorInfos_ = new RepeatedField<RoleTowerFloorInfo>();

		// Token: 0x04008A99 RID: 35481
		public const int RoleSnapshotsFieldNumber = 7;

		// Token: 0x04008A9A RID: 35482
		private static readonly FieldCodec<RoleTowerRoleSnapshot> _repeated_roleSnapshots_codec = FieldCodec.ForMessage<RoleTowerRoleSnapshot>(58U, RoleTowerRoleSnapshot.Parser);

		// Token: 0x04008A9B RID: 35483
		private readonly RepeatedField<RoleTowerRoleSnapshot> roleSnapshots_ = new RepeatedField<RoleTowerRoleSnapshot>();
	}
}
