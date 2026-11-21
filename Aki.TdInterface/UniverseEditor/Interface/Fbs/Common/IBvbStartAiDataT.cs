using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200639C RID: 25500
	public class IBvbStartAiDataT
	{
		// Token: 0x1700BC7C RID: 48252
		// (get) Token: 0x0602B4DC RID: 177372 RVA: 0x005E732A File Offset: 0x005E552A
		// (set) Token: 0x0602B4DD RID: 177373 RVA: 0x005E7332 File Offset: 0x005E5532
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B4DE RID: 177374 RVA: 0x005E733B File Offset: 0x005E553B
		public IBvbStartAiDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
