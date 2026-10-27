using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB7 RID: 24247
	public enum ICommonBtDecoratorBase_Union : byte
	{
		// Token: 0x0400F928 RID: 63784
		NONE,
		// Token: 0x0400F929 RID: 63785
		ICommonBtDecoratorBase,
		// Token: 0x0400F92A RID: 63786
		ICommonBtConditionDecorator,
		// Token: 0x0400F92B RID: 63787
		ICommonBtAlwaysFalseDecorator,
		// Token: 0x0400F92C RID: 63788
		ICommonBtAlwaysTrueDecorator,
		// Token: 0x0400F92D RID: 63789
		ICommonBtDoOnceDecorator,
		// Token: 0x0400F92E RID: 63790
		ICommonBtCoolDownDecorator
	}
}
