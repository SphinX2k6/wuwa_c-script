using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FA RID: 23034
	public class IInteractSectorRangeT
	{
		// Token: 0x1700A75E RID: 42846
		// (get) Token: 0x060259C7 RID: 154055 RVA: 0x005282F0 File Offset: 0x005264F0
		// (set) Token: 0x060259C8 RID: 154056 RVA: 0x005282F8 File Offset: 0x005264F8
		public float Begin { get; set; }

		// Token: 0x1700A75F RID: 42847
		// (get) Token: 0x060259C9 RID: 154057 RVA: 0x00528301 File Offset: 0x00526501
		// (set) Token: 0x060259CA RID: 154058 RVA: 0x00528309 File Offset: 0x00526509
		public float End { get; set; }

		// Token: 0x060259CB RID: 154059 RVA: 0x00528312 File Offset: 0x00526512
		public IInteractSectorRangeT()
		{
			this.Begin = 0f;
			this.End = 0f;
		}
	}
}
