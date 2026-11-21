using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006204 RID: 25092
	public enum TAttachTiming : byte
	{
		// Token: 0x0401008C RID: 65676
		NONE,
		// Token: 0x0401008D RID: 65677
		IDefaultAttachTiming,
		// Token: 0x0401008E RID: 65678
		IOnEntityStateChangeAttachTiming,
		// Token: 0x0401008F RID: 65679
		IOnMoveWithSplineEndAttachTiming
	}
}
