using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031F7 RID: 12791
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/EPanelQteViewType.EPanelQteViewType")]
	public enum EPanelQteViewType : byte
	{
		// Token: 0x0401115F RID: 69983
		Frozen,
		// Token: 0x04011160 RID: 69984
		Interact,
		// Token: 0x04011161 RID: 69985
		YouHu,
		// Token: 0x04011162 RID: 69986
		FreeRunning,
		// Token: 0x04011163 RID: 69987
		EPanelQteViewType_MAX
	}
}
