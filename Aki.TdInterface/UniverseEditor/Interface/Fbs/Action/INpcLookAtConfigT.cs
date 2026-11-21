using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732C RID: 29484
	public class INpcLookAtConfigT
	{
		// Token: 0x1700D81A RID: 55322
		// (get) Token: 0x060336B2 RID: 210610 RVA: 0x006EEB41 File Offset: 0x006ECD41
		// (set) Token: 0x060336B3 RID: 210611 RVA: 0x006EEB49 File Offset: 0x006ECD49
		public TNpcLookAtTypeUnion Target { get; set; }

		// Token: 0x1700D81B RID: 55323
		// (get) Token: 0x060336B4 RID: 210612 RVA: 0x006EEB52 File Offset: 0x006ECD52
		// (set) Token: 0x060336B5 RID: 210613 RVA: 0x006EEB5A File Offset: 0x006ECD5A
		public bool IsKeepOverAngle { get; set; }

		// Token: 0x1700D81C RID: 55324
		// (get) Token: 0x060336B6 RID: 210614 RVA: 0x006EEB63 File Offset: 0x006ECD63
		// (set) Token: 0x060336B7 RID: 210615 RVA: 0x006EEB6B File Offset: 0x006ECD6B
		public float MaxDistance { get; set; }

		// Token: 0x1700D81D RID: 55325
		// (get) Token: 0x060336B8 RID: 210616 RVA: 0x006EEB74 File Offset: 0x006ECD74
		// (set) Token: 0x060336B9 RID: 210617 RVA: 0x006EEB7C File Offset: 0x006ECD7C
		public float MaxAngle { get; set; }

		// Token: 0x1700D81E RID: 55326
		// (get) Token: 0x060336BA RID: 210618 RVA: 0x006EEB85 File Offset: 0x006ECD85
		// (set) Token: 0x060336BB RID: 210619 RVA: 0x006EEB8D File Offset: 0x006ECD8D
		public byte NullMask { get; set; }

		// Token: 0x060336BC RID: 210620 RVA: 0x006EEB96 File Offset: 0x006ECD96
		public INpcLookAtConfigT()
		{
			this.Target = null;
			this.IsKeepOverAngle = false;
			this.MaxDistance = 0f;
			this.MaxAngle = 0f;
			this.NullMask = 0;
		}
	}
}
