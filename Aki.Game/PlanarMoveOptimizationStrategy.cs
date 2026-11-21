using System;
using System.Runtime.CompilerServices;

// Token: 0x02002800 RID: 10240
public class PlanarMoveOptimizationStrategy : BaseOptimizationStrategy
{
	// Token: 0x06019C5F RID: 105567 RVA: 0x007F0FF8 File Offset: 0x007EF1F8
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

	// Token: 0x1700297E RID: 10622
	// (get) Token: 0x06019C60 RID: 105568 RVA: 0x007F1043 File Offset: 0x007EF243
	public override bool NeedEntityInOutRangeLocalInternal
	{
		get
		{
			return true;
		}
	}
}
