using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E8B RID: 16011
	public class IHandInItemT
	{
		// Token: 0x17006F19 RID: 28441
		// (get) Token: 0x06016954 RID: 92500 RVA: 0x00343421 File Offset: 0x00341621
		// (set) Token: 0x06016955 RID: 92501 RVA: 0x00343429 File Offset: 0x00341629
		public EHandInItemType HandInType { get; set; }

		// Token: 0x17006F1A RID: 28442
		// (get) Token: 0x06016956 RID: 92502 RVA: 0x00343432 File Offset: 0x00341632
		// (set) Token: 0x06016957 RID: 92503 RVA: 0x0034343A File Offset: 0x0034163A
		public List<int> ItemIds { get; set; }

		// Token: 0x17006F1B RID: 28443
		// (get) Token: 0x06016958 RID: 92504 RVA: 0x00343443 File Offset: 0x00341643
		// (set) Token: 0x06016959 RID: 92505 RVA: 0x0034344B File Offset: 0x0034164B
		public int Count { get; set; }

		// Token: 0x0601695A RID: 92506 RVA: 0x00343454 File Offset: 0x00341654
		public IHandInItemT()
		{
			this.HandInType = EHandInItemType.ItemIds;
			this.ItemIds = null;
			this.Count = 0;
		}
	}
}
