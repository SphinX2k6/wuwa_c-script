using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BFB RID: 7163
	public class IFireBulletTrackTarget_SetValue
	{
		// Token: 0x04005DBB RID: 23995
		public EFireBulletType Type;

		// Token: 0x04005DBC RID: 23996
		public long BulletId;

		// Token: 0x04005DBD RID: 23997
		public ITargetEntityType Launcher;

		// Token: 0x04005DBE RID: 23998
		public ITargetEntityType Target;

		// Token: 0x04005DBF RID: 23999
		public bool? WaitDestroy;
	}
}
