using System;
using System.Runtime.CompilerServices;

// Token: 0x0200328F RID: 12943
public class PlanarMoveOptimizationStrategy : BaseOptimizationStrategy
{
	// Token: 0x0601C04B RID: 114763 RVA: 0x007C9D9C File Offset: 0x007C7F9C
	[NullableContext(1)]
	protected override void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
	{
		if (handle == null || !handle.Valid)
		{
			return;
		}
		CharacterMoveComponent component = handle.Entity.GetComponent<CharacterMoveComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetKuroPlanarPhysWalking(isEnter);
		component.SetKuroAsyncRootMotion(isEnter);
	}
}
