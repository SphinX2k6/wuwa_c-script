using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007640 RID: 30272
	public class IRestorePlayerCameraAdjustmentT
	{
		// Token: 0x1700DE5B RID: 56923
		// (get) Token: 0x060351F0 RID: 217584 RVA: 0x0072219B File Offset: 0x0072039B
		// (set) Token: 0x060351F1 RID: 217585 RVA: 0x007221A3 File Offset: 0x007203A3
		public IResetFocusConfigT ResetFocus { get; set; }

		// Token: 0x1700DE5C RID: 56924
		// (get) Token: 0x060351F2 RID: 217586 RVA: 0x007221AC File Offset: 0x007203AC
		// (set) Token: 0x060351F3 RID: 217587 RVA: 0x007221B4 File Offset: 0x007203B4
		public string SubScreenKey { get; set; }

		// Token: 0x060351F4 RID: 217588 RVA: 0x007221BD File Offset: 0x007203BD
		public IRestorePlayerCameraAdjustmentT()
		{
			this.ResetFocus = null;
			this.SubScreenKey = null;
		}
	}
}
