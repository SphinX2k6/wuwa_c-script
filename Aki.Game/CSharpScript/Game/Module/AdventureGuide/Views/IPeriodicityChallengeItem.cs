using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005EDC RID: 24284
	[NullableContext(1)]
	[Nullable(0)]
	public class IPeriodicityChallengeItem
	{
		// Token: 0x17008EE5 RID: 36581
		// (get) Token: 0x0603DBA8 RID: 252840 RVA: 0x00EEA20E File Offset: 0x00EE840E
		// (set) Token: 0x0603DBA9 RID: 252841 RVA: 0x00EEA216 File Offset: 0x00EE8416
		public SoundAreaDetectionRecord Data { get; set; }

		// Token: 0x17008EE6 RID: 36582
		// (get) Token: 0x0603DBAA RID: 252842 RVA: 0x00EEA21F File Offset: 0x00EE841F
		// (set) Token: 0x0603DBAB RID: 252843 RVA: 0x00EEA227 File Offset: 0x00EE8427
		public bool Title { get; set; }

		// Token: 0x17008EE7 RID: 36583
		// (get) Token: 0x0603DBAC RID: 252844 RVA: 0x00EEA230 File Offset: 0x00EE8430
		// (set) Token: 0x0603DBAD RID: 252845 RVA: 0x00EEA238 File Offset: 0x00EE8438
		[Nullable(2)]
		public IPeriodicityChallengeTopTips TopTips { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
