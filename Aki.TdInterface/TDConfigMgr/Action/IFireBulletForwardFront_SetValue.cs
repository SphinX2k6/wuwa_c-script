using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A62 RID: 6754
	public class IFireBulletForwardFront_SetValue
	{
		// Token: 0x0400594B RID: 22859
		public EFireBulletType Type;

		// Token: 0x0400594C RID: 22860
		public long BulletId;

		// Token: 0x0400594D RID: 22861
		[Nullable(1)]
		public ITargetEntityType Launcher;
	}
}
