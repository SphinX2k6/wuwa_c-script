using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BF RID: 2495
	public sealed class MatchRoleInfo : IMessage<MatchRoleInfo>, IMessage, IEquatable<MatchRoleInfo>, IDeepCloneable<MatchRoleInfo>, IBufferMessage
	{
		// Token: 0x0600DAE2 RID: 56034 RVA: 0x002022AE File Offset: 0x002004AE
		[NullableContext(1)]
		public static MatchRoleInfo Create()
		{
			return new MatchRoleInfo();
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0600DAE3 RID: 56035 RVA: 0x002022B5 File Offset: 0x002004B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchRoleInfo> Parser
		{
			get
			{
				return MatchRoleInfo._parser;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x002022BC File Offset: 0x002004BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0600DAE5 RID: 56037 RVA: 0x002022BF File Offset: 0x002004BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x002022C6 File Offset: 0x002004C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleInfo()
		{
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x002022DC File Offset: 0x002004DC
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

		// Token: 0x0600DAE8 RID: 56040 RVA: 0x0020238D File Offset: 0x0020058D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchRoleInfo Clone()
		{
			return new MatchRoleInfo(this);
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0600DAE9 RID: 56041 RVA: 0x00202395 File Offset: 0x00200595
		// (set) Token: 0x0600DAEA RID: 56042 RVA: 0x0020239D File Offset: 0x0020059D
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

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600DAEB RID: 56043 RVA: 0x002023A6 File Offset: 0x002005A6
		// (set) Token: 0x0600DAEC RID: 56044 RVA: 0x002023AE File Offset: 0x002005AE
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

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600DAED RID: 56045 RVA: 0x002023B7 File Offset: 0x002005B7
		// (set) Token: 0x0600DAEE RID: 56046 RVA: 0x002023BF File Offset: 0x002005BF
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

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600DAEF RID: 56047 RVA: 0x002023C8 File Offset: 0x002005C8
		// (set) Token: 0x0600DAF0 RID: 56048 RVA: 0x002023D0 File Offset: 0x002005D0
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

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x002023D9 File Offset: 0x002005D9
		// (set) Token: 0x0600DAF2 RID: 56050 RVA: 0x002023E1 File Offset: 0x002005E1
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

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x002023EA File Offset: 0x002005EA
		// (set) Token: 0x0600DAF4 RID: 56052 RVA: 0x002023F2 File Offset: 0x002005F2
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

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0600DAF5 RID: 56053 RVA: 0x002023FB File Offset: 0x002005FB
		// (set) Token: 0x0600DAF6 RID: 56054 RVA: 0x00202403 File Offset: 0x00200603
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

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0600DAF7 RID: 56055 RVA: 0x0020240C File Offset: 0x0020060C
		// (set) Token: 0x0600DAF8 RID: 56056 RVA: 0x00202414 File Offset: 0x00200614
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

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0600DAF9 RID: 56057 RVA: 0x0020241D File Offset: 0x0020061D
		// (set) Token: 0x0600DAFA RID: 56058 RVA: 0x00202425 File Offset: 0x00200625
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

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600DAFB RID: 56059 RVA: 0x0020242E File Offset: 0x0020062E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DressList
		{
			get
			{
				return this.dressList_;
			}
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x00202436 File Offset: 0x00200636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchRoleInfo);
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00202444 File Offset: 0x00200644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.TowerDefencePhantomId == other.TowerDefencePhantomId && this.RoleSkinId == other.RoleSkinId && this.SkillBranchId == other.SkillBranchId && object.Equals(this.RoleContext, other.RoleContext) && this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && this.WeaponSkinId == other.WeaponSkinId && this.dressList_.Equals(other.dressList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAFE RID: 56062 RVA: 0x00202518 File Offset: 0x00200718
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

		// Token: 0x0600DAFF RID: 56063 RVA: 0x0020262A File Offset: 0x0020082A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x00202637 File Offset: 0x00200837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB01 RID: 56065 RVA: 0x00202640 File Offset: 0x00200840
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

		// Token: 0x0600DB02 RID: 56066 RVA: 0x00202770 File Offset: 0x00200970
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

		// Token: 0x0600DB03 RID: 56067 RVA: 0x00202884 File Offset: 0x00200A84
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

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00202989 File Offset: 0x00200B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00202994 File Offset: 0x00200B94
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

		// Token: 0x04005ADB RID: 23259
		private static readonly MessageParser<MatchRoleInfo> _parser = new MessageParser<MatchRoleInfo>(() => new MatchRoleInfo());

		// Token: 0x04005ADC RID: 23260
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ADD RID: 23261
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04005ADE RID: 23262
		private int roleId_;

		// Token: 0x04005ADF RID: 23263
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04005AE0 RID: 23264
		private int roleLevel_;

		// Token: 0x04005AE1 RID: 23265
		public const int TowerDefencePhantomIdFieldNumber = 3;

		// Token: 0x04005AE2 RID: 23266
		private int towerDefencePhantomId_;

		// Token: 0x04005AE3 RID: 23267
		public const int RoleSkinIdFieldNumber = 4;

		// Token: 0x04005AE4 RID: 23268
		private int roleSkinId_;

		// Token: 0x04005AE5 RID: 23269
		public const int SkillBranchIdFieldNumber = 5;

		// Token: 0x04005AE6 RID: 23270
		private int skillBranchId_;

		// Token: 0x04005AE7 RID: 23271
		public const int RoleContextFieldNumber = 6;

		// Token: 0x04005AE8 RID: 23272
		private MatchRoleContext roleContext_;

		// Token: 0x04005AE9 RID: 23273
		public const int WeaponIdFieldNumber = 7;

		// Token: 0x04005AEA RID: 23274
		private int weaponId_;

		// Token: 0x04005AEB RID: 23275
		public const int WeaponBreachLevelFieldNumber = 8;

		// Token: 0x04005AEC RID: 23276
		private int weaponBreachLevel_;

		// Token: 0x04005AED RID: 23277
		public const int WeaponSkinIdFieldNumber = 9;

		// Token: 0x04005AEE RID: 23278
		private int weaponSkinId_;

		// Token: 0x04005AEF RID: 23279
		public const int DressListFieldNumber = 10;

		// Token: 0x04005AF0 RID: 23280
		private static readonly FieldCodec<int> _repeated_dressList_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005AF1 RID: 23281
		private readonly RepeatedField<int> dressList_ = new RepeatedField<int>();
	}
}
