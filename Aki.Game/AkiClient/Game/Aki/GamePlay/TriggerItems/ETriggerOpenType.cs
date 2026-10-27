using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.TriggerItems
{
	// Token: 0x02003E51 RID: 15953
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/TriggerItems/ETriggerOpenType.ETriggerOpenType")]
	public enum ETriggerOpenType : byte
	{
		// Token: 0x0401467E RID: 83582
		Alway,
		// Token: 0x0401467F RID: 83583
		Task,
		// Token: 0x04014680 RID: 83584
		GamePlay,
		// Token: 0x04014681 RID: 83585
		ETriggerOpenType_MAX
	}
}
