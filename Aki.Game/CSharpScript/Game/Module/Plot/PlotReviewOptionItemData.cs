using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB6 RID: 16310
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewOptionItemData
	{
		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x06029449 RID: 169033 RVA: 0x00B9795A File Offset: 0x00B95B5A
		// (set) Token: 0x0602944A RID: 169034 RVA: 0x00B97962 File Offset: 0x00B95B62
		public ITalkItem TalkItem { get; set; } = new ITalkItem();

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x0602944B RID: 169035 RVA: 0x00B9796B File Offset: 0x00B95B6B
		// (set) Token: 0x0602944C RID: 169036 RVA: 0x00B97973 File Offset: 0x00B95B73
		public int OptionIndex { get; set; }
	}
}
