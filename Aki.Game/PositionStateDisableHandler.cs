using System;
using System.Runtime.CompilerServices;

// Token: 0x02002611 RID: 9745
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PositionStateDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x06018582 RID: 99714 RVA: 0x00757F68 File Offset: 0x00756168
	protected override bool ShouldStop(InputFunctionContext context)
	{
		BaseUnifiedStateComponent component = context.Entity.GetComponent<BaseUnifiedStateComponent>();
		ECharPositionState? echarPositionState = (component != null) ? new ECharPositionState?(component.PositionState) : null;
		switch (context.SkillId)
		{
		case 800001:
		case 800003:
		{
			ECharPositionState? echarPositionState2 = echarPositionState;
			ECharPositionState echarPositionState3 = ECharPositionState.Ground;
			return !(echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null) && echarPositionState.GetValueOrDefault() != ECharPositionState.Air;
		}
		case 800002:
		{
			ECharPositionState? echarPositionState2 = echarPositionState;
			ECharPositionState echarPositionState3 = ECharPositionState.Ground;
			return !(echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null);
		}
		default:
			return false;
		}
	}
}
