using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006050 RID: 24656
	public enum ITeleControlDestroyCondition_Union : byte
	{
		// Token: 0x0400FDB6 RID: 64950
		NONE,
		// Token: 0x0400FDB7 RID: 64951
		ITeleControlDestroyCondition,
		// Token: 0x0400FDB8 RID: 64952
		ILetGoDestroyCondition,
		// Token: 0x0400FDB9 RID: 64953
		ICreateBulletDestroyCondition,
		// Token: 0x0400FDBA RID: 64954
		IThrowDestroyCondition
	}
}
