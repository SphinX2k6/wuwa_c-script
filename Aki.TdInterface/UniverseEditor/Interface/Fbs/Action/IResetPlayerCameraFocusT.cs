using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007613 RID: 30227
	public class IResetPlayerCameraFocusT
	{
		// Token: 0x1700DE19 RID: 56857
		// (get) Token: 0x060350A5 RID: 217253 RVA: 0x00720019 File Offset: 0x0071E219
		// (set) Token: 0x060350A6 RID: 217254 RVA: 0x00720021 File Offset: 0x0071E221
		public TResetPlayerFocusTypeUnion ResetType { get; set; }

		// Token: 0x1700DE1A RID: 56858
		// (get) Token: 0x060350A7 RID: 217255 RVA: 0x0072002A File Offset: 0x0071E22A
		// (set) Token: 0x060350A8 RID: 217256 RVA: 0x00720032 File Offset: 0x0071E232
		public float FadeInTime { get; set; }

		// Token: 0x1700DE1B RID: 56859
		// (get) Token: 0x060350A9 RID: 217257 RVA: 0x0072003B File Offset: 0x0071E23B
		// (set) Token: 0x060350AA RID: 217258 RVA: 0x00720043 File Offset: 0x0071E243
		public bool CannotInterrupt { get; set; }

		// Token: 0x1700DE1C RID: 56860
		// (get) Token: 0x060350AB RID: 217259 RVA: 0x0072004C File Offset: 0x0071E24C
		// (set) Token: 0x060350AC RID: 217260 RVA: 0x00720054 File Offset: 0x0071E254
		public float Duration { get; set; }

		// Token: 0x1700DE1D RID: 56861
		// (get) Token: 0x060350AD RID: 217261 RVA: 0x0072005D File Offset: 0x0071E25D
		// (set) Token: 0x060350AE RID: 217262 RVA: 0x00720065 File Offset: 0x0071E265
		public byte NullMask { get; set; }

		// Token: 0x060350AF RID: 217263 RVA: 0x0072006E File Offset: 0x0071E26E
		public IResetPlayerCameraFocusT()
		{
			this.ResetType = null;
			this.FadeInTime = 0f;
			this.CannotInterrupt = false;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
