using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006980 RID: 27008
	public class IChangeNpcPerformStateT
	{
		// Token: 0x1700C6DA RID: 50906
		// (get) Token: 0x0602E528 RID: 189736 RVA: 0x0065309B File Offset: 0x0065129B
		// (set) Token: 0x0602E529 RID: 189737 RVA: 0x006530A3 File Offset: 0x006512A3
		public int EntityId { get; set; }

		// Token: 0x1700C6DB RID: 50907
		// (get) Token: 0x0602E52A RID: 189738 RVA: 0x006530AC File Offset: 0x006512AC
		// (set) Token: 0x0602E52B RID: 189739 RVA: 0x006530B4 File Offset: 0x006512B4
		public string State { get; set; }

		// Token: 0x0602E52C RID: 189740 RVA: 0x006530BD File Offset: 0x006512BD
		public IChangeNpcPerformStateT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
