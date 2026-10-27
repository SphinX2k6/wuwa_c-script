using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Ai;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046D RID: 1133
	[NetMessage(EMessageId.EntityBattleInfoResponse)]
	public sealed class EntityBattleInfoResponse : IMessage<EntityBattleInfoResponse>, IMessage, IEquatable<EntityBattleInfoResponse>, IDeepCloneable<EntityBattleInfoResponse>, IBufferMessage
	{
		// Token: 0x06006C0E RID: 27662 RVA: 0x00104B31 File Offset: 0x00102D31
		[NullableContext(1)]
		public static EntityBattleInfoResponse Create()
		{
			return new EntityBattleInfoResponse();
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00104B38 File Offset: 0x00102D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x00104B3B File Offset: 0x00102D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleInfoResponse.Descriptor;
			}
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x00104B44 File Offset: 0x00102D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoResponse()
		{
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x00104B9C File Offset: 0x00102D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoResponse(EntityBattleInfoResponse other) : this()
		{
			this.entityId_ = other.entityId_;
			this.errorCode_ = other.errorCode_;
			this.fightBuffComponentPb_ = ((other.fightBuffComponentPb_ != null) ? other.fightBuffComponentPb_.Clone() : null);
			this.entityBattleTagInfo_ = other.entityBattleTagInfo_.Clone();
			this.attributes_ = other.attributes_.Clone();
			this.formationAttrs_ = other.formationAttrs_.Clone();
			this.partComponentPb_ = ((other.partComponentPb_ != null) ? other.partComponentPb_.Clone() : null);
			this.hateList_ = other.hateList_.Clone();
			this.shieldComponentPb_ = ((other.shieldComponentPb_ != null) ? other.shieldComponentPb_.Clone() : null);
			this.playerTagInfos_ = other.playerTagInfos_.Clone();
			this.entityPassiveSkillInfo_ = other.entityPassiveSkillInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00104C8D File Offset: 0x00102E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoResponse Clone()
		{
			return new EntityBattleInfoResponse(this);
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06006C14 RID: 27668 RVA: 0x00104C95 File Offset: 0x00102E95
		// (set) Token: 0x06006C15 RID: 27669 RVA: 0x00104C9D File Offset: 0x00102E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06006C16 RID: 27670 RVA: 0x00104CA6 File Offset: 0x00102EA6
		// (set) Token: 0x06006C17 RID: 27671 RVA: 0x00104CAE File Offset: 0x00102EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06006C18 RID: 27672 RVA: 0x00104CB7 File Offset: 0x00102EB7
		// (set) Token: 0x06006C19 RID: 27673 RVA: 0x00104CBF File Offset: 0x00102EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb FightBuffComponentPb
		{
			get
			{
				return this.fightBuffComponentPb_;
			}
			set
			{
				this.fightBuffComponentPb_ = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06006C1A RID: 27674 RVA: 0x00104CC8 File Offset: 0x00102EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBattleTagInfo> EntityBattleTagInfo
		{
			get
			{
				return this.entityBattleTagInfo_;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x00104CD0 File Offset: 0x00102ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06006C1C RID: 27676 RVA: 0x00104CD8 File Offset: 0x00102ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x00104CE0 File Offset: 0x00102EE0
		// (set) Token: 0x06006C1E RID: 27678 RVA: 0x00104CE8 File Offset: 0x00102EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb PartComponentPb
		{
			get
			{
				return this.partComponentPb_;
			}
			set
			{
				this.partComponentPb_ = value;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x00104CF1 File Offset: 0x00102EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06006C20 RID: 27680 RVA: 0x00104CF9 File Offset: 0x00102EF9
		// (set) Token: 0x06006C21 RID: 27681 RVA: 0x00104D01 File Offset: 0x00102F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb ShieldComponentPb
		{
			get
			{
				return this.shieldComponentPb_;
			}
			set
			{
				this.shieldComponentPb_ = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06006C22 RID: 27682 RVA: 0x00104D0A File Offset: 0x00102F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBattleTagInfo> PlayerTagInfos
		{
			get
			{
				return this.playerTagInfos_;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x00104D12 File Offset: 0x00102F12
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x00104D1A File Offset: 0x00102F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EntityPassiveSkillInfo
		{
			get
			{
				return this.entityPassiveSkillInfo_;
			}
			set
			{
				this.entityPassiveSkillInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x00104D2D File Offset: 0x00102F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleInfoResponse);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x00104D3C File Offset: 0x00102F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleInfoResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ErrorCode == other.ErrorCode && object.Equals(this.FightBuffComponentPb, other.FightBuffComponentPb) && this.entityBattleTagInfo_.Equals(other.entityBattleTagInfo_) && this.attributes_.Equals(other.attributes_) && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this.PartComponentPb, other.PartComponentPb) && this.hateList_.Equals(other.hateList_) && object.Equals(this.ShieldComponentPb, other.ShieldComponentPb) && this.playerTagInfos_.Equals(other.playerTagInfos_) && !(this.EntityPassiveSkillInfo != other.EntityPassiveSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x00104E44 File Offset: 0x00103044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fightBuffComponentPb_ != null)
			{
				num ^= this.FightBuffComponentPb.GetHashCode();
			}
			num ^= this.entityBattleTagInfo_.GetHashCode();
			num ^= this.attributes_.GetHashCode();
			num ^= this.formationAttrs_.GetHashCode();
			if (this.partComponentPb_ != null)
			{
				num ^= this.PartComponentPb.GetHashCode();
			}
			num ^= this.hateList_.GetHashCode();
			if (this.shieldComponentPb_ != null)
			{
				num ^= this.ShieldComponentPb.GetHashCode();
			}
			num ^= this.playerTagInfos_.GetHashCode();
			if (this.EntityPassiveSkillInfo.Length != 0)
			{
				num ^= this.EntityPassiveSkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00104F45 File Offset: 0x00103145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x00104F52 File Offset: 0x00103152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00104F5C File Offset: 0x0010315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.partComponentPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PartComponentPb);
			}
			if (this.fightBuffComponentPb_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FightBuffComponentPb);
			}
			if (this.shieldComponentPb_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ShieldComponentPb);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			this.entityBattleTagInfo_.WriteTo(ref output, EntityBattleInfoResponse._repeated_entityBattleTagInfo_codec);
			this.formationAttrs_.WriteTo(ref output, EntityBattleInfoResponse._repeated_formationAttrs_codec);
			this.attributes_.WriteTo(ref output, EntityBattleInfoResponse._repeated_attributes_codec);
			if (this.EntityPassiveSkillInfo.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.EntityPassiveSkillInfo);
			}
			this.playerTagInfos_.WriteTo(ref output, EntityBattleInfoResponse._repeated_playerTagInfos_codec);
			this.hateList_.WriteTo(ref output, EntityBattleInfoResponse._repeated_hateList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x00105080 File Offset: 0x00103280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fightBuffComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightBuffComponentPb);
			}
			num += this.entityBattleTagInfo_.CalculateSize(EntityBattleInfoResponse._repeated_entityBattleTagInfo_codec);
			num += this.attributes_.CalculateSize(EntityBattleInfoResponse._repeated_attributes_codec);
			num += this.formationAttrs_.CalculateSize(EntityBattleInfoResponse._repeated_formationAttrs_codec);
			if (this.partComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartComponentPb);
			}
			num += this.hateList_.CalculateSize(EntityBattleInfoResponse._repeated_hateList_codec);
			if (this.shieldComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShieldComponentPb);
			}
			num += this.playerTagInfos_.CalculateSize(EntityBattleInfoResponse._repeated_playerTagInfos_codec);
			if (this.EntityPassiveSkillInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EntityPassiveSkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x0010519C File Offset: 0x0010339C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBattleInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fightBuffComponentPb_ != null)
			{
				if (this.fightBuffComponentPb_ == null)
				{
					this.FightBuffComponentPb = new FightBuffComponentPb();
				}
				this.FightBuffComponentPb.MergeFrom(other.FightBuffComponentPb);
			}
			this.entityBattleTagInfo_.Add(other.entityBattleTagInfo_);
			this.attributes_.Add(other.attributes_);
			this.formationAttrs_.Add(other.formationAttrs_);
			if (other.partComponentPb_ != null)
			{
				if (this.partComponentPb_ == null)
				{
					this.PartComponentPb = new PartComponentPb();
				}
				this.PartComponentPb.MergeFrom(other.PartComponentPb);
			}
			this.hateList_.Add(other.hateList_);
			if (other.shieldComponentPb_ != null)
			{
				if (this.shieldComponentPb_ == null)
				{
					this.ShieldComponentPb = new ShieldComponentPb();
				}
				this.ShieldComponentPb.MergeFrom(other.ShieldComponentPb);
			}
			this.playerTagInfos_.Add(other.playerTagInfos_);
			if (other.EntityPassiveSkillInfo.Length != 0)
			{
				this.EntityPassiveSkillInfo = other.EntityPassiveSkillInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x001052DE File Offset: 0x001034DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x001052E8 File Offset: 0x001034E8
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
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.partComponentPb_ == null)
							{
								this.PartComponentPb = new PartComponentPb();
							}
							input.ReadMessage(this.PartComponentPb);
							continue;
						}
						if (num == 18U)
						{
							if (this.fightBuffComponentPb_ == null)
							{
								this.FightBuffComponentPb = new FightBuffComponentPb();
							}
							input.ReadMessage(this.FightBuffComponentPb);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.shieldComponentPb_ == null)
							{
								this.ShieldComponentPb = new ShieldComponentPb();
							}
							input.ReadMessage(this.ShieldComponentPb);
							continue;
						}
						if (num == 48U)
						{
							this.EntityId = input.ReadInt64();
							continue;
						}
						if (num == 66U)
						{
							this.entityBattleTagInfo_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_entityBattleTagInfo_codec);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 82U)
					{
						this.formationAttrs_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_formationAttrs_codec);
						continue;
					}
					if (num == 90U)
					{
						this.attributes_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_attributes_codec);
						continue;
					}
					if (num == 98U)
					{
						this.EntityPassiveSkillInfo = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.playerTagInfos_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_playerTagInfos_codec);
						continue;
					}
					if (num == 114U)
					{
						this.hateList_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_hateList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AC5 RID: 15045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AC6 RID: 15046
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003AC7 RID: 15047
		private long entityId_;

		// Token: 0x04003AC8 RID: 15048
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003AC9 RID: 15049
		private ErrorCode errorCode_;

		// Token: 0x04003ACA RID: 15050
		public const int FightBuffComponentPbFieldNumber = 2;

		// Token: 0x04003ACB RID: 15051
		private FightBuffComponentPb fightBuffComponentPb_;

		// Token: 0x04003ACC RID: 15052
		public const int EntityBattleTagInfoFieldNumber = 8;

		// Token: 0x04003ACD RID: 15053
		private static readonly FieldCodec<EntityBattleTagInfo> _repeated_entityBattleTagInfo_codec = FieldCodec.ForMessage<EntityBattleTagInfo>(66U, Aki.Protocol.EntityBattleTagInfo.Parser);

		// Token: 0x04003ACE RID: 15054
		private readonly RepeatedField<EntityBattleTagInfo> entityBattleTagInfo_ = new RepeatedField<EntityBattleTagInfo>();

		// Token: 0x04003ACF RID: 15055
		public const int AttributesFieldNumber = 11;

		// Token: 0x04003AD0 RID: 15056
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(90U, GameplayAttributeData.Parser);

		// Token: 0x04003AD1 RID: 15057
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x04003AD2 RID: 15058
		public const int FormationAttrsFieldNumber = 10;

		// Token: 0x04003AD3 RID: 15059
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(82U, FormationAttr.Parser);

		// Token: 0x04003AD4 RID: 15060
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();

		// Token: 0x04003AD5 RID: 15061
		public const int PartComponentPbFieldNumber = 1;

		// Token: 0x04003AD6 RID: 15062
		private PartComponentPb partComponentPb_;

		// Token: 0x04003AD7 RID: 15063
		public const int HateListFieldNumber = 14;

		// Token: 0x04003AD8 RID: 15064
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(114U, AiHateEntity.Parser);

		// Token: 0x04003AD9 RID: 15065
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();

		// Token: 0x04003ADA RID: 15066
		public const int ShieldComponentPbFieldNumber = 4;

		// Token: 0x04003ADB RID: 15067
		private ShieldComponentPb shieldComponentPb_;

		// Token: 0x04003ADC RID: 15068
		public const int PlayerTagInfosFieldNumber = 13;

		// Token: 0x04003ADD RID: 15069
		private static readonly FieldCodec<EntityBattleTagInfo> _repeated_playerTagInfos_codec = FieldCodec.ForMessage<EntityBattleTagInfo>(106U, Aki.Protocol.EntityBattleTagInfo.Parser);

		// Token: 0x04003ADE RID: 15070
		private readonly RepeatedField<EntityBattleTagInfo> playerTagInfos_ = new RepeatedField<EntityBattleTagInfo>();

		// Token: 0x04003ADF RID: 15071
		public const int EntityPassiveSkillInfoFieldNumber = 12;

		// Token: 0x04003AE0 RID: 15072
		private string entityPassiveSkillInfo_ = "";
	}
}
