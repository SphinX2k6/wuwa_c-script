using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031F6 RID: 12790
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/EPanelQteCustomAction.EPanelQteCustomAction")]
	public enum EPanelQteCustomAction : byte
	{
		// Token: 0x04011158 RID: 69976
		RemoveFrozenBuff,
		// Token: 0x04011159 RID: 69977
		ChangeRole,
		// Token: 0x0401115A RID: 69978
		FreeRunningRush,
		// Token: 0x0401115B RID: 69979
		FreeRunningHook,
		// Token: 0x0401115C RID: 69980
		FreeRunningJump,
		// Token: 0x0401115D RID: 69981
		EPanelQteCustomAction_MAX
	}
}
