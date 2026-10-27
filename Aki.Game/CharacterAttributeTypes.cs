using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002EA7 RID: 11943
public class CharacterAttributeTypes : IStaticVariableResetter
{
	// Token: 0x06019816 RID: 104470 RVA: 0x0069538C File Offset: 0x0069358C
	static CharacterAttributeTypes()
	{
		EAttributeType[] array = new EAttributeType[5];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.7A8C53659DAEA03A0F1DCC578123D27F8B6457456D695A1E4C7037CC9247B374).FieldHandle);
		CharacterAttributeTypes.specialEnergyIds = new List<EAttributeType>(new <>z__ReadOnlyArray<EAttributeType>(array));
		EAttributeType[] array2 = new EAttributeType[6];
		RuntimeHelpers.InitializeArray(array2, fieldof(<PrivateImplementationDetails>.2C23178FC03C89FFD99D45EDEDC6C9A06CCF2BBB0FF7D2CEA81B762580E36C25).FieldHandle);
		CharacterAttributeTypes.energyAttrIds = array2;
		CharacterAttributeTypes.stateAttributeIds = new HashSet<EAttributeType>
		{
			EAttributeType.Life,
			EAttributeType.Strength,
			EAttributeType.Tough,
			EAttributeType.Rage,
			EAttributeType.Hardness,
			EAttributeType.Energy,
			EAttributeType.ElementPower1,
			EAttributeType.ElementPower2,
			EAttributeType.ElementPower3,
			EAttributeType.ElementPower4,
			EAttributeType.ElementPower5,
			EAttributeType.ElementPower6,
			EAttributeType.StatusBuildUp1,
			EAttributeType.StatusBuildUp2,
			EAttributeType.StatusBuildUp3,
			EAttributeType.StatusBuildUp4,
			EAttributeType.StatusBuildUp5,
			EAttributeType.ElementEnergy,
			EAttributeType.SpecialEnergy1,
			EAttributeType.SpecialEnergy2,
			EAttributeType.SpecialEnergy3,
			EAttributeType.SpecialEnergy4,
			EAttributeType.SpecialEnergy5,
			EAttributeType.ParalysisTime,
			EAttributeType.WeaknessBuildUp
		};
		CharacterAttributeTypes.attributeIdsWithMax = new Dictionary<EAttributeType, EAttributeType>
		{
			{
				EAttributeType.Life,
				EAttributeType.LifeMax
			},
			{
				EAttributeType.Strength,
				EAttributeType.StrengthMax
			},
			{
				EAttributeType.Tough,
				EAttributeType.ToughMax
			},
			{
				EAttributeType.Rage,
				EAttributeType.RageMax
			},
			{
				EAttributeType.Hardness,
				EAttributeType.HardnessMax
			},
			{
				EAttributeType.Energy,
				EAttributeType.EnergyMax
			},
			{
				EAttributeType.SpecialEnergy1,
				EAttributeType.SpecialEnergy1Max
			},
			{
				EAttributeType.SpecialEnergy2,
				EAttributeType.SpecialEnergy2Max
			},
			{
				EAttributeType.SpecialEnergy3,
				EAttributeType.SpecialEnergy3Max
			},
			{
				EAttributeType.SpecialEnergy4,
				EAttributeType.SpecialEnergy4Max
			},
			{
				EAttributeType.SpecialEnergy5,
				EAttributeType.SpecialEnergy5Max
			},
			{
				EAttributeType.StatusBuildUp1,
				EAttributeType.StatusBuildUp1Max
			},
			{
				EAttributeType.StatusBuildUp2,
				EAttributeType.StatusBuildUp2Max
			},
			{
				EAttributeType.StatusBuildUp3,
				EAttributeType.StatusBuildUp3Max
			},
			{
				EAttributeType.StatusBuildUp4,
				EAttributeType.StatusBuildUp4Max
			},
			{
				EAttributeType.StatusBuildUp5,
				EAttributeType.StatusBuildUp5Max
			},
			{
				EAttributeType.ElementEnergy,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower1,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower2,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower3,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower4,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower5,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ElementPower6,
				EAttributeType.ElementEnergyMax
			},
			{
				EAttributeType.ParalysisTime,
				EAttributeType.ParalysisTimeMax
			},
			{
				EAttributeType.WeaknessBuildUp,
				EAttributeType.WeaknessBuildUpMax
			}
		};
		EAttributeType[] array3 = new EAttributeType[18];
		RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.0C8F391E72E6A067C9D31CB621D2220C4B2E40D9441B83B97CAD43BFF3D0FE06).FieldHandle);
		CharacterAttributeTypes.attrsNotClampZero = array3;
		CharacterAttributeTypes.attrsCurrentValueClamp = new Dictionary<EAttributeType, int>
		{
			{
				EAttributeType.AutoAttackSpeed,
				20000
			},
			{
				EAttributeType.CastAttackSpeed,
				20000
			},
			{
				EAttributeType.DamageReduce,
				10000
			},
			{
				EAttributeType.DamageReducePhys,
				10000
			},
			{
				EAttributeType.DamageReduceElement1,
				10000
			},
			{
				EAttributeType.DamageReduceElement2,
				10000
			},
			{
				EAttributeType.DamageReduceElement3,
				10000
			},
			{
				EAttributeType.DamageReduceElement4,
				10000
			},
			{
				EAttributeType.DamageReduceElement5,
				10000
			},
			{
				EAttributeType.DamageReduceElement6,
				10000
			}
		};
		CharacterAttributeTypes.attrsAutoRecoverSpeedMap = new Dictionary<EAttributeType, EAttributeType>
		{
			{
				EAttributeType.Hardness,
				EAttributeType.HardnessRecover
			},
			{
				EAttributeType.Rage,
				EAttributeType.RageRecover
			},
			{
				EAttributeType.Tough,
				EAttributeType.ToughRecover
			},
			{
				EAttributeType.ParalysisTime,
				EAttributeType.ParalysisTimeRecover
			}
		};
		CharacterAttributeTypes.attrsAutoRecoverMaxMap = new Dictionary<EAttributeType, EAttributeType>
		{
			{
				EAttributeType.Hardness,
				EAttributeType.HardnessMax
			},
			{
				EAttributeType.Rage,
				EAttributeType.RageMax
			},
			{
				EAttributeType.Tough,
				EAttributeType.ToughMax
			},
			{
				EAttributeType.ParalysisTime,
				EAttributeType.ParalysisTimeMax
			}
		};
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterAttributeTypes.CreateStaticDefaultValue), new Action(CharacterAttributeTypes.ResetStaticDefaultValue));
	}

	// Token: 0x1700233D RID: 9021
	// (get) Token: 0x06019817 RID: 104471 RVA: 0x0069570C File Offset: 0x0069390C
	[Nullable(1)]
	public static Dictionary<EAttributeType, EAttributeType> AttributeIdsMaxToAttrId
	{
		[NullableContext(1)]
		get
		{
			return CharacterAttributeTypes._attributeIdsMaxToAttrId;
		}
	}

	// Token: 0x06019818 RID: 104472 RVA: 0x00695714 File Offset: 0x00693914
	public static void CreateStaticDefaultValue()
	{
		CharacterAttributeTypes._attributeIdsMaxToAttrId = new Dictionary<EAttributeType, EAttributeType>();
		foreach (KeyValuePair<EAttributeType, EAttributeType> keyValuePair in CharacterAttributeTypes.attributeIdsWithMax)
		{
			CharacterAttributeTypes.AttributeIdsMaxToAttrId[keyValuePair.Value] = keyValuePair.Key;
		}
	}

	// Token: 0x06019819 RID: 104473 RVA: 0x00695784 File Offset: 0x00693984
	public static void ResetStaticDefaultValue()
	{
		CharacterAttributeTypes._attributeIdsMaxToAttrId = null;
	}

	// Token: 0x0400BE4B RID: 48715
	public const int ATTRIBUTE_ID_MAX = 143;

	// Token: 0x0400BE4C RID: 48716
	public const int PER_TEN_THOUSAND = 10000;

	// Token: 0x0400BE4D RID: 48717
	public const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400BE4E RID: 48718
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly List<EAttributeType> specialEnergyIds;

	// Token: 0x0400BE4F RID: 48719
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EAttributeType[] energyAttrIds;

	// Token: 0x0400BE50 RID: 48720
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EAttributeType> stateAttributeIds;

	// Token: 0x0400BE51 RID: 48721
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attributeIdsWithMax;

	// Token: 0x0400BE52 RID: 48722
	[Nullable(2)]
	private static Dictionary<EAttributeType, EAttributeType> _attributeIdsMaxToAttrId;

	// Token: 0x0400BE53 RID: 48723
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EAttributeType[] attrsNotClampZero;

	// Token: 0x0400BE54 RID: 48724
	private const int ATTACK_SPEED_MAX = 20000;

	// Token: 0x0400BE55 RID: 48725
	private const int REDUCE_MAX = 10000;

	// Token: 0x0400BE56 RID: 48726
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, int> attrsCurrentValueClamp;

	// Token: 0x0400BE57 RID: 48727
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attrsAutoRecoverSpeedMap;

	// Token: 0x0400BE58 RID: 48728
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attrsAutoRecoverMaxMap;

	// Token: 0x020095DA RID: 38362
	public interface IModifier
	{
		// Token: 0x1700A0C2 RID: 41154
		// (get) Token: 0x0604C0BD RID: 311485
		ECalculationPolicyType Type { get; }
	}

	// Token: 0x020095DB RID: 38363
	public interface IAddValueModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0C3 RID: 41155
		// (get) Token: 0x0604C0BE RID: 311486
		float Value1 { get; }
	}

	// Token: 0x020095DC RID: 38364
	public interface IAddRateModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0C4 RID: 41156
		// (get) Token: 0x0604C0BF RID: 311487
		float Value1 { get; }
	}

	// Token: 0x020095DD RID: 38365
	public interface IAddFromAttrModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0C5 RID: 41157
		// (get) Token: 0x0604C0C0 RID: 311488
		// (set) Token: 0x0604C0C1 RID: 311489
		EAttributeType SourceAttributeId { get; set; }

		// Token: 0x1700A0C6 RID: 41158
		// (get) Token: 0x0604C0C2 RID: 311490
		// (set) Token: 0x0604C0C3 RID: 311491
		long SourceEntity { get; set; }

		// Token: 0x1700A0C7 RID: 41159
		// (get) Token: 0x0604C0C4 RID: 311492
		// (set) Token: 0x0604C0C5 RID: 311493
		EAttributeBasedFloatCalculationType SourceCalculationType { get; set; }

		// Token: 0x1700A0C8 RID: 41160
		// (get) Token: 0x0604C0C6 RID: 311494
		// (set) Token: 0x0604C0C7 RID: 311495
		float? SnapshotSource { get; set; }

		// Token: 0x1700A0C9 RID: 41161
		// (get) Token: 0x0604C0C8 RID: 311496
		// (set) Token: 0x0604C0C9 RID: 311497
		float? Min { get; set; }

		// Token: 0x1700A0CA RID: 41162
		// (get) Token: 0x0604C0CA RID: 311498
		// (set) Token: 0x0604C0CB RID: 311499
		float? Ratio { get; set; }

		// Token: 0x1700A0CB RID: 41163
		// (get) Token: 0x0604C0CC RID: 311500
		// (set) Token: 0x0604C0CD RID: 311501
		float? Max { get; set; }

		// Token: 0x1700A0CC RID: 41164
		// (get) Token: 0x0604C0CE RID: 311502
		// (set) Token: 0x0604C0CF RID: 311503
		bool FloorAfterRatio { get; set; }

		// Token: 0x1700A0CD RID: 41165
		// (get) Token: 0x0604C0D0 RID: 311504
		// (set) Token: 0x0604C0D1 RID: 311505
		float Value1 { get; set; }

		// Token: 0x1700A0CE RID: 41166
		// (get) Token: 0x0604C0D2 RID: 311506
		// (set) Token: 0x0604C0D3 RID: 311507
		float Value2 { get; set; }
	}

	// Token: 0x020095DE RID: 38366
	public interface IAddFromAttrRateModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0CF RID: 41167
		// (get) Token: 0x0604C0D4 RID: 311508
		EAttributeType SourceAttributeId { get; }

		// Token: 0x1700A0D0 RID: 41168
		// (get) Token: 0x0604C0D5 RID: 311509
		long SourceEntity { get; }

		// Token: 0x1700A0D1 RID: 41169
		// (get) Token: 0x0604C0D6 RID: 311510
		EAttributeBasedFloatCalculationType SourceCalculationType { get; }

		// Token: 0x1700A0D2 RID: 41170
		// (get) Token: 0x0604C0D7 RID: 311511
		int? SnapshotSource { get; }

		// Token: 0x1700A0D3 RID: 41171
		// (get) Token: 0x0604C0D8 RID: 311512
		float? Min { get; }

		// Token: 0x1700A0D4 RID: 41172
		// (get) Token: 0x0604C0D9 RID: 311513
		float? Ratio { get; }

		// Token: 0x1700A0D5 RID: 41173
		// (get) Token: 0x0604C0DA RID: 311514
		float? Max { get; }

		// Token: 0x1700A0D6 RID: 41174
		// (get) Token: 0x0604C0DB RID: 311515
		bool FloorAfterRatio { get; }

		// Token: 0x1700A0D7 RID: 41175
		// (get) Token: 0x0604C0DC RID: 311516
		float Value1 { get; }
	}

	// Token: 0x020095DF RID: 38367
	public interface IOverrideValue : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0D8 RID: 41176
		// (get) Token: 0x0604C0DD RID: 311517
		float Value1 { get; }
	}

	// Token: 0x020095E0 RID: 38368
	public interface IOverrideFromAttrModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0D9 RID: 41177
		// (get) Token: 0x0604C0DE RID: 311518
		// (set) Token: 0x0604C0DF RID: 311519
		EAttributeType? SourceAttributeId { get; set; }

		// Token: 0x1700A0DA RID: 41178
		// (get) Token: 0x0604C0E0 RID: 311520
		// (set) Token: 0x0604C0E1 RID: 311521
		long SourceEntity { get; set; }

		// Token: 0x1700A0DB RID: 41179
		// (get) Token: 0x0604C0E2 RID: 311522
		// (set) Token: 0x0604C0E3 RID: 311523
		EAttributeBasedFloatCalculationType? SourceCalculationType { get; set; }

		// Token: 0x1700A0DC RID: 41180
		// (get) Token: 0x0604C0E4 RID: 311524
		// (set) Token: 0x0604C0E5 RID: 311525
		float? SnapshotSource { get; set; }

		// Token: 0x1700A0DD RID: 41181
		// (get) Token: 0x0604C0E6 RID: 311526
		// (set) Token: 0x0604C0E7 RID: 311527
		float? Min { get; set; }

		// Token: 0x1700A0DE RID: 41182
		// (get) Token: 0x0604C0E8 RID: 311528
		// (set) Token: 0x0604C0E9 RID: 311529
		float? Ratio { get; set; }

		// Token: 0x1700A0DF RID: 41183
		// (get) Token: 0x0604C0EA RID: 311530
		// (set) Token: 0x0604C0EB RID: 311531
		float? Max { get; set; }

		// Token: 0x1700A0E0 RID: 41184
		// (get) Token: 0x0604C0EC RID: 311532
		// (set) Token: 0x0604C0ED RID: 311533
		bool FloorAfterRatio { get; set; }

		// Token: 0x1700A0E1 RID: 41185
		// (get) Token: 0x0604C0EE RID: 311534
		// (set) Token: 0x0604C0EF RID: 311535
		float Value1 { get; set; }

		// Token: 0x1700A0E2 RID: 41186
		// (get) Token: 0x0604C0F0 RID: 311536
		// (set) Token: 0x0604C0F1 RID: 311537
		float Value2 { get; set; }
	}

	// Token: 0x020095E1 RID: 38369
	public class OverrideFromAttrModifier : CharacterAttributeTypes.IOverrideFromAttrModifier, CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0E3 RID: 41187
		// (get) Token: 0x0604C0F2 RID: 311538 RVA: 0x0140D783 File Offset: 0x0140B983
		// (set) Token: 0x0604C0F3 RID: 311539 RVA: 0x0140D78B File Offset: 0x0140B98B
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x1700A0E4 RID: 41188
		// (get) Token: 0x0604C0F4 RID: 311540 RVA: 0x0140D794 File Offset: 0x0140B994
		// (set) Token: 0x0604C0F5 RID: 311541 RVA: 0x0140D79C File Offset: 0x0140B99C
		public EAttributeType? SourceAttributeId { get; set; }

		// Token: 0x1700A0E5 RID: 41189
		// (get) Token: 0x0604C0F6 RID: 311542 RVA: 0x0140D7A5 File Offset: 0x0140B9A5
		// (set) Token: 0x0604C0F7 RID: 311543 RVA: 0x0140D7AD File Offset: 0x0140B9AD
		public long SourceEntity { get; set; }

		// Token: 0x1700A0E6 RID: 41190
		// (get) Token: 0x0604C0F8 RID: 311544 RVA: 0x0140D7B6 File Offset: 0x0140B9B6
		// (set) Token: 0x0604C0F9 RID: 311545 RVA: 0x0140D7BE File Offset: 0x0140B9BE
		public EAttributeBasedFloatCalculationType? SourceCalculationType { get; set; }

		// Token: 0x1700A0E7 RID: 41191
		// (get) Token: 0x0604C0FA RID: 311546 RVA: 0x0140D7C7 File Offset: 0x0140B9C7
		// (set) Token: 0x0604C0FB RID: 311547 RVA: 0x0140D7CF File Offset: 0x0140B9CF
		public float? SnapshotSource { get; set; }

		// Token: 0x1700A0E8 RID: 41192
		// (get) Token: 0x0604C0FC RID: 311548 RVA: 0x0140D7D8 File Offset: 0x0140B9D8
		// (set) Token: 0x0604C0FD RID: 311549 RVA: 0x0140D7E0 File Offset: 0x0140B9E0
		public float? Min { get; set; }

		// Token: 0x1700A0E9 RID: 41193
		// (get) Token: 0x0604C0FE RID: 311550 RVA: 0x0140D7E9 File Offset: 0x0140B9E9
		// (set) Token: 0x0604C0FF RID: 311551 RVA: 0x0140D7F1 File Offset: 0x0140B9F1
		public float? Ratio { get; set; }

		// Token: 0x1700A0EA RID: 41194
		// (get) Token: 0x0604C100 RID: 311552 RVA: 0x0140D7FA File Offset: 0x0140B9FA
		// (set) Token: 0x0604C101 RID: 311553 RVA: 0x0140D802 File Offset: 0x0140BA02
		public float? Max { get; set; }

		// Token: 0x1700A0EB RID: 41195
		// (get) Token: 0x0604C102 RID: 311554 RVA: 0x0140D80B File Offset: 0x0140BA0B
		// (set) Token: 0x0604C103 RID: 311555 RVA: 0x0140D813 File Offset: 0x0140BA13
		public bool FloorAfterRatio { get; set; }

		// Token: 0x1700A0EC RID: 41196
		// (get) Token: 0x0604C104 RID: 311556 RVA: 0x0140D81C File Offset: 0x0140BA1C
		// (set) Token: 0x0604C105 RID: 311557 RVA: 0x0140D824 File Offset: 0x0140BA24
		public float Value1 { get; set; }

		// Token: 0x1700A0ED RID: 41197
		// (get) Token: 0x0604C106 RID: 311558 RVA: 0x0140D82D File Offset: 0x0140BA2D
		// (set) Token: 0x0604C107 RID: 311559 RVA: 0x0140D835 File Offset: 0x0140BA35
		public float Value2 { get; set; }
	}

	// Token: 0x020095E2 RID: 38370
	public interface IMultiplyMagnitude1Modifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0EE RID: 41198
		// (get) Token: 0x0604C109 RID: 311561
		// (set) Token: 0x0604C10A RID: 311562
		float Value1 { get; set; }
	}

	// Token: 0x020095E3 RID: 38371
	public class MultiplyMagnitude1Modifier : CharacterAttributeTypes.IMultiplyMagnitude1Modifier, CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700A0EF RID: 41199
		// (get) Token: 0x0604C10B RID: 311563 RVA: 0x0140D846 File Offset: 0x0140BA46
		// (set) Token: 0x0604C10C RID: 311564 RVA: 0x0140D84E File Offset: 0x0140BA4E
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x1700A0F0 RID: 41200
		// (get) Token: 0x0604C10D RID: 311565 RVA: 0x0140D857 File Offset: 0x0140BA57
		// (set) Token: 0x0604C10E RID: 311566 RVA: 0x0140D85F File Offset: 0x0140BA5F
		public float Value1 { get; set; }
	}

	// Token: 0x020095E4 RID: 38372
	public class AttributeModifier : CharacterAttributeTypes.IModifier, CharacterAttributeTypes.IAddValueModifier, CharacterAttributeTypes.IAddRateModifier, CharacterAttributeTypes.IAddFromAttrModifier, CharacterAttributeTypes.IAddFromAttrRateModifier, CharacterAttributeTypes.IOverrideValue, CharacterAttributeTypes.IOverrideFromAttrModifier, CharacterAttributeTypes.IMultiplyMagnitude1Modifier
	{
		// Token: 0x1700A0F1 RID: 41201
		// (get) Token: 0x0604C110 RID: 311568 RVA: 0x0140D870 File Offset: 0x0140BA70
		// (set) Token: 0x0604C111 RID: 311569 RVA: 0x0140D878 File Offset: 0x0140BA78
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x1700A0F2 RID: 41202
		// (get) Token: 0x0604C112 RID: 311570 RVA: 0x0140D881 File Offset: 0x0140BA81
		// (set) Token: 0x0604C113 RID: 311571 RVA: 0x0140D889 File Offset: 0x0140BA89
		public float Value1 { get; set; }

		// Token: 0x1700A0F3 RID: 41203
		// (get) Token: 0x0604C114 RID: 311572 RVA: 0x0140D892 File Offset: 0x0140BA92
		// (set) Token: 0x0604C115 RID: 311573 RVA: 0x0140D89A File Offset: 0x0140BA9A
		public float Value2 { get; set; }

		// Token: 0x1700A0F4 RID: 41204
		// (get) Token: 0x0604C116 RID: 311574 RVA: 0x0140D8A3 File Offset: 0x0140BAA3
		// (set) Token: 0x0604C117 RID: 311575 RVA: 0x0140D8AB File Offset: 0x0140BAAB
		public long SourceEntity { get; set; }

		// Token: 0x1700A0F5 RID: 41205
		// (get) Token: 0x0604C118 RID: 311576 RVA: 0x0140D8B4 File Offset: 0x0140BAB4
		// (set) Token: 0x0604C119 RID: 311577 RVA: 0x0140D8BC File Offset: 0x0140BABC
		public EAttributeType SourceAttributeId { get; set; }

		// Token: 0x1700A0F6 RID: 41206
		// (get) Token: 0x0604C11A RID: 311578 RVA: 0x0140D8C5 File Offset: 0x0140BAC5
		// (set) Token: 0x0604C11B RID: 311579 RVA: 0x0140D8CD File Offset: 0x0140BACD
		public EAttributeBasedFloatCalculationType SourceCalculationType { get; set; }

		// Token: 0x1700A0F7 RID: 41207
		// (get) Token: 0x0604C11C RID: 311580 RVA: 0x0140D8D6 File Offset: 0x0140BAD6
		// (set) Token: 0x0604C11D RID: 311581 RVA: 0x0140D8DE File Offset: 0x0140BADE
		public float? SnapshotSource { get; set; }

		// Token: 0x1700A0F8 RID: 41208
		// (get) Token: 0x0604C11E RID: 311582 RVA: 0x0140D8E7 File Offset: 0x0140BAE7
		// (set) Token: 0x0604C11F RID: 311583 RVA: 0x0140D8EF File Offset: 0x0140BAEF
		public float? Min { get; set; }

		// Token: 0x1700A0F9 RID: 41209
		// (get) Token: 0x0604C120 RID: 311584 RVA: 0x0140D8F8 File Offset: 0x0140BAF8
		// (set) Token: 0x0604C121 RID: 311585 RVA: 0x0140D900 File Offset: 0x0140BB00
		public float? Ratio { get; set; }

		// Token: 0x1700A0FA RID: 41210
		// (get) Token: 0x0604C122 RID: 311586 RVA: 0x0140D909 File Offset: 0x0140BB09
		// (set) Token: 0x0604C123 RID: 311587 RVA: 0x0140D911 File Offset: 0x0140BB11
		public float? Max { get; set; }

		// Token: 0x1700A0FB RID: 41211
		// (get) Token: 0x0604C124 RID: 311588 RVA: 0x0140D91A File Offset: 0x0140BB1A
		// (set) Token: 0x0604C125 RID: 311589 RVA: 0x0140D922 File Offset: 0x0140BB22
		public bool FloorAfterRatio { get; set; }

		// Token: 0x1700A0FC RID: 41212
		// (get) Token: 0x0604C126 RID: 311590 RVA: 0x0140D92B File Offset: 0x0140BB2B
		EAttributeType CharacterAttributeTypes.IAddFromAttrRateModifier.SourceAttributeId
		{
			get
			{
				return this.SourceAttributeId;
			}
		}

		// Token: 0x1700A0FD RID: 41213
		// (get) Token: 0x0604C127 RID: 311591 RVA: 0x0140D933 File Offset: 0x0140BB33
		long CharacterAttributeTypes.IAddFromAttrRateModifier.SourceEntity
		{
			get
			{
				return this.SourceEntity;
			}
		}

		// Token: 0x1700A0FE RID: 41214
		// (get) Token: 0x0604C128 RID: 311592 RVA: 0x0140D93B File Offset: 0x0140BB3B
		EAttributeBasedFloatCalculationType CharacterAttributeTypes.IAddFromAttrRateModifier.SourceCalculationType
		{
			get
			{
				return this.SourceCalculationType;
			}
		}

		// Token: 0x1700A0FF RID: 41215
		// (get) Token: 0x0604C129 RID: 311593 RVA: 0x0140D944 File Offset: 0x0140BB44
		int? CharacterAttributeTypes.IAddFromAttrRateModifier.SnapshotSource
		{
			get
			{
				if (this.SnapshotSource == null)
				{
					return null;
				}
				return new int?((int)this.SnapshotSource.Value);
			}
		}

		// Token: 0x1700A100 RID: 41216
		// (get) Token: 0x0604C12A RID: 311594 RVA: 0x0140D97F File Offset: 0x0140BB7F
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Min
		{
			get
			{
				return this.Min;
			}
		}

		// Token: 0x1700A101 RID: 41217
		// (get) Token: 0x0604C12B RID: 311595 RVA: 0x0140D987 File Offset: 0x0140BB87
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Ratio
		{
			get
			{
				return this.Ratio;
			}
		}

		// Token: 0x1700A102 RID: 41218
		// (get) Token: 0x0604C12C RID: 311596 RVA: 0x0140D98F File Offset: 0x0140BB8F
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Max
		{
			get
			{
				return this.Max;
			}
		}

		// Token: 0x1700A103 RID: 41219
		// (get) Token: 0x0604C12D RID: 311597 RVA: 0x0140D997 File Offset: 0x0140BB97
		float CharacterAttributeTypes.IAddFromAttrRateModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x1700A104 RID: 41220
		// (get) Token: 0x0604C12E RID: 311598 RVA: 0x0140D99F File Offset: 0x0140BB9F
		float CharacterAttributeTypes.IAddValueModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x1700A105 RID: 41221
		// (get) Token: 0x0604C12F RID: 311599 RVA: 0x0140D9A7 File Offset: 0x0140BBA7
		float CharacterAttributeTypes.IAddRateModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x1700A106 RID: 41222
		// (get) Token: 0x0604C130 RID: 311600 RVA: 0x0140D9AF File Offset: 0x0140BBAF
		float CharacterAttributeTypes.IOverrideValue.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x1700A107 RID: 41223
		// (get) Token: 0x0604C131 RID: 311601 RVA: 0x0140D9B7 File Offset: 0x0140BBB7
		// (set) Token: 0x0604C132 RID: 311602 RVA: 0x0140D9C4 File Offset: 0x0140BBC4
		EAttributeType? CharacterAttributeTypes.IOverrideFromAttrModifier.SourceAttributeId
		{
			get
			{
				return new EAttributeType?(this.SourceAttributeId);
			}
			set
			{
				this.SourceAttributeId = value.GetValueOrDefault();
			}
		}

		// Token: 0x1700A108 RID: 41224
		// (get) Token: 0x0604C133 RID: 311603 RVA: 0x0140D9D3 File Offset: 0x0140BBD3
		// (set) Token: 0x0604C134 RID: 311604 RVA: 0x0140D9E0 File Offset: 0x0140BBE0
		EAttributeBasedFloatCalculationType? CharacterAttributeTypes.IOverrideFromAttrModifier.SourceCalculationType
		{
			get
			{
				return new EAttributeBasedFloatCalculationType?(this.SourceCalculationType);
			}
			set
			{
				this.SourceCalculationType = value.GetValueOrDefault();
			}
		}
	}

	// Token: 0x020095E5 RID: 38373
	// (Invoke) Token: 0x0604C137 RID: 311607
	public delegate void AttributeChangeListener(EAttributeType attrId, float newValue, float oldValue);
}
