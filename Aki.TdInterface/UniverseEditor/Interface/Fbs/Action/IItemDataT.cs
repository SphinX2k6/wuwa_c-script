using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007068 RID: 28776
	public class IItemDataT
	{
		// Token: 0x1700D2C2 RID: 53954
		// (get) Token: 0x06031E6B RID: 204395 RVA: 0x006C11F0 File Offset: 0x006BF3F0
		// (set) Token: 0x06031E6C RID: 204396 RVA: 0x006C11F8 File Offset: 0x006BF3F8
		public int ItemId { get; set; }

		// Token: 0x1700D2C3 RID: 53955
		// (get) Token: 0x06031E6D RID: 204397 RVA: 0x006C1201 File Offset: 0x006BF401
		// (set) Token: 0x06031E6E RID: 204398 RVA: 0x006C1209 File Offset: 0x006BF409
		public int Count { get; set; }

		// Token: 0x06031E6F RID: 204399 RVA: 0x006C1212 File Offset: 0x006BF412
		public IItemDataT()
		{
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
