using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032EE RID: 13038
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsRotateDetectionType.EAnsRotateDetectionType")]
	public enum EAnsRotateDetectionType : byte
	{
		// Token: 0x04011FA6 RID: 73638
		持续旋转,
		// Token: 0x04011FA7 RID: 73639
		单次旋转,
		// Token: 0x04011FA8 RID: 73640
		动态单次旋转,
		// Token: 0x04011FA9 RID: 73641
		EAnsRotateDetectionType_MAX
	}
}
