using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001069 RID: 4201
	public sealed class RoleDevPropsProjectConfig : IMessage<RoleDevPropsProjectConfig>, IMessage, IEquatable<RoleDevPropsProjectConfig>, IDeepCloneable<RoleDevPropsProjectConfig>, IBufferMessage
	{
		// Token: 0x06016720 RID: 91936 RVA: 0x00343020 File Offset: 0x00341220
		[NullableContext(1)]
		public static RoleDevPropsProjectConfig Create()
		{
			return new RoleDevPropsProjectConfig();
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x06016721 RID: 91937 RVA: 0x00343027 File Offset: 0x00341227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleDevPropsProjectConfig> Parser
		{
			get
			{
				return RoleDevPropsProjectConfig._parser;
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x06016722 RID: 91938 RVA: 0x0034302E File Offset: 0x0034122E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x06016723 RID: 91939 RVA: 0x00343031 File Offset: 0x00341231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevPropsProjectConfig.Descriptor;
			}
		}

		// Token: 0x06016724 RID: 91940 RVA: 0x00343038 File Offset: 0x00341238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsProjectConfig()
		{
		}

		// Token: 0x06016725 RID: 91941 RVA: 0x003430A4 File Offset: 0x003412A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsProjectConfig(RoleDevPropsProjectConfig other) : this()
		{
			this.id_ = other.id_;
			this.elementId_ = other.elementId_;
			this.roleName_ = other.roleName_;
			this.roleExperience_ = other.roleExperience_;
			this.roleGoalLevel_ = other.roleGoalLevel_;
			this.weaponGoalLevel_ = other.weaponGoalLevel_;
			this.weaponExperience_ = other.weaponExperience_;
			this.roleItemGroup_ = other.roleItemGroup_.Clone();
			this.weaponBreachItemGroup_ = other.weaponBreachItemGroup_.Clone();
			this.weaponType_ = other.weaponType_;
			this.skillItemGroup_ = other.skillItemGroup_.Clone();
			this.prefectSkillLevel_ = other.prefectSkillLevel_.Clone();
			this.roleHeadIcon_ = other.roleHeadIcon_;
			this.roleHeadIconSmall_ = other.roleHeadIconSmall_;
			this.formationRoleCard_ = other.formationRoleCard_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016726 RID: 91942 RVA: 0x00343190 File Offset: 0x00341390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsProjectConfig Clone()
		{
			return new RoleDevPropsProjectConfig(this);
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x06016727 RID: 91943 RVA: 0x00343198 File Offset: 0x00341398
		// (set) Token: 0x06016728 RID: 91944 RVA: 0x003431A0 File Offset: 0x003413A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x06016729 RID: 91945 RVA: 0x003431A9 File Offset: 0x003413A9
		// (set) Token: 0x0601672A RID: 91946 RVA: 0x003431B1 File Offset: 0x003413B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementId
		{
			get
			{
				return this.elementId_;
			}
			set
			{
				this.elementId_ = value;
			}
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x0601672B RID: 91947 RVA: 0x003431BA File Offset: 0x003413BA
		// (set) Token: 0x0601672C RID: 91948 RVA: 0x003431C2 File Offset: 0x003413C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RoleName
		{
			get
			{
				return this.roleName_;
			}
			set
			{
				this.roleName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x0601672D RID: 91949 RVA: 0x003431D5 File Offset: 0x003413D5
		// (set) Token: 0x0601672E RID: 91950 RVA: 0x003431DD File Offset: 0x003413DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleExperience
		{
			get
			{
				return this.roleExperience_;
			}
			set
			{
				this.roleExperience_ = value;
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x0601672F RID: 91951 RVA: 0x003431E6 File Offset: 0x003413E6
		// (set) Token: 0x06016730 RID: 91952 RVA: 0x003431EE File Offset: 0x003413EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleGoalLevel
		{
			get
			{
				return this.roleGoalLevel_;
			}
			set
			{
				this.roleGoalLevel_ = value;
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x06016731 RID: 91953 RVA: 0x003431F7 File Offset: 0x003413F7
		// (set) Token: 0x06016732 RID: 91954 RVA: 0x003431FF File Offset: 0x003413FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponGoalLevel
		{
			get
			{
				return this.weaponGoalLevel_;
			}
			set
			{
				this.weaponGoalLevel_ = value;
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x06016733 RID: 91955 RVA: 0x00343208 File Offset: 0x00341408
		// (set) Token: 0x06016734 RID: 91956 RVA: 0x00343210 File Offset: 0x00341410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponExperience
		{
			get
			{
				return this.weaponExperience_;
			}
			set
			{
				this.weaponExperience_ = value;
			}
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x06016735 RID: 91957 RVA: 0x00343219 File Offset: 0x00341419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleItemGroup
		{
			get
			{
				return this.roleItemGroup_;
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x06016736 RID: 91958 RVA: 0x00343221 File Offset: 0x00341421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponBreachItemGroup
		{
			get
			{
				return this.weaponBreachItemGroup_;
			}
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x06016737 RID: 91959 RVA: 0x00343229 File Offset: 0x00341429
		// (set) Token: 0x06016738 RID: 91960 RVA: 0x00343231 File Offset: 0x00341431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponType
		{
			get
			{
				return this.weaponType_;
			}
			set
			{
				this.weaponType_ = value;
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x06016739 RID: 91961 RVA: 0x0034323A File Offset: 0x0034143A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillItemGroup
		{
			get
			{
				return this.skillItemGroup_;
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x0601673A RID: 91962 RVA: 0x00343242 File Offset: 0x00341442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PrefectSkillLevel
		{
			get
			{
				return this.prefectSkillLevel_;
			}
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x0601673B RID: 91963 RVA: 0x0034324A File Offset: 0x0034144A
		// (set) Token: 0x0601673C RID: 91964 RVA: 0x00343252 File Offset: 0x00341452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RoleHeadIcon
		{
			get
			{
				return this.roleHeadIcon_;
			}
			set
			{
				this.roleHeadIcon_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x0601673D RID: 91965 RVA: 0x00343265 File Offset: 0x00341465
		// (set) Token: 0x0601673E RID: 91966 RVA: 0x0034326D File Offset: 0x0034146D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RoleHeadIconSmall
		{
			get
			{
				return this.roleHeadIconSmall_;
			}
			set
			{
				this.roleHeadIconSmall_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x0601673F RID: 91967 RVA: 0x00343280 File Offset: 0x00341480
		// (set) Token: 0x06016740 RID: 91968 RVA: 0x00343288 File Offset: 0x00341488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FormationRoleCard
		{
			get
			{
				return this.formationRoleCard_;
			}
			set
			{
				this.formationRoleCard_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06016741 RID: 91969 RVA: 0x0034329B File Offset: 0x0034149B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevPropsProjectConfig);
		}

		// Token: 0x06016742 RID: 91970 RVA: 0x003432AC File Offset: 0x003414AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevPropsProjectConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ElementId == other.ElementId && !(this.RoleName != other.RoleName) && this.RoleExperience == other.RoleExperience && this.RoleGoalLevel == other.RoleGoalLevel && this.WeaponGoalLevel == other.WeaponGoalLevel && this.WeaponExperience == other.WeaponExperience && this.roleItemGroup_.Equals(other.roleItemGroup_) && this.weaponBreachItemGroup_.Equals(other.weaponBreachItemGroup_) && this.WeaponType == other.WeaponType && this.skillItemGroup_.Equals(other.skillItemGroup_) && this.prefectSkillLevel_.Equals(other.prefectSkillLevel_) && !(this.RoleHeadIcon != other.RoleHeadIcon) && !(this.RoleHeadIconSmall != other.RoleHeadIconSmall) && !(this.FormationRoleCard != other.FormationRoleCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016743 RID: 91971 RVA: 0x003433F0 File Offset: 0x003415F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ElementId != 0)
			{
				num ^= this.ElementId.GetHashCode();
			}
			if (this.RoleName.Length != 0)
			{
				num ^= this.RoleName.GetHashCode();
			}
			if (this.RoleExperience != 0)
			{
				num ^= this.RoleExperience.GetHashCode();
			}
			if (this.RoleGoalLevel != 0)
			{
				num ^= this.RoleGoalLevel.GetHashCode();
			}
			if (this.WeaponGoalLevel != 0)
			{
				num ^= this.WeaponGoalLevel.GetHashCode();
			}
			if (this.WeaponExperience != 0)
			{
				num ^= this.WeaponExperience.GetHashCode();
			}
			num ^= this.roleItemGroup_.GetHashCode();
			num ^= this.weaponBreachItemGroup_.GetHashCode();
			if (this.WeaponType != 0)
			{
				num ^= this.WeaponType.GetHashCode();
			}
			num ^= this.skillItemGroup_.GetHashCode();
			num ^= this.prefectSkillLevel_.GetHashCode();
			if (this.RoleHeadIcon.Length != 0)
			{
				num ^= this.RoleHeadIcon.GetHashCode();
			}
			if (this.RoleHeadIconSmall.Length != 0)
			{
				num ^= this.RoleHeadIconSmall.GetHashCode();
			}
			if (this.FormationRoleCard.Length != 0)
			{
				num ^= this.FormationRoleCard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016744 RID: 91972 RVA: 0x00343569 File Offset: 0x00341769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016745 RID: 91973 RVA: 0x00343576 File Offset: 0x00341776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016746 RID: 91974 RVA: 0x00343580 File Offset: 0x00341780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.ElementId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ElementId);
			}
			if (this.RoleName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.RoleName);
			}
			if (this.RoleExperience != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleExperience);
			}
			if (this.RoleGoalLevel != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleGoalLevel);
			}
			if (this.WeaponGoalLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponGoalLevel);
			}
			if (this.WeaponExperience != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WeaponExperience);
			}
			this.roleItemGroup_.WriteTo(ref output, RoleDevPropsProjectConfig._repeated_roleItemGroup_codec);
			this.weaponBreachItemGroup_.WriteTo(ref output, RoleDevPropsProjectConfig._repeated_weaponBreachItemGroup_codec);
			if (this.WeaponType != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.WeaponType);
			}
			this.skillItemGroup_.WriteTo(ref output, RoleDevPropsProjectConfig._repeated_skillItemGroup_codec);
			this.prefectSkillLevel_.WriteTo(ref output, RoleDevPropsProjectConfig._repeated_prefectSkillLevel_codec);
			if (this.RoleHeadIcon.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.RoleHeadIcon);
			}
			if (this.RoleHeadIconSmall.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.RoleHeadIconSmall);
			}
			if (this.FormationRoleCard.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.FormationRoleCard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016747 RID: 91975 RVA: 0x0034372C File Offset: 0x0034192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ElementId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementId);
			}
			if (this.RoleName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RoleName);
			}
			if (this.RoleExperience != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleExperience);
			}
			if (this.RoleGoalLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleGoalLevel);
			}
			if (this.WeaponGoalLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponGoalLevel);
			}
			if (this.WeaponExperience != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponExperience);
			}
			num += this.roleItemGroup_.CalculateSize(RoleDevPropsProjectConfig._repeated_roleItemGroup_codec);
			num += this.weaponBreachItemGroup_.CalculateSize(RoleDevPropsProjectConfig._repeated_weaponBreachItemGroup_codec);
			if (this.WeaponType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponType);
			}
			num += this.skillItemGroup_.CalculateSize(RoleDevPropsProjectConfig._repeated_skillItemGroup_codec);
			num += this.prefectSkillLevel_.CalculateSize(RoleDevPropsProjectConfig._repeated_prefectSkillLevel_codec);
			if (this.RoleHeadIcon.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RoleHeadIcon);
			}
			if (this.RoleHeadIconSmall.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RoleHeadIconSmall);
			}
			if (this.FormationRoleCard.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FormationRoleCard);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016748 RID: 91976 RVA: 0x003438BC File Offset: 0x00341ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevPropsProjectConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ElementId != 0)
			{
				this.ElementId = other.ElementId;
			}
			if (other.RoleName.Length != 0)
			{
				this.RoleName = other.RoleName;
			}
			if (other.RoleExperience != 0)
			{
				this.RoleExperience = other.RoleExperience;
			}
			if (other.RoleGoalLevel != 0)
			{
				this.RoleGoalLevel = other.RoleGoalLevel;
			}
			if (other.WeaponGoalLevel != 0)
			{
				this.WeaponGoalLevel = other.WeaponGoalLevel;
			}
			if (other.WeaponExperience != 0)
			{
				this.WeaponExperience = other.WeaponExperience;
			}
			this.roleItemGroup_.Add(other.roleItemGroup_);
			this.weaponBreachItemGroup_.Add(other.weaponBreachItemGroup_);
			if (other.WeaponType != 0)
			{
				this.WeaponType = other.WeaponType;
			}
			this.skillItemGroup_.Add(other.skillItemGroup_);
			this.prefectSkillLevel_.Add(other.prefectSkillLevel_);
			if (other.RoleHeadIcon.Length != 0)
			{
				this.RoleHeadIcon = other.RoleHeadIcon;
			}
			if (other.RoleHeadIconSmall.Length != 0)
			{
				this.RoleHeadIconSmall = other.RoleHeadIconSmall;
			}
			if (other.FormationRoleCard.Length != 0)
			{
				this.FormationRoleCard = other.FormationRoleCard;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016749 RID: 91977 RVA: 0x00343A18 File Offset: 0x00341C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601674A RID: 91978 RVA: 0x00343A24 File Offset: 0x00341C24
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
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.ElementId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 26U)
							{
								this.RoleName = input.ReadString();
								continue;
							}
							if (num == 32U)
							{
								this.RoleExperience = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.RoleGoalLevel = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.WeaponGoalLevel = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.WeaponExperience = input.ReadInt32();
							continue;
						}
						if (num == 64U || num == 66U)
						{
							this.roleItemGroup_.AddEntriesFrom(ref input, RoleDevPropsProjectConfig._repeated_roleItemGroup_codec);
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num <= 74U)
					{
						if (num == 72U || num == 74U)
						{
							this.weaponBreachItemGroup_.AddEntriesFrom(ref input, RoleDevPropsProjectConfig._repeated_weaponBreachItemGroup_codec);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.WeaponType = input.ReadInt32();
							continue;
						}
						if (num == 88U || num == 90U)
						{
							this.skillItemGroup_.AddEntriesFrom(ref input, RoleDevPropsProjectConfig._repeated_skillItemGroup_codec);
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num == 96U || num == 98U)
					{
						this.prefectSkillLevel_.AddEntriesFrom(ref input, RoleDevPropsProjectConfig._repeated_prefectSkillLevel_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.RoleHeadIcon = input.ReadString();
						continue;
					}
					if (num == 114U)
					{
						this.RoleHeadIconSmall = input.ReadString();
						continue;
					}
					if (num == 122U)
					{
						this.FormationRoleCard = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008633 RID: 34355
		private static readonly MessageParser<RoleDevPropsProjectConfig> _parser = new MessageParser<RoleDevPropsProjectConfig>(() => new RoleDevPropsProjectConfig());

		// Token: 0x04008634 RID: 34356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008635 RID: 34357
		public const int IdFieldNumber = 1;

		// Token: 0x04008636 RID: 34358
		private int id_;

		// Token: 0x04008637 RID: 34359
		public const int ElementIdFieldNumber = 2;

		// Token: 0x04008638 RID: 34360
		private int elementId_;

		// Token: 0x04008639 RID: 34361
		public const int RoleNameFieldNumber = 3;

		// Token: 0x0400863A RID: 34362
		private string roleName_ = "";

		// Token: 0x0400863B RID: 34363
		public const int RoleExperienceFieldNumber = 4;

		// Token: 0x0400863C RID: 34364
		private int roleExperience_;

		// Token: 0x0400863D RID: 34365
		public const int RoleGoalLevelFieldNumber = 5;

		// Token: 0x0400863E RID: 34366
		private int roleGoalLevel_;

		// Token: 0x0400863F RID: 34367
		public const int WeaponGoalLevelFieldNumber = 6;

		// Token: 0x04008640 RID: 34368
		private int weaponGoalLevel_;

		// Token: 0x04008641 RID: 34369
		public const int WeaponExperienceFieldNumber = 7;

		// Token: 0x04008642 RID: 34370
		private int weaponExperience_;

		// Token: 0x04008643 RID: 34371
		public const int RoleItemGroupFieldNumber = 8;

		// Token: 0x04008644 RID: 34372
		private static readonly FieldCodec<int> _repeated_roleItemGroup_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04008645 RID: 34373
		private readonly RepeatedField<int> roleItemGroup_ = new RepeatedField<int>();

		// Token: 0x04008646 RID: 34374
		public const int WeaponBreachItemGroupFieldNumber = 9;

		// Token: 0x04008647 RID: 34375
		private static readonly FieldCodec<int> _repeated_weaponBreachItemGroup_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008648 RID: 34376
		private readonly RepeatedField<int> weaponBreachItemGroup_ = new RepeatedField<int>();

		// Token: 0x04008649 RID: 34377
		public const int WeaponTypeFieldNumber = 10;

		// Token: 0x0400864A RID: 34378
		private int weaponType_;

		// Token: 0x0400864B RID: 34379
		public const int SkillItemGroupFieldNumber = 11;

		// Token: 0x0400864C RID: 34380
		private static readonly FieldCodec<int> _repeated_skillItemGroup_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400864D RID: 34381
		private readonly RepeatedField<int> skillItemGroup_ = new RepeatedField<int>();

		// Token: 0x0400864E RID: 34382
		public const int PrefectSkillLevelFieldNumber = 12;

		// Token: 0x0400864F RID: 34383
		private static readonly FieldCodec<int> _repeated_prefectSkillLevel_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04008650 RID: 34384
		private readonly RepeatedField<int> prefectSkillLevel_ = new RepeatedField<int>();

		// Token: 0x04008651 RID: 34385
		public const int RoleHeadIconFieldNumber = 13;

		// Token: 0x04008652 RID: 34386
		private string roleHeadIcon_ = "";

		// Token: 0x04008653 RID: 34387
		public const int RoleHeadIconSmallFieldNumber = 14;

		// Token: 0x04008654 RID: 34388
		private string roleHeadIconSmall_ = "";

		// Token: 0x04008655 RID: 34389
		public const int FormationRoleCardFieldNumber = 15;

		// Token: 0x04008656 RID: 34390
		private string formationRoleCard_ = "";
	}
}
