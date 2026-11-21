using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B8 RID: 16824
	public class CardEffectCountComponentData : ICardEffectCountComponentData
	{
		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x0602A941 RID: 174401 RVA: 0x00C023DF File Offset: 0x00C005DF
		// (set) Token: 0x0602A942 RID: 174402 RVA: 0x00C023E7 File Offset: 0x00C005E7
		public int EffectCount { get; set; }

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x0602A943 RID: 174403 RVA: 0x00C023F0 File Offset: 0x00C005F0
		// (set) Token: 0x0602A944 RID: 174404 RVA: 0x00C023F8 File Offset: 0x00C005F8
		public int EffectCountMax { get; set; }

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x0602A945 RID: 174405 RVA: 0x00C02401 File Offset: 0x00C00601
		// (set) Token: 0x0602A946 RID: 174406 RVA: 0x00C02409 File Offset: 0x00C00609
		public bool InFight { get; set; }
	}
}
