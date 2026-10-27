using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672D RID: 26413
	public class IExitVehicleLaunchT
	{
		// Token: 0x1700C42B RID: 50219
		// (get) Token: 0x0602DF29 RID: 188201 RVA: 0x00647F96 File Offset: 0x00646196
		// (set) Token: 0x0602DF2A RID: 188202 RVA: 0x00647F9E File Offset: 0x0064619E
		public EExitVehicleType Type { get; set; }

		// Token: 0x0602DF2B RID: 188203 RVA: 0x00647FA7 File Offset: 0x006461A7
		public IExitVehicleLaunchT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}
