using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C2 RID: 21186
	public class IFoxJumpInteractPointT
	{
		// Token: 0x17009B61 RID: 39777
		// (get) Token: 0x060228E7 RID: 141543 RVA: 0x004CA3DC File Offset: 0x004C85DC
		// (set) Token: 0x060228E8 RID: 141544 RVA: 0x004CA3E4 File Offset: 0x004C85E4
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x17009B62 RID: 39778
		// (get) Token: 0x060228E9 RID: 141545 RVA: 0x004CA3ED File Offset: 0x004C85ED
		// (set) Token: 0x060228EA RID: 141546 RVA: 0x004CA3F5 File Offset: 0x004C85F5
		public int LockConfigId { get; set; }

		// Token: 0x17009B63 RID: 39779
		// (get) Token: 0x060228EB RID: 141547 RVA: 0x004CA3FE File Offset: 0x004C85FE
		// (set) Token: 0x060228EC RID: 141548 RVA: 0x004CA406 File Offset: 0x004C8606
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009B64 RID: 39780
		// (get) Token: 0x060228ED RID: 141549 RVA: 0x004CA40F File Offset: 0x004C860F
		// (set) Token: 0x060228EE RID: 141550 RVA: 0x004CA417 File Offset: 0x004C8617
		public TFoxJumpInteractPointRelationTypeUnion PositionConfig { get; set; }

		// Token: 0x060228EF RID: 141551 RVA: 0x004CA420 File Offset: 0x004C8620
		public IFoxJumpInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.LockConfigId = 0;
			this.Actions = null;
			this.PositionConfig = null;
		}
	}
}
