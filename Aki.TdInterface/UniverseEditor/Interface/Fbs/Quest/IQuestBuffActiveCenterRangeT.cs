using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440A RID: 17418
	public class IQuestBuffActiveCenterRangeT
	{
		// Token: 0x17007860 RID: 30816
		// (get) Token: 0x06018D52 RID: 101714 RVA: 0x0038AA15 File Offset: 0x00388C15
		// (set) Token: 0x06018D53 RID: 101715 RVA: 0x0038AA1D File Offset: 0x00388C1D
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x17007861 RID: 30817
		// (get) Token: 0x06018D54 RID: 101716 RVA: 0x0038AA26 File Offset: 0x00388C26
		// (set) Token: 0x06018D55 RID: 101717 RVA: 0x0038AA2E File Offset: 0x00388C2E
		public int CheckEnterRange { get; set; }

		// Token: 0x17007862 RID: 30818
		// (get) Token: 0x06018D56 RID: 101718 RVA: 0x0038AA37 File Offset: 0x00388C37
		// (set) Token: 0x06018D57 RID: 101719 RVA: 0x0038AA3F File Offset: 0x00388C3F
		public int CheckLeaveRange { get; set; }

		// Token: 0x06018D58 RID: 101720 RVA: 0x0038AA48 File Offset: 0x00388C48
		public IQuestBuffActiveCenterRangeT()
		{
			this.CheckPoint = null;
			this.CheckEnterRange = 0;
			this.CheckLeaveRange = 0;
		}
	}
}
