using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043A1 RID: 17313
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/EBaseCurveType.EBaseCurveType")]
	public enum EBaseCurveType : byte
	{
		// Token: 0x04017A9E RID: 96926
		线性,
		// Token: 0x04017A9F RID: 96927
		二阶_凹函数,
		// Token: 0x04017AA0 RID: 96928
		二阶_凸函数,
		// Token: 0x04017AA1 RID: 96929
		三阶_凹函数,
		// Token: 0x04017AA2 RID: 96930
		三阶_凸函数,
		// Token: 0x04017AA3 RID: 96931
		三阶_S函数,
		// Token: 0x04017AA4 RID: 96932
		三阶_反S函数,
		// Token: 0x04017AA5 RID: 96933
		幂函数_凹函数,
		// Token: 0x04017AA6 RID: 96934
		幂函数_凸函数,
		// Token: 0x04017AA7 RID: 96935
		幂函数_S函数,
		// Token: 0x04017AA8 RID: 96936
		幂函数_反S函数,
		// Token: 0x04017AA9 RID: 96937
		幂函数_抛物线,
		// Token: 0x04017AAA RID: 96938
		缓入缓出,
		// Token: 0x04017AAB RID: 96939
		缓入急出,
		// Token: 0x04017AAC RID: 96940
		急入缓出,
		// Token: 0x04017AAD RID: 96941
		急入急出,
		// Token: 0x04017AAE RID: 96942
		资产曲线,
		// Token: 0x04017AAF RID: 96943
		EBaseCurveType_MAX
	}
}
