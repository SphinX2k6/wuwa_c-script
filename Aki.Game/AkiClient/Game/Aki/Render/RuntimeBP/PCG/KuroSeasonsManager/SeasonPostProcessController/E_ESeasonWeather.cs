using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroSeasonsManager.SeasonPostProcessController
{
	// Token: 0x02003C78 RID: 15480
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroSeasonsManager/SeasonPostProcessController/E_ESeasonWeather.E_ESeasonWeather")]
	public enum E_ESeasonWeather : byte
	{
		// Token: 0x04011CED RID: 72941
		Idle,
		// Token: 0x04011CEE RID: 72942
		Waiting,
		// Token: 0x04011CEF RID: 72943
		Active,
		// Token: 0x04011CF0 RID: 72944
		Cooldown,
		// Token: 0x04011CF1 RID: 72945
		E_MAX
	}
}
