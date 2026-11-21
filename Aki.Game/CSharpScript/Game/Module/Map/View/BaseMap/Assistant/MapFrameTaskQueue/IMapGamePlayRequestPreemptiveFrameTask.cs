using System;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x0200448C RID: 17548
	public interface IMapGamePlayRequestPreemptiveFrameTask : IPreemptiveFrameTask
	{
		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x0602C554 RID: 181588
		// (set) Token: 0x0602C555 RID: 181589
		int MarkId { get; set; }

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0602C556 RID: 181590
		// (set) Token: 0x0602C557 RID: 181591
		int GamePlayId { get; set; }

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0602C558 RID: 181592
		// (set) Token: 0x0602C559 RID: 181593
		int InstId { get; set; }
	}
}
