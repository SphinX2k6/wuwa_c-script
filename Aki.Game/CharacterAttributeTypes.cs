using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023FA RID: 9210
public class CharacterAttributeTypes : IStaticVariableResetter
{
	// Token: 0x060170F6 RID: 94454 RVA: 0x006BB75C File Offset: 0x006B995C
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

	// Token: 0x170023D3 RID: 9171
	// (get) Token: 0x060170F7 RID: 94455 RVA: 0x006BBADC File Offset: 0x006B9CDC
	[Nullable(1)]
	public static Dictionary<EAttributeType, EAttributeType> AttributeIdsMaxToAttrId
	{
		[NullableContext(1)]
		get
		{
			return CharacterAttributeTypes._attributeIdsMaxToAttrId;
		}
	}

	// Token: 0x060170F8 RID: 94456 RVA: 0x006BBAE4 File Offset: 0x006B9CE4
	public static void CreateStaticDefaultValue()
	{
		CharacterAttributeTypes._attributeIdsMaxToAttrId = new Dictionary<EAttributeType, EAttributeType>();
		foreach (KeyValuePair<EAttributeType, EAttributeType> keyValuePair in CharacterAttributeTypes.attributeIdsWithMax)
		{
			CharacterAttributeTypes.AttributeIdsMaxToAttrId[keyValuePair.Value] = keyValuePair.Key;
		}
	}

	// Token: 0x060170F9 RID: 94457 RVA: 0x006BBB54 File Offset: 0x006B9D54
	public static void ResetStaticDefaultValue()
	{
		CharacterAttributeTypes._attributeIdsMaxToAttrId = null;
	}

	// Token: 0x0400C1E6 RID: 49638
	public const int ATTRIBUTE_ID_MAX = 143;

	// Token: 0x0400C1E7 RID: 49639
	public const int PER_TEN_THOUSAND = 10000;

	// Token: 0x0400C1E8 RID: 49640
	public const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400C1E9 RID: 49641
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly List<EAttributeType> specialEnergyIds;

	// Token: 0x0400C1EA RID: 49642
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EAttributeType[] energyAttrIds;

	// Token: 0x0400C1EB RID: 49643
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EAttributeType> stateAttributeIds;

	// Token: 0x0400C1EC RID: 49644
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attributeIdsWithMax;

	// Token: 0x0400C1ED RID: 49645
	[Nullable(2)]
	private static Dictionary<EAttributeType, EAttributeType> _attributeIdsMaxToAttrId;

	// Token: 0x0400C1EE RID: 49646
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly EAttributeType[] attrsNotClampZero;

	// Token: 0x0400C1EF RID: 49647
	private const int ATTACK_SPEED_MAX = 20000;

	// Token: 0x0400C1F0 RID: 49648
	private const int REDUCE_MAX = 10000;

	// Token: 0x0400C1F1 RID: 49649
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, int> attrsCurrentValueClamp;

	// Token: 0x0400C1F2 RID: 49650
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attrsAutoRecoverSpeedMap;

	// Token: 0x0400C1F3 RID: 49651
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EAttributeType, EAttributeType> attrsAutoRecoverMaxMap;

	// Token: 0x02008802 RID: 34818
	public interface IModifier
	{
		// Token: 0x17007851 RID: 30801
		// (get) Token: 0x06042556 RID: 271702
		ECalculationPolicyType Type { get; }
	}

