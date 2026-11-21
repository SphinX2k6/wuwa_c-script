using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9C RID: 19356
	public class IFavoriteFlowConfigT
	{
		// Token: 0x170088FE RID: 35070
		// (get) Token: 0x0601D84E RID: 120910 RVA: 0x00425055 File Offset: 0x00423255
		// (set) Token: 0x0601D84F RID: 120911 RVA: 0x0042505D File Offset: 0x0042325D
		public bool _FoldedForTree { get; set; }

		// Token: 0x170088FF RID: 35071
		// (get) Token: 0x0601D850 RID: 120912 RVA: 0x00425066 File Offset: 0x00423266
		// (set) Token: 0x0601D851 RID: 120913 RVA: 0x0042506E File Offset: 0x0042326E
		public List<IFavoriteFlowNodeInfoT> FavoriteFlowNodes { get; set; }

		// Token: 0x17008900 RID: 35072
		// (get) Token: 0x0601D852 RID: 120914 RVA: 0x00425077 File Offset: 0x00423277
		// (set) Token: 0x0601D853 RID: 120915 RVA: 0x0042507F File Offset: 0x0042327F
		public byte NullMask { get; set; }

		// Token: 0x0601D854 RID: 120916 RVA: 0x00425088 File Offset: 0x00423288
		public IFavoriteFlowConfigT()
		{
			this._FoldedForTree = false;
			this.FavoriteFlowNodes = null;
			this.NullMask = 0;
		}
	}
}
