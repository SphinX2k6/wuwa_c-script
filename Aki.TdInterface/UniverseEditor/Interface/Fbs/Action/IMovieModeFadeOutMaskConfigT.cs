using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B8 RID: 29368
	public class IMovieModeFadeOutMaskConfigT
	{
		// Token: 0x1700D759 RID: 55129
		// (get) Token: 0x0603332E RID: 209710 RVA: 0x006E89B6 File Offset: 0x006E6BB6
		// (set) Token: 0x0603332F RID: 209711 RVA: 0x006E89BE File Offset: 0x006E6BBE
		public bool IsEnableMask { get; set; }

		// Token: 0x1700D75A RID: 55130
		// (get) Token: 0x06033330 RID: 209712 RVA: 0x006E89C7 File Offset: 0x006E6BC7
		// (set) Token: 0x06033331 RID: 209713 RVA: 0x006E89CF File Offset: 0x006E6BCF
		public float TransitionTime { get; set; }

		// Token: 0x1700D75B RID: 55131
		// (get) Token: 0x06033332 RID: 209714 RVA: 0x006E89D8 File Offset: 0x006E6BD8
		// (set) Token: 0x06033333 RID: 209715 RVA: 0x006E89E0 File Offset: 0x006E6BE0
		public byte NullMask { get; set; }

		// Token: 0x06033334 RID: 209716 RVA: 0x006E89E9 File Offset: 0x006E6BE9
		public IMovieModeFadeOutMaskConfigT()
		{
			this.IsEnableMask = false;
			this.TransitionTime = 0f;
			this.NullMask = 0;
		}
	}
}
