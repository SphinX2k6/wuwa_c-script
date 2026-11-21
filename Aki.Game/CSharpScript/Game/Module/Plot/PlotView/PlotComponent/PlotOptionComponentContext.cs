using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004052 RID: 16466
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotOptionComponentContext
	{
		// Token: 0x1700542E RID: 21550
		// (get) Token: 0x06029BD2 RID: 170962 RVA: 0x00BCAF74 File Offset: 0x00BC9174
		// (set) Token: 0x06029BD3 RID: 170963 RVA: 0x00BCAF7C File Offset: 0x00BC917C
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<ITalkOption[]> OptionsRefreshDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x1700542F RID: 21551
		// (get) Token: 0x06029BD4 RID: 170964 RVA: 0x00BCAF85 File Offset: 0x00BC9185
		// (set) Token: 0x06029BD5 RID: 170965 RVA: 0x00BCAF8D File Offset: 0x00BC918D
		public Action OptionsShowDelegate { get; set; }

		// Token: 0x17005430 RID: 21552
		// (get) Token: 0x06029BD6 RID: 170966 RVA: 0x00BCAF96 File Offset: 0x00BC9196
		// (set) Token: 0x06029BD7 RID: 170967 RVA: 0x00BCAF9E File Offset: 0x00BC919E
		public Action OptionsHideDelegate { get; set; }
	}
}
