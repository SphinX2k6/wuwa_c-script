using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C9 RID: 29385
	public class IMp4GamepadShakeFadeInConfigT
	{
		// Token: 0x1700D77F RID: 55167
		// (get) Token: 0x060333BF RID: 209855 RVA: 0x006E9A3E File Offset: 0x006E7C3E
		// (set) Token: 0x060333C0 RID: 209856 RVA: 0x006E9A46 File Offset: 0x006E7C46
		public float FadeInTime { get; set; }

		// Token: 0x1700D780 RID: 55168
		// (get) Token: 0x060333C1 RID: 209857 RVA: 0x006E9A4F File Offset: 0x006E7C4F
		// (set) Token: 0x060333C2 RID: 209858 RVA: 0x006E9A57 File Offset: 0x006E7C57
		public EMp4GamepadShakeCurve FadeInCurve { get; set; }

		// Token: 0x1700D781 RID: 55169
		// (get) Token: 0x060333C3 RID: 209859 RVA: 0x006E9A60 File Offset: 0x006E7C60
		// (set) Token: 0x060333C4 RID: 209860 RVA: 0x006E9A68 File Offset: 0x006E7C68
		public byte NullMask { get; set; }

		// Token: 0x060333C5 RID: 209861 RVA: 0x006E9A71 File Offset: 0x006E7C71
		public IMp4GamepadShakeFadeInConfigT()
		{
			this.FadeInTime = 0f;
			this.FadeInCurve = EMp4GamepadShakeCurve.Linear;
			this.NullMask = 0;
		}
	}
}
