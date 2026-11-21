using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007347 RID: 29511
	public class INpcSitDownT
	{
		// Token: 0x1700D849 RID: 55369
		// (get) Token: 0x0603377C RID: 210812 RVA: 0x006F001F File Offset: 0x006EE21F
		// (set) Token: 0x0603377D RID: 210813 RVA: 0x006F0027 File Offset: 0x006EE227
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700D84A RID: 55370
		// (get) Token: 0x0603377E RID: 210814 RVA: 0x006F0030 File Offset: 0x006EE230
		// (set) Token: 0x0603377F RID: 210815 RVA: 0x006F0038 File Offset: 0x006EE238
		public bool KeepState { get; set; }

		// Token: 0x1700D84B RID: 55371
		// (get) Token: 0x06033780 RID: 210816 RVA: 0x006F0041 File Offset: 0x006EE241
		// (set) Token: 0x06033781 RID: 210817 RVA: 0x006F0049 File Offset: 0x006EE249
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700D84C RID: 55372
		// (get) Token: 0x06033782 RID: 210818 RVA: 0x006F0052 File Offset: 0x006EE252
		// (set) Token: 0x06033783 RID: 210819 RVA: 0x006F005A File Offset: 0x006EE25A
		public int PosEntityId { get; set; }

		// Token: 0x1700D84D RID: 55373
		// (get) Token: 0x06033784 RID: 210820 RVA: 0x006F0063 File Offset: 0x006EE263
		// (set) Token: 0x06033785 RID: 210821 RVA: 0x006F006B File Offset: 0x006EE26B
		public float Duration { get; set; }

		// Token: 0x1700D84E RID: 55374
		// (get) Token: 0x06033786 RID: 210822 RVA: 0x006F0074 File Offset: 0x006EE274
		// (set) Token: 0x06033787 RID: 210823 RVA: 0x006F007C File Offset: 0x006EE27C
		public byte NullMask { get; set; }

		// Token: 0x06033788 RID: 210824 RVA: 0x006F0085 File Offset: 0x006EE285
		public INpcSitDownT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.MontageId = null;
			this.PosEntityId = 0;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
