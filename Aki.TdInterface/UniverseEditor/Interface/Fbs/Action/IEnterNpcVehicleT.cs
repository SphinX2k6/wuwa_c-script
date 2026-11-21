using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D38 RID: 27960
	public class IEnterNpcVehicleT
	{
		// Token: 0x1700CD1B RID: 52507
		// (get) Token: 0x060303A5 RID: 197541 RVA: 0x0068E7A4 File Offset: 0x0068C9A4
		// (set) Token: 0x060303A6 RID: 197542 RVA: 0x0068E7AC File Offset: 0x0068C9AC
		public int Target { get; set; }

		// Token: 0x1700CD1C RID: 52508
		// (get) Token: 0x060303A7 RID: 197543 RVA: 0x0068E7B5 File Offset: 0x0068C9B5
		// (set) Token: 0x060303A8 RID: 197544 RVA: 0x0068E7BD File Offset: 0x0068C9BD
		public int Seat { get; set; }

		// Token: 0x060303A9 RID: 197545 RVA: 0x0068E7C6 File Offset: 0x0068C9C6
		public IEnterNpcVehicleT()
		{
			this.Target = 0;
			this.Seat = 0;
		}
	}
}
