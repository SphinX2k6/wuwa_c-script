using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B7 RID: 16823
	public interface ICardEffectCountComponentData
	{
		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x0602A93B RID: 174395
		// (set) Token: 0x0602A93C RID: 174396
		int EffectCount { get; set; }

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x0602A93D RID: 174397
		// (set) Token: 0x0602A93E RID: 174398
		int EffectCountMax { get; set; }

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x0602A93F RID: 174399
		// (set) Token: 0x0602A940 RID: 174400
		bool InFight { get; set; }
	}
}
