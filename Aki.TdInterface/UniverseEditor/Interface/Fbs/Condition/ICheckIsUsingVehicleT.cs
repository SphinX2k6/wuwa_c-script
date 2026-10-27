using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA9 RID: 19113
	public class ICheckIsUsingVehicleT
	{
		// Token: 0x17008A86 RID: 35462
		// (get) Token: 0x0601DFE8 RID: 122856 RVA: 0x00435E5E File Offset: 0x0043405E
		// (set) Token: 0x0601DFE9 RID: 122857 RVA: 0x00435E66 File Offset: 0x00434066
		public EVehicleConditionType Type { get; set; }

		// Token: 0x17008A87 RID: 35463
		// (get) Token: 0x0601DFEA RID: 122858 RVA: 0x00435E6F File Offset: 0x0043406F
		// (set) Token: 0x0601DFEB RID: 122859 RVA: 0x00435E77 File Offset: 0x00434077
		public int TargetVehicle { get; set; }

		// Token: 0x17008A88 RID: 35464
		// (get) Token: 0x0601DFEC RID: 122860 RVA: 0x00435E80 File Offset: 0x00434080
		// (set) Token: 0x0601DFED RID: 122861 RVA: 0x00435E88 File Offset: 0x00434088
		public EVehicleSeat Seat { get; set; }

		// Token: 0x17008A89 RID: 35465
		// (get) Token: 0x0601DFEE RID: 122862 RVA: 0x00435E91 File Offset: 0x00434091
		// (set) Token: 0x0601DFEF RID: 122863 RVA: 0x00435E99 File Offset: 0x00434099
		public bool CheckIsBeingUsed { get; set; }

		// Token: 0x17008A8A RID: 35466
		// (get) Token: 0x0601DFF0 RID: 122864 RVA: 0x00435EA2 File Offset: 0x004340A2
		// (set) Token: 0x0601DFF1 RID: 122865 RVA: 0x00435EAA File Offset: 0x004340AA
		public byte NullMask { get; set; }

		// Token: 0x0601DFF2 RID: 122866 RVA: 0x00435EB3 File Offset: 0x004340B3
		public ICheckIsUsingVehicleT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
			this.TargetVehicle = 0;
			this.Seat = EVehicleSeat.Seat0;
			this.CheckIsBeingUsed = false;
			this.NullMask = 0;
		}
	}
}
