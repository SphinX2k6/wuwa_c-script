using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC1 RID: 24513
	public class IStateRepPerfEffectsT
	{
		// Token: 0x1700B587 RID: 46471
		// (get) Token: 0x060293EE RID: 168942 RVA: 0x005A133B File Offset: 0x0059F53B
		// (set) Token: 0x060293EF RID: 168943 RVA: 0x005A1343 File Offset: 0x0059F543
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700B588 RID: 46472
		// (get) Token: 0x060293F0 RID: 168944 RVA: 0x005A134C File Offset: 0x0059F54C
		// (set) Token: 0x060293F1 RID: 168945 RVA: 0x005A1354 File Offset: 0x0059F554
		public List<int> GamePlayCues { get; set; }

		// Token: 0x060293F2 RID: 168946 RVA: 0x005A135D File Offset: 0x0059F55D
		public IStateRepPerfEffectsT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.GamePlayCues = null;
		}
	}
}
