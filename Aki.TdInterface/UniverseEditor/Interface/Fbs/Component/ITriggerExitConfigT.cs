using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F5 RID: 24821
	public class ITriggerExitConfigT
	{
		// Token: 0x1700B8C2 RID: 47298
		// (get) Token: 0x0602A10E RID: 172302 RVA: 0x005BE1B4 File Offset: 0x005BC3B4
		// (set) Token: 0x0602A10F RID: 172303 RVA: 0x005BE1BC File Offset: 0x005BC3BC
		public int ExtraRange { get; set; }

		// Token: 0x1700B8C3 RID: 47299
		// (get) Token: 0x0602A110 RID: 172304 RVA: 0x005BE1C5 File Offset: 0x005BC3C5
		// (set) Token: 0x0602A111 RID: 172305 RVA: 0x005BE1CD File Offset: 0x005BC3CD
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700B8C4 RID: 47300
		// (get) Token: 0x0602A112 RID: 172306 RVA: 0x005BE1D6 File Offset: 0x005BC3D6
		// (set) Token: 0x0602A113 RID: 172307 RVA: 0x005BE1DE File Offset: 0x005BC3DE
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B8C5 RID: 47301
		// (get) Token: 0x0602A114 RID: 172308 RVA: 0x005BE1E7 File Offset: 0x005BC3E7
		// (set) Token: 0x0602A115 RID: 172309 RVA: 0x005BE1EF File Offset: 0x005BC3EF
		public int MatchTypeCount { get; set; }

		// Token: 0x1700B8C6 RID: 47302
		// (get) Token: 0x0602A116 RID: 172310 RVA: 0x005BE1F8 File Offset: 0x005BC3F8
		// (set) Token: 0x0602A117 RID: 172311 RVA: 0x005BE200 File Offset: 0x005BC400
		public bool ExitByNotEnterCondition { get; set; }

		// Token: 0x1700B8C7 RID: 47303
		// (get) Token: 0x0602A118 RID: 172312 RVA: 0x005BE209 File Offset: 0x005BC409
		// (set) Token: 0x0602A119 RID: 172313 RVA: 0x005BE211 File Offset: 0x005BC411
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700B8C8 RID: 47304
		// (get) Token: 0x0602A11A RID: 172314 RVA: 0x005BE21A File Offset: 0x005BC41A
		// (set) Token: 0x0602A11B RID: 172315 RVA: 0x005BE222 File Offset: 0x005BC422
		public bool DisableExecuteActionsWhenDestroy { get; set; }

		// Token: 0x1700B8C9 RID: 47305
		// (get) Token: 0x0602A11C RID: 172316 RVA: 0x005BE22B File Offset: 0x005BC42B
		// (set) Token: 0x0602A11D RID: 172317 RVA: 0x005BE233 File Offset: 0x005BC433
		public byte NullMask { get; set; }

		// Token: 0x0602A11E RID: 172318 RVA: 0x005BE23C File Offset: 0x005BC43C
		public ITriggerExitConfigT()
		{
			this.ExtraRange = 0;
			this.MaxTriggerTimes = 0;
			this.Condition = null;
			this.MatchTypeCount = 0;
			this.ExitByNotEnterCondition = false;
			this.Actions = null;
			this.DisableExecuteActionsWhenDestroy = false;
			this.NullMask = 0;
		}
	}
}
