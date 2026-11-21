using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7B RID: 23163
	public class ILevitateMagnetComponentT
	{
		// Token: 0x1700A8B9 RID: 43193
		// (get) Token: 0x06025F2B RID: 155435 RVA: 0x00533DE4 File Offset: 0x00531FE4
		// (set) Token: 0x06025F2C RID: 155436 RVA: 0x00533DEC File Offset: 0x00531FEC
		public bool Disabled { get; set; }

		// Token: 0x1700A8BA RID: 43194
		// (get) Token: 0x06025F2D RID: 155437 RVA: 0x00533DF5 File Offset: 0x00531FF5
		// (set) Token: 0x06025F2E RID: 155438 RVA: 0x00533DFD File Offset: 0x00531FFD
		public int MoveSpeed { get; set; }

		// Token: 0x1700A8BB RID: 43195
		// (get) Token: 0x06025F2F RID: 155439 RVA: 0x00533E06 File Offset: 0x00532006
		// (set) Token: 0x06025F30 RID: 155440 RVA: 0x00533E0E File Offset: 0x0053200E
		public int Test { get; set; }

		// Token: 0x1700A8BC RID: 43196
		// (get) Token: 0x06025F31 RID: 155441 RVA: 0x00533E17 File Offset: 0x00532017
		// (set) Token: 0x06025F32 RID: 155442 RVA: 0x00533E1F File Offset: 0x0053201F
		public byte NullMask { get; set; }

		// Token: 0x06025F33 RID: 155443 RVA: 0x00533E28 File Offset: 0x00532028
		public ILevitateMagnetComponentT()
		{
			this.Disabled = false;
			this.MoveSpeed = 0;
			this.Test = 0;
			this.NullMask = 0;
		}
	}
}
