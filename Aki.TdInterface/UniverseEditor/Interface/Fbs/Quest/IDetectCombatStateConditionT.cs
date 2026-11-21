using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420C RID: 16908
	public class IDetectCombatStateConditionT
	{
		// Token: 0x17007327 RID: 29479
		// (get) Token: 0x060177A8 RID: 96168 RVA: 0x0035A627 File Offset: 0x00358827
		// (set) Token: 0x060177A9 RID: 96169 RVA: 0x0035A62F File Offset: 0x0035882F
		public EChildQuest Type { get; set; }

		// Token: 0x17007328 RID: 29480
		// (get) Token: 0x060177AA RID: 96170 RVA: 0x0035A638 File Offset: 0x00358838
		// (set) Token: 0x060177AB RID: 96171 RVA: 0x0035A640 File Offset: 0x00358840
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007329 RID: 29481
		// (get) Token: 0x060177AC RID: 96172 RVA: 0x0035A649 File Offset: 0x00358849
		// (set) Token: 0x060177AD RID: 96173 RVA: 0x0035A651 File Offset: 0x00358851
		public int EntityId { get; set; }

		// Token: 0x1700732A RID: 29482
		// (get) Token: 0x060177AE RID: 96174 RVA: 0x0035A65A File Offset: 0x0035885A
		// (set) Token: 0x060177AF RID: 96175 RVA: 0x0035A662 File Offset: 0x00358862
		public string State { get; set; }

		// Token: 0x1700732B RID: 29483
		// (get) Token: 0x060177B0 RID: 96176 RVA: 0x0035A66B File Offset: 0x0035886B
		// (set) Token: 0x060177B1 RID: 96177 RVA: 0x0035A673 File Offset: 0x00358873
		public ECompare Compare { get; set; }

		// Token: 0x1700732C RID: 29484
		// (get) Token: 0x060177B2 RID: 96178 RVA: 0x0035A67C File Offset: 0x0035887C
		// (set) Token: 0x060177B3 RID: 96179 RVA: 0x0035A684 File Offset: 0x00358884
		public byte NullMask { get; set; }

		// Token: 0x060177B4 RID: 96180 RVA: 0x0035A68D File Offset: 0x0035888D
		public IDetectCombatStateConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EntityId = 0;
			this.State = null;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}
