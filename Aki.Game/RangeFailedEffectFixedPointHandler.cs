using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200122C RID: 4652
[NullableContext(1)]
[Nullable(0)]
internal class RangeFailedEffectFixedPointHandler : RangeFailedEffectHandler
{
	// Token: 0x0600B928 RID: 47400 RVA: 0x0036B28C File Offset: 0x0036948C
	private static bool FixedPointValid(RangeFailedParameterContext context)
	{
		return context.IsValid() && context.RangeFailedEffectCenterPos != null && context.RangeFailedEffectRadius > 0f;
	}

	// Token: 0x0600B929 RID: 47401 RVA: 0x0036B2AD File Offset: 0x003694AD
	protected override bool CanHandle(RangeFailedParameterContext context)
	{
		return RangeFailedEffectFixedPointHandler.FixedPointValid(context);
	}

	// Token: 0x0600B92A RID: 47402 RVA: 0x0036B2B5 File Offset: 0x003694B5
	protected override bool ShouldStop(RangeFailedParameterContext context)
	{
		return RangeFailedEffectFixedPointHandler.FixedPointValid(context);
	}

	// Token: 0x0600B92B RID: 47403 RVA: 0x0036B2C0 File Offset: 0x003694C0
	protected override void ExecuteProcessing(RangeFailedParameterContext context)
	{
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = context.RangeFailedEffectCenterPos.ToUeVector(false);
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref Rotator.ZeroRotator, ref fvectorDouble, ref Vector.OneVector));
		Func<int, bool> <>9__1;
		instance.SpawnEffect(world, ftransformDouble, context.RangeFailedEffectPath, "[QuestFailedBehaviorNode.RangeFailedEffectFixedPointHandler]", null, EEffectType.Scene, null, delegate(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "GeneralLogicTree:CheckPointEffectController.SpawnEffect 错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (handle == 0)
			{
				return;
			}
			context.RangeEffectHandleId = handle;
			EffectSystem instance3 = EffectSystem.Instance;
			FName value = FNameUtil.GetDynamicFName("CircleRadius").Value;
			instance3.SetEffectDataFloatConstParam(handle, value, context.RangeFailedEffectRadius);
			EffectSystem instance4 = EffectSystem.Instance;
			Func<int, bool> func;
			if ((func = <>9__1) == null)
			{
				func = (<>9__1 = ((int _) => context.RangeEffectHandleId != 0));
			}
			instance4.RegisterCustomCheckOwnerFunc(handle, func);
		}, null, false, false);
	}
}
