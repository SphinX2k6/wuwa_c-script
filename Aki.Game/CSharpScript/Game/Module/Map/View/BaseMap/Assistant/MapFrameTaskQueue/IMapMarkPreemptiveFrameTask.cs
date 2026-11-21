using System;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapFrameTaskQueue
{
	// Token: 0x0200448A RID: 17546
	public interface IMapMarkPreemptiveFrameTask : IPreemptiveFrameTask
	{
		// Token: 0x1700587A RID: 22650
		// (get) Token: 0x0602C53F RID: 181567
		// (set) Token: 0x0602C540 RID: 181568
		EMarkType MarkType { get; set; }

		// Token: 0x1700587B RID: 22651
		// (get) Token: 0x0602C541 RID: 181569
		// (set) Token: 0x0602C542 RID: 181570
		int MarkId { get; set; }
	}
}
