using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004539 RID: 17721
	public class ISaveConfigT
	{
		// Token: 0x17007B40 RID: 31552
		// (get) Token: 0x06019A92 RID: 105106 RVA: 0x003A7964 File Offset: 0x003A5B64
		// (set) Token: 0x06019A93 RID: 105107 RVA: 0x003A796C File Offset: 0x003A5B6C
		public bool IsTemp { get; set; }

		// Token: 0x17007B41 RID: 31553
		// (get) Token: 0x06019A94 RID: 105108 RVA: 0x003A7975 File Offset: 0x003A5B75
		// (set) Token: 0x06019A95 RID: 105109 RVA: 0x003A797D File Offset: 0x003A5B7D
		public bool EnableRollbackWhileSwitchOnlineMode { get; set; }

		// Token: 0x17007B42 RID: 31554
		// (get) Token: 0x06019A96 RID: 105110 RVA: 0x003A7986 File Offset: 0x003A5B86
		// (set) Token: 0x06019A97 RID: 105111 RVA: 0x003A798E File Offset: 0x003A5B8E
		public bool DisableRollbackWhileReconnect { get; set; }

		// Token: 0x17007B43 RID: 31555
		// (get) Token: 0x06019A98 RID: 105112 RVA: 0x003A7997 File Offset: 0x003A5B97
		// (set) Token: 0x06019A99 RID: 105113 RVA: 0x003A799F File Offset: 0x003A5B9F
		public IPosRollbackConfigT PosRollbackCfg { get; set; }

		// Token: 0x17007B44 RID: 31556
		// (get) Token: 0x06019A9A RID: 105114 RVA: 0x003A79A8 File Offset: 0x003A5BA8
		// (set) Token: 0x06019A9B RID: 105115 RVA: 0x003A79B0 File Offset: 0x003A5BB0
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x17007B45 RID: 31557
		// (get) Token: 0x06019A9C RID: 105116 RVA: 0x003A79B9 File Offset: 0x003A5BB9
		// (set) Token: 0x06019A9D RID: 105117 RVA: 0x003A79C1 File Offset: 0x003A5BC1
		public List<IInitConditionActionsT> InitConditionActions { get; set; }

		// Token: 0x17007B46 RID: 31558
		// (get) Token: 0x06019A9E RID: 105118 RVA: 0x003A79CA File Offset: 0x003A5BCA
		// (set) Token: 0x06019A9F RID: 105119 RVA: 0x003A79D2 File Offset: 0x003A5BD2
		public byte NullMask { get; set; }

		// Token: 0x06019AA0 RID: 105120 RVA: 0x003A79DB File Offset: 0x003A5BDB
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
