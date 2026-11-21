using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CC RID: 29388
	public class IMp4GamepadShakeFadeOutConfigT
	{
		// Token: 0x1700D786 RID: 55174
		// (get) Token: 0x060333D9 RID: 209881 RVA: 0x006E9CDE File Offset: 0x006E7EDE
		// (set) Token: 0x060333DA RID: 209882 RVA: 0x006E9CE6 File Offset: 0x006E7EE6
		public float FadeOutTime { get; set; }

		// Token: 0x1700D787 RID: 55175
		// (get) Token: 0x060333DB RID: 209883 RVA: 0x006E9CEF File Offset: 0x006E7EEF
		// (set) Token: 0x060333DC RID: 209884 RVA: 0x006E9CF7 File Offset: 0x006E7EF7
		public EMp4GamepadShakeCurve FadeOutCurve { get; set; }

		// Token: 0x1700D788 RID: 55176
		// (get) Token: 0x060333DD RID: 209885 RVA: 0x006E9D00 File Offset: 0x006E7F00
		// (set) Token: 0x060333DE RID: 209886 RVA: 0x006E9D08 File Offset: 0x006E7F08
		public byte NullMask { get; set; }

		// Token: 0x060333DF RID: 209887 RVA: 0x006E9D11 File Offset: 0x006E7F11
		public IMp4GamepadShakeFadeOutConfigT()
		{
			this.FadeOutTime = 0f;
			this.FadeOutCurve = EMp4GamepadShakeCurve.Linear;
			this.NullMask = 0;
		}
	}
}
