using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200627F RID: 25215
	public class ICameraLockConfigT
	{
		// Token: 0x1700BBF7 RID: 48119
		// (get) Token: 0x0602B87F RID: 178303 RVA: 0x005FE537 File Offset: 0x005FC737
		// (set) Token: 0x0602B880 RID: 178304 RVA: 0x005FE53F File Offset: 0x005FC73F
		public ICameraLockTargetPositionT LockTarget { get; set; }

		// Token: 0x1700BBF8 RID: 48120
		// (get) Token: 0x0602B881 RID: 178305 RVA: 0x005FE548 File Offset: 0x005FC748
		// (set) Token: 0x0602B882 RID: 178306 RVA: 0x005FE550 File Offset: 0x005FC750
		public ICameraLockParamsT CameraParams { get; set; }

		// Token: 0x0602B883 RID: 178307 RVA: 0x005FE559 File Offset: 0x005FC759
		public ICameraLockConfigT()
		{
			this.LockTarget = null;
			this.CameraParams = null;
		}
	}
}
