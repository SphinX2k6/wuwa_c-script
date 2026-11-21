using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007176 RID: 29046
	public class ILongPressProgressActionT
	{
		// Token: 0x1700D49A RID: 54426
		// (get) Token: 0x060327BE RID: 206782 RVA: 0x006D2B2B File Offset: 0x006D0D2B
		// (set) Token: 0x060327BF RID: 206783 RVA: 0x006D2B33 File Offset: 0x006D0D33
		public float Percentage { get; set; }

		// Token: 0x1700D49B RID: 54427
		// (get) Token: 0x060327C0 RID: 206784 RVA: 0x006D2B3C File Offset: 0x006D0D3C
		// (set) Token: 0x060327C1 RID: 206785 RVA: 0x006D2B44 File Offset: 0x006D0D44
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x060327C2 RID: 206786 RVA: 0x006D2B4D File Offset: 0x006D0D4D
		public ILongPressProgressActionT()
		{
			this.Percentage = 0f;
			this.Actions = null;
		}
	}
}
