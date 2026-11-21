using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200403E RID: 16446
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotWordArtViewParams
	{
		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x06029B06 RID: 170758 RVA: 0x00BC8C9F File Offset: 0x00BC6E9F
		// (set) Token: 0x06029B07 RID: 170759 RVA: 0x00BC8CA7 File Offset: 0x00BC6EA7
		public ITransitionPopupYuanChengArtText Config { get; set; }

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x06029B08 RID: 170760 RVA: 0x00BC8CB0 File Offset: 0x00BC6EB0
		// (set) Token: 0x06029B09 RID: 170761 RVA: 0x00BC8CB8 File Offset: 0x00BC6EB8
		public float? Duration { get; set; }
	}
}
