using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x0200443D RID: 17469
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EActionPlan.EActionPlan")]
	public enum EActionPlan : byte
	{
		// Token: 0x040180D6 RID: 98518
		游荡,
		// Token: 0x040180D7 RID: 98519
		技能,
		// Token: 0x040180D8 RID: 98520
		巡逻,
		// Token: 0x040180D9 RID: 98521
		跟随,
		// Token: 0x040180DA RID: 98522
		脱战,
		// Token: 0x040180DB RID: 98523
		EActionPlan_MAX
	}
}
