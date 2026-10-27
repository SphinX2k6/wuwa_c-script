using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A86 RID: 23174
	public class ITimePathConfigT
	{
		// Token: 0x1700AE89 RID: 44681
		// (get) Token: 0x0602778D RID: 161677 RVA: 0x0056E57B File Offset: 0x0056C77B
		// (set) Token: 0x0602778E RID: 161678 RVA: 0x0056E583 File Offset: 0x0056C783
		public float TotalTime { get; set; }

		// Token: 0x1700AE8A RID: 44682
		// (get) Token: 0x0602778F RID: 161679 RVA: 0x0056E58C File Offset: 0x0056C78C
		// (set) Token: 0x06027790 RID: 161680 RVA: 0x0056E594 File Offset: 0x0056C794
		public string TimePathCurve { get; set; }

		// Token: 0x06027791 RID: 161681 RVA: 0x0056E59D File Offset: 0x0056C79D
		public ITimePathConfigT()
		{
			this.TotalTime = 0f;
			this.TimePathCurve = null;
		}
	}
}
