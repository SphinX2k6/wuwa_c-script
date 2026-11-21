using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200605A RID: 24666
	public class ITeleportComponentT
	{
		// Token: 0x1700B71C RID: 46876
		// (get) Token: 0x06029A72 RID: 170610 RVA: 0x005AFC01 File Offset: 0x005ADE01
		// (set) Token: 0x06029A73 RID: 170611 RVA: 0x005AFC09 File Offset: 0x005ADE09
		public bool Disabled { get; set; }

		// Token: 0x1700B71D RID: 46877
		// (get) Token: 0x06029A74 RID: 170612 RVA: 0x005AFC12 File Offset: 0x005ADE12
		// (set) Token: 0x06029A75 RID: 170613 RVA: 0x005AFC1A File Offset: 0x005ADE1A
		public int TeleporterId { get; set; }

		// Token: 0x1700B71E RID: 46878
		// (get) Token: 0x06029A76 RID: 170614 RVA: 0x005AFC23 File Offset: 0x005ADE23
		// (set) Token: 0x06029A77 RID: 170615 RVA: 0x005AFC2B File Offset: 0x005ADE2B
		public IPosAT TeleportPos { get; set; }

		// Token: 0x1700B71F RID: 46879
		// (get) Token: 0x06029A78 RID: 170616 RVA: 0x005AFC34 File Offset: 0x005ADE34
		// (set) Token: 0x06029A79 RID: 170617 RVA: 0x005AFC3C File Offset: 0x005ADE3C
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700B720 RID: 46880
		// (get) Token: 0x06029A7A RID: 170618 RVA: 0x005AFC45 File Offset: 0x005ADE45
		// (set) Token: 0x06029A7B RID: 170619 RVA: 0x005AFC4D File Offset: 0x005ADE4D
		public byte NullMask { get; set; }

		// Token: 0x06029A7C RID: 170620 RVA: 0x005AFC56 File Offset: 0x005ADE56
		public ITeleportComponentT()
		{
			this.Disabled = false;
			this.TeleporterId = 0;
			this.TeleportPos = null;
			this.GravityConfig = null;
			this.NullMask = 0;
		}
	}
}
