using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D5 RID: 18645
	public class Record_Int_IntT
	{
		// Token: 0x1700875D RID: 34653
		// (get) Token: 0x0601D28C RID: 119436 RVA: 0x0041DC14 File Offset: 0x0041BE14
		// (set) Token: 0x0601D28D RID: 119437 RVA: 0x0041DC1C File Offset: 0x0041BE1C
		public int Key { get; set; }

		// Token: 0x1700875E RID: 34654
		// (get) Token: 0x0601D28E RID: 119438 RVA: 0x0041DC25 File Offset: 0x0041BE25
		// (set) Token: 0x0601D28F RID: 119439 RVA: 0x0041DC2D File Offset: 0x0041BE2D
		public int Value { get; set; }

		// Token: 0x0601D290 RID: 119440 RVA: 0x0041DC36 File Offset: 0x0041BE36
		public Record_Int_IntT()
		{
			this.Key = 0;
			this.Value = 0;
		}
	}
}
