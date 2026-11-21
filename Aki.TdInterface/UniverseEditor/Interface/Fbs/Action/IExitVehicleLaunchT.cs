using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAD RID: 28077
	public class IExitVehicleLaunchT
	{
		// Token: 0x1700CDE1 RID: 52705
		// (get) Token: 0x0603076F RID: 198511 RVA: 0x006956DA File Offset: 0x006938DA
		// (set) Token: 0x06030770 RID: 198512 RVA: 0x006956E2 File Offset: 0x006938E2
		public EExitVehicleType Type { get; set; }

		// Token: 0x06030771 RID: 198513 RVA: 0x006956EB File Offset: 0x006938EB
		public IExitVehicleLaunchT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}
