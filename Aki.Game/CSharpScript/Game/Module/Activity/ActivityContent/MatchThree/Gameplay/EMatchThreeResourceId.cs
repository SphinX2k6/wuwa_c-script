using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005440 RID: 21568
	[EnumExtensions]
	public enum EMatchThreeResourceId
	{
		// Token: 0x0401C4A6 RID: 115878
		[EnumStringMember("UiItem_TileNor")]
		TileNormal,
		// Token: 0x0401C4A7 RID: 115879
		[EnumStringMember("UiItem_TileUltimate")]
		TileUltimate,
		// Token: 0x0401C4A8 RID: 115880
		[EnumStringMember("UiItem_TileSandglass")]
		TileHourglass,
		// Token: 0x0401C4A9 RID: 115881
		[EnumStringMember("UiItem_TileAbsorb")]
		TileCharger,
		// Token: 0x0401C4AA RID: 115882
		[EnumStringMember("UiItem_TileIce")]
		TileIce,
		// Token: 0x0401C4AB RID: 115883
		[EnumStringMember("UiItem_ItemArrowX")]
		AdditionBomb,
		// Token: 0x0401C4AC RID: 115884
		[EnumStringMember("UiItem_ItemArrowCross")]
		AdditionCrossClear,
		// Token: 0x0401C4AD RID: 115885
		[EnumStringMember("UiItem_ItemSkillChain")]
		AdditionChain,
		// Token: 0x0401C4AE RID: 115886
		[EnumStringMember("UiItem_ItemEffectUltimate")]
		UltimateTrail,
		// Token: 0x0401C4AF RID: 115887
		[EnumStringMember("UiItem_ItemEffectRemove")]
		EnergyTrail,
		// Token: 0x0401C4B0 RID: 115888
		[EnumStringMember("UiItem_ItemEffectXin")]
		AllureTrail,
		// Token: 0x0401C4B1 RID: 115889
		[EnumStringMember("UiItem_ItemEffectChain")]
		ChainTrail,
		// Token: 0x0401C4B2 RID: 115890
		[EnumStringMember("UiItem_ItemEffectChain_2")]
		ChainDetonationTrail,
		// Token: 0x0401C4B3 RID: 115891
		[EnumStringMember("UiItem_ItemEffectProp")]
		MechanicTrail,
		// Token: 0x0401C4B4 RID: 115892
		[EnumStringMember("UiItem_ItemEffectAbsorb")]
		RecycleChargerTrail,
		// Token: 0x0401C4B5 RID: 115893
		[EnumStringMember("UiItem_ItemEffectSandglass")]
		RecycleHourglassTrail,
		// Token: 0x0401C4B6 RID: 115894
		[EnumStringMember("Cure_CharacterX")]
		SkillTrailCurveX,
		// Token: 0x0401C4B7 RID: 115895
		[EnumStringMember("Cure_CharacterY")]
		SkillTrailCurveY,
		// Token: 0x0401C4B8 RID: 115896
		[EnumStringMember("Cure_CharacterX_2")]
		SkillTrailCurveX2,
		// Token: 0x0401C4B9 RID: 115897
		[EnumStringMember("Cure_CharacterY_2")]
		SkillTrailCurveY2,
		// Token: 0x0401C4BA RID: 115898
		[EnumStringMember("Cure_Xian")]
		ChainSkillTrailCurve,
		// Token: 0x0401C4BB RID: 115899
		[EnumStringMember("Cure_energyX")]
		EnergyTrailCurveX,
		// Token: 0x0401C4BC RID: 115900
		[EnumStringMember("Cure_energyY")]
		EnergyTrailCurveY,
		// Token: 0x0401C4BD RID: 115901
		[EnumStringMember("Cure_ItemX")]
		MechanicTrailCurveX,
		// Token: 0x0401C4BE RID: 115902
		[EnumStringMember("Cure_ItemY")]
		MechanicTrailCurveY,
		// Token: 0x0401C4BF RID: 115903
		[EnumStringMember("Cure_Array")]
		FallCurve,
		// Token: 0x0401C4C0 RID: 115904
		[EnumStringMember("UiItem_GamePlayTipsEnv")]
		EnvTips,
		// Token: 0x0401C4C1 RID: 115905
		[EnumStringMember("UiItem_GamePlayTipsSkill")]
		SkillTips,
		// Token: 0x0401C4C2 RID: 115906
		[EnumStringMember("UiItem_GamePlayScore")]
		ScorePop,
		// Token: 0x0401C4C3 RID: 115907
		[EnumStringMember("UiItem_GamePlayGrade")]
		GradePop,
		// Token: 0x0401C4C4 RID: 115908
		[EnumStringMember("SP_IconTileUltimate")]
		IconTileUltimate,
		// Token: 0x0401C4C5 RID: 115909
		[EnumStringMember("SP_IconTileSandglass")]
		IconTileHourglass,
		// Token: 0x0401C4C6 RID: 115910
		[EnumStringMember("SP_IconTileAbsorb")]
		IconTileCharger,
		// Token: 0x0401C4C7 RID: 115911
		[EnumStringMember("SP_IconIce")]
		IconTileIce,
		// Token: 0x0401C4C8 RID: 115912
		[EnumStringMember("SP_IconTile1")]
		IconTileRed,
		// Token: 0x0401C4C9 RID: 115913
		[EnumStringMember("SP_IconTile2")]
		IconTileYellow,
		// Token: 0x0401C4CA RID: 115914
		[EnumStringMember("SP_IconTile3")]
		IconTileBlue,
		// Token: 0x0401C4CB RID: 115915
		[EnumStringMember("SP_IconTile4")]
		IconTileGreen,
		// Token: 0x0401C4CC RID: 115916
		[EnumStringMember("SP_IconTile5")]
		IconTilePurple,
		// Token: 0x0401C4CD RID: 115917
		[EnumStringMember("SP_PointsIcon")]
		IconScore,
		// Token: 0x0401C4CE RID: 115918
		[EnumStringMember("SP_ProgressBarBgNor")]
		ProgressBgNormal,
		// Token: 0x0401C4CF RID: 115919
		[EnumStringMember("SP_ProgressBarBgSP")]
		ProgressBgEndless
	}
}
