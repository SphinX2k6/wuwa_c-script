using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C0 RID: 29376
	public class ITalkItemAutoPlayConfigT
	{
		// Token: 0x1700DA24 RID: 55844
		// (get) Token: 0x060342F2 RID: 213746 RVA: 0x00704989 File Offset: 0x00702B89
		// (set) Token: 0x060342F3 RID: 213747 RVA: 0x00704991 File Offset: 0x00702B91
		public ITalkItemDisableAutoSelectOptionGroupT DisableAutoSelectOptionGroup { get; set; }

		// Token: 0x060342F4 RID: 213748 RVA: 0x0070499A File Offset: 0x00702B9A
		public ITalkItemAutoPlayConfigT()
		{
			this.DisableAutoSelectOptionGroup = null;
		}
	}
}
