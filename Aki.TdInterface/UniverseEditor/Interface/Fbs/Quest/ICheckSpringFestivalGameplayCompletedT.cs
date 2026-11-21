using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417C RID: 16764
	public class ICheckSpringFestivalGameplayCompletedT
	{
		// Token: 0x17007198 RID: 29080
		// (get) Token: 0x06017135 RID: 94517 RVA: 0x0034A301 File Offset: 0x00348501
		// (set) Token: 0x06017136 RID: 94518 RVA: 0x0034A309 File Offset: 0x00348509
		public EChildQuest Type { get; set; }

		// Token: 0x17007199 RID: 29081
		// (get) Token: 0x06017137 RID: 94519 RVA: 0x0034A312 File Offset: 0x00348512
		// (set) Token: 0x06017138 RID: 94520 RVA: 0x0034A31A File Offset: 0x0034851A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700719A RID: 29082
		// (get) Token: 0x06017139 RID: 94521 RVA: 0x0034A323 File Offset: 0x00348523
		// (set) Token: 0x0601713A RID: 94522 RVA: 0x0034A32B File Offset: 0x0034852B
		public TCheckSpringFestivalGameplayTypeUnion GameplayType { get; set; }

		// Token: 0x0601713B RID: 94523 RVA: 0x0034A334 File Offset: 0x00348534
		public ICheckSpringFestivalGameplayCompletedT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.GameplayType = null;
		}
	}
}
