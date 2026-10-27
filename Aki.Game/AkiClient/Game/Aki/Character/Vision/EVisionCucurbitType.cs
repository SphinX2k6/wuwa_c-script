using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x0200402B RID: 16427
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/EVisionCucurbitType.EVisionCucurbitType")]
	public enum EVisionCucurbitType : byte
	{
		// Token: 0x04015B68 RID: 88936
		无,
		// Token: 0x04015B69 RID: 88937
		辅助_近_,
		// Token: 0x04015B6A RID: 88938
		辅助_远_,
		// Token: 0x04015B6B RID: 88939
		远程,
		// Token: 0x04015B6C RID: 88940
		近战_正面_,
		// Token: 0x04015B6D RID: 88941
		近战_背刺_,
		// Token: 0x04015B6E RID: 88942
		EVisionCucurbitType_MAX
	}
}
