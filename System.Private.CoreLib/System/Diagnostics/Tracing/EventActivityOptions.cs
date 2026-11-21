using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008D1 RID: 2257
	[Flags]
	public enum EventActivityOptions
	{
		// Token: 0x04001F49 RID: 8009
		None = 0,
		// Token: 0x04001F4A RID: 8010
		Disable = 2,
		// Token: 0x04001F4B RID: 8011
		Recursive = 4,
		// Token: 0x04001F4C RID: 8012
		Detachable = 8
	}
}
