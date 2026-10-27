using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B86 RID: 27526
	public class IMp4GamepadShakeFadeOutConfigT
	{
		// Token: 0x1700CCA1 RID: 52385
		// (get) Token: 0x06030581 RID: 198017 RVA: 0x006916BE File Offset: 0x0068F8BE
		// (set) Token: 0x06030582 RID: 198018 RVA: 0x006916C6 File Offset: 0x0068F8C6
		public float FadeOutTime { get; set; }

		// Token: 0x1700CCA2 RID: 52386
		// (get) Token: 0x06030583 RID: 198019 RVA: 0x006916CF File Offset: 0x0068F8CF
		// (set) Token: 0x06030584 RID: 198020 RVA: 0x006916D7 File Offset: 0x0068F8D7
		public EMp4GamepadShakeCurve FadeOutCurve { get; set; }

		// Token: 0x1700CCA3 RID: 52387
		// (get) Token: 0x06030585 RID: 198021 RVA: 0x006916E0 File Offset: 0x0068F8E0
		// (set) Token: 0x06030586 RID: 198022 RVA: 0x006916E8 File Offset: 0x0068F8E8
		public byte NullMask { get; set; }

		// Token: 0x06030587 RID: 198023 RVA: 0x006916F1 File Offset: 0x0068F8F1
		public IMp4GamepadShakeFadeOutConfigT()
		{
			this.FadeOutTime = 0f;
			this.FadeOutCurve = EMp4GamepadShakeCurve.Linear;
			this.NullMask = 0;
		}
	}
}
