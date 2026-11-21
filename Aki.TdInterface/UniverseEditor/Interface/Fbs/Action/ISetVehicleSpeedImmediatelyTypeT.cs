using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007873 RID: 30835
	public class ISetVehicleSpeedImmediatelyTypeT
	{
		// Token: 0x1700E223 RID: 57891
		// (get) Token: 0x060363BF RID: 222143 RVA: 0x00743C96 File Offset: 0x00741E96
		// (set) Token: 0x060363C0 RID: 222144 RVA: 0x00743C9E File Offset: 0x00741E9E
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x060363C1 RID: 222145 RVA: 0x00743CA7 File Offset: 0x00741EA7
		public ISetVehicleSpeedImmediatelyTypeT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
		}
	}
}
