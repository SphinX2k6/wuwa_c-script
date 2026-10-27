using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200565A RID: 22106
	public enum EBaseItemDataCheckMask : byte
	{
		// Token: 0x0401D90B RID: 121099
		Unlock = 1,
		// Token: 0x0401D90C RID: 121100
		LimitCount,
		// Token: 0x0401D90D RID: 121101
		CoinEnough = 4,
		// Token: 0x0401D90E RID: 121102
		ComposeMaterialEnough = 8,
		// Token: 0x0401D90F RID: 121103
		ExchangeMaterialEnough = 16,
		// Token: 0x0401D910 RID: 121104
		All = 255
	}
}
