using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EC3 RID: 20163
	[NullableContext(1)]
	[Nullable(0)]
	public class IPeriodicityChallengeItem
	{
		// Token: 0x170062B7 RID: 25271
		// (get) Token: 0x06032B43 RID: 207683 RVA: 0x00E3BEC5 File Offset: 0x00E3A0C5
		// (set) Token: 0x06032B44 RID: 207684 RVA: 0x00E3BECD File Offset: 0x00E3A0CD
		public SoundAreaDetectionRecord Data { get; set; }

		// Token: 0x170062B8 RID: 25272
		// (get) Token: 0x06032B45 RID: 207685 RVA: 0x00E3BED6 File Offset: 0x00E3A0D6
		// (set) Token: 0x06032B46 RID: 207686 RVA: 0x00E3BEDE File Offset: 0x00E3A0DE
		public bool Title { get; set; }

		// Token: 0x170062B9 RID: 25273
		// (get) Token: 0x06032B47 RID: 207687 RVA: 0x00E3BEE7 File Offset: 0x00E3A0E7
		// (set) Token: 0x06032B48 RID: 207688 RVA: 0x00E3BEEF File Offset: 0x00E3A0EF
		[Nullable(2)]
		public IPeriodicityChallengeTopTips TopTips { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
