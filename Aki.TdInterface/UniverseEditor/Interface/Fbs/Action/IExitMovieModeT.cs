using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006727 RID: 26407
	public class IExitMovieModeT
	{
		// Token: 0x1700C424 RID: 50212
		// (get) Token: 0x0602DF04 RID: 188164 RVA: 0x00647C6F File Offset: 0x00645E6F
		// (set) Token: 0x0602DF05 RID: 188165 RVA: 0x00647C77 File Offset: 0x00645E77
		public float BorderAnimDuration { get; set; }

		// Token: 0x1700C425 RID: 50213
		// (get) Token: 0x0602DF06 RID: 188166 RVA: 0x00647C80 File Offset: 0x00645E80
		// (set) Token: 0x0602DF07 RID: 188167 RVA: 0x00647C88 File Offset: 0x00645E88
		public TEnterMovieModeDurationTypeUnion DurationType { get; set; }

		// Token: 0x1700C426 RID: 50214
		// (get) Token: 0x0602DF08 RID: 188168 RVA: 0x00647C91 File Offset: 0x00645E91
		// (set) Token: 0x0602DF09 RID: 188169 RVA: 0x00647C99 File Offset: 0x00645E99
		public IMovieModeFadeOutMaskConfigT FadeOutMaskConfig { get; set; }

		// Token: 0x1700C427 RID: 50215
		// (get) Token: 0x0602DF0A RID: 188170 RVA: 0x00647CA2 File Offset: 0x00645EA2
		// (set) Token: 0x0602DF0B RID: 188171 RVA: 0x00647CAA File Offset: 0x00645EAA
		public byte NullMask { get; set; }

		// Token: 0x0602DF0C RID: 188172 RVA: 0x00647CB3 File Offset: 0x00645EB3
		public IExitMovieModeT()
		{
			this.BorderAnimDuration = 0f;
			this.DurationType = null;
			this.FadeOutMaskConfig = null;
			this.NullMask = 0;
		}
	}
}
