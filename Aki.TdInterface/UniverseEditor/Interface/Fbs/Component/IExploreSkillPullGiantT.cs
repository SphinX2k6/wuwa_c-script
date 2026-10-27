using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F9 RID: 20985
	public class IExploreSkillPullGiantT
	{
		// Token: 0x170099B8 RID: 39352
		// (get) Token: 0x0602217C RID: 139644 RVA: 0x004BB595 File Offset: 0x004B9795
		// (set) Token: 0x0602217D RID: 139645 RVA: 0x004BB59D File Offset: 0x004B979D
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x170099B9 RID: 39353
		// (get) Token: 0x0602217E RID: 139646 RVA: 0x004BB5A6 File Offset: 0x004B97A6
		// (set) Token: 0x0602217F RID: 139647 RVA: 0x004BB5AE File Offset: 0x004B97AE
		public float PullTime { get; set; }

		// Token: 0x170099BA RID: 39354
		// (get) Token: 0x06022180 RID: 139648 RVA: 0x004BB5B7 File Offset: 0x004B97B7
		// (set) Token: 0x06022181 RID: 139649 RVA: 0x004BB5BF File Offset: 0x004B97BF
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06022182 RID: 139650 RVA: 0x004BB5C8 File Offset: 0x004B97C8
		public IExploreSkillPullGiantT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.PullTime = 0f;
			this.Actions = null;
		}
	}
}
