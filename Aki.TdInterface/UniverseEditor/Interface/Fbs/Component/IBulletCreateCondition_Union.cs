using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3D RID: 20285
	public enum IBulletCreateCondition_Union : byte
	{
		// Token: 0x0400DDA4 RID: 56740
		NONE,
		// Token: 0x0400DDA5 RID: 56741
		IBulletCreateCondition,
		// Token: 0x0400DDA6 RID: 56742
		IOnHitCondition,
		// Token: 0x0400DDA7 RID: 56743
		IOnCollisionCondition,
		// Token: 0x0400DDA8 RID: 56744
		IOnMatchingCondition,
		// Token: 0x0400DDA9 RID: 56745
		IOnOpenGravityCollisionCondition,
		// Token: 0x0400DDAA RID: 56746
		IOnThrowTriggerTimeCondition
	}
}
