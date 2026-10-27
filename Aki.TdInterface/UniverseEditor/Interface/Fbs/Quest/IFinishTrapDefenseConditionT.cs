using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E52 RID: 15954
	public class IFinishTrapDefenseConditionT
	{
		// Token: 0x17006EA2 RID: 28322
		// (get) Token: 0x06016741 RID: 91969 RVA: 0x0033F27D File Offset: 0x0033D47D
		// (set) Token: 0x06016742 RID: 91970 RVA: 0x0033F285 File Offset: 0x0033D485
		public EChildQuest Type { get; set; }

		// Token: 0x17006EA3 RID: 28323
		// (get) Token: 0x06016743 RID: 91971 RVA: 0x0033F28E File Offset: 0x0033D48E
		// (set) Token: 0x06016744 RID: 91972 RVA: 0x0033F296 File Offset: 0x0033D496
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006EA4 RID: 28324
		// (get) Token: 0x06016745 RID: 91973 RVA: 0x0033F29F File Offset: 0x0033D49F
		// (set) Token: 0x06016746 RID: 91974 RVA: 0x0033F2A7 File Offset: 0x0033D4A7
		public TTrapDefenseConditionStepUnion Step { get; set; }

		// Token: 0x17006EA5 RID: 28325
		// (get) Token: 0x06016747 RID: 91975 RVA: 0x0033F2B0 File Offset: 0x0033D4B0
		// (set) Token: 0x06016748 RID: 91976 RVA: 0x0033F2B8 File Offset: 0x0033D4B8
		public TVarRefUnion Batch { get; set; }

		// Token: 0x17006EA6 RID: 28326
		// (get) Token: 0x06016749 RID: 91977 RVA: 0x0033F2C1 File Offset: 0x0033D4C1
		// (set) Token: 0x0601674A RID: 91978 RVA: 0x0033F2C9 File Offset: 0x0033D4C9
		public bool NeedArchive { get; set; }

		// Token: 0x17006EA7 RID: 28327
		// (get) Token: 0x0601674B RID: 91979 RVA: 0x0033F2D2 File Offset: 0x0033D4D2
		// (set) Token: 0x0601674C RID: 91980 RVA: 0x0033F2DA File Offset: 0x0033D4DA
		public byte NullMask { get; set; }

		// Token: 0x0601674D RID: 91981 RVA: 0x0033F2E3 File Offset: 0x0033D4E3
		public IFinishTrapDefenseConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
			this.NeedArchive = false;
			this.NullMask = 0;
		}
	}
}
