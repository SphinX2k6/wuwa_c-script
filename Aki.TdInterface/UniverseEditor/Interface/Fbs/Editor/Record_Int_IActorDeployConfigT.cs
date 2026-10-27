using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CC RID: 18636
	public class Record_Int_IActorDeployConfigT
	{
		// Token: 0x1700874E RID: 34638
		// (get) Token: 0x0601D24A RID: 119370 RVA: 0x0041D4DB File Offset: 0x0041B6DB
		// (set) Token: 0x0601D24B RID: 119371 RVA: 0x0041D4E3 File Offset: 0x0041B6E3
		public int Key { get; set; }

		// Token: 0x1700874F RID: 34639
		// (get) Token: 0x0601D24C RID: 119372 RVA: 0x0041D4EC File Offset: 0x0041B6EC
		// (set) Token: 0x0601D24D RID: 119373 RVA: 0x0041D4F4 File Offset: 0x0041B6F4
		public IActorDeployConfigT Value { get; set; }

		// Token: 0x0601D24E RID: 119374 RVA: 0x0041D4FD File Offset: 0x0041B6FD
		public Record_Int_IActorDeployConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
