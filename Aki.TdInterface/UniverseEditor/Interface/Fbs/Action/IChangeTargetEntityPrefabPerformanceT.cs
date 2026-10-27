using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006327 RID: 25383
	public class IChangeTargetEntityPrefabPerformanceT
	{
		// Token: 0x1700BD77 RID: 48503
		// (get) Token: 0x0602BE83 RID: 179843 RVA: 0x006093FD File Offset: 0x006075FD
		// (set) Token: 0x0602BE84 RID: 179844 RVA: 0x00609405 File Offset: 0x00607605
		public EChangeEntityPrefabPerformanceType Type { get; set; }

		// Token: 0x1700BD78 RID: 48504
		// (get) Token: 0x0602BE85 RID: 179845 RVA: 0x0060940E File Offset: 0x0060760E
		// (set) Token: 0x0602BE86 RID: 179846 RVA: 0x00609416 File Offset: 0x00607616
		public int EntityId { get; set; }

		// Token: 0x1700BD79 RID: 48505
		// (get) Token: 0x0602BE87 RID: 179847 RVA: 0x0060941F File Offset: 0x0060761F
		// (set) Token: 0x0602BE88 RID: 179848 RVA: 0x00609427 File Offset: 0x00607627
		public string PerformanceTag { get; set; }

		// Token: 0x0602BE89 RID: 179849 RVA: 0x00609430 File Offset: 0x00607630
		public IChangeTargetEntityPrefabPerformanceT()
		{
			this.Type = EChangeEntityPrefabPerformanceType.Target;
			this.EntityId = 0;
			this.PerformanceTag = null;
		}
	}
}
