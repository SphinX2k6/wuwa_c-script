using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FA RID: 29946
	public class IVehicleControlTypeT
	{
		// Token: 0x1700E338 RID: 58168
		// (get) Token: 0x06036745 RID: 223045 RVA: 0x00765CC6 File Offset: 0x00763EC6
		// (set) Token: 0x06036746 RID: 223046 RVA: 0x00765CCE File Offset: 0x00763ECE
		public EVehicleControlType Type { get; set; }

		// Token: 0x06036747 RID: 223047 RVA: 0x00765CD7 File Offset: 0x00763ED7
		public IVehicleControlTypeT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
		}
	}
}
