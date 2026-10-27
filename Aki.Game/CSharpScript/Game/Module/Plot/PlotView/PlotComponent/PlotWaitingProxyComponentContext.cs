using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005083 RID: 20611
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWaitingProxyComponentContext
	{
		// Token: 0x17008071 RID: 32881
		// (get) Token: 0x06034CE4 RID: 216292 RVA: 0x00C7DBD7 File Offset: 0x00C7BDD7
		// (set) Token: 0x06034CE5 RID: 216293 RVA: 0x00C7DBDF File Offset: 0x00C7BDDF
		public Action OnWaitingStartDelegate { get; set; }

		// Token: 0x17008072 RID: 32882
		// (get) Token: 0x06034CE6 RID: 216294 RVA: 0x00C7DBE8 File Offset: 0x00C7BDE8
		// (set) Token: 0x06034CE7 RID: 216295 RVA: 0x00C7DBF0 File Offset: 0x00C7BDF0
		public Action OnWaitingCompleteDelegate { get; set; }

		// Token: 0x17008073 RID: 32883
		// (get) Token: 0x06034CE8 RID: 216296 RVA: 0x00C7DBF9 File Offset: 0x00C7BDF9
		// (set) Token: 0x06034CE9 RID: 216297 RVA: 0x00C7DC01 File Offset: 0x00C7BE01
		public Action OnWaitingCancelDelegate { get; set; }
	}
}
