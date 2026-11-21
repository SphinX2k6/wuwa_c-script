using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200620A RID: 25098
	public enum TBulletCreateCondition : byte
	{
		// Token: 0x04010099 RID: 65689
		NONE,
		// Token: 0x0401009A RID: 65690
		IOnCollisionCondition,
		// Token: 0x0401009B RID: 65691
		IOnHitCondition,
		// Token: 0x0401009C RID: 65692
		IOnMatchingCondition,
		// Token: 0x0401009D RID: 65693
		IOnOpenGravityCollisionCondition,
		// Token: 0x0401009E RID: 65694
		IOnThrowTriggerTimeCondition
	}
}
