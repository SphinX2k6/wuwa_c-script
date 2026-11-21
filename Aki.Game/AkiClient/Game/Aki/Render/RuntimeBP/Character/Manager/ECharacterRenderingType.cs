using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager
{
	// Token: 0x0200313D RID: 12605
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Manager/ECharacterRenderingType.ECharacterRenderingType")]
	public enum ECharacterRenderingType : byte
	{
		// Token: 0x04010842 RID: 67650
		LocalPlayer,
		// Token: 0x04010843 RID: 67651
		RemotePlayer,
		// Token: 0x04010844 RID: 67652
		Monster,
		// Token: 0x04010845 RID: 67653
		Npc,
		// Token: 0x04010846 RID: 67654
		Pet,
		// Token: 0x04010847 RID: 67655
		UI,
		// Token: 0x04010848 RID: 67656
		Sequence,
		// Token: 0x04010849 RID: 67657
		Default,
		// Token: 0x0401084A RID: 67658
		Effect,
		// Token: 0x0401084B RID: 67659
		Error,
		// Token: 0x0401084C RID: 67660
		ECharacterRenderingType_MAX
	}
}
