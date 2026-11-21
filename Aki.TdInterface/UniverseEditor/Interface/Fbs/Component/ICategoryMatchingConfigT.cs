using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005494 RID: 21652
	public class ICategoryMatchingConfigT
	{
		// Token: 0x17009A38 RID: 39480
		// (get) Token: 0x06022117 RID: 139543 RVA: 0x004B24B5 File Offset: 0x004B06B5
		// (set) Token: 0x06022118 RID: 139544 RVA: 0x004B24BD File Offset: 0x004B06BD
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x17009A39 RID: 39481
		// (get) Token: 0x06022119 RID: 139545 RVA: 0x004B24C6 File Offset: 0x004B06C6
		// (set) Token: 0x0602211A RID: 139546 RVA: 0x004B24CE File Offset: 0x004B06CE
		public ICategoryMatchingAnimationT Animation { get; set; }

		// Token: 0x17009A3A RID: 39482
		// (get) Token: 0x0602211B RID: 139547 RVA: 0x004B24D7 File Offset: 0x004B06D7
		// (set) Token: 0x0602211C RID: 139548 RVA: 0x004B24DF File Offset: 0x004B06DF
		public ICategoryMatchingSucceedT Callback { get; set; }

		// Token: 0x17009A3B RID: 39483
		// (get) Token: 0x0602211D RID: 139549 RVA: 0x004B24E8 File Offset: 0x004B06E8
		// (set) Token: 0x0602211E RID: 139550 RVA: 0x004B24F0 File Offset: 0x004B06F0
		public IItemLockingConfigT ItemLockingConfig { get; set; }

		// Token: 0x0602211F RID: 139551 RVA: 0x004B24F9 File Offset: 0x004B06F9
		public ICategoryMatchingConfigT()
		{
			this.Condition = null;
			this.Animation = null;
			this.Callback = null;
			this.ItemLockingConfig = null;
		}
	}
}
