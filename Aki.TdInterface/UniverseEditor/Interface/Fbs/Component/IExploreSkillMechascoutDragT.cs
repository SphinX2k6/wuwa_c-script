using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F6 RID: 20982
	public class IExploreSkillMechascoutDragT
	{
		// Token: 0x170099AF RID: 39343
		// (get) Token: 0x06022158 RID: 139608 RVA: 0x004BB0D8 File Offset: 0x004B92D8
		// (set) Token: 0x06022159 RID: 139609 RVA: 0x004BB0E0 File Offset: 0x004B92E0
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x170099B0 RID: 39344
		// (get) Token: 0x0602215A RID: 139610 RVA: 0x004BB0E9 File Offset: 0x004B92E9
		// (set) Token: 0x0602215B RID: 139611 RVA: 0x004BB0F1 File Offset: 0x004B92F1
		public TMechascoutDragTypeUnion DragType { get; set; }

		// Token: 0x170099B1 RID: 39345
		// (get) Token: 0x0602215C RID: 139612 RVA: 0x004BB0FA File Offset: 0x004B92FA
		// (set) Token: 0x0602215D RID: 139613 RVA: 0x004BB102 File Offset: 0x004B9302
		public List<int> TriggerPointList { get; set; }

		// Token: 0x170099B2 RID: 39346
		// (get) Token: 0x0602215E RID: 139614 RVA: 0x004BB10B File Offset: 0x004B930B
		// (set) Token: 0x0602215F RID: 139615 RVA: 0x004BB113 File Offset: 0x004B9313
		public List<IActionInfoT> FinishedActions { get; set; }

		// Token: 0x170099B3 RID: 39347
		// (get) Token: 0x06022160 RID: 139616 RVA: 0x004BB11C File Offset: 0x004B931C
		// (set) Token: 0x06022161 RID: 139617 RVA: 0x004BB124 File Offset: 0x004B9324
		public byte NullMask { get; set; }

		// Token: 0x06022162 RID: 139618 RVA: 0x004BB12D File Offset: 0x004B932D
		public IExploreSkillMechascoutDragT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.DragType = null;
			this.TriggerPointList = null;
			this.FinishedActions = null;
			this.NullMask = 0;
		}
	}
}
