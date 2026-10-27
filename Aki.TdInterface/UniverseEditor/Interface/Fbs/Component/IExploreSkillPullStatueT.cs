using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FC RID: 20988
	public class IExploreSkillPullStatueT
	{
		// Token: 0x170099BF RID: 39359
		// (get) Token: 0x06022196 RID: 139670 RVA: 0x004BB8B1 File Offset: 0x004B9AB1
		// (set) Token: 0x06022197 RID: 139671 RVA: 0x004BB8B9 File Offset: 0x004B9AB9
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x170099C0 RID: 39360
		// (get) Token: 0x06022198 RID: 139672 RVA: 0x004BB8C2 File Offset: 0x004B9AC2
		// (set) Token: 0x06022199 RID: 139673 RVA: 0x004BB8CA File Offset: 0x004B9ACA
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x170099C1 RID: 39361
		// (get) Token: 0x0602219A RID: 139674 RVA: 0x004BB8D3 File Offset: 0x004B9AD3
		// (set) Token: 0x0602219B RID: 139675 RVA: 0x004BB8DB File Offset: 0x004B9ADB
		public int StatueInteractPointId { get; set; }

		// Token: 0x0602219C RID: 139676 RVA: 0x004BB8E4 File Offset: 0x004B9AE4
		public IExploreSkillPullStatueT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Condition = null;
			this.StatueInteractPointId = 0;
		}
	}
}
