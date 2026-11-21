using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061D RID: 1565
	public sealed class FormationRoleInfo : IMessage<FormationRoleInfo>, IMessage, IEquatable<FormationRoleInfo>, IDeepCloneable<FormationRoleInfo>, IBufferMessage
	{
		// Token: 0x060090BD RID: 37053 RVA: 0x0015EB24 File Offset: 0x0015CD24
		[NullableContext(1)]
		public static FormationRoleInfo Create()
		{
			return new FormationRoleInfo();
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x0015EB2B File Offset: 0x0015CD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationRoleInfo> Parser
		{
			get
			{
				return FormationRoleInfo._parser;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x060090BF RID: 37055 RVA: 0x0015EB32 File Offset: 0x0015CD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x0015EB35 File Offset: 0x0015CD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationRoleInfo.Descriptor;
			}
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x0015EB3C File Offset: 0x0015CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRoleInfo()
		{
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x0015EB50 File Offset: 0x0015CD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRoleInfo(FormationRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.maxHp_ = other.maxHp_;
			this.curHp_ = other.curHp_;
			this.level_ = other.level_;
			this.roleSkinId_ = other.roleSkinId_;
			this.skillBranchId_ = other.skillBranchId_;
			this.weaponId_ = other.weaponId_;
			this.weaponBreachLevel_ = other.weaponBreachLevel_;
			this.weaponSkinId_ = other.weaponSkinId_;
			this.dressList_ = other.dressList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x0015EBF1 File Offset: 0x0015CDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRoleInfo Clone()
		{
			return new FormationRoleInfo(this);
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x060090C4 RID: 37060 RVA: 0x0015EBF9 File Offset: 0x0015CDF9
		// (set) Token: 0x060090C5 RID: 37061 RVA: 0x0015EC01 File Offset: 0x0015CE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0015EC0A File Offset: 0x0015CE0A
		// (set) Token: 0x060090C7 RID: 37063 RVA: 0x0015EC12 File Offset: 0x0015CE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxHp
		{
			get
			{
				return this.maxHp_;
			}
			set
			{
				this.maxHp_ = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060090C8 RID: 37064 RVA: 0x0015EC1B File Offset: 0x0015CE1B
		// (set) Token: 0x060090C9 RID: 37065 RVA: 0x0015EC23 File Offset: 0x0015CE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurHp
		{
			get
			{
				return this.curHp_;
			}
			set
			{
				this.curHp_ = value;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x0015EC2C File Offset: 0x0015CE2C
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x0015EC34 File Offset: 0x0015CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060090CC RID: 37068 RVA: 0x0015EC3D File Offset: 0x0015CE3D
		// (set) Token: 0x060090CD RID: 37069 RVA: 0x0015EC45 File Offset: 0x0015CE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060090CE RID: 37070 RVA: 0x0015EC4E File Offset: 0x0015CE4E
		// (set) Token: 0x060090CF RID: 37071 RVA: 0x0015EC56 File Offset: 0x0015CE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
			set
			{
				this.skillBranchId_ = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060090D0 RID: 37072 RVA: 0x0015EC5F File Offset: 0x0015CE5F
		// (set) Token: 0x060090D1 RID: 37073 RVA: 0x0015EC67 File Offset: 0x0015CE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x060090D2 RID: 37074 RVA: 0x0015EC70 File Offset: 0x0015CE70
		// (set) Token: 0x060090D3 RID: 37075 RVA: 0x0015EC78 File Offset: 0x0015CE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBreachLevel
		{
			get
			{
				return this.weaponBreachLevel_;
			}
			set
			{
				this.weaponBreachLevel_ = value;
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x0015EC81 File Offset: 0x0015CE81
		// (set) Token: 0x060090D5 RID: 37077 RVA: 0x0015EC89 File Offset: 0x0015CE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponSkinId
		{
			get
			{
				return this.weaponSkinId_;
			}
			set
			{
				this.weaponSkinId_ = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x0015EC92 File Offset: 0x0015CE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressList
		{
			get
			{
				return this.dressList_;
			}
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x0015EC9A File Offset: 0x0015CE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationRoleInfo);
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x0015ECA8 File Offset: 0x0015CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.MaxHp == other.MaxHp && this.CurHp == other.CurHp && this.Level == other.Level && this.RoleSkinId == other.RoleSkinId && this.SkillBranchId == other.SkillBranchId && this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && this.WeaponSkinId == other.WeaponSkinId && this.dressList_.Equals(other.dressList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x0015ED78 File Offset: 0x0015CF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.MaxHp != 0)
			{
				num ^= this.MaxHp.GetHashCode();
			}
			if (this.CurHp != 0)
			{
				num ^= this.CurHp.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.WeaponBreachLevel != 0)
			{
				num ^= this.WeaponBreachLevel.GetHashCode();
			}
			if (this.WeaponSkinId != 0)
			{
				num ^= this.WeaponSkinId.GetHashCode();
			}
			num ^= this.dressList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090DA RID: 37082 RVA: 0x0015EE8D File Offset: 0x0015D08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x0015EE9A File Offset: 0x0015D09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x0015EEA4 File Offset: 0x0015D0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.MaxHp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxHp);
			}
			if (this.CurHp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurHp);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.WeaponId);
			}
			if (this.WeaponBreachLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WeaponBreachLevel);
			}
			if (this.WeaponSkinId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WeaponSkinId);
			}
			this.dressList_.WriteTo(ref output, FormationRoleInfo._repeated_dressList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x0015EFD4 File Offset: 0x0015D1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.MaxHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxHp);
			}
			if (this.CurHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHp);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.WeaponBreachLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBreachLevel);
			}
			if (this.WeaponSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponSkinId);
			}
			num += this.dressList_.CalculateSize(FormationRoleInfo._repeated_dressList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x0015F0E8 File Offset: 0x0015D2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.MaxHp != 0)
			{
				this.MaxHp = other.MaxHp;
			}
			if (other.CurHp != 0)
			{
				this.CurHp = other.CurHp;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.WeaponBreachLevel != 0)
			{
				this.WeaponBreachLevel = other.WeaponBreachLevel;
			}
			if (other.WeaponSkinId != 0)
			{
				this.WeaponSkinId = other.WeaponSkinId;
			}
			this.dressList_.Add(other.dressList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x0015F1D5 File Offset: 0x0015D3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x0015F1E0 File Offset: 0x0015D3E0
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.RoleId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.MaxHp = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CurHp = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.RoleSkinId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 48U)
					{
						this.SkillBranchId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.WeaponId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.WeaponBreachLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.WeaponSkinId = input.ReadInt32();
						continue;
					}
					if (num == 80U || num == 82U)
					{
						this.dressList_.AddEntriesFrom(ref input, FormationRoleInfo._repeated_dressList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400466C RID: 18028
		private static readonly MessageParser<FormationRoleInfo> _parser = new MessageParser<FormationRoleInfo>(() => new FormationRoleInfo());

		// Token: 0x0400466D RID: 18029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400466E RID: 18030
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400466F RID: 18031
		private int roleId_;

		// Token: 0x04004670 RID: 18032
		public const int MaxHpFieldNumber = 2;

		// Token: 0x04004671 RID: 18033
		private int maxHp_;

		// Token: 0x04004672 RID: 18034
		public const int CurHpFieldNumber = 3;

		// Token: 0x04004673 RID: 18035
		private int curHp_;

		// Token: 0x04004674 RID: 18036
		public const int LevelFieldNumber = 4;

		// Token: 0x04004675 RID: 18037
		private int level_;

		// Token: 0x04004676 RID: 18038
		public const int RoleSkinIdFieldNumber = 5;

		// Token: 0x04004677 RID: 18039
		private int roleSkinId_;

		// Token: 0x04004678 RID: 18040
		public const int SkillBranchIdFieldNumber = 6;

		// Token: 0x04004679 RID: 18041
		private int skillBranchId_;

		// Token: 0x0400467A RID: 18042
		public const int WeaponIdFieldNumber = 7;

		// Token: 0x0400467B RID: 18043
		private int weaponId_;

		// Token: 0x0400467C RID: 18044
		public const int WeaponBreachLevelFieldNumber = 8;

		// Token: 0x0400467D RID: 18045
		private int weaponBreachLevel_;

		// Token: 0x0400467E RID: 18046
		public const int WeaponSkinIdFieldNumber = 9;

		// Token: 0x0400467F RID: 18047
		private int weaponSkinId_;

		// Token: 0x04004680 RID: 18048
		public const int DressListFieldNumber = 10;

		// Token: 0x04004681 RID: 18049
		private static readonly FieldCodec<int> _repeated_dressList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004682 RID: 18050
		private readonly RepeatedField<int> dressList_ = new RepeatedField<int>();
	}
}
