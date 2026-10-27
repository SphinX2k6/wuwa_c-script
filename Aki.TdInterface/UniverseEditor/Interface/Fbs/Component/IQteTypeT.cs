using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C1 RID: 22465
	public class IQteTypeT
	{
		// Token: 0x1700A7AD RID: 42925
		// (get) Token: 0x06025B50 RID: 154448 RVA: 0x005334C0 File Offset: 0x005316C0
		// (set) Token: 0x06025B51 RID: 154449 RVA: 0x005334C8 File Offset: 0x005316C8
		public EQteType Type { get; set; }

		// Token: 0x1700A7AE RID: 42926
		// (get) Token: 0x06025B52 RID: 154450 RVA: 0x005334D1 File Offset: 0x005316D1
		// (set) Token: 0x06025B53 RID: 154451 RVA: 0x005334D9 File Offset: 0x005316D9
		public int QteId { get; set; }

		// Token: 0x06025B54 RID: 154452 RVA: 0x005334E2 File Offset: 0x005316E2
		public IQteTypeT()
		{
			this.Type = EQteType.SingleBtn;
			this.QteId = 0;
		}
	}
}
