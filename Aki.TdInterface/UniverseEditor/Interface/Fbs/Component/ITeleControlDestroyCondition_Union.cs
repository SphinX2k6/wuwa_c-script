using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A43 RID: 23107
	public enum ITeleControlDestroyCondition_Union : byte
	{
		// Token: 0x0400F0BF RID: 61631
		NONE,
		// Token: 0x0400F0C0 RID: 61632
		ITeleControlDestroyCondition,
		// Token: 0x0400F0C1 RID: 61633
		ILetGoDestroyCondition,
		// Token: 0x0400F0C2 RID: 61634
		ICreateBulletDestroyCondition,
		// Token: 0x0400F0C3 RID: 61635
		IThrowDestroyCondition
	}
}
