using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC3 RID: 24259
	public class ISceneItemAiTypeT
	{
		// Token: 0x1700B339 RID: 45881
		// (get) Token: 0x06028A72 RID: 166514 RVA: 0x0058EBAE File Offset: 0x0058CDAE
		// (set) Token: 0x06028A73 RID: 166515 RVA: 0x0058EBB6 File Offset: 0x0058CDB6
		public ESceneItemAiType Type { get; set; }

		// Token: 0x1700B33A RID: 45882
		// (get) Token: 0x06028A74 RID: 166516 RVA: 0x0058EBBF File Offset: 0x0058CDBF
		// (set) Token: 0x06028A75 RID: 166517 RVA: 0x0058EBC7 File Offset: 0x0058CDC7
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x1700B33B RID: 45883
		// (get) Token: 0x06028A76 RID: 166518 RVA: 0x0058EBD0 File Offset: 0x0058CDD0
		// (set) Token: 0x06028A77 RID: 166519 RVA: 0x0058EBD8 File Offset: 0x0058CDD8
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x1700B33C RID: 45884
		// (get) Token: 0x06028A78 RID: 166520 RVA: 0x0058EBE1 File Offset: 0x0058CDE1
		// (set) Token: 0x06028A79 RID: 166521 RVA: 0x0058EBE9 File Offset: 0x0058CDE9
		public bool HideWhenDisable { get; set; }

		// Token: 0x06028A7A RID: 166522 RVA: 0x0058EBF2 File Offset: 0x0058CDF2
		public ISceneItemAiTypeT()
		{
			this.Type = ESceneItemAiType.SceneItemPatrol;
			this.EnableCondition = null;
			this.DisableCondition = null;
			this.HideWhenDisable = false;
		}
	}
}
