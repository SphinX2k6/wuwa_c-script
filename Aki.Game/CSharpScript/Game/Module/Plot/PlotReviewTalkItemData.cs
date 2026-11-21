using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB5 RID: 16309
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotReviewTalkItemData
	{
		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x06029442 RID: 169026 RVA: 0x00B9790D File Offset: 0x00B95B0D
		// (set) Token: 0x06029443 RID: 169027 RVA: 0x00B97915 File Offset: 0x00B95B15
		public ITalkItem TalkItem { get; set; } = new ITalkItem();

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x06029444 RID: 169028 RVA: 0x00B9791E File Offset: 0x00B95B1E
		// (set) Token: 0x06029445 RID: 169029 RVA: 0x00B97926 File Offset: 0x00B95B26
		public bool IsPlaying { get; set; }

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06029446 RID: 169030 RVA: 0x00B9792F File Offset: 0x00B95B2F
		// (set) Token: 0x06029447 RID: 169031 RVA: 0x00B97937 File Offset: 0x00B95B37
		public bool ShowSpeakerName { get; set; } = true;
	}
}
