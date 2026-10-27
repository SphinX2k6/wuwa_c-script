using System;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x020054A7 RID: 21671
	public interface IMapMarkPreemptiveFrameTask : IPreemptiveFrameTask
	{
		// Token: 0x170084AE RID: 33966
		// (get) Token: 0x060375E9 RID: 226793
		// (set) Token: 0x060375EA RID: 226794
		EMarkType MarkType { get; set; }

		// Token: 0x170084AF RID: 33967
		// (get) Token: 0x060375EB RID: 226795
		// (set) Token: 0x060375EC RID: 226796
		int MarkId { get; set; }
	}
}
