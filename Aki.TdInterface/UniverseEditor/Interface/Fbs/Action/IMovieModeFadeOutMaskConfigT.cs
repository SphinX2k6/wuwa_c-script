using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B72 RID: 27506
	public class IMovieModeFadeOutMaskConfigT
	{
		// Token: 0x1700CC74 RID: 52340
		// (get) Token: 0x060304D6 RID: 197846 RVA: 0x00690396 File Offset: 0x0068E596
		// (set) Token: 0x060304D7 RID: 197847 RVA: 0x0069039E File Offset: 0x0068E59E
		public bool IsEnableMask { get; set; }

		// Token: 0x1700CC75 RID: 52341
		// (get) Token: 0x060304D8 RID: 197848 RVA: 0x006903A7 File Offset: 0x0068E5A7
		// (set) Token: 0x060304D9 RID: 197849 RVA: 0x006903AF File Offset: 0x0068E5AF
		public float TransitionTime { get; set; }

		// Token: 0x1700CC76 RID: 52342
		// (get) Token: 0x060304DA RID: 197850 RVA: 0x006903B8 File Offset: 0x0068E5B8
		// (set) Token: 0x060304DB RID: 197851 RVA: 0x006903C0 File Offset: 0x0068E5C0
		public byte NullMask { get; set; }

		// Token: 0x060304DC RID: 197852 RVA: 0x006903C9 File Offset: 0x0068E5C9
		public IMovieModeFadeOutMaskConfigT()
		{
			this.IsEnableMask = false;
			this.TransitionTime = 0f;
			this.NullMask = 0;
		}
	}
}
