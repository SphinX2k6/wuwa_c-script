using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A66 RID: 6758
	[NullableContext(1)]
	[Nullable(0)]
	public class IFireBulletTrackTarget_SetValue
	{
		// Token: 0x04005956 RID: 22870
		public EFireBulletType Type;

		// Token: 0x04005957 RID: 22871
		public long BulletId;

		// Token: 0x04005958 RID: 22872
		public ITargetEntityType Launcher;

		// Token: 0x04005959 RID: 22873
		public ITargetEntityType Target;

		// Token: 0x0400595A RID: 22874
		public bool? WaitDestroy;
	}
}
