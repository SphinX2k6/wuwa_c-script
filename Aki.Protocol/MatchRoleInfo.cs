using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AE RID: 2478
	public sealed class MatchRoleInfo : IMessage<MatchRoleInfo>, IMessage, IEquatable<MatchRoleInfo>, IDeepCloneable<MatchRoleInfo>, IBufferMessage
	{
		// Token: 0x0600D9C8 RID: 55752 RVA: 0x002000BA File Offset: 0x001FE2BA
		[NullableContext(1)]
		public static MatchRoleInfo Create()
		{
			return new MatchRoleInfo();
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600D9C9 RID: 55753 RVA: 0x002000C1 File Offset: 0x001FE2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchRoleInfo> Parser
		{
			get
			{
				return MatchRoleInfo._parser;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x002000C8 File Offset: 0x001FE2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600D9CB RID: 55755 RVA: 0x002000CB File Offset: 0x001FE2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600D9CC RID: 55756 RVA: 0x002000D2 File Offset: 0x001FE2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleInfo()
		{
		}

		// Token: 0x0600D9CD RID: 55757 RVA: 0x002000E8 File Offset: 0x001FE2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleInfo(MatchRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this.towerDefencePhantomId_ = other.towerDefencePhantomId_;
			this.roleSkinId_ = other.roleSkinId_;
			this.skillBranchId_ = other.skillBranchId_;
			this.roleContext_ = ((other.roleContext_ != null) ? other.roleContext_.Clone() : null);
			this.weaponId_ = other.weaponId_;
			this.weaponBreachLevel_ = other.weaponBreachLevel_;
			this.weaponSkinId_ = other.weaponSkinId_;
			this.dressList_ = other.dressList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x00200199 File Offset: 0x001FE399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleInfo Clone()
		{
			return new MatchRoleInfo(this);
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600D9CF RID: 55759 RVA: 0x002001A1 File Offset: 0x001FE3A1
		// (set) Token: 0x0600D9D0 RID: 55760 RVA: 0x002001A9 File Offset: 0x001FE3A9
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

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0600D9D1 RID: 55761 RVA: 0x002001B2 File Offset: 0x001FE3B2
		// (set) Token: 0x0600D9D2 RID: 55762 RVA: 0x002001BA File Offset: 0x001FE3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600D9D3 RID: 55763 RVA: 0x002001C3 File Offset: 0x001FE3C3
		// (set) Token: 0x0600D9D4 RID: 55764 RVA: 0x002001CB File Offset: 0x001FE3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerDefencePhantomId
		{
			get
			{
				return this.towerDefencePhantomId_;
			}
			set
			{
				this.towerDefencePhantomId_ = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600D9D5 RID: 55765 RVA: 0x002001D4 File Offset: 0x001FE3D4
		// (set) Token: 0x0600D9D6 RID: 55766 RVA: 0x002001DC File Offset: 0x001FE3DC
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

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600D9D7 RID: 55767 RVA: 0x002001E5 File Offset: 0x001FE3E5
		// (set) Token: 0x0600D9D8 RID: 55768 RVA: 0x002001ED File Offset: 0x001FE3ED
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

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600D9D9 RID: 55769 RVA: 0x002001F6 File Offset: 0x001FE3F6
		// (set) Token: 0x0600D9DA RID: 55770 RVA: 0x002001FE File Offset: 0x001FE3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleContext RoleContext
		{
			get
			{
				return this.roleContext_;
			}
			set
			{
				this.roleContext_ = value;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600D9DB RID: 55771 RVA: 0x00200207 File Offset: 0x001FE407
		// (set) Token: 0x0600D9DC RID: 55772 RVA: 0x0020020F File Offset: 0x001FE40F
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

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600D9DD RID: 55773 RVA: 0x00200218 File Offset: 0x001FE418
		// (set) Token: 0x0600D9DE RID: 55774 RVA: 0x00200220 File Offset: 0x001FE420
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

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600D9DF RID: 55775 RVA: 0x00200229 File Offset: 0x001FE429
		// (set) Token: 0x0600D9E0 RID: 55776 RVA: 0x00200231 File Offset: 0x001FE431
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

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600D9E1 RID: 55777 RVA: 0x0020023A File Offset: 0x001FE43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressList
		{
			get
			{
				return this.dressList_;
			}
		}

		// Token: 0x0600D9E2 RID: 55778 RVA: 0x00200242 File Offset: 0x001FE442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchRoleInfo);
		}

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x00200250 File Offset: 0x001FE450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.TowerDefencePhantomId == other.TowerDefencePhantomId && this.RoleSkinId == other.RoleSkinId && this.SkillBranchId == other.SkillBranchId && object.Equals(this.RoleContext, other.RoleContext) && this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && this.WeaponSkinId == other.WeaponSkinId && this.dressList_.Equals(other.dressList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9E4 RID: 55780 RVA: 0x00200324 File Offset: 0x001FE524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.TowerDefencePhantomId != 0)
			{
				num ^= this.TowerDefencePhantomId.GetHashCode();
			}
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			if (this.roleContext_ != null)
			{
				num ^= this.RoleContext.GetHashCode();
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

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x00200436 File Offset: 0x001FE636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x00200443 File Offset: 0x001FE643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9E7 RID: 55783 RVA: 0x0020044C File Offset: 0x001FE64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.TowerDefencePhantomId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TowerDefencePhantomId);
			}
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this.roleContext_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RoleContext);
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
			this.dressList_.WriteTo(ref output, MatchRoleInfo._repeated_dressList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x0020057C File Offset: 0x001FE77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.TowerDefencePhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerDefencePhantomId);
			}
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			if (this.roleContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleContext);
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
			num += this.dressList_.CalculateSize(MatchRoleInfo._repeated_dressList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9E9 RID: 55785 RVA: 0x00200690 File Offset: 0x001FE890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.TowerDefencePhantomId != 0)
			{
				this.TowerDefencePhantomId = other.TowerDefencePhantomId;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			if (other.roleContext_ != null)
			{
				if (this.roleContext_ == null)
				{
					this.RoleContext = new MatchRoleContext();
				}
				this.RoleContext.MergeFrom(other.RoleContext);
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

		// Token: 0x0600D9EA RID: 55786 RVA: 0x00200795 File Offset: 0x001FE995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9EB RID: 55787 RVA: 0x002007A0 File Offset: 0x001FE9A0
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
							this.RoleLevel = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.TowerDefencePhantomId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.RoleSkinId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.SkillBranchId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 50U)
					{
						if (this.roleContext_ == null)
						{
							this.RoleContext = new MatchRoleContext();
						}
						input.ReadMessage(this.RoleContext);
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
						this.dressList_.AddEntriesFrom(ref input, MatchRoleInfo._repeated_dressList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005AE4 RID: 23268
		private static readonly MessageParser<MatchRoleInfo> _parser = new MessageParser<MatchRoleInfo>(() => new MatchRoleInfo());

		// Token: 0x04005AE5 RID: 23269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AE6 RID: 23270
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04005AE7 RID: 23271
		private int roleId_;

		// Token: 0x04005AE8 RID: 23272
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04005AE9 RID: 23273
		private int roleLevel_;

		// Token: 0x04005AEA RID: 23274
		public const int TowerDefencePhantomIdFieldNumber = 3;

		// Token: 0x04005AEB RID: 23275
		private int towerDefencePhantomId_;

		// Token: 0x04005AEC RID: 23276
		public const int RoleSkinIdFieldNumber = 4;

		// Token: 0x04005AED RID: 23277
		private int roleSkinId_;

		// Token: 0x04005AEE RID: 23278
		public const int SkillBranchIdFieldNumber = 5;

		// Token: 0x04005AEF RID: 23279
		private int skillBranchId_;

		// Token: 0x04005AF0 RID: 23280
		public const int RoleContextFieldNumber = 6;

		// Token: 0x04005AF1 RID: 23281
		private MatchRoleContext roleContext_;

		// Token: 0x04005AF2 RID: 23282
		public const int WeaponIdFieldNumber = 7;

		// Token: 0x04005AF3 RID: 23283
		private int weaponId_;

		// Token: 0x04005AF4 RID: 23284
		public const int WeaponBreachLevelFieldNumber = 8;

		// Token: 0x04005AF5 RID: 23285
		private int weaponBreachLevel_;

		// Token: 0x04005AF6 RID: 23286
		public const int WeaponSkinIdFieldNumber = 9;

		// Token: 0x04005AF7 RID: 23287
		private int weaponSkinId_;

		// Token: 0x04005AF8 RID: 23288
		public const int DressListFieldNumber = 10;

		// Token: 0x04005AF9 RID: 23289
		private static readonly FieldCodec<int> _repeated_dressList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005AFA RID: 23290
		private readonly RepeatedField<int> dressList_ = new RepeatedField<int>();
	}
}
