using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F50 RID: 16208
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/EPanelQteCustomAction.EPanelQteCustomAction")]
	public enum EPanelQteCustomAction : byte
	{
		// Token: 0x04015240 RID: 86592
		RemoveFrozenBuff,
		// Token: 0x04015241 RID: 86593
		ChangeRole,
		// Token: 0x04015242 RID: 86594
		FreeRunningRush,
		// Token: 0x04015243 RID: 86595
		FreeRunningHook,
		// Token: 0x04015244 RID: 86596
		FreeRunningJump,
		// Token: 0x04015245 RID: 86597
		EPanelQteCustomAction_MAX
	}
}
