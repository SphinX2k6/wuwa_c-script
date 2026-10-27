using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Sequence.Manager.Enum
{
	// Token: 0x02003A37 RID: 14903
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/Enum/SeqCameraMode.SeqCameraMode")]
	public enum SeqCameraMode : byte
	{
		// Token: 0x0400F129 RID: 61737
		剧情相机,
		// Token: 0x0400F12A RID: 61738
		跟随相机,
		// Token: 0x0400F12B RID: 61739
		跟随相机剧情模式,
		// Token: 0x0400F12C RID: 61740
		SeqCameraMode_MAX
	}
}
