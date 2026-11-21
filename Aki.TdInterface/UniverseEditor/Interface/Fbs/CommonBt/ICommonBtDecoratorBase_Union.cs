using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064FA RID: 25850
	public enum ICommonBtDecoratorBase_Union : byte
	{
		// Token: 0x0401068B RID: 67211
		NONE,
		// Token: 0x0401068C RID: 67212
		ICommonBtDecoratorBase,
		// Token: 0x0401068D RID: 67213
		ICommonBtConditionDecorator,
		// Token: 0x0401068E RID: 67214
		ICommonBtAlwaysFalseDecorator,
		// Token: 0x0401068F RID: 67215
		ICommonBtAlwaysTrueDecorator,
		// Token: 0x04010690 RID: 67216
		ICommonBtDoOnceDecorator,
		// Token: 0x04010691 RID: 67217
		ICommonBtCoolDownDecorator
	}
}
