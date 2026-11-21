using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004630 RID: 17968
	public enum EBaseItemDataCheckMask : byte
	{
		// Token: 0x04018396 RID: 99222
		Unlock = 1,
		// Token: 0x04018397 RID: 99223
		LimitCount,
		// Token: 0x04018398 RID: 99224
		CoinEnough = 4,
		// Token: 0x04018399 RID: 99225
		ComposeMaterialEnough = 8,
		// Token: 0x0401839A RID: 99226
		ExchangeMaterialEnough = 16,
		// Token: 0x0401839B RID: 99227
		All = 255
	}
}
