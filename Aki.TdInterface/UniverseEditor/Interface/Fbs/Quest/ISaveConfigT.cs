using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F8 RID: 16632
	public class ISaveConfigT
	{
		// Token: 0x1700753A RID: 30010
		// (get) Token: 0x060183F1 RID: 99313 RVA: 0x0037DA14 File Offset: 0x0037BC14
		// (set) Token: 0x060183F2 RID: 99314 RVA: 0x0037DA1C File Offset: 0x0037BC1C
		public bool IsTemp { get; set; }

		// Token: 0x1700753B RID: 30011
		// (get) Token: 0x060183F3 RID: 99315 RVA: 0x0037DA25 File Offset: 0x0037BC25
		// (set) Token: 0x060183F4 RID: 99316 RVA: 0x0037DA2D File Offset: 0x0037BC2D
		public bool EnableRollbackWhileSwitchOnlineMode { get; set; }

		// Token: 0x1700753C RID: 30012
		// (get) Token: 0x060183F5 RID: 99317 RVA: 0x0037DA36 File Offset: 0x0037BC36
		// (set) Token: 0x060183F6 RID: 99318 RVA: 0x0037DA3E File Offset: 0x0037BC3E
		public bool DisableRollbackWhileReconnect { get; set; }

		// Token: 0x1700753D RID: 30013
		// (get) Token: 0x060183F7 RID: 99319 RVA: 0x0037DA47 File Offset: 0x0037BC47
		// (set) Token: 0x060183F8 RID: 99320 RVA: 0x0037DA4F File Offset: 0x0037BC4F
		public IPosRollbackConfigT PosRollbackCfg { get; set; }

		// Token: 0x1700753E RID: 30014
		// (get) Token: 0x060183F9 RID: 99321 RVA: 0x0037DA58 File Offset: 0x0037BC58
		// (set) Token: 0x060183FA RID: 99322 RVA: 0x0037DA60 File Offset: 0x0037BC60
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x1700753F RID: 30015
		// (get) Token: 0x060183FB RID: 99323 RVA: 0x0037DA69 File Offset: 0x0037BC69
		// (set) Token: 0x060183FC RID: 99324 RVA: 0x0037DA71 File Offset: 0x0037BC71
		public List<IInitConditionActionsT> InitConditionActions { get; set; }

		// Token: 0x17007540 RID: 30016
		// (get) Token: 0x060183FD RID: 99325 RVA: 0x0037DA7A File Offset: 0x0037BC7A
		// (set) Token: 0x060183FE RID: 99326 RVA: 0x0037DA82 File Offset: 0x0037BC82
		public byte NullMask { get; set; }

		// Token: 0x060183FF RID: 99327 RVA: 0x0037DA8B File Offset: 0x0037BC8B
		public ISaveConfigT()
		{
			this.IsTemp = false;
			this.EnableRollbackWhileSwitchOnlineMode = false;
			this.DisableRollbackWhileReconnect = false;
			this.PosRollbackCfg = null;
			this.EnterActions = null;
			this.InitConditionActions = null;
			this.NullMask = 0;
		}
	}
}
