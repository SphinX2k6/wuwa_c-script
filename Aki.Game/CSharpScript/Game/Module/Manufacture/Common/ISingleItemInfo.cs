using System;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005691 RID: 22161
	public class ISingleItemInfo
	{
		// Token: 0x17008788 RID: 34696
		// (get) Token: 0x06038636 RID: 230966 RVA: 0x00D62AEE File Offset: 0x00D60CEE
		// (set) Token: 0x06038637 RID: 230967 RVA: 0x00D62AF6 File Offset: 0x00D60CF6
		public int Proto_ItemId { get; set; }

		// Token: 0x17008789 RID: 34697
		// (get) Token: 0x06038638 RID: 230968 RVA: 0x00D62AFF File Offset: 0x00D60CFF
		// (set) Token: 0x06038639 RID: 230969 RVA: 0x00D62B07 File Offset: 0x00D60D07
		public int Proto_ItemNum { get; set; }

		// Token: 0x1700878A RID: 34698
		// (get) Token: 0x0603863A RID: 230970 RVA: 0x00D62B10 File Offset: 0x00D60D10
		// (set) Token: 0x0603863B RID: 230971 RVA: 0x00D62B18 File Offset: 0x00D60D18
		public bool Proto_IsUnlock { get; set; }

		// Token: 0x1700878B RID: 34699
		// (get) Token: 0x0603863C RID: 230972 RVA: 0x00D62B21 File Offset: 0x00D60D21
		// (set) Token: 0x0603863D RID: 230973 RVA: 0x00D62B29 File Offset: 0x00D60D29
		public bool? IsEmpty { get; set; }
	}
}