	// Token: 0x02008803 RID: 34819
	public interface IAddValueModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007852 RID: 30802
		// (get) Token: 0x06042557 RID: 271703
		float Value1 { get; }
	}

	// Token: 0x02008804 RID: 34820
	public interface IAddRateModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007853 RID: 30803
		// (get) Token: 0x06042558 RID: 271704
		float Value1 { get; }
	}

	// Token: 0x02008805 RID: 34821
	public interface IAddFromAttrModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007854 RID: 30804
		// (get) Token: 0x06042559 RID: 271705
		// (set) Token: 0x0604255A RID: 271706
		EAttributeType SourceAttributeId { get; set; }

		// Token: 0x17007855 RID: 30805
		// (get) Token: 0x0604255B RID: 271707
		// (set) Token: 0x0604255C RID: 271708
		long SourceEntity { get; set; }

		// Token: 0x17007856 RID: 30806
		// (get) Token: 0x0604255D RID: 271709
		// (set) Token: 0x0604255E RID: 271710
		EAttributeBasedFloatCalculationType SourceCalculationType { get; set; }

		// Token: 0x17007857 RID: 30807
		// (get) Token: 0x0604255F RID: 271711
		// (set) Token: 0x06042560 RID: 271712
		float? SnapshotSource { get; set; }

		// Token: 0x17007858 RID: 30808
		// (get) Token: 0x06042561 RID: 271713
		// (set) Token: 0x06042562 RID: 271714
		float? Min { get; set; }

		// Token: 0x17007859 RID: 30809
		// (get) Token: 0x06042563 RID: 271715
		// (set) Token: 0x06042564 RID: 271716
		float? Ratio { get; set; }

		// Token: 0x1700785A RID: 30810
		// (get) Token: 0x06042565 RID: 271717
		// (set) Token: 0x06042566 RID: 271718
		float? Max { get; set; }

		// Token: 0x1700785B RID: 30811
		// (get) Token: 0x06042567 RID: 271719
		// (set) Token: 0x06042568 RID: 271720
		bool FloorAfterRatio { get; set; }

		// Token: 0x1700785C RID: 30812
		// (get) Token: 0x06042569 RID: 271721
		// (set) Token: 0x0604256A RID: 271722
		float Value1 { get; set; }

		// Token: 0x1700785D RID: 30813
		// (get) Token: 0x0604256B RID: 271723
		// (set) Token: 0x0604256C RID: 271724
		float Value2 { get; set; }
	}

	// Token: 0x02008806 RID: 34822
	public interface IAddFromAttrRateModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700785E RID: 30814
		// (get) Token: 0x0604256D RID: 271725
		EAttributeType SourceAttributeId { get; }

		// Token: 0x1700785F RID: 30815
		// (get) Token: 0x0604256E RID: 271726
		long SourceEntity { get; }

		// Token: 0x17007860 RID: 30816
		// (get) Token: 0x0604256F RID: 271727
		EAttributeBasedFloatCalculationType SourceCalculationType { get; }

		// Token: 0x17007861 RID: 30817
		// (get) Token: 0x06042570 RID: 271728
		int? SnapshotSource { get; }

		// Token: 0x17007862 RID: 30818
		// (get) Token: 0x06042571 RID: 271729
		float? Min { get; }

		// Token: 0x17007863 RID: 30819
		// (get) Token: 0x06042572 RID: 271730
		float? Ratio { get; }

		// Token: 0x17007864 RID: 30820
		// (get) Token: 0x06042573 RID: 271731
		float? Max { get; }

		// Token: 0x17007865 RID: 30821
		// (get) Token: 0x06042574 RID: 271732
		bool FloorAfterRatio { get; }

		// Token: 0x17007866 RID: 30822
		// (get) Token: 0x06042575 RID: 271733
		float Value1 { get; }
	}

	// Token: 0x02008807 RID: 34823
	public interface IOverrideValue : CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007867 RID: 30823
		// (get) Token: 0x06042576 RID: 271734
		float Value1 { get; }
	}

	// Token: 0x02008808 RID: 34824
	public interface IOverrideFromAttrModifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007868 RID: 30824
		// (get) Token: 0x06042577 RID: 271735
		// (set) Token: 0x06042578 RID: 271736
		EAttributeType? SourceAttributeId { get; set; }

		// Token: 0x17007869 RID: 30825
		// (get) Token: 0x06042579 RID: 271737
		// (set) Token: 0x0604257A RID: 271738
		long SourceEntity { get; set; }

		// Token: 0x1700786A RID: 30826
		// (get) Token: 0x0604257B RID: 271739
		// (set) Token: 0x0604257C RID: 271740
		EAttributeBasedFloatCalculationType? SourceCalculationType { get; set; }

		// Token: 0x1700786B RID: 30827
		// (get) Token: 0x0604257D RID: 271741
		// (set) Token: 0x0604257E RID: 271742
		float? SnapshotSource { get; set; }

		// Token: 0x1700786C RID: 30828
		// (get) Token: 0x0604257F RID: 271743
		// (set) Token: 0x06042580 RID: 271744
		float? Min { get; set; }

		// Token: 0x1700786D RID: 30829
		// (get) Token: 0x06042581 RID: 271745
		// (set) Token: 0x06042582 RID: 271746
		float? Ratio { get; set; }

		// Token: 0x1700786E RID: 30830
		// (get) Token: 0x06042583 RID: 271747
		// (set) Token: 0x06042584 RID: 271748
		float? Max { get; set; }

		// Token: 0x1700786F RID: 30831
		// (get) Token: 0x06042585 RID: 271749
		// (set) Token: 0x06042586 RID: 271750
		bool FloorAfterRatio { get; set; }

		// Token: 0x17007870 RID: 30832
		// (get) Token: 0x06042587 RID: 271751
		// (set) Token: 0x06042588 RID: 271752
		float Value1 { get; set; }

		// Token: 0x17007871 RID: 30833
		// (get) Token: 0x06042589 RID: 271753
		// (set) Token: 0x0604258A RID: 271754
		float Value2 { get; set; }
	}

	// Token: 0x02008809 RID: 34825
	public class OverrideFromAttrModifier : CharacterAttributeTypes.IOverrideFromAttrModifier, CharacterAttributeTypes.IModifier
	{
		// Token: 0x17007872 RID: 30834
		// (get) Token: 0x0604258B RID: 271755 RVA: 0x013B8354 File Offset: 0x013B6554
		// (set) Token: 0x0604258C RID: 271756 RVA: 0x013B835C File Offset: 0x013B655C
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x17007873 RID: 30835
		// (get) Token: 0x0604258D RID: 271757 RVA: 0x013B8365 File Offset: 0x013B6565
		// (set) Token: 0x0604258E RID: 271758 RVA: 0x013B836D File Offset: 0x013B656D
		public EAttributeType? SourceAttributeId { get; set; }

		// Token: 0x17007874 RID: 30836
		// (get) Token: 0x0604258F RID: 271759 RVA: 0x013B8376 File Offset: 0x013B6576
		// (set) Token: 0x06042590 RID: 271760 RVA: 0x013B837E File Offset: 0x013B657E
		public long SourceEntity { get; set; }

		// Token: 0x17007875 RID: 30837
		// (get) Token: 0x06042591 RID: 271761 RVA: 0x013B8387 File Offset: 0x013B6587
		// (set) Token: 0x06042592 RID: 271762 RVA: 0x013B838F File Offset: 0x013B658F
		public EAttributeBasedFloatCalculationType? SourceCalculationType { get; set; }

		// Token: 0x17007876 RID: 30838
		// (get) Token: 0x06042593 RID: 271763 RVA: 0x013B8398 File Offset: 0x013B6598
		// (set) Token: 0x06042594 RID: 271764 RVA: 0x013B83A0 File Offset: 0x013B65A0
		public float? SnapshotSource { get; set; }

		// Token: 0x17007877 RID: 30839
		// (get) Token: 0x06042595 RID: 271765 RVA: 0x013B83A9 File Offset: 0x013B65A9
		// (set) Token: 0x06042596 RID: 271766 RVA: 0x013B83B1 File Offset: 0x013B65B1
		public float? Min { get; set; }

		// Token: 0x17007878 RID: 30840
		// (get) Token: 0x06042597 RID: 271767 RVA: 0x013B83BA File Offset: 0x013B65BA
		// (set) Token: 0x06042598 RID: 271768 RVA: 0x013B83C2 File Offset: 0x013B65C2
		public float? Ratio { get; set; }

		// Token: 0x17007879 RID: 30841
		// (get) Token: 0x06042599 RID: 271769 RVA: 0x013B83CB File Offset: 0x013B65CB
		// (set) Token: 0x0604259A RID: 271770 RVA: 0x013B83D3 File Offset: 0x013B65D3
		public float? Max { get; set; }

		// Token: 0x1700787A RID: 30842
		// (get) Token: 0x0604259B RID: 271771 RVA: 0x013B83DC File Offset: 0x013B65DC
		// (set) Token: 0x0604259C RID: 271772 RVA: 0x013B83E4 File Offset: 0x013B65E4
		public bool FloorAfterRatio { get; set; }

		// Token: 0x1700787B RID: 30843
		// (get) Token: 0x0604259D RID: 271773 RVA: 0x013B83ED File Offset: 0x013B65ED
		// (set) Token: 0x0604259E RID: 271774 RVA: 0x013B83F5 File Offset: 0x013B65F5
		public float Value1 { get; set; }

		// Token: 0x1700787C RID: 30844
		// (get) Token: 0x0604259F RID: 271775 RVA: 0x013B83FE File Offset: 0x013B65FE
		// (set) Token: 0x060425A0 RID: 271776 RVA: 0x013B8406 File Offset: 0x013B6606
		public float Value2 { get; set; }
	}

	// Token: 0x0200880A RID: 34826
	public interface IMultiplyMagnitude1Modifier : CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700787D RID: 30845
		// (get) Token: 0x060425A2 RID: 271778
		// (set) Token: 0x060425A3 RID: 271779
		float Value1 { get; set; }
	}

	// Token: 0x0200880B RID: 34827
	public class MultiplyMagnitude1Modifier : CharacterAttributeTypes.IMultiplyMagnitude1Modifier, CharacterAttributeTypes.IModifier
	{
		// Token: 0x1700787E RID: 30846
		// (get) Token: 0x060425A4 RID: 271780 RVA: 0x013B8417 File Offset: 0x013B6617
		// (set) Token: 0x060425A5 RID: 271781 RVA: 0x013B841F File Offset: 0x013B661F
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x1700787F RID: 30847
		// (get) Token: 0x060425A6 RID: 271782 RVA: 0x013B8428 File Offset: 0x013B6628
		// (set) Token: 0x060425A7 RID: 271783 RVA: 0x013B8430 File Offset: 0x013B6630
		public float Value1 { get; set; }
	}

	// Token: 0x0200880C RID: 34828
	public class AttributeModifier : CharacterAttributeTypes.IModifier, CharacterAttributeTypes.IAddValueModifier, CharacterAttributeTypes.IAddRateModifier, CharacterAttributeTypes.IAddFromAttrModifier, CharacterAttributeTypes.IAddFromAttrRateModifier, CharacterAttributeTypes.IOverrideValue, CharacterAttributeTypes.IOverrideFromAttrModifier, CharacterAttributeTypes.IMultiplyMagnitude1Modifier
	{
		// Token: 0x17007880 RID: 30848
		// (get) Token: 0x060425A9 RID: 271785 RVA: 0x013B8441 File Offset: 0x013B6641
		// (set) Token: 0x060425AA RID: 271786 RVA: 0x013B8449 File Offset: 0x013B6649
		public ECalculationPolicyType Type { get; set; }

		// Token: 0x17007881 RID: 30849
		// (get) Token: 0x060425AB RID: 271787 RVA: 0x013B8452 File Offset: 0x013B6652
		// (set) Token: 0x060425AC RID: 271788 RVA: 0x013B845A File Offset: 0x013B665A
		public float Value1 { get; set; }

		// Token: 0x17007882 RID: 30850
		// (get) Token: 0x060425AD RID: 271789 RVA: 0x013B8463 File Offset: 0x013B6663
		// (set) Token: 0x060425AE RID: 271790 RVA: 0x013B846B File Offset: 0x013B666B
		public float Value2 { get; set; }

		// Token: 0x17007883 RID: 30851
		// (get) Token: 0x060425AF RID: 271791 RVA: 0x013B8474 File Offset: 0x013B6674
		// (set) Token: 0x060425B0 RID: 271792 RVA: 0x013B847C File Offset: 0x013B667C
		public long SourceEntity { get; set; }

		// Token: 0x17007884 RID: 30852
		// (get) Token: 0x060425B1 RID: 271793 RVA: 0x013B8485 File Offset: 0x013B6685
		// (set) Token: 0x060425B2 RID: 271794 RVA: 0x013B848D File Offset: 0x013B668D
		public EAttributeType SourceAttributeId { get; set; }

		// Token: 0x17007885 RID: 30853
		// (get) Token: 0x060425B3 RID: 271795 RVA: 0x013B8496 File Offset: 0x013B6696
		// (set) Token: 0x060425B4 RID: 271796 RVA: 0x013B849E File Offset: 0x013B669E
		public EAttributeBasedFloatCalculationType SourceCalculationType { get; set; }

		// Token: 0x17007886 RID: 30854
		// (get) Token: 0x060425B5 RID: 271797 RVA: 0x013B84A7 File Offset: 0x013B66A7
		// (set) Token: 0x060425B6 RID: 271798 RVA: 0x013B84AF File Offset: 0x013B66AF
		public float? SnapshotSource { get; set; }

		// Token: 0x17007887 RID: 30855
		// (get) Token: 0x060425B7 RID: 271799 RVA: 0x013B84B8 File Offset: 0x013B66B8
		// (set) Token: 0x060425B8 RID: 271800 RVA: 0x013B84C0 File Offset: 0x013B66C0
		public float? Min { get; set; }

		// Token: 0x17007888 RID: 30856
		// (get) Token: 0x060425B9 RID: 271801 RVA: 0x013B84C9 File Offset: 0x013B66C9
		// (set) Token: 0x060425BA RID: 271802 RVA: 0x013B84D1 File Offset: 0x013B66D1
		public float? Ratio { get; set; }

		// Token: 0x17007889 RID: 30857
		// (get) Token: 0x060425BB RID: 271803 RVA: 0x013B84DA File Offset: 0x013B66DA
		// (set) Token: 0x060425BC RID: 271804 RVA: 0x013B84E2 File Offset: 0x013B66E2
		public float? Max { get; set; }

		// Token: 0x1700788A RID: 30858
		// (get) Token: 0x060425BD RID: 271805 RVA: 0x013B84EB File Offset: 0x013B66EB
		// (set) Token: 0x060425BE RID: 271806 RVA: 0x013B84F3 File Offset: 0x013B66F3
		public bool FloorAfterRatio { get; set; }

		// Token: 0x1700788B RID: 30859
		// (get) Token: 0x060425BF RID: 271807 RVA: 0x013B84FC File Offset: 0x013B66FC
		EAttributeType CharacterAttributeTypes.IAddFromAttrRateModifier.SourceAttributeId
		{
			get
			{
				return this.SourceAttributeId;
			}
		}

		// Token: 0x1700788C RID: 30860
		// (get) Token: 0x060425C0 RID: 271808 RVA: 0x013B8504 File Offset: 0x013B6704
		long CharacterAttributeTypes.IAddFromAttrRateModifier.SourceEntity
		{
			get
			{
				return this.SourceEntity;
			}
		}

		// Token: 0x1700788D RID: 30861
		// (get) Token: 0x060425C1 RID: 271809 RVA: 0x013B850C File Offset: 0x013B670C
		EAttributeBasedFloatCalculationType CharacterAttributeTypes.IAddFromAttrRateModifier.SourceCalculationType
		{
			get
			{
				return this.SourceCalculationType;
			}
		}

		// Token: 0x1700788E RID: 30862
		// (get) Token: 0x060425C2 RID: 271810 RVA: 0x013B8514 File Offset: 0x013B6714
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

		// Token: 0x1700788F RID: 30863
		// (get) Token: 0x060425C3 RID: 271811 RVA: 0x013B854F File Offset: 0x013B674F
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Min
		{
			get
			{
				return this.Min;
			}
		}

		// Token: 0x17007890 RID: 30864
		// (get) Token: 0x060425C4 RID: 271812 RVA: 0x013B8557 File Offset: 0x013B6757
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Ratio
		{
			get
			{
				return this.Ratio;
			}
		}

		// Token: 0x17007891 RID: 30865
		// (get) Token: 0x060425C5 RID: 271813 RVA: 0x013B855F File Offset: 0x013B675F
		float? CharacterAttributeTypes.IAddFromAttrRateModifier.Max
		{
			get
			{
				return this.Max;
			}
		}

		// Token: 0x17007892 RID: 30866
		// (get) Token: 0x060425C6 RID: 271814 RVA: 0x013B8567 File Offset: 0x013B6767
		float CharacterAttributeTypes.IAddFromAttrRateModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x17007893 RID: 30867
		// (get) Token: 0x060425C7 RID: 271815 RVA: 0x013B856F File Offset: 0x013B676F
		float CharacterAttributeTypes.IAddValueModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x17007894 RID: 30868
		// (get) Token: 0x060425C8 RID: 271816 RVA: 0x013B8577 File Offset: 0x013B6777
		float CharacterAttributeTypes.IAddRateModifier.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x17007895 RID: 30869
		// (get) Token: 0x060425C9 RID: 271817 RVA: 0x013B857F File Offset: 0x013B677F
		float CharacterAttributeTypes.IOverrideValue.Value1
		{
			get
			{
				return this.Value1;
			}
		}

		// Token: 0x17007896 RID: 30870
		// (get) Token: 0x060425CA RID: 271818 RVA: 0x013B8587 File Offset: 0x013B6787
		// (set) Token: 0x060425CB RID: 271819 RVA: 0x013B8594 File Offset: 0x013B6794
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

		// Token: 0x17007897 RID: 30871
		// (get) Token: 0x060425CC RID: 271820 RVA: 0x013B85A3 File Offset: 0x013B67A3
		// (set) Token: 0x060425CD RID: 271821 RVA: 0x013B85B0 File Offset: 0x013B67B0
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

	// Token: 0x0200880D RID: 34829
	// (Invoke) Token: 0x060425D0 RID: 271824
	public delegate void AttributeChangeListener(EAttributeType attrId, float newValue, float oldValue);
}
