using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056B5 RID: 22197
	public class DangoBrawlRetryCountInfo
	{
		// Token: 0x06036D2E RID: 224558 RVA: 0x00F4B58D File Offset: 0x00F4978D
		public DangoBrawlRetryCountInfo(bool hasRetry, bool needAnim = false)
		{
			this.HasRetry = hasRetry;
			this.NeedAnim = needAnim;
		}

		// Token: 0x0401CF27 RID: 118567
		public bool HasRetry;

		// Token: 0x0401CF28 RID: 118568
		public bool NeedAnim;
	}
}
