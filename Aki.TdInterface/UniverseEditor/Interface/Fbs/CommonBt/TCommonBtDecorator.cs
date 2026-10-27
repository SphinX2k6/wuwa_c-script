using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED8 RID: 24280
	public enum TCommonBtDecorator : byte
	{
		// Token: 0x0400F974 RID: 63860
		NONE,
		// Token: 0x0400F975 RID: 63861
		ICommonBtAlwaysFalseDecorator,
		// Token: 0x0400F976 RID: 63862
		ICommonBtAlwaysTrueDecorator,
		// Token: 0x0400F977 RID: 63863
		ICommonBtConditionDecorator,
		// Token: 0x0400F978 RID: 63864
		ICommonBtCoolDownDecorator,
		// Token: 0x0400F979 RID: 63865
		ICommonBtDoOnceDecorator
	}
}
