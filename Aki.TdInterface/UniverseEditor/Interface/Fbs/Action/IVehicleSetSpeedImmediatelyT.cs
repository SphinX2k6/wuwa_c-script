using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007530 RID: 30000
	public class IVehicleSetSpeedImmediatelyT
	{
		// Token: 0x1700E3AC RID: 58284
		// (get) Token: 0x0603695D RID: 223581 RVA: 0x0076A941 File Offset: 0x00768B41
		// (set) Token: 0x0603695E RID: 223582 RVA: 0x0076A949 File Offset: 0x00768B49
		public TVehicleSetSpeedImmediatelyUnion SetSpeedConfig { get; set; }

		// Token: 0x0603695F RID: 223583 RVA: 0x0076A952 File Offset: 0x00768B52
		public IVehicleSetSpeedImmediatelyT()
		{
			this.SetSpeedConfig = null;
		}
	}
}
