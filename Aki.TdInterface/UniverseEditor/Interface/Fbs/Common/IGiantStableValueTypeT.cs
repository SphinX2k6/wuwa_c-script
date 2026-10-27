using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DDD RID: 24029
	public class IGiantStableValueTypeT
	{
		// Token: 0x1700B3E2 RID: 46050
		// (get) Token: 0x0602921A RID: 168474 RVA: 0x005A50F6 File Offset: 0x005A32F6
		// (set) Token: 0x0602921B RID: 168475 RVA: 0x005A50FE File Offset: 0x005A32FE
		public EGiantStableValueType Type { get; set; }

		// Token: 0x0602921C RID: 168476 RVA: 0x005A5107 File Offset: 0x005A3307
		public IGiantStableValueTypeT()
		{
			this.Type = EGiantStableValueType.Region;
		}
	}
}
