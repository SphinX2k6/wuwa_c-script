using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051ED RID: 20973
	public class IExploreSkillInteractTypeT
	{
		// Token: 0x170099A3 RID: 39331
		// (get) Token: 0x060220F4 RID: 139508 RVA: 0x004BA3E2 File Offset: 0x004B85E2
		// (set) Token: 0x060220F5 RID: 139509 RVA: 0x004BA3EA File Offset: 0x004B85EA
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x060220F6 RID: 139510 RVA: 0x004BA3F3 File Offset: 0x004B85F3
		public IExploreSkillInteractTypeT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
