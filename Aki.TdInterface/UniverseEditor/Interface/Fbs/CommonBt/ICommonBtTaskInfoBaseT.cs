using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED3 RID: 24275
	public class ICommonBtTaskInfoBaseT
	{
		// Token: 0x1700B598 RID: 46488
		// (get) Token: 0x06029B28 RID: 170792 RVA: 0x005B92CE File Offset: 0x005B74CE
		// (set) Token: 0x06029B29 RID: 170793 RVA: 0x005B92D6 File Offset: 0x005B74D6
		public int TaskId { get; set; }

		// Token: 0x06029B2A RID: 170794 RVA: 0x005B92DF File Offset: 0x005B74DF
		public ICommonBtTaskInfoBaseT()
		{
			this.TaskId = 0;
		}
	}
}
