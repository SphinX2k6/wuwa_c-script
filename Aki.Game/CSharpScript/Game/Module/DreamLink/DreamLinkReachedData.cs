using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB1 RID: 23217
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkReachedData : IDreamLinkReachedData
	{
		// Token: 0x17008C19 RID: 35865
		// (get) Token: 0x0603ACF4 RID: 240884 RVA: 0x00E03376 File Offset: 0x00E01576
		// (set) Token: 0x0603ACF5 RID: 240885 RVA: 0x00E0337E File Offset: 0x00E0157E
		public string Title { get; set; }

		// Token: 0x17008C1A RID: 35866
		// (get) Token: 0x0603ACF6 RID: 240886 RVA: 0x00E03387 File Offset: 0x00E01587
		// (set) Token: 0x0603ACF7 RID: 240887 RVA: 0x00E0338F File Offset: 0x00E0158F
		public string Score { get; set; }

		// Token: 0x17008C1B RID: 35867
		// (get) Token: 0x0603ACF8 RID: 240888 RVA: 0x00E03398 File Offset: 0x00E01598
		// (set) Token: 0x0603ACF9 RID: 240889 RVA: 0x00E033A0 File Offset: 0x00E015A0
		public bool IsReached { get; set; }
	}
}
