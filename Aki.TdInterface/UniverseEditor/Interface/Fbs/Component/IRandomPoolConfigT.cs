using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F4 RID: 22516
	public class IRandomPoolConfigT
	{
		// Token: 0x1700A82D RID: 43053
		// (get) Token: 0x06025D7C RID: 155004 RVA: 0x005380C4 File Offset: 0x005362C4
		// (set) Token: 0x06025D7D RID: 155005 RVA: 0x005380CC File Offset: 0x005362CC
		public int Id { get; set; }

		// Token: 0x1700A82E RID: 43054
		// (get) Token: 0x06025D7E RID: 155006 RVA: 0x005380D5 File Offset: 0x005362D5
		// (set) Token: 0x06025D7F RID: 155007 RVA: 0x005380DD File Offset: 0x005362DD
		public int Count { get; set; }

		// Token: 0x06025D80 RID: 155008 RVA: 0x005380E6 File Offset: 0x005362E6
		public IRandomPoolConfigT()
		{
			this.Id = 0;
			this.Count = 0;
		}
	}
}
