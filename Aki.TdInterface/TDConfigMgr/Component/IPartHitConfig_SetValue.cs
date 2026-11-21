using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200062A RID: 1578
	public class IPartHitConfig_SetValue
	{
		// Token: 0x0400178A RID: 6026
		public string PartName;

		// Token: 0x0400178B RID: 6027
		[Nullable(2)]
		public IHitBulletType HitBullets;

		// Token: 0x0400178C RID: 6028
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
