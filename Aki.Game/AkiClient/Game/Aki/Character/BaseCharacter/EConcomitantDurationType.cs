using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003301 RID: 13057
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EConcomitantDurationType.EConcomitantDurationType")]
	public enum EConcomitantDurationType : byte
	{
		// Token: 0x0401203D RID: 73789
		永久持续,
		// Token: 0x0401203E RID: 73790
		蒙太奇结束消失,
		// Token: 0x0401203F RID: 73791
		固定时间,
		// Token: 0x04012040 RID: 73792
		帧事件结束时消失,
		// Token: 0x04012041 RID: 73793
		EConcomitantDurationType_MAX
	}
}
