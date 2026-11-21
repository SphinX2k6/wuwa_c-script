using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F0 RID: 26864
	public class ICameraLockConfigT
	{
		// Token: 0x1700C57F RID: 50559
		// (get) Token: 0x0602DFE0 RID: 188384 RVA: 0x0064933F File Offset: 0x0064753F
		// (set) Token: 0x0602DFE1 RID: 188385 RVA: 0x00649347 File Offset: 0x00647547
		public ICameraLockTargetPositionT LockTarget { get; set; }

		// Token: 0x1700C580 RID: 50560
		// (get) Token: 0x0602DFE2 RID: 188386 RVA: 0x00649350 File Offset: 0x00647550
		// (set) Token: 0x0602DFE3 RID: 188387 RVA: 0x00649358 File Offset: 0x00647558
		public ICameraLockParamsT CameraParams { get; set; }

		// Token: 0x0602DFE4 RID: 188388 RVA: 0x00649361 File Offset: 0x00647561
		public ICameraLockConfigT()
		{
			this.LockTarget = null;
			this.CameraParams = null;
		}
	}
}
