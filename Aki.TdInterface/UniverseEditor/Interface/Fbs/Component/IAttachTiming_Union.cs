using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F4 RID: 21492
	public enum IAttachTiming_Union : byte
	{
		// Token: 0x0400E85D RID: 59485
		NONE,
		// Token: 0x0400E85E RID: 59486
		IAttachTiming,
		// Token: 0x0400E85F RID: 59487
		IDefaultAttachTiming,
		// Token: 0x0400E860 RID: 59488
		IOnMoveWithSplineEndAttachTiming,
		// Token: 0x0400E861 RID: 59489
		IOnEntityStateChangeAttachTiming
	}
}
