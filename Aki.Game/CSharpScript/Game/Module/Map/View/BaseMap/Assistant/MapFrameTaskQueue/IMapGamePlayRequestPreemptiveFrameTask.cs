using System;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054A9 RID: 21673
	public interface IMapGamePlayRequestPreemptiveFrameTask : IPreemptiveFrameTask
	{
		// Token: 0x170084B8 RID: 33976
		// (get) Token: 0x060375FE RID: 226814
		// (set) Token: 0x060375FF RID: 226815
		int MarkId { get; set; }

		// Token: 0x170084B9 RID: 33977
		// (get) Token: 0x06037600 RID: 226816
		// (set) Token: 0x06037601 RID: 226817
		int GamePlayId { get; set; }

		// Token: 0x170084BA RID: 33978
		// (get) Token: 0x06037602 RID: 226818
		// (set) Token: 0x06037603 RID: 226819
		int InstId { get; set; }
	}
}
