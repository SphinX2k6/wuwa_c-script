using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E7 RID: 17127
	public class IInformationViewCheckConditionT
	{
		// Token: 0x1700754A RID: 30026
		// (get) Token: 0x060180C1 RID: 98497 RVA: 0x0036E6D1 File Offset: 0x0036C8D1
		// (set) Token: 0x060180C2 RID: 98498 RVA: 0x0036E6D9 File Offset: 0x0036C8D9
		public EChildQuest Type { get; set; }

		// Token: 0x1700754B RID: 30027
		// (get) Token: 0x060180C3 RID: 98499 RVA: 0x0036E6E2 File Offset: 0x0036C8E2
		// (set) Token: 0x060180C4 RID: 98500 RVA: 0x0036E6EA File Offset: 0x0036C8EA
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700754C RID: 30028
		// (get) Token: 0x060180C5 RID: 98501 RVA: 0x0036E6F3 File Offset: 0x0036C8F3
		// (set) Token: 0x060180C6 RID: 98502 RVA: 0x0036E6FB File Offset: 0x0036C8FB
		public int InformationViewId { get; set; }

		// Token: 0x060180C7 RID: 98503 RVA: 0x0036E704 File Offset: 0x0036C904
		public IInformationViewCheckConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.InformationViewId = 0;
		}
	}
}
