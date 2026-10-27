using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C91 RID: 27793
	public class IPerformerRangeBoundaryActionTriggerT
	{
		// Token: 0x1700CEF7 RID: 52983
		// (get) Token: 0x06030FA5 RID: 200613 RVA: 0x006A641F File Offset: 0x006A461F
		// (set) Token: 0x06030FA6 RID: 200614 RVA: 0x006A6427 File Offset: 0x006A4627
		public int Range { get; set; }

		// Token: 0x1700CEF8 RID: 52984
		// (get) Token: 0x06030FA7 RID: 200615 RVA: 0x006A6430 File Offset: 0x006A4630
		// (set) Token: 0x06030FA8 RID: 200616 RVA: 0x006A6438 File Offset: 0x006A4638
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06030FA9 RID: 200617 RVA: 0x006A6441 File Offset: 0x006A4641
		public IPerformerRangeBoundaryActionTriggerT()
		{
			this.Range = 0;
			this.Actions = null;
		}
	}
}
