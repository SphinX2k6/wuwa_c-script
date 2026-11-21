using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582D RID: 22573
	public class IFoxJumpInteractPointT
	{
		// Token: 0x1700A36A RID: 41834
		// (get) Token: 0x060248AB RID: 149675 RVA: 0x005054D8 File Offset: 0x005036D8
		// (set) Token: 0x060248AC RID: 149676 RVA: 0x005054E0 File Offset: 0x005036E0
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A36B RID: 41835
		// (get) Token: 0x060248AD RID: 149677 RVA: 0x005054E9 File Offset: 0x005036E9
		// (set) Token: 0x060248AE RID: 149678 RVA: 0x005054F1 File Offset: 0x005036F1
		public int LockConfigId { get; set; }

		// Token: 0x1700A36C RID: 41836
		// (get) Token: 0x060248AF RID: 149679 RVA: 0x005054FA File Offset: 0x005036FA
		// (set) Token: 0x060248B0 RID: 149680 RVA: 0x00505502 File Offset: 0x00503702
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A36D RID: 41837
		// (get) Token: 0x060248B1 RID: 149681 RVA: 0x0050550B File Offset: 0x0050370B
		// (set) Token: 0x060248B2 RID: 149682 RVA: 0x00505513 File Offset: 0x00503713
		public TFoxJumpInteractPointRelationTypeUnion PositionConfig { get; set; }

		// Token: 0x060248B3 RID: 149683 RVA: 0x0050551C File Offset: 0x0050371C
		public IFoxJumpInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.LockConfigId = 0;
			this.Actions = null;
			this.PositionConfig = null;
		}
	}
}
