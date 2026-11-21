using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006516 RID: 25878
	public class ICommonBtTaskInfoBaseT
	{
		// Token: 0x1700BF03 RID: 48899
		// (get) Token: 0x0602C1DC RID: 180700 RVA: 0x006027B2 File Offset: 0x006009B2
		// (set) Token: 0x0602C1DD RID: 180701 RVA: 0x006027BA File Offset: 0x006009BA
		public int TaskId { get; set; }

		// Token: 0x0602C1DE RID: 180702 RVA: 0x006027C3 File Offset: 0x006009C3
		public ICommonBtTaskInfoBaseT()
		{
			this.TaskId = 0;
		}
	}
}
