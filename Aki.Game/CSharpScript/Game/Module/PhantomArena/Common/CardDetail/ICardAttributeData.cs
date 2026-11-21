using System;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E0 RID: 16864
	public interface ICardAttributeData
	{
		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x0602AAA0 RID: 174752
		// (set) Token: 0x0602AAA1 RID: 174753
		int Cost { get; set; }

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x0602AAA2 RID: 174754
		// (set) Token: 0x0602AAA3 RID: 174755
		int Attack { get; set; }

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x0602AAA4 RID: 174756
		// (set) Token: 0x0602AAA5 RID: 174757
		int Life { get; set; }
	}
}
