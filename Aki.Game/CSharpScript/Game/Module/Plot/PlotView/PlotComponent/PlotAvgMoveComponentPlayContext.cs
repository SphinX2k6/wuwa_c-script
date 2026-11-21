using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004056 RID: 16470
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAvgMoveComponentPlayContext : IPlotAvgMoveComponentPlayContext
	{
		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x06029BEB RID: 170987 RVA: 0x00BCAFEA File Offset: 0x00BC91EA
		// (set) Token: 0x06029BEC RID: 170988 RVA: 0x00BCAFF2 File Offset: 0x00BC91F2
		public IPlotAvgCharacterMove AvgCharacter { get; set; }

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x06029BED RID: 170989 RVA: 0x00BCAFFB File Offset: 0x00BC91FB
		// (set) Token: 0x06029BEE RID: 170990 RVA: 0x00BCB003 File Offset: 0x00BC9203
		public float StartPosition { get; set; }

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x06029BEF RID: 170991 RVA: 0x00BCB00C File Offset: 0x00BC920C
		// (set) Token: 0x06029BF0 RID: 170992 RVA: 0x00BCB014 File Offset: 0x00BC9214
		public float EndPosition { get; set; }

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x06029BF1 RID: 170993 RVA: 0x00BCB01D File Offset: 0x00BC921D
		// (set) Token: 0x06029BF2 RID: 170994 RVA: 0x00BCB025 File Offset: 0x00BC9225
		public LTweenEase Ease { get; set; }

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x06029BF3 RID: 170995 RVA: 0x00BCB02E File Offset: 0x00BC922E
		// (set) Token: 0x06029BF4 RID: 170996 RVA: 0x00BCB036 File Offset: 0x00BC9236
		public float Duration { get; set; }
	}
}
