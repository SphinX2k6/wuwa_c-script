using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072FF RID: 29439
	public class INpcExitCurrentInteractT
	{
		// Token: 0x1700D7DB RID: 55259
		// (get) Token: 0x06033575 RID: 210293 RVA: 0x006EC922 File Offset: 0x006EAB22
		// (set) Token: 0x06033576 RID: 210294 RVA: 0x006EC92A File Offset: 0x006EAB2A
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700D7DC RID: 55260
		// (get) Token: 0x06033577 RID: 210295 RVA: 0x006EC933 File Offset: 0x006EAB33
		// (set) Token: 0x06033578 RID: 210296 RVA: 0x006EC93B File Offset: 0x006EAB3B
		public bool KeepState { get; set; }

		// Token: 0x1700D7DD RID: 55261
		// (get) Token: 0x06033579 RID: 210297 RVA: 0x006EC944 File Offset: 0x006EAB44
		// (set) Token: 0x0603357A RID: 210298 RVA: 0x006EC94C File Offset: 0x006EAB4C
		public byte NullMask { get; set; }

		// Token: 0x0603357B RID: 210299 RVA: 0x006EC955 File Offset: 0x006EAB55
		public INpcExitCurrentInteractT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.NullMask = 0;
		}
	}
}
