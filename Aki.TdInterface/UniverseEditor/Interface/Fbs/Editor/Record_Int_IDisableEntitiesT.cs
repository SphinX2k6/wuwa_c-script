using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D34 RID: 19764
	public class Record_Int_IDisableEntitiesT
	{
		// Token: 0x17008D9B RID: 36251
		// (get) Token: 0x0601EA4D RID: 125517 RVA: 0x00449F03 File Offset: 0x00448103
		// (set) Token: 0x0601EA4E RID: 125518 RVA: 0x00449F0B File Offset: 0x0044810B
		public int Key { get; set; }

		// Token: 0x17008D9C RID: 36252
		// (get) Token: 0x0601EA4F RID: 125519 RVA: 0x00449F14 File Offset: 0x00448114
		// (set) Token: 0x0601EA50 RID: 125520 RVA: 0x00449F1C File Offset: 0x0044811C
		public IDisableEntitiesT Value { get; set; }

		// Token: 0x0601EA51 RID: 125521 RVA: 0x00449F25 File Offset: 0x00448125
		public Record_Int_IDisableEntitiesT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
