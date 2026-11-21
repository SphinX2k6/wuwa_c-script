using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004335 RID: 17205
	public class ILeaveDungeonConditionT
	{
		// Token: 0x170075C0 RID: 30144
		// (get) Token: 0x0601834B RID: 99147 RVA: 0x0037361F File Offset: 0x0037181F
		// (set) Token: 0x0601834C RID: 99148 RVA: 0x00373627 File Offset: 0x00371827
		public EChildQuest Type { get; set; }

		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x0601834D RID: 99149 RVA: 0x00373630 File Offset: 0x00371830
		// (set) Token: 0x0601834E RID: 99150 RVA: 0x00373638 File Offset: 0x00371838
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x0601834F RID: 99151 RVA: 0x00373641 File Offset: 0x00371841
		public ILeaveDungeonConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
