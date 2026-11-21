using System;
using CSharpScript.Core.Common;

// Token: 0x020016C0 RID: 5824
[EnumExtensions]
public enum EMapExploreToolCheckTipId
{
	// Token: 0x04008175 RID: 33141
	[EnumStringMember("OnylHostUse")]
	NotHost,
	// Token: 0x04008176 RID: 33142
	[EnumStringMember("ExploreStateError")]
	NotOnGround,
	// Token: 0x04008177 RID: 33143
	[EnumStringMember("ExplorePositionError")]
	IllegalExploreToolUsingPos,
	// Token: 0x04008178 RID: 33144
	[EnumStringMember("ExploreFighting")]
	InFight,
	// Token: 0x04008179 RID: 33145
	[EnumStringMember("ExploreUnauthorized")]
	NotHaveCountryAccess,
	// Token: 0x0400817A RID: 33146
	[EnumStringMember("ExploreActivating")]
	ToolActivating,
	// Token: 0x0400817B RID: 33147
	[EnumStringMember("ExploreShengXiaCollectAll")]
	SoundBoxAllCollected,
	// Token: 0x0400817C RID: 33148
	[EnumStringMember("Exolore_ShengXiaNoDetect")]
	Exolore_ShengXiaNoDetect,
	// Token: 0x0400817D RID: 33149
	[EnumStringMember("ExploreTeleporterItemLack")]
	TempTeleporterCostNotEnough,
	// Token: 0x0400817E RID: 33150
	[EnumStringMember("ExploreShengXiaItemLack")]
	SoundBoxDetectorCostNotEnough,
	// Token: 0x0400817F RID: 33151
	[EnumStringMember("ShengXiaDetectTip")]
	SoundBoxUseReachLimit,
	// Token: 0x04008180 RID: 33152
	[EnumStringMember("ExploreTeleporterBan")]
	TempTeleporterPlacementBanned,
	// Token: 0x04008181 RID: 33153
	[EnumStringMember("ErrorCode_2200054_Text")]
	AbnormalGravityCannotAddTemporary
}
