using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200651B RID: 25883
	public enum TCommonBtDecorator : byte
	{
		// Token: 0x040106D7 RID: 67287
		NONE,
		// Token: 0x040106D8 RID: 67288
		ICommonBtAlwaysFalseDecorator,
		// Token: 0x040106D9 RID: 67289
		ICommonBtAlwaysTrueDecorator,
		// Token: 0x040106DA RID: 67290
		ICommonBtConditionDecorator,
		// Token: 0x040106DB RID: 67291
		ICommonBtCoolDownDecorator,
		// Token: 0x040106DC RID: 67292
		ICommonBtDoOnceDecorator
	}
}
