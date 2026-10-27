using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F23 RID: 7971
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkCommonEffect_SetValue
	{
		// Token: 0x0400653A RID: 25914
		public ETalkEffectType Type;

		// Token: 0x0400653B RID: 25915
		public string Path;

		// Token: 0x0400653C RID: 25916
		public IAbsolutePos2 Pos2;

		// Token: 0x0400653D RID: 25917
		public bool? StartFromLoop;
	}
}
