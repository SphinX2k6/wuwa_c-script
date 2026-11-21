using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.TriggerItems
{
	// Token: 0x02003149 RID: 12617
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/TriggerItems/ETriggerType.ETriggerType")]
	public enum ETriggerType : byte
	{
		// Token: 0x0401092F RID: 67887
		Wall,
		// Token: 0x04010930 RID: 67888
		NotOpened,
		// Token: 0x04010931 RID: 67889
		Hurt,
		// Token: 0x04010932 RID: 67890
		Plot,
		// Token: 0x04010933 RID: 67891
		Events,
		// Token: 0x04010934 RID: 67892
		ControlObject,
		// Token: 0x04010935 RID: 67893
		EffectArea,
		// Token: 0x04010936 RID: 67894
		ETriggerType_MAX
	}
}
