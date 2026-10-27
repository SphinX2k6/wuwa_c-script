using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB7 RID: 16311
	public class IProgramSpecialProcessT
	{
		// Token: 0x170071EB RID: 29163
		// (get) Token: 0x0601752A RID: 95530 RVA: 0x0035CB35 File Offset: 0x0035AD35
		// (set) Token: 0x0601752B RID: 95531 RVA: 0x0035CB3D File Offset: 0x0035AD3D
		public EChildQuest Type { get; set; }

		// Token: 0x170071EC RID: 29164
		// (get) Token: 0x0601752C RID: 95532 RVA: 0x0035CB46 File Offset: 0x0035AD46
		// (set) Token: 0x0601752D RID: 95533 RVA: 0x0035CB4E File Offset: 0x0035AD4E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170071ED RID: 29165
		// (get) Token: 0x0601752E RID: 95534 RVA: 0x0035CB57 File Offset: 0x0035AD57
		// (set) Token: 0x0601752F RID: 95535 RVA: 0x0035CB5F File Offset: 0x0035AD5F
		public ILowMemorySceneSwitchT SpecialProcess { get; set; }

		// Token: 0x06017530 RID: 95536 RVA: 0x0035CB68 File Offset: 0x0035AD68
		public IProgramSpecialProcessT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SpecialProcess = null;
		}
	}
}
