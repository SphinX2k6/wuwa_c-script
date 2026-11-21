using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE0 RID: 24032
	public class IRagDollClimbingPointT
	{
		// Token: 0x1700B111 RID: 45329
		// (get) Token: 0x06028178 RID: 164216 RVA: 0x0057BB22 File Offset: 0x00579D22
		// (set) Token: 0x06028179 RID: 164217 RVA: 0x0057BB2A File Offset: 0x00579D2A
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B112 RID: 45330
		// (get) Token: 0x0602817A RID: 164218 RVA: 0x0057BB33 File Offset: 0x00579D33
		// (set) Token: 0x0602817B RID: 164219 RVA: 0x0057BB3B File Offset: 0x00579D3B
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B113 RID: 45331
		// (get) Token: 0x0602817C RID: 164220 RVA: 0x0057BB44 File Offset: 0x00579D44
		// (set) Token: 0x0602817D RID: 164221 RVA: 0x0057BB4C File Offset: 0x00579D4C
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B114 RID: 45332
		// (get) Token: 0x0602817E RID: 164222 RVA: 0x0057BB55 File Offset: 0x00579D55
		// (set) Token: 0x0602817F RID: 164223 RVA: 0x0057BB5D File Offset: 0x00579D5D
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B115 RID: 45333
		// (get) Token: 0x06028180 RID: 164224 RVA: 0x0057BB66 File Offset: 0x00579D66
		// (set) Token: 0x06028181 RID: 164225 RVA: 0x0057BB6E File Offset: 0x00579D6E
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B116 RID: 45334
		// (get) Token: 0x06028182 RID: 164226 RVA: 0x0057BB77 File Offset: 0x00579D77
		// (set) Token: 0x06028183 RID: 164227 RVA: 0x0057BB7F File Offset: 0x00579D7F
		public bool IsSummitPoint { get; set; }

		// Token: 0x1700B117 RID: 45335
		// (get) Token: 0x06028184 RID: 164228 RVA: 0x0057BB88 File Offset: 0x00579D88
		// (set) Token: 0x06028185 RID: 164229 RVA: 0x0057BB90 File Offset: 0x00579D90
		public byte NullMask { get; set; }

		// Token: 0x06028186 RID: 164230 RVA: 0x0057BB99 File Offset: 0x00579D99
		public IRagDollClimbingPointT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.IsSummitPoint = false;
			this.NullMask = 0;
		}
	}
}
