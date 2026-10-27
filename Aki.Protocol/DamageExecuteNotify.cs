using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032E RID: 814
	[NetMessage(EMessageId.DamageExecuteNotify)]
	public sealed class DamageExecuteNotify : IMessage<DamageExecuteNotify>, IMessage, IEquatable<DamageExecuteNotify>, IDeepCloneable<DamageExecuteNotify>, IBufferMessage
	{
		// Token: 0x060051A6 RID: 20902 RVA: 0x000C69FC File Offset: 0x000C4BFC
		[NullableContext(1)]
		public static DamageExecuteNotify Create()
		{
			return new DamageExecuteNotify();
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x000C6A03 File Offset: 0x000C4C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x000C6A06 File Offset: 0x000C4C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteNotify.Descriptor;
			}
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x000C6A0D File Offset: 0x000C4C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify()
		{
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x000C6A18 File Offset: 0x000C4C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify(DamageExecuteNotify other) : this()
		{
			this.damageId_ = other.damageId_;
			this.attackerEntityId_ = other.attackerEntityId_;
			this.targetEntityId_ = other.targetEntityId_;
			this.damage_ = other.damage_;
			this.partId_ = other.partId_;
			this.isCrit_ = other.isCrit_;
			this.killedTarget_ = other.killedTarget_;
			this.shieldCoverDamage_ = other.shieldCoverDamage_;
			this.skillLevel_ = other.skillLevel_;
			this.damageContext_ = ((other.damageContext_ != null) ? other.damageContext_.Clone() : null);
			this.immuneType_ = other.immuneType_;
			this.elementType_ = other.elementType_;
			this.changeLife_ = other.changeLife_;
			this.changeWeakness_ = other.changeWeakness_;
			this.killerEntityId_ = other.killerEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x000C6B00 File Offset: 0x000C4D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify Clone()
		{
			return new DamageExecuteNotify(this);
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x000C6B08 File Offset: 0x000C4D08
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x000C6B10 File Offset: 0x000C4D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DamageId
		{
			get
			{
				return this.damageId_;
			}
			set
			{
				this.damageId_ = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x000C6B19 File Offset: 0x000C4D19
		// (set) Token: 0x060051AF RID: 20911 RVA: 0x000C6B21 File Offset: 0x000C4D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AttackerEntityId
		{
			get
			{
				return this.attackerEntityId_;
			}
			set
			{
				this.attackerEntityId_ = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x000C6B2A File Offset: 0x000C4D2A
		// (set) Token: 0x060051B1 RID: 20913 RVA: 0x000C6B32 File Offset: 0x000C4D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x000C6B3B File Offset: 0x000C4D3B
		// (set) Token: 0x060051B3 RID: 20915 RVA: 0x000C6B43 File Offset: 0x000C4D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x000C6B4C File Offset: 0x000C4D4C
		// (set) Token: 0x060051B5 RID: 20917 RVA: 0x000C6B54 File Offset: 0x000C4D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x000C6B5D File Offset: 0x000C4D5D
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x000C6B65 File Offset: 0x000C4D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCrit
		{
			get
			{
				return this.isCrit_;
			}
			set
			{
				this.isCrit_ = value;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x000C6B6E File Offset: 0x000C4D6E
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x000C6B76 File Offset: 0x000C4D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KilledTarget
		{
			get
			{
				return this.killedTarget_;
			}
			set
			{
				this.killedTarget_ = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x000C6B7F File Offset: 0x000C4D7F
		// (set) Token: 0x060051BB RID: 20923 RVA: 0x000C6B87 File Offset: 0x000C4D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldCoverDamage
		{
			get
			{
				return this.shieldCoverDamage_;
			}
			set
			{
				this.shieldCoverDamage_ = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x000C6B90 File Offset: 0x000C4D90
		// (set) Token: 0x060051BD RID: 20925 RVA: 0x000C6B98 File Offset: 0x000C4D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillLevel
		{
			get
			{
				return this.skillLevel_;
			}
			set
			{
				this.skillLevel_ = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x000C6BA1 File Offset: 0x000C4DA1
		// (set) Token: 0x060051BF RID: 20927 RVA: 0x000C6BA9 File Offset: 0x000C4DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageContext DamageContext
		{
			get
			{
				return this.damageContext_;
			}
			set
			{
				this.damageContext_ = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x000C6BB2 File Offset: 0x000C4DB2
		// (set) Token: 0x060051C1 RID: 20929 RVA: 0x000C6BBA File Offset: 0x000C4DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDamageImmune ImmuneType
		{
			get
			{
				return this.immuneType_;
			}
			set
			{
				this.immuneType_ = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x000C6BC3 File Offset: 0x000C4DC3
		// (set) Token: 0x060051C3 RID: 20931 RVA: 0x000C6BCB File Offset: 0x000C4DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementType
		{
			get
			{
				return this.elementType_;
			}
			set
			{
				this.elementType_ = value;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x000C6BD4 File Offset: 0x000C4DD4
		// (set) Token: 0x060051C5 RID: 20933 RVA: 0x000C6BDC File Offset: 0x000C4DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeLife
		{
			get
			{
				return this.changeLife_;
			}
			set
			{
				this.changeLife_ = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x000C6BE5 File Offset: 0x000C4DE5
		// (set) Token: 0x060051C7 RID: 20935 RVA: 0x000C6BED File Offset: 0x000C4DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeWeakness
		{
			get
			{
				return this.changeWeakness_;
			}
			set
			{
				this.changeWeakness_ = value;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x000C6BF6 File Offset: 0x000C4DF6
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x000C6BFE File Offset: 0x000C4DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KillerEntityId
		{
			get
			{
				return this.killerEntityId_;
			}
			set
			{
				this.killerEntityId_ = value;
			}
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x000C6C07 File Offset: 0x000C4E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteNotify);
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x000C6C18 File Offset: 0x000C4E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteNotify other)
		{
			return other != null && (other == this || (this.DamageId == other.DamageId && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.Damage == other.Damage && this.PartId == other.PartId && this.IsCrit == other.IsCrit && this.KilledTarget == other.KilledTarget && this.ShieldCoverDamage == other.ShieldCoverDamage && this.SkillLevel == other.SkillLevel && object.Equals(this.DamageContext, other.DamageContext) && this.ImmuneType == other.ImmuneType && this.ElementType == other.ElementType && this.ChangeLife == other.ChangeLife && this.ChangeWeakness == other.ChangeWeakness && this.KillerEntityId == other.KillerEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x000C6D38 File Offset: 0x000C4F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DamageId != 0L)
			{
				num ^= this.DamageId.GetHashCode();
			}
			if (this.AttackerEntityId != 0L)
			{
				num ^= this.AttackerEntityId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.IsCrit)
			{
				num ^= this.IsCrit.GetHashCode();
			}
			if (this.KilledTarget)
			{
				num ^= this.KilledTarget.GetHashCode();
			}
			if (this.ShieldCoverDamage != 0)
			{
				num ^= this.ShieldCoverDamage.GetHashCode();
			}
			if (this.SkillLevel != 0)
			{
				num ^= this.SkillLevel.GetHashCode();
			}
			if (this.damageContext_ != null)
			{
				num ^= this.DamageContext.GetHashCode();
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				num ^= this.ImmuneType.GetHashCode();
			}
			if (this.ElementType != 0)
			{
				num ^= this.ElementType.GetHashCode();
			}
			if (this.ChangeLife != 0)
			{
				num ^= this.ChangeLife.GetHashCode();
			}
			if (this.ChangeWeakness != 0)
			{
				num ^= this.ChangeWeakness.GetHashCode();
			}
			if (this.KillerEntityId != 0L)
			{
				num ^= this.KillerEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x000C6ED9 File Offset: 0x000C50D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x000C6EE6 File Offset: 0x000C50E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x000C6EF0 File Offset: 0x000C50F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ImmuneType != EDamageImmune.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ImmuneType);
			}
			if (this.ChangeWeakness != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChangeWeakness);
			}
			if (this.KilledTarget)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.KilledTarget);
			}
			if (this.ShieldCoverDamage != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ShieldCoverDamage);
			}
			if (this.ElementType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ElementType);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.DamageId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.DamageId);
			}
			if (this.IsCrit)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsCrit);
			}
			if (this.KillerEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.KillerEntityId);
			}
			if (this.ChangeLife != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChangeLife);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PartId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Damage);
			}
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.damageContext_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.DamageContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x000C70B4 File Offset: 0x000C52B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DamageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DamageId);
			}
			if (this.AttackerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AttackerEntityId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.IsCrit)
			{
				num += 2;
			}
			if (this.KilledTarget)
			{
				num += 2;
			}
			if (this.ShieldCoverDamage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldCoverDamage);
			}
			if (this.SkillLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLevel);
			}
			if (this.damageContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DamageContext);
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ImmuneType);
			}
			if (this.ElementType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementType);
			}
			if (this.ChangeLife != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeLife);
			}
			if (this.ChangeWeakness != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeWeakness);
			}
			if (this.KillerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.KillerEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x000C722C File Offset: 0x000C542C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageExecuteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DamageId != 0L)
			{
				this.DamageId = other.DamageId;
			}
			if (other.AttackerEntityId != 0L)
			{
				this.AttackerEntityId = other.AttackerEntityId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.IsCrit)
			{
				this.IsCrit = other.IsCrit;
			}
			if (other.KilledTarget)
			{
				this.KilledTarget = other.KilledTarget;
			}
			if (other.ShieldCoverDamage != 0)
			{
				this.ShieldCoverDamage = other.ShieldCoverDamage;
			}
			if (other.SkillLevel != 0)
			{
				this.SkillLevel = other.SkillLevel;
			}
			if (other.damageContext_ != null)
			{
				if (this.damageContext_ == null)
				{
					this.DamageContext = new DamageContext();
				}
				this.DamageContext.MergeFrom(other.DamageContext);
			}
			if (other.ImmuneType != EDamageImmune.Default)
			{
				this.ImmuneType = other.ImmuneType;
			}
			if (other.ElementType != 0)
			{
				this.ElementType = other.ElementType;
			}
			if (other.ChangeLife != 0)
			{
				this.ChangeLife = other.ChangeLife;
			}
			if (other.ChangeWeakness != 0)
			{
				this.ChangeWeakness = other.ChangeWeakness;
			}
			if (other.KillerEntityId != 0L)
			{
				this.KillerEntityId = other.KillerEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x000C7398 File Offset: 0x000C5598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x000C73A4 File Offset: 0x000C55A4
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.ImmuneType = (EDamageImmune)input.ReadEnum();
							continue;
						}
						if (num == 16U)
						{
							this.ChangeWeakness = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.KilledTarget = input.ReadBool();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.ShieldCoverDamage = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.ElementType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.SkillLevel = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.DamageId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 72U)
					{
						if (num == 64U)
						{
							this.IsCrit = input.ReadBool();
							continue;
						}
						if (num == 72U)
						{
							this.KillerEntityId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.ChangeLife = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.PartId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.AttackerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.damageContext_ == null)
						{
							this.DamageContext = new DamageContext();
						}
						input.ReadMessage(this.DamageContext);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032C0 RID: 12992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032C1 RID: 12993
		public const int DamageIdFieldNumber = 7;

		// Token: 0x040032C2 RID: 12994
		private long damageId_;

		// Token: 0x040032C3 RID: 12995
		public const int AttackerEntityIdFieldNumber = 14;

		// Token: 0x040032C4 RID: 12996
		private long attackerEntityId_;

		// Token: 0x040032C5 RID: 12997
		public const int TargetEntityIdFieldNumber = 12;

		// Token: 0x040032C6 RID: 12998
		private long targetEntityId_;

		// Token: 0x040032C7 RID: 12999
		public const int DamageFieldNumber = 13;

		// Token: 0x040032C8 RID: 13000
		private int damage_;

		// Token: 0x040032C9 RID: 13001
		public const int PartIdFieldNumber = 11;

		// Token: 0x040032CA RID: 13002
		private int partId_;

		// Token: 0x040032CB RID: 13003
		public const int IsCritFieldNumber = 8;

		// Token: 0x040032CC RID: 13004
		private bool isCrit_;

		// Token: 0x040032CD RID: 13005
		public const int KilledTargetFieldNumber = 3;

		// Token: 0x040032CE RID: 13006
		private bool killedTarget_;

		// Token: 0x040032CF RID: 13007
		public const int ShieldCoverDamageFieldNumber = 4;

		// Token: 0x040032D0 RID: 13008
		private int shieldCoverDamage_;

		// Token: 0x040032D1 RID: 13009
		public const int SkillLevelFieldNumber = 6;

		// Token: 0x040032D2 RID: 13010
		private int skillLevel_;

		// Token: 0x040032D3 RID: 13011
		public const int DamageContextFieldNumber = 15;

		// Token: 0x040032D4 RID: 13012
		private DamageContext damageContext_;

		// Token: 0x040032D5 RID: 13013
		public const int ImmuneTypeFieldNumber = 1;

		// Token: 0x040032D6 RID: 13014
		private EDamageImmune immuneType_;

		// Token: 0x040032D7 RID: 13015
		public const int ElementTypeFieldNumber = 5;

		// Token: 0x040032D8 RID: 13016
		private int elementType_;

		// Token: 0x040032D9 RID: 13017
		public const int ChangeLifeFieldNumber = 10;

		// Token: 0x040032DA RID: 13018
		private int changeLife_;

		// Token: 0x040032DB RID: 13019
		public const int ChangeWeaknessFieldNumber = 2;

		// Token: 0x040032DC RID: 13020
		private int changeWeakness_;

		// Token: 0x040032DD RID: 13021
		public const int KillerEntityIdFieldNumber = 9;

		// Token: 0x040032DE RID: 13022
		private long killerEntityId_;
	}
}
