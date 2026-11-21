using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200170E RID: 5902
	public sealed class DamageCalculationDetails : IMessage<DamageCalculationDetails>, IMessage, IEquatable<DamageCalculationDetails>, IDeepCloneable<DamageCalculationDetails>, IBufferMessage
	{
		// Token: 0x0601D9F6 RID: 121334 RVA: 0x00457E75 File Offset: 0x00456075
		[NullableContext(1)]
		public static DamageCalculationDetails Create()
		{
			return new DamageCalculationDetails();
		}

		// Token: 0x170064CF RID: 25807
		// (get) Token: 0x0601D9F7 RID: 121335 RVA: 0x00457E7C File Offset: 0x0045607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x0601D9F8 RID: 121336 RVA: 0x00457E7F File Offset: 0x0045607F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DamageCalculationDetails.Descriptor;
			}
		}

		// Token: 0x0601D9F9 RID: 121337 RVA: 0x00457E86 File Offset: 0x00456086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails()
		{
		}

		// Token: 0x0601D9FA RID: 121338 RVA: 0x00457E90 File Offset: 0x00456090
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
			this.darkTideAttackValue_ = other.darkTideAttackValue_;
			this.aDamageBonusRate2_ = other.aDamageBonusRate2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D9FB RID: 121339 RVA: 0x00457FA4 File Offset: 0x004561A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DamageCalculationDetails Clone()
		{
			return new DamageCalculationDetails(this);
		}

		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x0601D9FC RID: 121340 RVA: 0x00457FAC File Offset: 0x004561AC
		// (set) Token: 0x0601D9FD RID: 121341 RVA: 0x00457FB4 File Offset: 0x004561B4
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

		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x0601D9FE RID: 121342 RVA: 0x00457FBD File Offset: 0x004561BD
		// (set) Token: 0x0601D9FF RID: 121343 RVA: 0x00457FC5 File Offset: 0x004561C5
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

		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x0601DA00 RID: 121344 RVA: 0x00457FCE File Offset: 0x004561CE
		// (set) Token: 0x0601DA01 RID: 121345 RVA: 0x00457FD6 File Offset: 0x004561D6
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

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x0601DA02 RID: 121346 RVA: 0x00457FDF File Offset: 0x004561DF
		// (set) Token: 0x0601DA03 RID: 121347 RVA: 0x00457FE7 File Offset: 0x004561E7
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

		// Token: 0x170064D5 RID: 25813
		// (get) Token: 0x0601DA04 RID: 121348 RVA: 0x00457FF0 File Offset: 0x004561F0
		// (set) Token: 0x0601DA05 RID: 121349 RVA: 0x00457FF8 File Offset: 0x004561F8
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

		// Token: 0x170064D6 RID: 25814
		// (get) Token: 0x0601DA06 RID: 121350 RVA: 0x00458001 File Offset: 0x00456201
		// (set) Token: 0x0601DA07 RID: 121351 RVA: 0x00458009 File Offset: 0x00456209
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

		// Token: 0x170064D7 RID: 25815
		// (get) Token: 0x0601DA08 RID: 121352 RVA: 0x00458012 File Offset: 0x00456212
		// (set) Token: 0x0601DA09 RID: 121353 RVA: 0x0045801A File Offset: 0x0045621A
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

		// Token: 0x170064D8 RID: 25816
		// (get) Token: 0x0601DA0A RID: 121354 RVA: 0x00458023 File Offset: 0x00456223
		// (set) Token: 0x0601DA0B RID: 121355 RVA: 0x0045802B File Offset: 0x0045622B
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

		// Token: 0x170064D9 RID: 25817
		// (get) Token: 0x0601DA0C RID: 121356 RVA: 0x00458034 File Offset: 0x00456234
		// (set) Token: 0x0601DA0D RID: 121357 RVA: 0x0045803C File Offset: 0x0045623C
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

		// Token: 0x170064DA RID: 25818
		// (get) Token: 0x0601DA0E RID: 121358 RVA: 0x00458045 File Offset: 0x00456245
		// (set) Token: 0x0601DA0F RID: 121359 RVA: 0x0045804D File Offset: 0x0045624D
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

		// Token: 0x170064DB RID: 25819
		// (get) Token: 0x0601DA10 RID: 121360 RVA: 0x00458056 File Offset: 0x00456256
		// (set) Token: 0x0601DA11 RID: 121361 RVA: 0x0045805E File Offset: 0x0045625E
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

		// Token: 0x170064DC RID: 25820
		// (get) Token: 0x0601DA12 RID: 121362 RVA: 0x00458067 File Offset: 0x00456267
		// (set) Token: 0x0601DA13 RID: 121363 RVA: 0x0045806F File Offset: 0x0045626F
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

		// Token: 0x170064DD RID: 25821
		// (get) Token: 0x0601DA14 RID: 121364 RVA: 0x00458078 File Offset: 0x00456278
		// (set) Token: 0x0601DA15 RID: 121365 RVA: 0x00458080 File Offset: 0x00456280
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

		// Token: 0x170064DE RID: 25822
		// (get) Token: 0x0601DA16 RID: 121366 RVA: 0x00458089 File Offset: 0x00456289
		// (set) Token: 0x0601DA17 RID: 121367 RVA: 0x00458091 File Offset: 0x00456291
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

		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x0601DA18 RID: 121368 RVA: 0x0045809A File Offset: 0x0045629A
		// (set) Token: 0x0601DA19 RID: 121369 RVA: 0x004580A2 File Offset: 0x004562A2
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

		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x0601DA1A RID: 121370 RVA: 0x004580AB File Offset: 0x004562AB
		// (set) Token: 0x0601DA1B RID: 121371 RVA: 0x004580B3 File Offset: 0x004562B3
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

		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x0601DA1C RID: 121372 RVA: 0x004580BC File Offset: 0x004562BC
		// (set) Token: 0x0601DA1D RID: 121373 RVA: 0x004580C4 File Offset: 0x004562C4
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

		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x0601DA1E RID: 121374 RVA: 0x004580CD File Offset: 0x004562CD
		// (set) Token: 0x0601DA1F RID: 121375 RVA: 0x004580D5 File Offset: 0x004562D5
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

		// Token: 0x170064E3 RID: 25827
		// (get) Token: 0x0601DA20 RID: 121376 RVA: 0x004580DE File Offset: 0x004562DE
		// (set) Token: 0x0601DA21 RID: 121377 RVA: 0x004580E6 File Offset: 0x004562E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DarkTideAttackValue
		{
			get
			{
				return this.darkTideAttackValue_;
			}
			set
			{
				this.darkTideAttackValue_ = value;
			}
		}

		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x0601DA22 RID: 121378 RVA: 0x004580EF File Offset: 0x004562EF
		// (set) Token: 0x0601DA23 RID: 121379 RVA: 0x004580F7 File Offset: 0x004562F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ADamageBonusRate2
		{
			get
			{
				return this.aDamageBonusRate2_;
			}
			set
			{
				this.aDamageBonusRate2_ = value;
			}
		}

		// Token: 0x0601DA24 RID: 121380 RVA: 0x00458100 File Offset: 0x00456300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DamageCalculationDetails);
		}

		// Token: 0x0601DA25 RID: 121381 RVA: 0x00458110 File Offset: 0x00456310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DamageCalculationDetails other)
		{
			return other != null && (other == this || (this.ABaseAttackValue == other.ABaseAttackValue && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VEffectiveDefense, other.VEffectiveDefense) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ADamageFactor, other.ADamageFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ADamageBonusRate, other.ADamageBonusRate) && this.ACritChance == other.ACritChance && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.AWeaknessMasteryCoefficient, other.AWeaknessMasteryCoefficient) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VMonsterTypeRate, other.VMonsterTypeRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ARate, other.ARate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VDefFactor, other.VDefFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VResistanceFactor, other.VResistanceFactor) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VbDamageReduce, other.VbDamageReduce) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.VbElementReduce, other.VbElementReduce) && this.AEnergyChange == other.AEnergyChange && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WeaknessLvValue, other.WeaknessLvValue) && this.VWeaknessBuffStack == other.VWeaknessBuffStack && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HitDamageBonusRate, other.HitDamageBonusRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.WeakDamageBonusRate, other.WeakDamageBonusRate) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ExceptedDamageValue, other.ExceptedDamageValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DarkTideAttackValue, other.DarkTideAttackValue) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ADamageBonusRate2, other.ADamageBonusRate2) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DA26 RID: 121382 RVA: 0x0045831C File Offset: 0x0045651C
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
			if (this.DarkTideAttackValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DarkTideAttackValue);
			}
			if (this.ADamageBonusRate2 != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ADamageBonusRate2);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DA27 RID: 121383 RVA: 0x004585A6 File Offset: 0x004567A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DA28 RID: 121384 RVA: 0x004585B3 File Offset: 0x004567B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DA29 RID: 121385 RVA: 0x004585BC File Offset: 0x004567BC
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
			if (this.DarkTideAttackValue != 0f)
			{
				output.WriteRawTag(157, 1);
				output.WriteFloat(this.DarkTideAttackValue);
			}
			if (this.ADamageBonusRate2 != 0f)
			{
				output.WriteRawTag(165, 1);
				output.WriteFloat(this.ADamageBonusRate2);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DA2A RID: 121386 RVA: 0x00458870 File Offset: 0x00456A70
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
			if (this.DarkTideAttackValue != 0f)
			{
				num += 6;
			}
			if (this.ADamageBonusRate2 != 0f)
			{
				num += 6;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DA2B RID: 121387 RVA: 0x00458A08 File Offset: 0x00456C08
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
			if (other.DarkTideAttackValue != 0f)
			{
				this.DarkTideAttackValue = other.DarkTideAttackValue;
			}
			if (other.ADamageBonusRate2 != 0f)
			{
				this.ADamageBonusRate2 = other.ADamageBonusRate2;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DA2C RID: 121388 RVA: 0x00458C10 File Offset: 0x00456E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DA2D RID: 121389 RVA: 0x00458C1C File Offset: 0x00456E1C
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
				if (num <= 85U)
				{
					if (num <= 40U)
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
							if (num == 40U)
							{
								this.ACritChance = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 61U)
					{
						if (num == 53U)
						{
							this.AWeaknessMasteryCoefficient = input.ReadFloat();
							continue;
						}
						if (num == 61U)
						{
							this.VMonsterTypeRate = input.ReadFloat();
							continue;
						}
					}
					else
					{
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
						if (num == 85U)
						{
							this.VResistanceFactor = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 120U)
				{
					if (num <= 101U)
					{
						if (num == 93U)
						{
							this.VbDamageReduce = input.ReadFloat();
							continue;
						}
						if (num == 101U)
						{
							this.VbElementReduce = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 104U)
						{
							this.AEnergyChange = input.ReadInt64();
							continue;
						}
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
				}
				else if (num <= 141U)
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
				}
				else
				{
					if (num == 149U)
					{
						this.ExceptedDamageValue = input.ReadFloat();
						continue;
					}
					if (num == 157U)
					{
						this.DarkTideAttackValue = input.ReadFloat();
						continue;
					}
					if (num == 165U)
					{
						this.ADamageBonusRate2 = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C897 RID: 51351
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C898 RID: 51352
		public const int ABaseAttackValueFieldNumber = 1;

		// Token: 0x0400C899 RID: 51353
		private long aBaseAttackValue_;

		// Token: 0x0400C89A RID: 51354
		public const int VEffectiveDefenseFieldNumber = 2;

		// Token: 0x0400C89B RID: 51355
		private float vEffectiveDefense_;

		// Token: 0x0400C89C RID: 51356
		public const int ADamageFactorFieldNumber = 3;

		// Token: 0x0400C89D RID: 51357
		private float aDamageFactor_;

		// Token: 0x0400C89E RID: 51358
		public const int ADamageBonusRateFieldNumber = 4;

		// Token: 0x0400C89F RID: 51359
		private float aDamageBonusRate_;

		// Token: 0x0400C8A0 RID: 51360
		public const int ACritChanceFieldNumber = 5;

		// Token: 0x0400C8A1 RID: 51361
		private long aCritChance_;

		// Token: 0x0400C8A2 RID: 51362
		public const int AWeaknessMasteryCoefficientFieldNumber = 6;

		// Token: 0x0400C8A3 RID: 51363
		private float aWeaknessMasteryCoefficient_;

		// Token: 0x0400C8A4 RID: 51364
		public const int VMonsterTypeRateFieldNumber = 7;

		// Token: 0x0400C8A5 RID: 51365
		private float vMonsterTypeRate_;

		// Token: 0x0400C8A6 RID: 51366
		public const int ARateFieldNumber = 8;

		// Token: 0x0400C8A7 RID: 51367
		private float aRate_;

		// Token: 0x0400C8A8 RID: 51368
		public const int VDefFactorFieldNumber = 9;

		// Token: 0x0400C8A9 RID: 51369
		private float vDefFactor_;

		// Token: 0x0400C8AA RID: 51370
		public const int VResistanceFactorFieldNumber = 10;

		// Token: 0x0400C8AB RID: 51371
		private float vResistanceFactor_;

		// Token: 0x0400C8AC RID: 51372
		public const int VbDamageReduceFieldNumber = 11;

		// Token: 0x0400C8AD RID: 51373
		private float vbDamageReduce_;

		// Token: 0x0400C8AE RID: 51374
		public const int VbElementReduceFieldNumber = 12;

		// Token: 0x0400C8AF RID: 51375
		private float vbElementReduce_;

		// Token: 0x0400C8B0 RID: 51376
		public const int AEnergyChangeFieldNumber = 13;

		// Token: 0x0400C8B1 RID: 51377
		private long aEnergyChange_;

		// Token: 0x0400C8B2 RID: 51378
		public const int WeaknessLvValueFieldNumber = 14;

		// Token: 0x0400C8B3 RID: 51379
		private float weaknessLvValue_;

		// Token: 0x0400C8B4 RID: 51380
		public const int VWeaknessBuffStackFieldNumber = 15;

		// Token: 0x0400C8B5 RID: 51381
		private int vWeaknessBuffStack_;

		// Token: 0x0400C8B6 RID: 51382
		public const int HitDamageBonusRateFieldNumber = 16;

		// Token: 0x0400C8B7 RID: 51383
		private float hitDamageBonusRate_;

		// Token: 0x0400C8B8 RID: 51384
		public const int WeakDamageBonusRateFieldNumber = 17;

		// Token: 0x0400C8B9 RID: 51385
		private float weakDamageBonusRate_;

		// Token: 0x0400C8BA RID: 51386
		public const int ExceptedDamageValueFieldNumber = 18;

		// Token: 0x0400C8BB RID: 51387
		private float exceptedDamageValue_;

		// Token: 0x0400C8BC RID: 51388
		public const int DarkTideAttackValueFieldNumber = 19;

		// Token: 0x0400C8BD RID: 51389
		private float darkTideAttackValue_;

		// Token: 0x0400C8BE RID: 51390
		public const int ADamageBonusRate2FieldNumber = 20;

		// Token: 0x0400C8BF RID: 51391
		private float aDamageBonusRate2_;
	}
}
