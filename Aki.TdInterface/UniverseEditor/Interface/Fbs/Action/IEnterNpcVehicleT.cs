using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066BE RID: 26302
	public class IEnterNpcVehicleT
	{
		// Token: 0x1700C36A RID: 50026
		// (get) Token: 0x0602DB88 RID: 187272 RVA: 0x006414F0 File Offset: 0x0063F6F0
		// (set) Token: 0x0602DB89 RID: 187273 RVA: 0x006414F8 File Offset: 0x0063F6F8
		public int Target { get; set; }

		// Token: 0x1700C36B RID: 50027
		// (get) Token: 0x0602DB8A RID: 187274 RVA: 0x00641501 File Offset: 0x0063F701
		// (set) Token: 0x0602DB8B RID: 187275 RVA: 0x00641509 File Offset: 0x0063F709
		public int Seat { get; set; }

		// Token: 0x0602DB8C RID: 187276 RVA: 0x00641512 File Offset: 0x0063F712
		public IEnterNpcVehicleT()
		{
			this.Target = 0;
			this.Seat = 0;
		}
	}
}
