using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032F2 RID: 13042
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EBornRotateType.EBornRotateType")]
	public enum EBornRotateType : byte
	{
		// Token: 0x04011FB9 RID: 73657
		保持自身,
		// Token: 0x04011FBA RID: 73658
		同步玩家当前角色,
		// Token: 0x04011FBB RID: 73659
		朝向镜头前一定距离,
		// Token: 0x04011FBC RID: 73660
		EBornRotateType_MAX
	}
}
