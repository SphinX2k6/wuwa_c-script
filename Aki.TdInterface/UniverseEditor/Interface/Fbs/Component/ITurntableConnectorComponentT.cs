using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006101 RID: 24833
	public class ITurntableConnectorComponentT
	{
		// Token: 0x1700B8E5 RID: 47333
		// (get) Token: 0x0602A18A RID: 172426 RVA: 0x005BF0B5 File Offset: 0x005BD2B5
		// (set) Token: 0x0602A18B RID: 172427 RVA: 0x005BF0BD File Offset: 0x005BD2BD
		public bool Disabled { get; set; }

		// Token: 0x1700B8E6 RID: 47334
		// (get) Token: 0x0602A18C RID: 172428 RVA: 0x005BF0C6 File Offset: 0x005BD2C6
		// (set) Token: 0x0602A18D RID: 172429 RVA: 0x005BF0CE File Offset: 0x005BD2CE
		public ICircuitConnectT Gameplay { get; set; }

		// Token: 0x1700B8E7 RID: 47335
		// (get) Token: 0x0602A18E RID: 172430 RVA: 0x005BF0D7 File Offset: 0x005BD2D7
		// (set) Token: 0x0602A18F RID: 172431 RVA: 0x005BF0DF File Offset: 0x005BD2DF
		public byte NullMask { get; set; }

		// Token: 0x0602A190 RID: 172432 RVA: 0x005BF0E8 File Offset: 0x005BD2E8
		public ITurntableConnectorComponentT()
		{
			this.Disabled = false;
			this.Gameplay = null;
			this.NullMask = 0;
		}
	}
}
