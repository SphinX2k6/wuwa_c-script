using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBC RID: 28348
	public class IRestorePlayerCameraAdjustmentT
	{
		// Token: 0x1700D304 RID: 54020
		// (get) Token: 0x060321B0 RID: 205232 RVA: 0x006C6467 File Offset: 0x006C4667
		// (set) Token: 0x060321B1 RID: 205233 RVA: 0x006C646F File Offset: 0x006C466F
		public IResetFocusConfigT ResetFocus { get; set; }

		// Token: 0x1700D305 RID: 54021
		// (get) Token: 0x060321B2 RID: 205234 RVA: 0x006C6478 File Offset: 0x006C4678
		// (set) Token: 0x060321B3 RID: 205235 RVA: 0x006C6480 File Offset: 0x006C4680
		public string SubScreenKey { get; set; }

		// Token: 0x060321B4 RID: 205236 RVA: 0x006C6489 File Offset: 0x006C4689
		public IRestorePlayerCameraAdjustmentT()
		{
			this.ResetFocus = null;
			this.SubScreenKey = null;
		}
	}
}
