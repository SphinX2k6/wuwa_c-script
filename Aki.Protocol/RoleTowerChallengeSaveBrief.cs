using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BD RID: 4285
	public sealed class RoleTowerChallengeSaveBrief : IMessage<RoleTowerChallengeSaveBrief>, IMessage, IEquatable<RoleTowerChallengeSaveBrief>, IDeepCloneable<RoleTowerChallengeSaveBrief>, IBufferMessage
	{
		// Token: 0x06016E6C RID: 93804 RVA: 0x00354434 File Offset: 0x00352634
		[NullableContext(1)]
		public static RoleTowerChallengeSaveBrief Create()
		{
			return new RoleTowerChallengeSaveBrief();
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x06016E6D RID: 93805 RVA: 0x0035443B File Offset: 0x0035263B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x06016E6E RID: 93806 RVA: 0x0035443E File Offset: 0x0035263E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeSaveBrief.Descriptor;
			}
		}

		// Token: 0x06016E6F RID: 93807 RVA: 0x00354448 File Offset: 0x00352648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSaveBrief()
		{
		}

		// Token: 0x06016E70 RID: 93808 RVA: 0x003544A0 File Offset: 0x003526A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSaveBrief(RoleTowerChallengeSaveBrief other) : this()
		{
			this.curStageId_ = other.curStageId_;
			this.passedFloorCount_ = other.passedFloorCount_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.saveTime_ = other.saveTime_;
			this.initialTokens_ = other.initialTokens_.Clone();
			this.roleList_ = other.roleList_.Clone();
			this.roleEnergyInfos_ = ((other.roleEnergyInfos_ != null) ? other.roleEnergyInfos_.Clone() : null);
			this.phantomAddAttrs_ = other.phantomAddAttrs_.Clone();
			this.phantomAddAttrInfos_ = other.phantomAddAttrInfos_.Clone();
			this.roleTowerRoleEnergyInfos_ = other.roleTowerRoleEnergyInfos_.Clone();
			this.teamStarInfo_ = other.teamStarInfo_.Clone();
			this.phantomInfo_ = ((other.phantomInfo_ != null) ? other.phantomInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E71 RID: 93809 RVA: 0x00354592 File Offset: 0x00352792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSaveBrief Clone()
		{
			return new RoleTowerChallengeSaveBrief(this);
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x06016E72 RID: 93810 RVA: 0x0035459A File Offset: 0x0035279A
		// (set) Token: 0x06016E73 RID: 93811 RVA: 0x003545A2 File Offset: 0x003527A2
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

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x06016E74 RID: 93812 RVA: 0x003545AB File Offset: 0x003527AB
		// (set) Token: 0x06016E75 RID: 93813 RVA: 0x003545B3 File Offset: 0x003527B3
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

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x06016E76 RID: 93814 RVA: 0x003545BC File Offset: 0x003527BC
		// (set) Token: 0x06016E77 RID: 93815 RVA: 0x003545C4 File Offset: 0x003527C4
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

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x06016E78 RID: 93816 RVA: 0x003545CD File Offset: 0x003527CD
		// (set) Token: 0x06016E79 RID: 93817 RVA: 0x003545D5 File Offset: 0x003527D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTime
		{
			get
			{
				return this.saveTime_;
			}
			set
			{
				this.saveTime_ = value;
			}
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x06016E7A RID: 93818 RVA: 0x003545DE File Offset: 0x003527DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> InitialTokens
		{
			get
			{
				return this.initialTokens_;
			}
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x06016E7B RID: 93819 RVA: 0x003545E6 File Offset: 0x003527E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x06016E7C RID: 93820 RVA: 0x003545EE File Offset: 0x003527EE
		// (set) Token: 0x06016E7D RID: 93821 RVA: 0x003545F6 File Offset: 0x003527F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleEnergyInfo RoleEnergyInfos
		{
			get
			{
				return this.roleEnergyInfos_;
			}
			set
			{
				this.roleEnergyInfos_ = value;
			}
		}

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x06016E7E RID: 93822 RVA: 0x003545FF File Offset: 0x003527FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PhantomAddAttrs
		{
			get
			{
				return this.phantomAddAttrs_;
			}
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x06016E7F RID: 93823 RVA: 0x00354607 File Offset: 0x00352807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerPhantomAddAttr> PhantomAddAttrInfos
		{
			get
			{
				return this.phantomAddAttrInfos_;
			}
		}

		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x06016E80 RID: 93824 RVA: 0x0035460F File Offset: 0x0035280F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleEnergyInfo> RoleTowerRoleEnergyInfos
		{
			get
			{
				return this.roleTowerRoleEnergyInfos_;
			}
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x06016E81 RID: 93825 RVA: 0x00354617 File Offset: 0x00352817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TeamStarInfo
		{
			get
			{
				return this.teamStarInfo_;
			}
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x06016E82 RID: 93826 RVA: 0x0035461F File Offset: 0x0035281F
		// (set) Token: 0x06016E83 RID: 93827 RVA: 0x00354627 File Offset: 0x00352827
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

		// Token: 0x06016E84 RID: 93828 RVA: 0x00354630 File Offset: 0x00352830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeSaveBrief);
		}

		// Token: 0x06016E85 RID: 93829 RVA: 0x00354640 File Offset: 0x00352840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeSaveBrief other)
		{
			return other != null && (other == this || (this.CurStageId == other.CurStageId && this.PassedFloorCount == other.PassedFloorCount && this.RemainTimeMs == other.RemainTimeMs && this.SaveTime == other.SaveTime && this.InitialTokens.Equals(other.InitialTokens) && this.roleList_.Equals(other.roleList_) && object.Equals(this.RoleEnergyInfos, other.RoleEnergyInfos) && this.PhantomAddAttrs.Equals(other.PhantomAddAttrs) && this.phantomAddAttrInfos_.Equals(other.phantomAddAttrInfos_) && this.roleTowerRoleEnergyInfos_.Equals(other.roleTowerRoleEnergyInfos_) && this.TeamStarInfo.Equals(other.TeamStarInfo) && object.Equals(this.PhantomInfo, other.PhantomInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E86 RID: 93830 RVA: 0x00354754 File Offset: 0x00352954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurStageId != 0)
			{
				num ^= this.CurStageId.GetHashCode();
			}
			if (this.PassedFloorCount != 0)
			{
				num ^= this.PassedFloorCount.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			if (this.SaveTime != 0L)
			{
				num ^= this.SaveTime.GetHashCode();
			}
			num ^= this.InitialTokens.GetHashCode();
			num ^= this.roleList_.GetHashCode();
			if (this.roleEnergyInfos_ != null)
			{
				num ^= this.RoleEnergyInfos.GetHashCode();
			}
			num ^= this.PhantomAddAttrs.GetHashCode();
			num ^= this.phantomAddAttrInfos_.GetHashCode();
			num ^= this.roleTowerRoleEnergyInfos_.GetHashCode();
			num ^= this.TeamStarInfo.GetHashCode();
			if (this.phantomInfo_ != null)
			{
				num ^= this.PhantomInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E87 RID: 93831 RVA: 0x0035485E File Offset: 0x00352A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E88 RID: 93832 RVA: 0x0035486B File Offset: 0x00352A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E89 RID: 93833 RVA: 0x00354874 File Offset: 0x00352A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurStageId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurStageId);
			}
			if (this.PassedFloorCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassedFloorCount);
			}
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.RemainTimeMs);
			}
			if (this.SaveTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SaveTime);
			}
			this.initialTokens_.WriteTo(ref output, RoleTowerChallengeSaveBrief._map_initialTokens_codec);
			this.roleList_.WriteTo(ref output, RoleTowerChallengeSaveBrief._repeated_roleList_codec);
			if (this.roleEnergyInfos_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RoleEnergyInfos);
			}
			this.phantomAddAttrs_.WriteTo(ref output, RoleTowerChallengeSaveBrief._map_phantomAddAttrs_codec);
			this.phantomAddAttrInfos_.WriteTo(ref output, RoleTowerChallengeSaveBrief._repeated_phantomAddAttrInfos_codec);
			this.roleTowerRoleEnergyInfos_.WriteTo(ref output, RoleTowerChallengeSaveBrief._repeated_roleTowerRoleEnergyInfos_codec);
			this.teamStarInfo_.WriteTo(ref output, RoleTowerChallengeSaveBrief._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PhantomInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E8A RID: 93834 RVA: 0x003549A4 File Offset: 0x00352BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurStageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStageId);
			}
			if (this.PassedFloorCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassedFloorCount);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			if (this.SaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTime);
			}
			num += this.initialTokens_.CalculateSize(RoleTowerChallengeSaveBrief._map_initialTokens_codec);
			num += this.roleList_.CalculateSize(RoleTowerChallengeSaveBrief._repeated_roleList_codec);
			if (this.roleEnergyInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleEnergyInfos);
			}
			num += this.phantomAddAttrs_.CalculateSize(RoleTowerChallengeSaveBrief._map_phantomAddAttrs_codec);
			num += this.phantomAddAttrInfos_.CalculateSize(RoleTowerChallengeSaveBrief._repeated_phantomAddAttrInfos_codec);
			num += this.roleTowerRoleEnergyInfos_.CalculateSize(RoleTowerChallengeSaveBrief._repeated_roleTowerRoleEnergyInfos_codec);
			num += this.teamStarInfo_.CalculateSize(RoleTowerChallengeSaveBrief._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E8B RID: 93835 RVA: 0x00354ACC File Offset: 0x00352CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeSaveBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurStageId != 0)
			{
				this.CurStageId = other.CurStageId;
			}
			if (other.PassedFloorCount != 0)
			{
				this.PassedFloorCount = other.PassedFloorCount;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			if (other.SaveTime != 0L)
			{
				this.SaveTime = other.SaveTime;
			}
			this.initialTokens_.MergeFrom(other.initialTokens_);
			this.roleList_.Add(other.roleList_);
			if (other.roleEnergyInfos_ != null)
			{
				if (this.roleEnergyInfos_ == null)
				{
					this.RoleEnergyInfos = new RoleTowerRoleEnergyInfo();
				}
				this.RoleEnergyInfos.MergeFrom(other.RoleEnergyInfos);
			}
			this.phantomAddAttrs_.MergeFrom(other.phantomAddAttrs_);
			this.phantomAddAttrInfos_.Add(other.phantomAddAttrInfos_);
			this.roleTowerRoleEnergyInfos_.Add(other.roleTowerRoleEnergyInfos_);
			this.teamStarInfo_.MergeFrom(other.teamStarInfo_);
			if (other.phantomInfo_ != null)
			{
				if (this.phantomInfo_ == null)
				{
					this.PhantomInfo = new RoleTowerPhantomInfo();
				}
				this.PhantomInfo.MergeFrom(other.PhantomInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E8C RID: 93836 RVA: 0x00354C02 File Offset: 0x00352E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E8D RID: 93837 RVA: 0x00354C0C File Offset: 0x00352E0C
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.CurStageId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.PassedFloorCount = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.RemainTimeMs = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.SaveTime = input.ReadInt64();
							continue;
						}
						if (num == 42U)
						{
							this.initialTokens_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._map_initialTokens_codec);
							continue;
						}
						if (num == 48U)
						{
							goto IL_100;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 50U)
					{
						goto IL_100;
					}
					if (num == 74U)
					{
						if (this.roleEnergyInfos_ == null)
						{
							this.RoleEnergyInfos = new RoleTowerRoleEnergyInfo();
						}
						input.ReadMessage(this.RoleEnergyInfos);
						continue;
					}
					if (num == 82U)
					{
						this.phantomAddAttrs_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._map_phantomAddAttrs_codec);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 90U)
					{
						this.phantomAddAttrInfos_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._repeated_phantomAddAttrInfos_codec);
						continue;
					}
					if (num == 98U)
					{
						this.roleTowerRoleEnergyInfos_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._repeated_roleTowerRoleEnergyInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.teamStarInfo_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._map_teamStarInfo_codec);
						continue;
					}
					if (num == 114U)
					{
						if (this.phantomInfo_ == null)
						{
							this.PhantomInfo = new RoleTowerPhantomInfo();
						}
						input.ReadMessage(this.PhantomInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_100:
				this.roleList_.AddEntriesFrom(ref input, RoleTowerChallengeSaveBrief._repeated_roleList_codec);
			}
		}

		// Token: 0x0400890C RID: 35084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400890D RID: 35085
		public const int CurStageIdFieldNumber = 1;

		// Token: 0x0400890E RID: 35086
		private int curStageId_;

		// Token: 0x0400890F RID: 35087
		public const int PassedFloorCountFieldNumber = 2;

		// Token: 0x04008910 RID: 35088
		private int passedFloorCount_;

		// Token: 0x04008911 RID: 35089
		public const int RemainTimeMsFieldNumber = 3;

		// Token: 0x04008912 RID: 35090
		private long remainTimeMs_;

		// Token: 0x04008913 RID: 35091
		public const int SaveTimeFieldNumber = 4;

		// Token: 0x04008914 RID: 35092
		private long saveTime_;

		// Token: 0x04008915 RID: 35093
		public const int InitialTokensFieldNumber = 5;

		// Token: 0x04008916 RID: 35094
		private static readonly MapField<int, int>.Codec _map_initialTokens_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04008917 RID: 35095
		private readonly MapField<int, int> initialTokens_ = new MapField<int, int>();

		// Token: 0x04008918 RID: 35096
		public const int RoleListFieldNumber = 6;

		// Token: 0x04008919 RID: 35097
		private static readonly FieldCodec<int> _repeated_roleList_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400891A RID: 35098
		private readonly RepeatedField<int> roleList_ = new RepeatedField<int>();

		// Token: 0x0400891B RID: 35099
		public const int RoleEnergyInfosFieldNumber = 9;

		// Token: 0x0400891C RID: 35100
		private RoleTowerRoleEnergyInfo roleEnergyInfos_;

		// Token: 0x0400891D RID: 35101
		public const int PhantomAddAttrsFieldNumber = 10;

		// Token: 0x0400891E RID: 35102
		private static readonly MapField<int, int>.Codec _map_phantomAddAttrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x0400891F RID: 35103
		private readonly MapField<int, int> phantomAddAttrs_ = new MapField<int, int>();

		// Token: 0x04008920 RID: 35104
		public const int PhantomAddAttrInfosFieldNumber = 11;

		// Token: 0x04008921 RID: 35105
		private static readonly FieldCodec<RoleTowerPhantomAddAttr> _repeated_phantomAddAttrInfos_codec = FieldCodec.ForMessage<RoleTowerPhantomAddAttr>(90U, RoleTowerPhantomAddAttr.Parser);

		// Token: 0x04008922 RID: 35106
		private readonly RepeatedField<RoleTowerPhantomAddAttr> phantomAddAttrInfos_ = new RepeatedField<RoleTowerPhantomAddAttr>();

		// Token: 0x04008923 RID: 35107
		public const int RoleTowerRoleEnergyInfosFieldNumber = 12;

		// Token: 0x04008924 RID: 35108
		private static readonly FieldCodec<RoleTowerRoleEnergyInfo> _repeated_roleTowerRoleEnergyInfos_codec = FieldCodec.ForMessage<RoleTowerRoleEnergyInfo>(98U, RoleTowerRoleEnergyInfo.Parser);

		// Token: 0x04008925 RID: 35109
		private readonly RepeatedField<RoleTowerRoleEnergyInfo> roleTowerRoleEnergyInfos_ = new RepeatedField<RoleTowerRoleEnergyInfo>();

		// Token: 0x04008926 RID: 35110
		public const int TeamStarInfoFieldNumber = 13;

		// Token: 0x04008927 RID: 35111
		private static readonly MapField<int, int>.Codec _map_teamStarInfo_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 106U);

		// Token: 0x04008928 RID: 35112
		private readonly MapField<int, int> teamStarInfo_ = new MapField<int, int>();

		// Token: 0x04008929 RID: 35113
		public const int PhantomInfoFieldNumber = 14;

		// Token: 0x0400892A RID: 35114
		private RoleTowerPhantomInfo phantomInfo_;
	}
}
