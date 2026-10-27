using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B84 RID: 19332
	public class ICompareAlertValueT
	{
		// Token: 0x17008C4C RID: 35916
		// (get) Token: 0x0601E786 RID: 124806 RVA: 0x004441DB File Offset: 0x004423DB
		// (set) Token: 0x0601E787 RID: 124807 RVA: 0x004441E3 File Offset: 0x004423E3
		public ECondition Type { get; set; }

		// Token: 0x17008C4D RID: 35917
		// (get) Token: 0x0601E788 RID: 124808 RVA: 0x004441EC File Offset: 0x004423EC
		// (set) Token: 0x0601E789 RID: 124809 RVA: 0x004441F4 File Offset: 0x004423F4
		public int AreaId { get; set; }

		// Token: 0x17008C4E RID: 35918
		// (get) Token: 0x0601E78A RID: 124810 RVA: 0x004441FD File Offset: 0x004423FD
		// (set) Token: 0x0601E78B RID: 124811 RVA: 0x00444205 File Offset: 0x00442405
		public ECompare CompareType { get; set; }

		// Token: 0x17008C4F RID: 35919
		// (get) Token: 0x0601E78C RID: 124812 RVA: 0x0044420E File Offset: 0x0044240E
		// (set) Token: 0x0601E78D RID: 124813 RVA: 0x00444216 File Offset: 0x00442416
		public TComparedAlertValueUnion CompareValue { get; set; }

		// Token: 0x0601E78E RID: 124814 RVA: 0x0044421F File Offset: 0x0044241F
		public ICompareAlertValueT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
			this.CompareType = ECompare.Eq;
			this.CompareValue = null;
		}
	}
}
