using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004734 RID: 18228
	public class IFavoriteFlowConfigT
	{
		// Token: 0x170082BD RID: 33469
		// (get) Token: 0x0601C079 RID: 114809 RVA: 0x003F8DB9 File Offset: 0x003F6FB9
		// (set) Token: 0x0601C07A RID: 114810 RVA: 0x003F8DC1 File Offset: 0x003F6FC1
		public bool _FoldedForTree { get; set; }

		// Token: 0x170082BE RID: 33470
		// (get) Token: 0x0601C07B RID: 114811 RVA: 0x003F8DCA File Offset: 0x003F6FCA
		// (set) Token: 0x0601C07C RID: 114812 RVA: 0x003F8DD2 File Offset: 0x003F6FD2
		public List<IFavoriteFlowNodeInfoT> FavoriteFlowNodes { get; set; }

		// Token: 0x170082BF RID: 33471
		// (get) Token: 0x0601C07D RID: 114813 RVA: 0x003F8DDB File Offset: 0x003F6FDB
		// (set) Token: 0x0601C07E RID: 114814 RVA: 0x003F8DE3 File Offset: 0x003F6FE3
		public byte NullMask { get; set; }

		// Token: 0x0601C07F RID: 114815 RVA: 0x003F8DEC File Offset: 0x003F6FEC
		public IFavoriteFlowConfigT()
		{
			this._FoldedForTree = false;
			this.FavoriteFlowNodes = null;
			this.NullMask = 0;
		}
	}
}
