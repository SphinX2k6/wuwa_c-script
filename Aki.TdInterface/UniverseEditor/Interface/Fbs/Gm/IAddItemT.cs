using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A9F RID: 19103
	public class IAddItemT
	{
		// Token: 0x170085CF RID: 34255
		// (get) Token: 0x0601CB6E RID: 117614 RVA: 0x0040C4FE File Offset: 0x0040A6FE
		// (set) Token: 0x0601CB6F RID: 117615 RVA: 0x0040C506 File Offset: 0x0040A706
		public EGmCommand Type { get; set; }

		// Token: 0x170085D0 RID: 34256
		// (get) Token: 0x0601CB70 RID: 117616 RVA: 0x0040C50F File Offset: 0x0040A70F
		// (set) Token: 0x0601CB71 RID: 117617 RVA: 0x0040C517 File Offset: 0x0040A717
		public int ItemId { get; set; }

		// Token: 0x170085D1 RID: 34257
		// (get) Token: 0x0601CB72 RID: 117618 RVA: 0x0040C520 File Offset: 0x0040A720
		// (set) Token: 0x0601CB73 RID: 117619 RVA: 0x0040C528 File Offset: 0x0040A728
		public int Count { get; set; }

		// Token: 0x0601CB74 RID: 117620 RVA: 0x0040C531 File Offset: 0x0040A731
		public IAddItemT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
