using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200506B RID: 20587
	[NullableContext(2)]
	[Nullable(0)]
	public class ViewHandle
	{
		// Token: 0x1700803B RID: 32827
		// (get) Token: 0x06034BC2 RID: 216002 RVA: 0x00C7A062 File Offset: 0x00C78262
		// (set) Token: 0x06034BC3 RID: 216003 RVA: 0x00C7A06A File Offset: 0x00C7826A
		public EUiViewName? ViewName { get; set; }

		// Token: 0x1700803C RID: 32828
		// (get) Token: 0x06034BC4 RID: 216004 RVA: 0x00C7A073 File Offset: 0x00C78273
		// (set) Token: 0x06034BC5 RID: 216005 RVA: 0x00C7A07B File Offset: 0x00C7827B
		public UiParam Param { get; set; }

		// Token: 0x1700803D RID: 32829
		// (get) Token: 0x06034BC6 RID: 216006 RVA: 0x00C7A084 File Offset: 0x00C78284
		// (set) Token: 0x06034BC7 RID: 216007 RVA: 0x00C7A08C File Offset: 0x00C7828C
		public TCallback Callback { get; set; }

		// Token: 0x1700803E RID: 32830
		// (get) Token: 0x06034BC8 RID: 216008 RVA: 0x00C7A095 File Offset: 0x00C78295
		// (set) Token: 0x06034BC9 RID: 216009 RVA: 0x00C7A09D File Offset: 0x00C7829D
		public long? OwnerId { get; set; }

		// Token: 0x06034BCA RID: 216010 RVA: 0x00C7A0A6 File Offset: 0x00C782A6
		public ViewHandle(EUiViewName? viewName = null, UiParam param = null, TCallback callback = null, long? ownerId = null)
		{
			this.ViewName = viewName;
			this.Param = param;
			this.Callback = callback;
			this.OwnerId = ownerId;
		}
	}
}
