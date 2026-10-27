using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A64 RID: 6756
	public class IFireBulletTrackPosition_SetValue
	{
		// Token: 0x04005950 RID: 22864
		public EFireBulletType Type;

		// Token: 0x04005951 RID: 22865
		public long BulletId;

		// Token: 0x04005952 RID: 22866
		[Nullable(1)]
		public ITargetEntityType Launcher;

		// Token: 0x04005953 RID: 22867
		public int PositionEntityId;
	}
}
