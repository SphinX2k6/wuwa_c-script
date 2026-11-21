using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD1 RID: 27345
	public class ICommonBtOverrideActionInfoT
	{
		// Token: 0x1700C8CE RID: 51406
		// (get) Token: 0x0602EF15 RID: 192277 RVA: 0x00664E27 File Offset: 0x00663027
		// (set) Token: 0x0602EF16 RID: 192278 RVA: 0x00664E2F File Offset: 0x0066302F
		public ECommonBtPlaceholderTargetType Type { get; set; }

		// Token: 0x1700C8CF RID: 51407
		// (get) Token: 0x0602EF17 RID: 192279 RVA: 0x00664E38 File Offset: 0x00663038
		// (set) Token: 0x0602EF18 RID: 192280 RVA: 0x00664E40 File Offset: 0x00663040
		public IActionInfoT Action { get; set; }

		// Token: 0x0602EF19 RID: 192281 RVA: 0x00664E49 File Offset: 0x00663049
		public ICommonBtOverrideActionInfoT()
		{
			this.Type = ECommonBtPlaceholderTargetType.Action;
			this.Action = null;
		}
	}
}
