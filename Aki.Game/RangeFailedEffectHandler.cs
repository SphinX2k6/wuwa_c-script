using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x0200122A RID: 4650
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class RangeFailedEffectHandler : AbstractHandler<RangeFailedParameterContext>
{
	// Token: 0x0600B91E RID: 47390 RVA: 0x0036AEB8 File Offset: 0x003690B8
	protected override void ExecuteStopping(RangeFailedParameterContext parameterContext)
	{
		if (EffectSystem.Instance.IsValid(parameterContext.RangeEffectHandleId))
		{
			EffectSystem.Instance.StopEffectById(parameterContext.RangeEffectHandleId, "[QuestFailedBehaviorNode.StopFailRangeEffect]", true, null);
		}
		parameterContext.RangeEffectHandleId = 0;
	}
}
