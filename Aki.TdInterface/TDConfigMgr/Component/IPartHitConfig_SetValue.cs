using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005BF RID: 1471
	public class IPartHitConfig_SetValue
	{
		// Token: 0x04001616 RID: 5654
		[Nullable(1)]
		public string PartName;

		// Token: 0x04001617 RID: 5655
		[Nullable(2)]
		public IHitBulletType HitBullets;

		// Token: 0x04001618 RID: 5656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
