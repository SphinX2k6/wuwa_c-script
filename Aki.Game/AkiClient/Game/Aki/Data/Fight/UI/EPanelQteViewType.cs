using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F51 RID: 16209
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/EPanelQteViewType.EPanelQteViewType")]
	public enum EPanelQteViewType : byte
	{
		// Token: 0x04015247 RID: 86599
		Frozen,
		// Token: 0x04015248 RID: 86600
		Interact,
		// Token: 0x04015249 RID: 86601
		YouHu,
		// Token: 0x0401524A RID: 86602
		FreeRunning,
		// Token: 0x0401524B RID: 86603
		EPanelQteViewType_MAX
	}
}
