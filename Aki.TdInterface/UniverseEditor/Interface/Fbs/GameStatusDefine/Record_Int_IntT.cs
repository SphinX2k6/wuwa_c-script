using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B7E RID: 19326
	public class Record_Int_IntT
	{
		// Token: 0x170088A5 RID: 34981
		// (get) Token: 0x0601D6E2 RID: 120546 RVA: 0x00422170 File Offset: 0x00420370
		// (set) Token: 0x0601D6E3 RID: 120547 RVA: 0x00422178 File Offset: 0x00420378
		public int Key { get; set; }

		// Token: 0x170088A6 RID: 34982
		// (get) Token: 0x0601D6E4 RID: 120548 RVA: 0x00422181 File Offset: 0x00420381
		// (set) Token: 0x0601D6E5 RID: 120549 RVA: 0x00422189 File Offset: 0x00420389
		public int Value { get; set; }

		// Token: 0x0601D6E6 RID: 120550 RVA: 0x00422192 File Offset: 0x00420392
		public Record_Int_IntT()
		{
			this.Key = 0;
			this.Value = 0;
		}
	}
}
