using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593A RID: 22842
	public class IHookFetchComponentT
	{
		// Token: 0x1700A5B7 RID: 42423
		// (get) Token: 0x0602528E RID: 152206 RVA: 0x005197D1 File Offset: 0x005179D1
		// (set) Token: 0x0602528F RID: 152207 RVA: 0x005197D9 File Offset: 0x005179D9
		public bool Disabled { get; set; }

		// Token: 0x1700A5B8 RID: 42424
		// (get) Token: 0x06025290 RID: 152208 RVA: 0x005197E2 File Offset: 0x005179E2
		// (set) Token: 0x06025291 RID: 152209 RVA: 0x005197EA File Offset: 0x005179EA
		public ISphereTriggerShapeT Range { get; set; }

		// Token: 0x1700A5B9 RID: 42425
		// (get) Token: 0x06025292 RID: 152210 RVA: 0x005197F3 File Offset: 0x005179F3
		// (set) Token: 0x06025293 RID: 152211 RVA: 0x005197FB File Offset: 0x005179FB
		public bool UseRangeComponent { get; set; }

		// Token: 0x1700A5BA RID: 42426
		// (get) Token: 0x06025294 RID: 152212 RVA: 0x00519804 File Offset: 0x00517A04
		// (set) Token: 0x06025295 RID: 152213 RVA: 0x0051980C File Offset: 0x00517A0C
		public IHookFetchMoveUniformT MoveMode { get; set; }

		// Token: 0x1700A5BB RID: 42427
		// (get) Token: 0x06025296 RID: 152214 RVA: 0x00519815 File Offset: 0x00517A15
		// (set) Token: 0x06025297 RID: 152215 RVA: 0x0051981D File Offset: 0x00517A1D
		public IConditionGroupT HookEnableCondition { get; set; }

		// Token: 0x1700A5BC RID: 42428
		// (get) Token: 0x06025298 RID: 152216 RVA: 0x00519826 File Offset: 0x00517A26
		// (set) Token: 0x06025299 RID: 152217 RVA: 0x0051982E File Offset: 0x00517A2E
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A5BD RID: 42429
		// (get) Token: 0x0602529A RID: 152218 RVA: 0x00519837 File Offset: 0x00517A37
		// (set) Token: 0x0602529B RID: 152219 RVA: 0x0051983F File Offset: 0x00517A3F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A5BE RID: 42430
		// (get) Token: 0x0602529C RID: 152220 RVA: 0x00519848 File Offset: 0x00517A48
		// (set) Token: 0x0602529D RID: 152221 RVA: 0x00519850 File Offset: 0x00517A50
		public byte NullMask { get; set; }

		// Token: 0x0602529E RID: 152222 RVA: 0x00519859 File Offset: 0x00517A59
		public IHookFetchComponentT()
		{
			this.Disabled = false;
			this.Range = null;
			this.UseRangeComponent = false;
			this.MoveMode = null;
			this.HookEnableCondition = null;
			this.HookActions = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}
