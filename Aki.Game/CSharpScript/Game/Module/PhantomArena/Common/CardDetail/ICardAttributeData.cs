using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005210 RID: 21008
	public interface ICardAttributeData
	{
		// Token: 0x17008203 RID: 33283
		// (get) Token: 0x06035BA5 RID: 220069
		// (set) Token: 0x06035BA6 RID: 220070
		int Cost { get; set; }

		// Token: 0x17008204 RID: 33284
		// (get) Token: 0x06035BA7 RID: 220071
		// (set) Token: 0x06035BA8 RID: 220072
		int Attack { get; set; }

		// Token: 0x17008205 RID: 33285
		// (get) Token: 0x06035BA9 RID: 220073
		// (set) Token: 0x06035BAA RID: 220074
		int Life { get; set; }
	}
}
