using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA9 RID: 16041
	public class IInformationViewCheckConditionT
	{
		// Token: 0x17006F5D RID: 28509
		// (get) Token: 0x06016A74 RID: 92788 RVA: 0x00345749 File Offset: 0x00343949
		// (set) Token: 0x06016A75 RID: 92789 RVA: 0x00345751 File Offset: 0x00343951
		public EChildQuest Type { get; set; }

		// Token: 0x17006F5E RID: 28510
		// (get) Token: 0x06016A76 RID: 92790 RVA: 0x0034575A File Offset: 0x0034395A
		// (set) Token: 0x06016A77 RID: 92791 RVA: 0x00345762 File Offset: 0x00343962
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006F5F RID: 28511
		// (get) Token: 0x06016A78 RID: 92792 RVA: 0x0034576B File Offset: 0x0034396B
		// (set) Token: 0x06016A79 RID: 92793 RVA: 0x00345773 File Offset: 0x00343973
		public int InformationViewId { get; set; }

		// Token: 0x06016A7A RID: 92794 RVA: 0x0034577C File Offset: 0x0034397C
		public IInformationViewCheckConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.InformationViewId = 0;
		}
	}
}
