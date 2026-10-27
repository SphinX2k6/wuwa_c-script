using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005086 RID: 20614
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAvgMoveComponentPlayContext : IPlotAvgMoveComponentPlayContext
	{
		// Token: 0x17008079 RID: 32889
		// (get) Token: 0x06034CF6 RID: 216310 RVA: 0x00C7DC12 File Offset: 0x00C7BE12
		// (set) Token: 0x06034CF7 RID: 216311 RVA: 0x00C7DC1A File Offset: 0x00C7BE1A
		public IPlotAvgCharacterMove AvgCharacter { get; set; }

		// Token: 0x1700807A RID: 32890
		// (get) Token: 0x06034CF8 RID: 216312 RVA: 0x00C7DC23 File Offset: 0x00C7BE23
		// (set) Token: 0x06034CF9 RID: 216313 RVA: 0x00C7DC2B File Offset: 0x00C7BE2B
		public float StartPosition { get; set; }

		// Token: 0x1700807B RID: 32891
		// (get) Token: 0x06034CFA RID: 216314 RVA: 0x00C7DC34 File Offset: 0x00C7BE34
		// (set) Token: 0x06034CFB RID: 216315 RVA: 0x00C7DC3C File Offset: 0x00C7BE3C
		public float EndPosition { get; set; }

		// Token: 0x1700807C RID: 32892
		// (get) Token: 0x06034CFC RID: 216316 RVA: 0x00C7DC45 File Offset: 0x00C7BE45
		// (set) Token: 0x06034CFD RID: 216317 RVA: 0x00C7DC4D File Offset: 0x00C7BE4D
		public LTweenEase Ease { get; set; }

		// Token: 0x1700807D RID: 32893
		// (get) Token: 0x06034CFE RID: 216318 RVA: 0x00C7DC56 File Offset: 0x00C7BE56
		// (set) Token: 0x06034CFF RID: 216319 RVA: 0x00C7DC5E File Offset: 0x00C7BE5E
		public float Duration { get; set; }
	}
}
