using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001692 RID: 5778
	public sealed class DamageCalculationDetails : IMessage<DamageCalculationDetails>, IMessage, IEquatable<DamageCalculationDetails>, IDeepCloneable<DamageCalculationDetails>, IBufferMessage
	{
		// Token: 0x0601CF2B RID: 118571 RVA: 0x0043C2C5 File Offset: 0x0043A4C5
		[NullableContext(1)]
		public static DamageCalculationDetails Create()
		{
			return new DamageCalculationDetails();
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x0601CF2C RID: 118572 RVA: 0x0043C2CC File Offset: 0x0043A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x0601CF2D RID: 118573 RVA: 0x0043C2CF File Offset: 0x0043A4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageCalculationDetails.Descriptor;
			}
		}

		// Token: 0x0601CF2E RID: 118574 RVA: 0x0043C2D6 File Offset: 0x0043A4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails()
		{
		}

		// Token: 0x0601CF2F RID: 118575 RVA: 0x0043C2E0 File Offset: 0x0043A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails(DamageCalculationDetails other) : this()
		{
			this.aBaseAttackValue_ = other.aBaseAttackValue_;
			this.vEffectiveDefense_ = other.vEffectiveDefense_;
			this.aDamageFactor_ = other.aDamageFactor_;
			this.aDamageBonusRate_ = other.aDamageBonusRate_;
			this.aCritChance_ = other.aCritChance_;
			this.aWeaknessMasteryCoefficient_ = other.aWeaknessMasteryCoefficient_;
			this.vMonsterTypeRate_ = other.vMonsterTypeRate_;
			this.aRate_ = other.aRate_;
			this.vDefFactor_ = other.vDefFactor_;
			this.vResistanceFactor_ = other.vResistanceFactor_;
			this.vbDamageReduce_ = other.vbDamageReduce_;
			this.vbElementReduce_ = other.vbElementReduce_;
			this.aEnergyChange_ = other.aEnergyChange_;
			this.weaknessLvValue_ = other.weaknessLvValue_;
			this.vWeaknessBuffStack_ = other.vWeaknessBuffStack_;
			this.hitDamageBonusRate_ = other.hitDamageBonusRate_;
			this.weakDamageBonusRate_ = other.weakDamageBonusRate_;
			this.exceptedDamageValue_ = other.exceptedDamageValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF30 RID: 118576 RVA: 0x0043C3DC File Offset: 0x0043A5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails Clone()
		{
			return new DamageCalculationDetails(this);
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x0601CF31 RID: 118577 RVA: 0x0043C3E4 File Offset: 0x0043A5E4
		// (set) Token: 0x0601CF32 RID: 118578 RVA: 0x0043C3EC File Offset: 0x0043A5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ABaseAttackValue
		{
			get
			{
				return this.aBaseAttackValue_;
			}
			set
			{
				this.aBaseAttackValue_ = value;
			}
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x0601CF33 RID: 118579 RVA: 0x0043C3F5 File Offset: 0x0043A5F5
		// (set) Token: 0x0601CF34 RID: 118580 RVA: 0x0043C3FD File Offset: 0x0043A5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VEffectiveDefense
		{
			get
			{
				return this.vEffectiveDefense_;
			}
			set
			{
				this.vEffectiveDefense_ = value;
			}
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x0601CF35 RID: 118581 RVA: 0x0043C406 File Offset: 0x0043A606
		// (set) Token: 0x0601CF36 RID: 118582 RVA: 0x0043C40E File Offset: 0x0043A60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ADamageFactor
		{
			get
			{
				return this.aDamageFactor_;
			}
			set
			{
				this.aDamageFactor_ = value;
			}
		}

		// Token: 0x17006231 RID: 25137
		// (get) Token: 0x0601CF37 RID: 118583 RVA: 0x0043C417 File Offset: 0x0043A617
		// (set) Token: 0x0601CF38 RID: 118584 RVA: 0x0043C41F File Offset: 0x0043A61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ADamageBonusRate
		{
			get
			{
				return this.aDamageBonusRate_;
			}
			set
			{
				this.aDamageBonusRate_ = value;
			}
		}

		// Token: 0x17006232 RID: 25138
		// (get) Token: 0x0601CF39 RID: 118585 RVA: 0x0043C428 File Offset: 0x0043A628
		// (set) Token: 0x0601CF3A RID: 118586 RVA: 0x0043C430 File Offset: 0x0043A630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ACritChance
		{
			get
			{
				return this.aCritChance_;
			}
			set
			{
				this.aCritChance_ = value;
			}
		}

		// Token: 0x17006233 RID: 25139
		// (get) Token: 0x0601CF3B RID: 118587 RVA: 0x0043C439 File Offset: 0x0043A639
		// (set) Token: 0x0601CF3C RID: 118588 RVA: 0x0043C441 File Offset: 0x0043A641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float AWeaknessMasteryCoefficient
		{
			get
			{
				return this.aWeaknessMasteryCoefficient_;
			}
			set
			{
				this.aWeaknessMasteryCoefficient_ = value;
			}
		}

		// Token: 0x17006234 RID: 25140
		// (get) Token: 0x0601CF3D RID: 118589 RVA: 0x0043C44A File Offset: 0x0043A64A
		// (set) Token: 0x0601CF3E RID: 118590 RVA: 0x0043C452 File Offset: 0x0043A652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VMonsterTypeRate
		{
			get
			{
				return this.vMonsterTypeRate_;
			}
			set
			{
				this.vMonsterTypeRate_ = value;
			}
		}

		// Token: 0x17006235 RID: 25141
		// (get) Token: 0x0601CF3F RID: 118591 RVA: 0x0043C45B File Offset: 0x0043A65B
		// (set) Token: 0x0601CF40 RID: 118592 RVA: 0x0043C463 File Offset: 0x0043A663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ARate
		{
			get
			{
				return this.aRate_;
			}
			set
			{
				this.aRate_ = value;
			}
		}

		// Token: 0x17006236 RID: 25142
		// (get) Token: 0x0601CF41 RID: 118593 RVA: 0x0043C46C File Offset: 0x0043A66C
		// (set) Token: 0x0601CF42 RID: 118594 RVA: 0x0043C474 File Offset: 0x0043A674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VDefFactor
		{
			get
			{
				return this.vDefFactor_;
			}
			set
			{
				this.vDefFactor_ = value;
			}
		}

		// Token: 0x17006237 RID: 25143
		// (get) Token: 0x0601CF43 RID: 118595 RVA: 0x0043C47D File Offset: 0x0043A67D
		// (set) Token: 0x0601CF44 RID: 118596 RVA: 0x0043C485 File Offset: 0x0043A685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VResistanceFactor
		{
			get
			{
				return this.vResistanceFactor_;
			}
			set
			{
				this.vResistanceFactor_ = value;
			}
		}

		// Token: 0x17006238 RID: 25144
		// (get) Token: 0x0601CF45 RID: 118597 RVA: 0x0043C48E File Offset: 0x0043A68E
		// (set) Token: 0x0601CF46 RID: 118598 RVA: 0x0043C496 File Offset: 0x0043A696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VbDamageReduce
		{
			get
			{
				return this.vbDamageReduce_;
			}
			set
			{
				this.vbDamageReduce_ = value;
			}
		}

		// Token: 0x17006239 RID: 25145
		// (get) Token: 0x0601CF47 RID: 118599 RVA: 0x0043C49F File Offset: 0x0043A69F
		// (set) Token: 0x0601CF48 RID: 118600 RVA: 0x0043C4A7 File Offset: 0x0043A6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float VbElementReduce
		{
			get
			{
				return this.vbElementReduce_;
			}
			set
			{
				this.vbElementReduce_ = value;
			}
		}

		// Token: 0x1700623A RID: 25146
		// (get) Token: 0x0601CF49 RID: 118601 RVA: 0x0043C4B0 File Offset: 0x0043A6B0
		// (set) Token: 0x0601CF4A RID: 118602 RVA: 0x0043C4B8 File Offset: 0x0043A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AEnergyChange
		{
			get
			{
				return this.aEnergyChange_;
			}
			set
			{
				this.aEnergyChange_ = value;
			}
		}

		// Token: 0x1700623B RID: 25147
		// (get) Token: 0x0601CF4B RID: 118603 RVA: 0x0043C4C1 File Offset: 0x0043A6C1
		// (set) Token: 0x0601CF4C RID: 118604 RVA: 0x0043C4C9 File Offset: 0x0043A6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float WeaknessLvValue
		{
			get
			{
				return this.weaknessLvValue_;
			}
			set
			{
				this.weaknessLvValue_ = value;
			}
		}

		// Token: 0x1700623C RID: 25148
		// (get) Token: 0x0601CF4D RID: 118605 RVA: 0x0043C4D2 File Offset: 0x0043A6D2
		// (set) Token: 0x0601CF4E RID: 118606 RVA: 0x0043C4DA File Offset: 0x0043A6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VWeaknessBuffStack
		{
			get
			{
				return this.vWeaknessBuffStack_;
			}
			set
			{
				this.vWeaknessBuffStack_ = value;
			}
		}

		// Token: 0x1700623D RID: 25149
		// (get) Token: 0x0601CF4F RID: 118607 RVA: 0x0043C4E3 File Offset: 0x0043A6E3
		// (set) Token: 0x0601CF50 RID: 118608 RVA: 0x0043C4EB File Offset: 0x0043A6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float HitDamageBonusRate
		{
			get
			{
				return this.hitDamageBonusRate_;
			}
			set
			{
				this.hitDamageBonusRate_ = value;
			}
		}

		// Token: 0x1700623E RID: 25150
		// (get) Token: 0x0601CF51 RID: 118609 RVA: 0x0043C4F4 File Offset: 0x0043A6F4
		// (set) Token: 0x0601CF52 RID: 118610 RVA: 0x0043C4FC File Offset: 0x0043A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float WeakDamageBonusRate
		{
			get
			{
				return this.weakDamageBonusRate_;
			}
			set
			{
				this.weakDamageBonusRate_ = value;
			}
		}

		// Token: 0x1700623F RID: 25151
		// (get) Token: 0x0601CF53 RID: 118611 RVA: 0x0043C505 File Offset: 0x0043A705
		// (set) Token: 0x0601CF54 RID: 118612 RVA: 0x0043C50D File Offset: 0x0043A70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ExceptedDamageValue
		{
			get
			{
				return this.exceptedDamageValue_;
			}
			set
			{
				this.exceptedDamageValue_ = value;
			}
		}

		// Token: 0x0601CF55 RID: 118613 RVA: 0x0043C516 File Offset: 0x0043A716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageCalculationDetails);
		}

		// Token: 0x0601CF56 RID: 118614 RVA: 0x0043C524 File Offset: 0x0043A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageCalculationDetails other)
		{
			return other != null && (other == this || (this.ABaseAttackValue == other.ABaseAttackValue && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VEffectiveDefense, other.VEffectiveDefense) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ADamageFactor, other.ADamageFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ADamageBonusRate, other.ADamageBonusRate) && this.ACritChance == other.ACritChance && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AWeaknessMasteryCoefficient, other.AWeaknessMasteryCoefficient) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VMonsterTypeRate, other.VMonsterTypeRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ARate, other.ARate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VDefFactor, other.VDefFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VResistanceFactor, other.VResistanceFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VbDamageReduce, other.VbDamageReduce) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VbElementReduce, other.VbElementReduce) && this.AEnergyChange == other.AEnergyChange && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WeaknessLvValue, other.WeaknessLvValue) && this.VWeaknessBuffStack == other.VWeaknessBuffStack && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HitDamageBonusRate, other.HitDamageBonusRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WeakDamageBonusRate, other.WeakDamageBonusRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ExceptedDamageValue, other.ExceptedDamageValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF57 RID: 118615 RVA: 0x0043C6FC File Offset: 0x0043A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ABaseAttackValue != 0L)
			{
				num ^= this.ABaseAttackValue.GetHashCode();
			}
			if (this.VEffectiveDefense != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VEffectiveDefense);
			}
			if (this.ADamageFactor != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ADamageFactor);
			}
			if (this.ADamageBonusRate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ADamageBonusRate);
			}
			if (this.ACritChance != 0L)
			{
				num ^= this.ACritChance.GetHashCode();
			}
			if (this.AWeaknessMasteryCoefficient != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.AWeaknessMasteryCoefficient);
			}
			if (this.VMonsterTypeRate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VMonsterTypeRate);
			}
			if (this.ARate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ARate);
			}
			if (this.VDefFactor != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VDefFactor);
			}
			if (this.VResistanceFactor != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VResistanceFactor);
			}
			if (this.VbDamageReduce != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VbDamageReduce);
			}
			if (this.VbElementReduce != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.VbElementReduce);
			}
			if (this.AEnergyChange != 0L)
			{
				num ^= this.AEnergyChange.GetHashCode();
			}
			if (this.WeaknessLvValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.WeaknessLvValue);
			}
			if (this.VWeaknessBuffStack != 0)
			{
				num ^= this.VWeaknessBuffStack.GetHashCode();
			}
			if (this.HitDamageBonusRate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HitDamageBonusRate);
			}
			if (this.WeakDamageBonusRate != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.WeakDamageBonusRate);
			}
			if (this.ExceptedDamageValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ExceptedDamageValue);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF58 RID: 118616 RVA: 0x0043C946 File Offset: 0x0043AB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF59 RID: 118617 RVA: 0x0043C953 File Offset: 0x0043AB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF5A RID: 118618 RVA: 0x0043C95C File Offset: 0x0043AB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ABaseAttackValue != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ABaseAttackValue);
			}
			if (this.VEffectiveDefense != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.VEffectiveDefense);
			}
			if (this.ADamageFactor != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.ADamageFactor);
			}
			if (this.ADamageBonusRate != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.ADamageBonusRate);
			}
			if (this.ACritChance != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.ACritChance);
			}
			if (this.AWeaknessMasteryCoefficient != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.AWeaknessMasteryCoefficient);
			}
			if (this.VMonsterTypeRate != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.VMonsterTypeRate);
			}
			if (this.ARate != 0f)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.ARate);
			}
			if (this.VDefFactor != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.VDefFactor);
			}
			if (this.VResistanceFactor != 0f)
			{
				output.WriteRawTag(85);
				output.WriteFloat(this.VResistanceFactor);
			}
			if (this.VbDamageReduce != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.VbDamageReduce);
			}
			if (this.VbElementReduce != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.VbElementReduce);
			}
			if (this.AEnergyChange != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.AEnergyChange);
			}
			if (this.WeaknessLvValue != 0f)
			{
				output.WriteRawTag(117);
				output.WriteFloat(this.WeaknessLvValue);
			}
			if (this.VWeaknessBuffStack != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.VWeaknessBuffStack);
			}
			if (this.HitDamageBonusRate != 0f)
			{
				output.WriteRawTag(133, 1);
				output.WriteFloat(this.HitDamageBonusRate);
			}
			if (this.WeakDamageBonusRate != 0f)
			{
				output.WriteRawTag(141, 1);
				output.WriteFloat(this.WeakDamageBonusRate);
			}
			if (this.ExceptedDamageValue != 0f)
			{
				output.WriteRawTag(149, 1);
				output.WriteFloat(this.ExceptedDamageValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF5B RID: 118619 RVA: 0x0043CBC8 File Offset: 0x0043ADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ABaseAttackValue != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ABaseAttackValue);
			}
			if (this.VEffectiveDefense != 0f)
			{
				num += 5;
			}
			if (this.ADamageFactor != 0f)
			{
				num += 5;
			}
			if (this.ADamageBonusRate != 0f)
			{
				num += 5;
			}
			if (this.ACritChance != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ACritChance);
			}
			if (this.AWeaknessMasteryCoefficient != 0f)
			{
				num += 5;
			}
			if (this.VMonsterTypeRate != 0f)
			{
				num += 5;
			}
			if (this.ARate != 0f)
			{
				num += 5;
			}
			if (this.VDefFactor != 0f)
			{
				num += 5;
			}
			if (this.VResistanceFactor != 0f)
			{
				num += 5;
			}
			if (this.VbDamageReduce != 0f)
			{
				num += 5;
			}
			if (this.VbElementReduce != 0f)
			{
				num += 5;
			}
			if (this.AEnergyChange != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AEnergyChange);
			}
			if (this.WeaknessLvValue != 0f)
			{
				num += 5;
			}
			if (this.VWeaknessBuffStack != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VWeaknessBuffStack);
			}
			if (this.HitDamageBonusRate != 0f)
			{
				num += 6;
			}
			if (this.WeakDamageBonusRate != 0f)
			{
				num += 6;
			}
			if (this.ExceptedDamageValue != 0f)
			{
				num += 6;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF5C RID: 118620 RVA: 0x0043CD3C File Offset: 0x0043AF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DamageCalculationDetails other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ABaseAttackValue != 0L)
			{
				this.ABaseAttackValue = other.ABaseAttackValue;
			}
			if (other.VEffectiveDefense != 0f)
			{
				this.VEffectiveDefense = other.VEffectiveDefense;
			}
			if (other.ADamageFactor != 0f)
			{
				this.ADamageFactor = other.ADamageFactor;
			}
			if (other.ADamageBonusRate != 0f)
			{
				this.ADamageBonusRate = other.ADamageBonusRate;
			}
			if (other.ACritChance != 0L)
			{
				this.ACritChance = other.ACritChance;
			}
			if (other.AWeaknessMasteryCoefficient != 0f)
			{
				this.AWeaknessMasteryCoefficient = other.AWeaknessMasteryCoefficient;
			}
			if (other.VMonsterTypeRate != 0f)
			{
				this.VMonsterTypeRate = other.VMonsterTypeRate;
			}
			if (other.ARate != 0f)
			{
				this.ARate = other.ARate;
			}
			if (other.VDefFactor != 0f)
			{
				this.VDefFactor = other.VDefFactor;
			}
			if (other.VResistanceFactor != 0f)
			{
				this.VResistanceFactor = other.VResistanceFactor;
			}
			if (other.VbDamageReduce != 0f)
			{
				this.VbDamageReduce = other.VbDamageReduce;
			}
			if (other.VbElementReduce != 0f)
			{
				this.VbElementReduce = other.VbElementReduce;
			}
			if (other.AEnergyChange != 0L)
			{
				this.AEnergyChange = other.AEnergyChange;
			}
			if (other.WeaknessLvValue != 0f)
			{
				this.WeaknessLvValue = other.WeaknessLvValue;
			}
			if (other.VWeaknessBuffStack != 0)
			{
				this.VWeaknessBuffStack = other.VWeaknessBuffStack;
			}
			if (other.HitDamageBonusRate != 0f)
			{
				this.HitDamageBonusRate = other.HitDamageBonusRate;
			}
			if (other.WeakDamageBonusRate != 0f)
			{
				this.WeakDamageBonusRate = other.WeakDamageBonusRate;
			}
			if (other.ExceptedDamageValue != 0f)
			{
				this.ExceptedDamageValue = other.ExceptedDamageValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF5D RID: 118621 RVA: 0x0043CF12 File Offset: 0x0043B112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF5E RID: 118622 RVA: 0x0043CF1C File Offset: 0x0043B11C
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
				if (num <= 77U)
				{
					if (num <= 37U)
					{
						if (num <= 21U)
						{
							if (num == 8U)
							{
								this.ABaseAttackValue = input.ReadInt64();
								continue;
							}
							if (num == 21U)
							{
								this.VEffectiveDefense = input.ReadFloat();
								continue;
							}
						}
						else
						{
							if (num == 29U)
							{
								this.ADamageFactor = input.ReadFloat();
								continue;
							}
							if (num == 37U)
							{
								this.ADamageBonusRate = input.ReadFloat();
								continue;
							}
						}
					}
					else if (num <= 53U)
					{
						if (num == 40U)
						{
							this.ACritChance = input.ReadInt64();
							continue;
						}
						if (num == 53U)
						{
							this.AWeaknessMasteryCoefficient = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 61U)
						{
							this.VMonsterTypeRate = input.ReadFloat();
							continue;
						}
						if (num == 69U)
						{
							this.ARate = input.ReadFloat();
							continue;
						}
						if (num == 77U)
						{
							this.VDefFactor = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num <= 93U)
					{
						if (num == 85U)
						{
							this.VResistanceFactor = input.ReadFloat();
							continue;
						}
						if (num == 93U)
						{
							this.VbDamageReduce = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 101U)
						{
							this.VbElementReduce = input.ReadFloat();
							continue;
						}
						if (num == 104U)
						{
							this.AEnergyChange = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num == 117U)
					{
						this.WeaknessLvValue = input.ReadFloat();
						continue;
					}
					if (num == 120U)
					{
						this.VWeaknessBuffStack = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 133U)
					{
						this.HitDamageBonusRate = input.ReadFloat();
						continue;
					}
					if (num == 141U)
					{
						this.WeakDamageBonusRate = input.ReadFloat();
						continue;
					}
					if (num == 149U)
					{
						this.ExceptedDamageValue = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C36C RID: 50028
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C36D RID: 50029
		public const int ABaseAttackValueFieldNumber = 1;

		// Token: 0x0400C36E RID: 50030
		private long aBaseAttackValue_;

		// Token: 0x0400C36F RID: 50031
		public const int VEffectiveDefenseFieldNumber = 2;

		// Token: 0x0400C370 RID: 50032
		private float vEffectiveDefense_;

		// Token: 0x0400C371 RID: 50033
		public const int ADamageFactorFieldNumber = 3;

		// Token: 0x0400C372 RID: 50034
		private float aDamageFactor_;

		// Token: 0x0400C373 RID: 50035
		public const int ADamageBonusRateFieldNumber = 4;

		// Token: 0x0400C374 RID: 50036
		private float aDamageBonusRate_;

		// Token: 0x0400C375 RID: 50037
		public const int ACritChanceFieldNumber = 5;

		// Token: 0x0400C376 RID: 50038
		private long aCritChance_;

		// Token: 0x0400C377 RID: 50039
		public const int AWeaknessMasteryCoefficientFieldNumber = 6;

		// Token: 0x0400C378 RID: 50040
		private float aWeaknessMasteryCoefficient_;

		// Token: 0x0400C379 RID: 50041
		public const int VMonsterTypeRateFieldNumber = 7;

		// Token: 0x0400C37A RID: 50042
		private float vMonsterTypeRate_;

		// Token: 0x0400C37B RID: 50043
		public const int ARateFieldNumber = 8;

		// Token: 0x0400C37C RID: 50044
		private float aRate_;

		// Token: 0x0400C37D RID: 50045
		public const int VDefFactorFieldNumber = 9;

		// Token: 0x0400C37E RID: 50046
		private float vDefFactor_;

		// Token: 0x0400C37F RID: 50047
		public const int VResistanceFactorFieldNumber = 10;

		// Token: 0x0400C380 RID: 50048
		private float vResistanceFactor_;

		// Token: 0x0400C381 RID: 50049
		public const int VbDamageReduceFieldNumber = 11;

		// Token: 0x0400C382 RID: 50050
		private float vbDamageReduce_;

		// Token: 0x0400C383 RID: 50051
		public const int VbElementReduceFieldNumber = 12;

		// Token: 0x0400C384 RID: 50052
		private float vbElementReduce_;

		// Token: 0x0400C385 RID: 50053
		public const int AEnergyChangeFieldNumber = 13;

		// Token: 0x0400C386 RID: 50054
		private long aEnergyChange_;

		// Token: 0x0400C387 RID: 50055
		public const int WeaknessLvValueFieldNumber = 14;

		// Token: 0x0400C388 RID: 50056
		private float weaknessLvValue_;

		// Token: 0x0400C389 RID: 50057
		public const int VWeaknessBuffStackFieldNumber = 15;

		// Token: 0x0400C38A RID: 50058
		private int vWeaknessBuffStack_;

		// Token: 0x0400C38B RID: 50059
		public const int HitDamageBonusRateFieldNumber = 16;

		// Token: 0x0400C38C RID: 50060
		private float hitDamageBonusRate_;

		// Token: 0x0400C38D RID: 50061
		public const int WeakDamageBonusRateFieldNumber = 17;

		// Token: 0x0400C38E RID: 50062
		private float weakDamageBonusRate_;

		// Token: 0x0400C38F RID: 50063
		public const int ExceptedDamageValueFieldNumber = 18;

		// Token: 0x0400C390 RID: 50064
		private float exceptedDamageValue_;
	}
}
