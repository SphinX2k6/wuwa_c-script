using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546F RID: 21615
	public enum IBulletCreateCondition_Union : byte
	{
		// Token: 0x0400E953 RID: 59731
		NONE,
		// Token: 0x0400E954 RID: 59732
		IBulletCreateCondition,
		// Token: 0x0400E955 RID: 59733
		IOnHitCondition,
		// Token: 0x0400E956 RID: 59734
		IOnCollisionCondition,
		// Token: 0x0400E957 RID: 59735
		IOnMatchingCondition,
		// Token: 0x0400E958 RID: 59736
		IOnOpenGravityCollisionCondition,
		// Token: 0x0400E959 RID: 59737
		IOnThrowTriggerTimeCondition
	}
}
