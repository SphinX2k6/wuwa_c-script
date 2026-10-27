using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056ED RID: 22253
	public class IPathDrivenActorInitialSpawnHandleT
	{
		// Token: 0x1700A5AB RID: 42411
		// (get) Token: 0x06025312 RID: 152338 RVA: 0x005221A8 File Offset: 0x005203A8
		// (set) Token: 0x06025313 RID: 152339 RVA: 0x005221B0 File Offset: 0x005203B0
		public int Index { get; set; }

		// Token: 0x1700A5AC RID: 42412
		// (get) Token: 0x06025314 RID: 152340 RVA: 0x005221B9 File Offset: 0x005203B9
		// (set) Token: 0x06025315 RID: 152341 RVA: 0x005221C1 File Offset: 0x005203C1
		public EPathDrivenActorInitialSpawnHandleType HandleType { get; set; }

		// Token: 0x06025316 RID: 152342 RVA: 0x005221CA File Offset: 0x005203CA
		public IPathDrivenActorInitialSpawnHandleT()
		{
			this.Index = 0;
			this.HandleType = EPathDrivenActorInitialSpawnHandleType.WaterBoxStagnation;
		}
	}
}
