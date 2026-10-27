using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200521C RID: 21020
	public interface ICardDetailEffectCountData
	{
		// Token: 0x1700821F RID: 33311
		// (get) Token: 0x06035BFC RID: 220156
		// (set) Token: 0x06035BFD RID: 220157
		int CurrentEffectCount { get; set; }

		// Token: 0x17008220 RID: 33312
		// (get) Token: 0x06035BFE RID: 220158
		// (set) Token: 0x06035BFF RID: 220159
		int TotalEffectCount { get; set; }
	}
}
