using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E8E RID: 16014
	public class IHandInItemRangeT
	{
		// Token: 0x17006F1F RID: 28447
		// (get) Token: 0x06016974 RID: 92532 RVA: 0x00343773 File Offset: 0x00341973
		// (set) Token: 0x06016975 RID: 92533 RVA: 0x0034377B File Offset: 0x0034197B
		public EHandInItemType HandInType { get; set; }

		// Token: 0x17006F20 RID: 28448
		// (get) Token: 0x06016976 RID: 92534 RVA: 0x00343784 File Offset: 0x00341984
		// (set) Token: 0x06016977 RID: 92535 RVA: 0x0034378C File Offset: 0x0034198C
		public List<int> ItemIds { get; set; }

		// Token: 0x06016978 RID: 92536 RVA: 0x00343795 File Offset: 0x00341995
		public IHandInItemRangeT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
		}
	}
}
