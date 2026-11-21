using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215C RID: 8540
	public class ITalkCommonEffect_SetValue
	{
		// Token: 0x04006B29 RID: 27433
		public ETalkEffectType Type;

		// Token: 0x04006B2A RID: 27434
		public string Path;

		// Token: 0x04006B2B RID: 27435
		public IAbsolutePos2 Pos2;

		// Token: 0x04006B2C RID: 27436
		public bool? StartFromLoop;
	}
}
