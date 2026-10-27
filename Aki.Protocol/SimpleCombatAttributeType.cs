using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015EE RID: 5614
	public enum SimpleCombatAttributeType
	{
		// Token: 0x0400BDF7 RID: 48631
		[OriginalName("KscNone")]
		KscNone,
		// Token: 0x0400BDF8 RID: 48632
		[OriginalName("KscLv")]
		KscLv,
		// Token: 0x0400BDF9 RID: 48633
		[OriginalName("KscLifeMax")]
		KscLifeMax,
		// Token: 0x0400BDFA RID: 48634
		[OriginalName("KscLife")]
		KscLife,
		// Token: 0x0400BDFB RID: 48635
		[OriginalName("KscShield")]
		KscShield,
		// Token: 0x0400BDFC RID: 48636
		[OriginalName("KscAtk")]
		KscAtk = 7,
		// Token: 0x0400BDFD RID: 48637
		[OriginalName("KscCrit")]
		KscCrit,
		// Token: 0x0400BDFE RID: 48638
		[OriginalName("KscCritDamage")]
		KscCritDamage,
		// Token: 0x0400BDFF RID: 48639
		[OriginalName("KscDef")]
		KscDef,
		// Token: 0x0400BE00 RID: 48640
		[OriginalName("KscAtkChange")]
		KscAtkChange,
		// Token: 0x0400BE01 RID: 48641
		[OriginalName("KscMaxLifeShieldChange")]
		KscMaxLifeShieldChange,
		// Token: 0x0400BE02 RID: 48642
		[OriginalName("KscBaseLife")]
		KscBaseLife,
		// Token: 0x0400BE03 RID: 48643
		[OriginalName("KscCritChange")]
		KscCritChange,
		// Token: 0x0400BE04 RID: 48644
		[OriginalName("KscDamageChange")]
		KscDamageChange,
		// Token: 0x0400BE05 RID: 48645
		[OriginalName("KscDamageReduce")]
		KscDamageReduce,
		// Token: 0x0400BE06 RID: 48646
		[OriginalName("KscDamageLifeSteal")]
		KscDamageLifeSteal,
		// Token: 0x0400BE07 RID: 48647
		[OriginalName("KscHealBase")]
		KscHealBase,
		// Token: 0x0400BE08 RID: 48648
		[OriginalName("KscDamageReduceCollision")]
		KscDamageReduceCollision,
		// Token: 0x0400BE09 RID: 48649
		[OriginalName("KscDamageAbsorptionCount")]
		KscDamageAbsorptionCount,
		// Token: 0x0400BE0A RID: 48650
		[OriginalName("KscDamageChangePhys")]
		KscDamageChangePhys,
		// Token: 0x0400BE0B RID: 48651
		[OriginalName("KscDamageChangeElement1")]
		KscDamageChangeElement1,
		// Token: 0x0400BE0C RID: 48652
		[OriginalName("KscDamageChangeElement2")]
		KscDamageChangeElement2,
		// Token: 0x0400BE0D RID: 48653
		[OriginalName("KscDamageChangeElement3")]
		KscDamageChangeElement3,
		// Token: 0x0400BE0E RID: 48654
		[OriginalName("KscDamageChangeElement4")]
		KscDamageChangeElement4,
		// Token: 0x0400BE0F RID: 48655
		[OriginalName("KscDamageChangeElement5")]
		KscDamageChangeElement5,
		// Token: 0x0400BE10 RID: 48656
		[OriginalName("KscDamageChangeElement6")]
		KscDamageChangeElement6,
		// Token: 0x0400BE11 RID: 48657
		[OriginalName("KscDamageResistancePhys")]
		KscDamageResistancePhys,
		// Token: 0x0400BE12 RID: 48658
		[OriginalName("KscDamageResistanceElement1")]
		KscDamageResistanceElement1,
		// Token: 0x0400BE13 RID: 48659
		[OriginalName("KscDamageResistanceElement2")]
		KscDamageResistanceElement2,
		// Token: 0x0400BE14 RID: 48660
		[OriginalName("KscDamageResistanceElement3")]
		KscDamageResistanceElement3,
		// Token: 0x0400BE15 RID: 48661
		[OriginalName("KscDamageResistanceElement4")]
		KscDamageResistanceElement4,
		// Token: 0x0400BE16 RID: 48662
		[OriginalName("KscDamageResistanceElement5")]
		KscDamageResistanceElement5,
		// Token: 0x0400BE17 RID: 48663
		[OriginalName("KscDamageResistanceElement6")]
		KscDamageResistanceElement6,
		// Token: 0x0400BE18 RID: 48664
		[OriginalName("KscHealChange")]
		KscHealChange,
		// Token: 0x0400BE19 RID: 48665
		[OriginalName("KscHealedChange")]
		KscHealedChange,
		// Token: 0x0400BE1A RID: 48666
		[OriginalName("KscDamageReducePhys")]
		KscDamageReducePhys,
		// Token: 0x0400BE1B RID: 48667
		[OriginalName("KscDamageReduceElement1")]
		KscDamageReduceElement1,
		// Token: 0x0400BE1C RID: 48668
		[OriginalName("KscDamageReduceElement2")]
		KscDamageReduceElement2,
		// Token: 0x0400BE1D RID: 48669
		[OriginalName("KscDamageReduceElement3")]
		KscDamageReduceElement3,
		// Token: 0x0400BE1E RID: 48670
		[OriginalName("KscDamageReduceElement4")]
		KscDamageReduceElement4,
		// Token: 0x0400BE1F RID: 48671
		[OriginalName("KscDamageReduceElement5")]
		KscDamageReduceElement5,
		// Token: 0x0400BE20 RID: 48672
		[OriginalName("KscDamageReduceElement6")]
		KscDamageReduceElement6,
		// Token: 0x0400BE21 RID: 48673
		[OriginalName("KscDamageAmplify1")]
		KscDamageAmplify1,
		// Token: 0x0400BE22 RID: 48674
		[OriginalName("KscDamageAmplify2")]
		KscDamageAmplify2,
		// Token: 0x0400BE23 RID: 48675
		[OriginalName("KscIgnoreDefRate")]
		KscIgnoreDefRate = 99,
		// Token: 0x0400BE24 RID: 48676
		[OriginalName("KscIgnoreDamageResistancePhys")]
		KscIgnoreDamageResistancePhys,
		// Token: 0x0400BE25 RID: 48677
		[OriginalName("KscIgnoreDamageResistanceElement1")]
		KscIgnoreDamageResistanceElement1,
		// Token: 0x0400BE26 RID: 48678
		[OriginalName("KscIgnoreDamageResistanceElement2")]
		KscIgnoreDamageResistanceElement2,
		// Token: 0x0400BE27 RID: 48679
		[OriginalName("KscIgnoreDamageResistanceElement3")]
		KscIgnoreDamageResistanceElement3,
		// Token: 0x0400BE28 RID: 48680
		[OriginalName("KscIgnoreDamageResistanceElement4")]
		KscIgnoreDamageResistanceElement4,
		// Token: 0x0400BE29 RID: 48681
		[OriginalName("KscIgnoreDamageResistanceElement5")]
		KscIgnoreDamageResistanceElement5,
		// Token: 0x0400BE2A RID: 48682
		[OriginalName("KscIgnoreDamageResistanceElement6")]
		KscIgnoreDamageResistanceElement6,
		// Token: 0x0400BE2B RID: 48683
		[OriginalName("KscSkillCoolDown")]
		KscSkillCoolDown = 117,
		// Token: 0x0400BE2C RID: 48684
		[OriginalName("KscSkillCoolDownChange")]
		KscSkillCoolDownChange,
		// Token: 0x0400BE2D RID: 48685
		[OriginalName("KscSkillCoolDownChangeMin")]
		KscSkillCoolDownChangeMin,
		// Token: 0x0400BE2E RID: 48686
		[OriginalName("KscCustomProperty1")]
		KscCustomProperty1,
		// Token: 0x0400BE2F RID: 48687
		[OriginalName("KscCustomProperty2")]
		KscCustomProperty2,
		// Token: 0x0400BE30 RID: 48688
		[OriginalName("KscCustomProperty3")]
		KscCustomProperty3,
		// Token: 0x0400BE31 RID: 48689
		[OriginalName("KscCustomProperty4")]
		KscCustomProperty4,
		// Token: 0x0400BE32 RID: 48690
		[OriginalName("KscCustomProperty5")]
		KscCustomProperty5,
		// Token: 0x0400BE33 RID: 48691
		[OriginalName("KscCustomProperty6")]
		KscCustomProperty6,
		// Token: 0x0400BE34 RID: 48692
		[OriginalName("KscCustomProperty7")]
		KscCustomProperty7,
		// Token: 0x0400BE35 RID: 48693
		[OriginalName("KscCustomProperty8")]
		KscCustomProperty8,
		// Token: 0x0400BE36 RID: 48694
		[OriginalName("KscCustomProperty9")]
		KscCustomProperty9,
		// Token: 0x0400BE37 RID: 48695
		[OriginalName("KscCustomProperty10")]
		KscCustomProperty10,
		// Token: 0x0400BE38 RID: 48696
		[OriginalName("KscCustomProperty11")]
		KscCustomProperty11,
		// Token: 0x0400BE39 RID: 48697
		[OriginalName("KscCustomProperty12")]
		KscCustomProperty12,
		// Token: 0x0400BE3A RID: 48698
		[OriginalName("KscCustomProperty13")]
		KscCustomProperty13,
		// Token: 0x0400BE3B RID: 48699
		[OriginalName("KscCustomProperty14")]
		KscCustomProperty14,
		// Token: 0x0400BE3C RID: 48700
		[OriginalName("KscCustomProperty15")]
		KscCustomProperty15,
		// Token: 0x0400BE3D RID: 48701
		[OriginalName("KscCustomProperty16")]
		KscCustomProperty16,
		// Token: 0x0400BE3E RID: 48702
		[OriginalName("KscCustomProperty17")]
		KscCustomProperty17,
		// Token: 0x0400BE3F RID: 48703
		[OriginalName("KscCustomProperty18")]
		KscCustomProperty18,
		// Token: 0x0400BE40 RID: 48704
		[OriginalName("KscCustomProperty19")]
		KscCustomProperty19,
		// Token: 0x0400BE41 RID: 48705
		[OriginalName("KscCustomProperty20")]
		KscCustomProperty20,
		// Token: 0x0400BE42 RID: 48706
		[OriginalName("KscCustomProperty21")]
		KscCustomProperty21,
		// Token: 0x0400BE43 RID: 48707
		[OriginalName("KscCustomProperty22")]
		KscCustomProperty22,
		// Token: 0x0400BE44 RID: 48708
		[OriginalName("KscCustomProperty23")]
		KscCustomProperty23,
		// Token: 0x0400BE45 RID: 48709
		[OriginalName("KscCustomProperty24")]
		KscCustomProperty24,
		// Token: 0x0400BE46 RID: 48710
		[OriginalName("KscCustomProperty25")]
		KscCustomProperty25,
		// Token: 0x0400BE47 RID: 48711
		[OriginalName("KscCustomProperty26")]
		KscCustomProperty26,
		// Token: 0x0400BE48 RID: 48712
		[OriginalName("KscCustomProperty27")]
		KscCustomProperty27,
		// Token: 0x0400BE49 RID: 48713
		[OriginalName("KscCustomProperty28")]
		KscCustomProperty28,
		// Token: 0x0400BE4A RID: 48714
		[OriginalName("KscCustomProperty29")]
		KscCustomProperty29,
		// Token: 0x0400BE4B RID: 48715
		[OriginalName("KscCustomProperty30")]
		KscCustomProperty30,
		// Token: 0x0400BE4C RID: 48716
		[OriginalName("KscCustomProperty31")]
		KscCustomProperty31,
		// Token: 0x0400BE4D RID: 48717
		[OriginalName("KscCustomProperty32")]
		KscCustomProperty32,
		// Token: 0x0400BE4E RID: 48718
		[OriginalName("KscCustomProperty33")]
		KscCustomProperty33,
		// Token: 0x0400BE4F RID: 48719
		[OriginalName("KscCustomProperty34")]
		KscCustomProperty34,
		// Token: 0x0400BE50 RID: 48720
		[OriginalName("KscCustomProperty35")]
		KscCustomProperty35,
		// Token: 0x0400BE51 RID: 48721
		[OriginalName("KscCustomProperty36")]
		KscCustomProperty36,
		// Token: 0x0400BE52 RID: 48722
		[OriginalName("KscCustomProperty37")]
		KscCustomProperty37,
		// Token: 0x0400BE53 RID: 48723
		[OriginalName("KscCustomProperty38")]
		KscCustomProperty38,
		// Token: 0x0400BE54 RID: 48724
		[OriginalName("KscCustomProperty39")]
		KscCustomProperty39,
		// Token: 0x0400BE55 RID: 48725
		[OriginalName("KscCustomProperty40")]
		KscCustomProperty40,
		// Token: 0x0400BE56 RID: 48726
		[OriginalName("KscCustomProperty41")]
		KscCustomProperty41,
		// Token: 0x0400BE57 RID: 48727
		[OriginalName("KscCustomProperty42")]
		KscCustomProperty42,
		// Token: 0x0400BE58 RID: 48728
		[OriginalName("KscCustomProperty43")]
		KscCustomProperty43,
		// Token: 0x0400BE59 RID: 48729
		[OriginalName("KscCustomProperty44")]
		KscCustomProperty44,
		// Token: 0x0400BE5A RID: 48730
		[OriginalName("KscCustomProperty45")]
		KscCustomProperty45,
		// Token: 0x0400BE5B RID: 48731
		[OriginalName("KscCustomProperty46")]
		KscCustomProperty46,
		// Token: 0x0400BE5C RID: 48732
		[OriginalName("KscCustomProperty47")]
		KscCustomProperty47,
		// Token: 0x0400BE5D RID: 48733
		[OriginalName("KscCustomProperty48")]
		KscCustomProperty48,
		// Token: 0x0400BE5E RID: 48734
		[OriginalName("KscCustomProperty49")]
		KscCustomProperty49,
		// Token: 0x0400BE5F RID: 48735
		[OriginalName("KscCustomProperty50")]
		KscCustomProperty50,
		// Token: 0x0400BE60 RID: 48736
		[OriginalName("KscCustomProperty51")]
		KscCustomProperty51,
		// Token: 0x0400BE61 RID: 48737
		[OriginalName("KscCustomProperty52")]
		KscCustomProperty52,
		// Token: 0x0400BE62 RID: 48738
		[OriginalName("KscCustomProperty53")]
		KscCustomProperty53,
		// Token: 0x0400BE63 RID: 48739
		[OriginalName("KscCustomProperty54")]
		KscCustomProperty54,
		// Token: 0x0400BE64 RID: 48740
		[OriginalName("KscCustomProperty55")]
		KscCustomProperty55,
		// Token: 0x0400BE65 RID: 48741
		[OriginalName("KscCustomProperty56")]
		KscCustomProperty56,
		// Token: 0x0400BE66 RID: 48742
		[OriginalName("KscCustomProperty57")]
		KscCustomProperty57,
		// Token: 0x0400BE67 RID: 48743
		[OriginalName("KscCustomProperty58")]
		KscCustomProperty58,
		// Token: 0x0400BE68 RID: 48744
		[OriginalName("KscCustomProperty59")]
		KscCustomProperty59,
		// Token: 0x0400BE69 RID: 48745
		[OriginalName("KscCustomProperty60")]
		KscCustomProperty60,
		// Token: 0x0400BE6A RID: 48746
		[OriginalName("KscCustomProperty61")]
		KscCustomProperty61,
		// Token: 0x0400BE6B RID: 48747
		[OriginalName("KscCustomProperty62")]
		KscCustomProperty62,
		// Token: 0x0400BE6C RID: 48748
		[OriginalName("KscCustomProperty63")]
		KscCustomProperty63,
		// Token: 0x0400BE6D RID: 48749
		[OriginalName("KscCustomProperty64")]
		KscCustomProperty64,
		// Token: 0x0400BE6E RID: 48750
		[OriginalName("KscCustomProperty65")]
		KscCustomProperty65,
		// Token: 0x0400BE6F RID: 48751
		[OriginalName("KscCustomProperty66")]
		KscCustomProperty66,
		// Token: 0x0400BE70 RID: 48752
		[OriginalName("KscCustomProperty67")]
		KscCustomProperty67,
		// Token: 0x0400BE71 RID: 48753
		[OriginalName("KscCustomProperty68")]
		KscCustomProperty68,
		// Token: 0x0400BE72 RID: 48754
		[OriginalName("KscCustomProperty69")]
		KscCustomProperty69,
		// Token: 0x0400BE73 RID: 48755
		[OriginalName("KscCustomProperty70")]
		KscCustomProperty70,
		// Token: 0x0400BE74 RID: 48756
		[OriginalName("KscMoveSpeed")]
		KscMoveSpeed,
		// Token: 0x0400BE75 RID: 48757
		[OriginalName("KscMoveSpeedAdd")]
		KscMoveSpeedAdd,
		// Token: 0x0400BE76 RID: 48758
		[OriginalName("KscMoveSpeedReduce")]
		KscMoveSpeedReduce,
		// Token: 0x0400BE77 RID: 48759
		[OriginalName("KscAddBuffDuration")]
		KscAddBuffDuration = 199,
		// Token: 0x0400BE78 RID: 48760
		[OriginalName("KscBuffDuration")]
		KscBuffDuration,
		// Token: 0x0400BE79 RID: 48761
		[OriginalName("KscSpecialDamageChange1")]
		KscSpecialDamageChange1,
		// Token: 0x0400BE7A RID: 48762
		[OriginalName("KscSpecialDamageChange2")]
		KscSpecialDamageChange2,
		// Token: 0x0400BE7B RID: 48763
		[OriginalName("KscSpecialDamageChange3")]
		KscSpecialDamageChange3,
		// Token: 0x0400BE7C RID: 48764
		[OriginalName("KscSpecialDamageChange4")]
		KscSpecialDamageChange4,
		// Token: 0x0400BE7D RID: 48765
		[OriginalName("KscSpecialDamageChange5")]
		KscSpecialDamageChange5,
		// Token: 0x0400BE7E RID: 48766
		[OriginalName("KscSpecialDamageChange6")]
		KscSpecialDamageChange6,
		// Token: 0x0400BE7F RID: 48767
		[OriginalName("KscSpecialDamageChange7")]
		KscSpecialDamageChange7,
		// Token: 0x0400BE80 RID: 48768
		[OriginalName("KscSpecialChange0")]
		KscSpecialChange0 = 210,
		// Token: 0x0400BE81 RID: 48769
		[OriginalName("KscSpecialChange1")]
		KscSpecialChange1,
		// Token: 0x0400BE82 RID: 48770
		[OriginalName("KscSpecialChange2")]
		KscSpecialChange2,
		// Token: 0x0400BE83 RID: 48771
		[OriginalName("KscSpecialChange3")]
		KscSpecialChange3,
		// Token: 0x0400BE84 RID: 48772
		[OriginalName("KscSpecialChange4")]
		KscSpecialChange4,
		// Token: 0x0400BE85 RID: 48773
		[OriginalName("KscSpecialChange5")]
		KscSpecialChange5,
		// Token: 0x0400BE86 RID: 48774
		[OriginalName("KscSpecialChange6")]
		KscSpecialChange6,
		// Token: 0x0400BE87 RID: 48775
		[OriginalName("KscSpecialChange7")]
		KscSpecialChange7,
		// Token: 0x0400BE88 RID: 48776
		[OriginalName("KscSpecialChange8")]
		KscSpecialChange8,
		// Token: 0x0400BE89 RID: 48777
		[OriginalName("KscSpecialChange9")]
		KscSpecialChange9,
		// Token: 0x0400BE8A RID: 48778
		[OriginalName("KscAttackSpeed")]
		KscAttackSpeed,
		// Token: 0x0400BE8B RID: 48779
		[OriginalName("KscAttackSpeedChange")]
		KscAttackSpeedChange,
		// Token: 0x0400BE8C RID: 48780
		[OriginalName("KscAttributeTypeMax")]
		KscAttributeTypeMax = 255
	}
}
