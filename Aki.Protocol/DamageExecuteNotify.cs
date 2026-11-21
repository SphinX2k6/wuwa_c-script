using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000335 RID: 821
	[NetMessage(EMessageId.DamageExecuteNotify)]
	public sealed class DamageExecuteNotify : IMessage<DamageExecuteNotify>, IMessage, IEquatable<DamageExecuteNotify>, IDeepCloneable<DamageExecuteNotify>, IBufferMessage
	{
		// Token: 0x0600527F RID: 21119 RVA: 0x000C8DF0 File Offset: 0x000C6FF0
		[NullableContext(1)]
		public static DamageExecuteNotify Create()
		{
			return new DamageExecuteNotify();
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x000C8DF7 File Offset: 0x000C6FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06005281 RID: 21121 RVA: 0x000C8DFA File Offset: 0x000C6FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageExecuteNotify.Descriptor;
			}
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x000C8E01 File Offset: 0x000C7001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify()
		{
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x000C8E0C File Offset: 0x000C700C
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

		// Token: 0x06005284 RID: 21124 RVA: 0x000C8EF4 File Offset: 0x000C70F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageExecuteNotify Clone()
		{
			return new DamageExecuteNotify(this);
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x000C8EFC File Offset: 0x000C70FC
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x000C8F04 File Offset: 0x000C7104
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x000C8F0D File Offset: 0x000C710D
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x000C8F15 File Offset: 0x000C7115
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x000C8F1E File Offset: 0x000C711E
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x000C8F26 File Offset: 0x000C7126
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x000C8F2F File Offset: 0x000C712F
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x000C8F37 File Offset: 0x000C7137
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x000C8F40 File Offset: 0x000C7140
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x000C8F48 File Offset: 0x000C7148
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

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x000C8F51 File Offset: 0x000C7151
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x000C8F59 File Offset: 0x000C7159
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

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x000C8F62 File Offset: 0x000C7162
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x000C8F6A File Offset: 0x000C716A
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

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x000C8F73 File Offset: 0x000C7173
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x000C8F7B File Offset: 0x000C717B
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

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x000C8F84 File Offset: 0x000C7184
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x000C8F8C File Offset: 0x000C718C
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

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x000C8F95 File Offset: 0x000C7195
		// (set) Token: 0x06005298 RID: 21144 RVA: 0x000C8F9D File Offset: 0x000C719D
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

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x000C8FA6 File Offset: 0x000C71A6
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x000C8FAE File Offset: 0x000C71AE
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

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x000C8FB7 File Offset: 0x000C71B7
		// (set) Token: 0x0600529C RID: 21148 RVA: 0x000C8FBF File Offset: 0x000C71BF
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

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x000C8FC8 File Offset: 0x000C71C8
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x000C8FD0 File Offset: 0x000C71D0
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

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x000C8FD9 File Offset: 0x000C71D9
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x000C8FE1 File Offset: 0x000C71E1
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

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x000C8FEA File Offset: 0x000C71EA
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x000C8FF2 File Offset: 0x000C71F2
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

		// Token: 0x060052A3 RID: 21155 RVA: 0x000C8FFB File Offset: 0x000C71FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageExecuteNotify);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x000C900C File Offset: 0x000C720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageExecuteNotify other)
		{
			return other != null && (other == this || (this.DamageId == other.DamageId && this.AttackerEntityId == other.AttackerEntityId && this.TargetEntityId == other.TargetEntityId && this.Damage == other.Damage && this.PartId == other.PartId && this.IsCrit == other.IsCrit && this.KilledTarget == other.KilledTarget && this.ShieldCoverDamage == other.ShieldCoverDamage && this.SkillLevel == other.SkillLevel && object.Equals(this.DamageContext, other.DamageContext) && this.ImmuneType == other.ImmuneType && this.ElementType == other.ElementType && this.ChangeLife == other.ChangeLife && this.ChangeWeakness == other.ChangeWeakness && this.KillerEntityId == other.KillerEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x000C912C File Offset: 0x000C732C
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

		// Token: 0x060052A6 RID: 21158 RVA: 0x000C92CD File Offset: 0x000C74CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x000C92DA File Offset: 0x000C74DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x000C92E4 File Offset: 0x000C74E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChangeLife != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChangeLife);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.IsCrit)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsCrit);
			}
			if (this.ElementType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ElementType);
			}
			if (this.damageContext_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.DamageContext);
			}
			if (this.ShieldCoverDamage != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ShieldCoverDamage);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Damage);
			}
			if (this.KillerEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.KillerEntityId);
			}
			if (this.ChangeWeakness != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChangeWeakness);
			}
			if (this.AttackerEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.AttackerEntityId);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PartId);
			}
			if (this.DamageId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.DamageId);
			}
			if (this.SkillLevel != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillLevel);
			}
			if (this.KilledTarget)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.KilledTarget);
			}
			if (this.ImmuneType != EDamageImmune.Default)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ImmuneType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x000C94A8 File Offset: 0x000C76A8
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

		// Token: 0x060052AA RID: 21162 RVA: 0x000C9620 File Offset: 0x000C7820
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

		// Token: 0x060052AB RID: 21163 RVA: 0x000C978C File Offset: 0x000C798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x000C9798 File Offset: 0x000C7998
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
							this.ChangeLife = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.TargetEntityId = input.ReadInt64();
							continue;
						}
						if (num == 24U)
						{
							this.IsCrit = input.ReadBool();
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.ElementType = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							if (this.damageContext_ == null)
							{
								this.DamageContext = new DamageContext();
							}
							input.ReadMessage(this.DamageContext);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.ShieldCoverDamage = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.Damage = input.ReadInt32();
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
							this.KillerEntityId = input.ReadInt64();
							continue;
						}
						if (num == 72U)
						{
							this.ChangeWeakness = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.AttackerEntityId = input.ReadInt64();
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
						this.DamageId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.SkillLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.KilledTarget = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.ImmuneType = (EDamageImmune)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003357 RID: 13143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003358 RID: 13144
		public const int DamageIdFieldNumber = 12;

		// Token: 0x04003359 RID: 13145
		private long damageId_;

		// Token: 0x0400335A RID: 13146
		public const int AttackerEntityIdFieldNumber = 10;

		// Token: 0x0400335B RID: 13147
		private long attackerEntityId_;

		// Token: 0x0400335C RID: 13148
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x0400335D RID: 13149
		private long targetEntityId_;

		// Token: 0x0400335E RID: 13150
		public const int DamageFieldNumber = 7;

		// Token: 0x0400335F RID: 13151
		private int damage_;

		// Token: 0x04003360 RID: 13152
		public const int PartIdFieldNumber = 11;

		// Token: 0x04003361 RID: 13153
		private int partId_;

		// Token: 0x04003362 RID: 13154
		public const int IsCritFieldNumber = 3;

		// Token: 0x04003363 RID: 13155
		private bool isCrit_;

		// Token: 0x04003364 RID: 13156
		public const int KilledTargetFieldNumber = 14;

		// Token: 0x04003365 RID: 13157
		private bool killedTarget_;

		// Token: 0x04003366 RID: 13158
		public const int ShieldCoverDamageFieldNumber = 6;

		// Token: 0x04003367 RID: 13159
		private int shieldCoverDamage_;

		// Token: 0x04003368 RID: 13160
		public const int SkillLevelFieldNumber = 13;

		// Token: 0x04003369 RID: 13161
		private int skillLevel_;

		// Token: 0x0400336A RID: 13162
		public const int DamageContextFieldNumber = 5;

		// Token: 0x0400336B RID: 13163
		private DamageContext damageContext_;

		// Token: 0x0400336C RID: 13164
		public const int ImmuneTypeFieldNumber = 15;

		// Token: 0x0400336D RID: 13165
		private EDamageImmune immuneType_;

		// Token: 0x0400336E RID: 13166
		public const int ElementTypeFieldNumber = 4;

		// Token: 0x0400336F RID: 13167
		private int elementType_;

		// Token: 0x04003370 RID: 13168
		public const int ChangeLifeFieldNumber = 1;

		// Token: 0x04003371 RID: 13169
		private int changeLife_;

		// Token: 0x04003372 RID: 13170
		public const int ChangeWeaknessFieldNumber = 9;

		// Token: 0x04003373 RID: 13171
		private int changeWeakness_;

		// Token: 0x04003374 RID: 13172
		public const int KillerEntityIdFieldNumber = 8;

		// Token: 0x04003375 RID: 13173
		private long killerEntityId_;
	}
}
