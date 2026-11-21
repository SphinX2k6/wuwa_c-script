using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418B RID: 16779
	public class ICheckTargetBattleAttributeConditionT
	{
		// Token: 0x170071B4 RID: 29108
		// (get) Token: 0x060171B5 RID: 94645 RVA: 0x0034B243 File Offset: 0x00349443
		// (set) Token: 0x060171B6 RID: 94646 RVA: 0x0034B24B File Offset: 0x0034944B
		public EChildQuest Type { get; set; }

		// Token: 0x170071B5 RID: 29109
		// (get) Token: 0x060171B7 RID: 94647 RVA: 0x0034B254 File Offset: 0x00349454
		// (set) Token: 0x060171B8 RID: 94648 RVA: 0x0034B25C File Offset: 0x0034945C
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071B6 RID: 29110
		// (get) Token: 0x060171B9 RID: 94649 RVA: 0x0034B265 File Offset: 0x00349465
		// (set) Token: 0x060171BA RID: 94650 RVA: 0x0034B26D File Offset: 0x0034946D
		public EConditionCount Count { get; set; }

		// Token: 0x170071B7 RID: 29111
		// (get) Token: 0x060171BB RID: 94651 RVA: 0x0034B276 File Offset: 0x00349476
		// (set) Token: 0x060171BC RID: 94652 RVA: 0x0034B27E File Offset: 0x0034947E
		public List<TTargetBattleAttributeUnion> Option { get; set; }

		// Token: 0x060171BD RID: 94653 RVA: 0x0034B287 File Offset: 0x00349487
		public ICheckTargetBattleAttributeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Option = null;
		}
	}
}
