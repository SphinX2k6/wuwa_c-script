using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200035D RID: 861
	public sealed class DangoBrawlFightActionSkillCastInfo : IMessage<DangoBrawlFightActionSkillCastInfo>, IMessage, IEquatable<DangoBrawlFightActionSkillCastInfo>, IDeepCloneable<DangoBrawlFightActionSkillCastInfo>, IBufferMessage
	{
		// Token: 0x0600562C RID: 22060 RVA: 0x000D2B16 File Offset: 0x000D0D16
		[NullableContext(1)]
		public static DangoBrawlFightActionSkillCastInfo Create()
		{
			return new DangoBrawlFightActionSkillCastInfo();
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x000D2B1D File Offset: 0x000D0D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x000D2B20 File Offset: 0x000D0D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionSkillCastInfo.Descriptor;
			}
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x000D2B27 File Offset: 0x000D0D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo()
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x000D2B30 File Offset: 0x000D0D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo(DangoBrawlFightActionSkillCastInfo other) : this()
		{
			this.sourceFighterUId_ = other.sourceFighterUId_;
			this.skillConfigId_ = other.skillConfigId_;
			this.weaponItemId_ = other.weaponItemId_;
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damageInfo_ = ((other.damageInfo_ != null) ? other.damageInfo_.Clone() : null);
			this.weaponItemUId_ = other.weaponItemUId_;
			this.nextReadyMs_ = other.nextReadyMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x000D2BB8 File Offset: 0x000D0DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionSkillCastInfo Clone()
		{
			return new DangoBrawlFightActionSkillCastInfo(this);
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x000D2BC0 File Offset: 0x000D0DC0
		// (set) Token: 0x06005633 RID: 22067 RVA: 0x000D2BC8 File Offset: 0x000D0DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceFighterUId
		{
			get
			{
				return this.sourceFighterUId_;
			}
			set
			{
				this.sourceFighterUId_ = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06005634 RID: 22068 RVA: 0x000D2BD1 File Offset: 0x000D0DD1
		// (set) Token: 0x06005635 RID: 22069 RVA: 0x000D2BD9 File Offset: 0x000D0DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillConfigId
		{
			get
			{
				return this.skillConfigId_;
			}
			set
			{
				this.skillConfigId_ = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x000D2BE2 File Offset: 0x000D0DE2
		// (set) Token: 0x06005637 RID: 22071 RVA: 0x000D2BEA File Offset: 0x000D0DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemId
		{
			get
			{
				return this.weaponItemId_;
			}
			set
			{
				this.weaponItemId_ = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06005638 RID: 22072 RVA: 0x000D2BF3 File Offset: 0x000D0DF3
		// (set) Token: 0x06005639 RID: 22073 RVA: 0x000D2BFB File Offset: 0x000D0DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x000D2C04 File Offset: 0x000D0E04
		// (set) Token: 0x0600563B RID: 22075 RVA: 0x000D2C0C File Offset: 0x000D0E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo DamageInfo
		{
			get
			{
				return this.damageInfo_;
			}
			set
			{
				this.damageInfo_ = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x000D2C15 File Offset: 0x000D0E15
		// (set) Token: 0x0600563D RID: 22077 RVA: 0x000D2C1D File Offset: 0x000D0E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemUId
		{
			get
			{
				return this.weaponItemUId_;
			}
			set
			{
				this.weaponItemUId_ = value;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x0600563E RID: 22078 RVA: 0x000D2C26 File Offset: 0x000D0E26
		// (set) Token: 0x0600563F RID: 22079 RVA: 0x000D2C2E File Offset: 0x000D0E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextReadyMs
		{
			get
			{
				return this.nextReadyMs_;
			}
			set
			{
				this.nextReadyMs_ = value;
			}
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x000D2C37 File Offset: 0x000D0E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionSkillCastInfo);
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x000D2C48 File Offset: 0x000D0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionSkillCastInfo other)
		{
			return other != null && (other == this || (this.SourceFighterUId == other.SourceFighterUId && this.SkillConfigId == other.SkillConfigId && this.WeaponItemId == other.WeaponItemId && this.TargetFighterUId == other.TargetFighterUId && object.Equals(this.DamageInfo, other.DamageInfo) && this.WeaponItemUId == other.WeaponItemUId && this.NextReadyMs == other.NextReadyMs && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x000D2CE8 File Offset: 0x000D0EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceFighterUId != 0)
			{
				num ^= this.SourceFighterUId.GetHashCode();
			}
			if (this.SkillConfigId != 0)
			{
				num ^= this.SkillConfigId.GetHashCode();
			}
			if (this.WeaponItemId != 0)
			{
				num ^= this.WeaponItemId.GetHashCode();
			}
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.damageInfo_ != null)
			{
				num ^= this.DamageInfo.GetHashCode();
			}
			if (this.WeaponItemUId != 0)
			{
				num ^= this.WeaponItemUId.GetHashCode();
			}
			if (this.NextReadyMs != 0)
			{
				num ^= this.NextReadyMs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x000D2DBA File Offset: 0x000D0FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x000D2DC7 File Offset: 0x000D0FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x000D2DD0 File Offset: 0x000D0FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceFighterUId);
			}
			if (this.SkillConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillConfigId);
			}
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.damageInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageInfo);
			}
			if (this.WeaponItemUId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x000D2EB4 File Offset: 0x000D10B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceFighterUId);
			}
			if (this.SkillConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillConfigId);
			}
			if (this.WeaponItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemId);
			}
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.damageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageInfo);
			}
			if (this.WeaponItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemUId);
			}
			if (this.NextReadyMs != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextReadyMs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x000D2F84 File Offset: 0x000D1184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionSkillCastInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceFighterUId != 0)
			{
				this.SourceFighterUId = other.SourceFighterUId;
			}
			if (other.SkillConfigId != 0)
			{
				this.SkillConfigId = other.SkillConfigId;
			}
			if (other.WeaponItemId != 0)
			{
				this.WeaponItemId = other.WeaponItemId;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.damageInfo_ != null)
			{
				if (this.damageInfo_ == null)
				{
					this.DamageInfo = new DangoBrawlDamageInfo();
				}
				this.DamageInfo.MergeFrom(other.DamageInfo);
			}
			if (other.WeaponItemUId != 0)
			{
				this.WeaponItemUId = other.WeaponItemUId;
			}
			if (other.NextReadyMs != 0)
			{
				this.NextReadyMs = other.NextReadyMs;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x000D3050 File Offset: 0x000D1250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x000D305C File Offset: 0x000D125C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SourceFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkillConfigId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.WeaponItemId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 32U)
					{
						this.TargetFighterUId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.damageInfo_ == null)
						{
							this.DamageInfo = new DangoBrawlDamageInfo();
						}
						input.ReadMessage(this.DamageInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.WeaponItemUId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.NextReadyMs = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034AF RID: 13487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B0 RID: 13488
		public const int SourceFighterUIdFieldNumber = 1;

		// Token: 0x040034B1 RID: 13489
		private int sourceFighterUId_;

		// Token: 0x040034B2 RID: 13490
		public const int SkillConfigIdFieldNumber = 2;

		// Token: 0x040034B3 RID: 13491
		private int skillConfigId_;

		// Token: 0x040034B4 RID: 13492
		public const int WeaponItemIdFieldNumber = 3;

		// Token: 0x040034B5 RID: 13493
		private int weaponItemId_;

		// Token: 0x040034B6 RID: 13494
		public const int TargetFighterUIdFieldNumber = 4;

		// Token: 0x040034B7 RID: 13495
		private int targetFighterUId_;

		// Token: 0x040034B8 RID: 13496
		public const int DamageInfoFieldNumber = 5;

		// Token: 0x040034B9 RID: 13497
		private DangoBrawlDamageInfo damageInfo_;

		// Token: 0x040034BA RID: 13498
		public const int WeaponItemUIdFieldNumber = 6;

		// Token: 0x040034BB RID: 13499
		private int weaponItemUId_;

		// Token: 0x040034BC RID: 13500
		public const int NextReadyMsFieldNumber = 7;

		// Token: 0x040034BD RID: 13501
		private int nextReadyMs_;
	}
}
