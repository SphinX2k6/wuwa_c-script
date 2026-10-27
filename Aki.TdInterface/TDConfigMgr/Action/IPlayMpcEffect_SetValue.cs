using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D19 RID: 7449
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayMpcEffect_SetValue
	{
		// Token: 0x04006063 RID: 24675
		public EEffectType Type;

		// Token: 0x04006064 RID: 24676
		public string Path;

		// Token: 0x04006065 RID: 24677
		public IBasePos2 Pos2;

		// Token: 0x04006066 RID: 24678
		public List<IPostProcessVolumeCenterPosition> Params;
	}
}
