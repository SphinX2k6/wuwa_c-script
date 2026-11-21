using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200513D RID: 20797
	public class IItemConfigT
	{
		// Token: 0x1700950D RID: 38157
		// (get) Token: 0x06020B67 RID: 133991 RVA: 0x00488538 File Offset: 0x00486738
		// (set) Token: 0x06020B68 RID: 133992 RVA: 0x00488540 File Offset: 0x00486740
		public int ItemId { get; set; }

		// Token: 0x1700950E RID: 38158
		// (get) Token: 0x06020B69 RID: 133993 RVA: 0x00488549 File Offset: 0x00486749
		// (set) Token: 0x06020B6A RID: 133994 RVA: 0x00488551 File Offset: 0x00486751
		public int Count { get; set; }

		// Token: 0x06020B6B RID: 133995 RVA: 0x0048855A File Offset: 0x0048675A
		public IItemConfigT()
		{
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
