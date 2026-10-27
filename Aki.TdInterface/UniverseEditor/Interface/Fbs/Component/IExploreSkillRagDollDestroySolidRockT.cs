using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005205 RID: 20997
	public class IExploreSkillRagDollDestroySolidRockT
	{
		// Token: 0x170099D0 RID: 39376
		// (get) Token: 0x060221E2 RID: 139746 RVA: 0x004BC0D2 File Offset: 0x004BA2D2
		// (set) Token: 0x060221E3 RID: 139747 RVA: 0x004BC0DA File Offset: 0x004BA2DA
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x060221E4 RID: 139748 RVA: 0x004BC0E3 File Offset: 0x004BA2E3
		public IExploreSkillRagDollDestroySolidRockT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
