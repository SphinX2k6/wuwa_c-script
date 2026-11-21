using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D4 RID: 4308
	public sealed class RoleTowerPrepareInfo : IMessage<RoleTowerPrepareInfo>, IMessage, IEquatable<RoleTowerPrepareInfo>, IDeepCloneable<RoleTowerPrepareInfo>, IBufferMessage
	{
		// Token: 0x06017069 RID: 94313 RVA: 0x003593A3 File Offset: 0x003575A3
		[NullableContext(1)]
		public static RoleTowerPrepareInfo Create()
		{
			return new RoleTowerPrepareInfo();
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x0601706A RID: 94314 RVA: 0x003593AA File Offset: 0x003575AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x0601706B RID: 94315 RVA: 0x003593AD File Offset: 0x003575AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPrepareInfo.Descriptor;
			}
		}

		// Token: 0x0601706C RID: 94316 RVA: 0x003593B4 File Offset: 0x003575B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareInfo()
		{
		}

		// Token: 0x0601706D RID: 94317 RVA: 0x003593E8 File Offset: 0x003575E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareInfo(RoleTowerPrepareInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.curStageId_ = other.curStageId_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.roles_ = other.roles_.Clone();
			this.roleEnergyInfos_ = other.roleEnergyInfos_.Clone();
			this.tokenPanelInfo_ = ((other.tokenPanelInfo_ != null) ? other.tokenPanelInfo_.Clone() : null);
			this.equipTokenId_ = other.equipTokenId_;
			this.stageInfos_ = other.stageInfos_.Clone();
			this.needBranchSelect_ = other.needBranchSelect_;
			this.branchFloorInfo_ = ((other.branchFloorInfo_ != null) ? other.branchFloorInfo_.Clone() : null);
			this.teamStarInfo_ = other.teamStarInfo_.Clone();
			this.phantomInfo_ = ((other.phantomInfo_ != null) ? other.phantomInfo_.Clone() : null);
			this.needOpenUi_ = other.needOpenUi_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601706E RID: 94318 RVA: 0x003594EC File Offset: 0x003576EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPrepareInfo Clone()
		{
			return new RoleTowerPrepareInfo(this);
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x0601706F RID: 94319 RVA: 0x003594F4 File Offset: 0x003576F4
		// (set) Token: 0x06017070 RID: 94320 RVA: 0x003594FC File Offset: 0x003576FC
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

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x06017071 RID: 94321 RVA: 0x00359505 File Offset: 0x00357705
		// (set) Token: 0x06017072 RID: 94322 RVA: 0x0035950D File Offset: 0x0035770D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStageId
		{
			get
			{
				return this.curStageId_;
			}
			set
			{
				this.curStageId_ = value;
			}
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x06017073 RID: 94323 RVA: 0x00359516 File Offset: 0x00357716
		// (set) Token: 0x06017074 RID: 94324 RVA: 0x0035951E File Offset: 0x0035771E
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

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x06017075 RID: 94325 RVA: 0x00359527 File Offset: 0x00357727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleBrief> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x06017076 RID: 94326 RVA: 0x0035952F File Offset: 0x0035772F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleEnergyInfo> RoleEnergyInfos
		{
			get
			{
				return this.roleEnergyInfos_;
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x06017077 RID: 94327 RVA: 0x00359537 File Offset: 0x00357737
		// (set) Token: 0x06017078 RID: 94328 RVA: 0x0035953F File Offset: 0x0035773F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerTokenPanelInfo TokenPanelInfo
		{
			get
			{
				return this.tokenPanelInfo_;
			}
			set
			{
				this.tokenPanelInfo_ = value;
			}
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x06017079 RID: 94329 RVA: 0x00359548 File Offset: 0x00357748
		// (set) Token: 0x0601707A RID: 94330 RVA: 0x00359550 File Offset: 0x00357750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquipTokenId
		{
			get
			{
				return this.equipTokenId_;
			}
			set
			{
				this.equipTokenId_ = value;
			}
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x0601707B RID: 94331 RVA: 0x00359559 File Offset: 0x00357759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerStageInfo> StageInfos
		{
			get
			{
				return this.stageInfos_;
			}
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x0601707C RID: 94332 RVA: 0x00359561 File Offset: 0x00357761
		// (set) Token: 0x0601707D RID: 94333 RVA: 0x00359569 File Offset: 0x00357769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedBranchSelect
		{
			get
			{
				return this.needBranchSelect_;
			}
			set
			{
				this.needBranchSelect_ = value;
			}
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x0601707E RID: 94334 RVA: 0x00359572 File Offset: 0x00357772
		// (set) Token: 0x0601707F RID: 94335 RVA: 0x0035957A File Offset: 0x0035777A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerFloorInfo BranchFloorInfo
		{
			get
			{
				return this.branchFloorInfo_;
			}
			set
			{
				this.branchFloorInfo_ = value;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x06017080 RID: 94336 RVA: 0x00359583 File Offset: 0x00357783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TeamStarInfo
		{
			get
			{
				return this.teamStarInfo_;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x06017081 RID: 94337 RVA: 0x0035958B File Offset: 0x0035778B
		// (set) Token: 0x06017082 RID: 94338 RVA: 0x00359593 File Offset: 0x00357793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomInfo PhantomInfo
		{
			get
			{
				return this.phantomInfo_;
			}
			set
			{
				this.phantomInfo_ = value;
			}
		}

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x06017083 RID: 94339 RVA: 0x0035959C File Offset: 0x0035779C
		// (set) Token: 0x06017084 RID: 94340 RVA: 0x003595A4 File Offset: 0x003577A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedOpenUi
		{
			get
			{
				return this.needOpenUi_;
			}
			set
			{
				this.needOpenUi_ = value;
			}
		}

		// Token: 0x06017085 RID: 94341 RVA: 0x003595AD File Offset: 0x003577AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPrepareInfo);
		}

		// Token: 0x06017086 RID: 94342 RVA: 0x003595BC File Offset: 0x003577BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPrepareInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.CurStageId == other.CurStageId && this.RemainTimeMs == other.RemainTimeMs && this.roles_.Equals(other.roles_) && this.roleEnergyInfos_.Equals(other.roleEnergyInfos_) && object.Equals(this.TokenPanelInfo, other.TokenPanelInfo) && this.EquipTokenId == other.EquipTokenId && this.stageInfos_.Equals(other.stageInfos_) && this.NeedBranchSelect == other.NeedBranchSelect && object.Equals(this.BranchFloorInfo, other.BranchFloorInfo) && this.TeamStarInfo.Equals(other.TeamStarInfo) && object.Equals(this.PhantomInfo, other.PhantomInfo) && this.NeedOpenUi == other.NeedOpenUi && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017087 RID: 94343 RVA: 0x003596D8 File Offset: 0x003578D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.CurStageId != 0)
			{
				num ^= this.CurStageId.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			num ^= this.roleEnergyInfos_.GetHashCode();
			if (this.tokenPanelInfo_ != null)
			{
				num ^= this.TokenPanelInfo.GetHashCode();
			}
			if (this.EquipTokenId != 0)
			{
				num ^= this.EquipTokenId.GetHashCode();
			}
			num ^= this.stageInfos_.GetHashCode();
			if (this.NeedBranchSelect)
			{
				num ^= this.NeedBranchSelect.GetHashCode();
			}
			if (this.branchFloorInfo_ != null)
			{
				num ^= this.BranchFloorInfo.GetHashCode();
			}
			num ^= this.TeamStarInfo.GetHashCode();
			if (this.phantomInfo_ != null)
			{
				num ^= this.PhantomInfo.GetHashCode();
			}
			if (this.NeedOpenUi)
			{
				num ^= this.NeedOpenUi.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017088 RID: 94344 RVA: 0x0035980E File Offset: 0x00357A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017089 RID: 94345 RVA: 0x0035981B File Offset: 0x00357A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601708A RID: 94346 RVA: 0x00359824 File Offset: 0x00357A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CurStageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurStageId);
			}
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.RemainTimeMs);
			}
			this.roles_.WriteTo(ref output, RoleTowerPrepareInfo._repeated_roles_codec);
			this.roleEnergyInfos_.WriteTo(ref output, RoleTowerPrepareInfo._repeated_roleEnergyInfos_codec);
			if (this.tokenPanelInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TokenPanelInfo);
			}
			if (this.EquipTokenId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EquipTokenId);
			}
			this.stageInfos_.WriteTo(ref output, RoleTowerPrepareInfo._repeated_stageInfos_codec);
			if (this.NeedBranchSelect)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NeedBranchSelect);
			}
			if (this.branchFloorInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BranchFloorInfo);
			}
			this.teamStarInfo_.WriteTo(ref output, RoleTowerPrepareInfo._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PhantomInfo);
			}
			if (this.NeedOpenUi)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NeedOpenUi);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601708B RID: 94347 RVA: 0x00359988 File Offset: 0x00357B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.CurStageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStageId);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			num += this.roles_.CalculateSize(RoleTowerPrepareInfo._repeated_roles_codec);
			num += this.roleEnergyInfos_.CalculateSize(RoleTowerPrepareInfo._repeated_roleEnergyInfos_codec);
			if (this.tokenPanelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TokenPanelInfo);
			}
			if (this.EquipTokenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipTokenId);
			}
			num += this.stageInfos_.CalculateSize(RoleTowerPrepareInfo._repeated_stageInfos_codec);
			if (this.NeedBranchSelect)
			{
				num += 2;
			}
			if (this.branchFloorInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BranchFloorInfo);
			}
			num += this.teamStarInfo_.CalculateSize(RoleTowerPrepareInfo._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomInfo);
			}
			if (this.NeedOpenUi)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x00359ABC File Offset: 0x00357CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPrepareInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.CurStageId != 0)
			{
				this.CurStageId = other.CurStageId;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			this.roles_.Add(other.roles_);
			this.roleEnergyInfos_.Add(other.roleEnergyInfos_);
			if (other.tokenPanelInfo_ != null)
			{
				if (this.tokenPanelInfo_ == null)
				{
					this.TokenPanelInfo = new RoleTowerTokenPanelInfo();
				}
				this.TokenPanelInfo.MergeFrom(other.TokenPanelInfo);
			}
			if (other.EquipTokenId != 0)
			{
				this.EquipTokenId = other.EquipTokenId;
			}
			this.stageInfos_.Add(other.stageInfos_);
			if (other.NeedBranchSelect)
			{
				this.NeedBranchSelect = other.NeedBranchSelect;
			}
			if (other.branchFloorInfo_ != null)
			{
				if (this.branchFloorInfo_ == null)
				{
					this.BranchFloorInfo = new RoleTowerFloorInfo();
				}
				this.BranchFloorInfo.MergeFrom(other.BranchFloorInfo);
			}
			this.teamStarInfo_.MergeFrom(other.teamStarInfo_);
			if (other.phantomInfo_ != null)
			{
				if (this.phantomInfo_ == null)
				{
					this.PhantomInfo = new RoleTowerPhantomInfo();
				}
				this.PhantomInfo.MergeFrom(other.PhantomInfo);
			}
			if (other.NeedOpenUi)
			{
				this.NeedOpenUi = other.NeedOpenUi;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00359C24 File Offset: 0x00357E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601708E RID: 94350 RVA: 0x00359C30 File Offset: 0x00357E30
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
				if (num <= 66U)
				{
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.CurStageId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.RemainTimeMs = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.roles_.AddEntriesFrom(ref input, RoleTowerPrepareInfo._repeated_roles_codec);
							continue;
						}
						if (num == 58U)
						{
							this.roleEnergyInfos_.AddEntriesFrom(ref input, RoleTowerPrepareInfo._repeated_roleEnergyInfos_codec);
							continue;
						}
						if (num == 66U)
						{
							if (this.tokenPanelInfo_ == null)
							{
								this.TokenPanelInfo = new RoleTowerTokenPanelInfo();
							}
							input.ReadMessage(this.TokenPanelInfo);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.EquipTokenId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.stageInfos_.AddEntriesFrom(ref input, RoleTowerPrepareInfo._repeated_stageInfos_codec);
						continue;
					}
					if (num == 88U)
					{
						this.NeedBranchSelect = input.ReadBool();
						continue;
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						if (this.branchFloorInfo_ == null)
						{
							this.BranchFloorInfo = new RoleTowerFloorInfo();
						}
						input.ReadMessage(this.BranchFloorInfo);
						continue;
					}
					if (num == 106U)
					{
						this.teamStarInfo_.AddEntriesFrom(ref input, RoleTowerPrepareInfo._map_teamStarInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.phantomInfo_ == null)
						{
							this.PhantomInfo = new RoleTowerPhantomInfo();
						}
						input.ReadMessage(this.PhantomInfo);
						continue;
					}
					if (num == 120U)
					{
						this.NeedOpenUi = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040089C9 RID: 35273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089CA RID: 35274
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x040089CB RID: 35275
		private int challengeId_;

		// Token: 0x040089CC RID: 35276
		public const int CurStageIdFieldNumber = 3;

		// Token: 0x040089CD RID: 35277
		private int curStageId_;

		// Token: 0x040089CE RID: 35278
		public const int RemainTimeMsFieldNumber = 4;

		// Token: 0x040089CF RID: 35279
		private long remainTimeMs_;

		// Token: 0x040089D0 RID: 35280
		public const int RolesFieldNumber = 5;

		// Token: 0x040089D1 RID: 35281
		private static readonly FieldCodec<RoleTowerRoleBrief> _repeated_roles_codec = FieldCodec.ForMessage<RoleTowerRoleBrief>(42U, RoleTowerRoleBrief.Parser);

		// Token: 0x040089D2 RID: 35282
		private readonly RepeatedField<RoleTowerRoleBrief> roles_ = new RepeatedField<RoleTowerRoleBrief>();

		// Token: 0x040089D3 RID: 35283
		public const int RoleEnergyInfosFieldNumber = 7;

		// Token: 0x040089D4 RID: 35284
		private static readonly FieldCodec<RoleTowerRoleEnergyInfo> _repeated_roleEnergyInfos_codec = FieldCodec.ForMessage<RoleTowerRoleEnergyInfo>(58U, RoleTowerRoleEnergyInfo.Parser);

		// Token: 0x040089D5 RID: 35285
		private readonly RepeatedField<RoleTowerRoleEnergyInfo> roleEnergyInfos_ = new RepeatedField<RoleTowerRoleEnergyInfo>();

		// Token: 0x040089D6 RID: 35286
		public const int TokenPanelInfoFieldNumber = 8;

		// Token: 0x040089D7 RID: 35287
		private RoleTowerTokenPanelInfo tokenPanelInfo_;

		// Token: 0x040089D8 RID: 35288
		public const int EquipTokenIdFieldNumber = 9;

		// Token: 0x040089D9 RID: 35289
		private int equipTokenId_;

		// Token: 0x040089DA RID: 35290
		public const int StageInfosFieldNumber = 10;

		// Token: 0x040089DB RID: 35291
		private static readonly FieldCodec<RoleTowerStageInfo> _repeated_stageInfos_codec = FieldCodec.ForMessage<RoleTowerStageInfo>(82U, RoleTowerStageInfo.Parser);

		// Token: 0x040089DC RID: 35292
		private readonly RepeatedField<RoleTowerStageInfo> stageInfos_ = new RepeatedField<RoleTowerStageInfo>();

		// Token: 0x040089DD RID: 35293
		public const int NeedBranchSelectFieldNumber = 11;

		// Token: 0x040089DE RID: 35294
		private bool needBranchSelect_;

		// Token: 0x040089DF RID: 35295
		public const int BranchFloorInfoFieldNumber = 12;

		// Token: 0x040089E0 RID: 35296
		private RoleTowerFloorInfo branchFloorInfo_;

		// Token: 0x040089E1 RID: 35297
		public const int TeamStarInfoFieldNumber = 13;

		// Token: 0x040089E2 RID: 35298
		private static readonly MapField<int, int>.Codec _map_teamStarInfo_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x040089E3 RID: 35299
		private readonly MapField<int, int> teamStarInfo_ = new MapField<int, int>();

		// Token: 0x040089E4 RID: 35300
		public const int PhantomInfoFieldNumber = 14;

		// Token: 0x040089E5 RID: 35301
		private RoleTowerPhantomInfo phantomInfo_;

		// Token: 0x040089E6 RID: 35302
		public const int NeedOpenUiFieldNumber = 15;

		// Token: 0x040089E7 RID: 35303
		private bool needOpenUi_;
	}
}
