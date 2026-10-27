using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200497D RID: 18813
	public class IBattleTagConditionT
	{
		// Token: 0x170087DE RID: 34782
		// (get) Token: 0x0601D536 RID: 120118 RVA: 0x00422BAA File Offset: 0x00420DAA
		// (set) Token: 0x0601D537 RID: 120119 RVA: 0x00422BB2 File Offset: 0x00420DB2
		public EBattleConditionType Type { get; set; }

		// Token: 0x170087DF RID: 34783
		// (get) Token: 0x0601D538 RID: 120120 RVA: 0x00422BBB File Offset: 0x00420DBB
		// (set) Token: 0x0601D539 RID: 120121 RVA: 0x00422BC3 File Offset: 0x00420DC3
		public int EntityId { get; set; }

		// Token: 0x170087E0 RID: 34784
		// (get) Token: 0x0601D53A RID: 120122 RVA: 0x00422BCC File Offset: 0x00420DCC
		// (set) Token: 0x0601D53B RID: 120123 RVA: 0x00422BD4 File Offset: 0x00420DD4
		public int TagConfigId { get; set; }

		// Token: 0x0601D53C RID: 120124 RVA: 0x00422BDD File Offset: 0x00420DDD
		public IBattleTagConditionT()
		{
			this.Type = EBattleConditionType.BattleTag;
			this.EntityId = 0;
			this.TagConfigId = 0;
		}
	}
}
