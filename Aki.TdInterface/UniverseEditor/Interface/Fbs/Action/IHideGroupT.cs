using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E6 RID: 26854
	public class IHideGroupT
	{
		// Token: 0x1700C744 RID: 51012
		// (get) Token: 0x0602ED93 RID: 191891 RVA: 0x00664543 File Offset: 0x00662743
		// (set) Token: 0x0602ED94 RID: 191892 RVA: 0x0066454B File Offset: 0x0066274B
		public string GroupKey { get; set; }

		// Token: 0x1700C745 RID: 51013
		// (get) Token: 0x0602ED95 RID: 191893 RVA: 0x00664554 File Offset: 0x00662754
		// (set) Token: 0x0602ED96 RID: 191894 RVA: 0x0066455C File Offset: 0x0066275C
		public THideGroupConfigUnion HideConfig { get; set; }

		// Token: 0x1700C746 RID: 51014
		// (get) Token: 0x0602ED97 RID: 191895 RVA: 0x00664565 File Offset: 0x00662765
		// (set) Token: 0x0602ED98 RID: 191896 RVA: 0x0066456D File Offset: 0x0066276D
		public bool IsHidePasserByNpc { get; set; }

		// Token: 0x1700C747 RID: 51015
		// (get) Token: 0x0602ED99 RID: 191897 RVA: 0x00664576 File Offset: 0x00662776
		// (set) Token: 0x0602ED9A RID: 191898 RVA: 0x0066457E File Offset: 0x0066277E
		public byte NullMask { get; set; }

		// Token: 0x0602ED9B RID: 191899 RVA: 0x00664587 File Offset: 0x00662787
		public IHideGroupT()
		{
			this.GroupKey = null;
			this.HideConfig = null;
			this.IsHidePasserByNpc = false;
			this.NullMask = 0;
		}
	}
}
