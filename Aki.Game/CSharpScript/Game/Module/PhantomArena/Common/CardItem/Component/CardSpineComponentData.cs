using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C3 RID: 16835
	[NullableContext(1)]
	[Nullable(0)]
	public class CardSpineComponentData : ICardSpineComponentData
	{
		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x0602A984 RID: 174468 RVA: 0x00C02CDE File Offset: 0x00C00EDE
		// (set) Token: 0x0602A985 RID: 174469 RVA: 0x00C02CE6 File Offset: 0x00C00EE6
		public CardSpineData CardSpineData { get; set; }

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x0602A986 RID: 174470 RVA: 0x00C02CEF File Offset: 0x00C00EEF
		// (set) Token: 0x0602A987 RID: 174471 RVA: 0x00C02CF7 File Offset: 0x00C00EF7
		public bool ShowSpine { get; set; }
	}
}
