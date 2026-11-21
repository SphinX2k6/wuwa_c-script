using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F03 RID: 20227
	public class ICheckGiantTotalProgressInteractActivatedNodeT
	{
		// Token: 0x17009072 RID: 36978
		// (get) Token: 0x0601F6C3 RID: 128707 RVA: 0x0046065B File Offset: 0x0045E85B
		// (set) Token: 0x0601F6C4 RID: 128708 RVA: 0x00460663 File Offset: 0x0045E863
		public ECondition Type { get; set; }

		// Token: 0x17009073 RID: 36979
		// (get) Token: 0x0601F6C5 RID: 128709 RVA: 0x0046066C File Offset: 0x0045E86C
		// (set) Token: 0x0601F6C6 RID: 128710 RVA: 0x00460674 File Offset: 0x0045E874
		public List<int> NodeIds { get; set; }

		// Token: 0x0601F6C7 RID: 128711 RVA: 0x0046067D File Offset: 0x0045E87D
		public ICheckGiantTotalProgressInteractActivatedNodeT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeIds = null;
		}
	}
}
