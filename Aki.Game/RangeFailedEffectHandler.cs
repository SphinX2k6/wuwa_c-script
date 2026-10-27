using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x02001D68 RID: 7528
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class RangeFailedEffectHandler : AbstractHandler<RangeFailedParameterContext>
{
	// Token: 0x0600E500 RID: 58624 RVA: 0x0035F264 File Offset: 0x0035D464
	protected override void ExecuteStopping(RangeFailedParameterContext parameterContext)
	{
		if (EffectSystem.Instance.IsValid(parameterContext.RangeEffectHandleId))
		{
			EffectSystem.Instance.StopEffectById(parameterContext.RangeEffectHandleId, "[QuestFailedBehaviorNode.StopFailRangeEffect]", true, null);
		}
		parameterContext.RangeEffectHandleId = 0;
	}
}
