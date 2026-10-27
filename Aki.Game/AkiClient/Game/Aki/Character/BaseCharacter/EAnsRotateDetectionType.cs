using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428D RID: 17037
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsRotateDetectionType.EAnsRotateDetectionType")]
	public enum EAnsRotateDetectionType : byte
	{
		// Token: 0x04017288 RID: 94856
		持续旋转,
		// Token: 0x04017289 RID: 94857
		单次旋转,
		// Token: 0x0401728A RID: 94858
		动态单次旋转,
		// Token: 0x0401728B RID: 94859
		EAnsRotateDetectionType_MAX
	}
}
