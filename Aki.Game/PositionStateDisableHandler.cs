using System;
using System.Runtime.CompilerServices;

// Token: 0x020030B9 RID: 12473
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PositionStateDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x0601AB73 RID: 109427 RVA: 0x007325FC File Offset: 0x007307FC
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
