using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006765 RID: 26469
	public class DangoBrawlRetryCountInfo
	{
		// Token: 0x060421D8 RID: 270808 RVA: 0x0100A1A9 File Offset: 0x010083A9
		public DangoBrawlRetryCountInfo(bool hasRetry, bool needAnim = false)
		{
			this.HasRetry = hasRetry;
			this.NeedAnim = needAnim;
		}

		// Token: 0x040226CA RID: 141002
		public bool HasRetry;

		// Token: 0x040226CB RID: 141003
		public bool NeedAnim;
	}
}
