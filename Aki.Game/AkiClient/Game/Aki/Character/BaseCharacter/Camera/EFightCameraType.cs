using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043B9 RID: 17337
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EFightCameraType.EFightCameraType")]
	public enum EFightCameraType : byte
	{
		// Token: 0x04017C59 RID: 97369
		基础镜头,
		// Token: 0x04017C5A RID: 97370
		战斗镜头,
		// Token: 0x04017C5B RID: 97371
		子镜头,
		// Token: 0x04017C5C RID: 97372
		锁定目标镜头,
		// Token: 0x04017C5D RID: 97373
		伴随目标镜头,
		// Token: 0x04017C5E RID: 97374
		EFightCameraType_MAX
	}
}
