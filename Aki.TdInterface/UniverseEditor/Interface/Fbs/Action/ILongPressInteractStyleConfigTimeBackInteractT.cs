using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716A RID: 29034
	public class ILongPressInteractStyleConfigTimeBackInteractT
	{
		// Token: 0x1700D48B RID: 54411
		// (get) Token: 0x06032768 RID: 206696 RVA: 0x006D227F File Offset: 0x006D047F
		// (set) Token: 0x06032769 RID: 206697 RVA: 0x006D2287 File Offset: 0x006D0487
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x1700D48C RID: 54412
		// (get) Token: 0x0603276A RID: 206698 RVA: 0x006D2290 File Offset: 0x006D0490
		// (set) Token: 0x0603276B RID: 206699 RVA: 0x006D2298 File Offset: 0x006D0498
		public string TidContent { get; set; }

		// Token: 0x1700D48D RID: 54413
		// (get) Token: 0x0603276C RID: 206700 RVA: 0x006D22A1 File Offset: 0x006D04A1
		// (set) Token: 0x0603276D RID: 206701 RVA: 0x006D22A9 File Offset: 0x006D04A9
		public float StartProgress { get; set; }

		// Token: 0x1700D48E RID: 54414
		// (get) Token: 0x0603276E RID: 206702 RVA: 0x006D22B2 File Offset: 0x006D04B2
		// (set) Token: 0x0603276F RID: 206703 RVA: 0x006D22BA File Offset: 0x006D04BA
		public byte NullMask { get; set; }

		// Token: 0x06032770 RID: 206704 RVA: 0x006D22C3 File Offset: 0x006D04C3
		public ILongPressInteractStyleConfigTimeBackInteractT()
		{
			this.Type = ELongPressInteractStyle.Default;
			this.TidContent = null;
			this.StartProgress = 0f;
			this.NullMask = 0;
		}
	}
}
