using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA7 RID: 28071
	public class IExitMovieModeT
	{
		// Token: 0x1700CDDA RID: 52698
		// (get) Token: 0x0603074A RID: 198474 RVA: 0x006953B3 File Offset: 0x006935B3
		// (set) Token: 0x0603074B RID: 198475 RVA: 0x006953BB File Offset: 0x006935BB
		public float BorderAnimDuration { get; set; }

		// Token: 0x1700CDDB RID: 52699
		// (get) Token: 0x0603074C RID: 198476 RVA: 0x006953C4 File Offset: 0x006935C4
		// (set) Token: 0x0603074D RID: 198477 RVA: 0x006953CC File Offset: 0x006935CC
		public TEnterMovieModeDurationTypeUnion DurationType { get; set; }

		// Token: 0x1700CDDC RID: 52700
		// (get) Token: 0x0603074E RID: 198478 RVA: 0x006953D5 File Offset: 0x006935D5
		// (set) Token: 0x0603074F RID: 198479 RVA: 0x006953DD File Offset: 0x006935DD
		public IMovieModeFadeOutMaskConfigT FadeOutMaskConfig { get; set; }

		// Token: 0x1700CDDD RID: 52701
		// (get) Token: 0x06030750 RID: 198480 RVA: 0x006953E6 File Offset: 0x006935E6
		// (set) Token: 0x06030751 RID: 198481 RVA: 0x006953EE File Offset: 0x006935EE
		public byte NullMask { get; set; }

		// Token: 0x06030752 RID: 198482 RVA: 0x006953F7 File Offset: 0x006935F7
		public IExitMovieModeT()
		{
			this.BorderAnimDuration = 0f;
			this.DurationType = null;
			this.FadeOutMaskConfig = null;
			this.NullMask = 0;
		}
	}
}
