using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F6 RID: 22262
	public class IPathDrivenActorSpawnBaseT
	{
		// Token: 0x1700A5B4 RID: 42420
		// (get) Token: 0x06025344 RID: 152388 RVA: 0x005225BA File Offset: 0x005207BA
		// (set) Token: 0x06025345 RID: 152389 RVA: 0x005225C2 File Offset: 0x005207C2
		public EPathDrivenActorSpawnType Type { get; set; }

		// Token: 0x06025346 RID: 152390 RVA: 0x005225CB File Offset: 0x005207CB
		public IPathDrivenActorSpawnBaseT()
		{
			this.Type = EPathDrivenActorSpawnType.IntervalSplineSpawn;
		}
	}
}
