using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F1 RID: 4337
	public sealed class RoleTowerStageSettleInfo : IMessage<RoleTowerStageSettleInfo>, IMessage, IEquatable<RoleTowerStageSettleInfo>, IDeepCloneable<RoleTowerStageSettleInfo>, IBufferMessage
	{
		// Token: 0x060172F1 RID: 94961 RVA: 0x0035F765 File Offset: 0x0035D965
		[NullableContext(1)]
		public static RoleTowerStageSettleInfo Create()
		{
			return new RoleTowerStageSettleInfo();
		}

		// Token: 0x17004DDD RID: 19933
		// (get) Token: 0x060172F2 RID: 94962 RVA: 0x0035F76C File Offset: 0x0035D96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DDE RID: 19934
		// (get) Token: 0x060172F3 RID: 94963 RVA: 0x0035F76F File Offset: 0x0035D96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageSettleInfo.Descriptor;
			}
		}

		// Token: 0x060172F4 RID: 94964 RVA: 0x0035F776 File Offset: 0x0035D976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleInfo()
		{
		}

		// Token: 0x060172F5 RID: 94965 RVA: 0x0035F794 File Offset: 0x0035D994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleInfo(RoleTowerStageSettleInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.stageId_ = other.stageId_;
			this.stageRecord_ = ((other.stageRecord_ != null) ? other.stageRecord_.Clone() : null);
			this.gainTokens_ = other.gainTokens_.Clone();
			this.assistRoles_ = other.assistRoles_.Clone();
			this.beforeTeamStar_ = other.beforeTeamStar_;
			this.afterTeamStar_ = other.afterTeamStar_;
			this.phantomExp_ = other.phantomExp_;
			this.beforePhantomLevel_ = other.beforePhantomLevel_;
			this.afterPhantomLevel_ = other.afterPhantomLevel_;
			this.curPhantomExp_ = other.curPhantomExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060172F6 RID: 94966 RVA: 0x0035F856 File Offset: 0x0035DA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleInfo Clone()
		{
			return new RoleTowerStageSettleInfo(this);
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x060172F7 RID: 94967 RVA: 0x0035F85E File Offset: 0x0035DA5E
		// (set) Token: 0x060172F8 RID: 94968 RVA: 0x0035F866 File Offset: 0x0035DA66
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

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x060172F9 RID: 94969 RVA: 0x0035F86F File Offset: 0x0035DA6F
		// (set) Token: 0x060172FA RID: 94970 RVA: 0x0035F877 File Offset: 0x0035DA77
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

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x060172FB RID: 94971 RVA: 0x0035F880 File Offset: 0x0035DA80
		// (set) Token: 0x060172FC RID: 94972 RVA: 0x0035F888 File Offset: 0x0035DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageRecord StageRecord
		{
			get
			{
				return this.stageRecord_;
			}
			set
			{
				this.stageRecord_ = value;
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x060172FD RID: 94973 RVA: 0x0035F891 File Offset: 0x0035DA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerTokenCount> GainTokens
		{
			get
			{
				return this.gainTokens_;
			}
		}

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x060172FE RID: 94974 RVA: 0x0035F899 File Offset: 0x0035DA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerAssistRoleInfo> AssistRoles
		{
			get
			{
				return this.assistRoles_;
			}
		}

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x060172FF RID: 94975 RVA: 0x0035F8A1 File Offset: 0x0035DAA1
		// (set) Token: 0x06017300 RID: 94976 RVA: 0x0035F8A9 File Offset: 0x0035DAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeforeTeamStar
		{
			get
			{
				return this.beforeTeamStar_;
			}
			set
			{
				this.beforeTeamStar_ = value;
			}
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x06017301 RID: 94977 RVA: 0x0035F8B2 File Offset: 0x0035DAB2
		// (set) Token: 0x06017302 RID: 94978 RVA: 0x0035F8BA File Offset: 0x0035DABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterTeamStar
		{
			get
			{
				return this.afterTeamStar_;
			}
			set
			{
				this.afterTeamStar_ = value;
			}
		}

		// Token: 0x17004DE6 RID: 19942
		// (get) Token: 0x06017303 RID: 94979 RVA: 0x0035F8C3 File Offset: 0x0035DAC3
		// (set) Token: 0x06017304 RID: 94980 RVA: 0x0035F8CB File Offset: 0x0035DACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomExp
		{
			get
			{
				return this.phantomExp_;
			}
			set
			{
				this.phantomExp_ = value;
			}
		}

		// Token: 0x17004DE7 RID: 19943
		// (get) Token: 0x06017305 RID: 94981 RVA: 0x0035F8D4 File Offset: 0x0035DAD4
		// (set) Token: 0x06017306 RID: 94982 RVA: 0x0035F8DC File Offset: 0x0035DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeforePhantomLevel
		{
			get
			{
				return this.beforePhantomLevel_;
			}
			set
			{
				this.beforePhantomLevel_ = value;
			}
		}

		// Token: 0x17004DE8 RID: 19944
		// (get) Token: 0x06017307 RID: 94983 RVA: 0x0035F8E5 File Offset: 0x0035DAE5
		// (set) Token: 0x06017308 RID: 94984 RVA: 0x0035F8ED File Offset: 0x0035DAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterPhantomLevel
		{
			get
			{
				return this.afterPhantomLevel_;
			}
			set
			{
				this.afterPhantomLevel_ = value;
			}
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x06017309 RID: 94985 RVA: 0x0035F8F6 File Offset: 0x0035DAF6
		// (set) Token: 0x0601730A RID: 94986 RVA: 0x0035F8FE File Offset: 0x0035DAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPhantomExp
		{
			get
			{
				return this.curPhantomExp_;
			}
			set
			{
				this.curPhantomExp_ = value;
			}
		}

		// Token: 0x0601730B RID: 94987 RVA: 0x0035F907 File Offset: 0x0035DB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageSettleInfo);
		}

		// Token: 0x0601730C RID: 94988 RVA: 0x0035F918 File Offset: 0x0035DB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageSettleInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.StageId == other.StageId && object.Equals(this.StageRecord, other.StageRecord) && this.gainTokens_.Equals(other.gainTokens_) && this.assistRoles_.Equals(other.assistRoles_) && this.BeforeTeamStar == other.BeforeTeamStar && this.AfterTeamStar == other.AfterTeamStar && this.PhantomExp == other.PhantomExp && this.BeforePhantomLevel == other.BeforePhantomLevel && this.AfterPhantomLevel == other.AfterPhantomLevel && this.CurPhantomExp == other.CurPhantomExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601730D RID: 94989 RVA: 0x0035FA00 File Offset: 0x0035DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.StageId != 0)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.stageRecord_ != null)
			{
				num ^= this.StageRecord.GetHashCode();
			}
			num ^= this.gainTokens_.GetHashCode();
			num ^= this.assistRoles_.GetHashCode();
			if (this.BeforeTeamStar != 0)
			{
				num ^= this.BeforeTeamStar.GetHashCode();
			}
			if (this.AfterTeamStar != 0)
			{
				num ^= this.AfterTeamStar.GetHashCode();
			}
			if (this.PhantomExp != 0)
			{
				num ^= this.PhantomExp.GetHashCode();
			}
			if (this.BeforePhantomLevel != 0)
			{
				num ^= this.BeforePhantomLevel.GetHashCode();
			}
			if (this.AfterPhantomLevel != 0)
			{
				num ^= this.AfterPhantomLevel.GetHashCode();
			}
			if (this.CurPhantomExp != 0)
			{
				num ^= this.CurPhantomExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601730E RID: 94990 RVA: 0x0035FB20 File Offset: 0x0035DD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601730F RID: 94991 RVA: 0x0035FB2D File Offset: 0x0035DD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017310 RID: 94992 RVA: 0x0035FB38 File Offset: 0x0035DD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.StageId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StageId);
			}
			if (this.stageRecord_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StageRecord);
			}
			this.gainTokens_.WriteTo(ref output, RoleTowerStageSettleInfo._repeated_gainTokens_codec);
			this.assistRoles_.WriteTo(ref output, RoleTowerStageSettleInfo._repeated_assistRoles_codec);
			if (this.BeforeTeamStar != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BeforeTeamStar);
			}
			if (this.AfterTeamStar != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AfterTeamStar);
			}
			if (this.PhantomExp != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PhantomExp);
			}
			if (this.BeforePhantomLevel != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BeforePhantomLevel);
			}
			if (this.AfterPhantomLevel != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AfterPhantomLevel);
			}
			if (this.CurPhantomExp != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurPhantomExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017311 RID: 94993 RVA: 0x0035FC78 File Offset: 0x0035DE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.StageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StageId);
			}
			if (this.stageRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageRecord);
			}
			num += this.gainTokens_.CalculateSize(RoleTowerStageSettleInfo._repeated_gainTokens_codec);
			num += this.assistRoles_.CalculateSize(RoleTowerStageSettleInfo._repeated_assistRoles_codec);
			if (this.BeforeTeamStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforeTeamStar);
			}
			if (this.AfterTeamStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterTeamStar);
			}
			if (this.PhantomExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomExp);
			}
			if (this.BeforePhantomLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforePhantomLevel);
			}
			if (this.AfterPhantomLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterPhantomLevel);
			}
			if (this.CurPhantomExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPhantomExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017312 RID: 94994 RVA: 0x0035FD9C File Offset: 0x0035DF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageSettleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.StageId != 0)
			{
				this.StageId = other.StageId;
			}
			if (other.stageRecord_ != null)
			{
				if (this.stageRecord_ == null)
				{
					this.StageRecord = new RoleTowerStageRecord();
				}
				this.StageRecord.MergeFrom(other.StageRecord);
			}
			this.gainTokens_.Add(other.gainTokens_);
			this.assistRoles_.Add(other.assistRoles_);
			if (other.BeforeTeamStar != 0)
			{
				this.BeforeTeamStar = other.BeforeTeamStar;
			}
			if (other.AfterTeamStar != 0)
			{
				this.AfterTeamStar = other.AfterTeamStar;
			}
			if (other.PhantomExp != 0)
			{
				this.PhantomExp = other.PhantomExp;
			}
			if (other.BeforePhantomLevel != 0)
			{
				this.BeforePhantomLevel = other.BeforePhantomLevel;
			}
			if (other.AfterPhantomLevel != 0)
			{
				this.AfterPhantomLevel = other.AfterPhantomLevel;
			}
			if (other.CurPhantomExp != 0)
			{
				this.CurPhantomExp = other.CurPhantomExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017313 RID: 94995 RVA: 0x0035FEB2 File Offset: 0x0035E0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017314 RID: 94996 RVA: 0x0035FEBC File Offset: 0x0035E0BC
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
				if (num <= 42U)
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
							this.StageId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.stageRecord_ == null)
							{
								this.StageRecord = new RoleTowerStageRecord();
							}
							input.ReadMessage(this.StageRecord);
							continue;
						}
						if (num == 34U)
						{
							this.gainTokens_.AddEntriesFrom(ref input, RoleTowerStageSettleInfo._repeated_gainTokens_codec);
							continue;
						}
						if (num == 42U)
						{
							this.assistRoles_.AddEntriesFrom(ref input, RoleTowerStageSettleInfo._repeated_assistRoles_codec);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.BeforeTeamStar = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.AfterTeamStar = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PhantomExp = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.BeforePhantomLevel = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.AfterPhantomLevel = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.CurPhantomExp = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008AB6 RID: 35510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AB7 RID: 35511
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04008AB8 RID: 35512
		private int challengeId_;

		// Token: 0x04008AB9 RID: 35513
		public const int StageIdFieldNumber = 2;

		// Token: 0x04008ABA RID: 35514
		private int stageId_;

		// Token: 0x04008ABB RID: 35515
		public const int StageRecordFieldNumber = 3;

		// Token: 0x04008ABC RID: 35516
		private RoleTowerStageRecord stageRecord_;

		// Token: 0x04008ABD RID: 35517
		public const int GainTokensFieldNumber = 4;

		// Token: 0x04008ABE RID: 35518
		private static readonly FieldCodec<RoleTowerTokenCount> _repeated_gainTokens_codec = FieldCodec.ForMessage<RoleTowerTokenCount>(34U, RoleTowerTokenCount.Parser);

		// Token: 0x04008ABF RID: 35519
		private readonly RepeatedField<RoleTowerTokenCount> gainTokens_ = new RepeatedField<RoleTowerTokenCount>();

		// Token: 0x04008AC0 RID: 35520
		public const int AssistRolesFieldNumber = 5;

		// Token: 0x04008AC1 RID: 35521
		private static readonly FieldCodec<RoleTowerAssistRoleInfo> _repeated_assistRoles_codec = FieldCodec.ForMessage<RoleTowerAssistRoleInfo>(42U, RoleTowerAssistRoleInfo.Parser);

		// Token: 0x04008AC2 RID: 35522
		private readonly RepeatedField<RoleTowerAssistRoleInfo> assistRoles_ = new RepeatedField<RoleTowerAssistRoleInfo>();

		// Token: 0x04008AC3 RID: 35523
		public const int BeforeTeamStarFieldNumber = 6;

		// Token: 0x04008AC4 RID: 35524
		private int beforeTeamStar_;

		// Token: 0x04008AC5 RID: 35525
		public const int AfterTeamStarFieldNumber = 7;

		// Token: 0x04008AC6 RID: 35526
		private int afterTeamStar_;

		// Token: 0x04008AC7 RID: 35527
		public const int PhantomExpFieldNumber = 8;

		// Token: 0x04008AC8 RID: 35528
		private int phantomExp_;

		// Token: 0x04008AC9 RID: 35529
		public const int BeforePhantomLevelFieldNumber = 9;

		// Token: 0x04008ACA RID: 35530
		private int beforePhantomLevel_;

		// Token: 0x04008ACB RID: 35531
		public const int AfterPhantomLevelFieldNumber = 10;

		// Token: 0x04008ACC RID: 35532
		private int afterPhantomLevel_;

		// Token: 0x04008ACD RID: 35533
		public const int CurPhantomExpFieldNumber = 11;

		// Token: 0x04008ACE RID: 35534
		private int curPhantomExp_;
	}
}
