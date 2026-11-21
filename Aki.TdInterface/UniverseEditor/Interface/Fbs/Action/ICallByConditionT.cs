using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E1 RID: 26849
	public class ICallByConditionT
	{
		// Token: 0x1700C556 RID: 50518
		// (get) Token: 0x0602DF50 RID: 188240 RVA: 0x00648216 File Offset: 0x00646416
		// (set) Token: 0x0602DF51 RID: 188241 RVA: 0x0064821E File Offset: 0x0064641E
		public IConditionsT Conditions { get; set; }

		// Token: 0x1700C557 RID: 50519
		// (get) Token: 0x0602DF52 RID: 188242 RVA: 0x00648227 File Offset: 0x00646427
		// (set) Token: 0x0602DF53 RID: 188243 RVA: 0x0064822F File Offset: 0x0064642F
		public List<IActionInfoT> TrueActions { get; set; }

		// Token: 0x1700C558 RID: 50520
		// (get) Token: 0x0602DF54 RID: 188244 RVA: 0x00648238 File Offset: 0x00646438
		// (set) Token: 0x0602DF55 RID: 188245 RVA: 0x00648240 File Offset: 0x00646440
		public List<IActionInfoT> FalseActions { get; set; }

		// Token: 0x1700C559 RID: 50521
		// (get) Token: 0x0602DF56 RID: 188246 RVA: 0x00648249 File Offset: 0x00646449
		// (set) Token: 0x0602DF57 RID: 188247 RVA: 0x00648251 File Offset: 0x00646451
		public byte NullMask { get; set; }

		// Token: 0x0602DF58 RID: 188248 RVA: 0x0064825A File Offset: 0x0064645A
		public ICallByConditionT()
		{
			this.Conditions = null;
			this.TrueActions = null;
			this.FalseActions = null;
			this.NullMask = 0;
		}
	}
}
