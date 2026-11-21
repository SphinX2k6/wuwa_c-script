using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB3 RID: 28083
	public class IExitVehicleStandUpT
	{
		// Token: 0x1700CDE7 RID: 52711
		// (get) Token: 0x06030793 RID: 198547 RVA: 0x006959CA File Offset: 0x00693BCA
		// (set) Token: 0x06030794 RID: 198548 RVA: 0x006959D2 File Offset: 0x00693BD2
		public EExitVehicleType Type { get; set; }

		// Token: 0x06030795 RID: 198549 RVA: 0x006959DB File Offset: 0x00693BDB
		public IExitVehicleStandUpT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}
