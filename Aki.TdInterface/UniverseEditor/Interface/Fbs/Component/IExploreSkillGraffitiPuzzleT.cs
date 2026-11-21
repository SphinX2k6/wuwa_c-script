using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005749 RID: 22345
	public class IExploreSkillGraffitiPuzzleT
	{
		// Token: 0x1700A166 RID: 41318
		// (get) Token: 0x06023F8A RID: 147338 RVA: 0x004F1E73 File Offset: 0x004F0073
		// (set) Token: 0x06023F8B RID: 147339 RVA: 0x004F1E7B File Offset: 0x004F007B
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A167 RID: 41319
		// (get) Token: 0x06023F8C RID: 147340 RVA: 0x004F1E84 File Offset: 0x004F0084
		// (set) Token: 0x06023F8D RID: 147341 RVA: 0x004F1E8C File Offset: 0x004F008C
		public List<IGraffitiPointPairT> PointPairs { get; set; }

		// Token: 0x1700A168 RID: 41320
		// (get) Token: 0x06023F8E RID: 147342 RVA: 0x004F1E95 File Offset: 0x004F0095
		// (set) Token: 0x06023F8F RID: 147343 RVA: 0x004F1E9D File Offset: 0x004F009D
		public float AlignDuration { get; set; }

		// Token: 0x1700A169 RID: 41321
		// (get) Token: 0x06023F90 RID: 147344 RVA: 0x004F1EA6 File Offset: 0x004F00A6
		// (set) Token: 0x06023F91 RID: 147345 RVA: 0x004F1EAE File Offset: 0x004F00AE
		public List<int> HighlightEntityIds { get; set; }

		// Token: 0x1700A16A RID: 41322
		// (get) Token: 0x06023F92 RID: 147346 RVA: 0x004F1EB7 File Offset: 0x004F00B7
		// (set) Token: 0x06023F93 RID: 147347 RVA: 0x004F1EBF File Offset: 0x004F00BF
		public int HighlightTag { get; set; }

		// Token: 0x1700A16B RID: 41323
		// (get) Token: 0x06023F94 RID: 147348 RVA: 0x004F1EC8 File Offset: 0x004F00C8
		// (set) Token: 0x06023F95 RID: 147349 RVA: 0x004F1ED0 File Offset: 0x004F00D0
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06023F96 RID: 147350 RVA: 0x004F1ED9 File Offset: 0x004F00D9
		public IExploreSkillGraffitiPuzzleT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.PointPairs = null;
			this.AlignDuration = 0f;
			this.HighlightEntityIds = null;
			this.HighlightTag = 0;
			this.Actions = null;
		}
	}
}
