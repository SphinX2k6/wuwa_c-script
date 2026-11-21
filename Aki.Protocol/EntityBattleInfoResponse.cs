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
	// Token: 0x02000456 RID: 1110
	[NetMessage(EMessageId.EntityBattleInfoResponse)]
	public sealed class EntityBattleInfoResponse : IMessage<EntityBattleInfoResponse>, IMessage, IEquatable<EntityBattleInfoResponse>, IDeepCloneable<EntityBattleInfoResponse>, IBufferMessage
	{
		// Token: 0x06006A80 RID: 27264 RVA: 0x00101ABD File Offset: 0x000FFCBD
		[NullableContext(1)]
		public static EntityBattleInfoResponse Create()
		{
			return new EntityBattleInfoResponse();
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x00101AC4 File Offset: 0x000FFCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x00101AC7 File Offset: 0x000FFCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBattleInfoResponse.Descriptor;
			}
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x00101AD0 File Offset: 0x000FFCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoResponse()
		{
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00101B28 File Offset: 0x000FFD28
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

		// Token: 0x06006A85 RID: 27269 RVA: 0x00101C19 File Offset: 0x000FFE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBattleInfoResponse Clone()
		{
			return new EntityBattleInfoResponse(this);
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x00101C21 File Offset: 0x000FFE21
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x00101C29 File Offset: 0x000FFE29
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

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x00101C32 File Offset: 0x000FFE32
		// (set) Token: 0x06006A89 RID: 27273 RVA: 0x00101C3A File Offset: 0x000FFE3A
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

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06006A8A RID: 27274 RVA: 0x00101C43 File Offset: 0x000FFE43
		// (set) Token: 0x06006A8B RID: 27275 RVA: 0x00101C4B File Offset: 0x000FFE4B
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

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x00101C54 File Offset: 0x000FFE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBattleTagInfo> EntityBattleTagInfo
		{
			get
			{
				return this.entityBattleTagInfo_;
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06006A8D RID: 27277 RVA: 0x00101C5C File Offset: 0x000FFE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x00101C64 File Offset: 0x000FFE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationAttr> FormationAttrs
		{
			get
			{
				return this.formationAttrs_;
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06006A8F RID: 27279 RVA: 0x00101C6C File Offset: 0x000FFE6C
		// (set) Token: 0x06006A90 RID: 27280 RVA: 0x00101C74 File Offset: 0x000FFE74
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

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06006A91 RID: 27281 RVA: 0x00101C7D File Offset: 0x000FFE7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiHateEntity> HateList
		{
			get
			{
				return this.hateList_;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06006A92 RID: 27282 RVA: 0x00101C85 File Offset: 0x000FFE85
		// (set) Token: 0x06006A93 RID: 27283 RVA: 0x00101C8D File Offset: 0x000FFE8D
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

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06006A94 RID: 27284 RVA: 0x00101C96 File Offset: 0x000FFE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityBattleTagInfo> PlayerTagInfos
		{
			get
			{
				return this.playerTagInfos_;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x00101C9E File Offset: 0x000FFE9E
		// (set) Token: 0x06006A96 RID: 27286 RVA: 0x00101CA6 File Offset: 0x000FFEA6
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

		// Token: 0x06006A97 RID: 27287 RVA: 0x00101CB9 File Offset: 0x000FFEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBattleInfoResponse);
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x00101CC8 File Offset: 0x000FFEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBattleInfoResponse other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ErrorCode == other.ErrorCode && object.Equals(this.FightBuffComponentPb, other.FightBuffComponentPb) && this.entityBattleTagInfo_.Equals(other.entityBattleTagInfo_) && this.attributes_.Equals(other.attributes_) && this.formationAttrs_.Equals(other.formationAttrs_) && object.Equals(this.PartComponentPb, other.PartComponentPb) && this.hateList_.Equals(other.hateList_) && object.Equals(this.ShieldComponentPb, other.ShieldComponentPb) && this.playerTagInfos_.Equals(other.playerTagInfos_) && !(this.EntityPassiveSkillInfo != other.EntityPassiveSkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x00101DD0 File Offset: 0x000FFFD0
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

		// Token: 0x06006A9A RID: 27290 RVA: 0x00101ED1 File Offset: 0x001000D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x00101EDE File Offset: 0x001000DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x00101EE8 File Offset: 0x001000E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.hateList_.WriteTo(ref output, EntityBattleInfoResponse._repeated_hateList_codec);
			this.playerTagInfos_.WriteTo(ref output, EntityBattleInfoResponse._repeated_playerTagInfos_codec);
			this.attributes_.WriteTo(ref output, EntityBattleInfoResponse._repeated_attributes_codec);
			if (this.EntityPassiveSkillInfo.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.EntityPassiveSkillInfo);
			}
			if (this.fightBuffComponentPb_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.FightBuffComponentPb);
			}
			if (this.partComponentPb_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PartComponentPb);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			this.entityBattleTagInfo_.WriteTo(ref output, EntityBattleInfoResponse._repeated_entityBattleTagInfo_codec);
			this.formationAttrs_.WriteTo(ref output, EntityBattleInfoResponse._repeated_formationAttrs_codec);
			if (this.shieldComponentPb_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.ShieldComponentPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x0010200C File Offset: 0x0010020C
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

		// Token: 0x06006A9E RID: 27294 RVA: 0x00102128 File Offset: 0x00100328
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

		// Token: 0x06006A9F RID: 27295 RVA: 0x0010226A File Offset: 0x0010046A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x00102274 File Offset: 0x00100474
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
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 26U)
						{
							this.hateList_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_hateList_codec);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.playerTagInfos_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_playerTagInfos_codec);
							continue;
						}
						if (num == 50U)
						{
							this.attributes_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_attributes_codec);
							continue;
						}
						if (num == 66U)
						{
							this.EntityPassiveSkillInfo = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 74U)
					{
						if (this.fightBuffComponentPb_ == null)
						{
							this.FightBuffComponentPb = new FightBuffComponentPb();
						}
						input.ReadMessage(this.FightBuffComponentPb);
						continue;
					}
					if (num == 82U)
					{
						if (this.partComponentPb_ == null)
						{
							this.PartComponentPb = new PartComponentPb();
						}
						input.ReadMessage(this.PartComponentPb);
						continue;
					}
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.entityBattleTagInfo_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_entityBattleTagInfo_codec);
						continue;
					}
					if (num == 114U)
					{
						this.formationAttrs_.AddEntriesFrom(ref input, EntityBattleInfoResponse._repeated_formationAttrs_codec);
						continue;
					}
					if (num == 122U)
					{
						if (this.shieldComponentPb_ == null)
						{
							this.ShieldComponentPb = new ShieldComponentPb();
						}
						input.ReadMessage(this.ShieldComponentPb);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AB3 RID: 15027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB4 RID: 15028
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003AB5 RID: 15029
		private long entityId_;

		// Token: 0x04003AB6 RID: 15030
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003AB7 RID: 15031
		private ErrorCode errorCode_;

		// Token: 0x04003AB8 RID: 15032
		public const int FightBuffComponentPbFieldNumber = 9;

		// Token: 0x04003AB9 RID: 15033
		private FightBuffComponentPb fightBuffComponentPb_;

		// Token: 0x04003ABA RID: 15034
		public const int EntityBattleTagInfoFieldNumber = 13;

		// Token: 0x04003ABB RID: 15035
		private static readonly FieldCodec<EntityBattleTagInfo> _repeated_entityBattleTagInfo_codec = FieldCodec.ForMessage<EntityBattleTagInfo>(106U, Aki.Protocol.EntityBattleTagInfo.Parser);

		// Token: 0x04003ABC RID: 15036
		private readonly RepeatedField<EntityBattleTagInfo> entityBattleTagInfo_ = new RepeatedField<EntityBattleTagInfo>();

		// Token: 0x04003ABD RID: 15037
		public const int AttributesFieldNumber = 6;

		// Token: 0x04003ABE RID: 15038
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(50U, GameplayAttributeData.Parser);

		// Token: 0x04003ABF RID: 15039
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x04003AC0 RID: 15040
		public const int FormationAttrsFieldNumber = 14;

		// Token: 0x04003AC1 RID: 15041
		private static readonly FieldCodec<FormationAttr> _repeated_formationAttrs_codec = FieldCodec.ForMessage<FormationAttr>(114U, FormationAttr.Parser);

		// Token: 0x04003AC2 RID: 15042
		private readonly RepeatedField<FormationAttr> formationAttrs_ = new RepeatedField<FormationAttr>();

		// Token: 0x04003AC3 RID: 15043
		public const int PartComponentPbFieldNumber = 10;

		// Token: 0x04003AC4 RID: 15044
		private PartComponentPb partComponentPb_;

		// Token: 0x04003AC5 RID: 15045
		public const int HateListFieldNumber = 3;

		// Token: 0x04003AC6 RID: 15046
		private static readonly FieldCodec<AiHateEntity> _repeated_hateList_codec = FieldCodec.ForMessage<AiHateEntity>(26U, AiHateEntity.Parser);

		// Token: 0x04003AC7 RID: 15047
		private readonly RepeatedField<AiHateEntity> hateList_ = new RepeatedField<AiHateEntity>();

		// Token: 0x04003AC8 RID: 15048
		public const int ShieldComponentPbFieldNumber = 15;

		// Token: 0x04003AC9 RID: 15049
		private ShieldComponentPb shieldComponentPb_;

		// Token: 0x04003ACA RID: 15050
		public const int PlayerTagInfosFieldNumber = 5;

		// Token: 0x04003ACB RID: 15051
		private static readonly FieldCodec<EntityBattleTagInfo> _repeated_playerTagInfos_codec = FieldCodec.ForMessage<EntityBattleTagInfo>(42U, Aki.Protocol.EntityBattleTagInfo.Parser);

		// Token: 0x04003ACC RID: 15052
		private readonly RepeatedField<EntityBattleTagInfo> playerTagInfos_ = new RepeatedField<EntityBattleTagInfo>();

		// Token: 0x04003ACD RID: 15053
		public const int EntityPassiveSkillInfoFieldNumber = 8;

		// Token: 0x04003ACE RID: 15054
		private string entityPassiveSkillInfo_ = "";
	}
}
