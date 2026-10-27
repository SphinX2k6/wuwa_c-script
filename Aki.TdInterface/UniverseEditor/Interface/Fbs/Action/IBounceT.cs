using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200621C RID: 25116
	public class IBounceT
	{
		// Token: 0x1700BB2B RID: 47915
		// (get) Token: 0x0602B4B6 RID: 177334 RVA: 0x005F678D File Offset: 0x005F498D
		// (set) Token: 0x0602B4B7 RID: 177335 RVA: 0x005F6795 File Offset: 0x005F4995
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700BB2C RID: 47916
		// (get) Token: 0x0602B4B8 RID: 177336 RVA: 0x005F679E File Offset: 0x005F499E
		// (set) Token: 0x0602B4B9 RID: 177337 RVA: 0x005F67A6 File Offset: 0x005F49A6
		public int Height { get; set; }

		// Token: 0x1700BB2D RID: 47917
		// (get) Token: 0x0602B4BA RID: 177338 RVA: 0x005F67AF File Offset: 0x005F49AF
		// (set) Token: 0x0602B4BB RID: 177339 RVA: 0x005F67B7 File Offset: 0x005F49B7
		public float Time { get; set; }

		// Token: 0x1700BB2E RID: 47918
		// (get) Token: 0x0602B4BC RID: 177340 RVA: 0x005F67C0 File Offset: 0x005F49C0
		// (set) Token: 0x0602B4BD RID: 177341 RVA: 0x005F67C8 File Offset: 0x005F49C8
		public string MotionCurve { get; set; }

		// Token: 0x1700BB2F RID: 47919
		// (get) Token: 0x0602B4BE RID: 177342 RVA: 0x005F67D1 File Offset: 0x005F49D1
		// (set) Token: 0x0602B4BF RID: 177343 RVA: 0x005F67D9 File Offset: 0x005F49D9
		public byte NullMask { get; set; }

		// Token: 0x0602B4C0 RID: 177344 RVA: 0x005F67E2 File Offset: 0x005F49E2
		public IBounceT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Height = 0;
			this.Time = 0f;
			this.MotionCurve = null;
			this.NullMask = 0;
		}
	}
}
