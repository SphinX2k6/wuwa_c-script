using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004176 RID: 16758
	public class ICheckPlayerInputConditionT
	{
		// Token: 0x1700718C RID: 29068
		// (get) Token: 0x06017101 RID: 94465 RVA: 0x00349C81 File Offset: 0x00347E81
		// (set) Token: 0x06017102 RID: 94466 RVA: 0x00349C89 File Offset: 0x00347E89
		public EChildQuest Type { get; set; }

		// Token: 0x1700718D RID: 29069
		// (get) Token: 0x06017103 RID: 94467 RVA: 0x00349C92 File Offset: 0x00347E92
		// (set) Token: 0x06017104 RID: 94468 RVA: 0x00349C9A File Offset: 0x00347E9A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700718E RID: 29070
		// (get) Token: 0x06017105 RID: 94469 RVA: 0x00349CA3 File Offset: 0x00347EA3
		// (set) Token: 0x06017106 RID: 94470 RVA: 0x00349CAB File Offset: 0x00347EAB
		public ICheckPlayerPressButtonT CheckInput { get; set; }

		// Token: 0x06017107 RID: 94471 RVA: 0x00349CB4 File Offset: 0x00347EB4
		public ICheckPlayerInputConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.CheckInput = null;
		}
	}
}
