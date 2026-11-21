using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422D RID: 16941
	public class IEnableSystemConfigT
	{
		// Token: 0x17007384 RID: 29572
		// (get) Token: 0x060178F2 RID: 96498 RVA: 0x0035CAFE File Offset: 0x0035ACFE
		// (set) Token: 0x060178F3 RID: 96499 RVA: 0x0035CB06 File Offset: 0x0035AD06
		public EEnableSystemType Type { get; set; }

		// Token: 0x060178F4 RID: 96500 RVA: 0x0035CB0F File Offset: 0x0035AD0F
		public IEnableSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
		}
	}
}
