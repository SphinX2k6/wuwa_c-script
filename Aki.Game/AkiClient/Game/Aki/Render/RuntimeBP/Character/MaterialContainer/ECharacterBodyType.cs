using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E21 RID: 15905
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterBodyType.ECharacterBodyType")]
	public enum ECharacterBodyType : byte
	{
		// Token: 0x0401436C RID: 82796
		Body,
		// Token: 0x0401436D RID: 82797
		Weapon,
		// Token: 0x0401436E RID: 82798
		Hulu,
		// Token: 0x0401436F RID: 82799
		Other,
		// Token: 0x04014370 RID: 82800
		ECharacterBodyType_MAX
	}
}
