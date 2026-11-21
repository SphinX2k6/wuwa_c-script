using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B5 RID: 25013
	public class IWuWaGoComponentT
	{
		// Token: 0x1700BA88 RID: 47752
		// (get) Token: 0x0602A85D RID: 174173 RVA: 0x005CCC50 File Offset: 0x005CAE50
		// (set) Token: 0x0602A85E RID: 174174 RVA: 0x005CCC58 File Offset: 0x005CAE58
		public bool Disabled { get; set; }

		// Token: 0x1700BA89 RID: 47753
		// (get) Token: 0x0602A85F RID: 174175 RVA: 0x005CCC61 File Offset: 0x005CAE61
		// (set) Token: 0x0602A860 RID: 174176 RVA: 0x005CCC69 File Offset: 0x005CAE69
		public TWuWaGoEntityDataUnion WuWaGoEntity { get; set; }

		// Token: 0x1700BA8A RID: 47754
		// (get) Token: 0x0602A861 RID: 174177 RVA: 0x005CCC72 File Offset: 0x005CAE72
		// (set) Token: 0x0602A862 RID: 174178 RVA: 0x005CCC7A File Offset: 0x005CAE7A
		public List<int> OpenAddClientTags { get; set; }

		// Token: 0x1700BA8B RID: 47755
		// (get) Token: 0x0602A863 RID: 174179 RVA: 0x005CCC83 File Offset: 0x005CAE83
		// (set) Token: 0x0602A864 RID: 174180 RVA: 0x005CCC8B File Offset: 0x005CAE8B
		public byte NullMask { get; set; }

		// Token: 0x0602A865 RID: 174181 RVA: 0x005CCC94 File Offset: 0x005CAE94
		public IWuWaGoComponentT()
		{
			this.Disabled = false;
			this.WuWaGoEntity = null;
			this.OpenAddClientTags = null;
			this.NullMask = 0;
		}
	}
}
