using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E1 RID: 16865
	public class CardAttributeData : ICardAttributeData
	{
		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x0602AAA6 RID: 174758 RVA: 0x00C05D1C File Offset: 0x00C03F1C
		// (set) Token: 0x0602AAA7 RID: 174759 RVA: 0x00C05D24 File Offset: 0x00C03F24
		public int Cost { get; set; }

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x0602AAA8 RID: 174760 RVA: 0x00C05D2D File Offset: 0x00C03F2D
		// (set) Token: 0x0602AAA9 RID: 174761 RVA: 0x00C05D35 File Offset: 0x00C03F35
		public int Attack { get; set; }

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x0602AAAA RID: 174762 RVA: 0x00C05D3E File Offset: 0x00C03F3E
		// (set) Token: 0x0602AAAB RID: 174763 RVA: 0x00C05D46 File Offset: 0x00C03F46
		public int Life { get; set; }
	}
}
