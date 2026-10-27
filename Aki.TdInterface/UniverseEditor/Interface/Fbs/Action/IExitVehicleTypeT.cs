using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006739 RID: 26425
	public class IExitVehicleTypeT
	{
		// Token: 0x1700C43B RID: 50235
		// (get) Token: 0x0602DF79 RID: 188281 RVA: 0x00648792 File Offset: 0x00646992
		// (set) Token: 0x0602DF7A RID: 188282 RVA: 0x0064879A File Offset: 0x0064699A
		public EExitVehicleType Type { get; set; }

		// Token: 0x0602DF7B RID: 188283 RVA: 0x006487A3 File Offset: 0x006469A3
		public IExitVehicleTypeT()
		{
			this.Type = EExitVehicleType.Launch;
		}
	}
}
