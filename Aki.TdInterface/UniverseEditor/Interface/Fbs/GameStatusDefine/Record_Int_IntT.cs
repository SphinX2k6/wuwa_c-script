using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004716 RID: 18198
	public class Record_Int_IntT
	{
		// Token: 0x17008264 RID: 33380
		// (get) Token: 0x0601BF0D RID: 114445 RVA: 0x003F5ED4 File Offset: 0x003F40D4
		// (set) Token: 0x0601BF0E RID: 114446 RVA: 0x003F5EDC File Offset: 0x003F40DC
		public int Key { get; set; }

		// Token: 0x17008265 RID: 33381
		// (get) Token: 0x0601BF0F RID: 114447 RVA: 0x003F5EE5 File Offset: 0x003F40E5
		// (set) Token: 0x0601BF10 RID: 114448 RVA: 0x003F5EED File Offset: 0x003F40ED
		public int Value { get; set; }

		// Token: 0x0601BF11 RID: 114449 RVA: 0x003F5EF6 File Offset: 0x003F40F6
		public Record_Int_IntT()
		{
			this.Key = 0;
			this.Value = 0;
		}
	}
}
