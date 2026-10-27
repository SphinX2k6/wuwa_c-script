using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200479D RID: 18333
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListItemData : IActivityListItemData
	{
		// Token: 0x170077F7 RID: 30711
		// (get) Token: 0x0602FF13 RID: 196371 RVA: 0x00B19D4E File Offset: 0x00B17F4E
		// (set) Token: 0x0602FF14 RID: 196372 RVA: 0x00B19D56 File Offset: 0x00B17F56
		public EMapPeriodicActivityId Id { get; set; }

		// Token: 0x170077F8 RID: 30712
		// (get) Token: 0x0602FF15 RID: 196373 RVA: 0x00B19D5F File Offset: 0x00B17F5F
		// (set) Token: 0x0602FF16 RID: 196374 RVA: 0x00B19D67 File Offset: 0x00B17F67
		public double LeftTime { get; set; }

		// Token: 0x170077F9 RID: 30713
		// (get) Token: 0x0602FF17 RID: 196375 RVA: 0x00B19D70 File Offset: 0x00B17F70
		// (set) Token: 0x0602FF18 RID: 196376 RVA: 0x00B19D78 File Offset: 0x00B17F78
		public string LeftTimeText { get; set; }

		// Token: 0x170077FA RID: 30714
		// (get) Token: 0x0602FF19 RID: 196377 RVA: 0x00B19D81 File Offset: 0x00B17F81
		// (set) Token: 0x0602FF1A RID: 196378 RVA: 0x00B19D89 File Offset: 0x00B17F89
		public int CurrentNum { get; set; }

		// Token: 0x170077FB RID: 30715
		// (get) Token: 0x0602FF1B RID: 196379 RVA: 0x00B19D92 File Offset: 0x00B17F92
		// (set) Token: 0x0602FF1C RID: 196380 RVA: 0x00B19D9A File Offset: 0x00B17F9A
		public int TotalNum { get; set; }

		// Token: 0x170077FC RID: 30716
		// (get) Token: 0x0602FF1D RID: 196381 RVA: 0x00B19DA3 File Offset: 0x00B17FA3
		// (set) Token: 0x0602FF1E RID: 196382 RVA: 0x00B19DAB File Offset: 0x00B17FAB
		public bool IsFinish { get; set; }

		// Token: 0x170077FD RID: 30717
		// (get) Token: 0x0602FF1F RID: 196383 RVA: 0x00B19DB4 File Offset: 0x00B17FB4
		// (set) Token: 0x0602FF20 RID: 196384 RVA: 0x00B19DBC File Offset: 0x00B17FBC
		public bool RedPoint { get; set; }

		// Token: 0x170077FE RID: 30718
		// (get) Token: 0x0602FF21 RID: 196385 RVA: 0x00B19DC5 File Offset: 0x00B17FC5
		// (set) Token: 0x0602FF22 RID: 196386 RVA: 0x00B19DCD File Offset: 0x00B17FCD
		public Action OnClickCb { get; set; }

		// Token: 0x170077FF RID: 30719
		// (get) Token: 0x0602FF23 RID: 196387 RVA: 0x00B19DD6 File Offset: 0x00B17FD6
		// (set) Token: 0x0602FF24 RID: 196388 RVA: 0x00B19DDE File Offset: 0x00B17FDE
		public Action<IActivityListItemData> OnLeftTimeRefreshCb { get; set; }
	}
}
