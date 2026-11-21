using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2A RID: 7978
	public class IPlayMpcEffect_SetValue
	{
		// Token: 0x040065DF RID: 26079
		public EEffectType Type;

		// Token: 0x040065E0 RID: 26080
		public string Path;

		// Token: 0x040065E1 RID: 26081
		public IBasePos2 Pos2;

		// Token: 0x040065E2 RID: 26082
		public List<IPostProcessVolumeCenterPosition> Params;
	}
}
