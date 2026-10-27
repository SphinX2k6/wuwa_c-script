using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006460 RID: 25696
	public class ICommonBtClientOverrideDataT
	{
		// Token: 0x1700BF3B RID: 48955
		// (get) Token: 0x0602C77E RID: 182142 RVA: 0x00619313 File Offset: 0x00617513
		// (set) Token: 0x0602C77F RID: 182143 RVA: 0x0061931B File Offset: 0x0061751B
		public int TaskId { get; set; }

		// Token: 0x1700BF3C RID: 48956
		// (get) Token: 0x0602C780 RID: 182144 RVA: 0x00619324 File Offset: 0x00617524
		// (set) Token: 0x0602C781 RID: 182145 RVA: 0x0061932C File Offset: 0x0061752C
		public string Data { get; set; }

		// Token: 0x0602C782 RID: 182146 RVA: 0x00619335 File Offset: 0x00617535
		public ICommonBtClientOverrideDataT()
		{
			this.TaskId = 0;
			this.Data = null;
		}
	}
}
