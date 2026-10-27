using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000631 RID: 1585
	public sealed class FormationRoleInfo : IMessage<FormationRoleInfo>, IMessage, IEquatable<FormationRoleInfo>, IDeepCloneable<FormationRoleInfo>, IBufferMessage
	{
		// Token: 0x06009213 RID: 37395 RVA: 0x00161554 File Offset: 0x0015F754
		[NullableContext(1)]
		public static FormationRoleInfo Create()
		{
			return new FormationRoleInfo();
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06009214 RID: 37396 RVA: 0x0016155B File Offset: 0x0015F75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationRoleInfo> Parser
		{
			get
			{
				return FormationRoleInfo._parser;
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x06009215 RID: 37397 RVA: 0x00161562 File Offset: 0x0015F762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06009216 RID: 37398 RVA: 0x00161565 File Offset: 0x0015F765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationRoleInfo.Descriptor;
			}
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x0016156C File Offset: 0x0015F76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRoleInfo()
		{
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x00161580 File Offset: 0x0015F780
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

		// Token: 0x06009219 RID: 37401 RVA: 0x00161621 File Offset: 0x0015F821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationRoleInfo Clone()
		{
			return new FormationRoleInfo(this);
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x0600921A RID: 37402 RVA: 0x00161629 File Offset: 0x0015F829
		// (set) Token: 0x0600921B RID: 37403 RVA: 0x00161631 File Offset: 0x0015F831
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

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x0600921C RID: 37404 RVA: 0x0016163A File Offset: 0x0015F83A
		// (set) Token: 0x0600921D RID: 37405 RVA: 0x00161642 File Offset: 0x0015F842
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

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x0600921E RID: 37406 RVA: 0x0016164B File Offset: 0x0015F84B
		// (set) Token: 0x0600921F RID: 37407 RVA: 0x00161653 File Offset: 0x0015F853
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

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x06009220 RID: 37408 RVA: 0x0016165C File Offset: 0x0015F85C
		// (set) Token: 0x06009221 RID: 37409 RVA: 0x00161664 File Offset: 0x0015F864
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

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x0016166D File Offset: 0x0015F86D
		// (set) Token: 0x06009223 RID: 37411 RVA: 0x00161675 File Offset: 0x0015F875
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

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x0016167E File Offset: 0x0015F87E
		// (set) Token: 0x06009225 RID: 37413 RVA: 0x00161686 File Offset: 0x0015F886
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

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06009226 RID: 37414 RVA: 0x0016168F File Offset: 0x0015F88F
		// (set) Token: 0x06009227 RID: 37415 RVA: 0x00161697 File Offset: 0x0015F897
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

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x001616A0 File Offset: 0x0015F8A0
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x001616A8 File Offset: 0x0015F8A8
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

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x001616B1 File Offset: 0x0015F8B1
		// (set) Token: 0x0600922B RID: 37419 RVA: 0x001616B9 File Offset: 0x0015F8B9
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

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x0600922C RID: 37420 RVA: 0x001616C2 File Offset: 0x0015F8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressList
		{
			get
			{
				return this.dressList_;
			}
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x001616CA File Offset: 0x0015F8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationRoleInfo);
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x001616D8 File Offset: 0x0015F8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.MaxHp == other.MaxHp && this.CurHp == other.CurHp && this.Level == other.Level && this.RoleSkinId == other.RoleSkinId && this.SkillBranchId == other.SkillBranchId && this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && this.WeaponSkinId == other.WeaponSkinId && this.dressList_.Equals(other.dressList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x001617A8 File Offset: 0x0015F9A8
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

		// Token: 0x06009230 RID: 37424 RVA: 0x001618BD File Offset: 0x0015FABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x001618CA File Offset: 0x0015FACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x001618D4 File Offset: 0x0015FAD4
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

		// Token: 0x06009233 RID: 37427 RVA: 0x00161A04 File Offset: 0x0015FC04
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

		// Token: 0x06009234 RID: 37428 RVA: 0x00161B18 File Offset: 0x0015FD18
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

		// Token: 0x06009235 RID: 37429 RVA: 0x00161C05 File Offset: 0x0015FE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x00161C10 File Offset: 0x0015FE10
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

		// Token: 0x04004673 RID: 18035
		private static readonly MessageParser<FormationRoleInfo> _parser = new MessageParser<FormationRoleInfo>(() => new FormationRoleInfo());

		// Token: 0x04004674 RID: 18036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004675 RID: 18037
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04004676 RID: 18038
		private int roleId_;

		// Token: 0x04004677 RID: 18039
		public const int MaxHpFieldNumber = 2;

		// Token: 0x04004678 RID: 18040
		private int maxHp_;

		// Token: 0x04004679 RID: 18041
		public const int CurHpFieldNumber = 3;

		// Token: 0x0400467A RID: 18042
		private int curHp_;

		// Token: 0x0400467B RID: 18043
		public const int LevelFieldNumber = 4;

		// Token: 0x0400467C RID: 18044
		private int level_;

		// Token: 0x0400467D RID: 18045
		public const int RoleSkinIdFieldNumber = 5;

		// Token: 0x0400467E RID: 18046
		private int roleSkinId_;

		// Token: 0x0400467F RID: 18047
		public const int SkillBranchIdFieldNumber = 6;

		// Token: 0x04004680 RID: 18048
		private int skillBranchId_;

		// Token: 0x04004681 RID: 18049
		public const int WeaponIdFieldNumber = 7;

		// Token: 0x04004682 RID: 18050
		private int weaponId_;

		// Token: 0x04004683 RID: 18051
		public const int WeaponBreachLevelFieldNumber = 8;

		// Token: 0x04004684 RID: 18052
		private int weaponBreachLevel_;

		// Token: 0x04004685 RID: 18053
		public const int WeaponSkinIdFieldNumber = 9;

		// Token: 0x04004686 RID: 18054
		private int weaponSkinId_;

		// Token: 0x04004687 RID: 18055
		public const int DressListFieldNumber = 10;

		// Token: 0x04004688 RID: 18056
		private static readonly FieldCodec<int> _repeated_dressList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04004689 RID: 18057
		private readonly RepeatedField<int> dressList_ = new RepeatedField<int>();
	}
}
