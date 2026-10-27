using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A6 RID: 17062
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EConcomitantDurationType.EConcomitantDurationType")]
	public enum EConcomitantDurationType : byte
	{
		// Token: 0x0401733F RID: 95039
		永久持续,
		// Token: 0x04017340 RID: 95040
		蒙太奇结束消失,
		// Token: 0x04017341 RID: 95041
		固定时间,
		// Token: 0x04017342 RID: 95042
		帧事件结束时消失,
		// Token: 0x04017343 RID: 95043
		EConcomitantDurationType_MAX
	}
}
