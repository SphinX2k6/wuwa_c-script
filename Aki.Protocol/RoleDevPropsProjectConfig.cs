using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001059 RID: 4185
	public sealed class RoleDevPropsProjectConfig : IMessage<RoleDevPropsProjectConfig>, IMessage, IEquatable<RoleDevPropsProjectConfig>, IDeepCloneable<RoleDevPropsProjectConfig>, IBufferMessage
	{
		// Token: 0x0601663B RID: 91707 RVA: 0x0034194C File Offset: 0x0033FB4C
		[NullableContext(1)]
		public static RoleDevPropsProjectConfig Create()
		{
			return new RoleDevPropsProjectConfig();
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x0601663C RID: 91708 RVA: 0x00341953 File Offset: 0x0033FB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleDevPropsProjectConfig> Parser
		{
			get
			{
				return RoleDevPropsProjectConfig._parser;
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x0601663D RID: 91709 RVA: 0x0034195A File Offset: 0x0033FB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0601663E RID: 91710 RVA: 0x0034195D File Offset: 0x0033FB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevPropsProjectConfig.Descriptor;
			}
		}

		// Token: 0x0601663F RID: 91711 RVA: 0x00341964 File Offset: 0x0033FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsProjectConfig()
		{
		}

		// Token: 0x06016640 RID: 91712 RVA: 0x003419D0 File Offset: 0x0033FBD0
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

		// Token: 0x06016641 RID: 91713 RVA: 0x00341ABC File Offset: 0x0033FCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevPropsProjectConfig Clone()
		{
			return new RoleDevPropsProjectConfig(this);
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x06016642 RID: 91714 RVA: 0x00341AC4 File Offset: 0x0033FCC4
		// (set) Token: 0x06016643 RID: 91715 RVA: 0x00341ACC File Offset: 0x0033FCCC
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

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x06016644 RID: 91716 RVA: 0x00341AD5 File Offset: 0x0033FCD5
		// (set) Token: 0x06016645 RID: 91717 RVA: 0x00341ADD File Offset: 0x0033FCDD
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

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x06016646 RID: 91718 RVA: 0x00341AE6 File Offset: 0x0033FCE6
		// (set) Token: 0x06016647 RID: 91719 RVA: 0x00341AEE File Offset: 0x0033FCEE
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

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x06016648 RID: 91720 RVA: 0x00341B01 File Offset: 0x0033FD01
		// (set) Token: 0x06016649 RID: 91721 RVA: 0x00341B09 File Offset: 0x0033FD09
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

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x0601664A RID: 91722 RVA: 0x00341B12 File Offset: 0x0033FD12
		// (set) Token: 0x0601664B RID: 91723 RVA: 0x00341B1A File Offset: 0x0033FD1A
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

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x0601664C RID: 91724 RVA: 0x00341B23 File Offset: 0x0033FD23
		// (set) Token: 0x0601664D RID: 91725 RVA: 0x00341B2B File Offset: 0x0033FD2B
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

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x0601664E RID: 91726 RVA: 0x00341B34 File Offset: 0x0033FD34
		// (set) Token: 0x0601664F RID: 91727 RVA: 0x00341B3C File Offset: 0x0033FD3C
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

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x06016650 RID: 91728 RVA: 0x00341B45 File Offset: 0x0033FD45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleItemGroup
		{
			get
			{
				return this.roleItemGroup_;
			}
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x06016651 RID: 91729 RVA: 0x00341B4D File Offset: 0x0033FD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WeaponBreachItemGroup
		{
			get
			{
				return this.weaponBreachItemGroup_;
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x06016652 RID: 91730 RVA: 0x00341B55 File Offset: 0x0033FD55
		// (set) Token: 0x06016653 RID: 91731 RVA: 0x00341B5D File Offset: 0x0033FD5D
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

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x06016654 RID: 91732 RVA: 0x00341B66 File Offset: 0x0033FD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillItemGroup
		{
			get
			{
				return this.skillItemGroup_;
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x06016655 RID: 91733 RVA: 0x00341B6E File Offset: 0x0033FD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PrefectSkillLevel
		{
			get
			{
				return this.prefectSkillLevel_;
			}
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x06016656 RID: 91734 RVA: 0x00341B76 File Offset: 0x0033FD76
		// (set) Token: 0x06016657 RID: 91735 RVA: 0x00341B7E File Offset: 0x0033FD7E
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

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x06016658 RID: 91736 RVA: 0x00341B91 File Offset: 0x0033FD91
		// (set) Token: 0x06016659 RID: 91737 RVA: 0x00341B99 File Offset: 0x0033FD99
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

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x0601665A RID: 91738 RVA: 0x00341BAC File Offset: 0x0033FDAC
		// (set) Token: 0x0601665B RID: 91739 RVA: 0x00341BB4 File Offset: 0x0033FDB4
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

		// Token: 0x0601665C RID: 91740 RVA: 0x00341BC7 File Offset: 0x0033FDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevPropsProjectConfig);
		}

		// Token: 0x0601665D RID: 91741 RVA: 0x00341BD8 File Offset: 0x0033FDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevPropsProjectConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ElementId == other.ElementId && !(this.RoleName != other.RoleName) && this.RoleExperience == other.RoleExperience && this.RoleGoalLevel == other.RoleGoalLevel && this.WeaponGoalLevel == other.WeaponGoalLevel && this.WeaponExperience == other.WeaponExperience && this.roleItemGroup_.Equals(other.roleItemGroup_) && this.weaponBreachItemGroup_.Equals(other.weaponBreachItemGroup_) && this.WeaponType == other.WeaponType && this.skillItemGroup_.Equals(other.skillItemGroup_) && this.prefectSkillLevel_.Equals(other.prefectSkillLevel_) && !(this.RoleHeadIcon != other.RoleHeadIcon) && !(this.RoleHeadIconSmall != other.RoleHeadIconSmall) && !(this.FormationRoleCard != other.FormationRoleCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601665E RID: 91742 RVA: 0x00341D1C File Offset: 0x0033FF1C
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

		// Token: 0x0601665F RID: 91743 RVA: 0x00341E95 File Offset: 0x00340095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016660 RID: 91744 RVA: 0x00341EA2 File Offset: 0x003400A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016661 RID: 91745 RVA: 0x00341EAC File Offset: 0x003400AC
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

		// Token: 0x06016662 RID: 91746 RVA: 0x00342058 File Offset: 0x00340258
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

		// Token: 0x06016663 RID: 91747 RVA: 0x003421E8 File Offset: 0x003403E8
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

		// Token: 0x06016664 RID: 91748 RVA: 0x00342344 File Offset: 0x00340544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016665 RID: 91749 RVA: 0x00342350 File Offset: 0x00340550
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

		// Token: 0x0400865D RID: 34397
		private static readonly MessageParser<RoleDevPropsProjectConfig> _parser = new MessageParser<RoleDevPropsProjectConfig>(() => new RoleDevPropsProjectConfig());

		// Token: 0x0400865E RID: 34398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400865F RID: 34399
		public const int IdFieldNumber = 1;

		// Token: 0x04008660 RID: 34400
		private int id_;

		// Token: 0x04008661 RID: 34401
		public const int ElementIdFieldNumber = 2;

		// Token: 0x04008662 RID: 34402
		private int elementId_;

		// Token: 0x04008663 RID: 34403
		public const int RoleNameFieldNumber = 3;

		// Token: 0x04008664 RID: 34404
		private string roleName_ = "";

		// Token: 0x04008665 RID: 34405
		public const int RoleExperienceFieldNumber = 4;

		// Token: 0x04008666 RID: 34406
		private int roleExperience_;

		// Token: 0x04008667 RID: 34407
		public const int RoleGoalLevelFieldNumber = 5;

		// Token: 0x04008668 RID: 34408
		private int roleGoalLevel_;

		// Token: 0x04008669 RID: 34409
		public const int WeaponGoalLevelFieldNumber = 6;

		// Token: 0x0400866A RID: 34410
		private int weaponGoalLevel_;

		// Token: 0x0400866B RID: 34411
		public const int WeaponExperienceFieldNumber = 7;

		// Token: 0x0400866C RID: 34412
		private int weaponExperience_;

		// Token: 0x0400866D RID: 34413
		public const int RoleItemGroupFieldNumber = 8;

		// Token: 0x0400866E RID: 34414
		private static readonly FieldCodec<int> _repeated_roleItemGroup_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400866F RID: 34415
		private readonly RepeatedField<int> roleItemGroup_ = new RepeatedField<int>();

		// Token: 0x04008670 RID: 34416
		public const int WeaponBreachItemGroupFieldNumber = 9;

		// Token: 0x04008671 RID: 34417
		private static readonly FieldCodec<int> _repeated_weaponBreachItemGroup_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008672 RID: 34418
		private readonly RepeatedField<int> weaponBreachItemGroup_ = new RepeatedField<int>();

		// Token: 0x04008673 RID: 34419
		public const int WeaponTypeFieldNumber = 10;

		// Token: 0x04008674 RID: 34420
		private int weaponType_;

		// Token: 0x04008675 RID: 34421
		public const int SkillItemGroupFieldNumber = 11;

		// Token: 0x04008676 RID: 34422
		private static readonly FieldCodec<int> _repeated_skillItemGroup_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04008677 RID: 34423
		private readonly RepeatedField<int> skillItemGroup_ = new RepeatedField<int>();

		// Token: 0x04008678 RID: 34424
		public const int PrefectSkillLevelFieldNumber = 12;

		// Token: 0x04008679 RID: 34425
		private static readonly FieldCodec<int> _repeated_prefectSkillLevel_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400867A RID: 34426
		private readonly RepeatedField<int> prefectSkillLevel_ = new RepeatedField<int>();

		// Token: 0x0400867B RID: 34427
		public const int RoleHeadIconFieldNumber = 13;

		// Token: 0x0400867C RID: 34428
		private string roleHeadIcon_ = "";

		// Token: 0x0400867D RID: 34429
		public const int RoleHeadIconSmallFieldNumber = 14;

		// Token: 0x0400867E RID: 34430
		private string roleHeadIconSmall_ = "";

		// Token: 0x0400867F RID: 34431
		public const int FormationRoleCardFieldNumber = 15;

		// Token: 0x04008680 RID: 34432
		private string formationRoleCard_ = "";
	}
}
