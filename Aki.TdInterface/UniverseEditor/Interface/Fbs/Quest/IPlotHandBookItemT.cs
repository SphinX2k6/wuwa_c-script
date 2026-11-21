using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E9 RID: 17385
	public class IPlotHandBookItemT
	{
		// Token: 0x170077C7 RID: 30663
		// (get) Token: 0x06018B35 RID: 101173 RVA: 0x0038572F File Offset: 0x0038392F
		// (set) Token: 0x06018B36 RID: 101174 RVA: 0x00385737 File Offset: 0x00383937
		public int Id { get; set; }

		// Token: 0x170077C8 RID: 30664
		// (get) Token: 0x06018B37 RID: 101175 RVA: 0x00385740 File Offset: 0x00383940
		// (set) Token: 0x06018B38 RID: 101176 RVA: 0x00385748 File Offset: 0x00383948
		public List<IPlotHandBookNodeT> Nodes { get; set; }

		// Token: 0x06018B39 RID: 101177 RVA: 0x00385751 File Offset: 0x00383951
		public IPlotHandBookItemT()
		{
			this.Id = 0;
			this.Nodes = null;
		}
	}
}
