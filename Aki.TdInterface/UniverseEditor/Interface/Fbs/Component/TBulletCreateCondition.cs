using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF1 RID: 23537
	public enum TBulletCreateCondition : byte
	{
		// Token: 0x0400F38C RID: 62348
		NONE,
		// Token: 0x0400F38D RID: 62349
		IOnCollisionCondition,
		// Token: 0x0400F38E RID: 62350
		IOnHitCondition,
		// Token: 0x0400F38F RID: 62351
		IOnMatchingCondition,
		// Token: 0x0400F390 RID: 62352
		IOnOpenGravityCollisionCondition,
		// Token: 0x0400F391 RID: 62353
		IOnThrowTriggerTimeCondition
	}
}
