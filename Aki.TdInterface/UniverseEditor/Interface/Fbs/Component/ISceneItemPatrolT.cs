using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EDB RID: 24283
	public class ISceneItemPatrolT
	{
		// Token: 0x1700B371 RID: 45937
		// (get) Token: 0x06028B56 RID: 166742 RVA: 0x00590892 File Offset: 0x0058EA92
		// (set) Token: 0x06028B57 RID: 166743 RVA: 0x0059089A File Offset: 0x0058EA9A
		public ESceneItemAiType Type { get; set; }

		// Token: 0x1700B372 RID: 45938
		// (get) Token: 0x06028B58 RID: 166744 RVA: 0x005908A3 File Offset: 0x0058EAA3
		// (set) Token: 0x06028B59 RID: 166745 RVA: 0x005908AB File Offset: 0x0058EAAB
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x1700B373 RID: 45939
		// (get) Token: 0x06028B5A RID: 166746 RVA: 0x005908B4 File Offset: 0x0058EAB4
		// (set) Token: 0x06028B5B RID: 166747 RVA: 0x005908BC File Offset: 0x0058EABC
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x1700B374 RID: 45940
		// (get) Token: 0x06028B5C RID: 166748 RVA: 0x005908C5 File Offset: 0x0058EAC5
		// (set) Token: 0x06028B5D RID: 166749 RVA: 0x005908CD File Offset: 0x0058EACD
		public bool HideWhenDisable { get; set; }

		// Token: 0x1700B375 RID: 45941
		// (get) Token: 0x06028B5E RID: 166750 RVA: 0x005908D6 File Offset: 0x0058EAD6
		// (set) Token: 0x06028B5F RID: 166751 RVA: 0x005908DE File Offset: 0x0058EADE
		public ISceneItemAiPatrolByGameTimeT PatrolType { get; set; }

		// Token: 0x06028B60 RID: 166752 RVA: 0x005908E7 File Offset: 0x0058EAE7
		public ISceneItemPatrolT()
		{
			this.Type = ESceneItemAiType.SceneItemPatrol;
			this.EnableCondition = null;
			this.DisableCondition = null;
			this.HideWhenDisable = false;
			this.PatrolType = null;
		}
	}
}
