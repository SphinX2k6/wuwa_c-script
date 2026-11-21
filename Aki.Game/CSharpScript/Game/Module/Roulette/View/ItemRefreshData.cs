using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C4A RID: 15434
	[NullableContext(2)]
	[Nullable(0)]
	public class ItemRefreshData
	{
		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x06027886 RID: 161926 RVA: 0x00B17401 File Offset: 0x00B15601
		// (set) Token: 0x06027887 RID: 161927 RVA: 0x00B17409 File Offset: 0x00B15609
		public int ItemId { get; set; }

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x06027888 RID: 161928 RVA: 0x00B17412 File Offset: 0x00B15612
		// (set) Token: 0x06027889 RID: 161929 RVA: 0x00B1741A File Offset: 0x00B1561A
		public bool NeedLock { get; set; }

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x0602788A RID: 161930 RVA: 0x00B17423 File Offset: 0x00B15623
		// (set) Token: 0x0602788B RID: 161931 RVA: 0x00B1742B File Offset: 0x00B1562B
		public string Text { get; set; }
	}
}
