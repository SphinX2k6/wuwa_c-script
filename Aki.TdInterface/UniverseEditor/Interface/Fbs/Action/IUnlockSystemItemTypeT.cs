using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD8 RID: 31960
	public class IUnlockSystemItemTypeT
	{
		// Token: 0x1700EF32 RID: 61234
		// (get) Token: 0x06039A73 RID: 236147 RVA: 0x007C724E File Offset: 0x007C544E
		// (set) Token: 0x06039A74 RID: 236148 RVA: 0x007C7256 File Offset: 0x007C5456
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x06039A75 RID: 236149 RVA: 0x007C725F File Offset: 0x007C545F
		public IUnlockSystemItemTypeT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
		}
	}
}
