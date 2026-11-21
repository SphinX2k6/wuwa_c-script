using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004878 RID: 18552
	public class ILevelsConfigT
	{
		// Token: 0x1700812F RID: 33071
		// (get) Token: 0x0601B6FF RID: 112383 RVA: 0x003E232D File Offset: 0x003E052D
		// (set) Token: 0x0601B700 RID: 112384 RVA: 0x003E2335 File Offset: 0x003E0535
		public List<ILevelConfigT> Levels { get; set; }

		// Token: 0x0601B701 RID: 112385 RVA: 0x003E233E File Offset: 0x003E053E
		public ILevelsConfigT()
		{
			this.Levels = null;
		}
	}
}
