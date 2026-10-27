using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D6D RID: 15725
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/PresetSelection.PresetSelection")]
	public enum PresetSelection : byte
	{
		// Token: 0x0401364F RID: 79439
		BlueprintDefaults,
		// Token: 0x04013650 RID: 79440
		Selected,
		// Token: 0x04013651 RID: 79441
		RandomOnList,
		// Token: 0x04013652 RID: 79442
		NextPresetOnList,
		// Token: 0x04013653 RID: 79443
		CustomFunction,
		// Token: 0x04013654 RID: 79444
		PresetSelection_MAX
	}
}
