using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FEB RID: 20459
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewTalkItemData
	{
		// Token: 0x17007FD2 RID: 32722
		// (get) Token: 0x060345B9 RID: 214457 RVA: 0x00C4D8C5 File Offset: 0x00C4BAC5
		// (set) Token: 0x060345BA RID: 214458 RVA: 0x00C4D8CD File Offset: 0x00C4BACD
		public ITalkItem TalkItem { get; set; } = new ITalkItem();

		// Token: 0x17007FD3 RID: 32723
		// (get) Token: 0x060345BB RID: 214459 RVA: 0x00C4D8D6 File Offset: 0x00C4BAD6
		// (set) Token: 0x060345BC RID: 214460 RVA: 0x00C4D8DE File Offset: 0x00C4BADE
		public bool IsPlaying { get; set; }
	}
}
