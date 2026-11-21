using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x02002619 RID: 9753
public class InputLayerQueryHelper : IStaticVariableResetter
{
	// Token: 0x060185A4 RID: 99748 RVA: 0x007593AE File Offset: 0x007575AE
	static InputLayerQueryHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputLayerQueryHelper.CreateStaticDefaultValue), new Action(InputLayerQueryHelper.ResetStaticDefaultValue));
	}

	// Token: 0x060185A5 RID: 99749 RVA: 0x007593CD File Offset: 0x007575CD
	public static void CreateStaticDefaultValue()
	{
		InputLayerQueryHelper.HoldConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>>();
		InputLayerQueryHelper.CacheConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>>();
		InputLayerQueryHelper.MoveAxisToButtonConfigCaches = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache>();
	}

	// Token: 0x060185A6 RID: 99750 RVA: 0x007593ED File Offset: 0x007575ED
	public static void ResetStaticDefaultValue()
	{
		InputLayerQueryHelper.HoldConfigCache = null;
		InputLayerQueryHelper.CacheConfigCache = null;
		InputLayerQueryHelper.MoveAxisToButtonConfigCaches = null;
	}

	// Token: 0x060185A7 RID: 99751 RVA: 0x00759404 File Offset: 0x00757604
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static InputLayerQueryResult<T> FindLayerResult<[Nullable(2)] T>(List<InputLayer> inputLayers, Func<InputLayer, T> query, Func<T, bool> isValid)
	{
		foreach (InputLayer inputLayer in inputLayers)
		{
			T t = query(inputLayer);
			if (isValid(t))
			{
				return new InputLayerQueryResult<T>
				{
					Layer = inputLayer,
					Result = t
				};
			}
		}
		return null;
	}

	// Token: 0x060185A8 RID: 99752 RVA: 0x00759478 File Offset: 0x00757678
	[NullableContext(2)]
	public static BP_InputBase_C GetFirstBpInputComp(int unitId)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		InputLayerQueryResult<BP_InputBase_C> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<BP_InputBase_C>(inputLayers, ([Nullable(1)] InputLayer layer) => layer.GetBpInputComp(), (BP_InputBase_C bpInputComp) => bpInputComp != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x060185A9 RID: 99753 RVA: 0x007594E8 File Offset: 0x007576E8
	public static SInputHoldConfig? GetHoldConfig(int unitId, CSharpScript.Game.Input.EInputAction action)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		InputLayerQueryResult<SInputHoldConfig?> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputHoldConfig?>(inputLayers, delegate(InputLayer layer)
		{
			BP_InputBase_C bpInputComp = layer.GetBpInputComp(action, EInputState.Hold);
			if (bpInputComp == null)
			{
				return null;
			}
			return InputLayerQueryHelper.GetCachedConfig<SInputHoldConfig>(InputLayerQueryHelper.GetHoldConfigCache(), bpInputComp, action, delegate(BP_InputBase_C inputComp)
			{
				SInputHoldConfig unrealHoldConfig = inputComp.GetUnrealHoldConfig((int)action);
				if (!layer.IsCheckHoldConfigTime(action))
				{
					return new SInputHoldConfig?(unrealHoldConfig);
				}
				if (unrealHoldConfig.触发时间 == 0f)
				{
					return null;
				}
				return new SInputHoldConfig?(unrealHoldConfig);
			});
		}, (SInputHoldConfig? config) => config != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x060185AA RID: 99754 RVA: 0x00759560 File Offset: 0x00757760
	public static SInputCaches? GetCacheConfig(int unitId, CSharpScript.Game.Input.EInputAction action)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		Func<BP_InputBase_C, SInputCaches?> <>9__2;
		InputLayerQueryResult<SInputCaches?> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputCaches?>(inputLayers, delegate(InputLayer layer)
		{
			BP_InputBase_C bpInputComp = layer.GetBpInputComp();
			if (bpInputComp == null)
			{
				return null;
			}
			ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> cacheConfigCache = InputLayerQueryHelper.GetCacheConfigCache();
			BP_InputBase_C bpInputComp2 = bpInputComp;
			CSharpScript.Game.Input.EInputAction action2 = action;
			Func<BP_InputBase_C, SInputCaches?> getter;
			if ((getter = <>9__2) == null)
			{
				getter = (<>9__2 = delegate(BP_InputBase_C inputComp)
				{
					SInputCaches unrealCacheConfig = inputComp.GetUnrealCacheConfig((int)action);
					if (unrealCacheConfig.按下 == 0f && unrealCacheConfig.抬起 == 0f && unrealCacheConfig.长按 == 0f)
					{
						return null;
					}
					return new SInputCaches?(unrealCacheConfig);
				});
			}
			return InputLayerQueryHelper.GetCachedConfig<SInputCaches>(cacheConfigCache, bpInputComp2, action2, getter);
		}, (SInputCaches? config) => config != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x060185AB RID: 99755 RVA: 0x007595D8 File Offset: 0x007577D8
	[NullableContext(2)]
	public static SInputActive GetMoveAxisToButtonConfig(int unitId)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		InputLayerQueryResult<SInputActive> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputActive>(inputLayers, delegate([Nullable(1)] InputLayer layer)
		{
			BP_InputBase_C bpInputComp = layer.GetBpInputComp();
			if (bpInputComp == null)
			{
				return null;
			}
			return InputLayerQueryHelper.GetMoveAxisToButtonConfigByBp(bpInputComp);
		}, (SInputActive config) => config != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x060185AC RID: 99756 RVA: 0x00759648 File Offset: 0x00757848
	private static T? GetCachedConfig<T>([Nullable(new byte[]
	{
		1,
		1,
		1,
		0
	})] ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<T>> cache, [Nullable(1)] BP_InputBase_C bpInputComp, CSharpScript.Game.Input.EInputAction action, [Nullable(new byte[]
	{
		1,
		1,
		0
	})] Func<BP_InputBase_C, T?> getter) where T : struct
	{
		InputLayerQueryHelper.ActionConfigCache<T> value = cache.GetValue(bpInputComp, (BP_InputBase_C _) => new InputLayerQueryHelper.ActionConfigCache<T>());
		if (!value.Configs.ContainsKey(action))
		{
			value.Configs[action] = getter(bpInputComp);
		}
		return value.Configs[action];
	}

	// Token: 0x060185AD RID: 99757 RVA: 0x007596AC File Offset: 0x007578AC
	[NullableContext(1)]
	[return: Nullable(2)]
	private static SInputActive GetMoveAxisToButtonConfigByBp(BP_InputBase_C bpInputComp)
	{
		InputLayerQueryHelper.MoveAxisToButtonConfigCache value = InputLayerQueryHelper.GetMoveAxisToButtonConfigCaches().GetValue(bpInputComp, (BP_InputBase_C _) => new InputLayerQueryHelper.MoveAxisToButtonConfigCache());
		if (!value.HasValue)
		{
			SInputActive 激活移动输入映射按键事件 = bpInputComp.激活移动输入映射按键事件;
			TArray<SInputActiveCondition> tarray = (激活移动输入映射按键事件 != null) ? 激活移动输入映射按键事件.InputActiveConditionGroup : null;
			value.Config = ((tarray != null && tarray.Num() > 0) ? 激活移动输入映射按键事件 : null);
			value.HasValue = true;
		}
		return value.Config;
	}

	// Token: 0x060185AE RID: 99758 RVA: 0x00759723 File Offset: 0x00757923
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>> GetHoldConfigCache()
	{
		if (InputLayerQueryHelper.HoldConfigCache == null)
		{
			InputLayerQueryHelper.HoldConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>>();
		}
		return InputLayerQueryHelper.HoldConfigCache;
	}

	// Token: 0x060185AF RID: 99759 RVA: 0x0075973B File Offset: 0x0075793B
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> GetCacheConfigCache()
	{
		if (InputLayerQueryHelper.CacheConfigCache == null)
		{
			InputLayerQueryHelper.CacheConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>>();
		}
		return InputLayerQueryHelper.CacheConfigCache;
	}

	// Token: 0x060185B0 RID: 99760 RVA: 0x00759753 File Offset: 0x00757953
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache> GetMoveAxisToButtonConfigCaches()
	{
		if (InputLayerQueryHelper.MoveAxisToButtonConfigCaches == null)
		{
			InputLayerQueryHelper.MoveAxisToButtonConfigCaches = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache>();
		}
		return InputLayerQueryHelper.MoveAxisToButtonConfigCaches;
	}

	// Token: 0x0400D24D RID: 53837
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>> HoldConfigCache;

	// Token: 0x0400D24E RID: 53838
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> CacheConfigCache;

	// Token: 0x0400D24F RID: 53839
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache> MoveAxisToButtonConfigCaches;

	// Token: 0x02008897 RID: 34967
	private class ActionConfigCache<T> where T : struct
	{
		// Token: 0x0402BA84 RID: 178820
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public readonly Dictionary<CSharpScript.Game.Input.EInputAction, T?> Configs = new Dictionary<CSharpScript.Game.Input.EInputAction, T?>();
	}

	// Token: 0x02008898 RID: 34968
	private class MoveAxisToButtonConfigCache
	{
		// Token: 0x0402BA85 RID: 178821
		public bool HasValue;

		// Token: 0x0402BA86 RID: 178822
		[Nullable(2)]
		public SInputActive Config;
	}
}
