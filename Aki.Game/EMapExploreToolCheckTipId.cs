using System;
using CSharpScript.Core.Common;

// Token: 0x020021DC RID: 8668
[EnumExtensions]
public enum EMapExploreToolCheckTipId
{
	// Token: 0x0400802E RID: 32814
	[EnumStringMember("OnylHostUse")]
	NotHost,
	// Token: 0x0400802F RID: 32815
	[EnumStringMember("ExploreStateError")]
	NotOnGround,
	// Token: 0x04008030 RID: 32816
	[EnumStringMember("ExplorePositionError")]
	IllegalExploreToolUsingPos,
	// Token: 0x04008031 RID: 32817
	[EnumStringMember("ExploreFighting")]
	InFight,
	// Token: 0x04008032 RID: 32818
	[EnumStringMember("ExploreUnauthorized")]
	NotHaveCountryAccess,
	// Token: 0x04008033 RID: 32819
	[EnumStringMember("ExploreActivating")]
	ToolActivating,
	// Token: 0x04008034 RID: 32820
	[EnumStringMember("ExploreShengXiaCollectAll")]
	SoundBoxAllCollected,
	// Token: 0x04008035 RID: 32821
	[EnumStringMember("Exolore_ShengXiaNoDetect")]
	Exolore_ShengXiaNoDetect,
	// Token: 0x04008036 RID: 32822
	[EnumStringMember("ExploreTeleporterItemLack")]
	TempTeleporterCostNotEnough,
	// Token: 0x04008037 RID: 32823
	[EnumStringMember("ExploreShengXiaItemLack")]
	SoundBoxDetectorCostNotEnough,
	// Token: 0x04008038 RID: 32824
	[EnumStringMember("ShengXiaDetectTip")]
	SoundBoxUseReachLimit,
	// Token: 0x04008039 RID: 32825
	[EnumStringMember("ExploreTeleporterBan")]
	TempTeleporterPlacementBanned,
	// Token: 0x0400803A RID: 32826
	[EnumStringMember("ErrorCode_2200054_Text")]
	AbnormalGravityCannotAddTemporary
}
