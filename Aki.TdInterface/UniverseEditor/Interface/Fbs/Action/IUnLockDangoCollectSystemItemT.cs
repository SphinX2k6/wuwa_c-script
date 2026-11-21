using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC9 RID: 31945
	public class IUnLockDangoCollectSystemItemT
	{
		// Token: 0x1700EF20 RID: 61216
		// (get) Token: 0x06039A04 RID: 236036 RVA: 0x007C668C File Offset: 0x007C488C
		// (set) Token: 0x06039A05 RID: 236037 RVA: 0x007C6694 File Offset: 0x007C4894
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700EF21 RID: 61217
		// (get) Token: 0x06039A06 RID: 236038 RVA: 0x007C669D File Offset: 0x007C489D
		// (set) Token: 0x06039A07 RID: 236039 RVA: 0x007C66A5 File Offset: 0x007C48A5
		public int Id { get; set; }

		// Token: 0x06039A08 RID: 236040 RVA: 0x007C66AE File Offset: 0x007C48AE
		public IUnLockDangoCollectSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.Id = 0;
		}
	}
}
