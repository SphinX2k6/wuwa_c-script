using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC9 RID: 16329
	public class IQuestBuffActiveCenterRangeT
	{
		// Token: 0x17007260 RID: 29280
		// (get) Token: 0x060176BF RID: 95935 RVA: 0x00360CED File Offset: 0x0035EEED
		// (set) Token: 0x060176C0 RID: 95936 RVA: 0x00360CF5 File Offset: 0x0035EEF5
		public IVectorInfoT CheckPoint { get; set; }

		// Token: 0x17007261 RID: 29281
		// (get) Token: 0x060176C1 RID: 95937 RVA: 0x00360CFE File Offset: 0x0035EEFE
		// (set) Token: 0x060176C2 RID: 95938 RVA: 0x00360D06 File Offset: 0x0035EF06
		public int CheckEnterRange { get; set; }

		// Token: 0x17007262 RID: 29282
		// (get) Token: 0x060176C3 RID: 95939 RVA: 0x00360D0F File Offset: 0x0035EF0F
		// (set) Token: 0x060176C4 RID: 95940 RVA: 0x00360D17 File Offset: 0x0035EF17
		public int CheckLeaveRange { get; set; }

		// Token: 0x060176C5 RID: 95941 RVA: 0x00360D20 File Offset: 0x0035EF20
		public IQuestBuffActiveCenterRangeT()
		{
			this.CheckPoint = null;
			this.CheckEnterRange = 0;
			this.CheckLeaveRange = 0;
		}
	}
}
