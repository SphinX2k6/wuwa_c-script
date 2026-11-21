using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE5 RID: 23781
	public class IPathDrivenActorSpawnBaseT
	{
		// Token: 0x1700AEB7 RID: 44727
		// (get) Token: 0x060277AB RID: 161707 RVA: 0x00567006 File Offset: 0x00565206
		// (set) Token: 0x060277AC RID: 161708 RVA: 0x0056700E File Offset: 0x0056520E
		public EPathDrivenActorSpawnType Type { get; set; }

		// Token: 0x060277AD RID: 161709 RVA: 0x00567017 File Offset: 0x00565217
		public IPathDrivenActorSpawnBaseT()
		{
			this.Type = EPathDrivenActorSpawnType.IntervalSplineSpawn;
		}
	}
}
