using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F57 RID: 16215
	public class INewHandInItemsConditionT
	{
		// Token: 0x170070C0 RID: 28864
		// (get) Token: 0x060170F0 RID: 94448 RVA: 0x003530AD File Offset: 0x003512AD
		// (set) Token: 0x060170F1 RID: 94449 RVA: 0x003530B5 File Offset: 0x003512B5
		public EChildQuest Type { get; set; }

		// Token: 0x170070C1 RID: 28865
		// (get) Token: 0x060170F2 RID: 94450 RVA: 0x003530BE File Offset: 0x003512BE
		// (set) Token: 0x060170F3 RID: 94451 RVA: 0x003530C6 File Offset: 0x003512C6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170070C2 RID: 28866
		// (get) Token: 0x060170F4 RID: 94452 RVA: 0x003530CF File Offset: 0x003512CF
		// (set) Token: 0x060170F5 RID: 94453 RVA: 0x003530D7 File Offset: 0x003512D7
		public INewHandInItemsProjectionMachineT HandIn { get; set; }

		// Token: 0x060170F6 RID: 94454 RVA: 0x003530E0 File Offset: 0x003512E0
		public INewHandInItemsConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.HandIn = null;
		}
	}
}
