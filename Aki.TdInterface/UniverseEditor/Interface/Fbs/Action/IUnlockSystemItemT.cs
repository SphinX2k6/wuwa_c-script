using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD5 RID: 31957
	public class IUnlockSystemItemT
	{
		// Token: 0x1700EF2F RID: 61231
		// (get) Token: 0x06039A61 RID: 236129 RVA: 0x007C70A1 File Offset: 0x007C52A1
		// (set) Token: 0x06039A62 RID: 236130 RVA: 0x007C70A9 File Offset: 0x007C52A9
		public TUnlockSystemOptionUnion SystemOption { get; set; }

		// Token: 0x06039A63 RID: 236131 RVA: 0x007C70B2 File Offset: 0x007C52B2
		public IUnlockSystemItemT()
		{
			this.SystemOption = null;
		}
	}
}
