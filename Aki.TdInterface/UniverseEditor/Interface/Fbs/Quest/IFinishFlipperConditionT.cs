using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004272 RID: 17010
	public class IFinishFlipperConditionT
	{
		// Token: 0x1700740B RID: 29707
		// (get) Token: 0x06017B78 RID: 97144 RVA: 0x0036210D File Offset: 0x0036030D
		// (set) Token: 0x06017B79 RID: 97145 RVA: 0x00362115 File Offset: 0x00360315
		public EChildQuest Type { get; set; }

		// Token: 0x1700740C RID: 29708
		// (get) Token: 0x06017B7A RID: 97146 RVA: 0x0036211E File Offset: 0x0036031E
		// (set) Token: 0x06017B7B RID: 97147 RVA: 0x00362126 File Offset: 0x00360326
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700740D RID: 29709
		// (get) Token: 0x06017B7C RID: 97148 RVA: 0x0036212F File Offset: 0x0036032F
		// (set) Token: 0x06017B7D RID: 97149 RVA: 0x00362137 File Offset: 0x00360337
		public IFlipperConditionStepFightT Step { get; set; }

		// Token: 0x06017B7E RID: 97150 RVA: 0x00362140 File Offset: 0x00360340
		public IFinishFlipperConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
		}
	}
}
