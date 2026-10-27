using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007056 RID: 28758
	public class ISetPlayerPosT
	{
		// Token: 0x1700D59D RID: 54685
		// (get) Token: 0x06032E60 RID: 208480 RVA: 0x006DDB5D File Offset: 0x006DBD5D
		// (set) Token: 0x06032E61 RID: 208481 RVA: 0x006DDB65 File Offset: 0x006DBD65
		public TTeleportConfigUnion TelePortConfig { get; set; }

		// Token: 0x1700D59E RID: 54686
		// (get) Token: 0x06032E62 RID: 208482 RVA: 0x006DDB6E File Offset: 0x006DBD6E
		// (set) Token: 0x06032E63 RID: 208483 RVA: 0x006DDB76 File Offset: 0x006DBD76
		public ITelePortAfterTimeOutT TeammateTeleportConfig { get; set; }

		// Token: 0x1700D59F RID: 54687
		// (get) Token: 0x06032E64 RID: 208484 RVA: 0x006DDB7F File Offset: 0x006DBD7F
		// (set) Token: 0x06032E65 RID: 208485 RVA: 0x006DDB87 File Offset: 0x006DBD87
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x1700D5A0 RID: 54688
		// (get) Token: 0x06032E66 RID: 208486 RVA: 0x006DDB90 File Offset: 0x006DBD90
		// (set) Token: 0x06032E67 RID: 208487 RVA: 0x006DDB98 File Offset: 0x006DBD98
		public bool DisableAutoFadeInScreen { get; set; }

		// Token: 0x1700D5A1 RID: 54689
		// (get) Token: 0x06032E68 RID: 208488 RVA: 0x006DDBA1 File Offset: 0x006DBDA1
		// (set) Token: 0x06032E69 RID: 208489 RVA: 0x006DDBA9 File Offset: 0x006DBDA9
		public bool OnlinePreciseTransport { get; set; }

		// Token: 0x1700D5A2 RID: 54690
		// (get) Token: 0x06032E6A RID: 208490 RVA: 0x006DDBB2 File Offset: 0x006DBDB2
		// (set) Token: 0x06032E6B RID: 208491 RVA: 0x006DDBBA File Offset: 0x006DBDBA
		public byte NullMask { get; set; }

		// Token: 0x06032E6C RID: 208492 RVA: 0x006DDBC3 File Offset: 0x006DBDC3
		public ISetPlayerPosT()
		{
			this.TelePortConfig = null;
			this.TeammateTeleportConfig = null;
			this.TransitionOption = null;
			this.DisableAutoFadeInScreen = false;
			this.OnlinePreciseTransport = false;
			this.NullMask = 0;
		}
	}
}
