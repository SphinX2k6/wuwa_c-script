using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B1 RID: 16817
	[NullableContext(1)]
	[Nullable(0)]
	public class CardCheckComponentData : ICardCheckComponentData
	{
		// Token: 0x17005581 RID: 21889
		// (get) Token: 0x0602A91C RID: 174364 RVA: 0x00C02143 File Offset: 0x00C00343
		// (set) Token: 0x0602A91D RID: 174365 RVA: 0x00C0214B File Offset: 0x00C0034B
		public int LeftCount { get; set; }

		// Token: 0x17005582 RID: 21890
		// (get) Token: 0x0602A91E RID: 174366 RVA: 0x00C02154 File Offset: 0x00C00354
		// (set) Token: 0x0602A91F RID: 174367 RVA: 0x00C0215C File Offset: 0x00C0035C
		public int MaxCount { get; set; }

		// Token: 0x17005583 RID: 21891
		// (get) Token: 0x0602A920 RID: 174368 RVA: 0x00C02165 File Offset: 0x00C00365
		// (set) Token: 0x0602A921 RID: 174369 RVA: 0x00C0216D File Offset: 0x00C0036D
		public Action OnCheckBtnClick { get; set; }
	}
}
