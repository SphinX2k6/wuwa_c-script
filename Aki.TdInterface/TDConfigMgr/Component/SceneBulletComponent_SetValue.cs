using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088A RID: 2186
	public class SceneBulletComponent_SetValue
	{
		// Token: 0x04002011 RID: 8209
		public bool? Disabled;

		// Token: 0x04002012 RID: 8210
		public bool? EdIsLocked;

		// Token: 0x04002013 RID: 8211
		public bool? DisableGenerateByRange;

		// Token: 0x04002014 RID: 8212
		[Nullable(1)]
		public List<ISceneBulletGroup> BulletGroups;
	}
}
