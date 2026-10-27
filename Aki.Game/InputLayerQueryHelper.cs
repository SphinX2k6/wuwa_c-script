using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x020030C1 RID: 12481
public class InputLayerQueryHelper : IStaticVariableResetter
{
	// Token: 0x0601AB95 RID: 109461 RVA: 0x00733A42 File Offset: 0x00731C42
	static InputLayerQueryHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputLayerQueryHelper.CreateStaticDefaultValue), new Action(InputLayerQueryHelper.ResetStaticDefaultValue));
	}

	// Token: 0x0601AB96 RID: 109462 RVA: 0x00733A61 File Offset: 0x00731C61
	public static void CreateStaticDefaultValue()
	{
		InputLayerQueryHelper.HoldConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>>();
		InputLayerQueryHelper.CacheConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>>();
		InputLayerQueryHelper.MoveAxisToButtonConfigCaches = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache>();
	}

	// Token: 0x0601AB97 RID: 109463 RVA: 0x00733A81 File Offset: 0x00731C81
	public static void ResetStaticDefaultValue()
	{
		InputLayerQueryHelper.HoldConfigCache = null;
		InputLayerQueryHelper.CacheConfigCache = null;
		InputLayerQueryHelper.MoveAxisToButtonConfigCaches = null;
	}

	// Token: 0x0601AB98 RID: 109464 RVA: 0x00733A98 File Offset: 0x00731C98
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

	// Token: 0x0601AB99 RID: 109465 RVA: 0x00733B0C File Offset: 0x00731D0C
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

	// Token: 0x0601AB9A RID: 109466 RVA: 0x00733B7C File Offset: 0x00731D7C
	public static SInputHoldConfig? GetHoldConfig(int unitId, EInputAction action)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		Func<BP_InputBase_C, SInputHoldConfig> <>9__2;
		InputLayerQueryResult<SInputHoldConfig?> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputHoldConfig?>(inputLayers, delegate(InputLayer layer)
		{
			BP_InputBase_C bpInputComp = layer.GetBpInputComp();
			if (bpInputComp == null)
			{
				return null;
			}
			ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>> holdConfigCache = InputLayerQueryHelper.GetHoldConfigCache();
			BP_InputBase_C bpInputComp2 = bpInputComp;
			EInputAction action2 = action;
			Func<BP_InputBase_C, SInputHoldConfig> getter;
			if ((getter = <>9__2) == null)
			{
				getter = (<>9__2 = ((BP_InputBase_C inputComp) => inputComp.GetUnrealHoldConfig((int)action)));
			}
			return InputLayerQueryHelper.GetCachedConfig<SInputHoldConfig>(holdConfigCache, bpInputComp2, action2, getter);
		}, (SInputHoldConfig? config) => config != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x0601AB9B RID: 109467 RVA: 0x00733BF4 File Offset: 0x00731DF4
	public static SInputCaches? GetCacheConfig(int unitId, EInputAction action)
	{
		List<InputLayer> inputLayers = InputController.Instance.GetInputLayers(unitId);
		if (inputLayers == null)
		{
			return null;
		}
		Func<BP_InputBase_C, SInputCaches> <>9__2;
		InputLayerQueryResult<SInputCaches?> inputLayerQueryResult = InputLayerQueryHelper.FindLayerResult<SInputCaches?>(inputLayers, delegate(InputLayer layer)
		{
			BP_InputBase_C bpInputComp = layer.GetBpInputComp();
			if (bpInputComp == null)
			{
				return null;
			}
			ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> cacheConfigCache = InputLayerQueryHelper.GetCacheConfigCache();
			BP_InputBase_C bpInputComp2 = bpInputComp;
			EInputAction action2 = action;
			Func<BP_InputBase_C, SInputCaches> getter;
			if ((getter = <>9__2) == null)
			{
				getter = (<>9__2 = ((BP_InputBase_C inputComp) => inputComp.GetUnrealCacheConfig((int)action)));
			}
			return InputLayerQueryHelper.GetCachedConfig<SInputCaches>(cacheConfigCache, bpInputComp2, action2, getter);
		}, (SInputCaches? config) => config != null);
		if (inputLayerQueryResult == null)
		{
			return null;
		}
		return inputLayerQueryResult.Result;
	}

	// Token: 0x0601AB9C RID: 109468 RVA: 0x00733C6C File Offset: 0x00731E6C
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

	// Token: 0x0601AB9D RID: 109469 RVA: 0x00733CDC File Offset: 0x00731EDC
	private static T? GetCachedConfig<T>([Nullable(new byte[]
	{
		1,
		1,
		1,
		0
	})] ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<T>> cache, [Nullable(1)] BP_InputBase_C bpInputComp, EInputAction action, [Nullable(new byte[]
	{
		1,
		1,
		0
	})] Func<BP_InputBase_C, T> getter) where T : struct
	{
		InputLayerQueryHelper.ActionConfigCache<T> value = cache.GetValue(bpInputComp, (BP_InputBase_C _) => new InputLayerQueryHelper.ActionConfigCache<T>());
		if (!value.Configs.ContainsKey(action))
		{
			value.Configs[action] = getter(bpInputComp);
		}
		return new T?(value.Configs[action]);
	}

	// Token: 0x0601AB9E RID: 109470 RVA: 0x00733D44 File Offset: 0x00731F44
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

	// Token: 0x0601AB9F RID: 109471 RVA: 0x00733DBB File Offset: 0x00731FBB
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>> GetHoldConfigCache()
	{
		if (InputLayerQueryHelper.HoldConfigCache == null)
		{
			InputLayerQueryHelper.HoldConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>>();
		}
		return InputLayerQueryHelper.HoldConfigCache;
	}

	// Token: 0x0601ABA0 RID: 109472 RVA: 0x00733DD3 File Offset: 0x00731FD3
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> GetCacheConfigCache()
	{
		if (InputLayerQueryHelper.CacheConfigCache == null)
		{
			InputLayerQueryHelper.CacheConfigCache = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>>();
		}
		return InputLayerQueryHelper.CacheConfigCache;
	}

	// Token: 0x0601ABA1 RID: 109473 RVA: 0x00733DEB File Offset: 0x00731FEB
	[NullableContext(1)]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache> GetMoveAxisToButtonConfigCaches()
	{
		if (InputLayerQueryHelper.MoveAxisToButtonConfigCaches == null)
		{
			InputLayerQueryHelper.MoveAxisToButtonConfigCaches = new ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache>();
		}
		return InputLayerQueryHelper.MoveAxisToButtonConfigCaches;
	}

	// Token: 0x0400CE61 RID: 52833
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputHoldConfig>> HoldConfigCache;

	// Token: 0x0400CE62 RID: 52834
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.ActionConfigCache<SInputCaches>> CacheConfigCache;

	// Token: 0x0400CE63 RID: 52835
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static ConditionalWeakTable<BP_InputBase_C, InputLayerQueryHelper.MoveAxisToButtonConfigCache> MoveAxisToButtonConfigCaches;

	// Token: 0x02009676 RID: 38518
	private class ActionConfigCache<[Nullable(2)] T>
	{
		// Token: 0x040303F7 RID: 197623
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public readonly Dictionary<EInputAction, T> Configs = new Dictionary<EInputAction, T>();
	}

	// Token: 0x02009677 RID: 38519
	private class MoveAxisToButtonConfigCache
	{
		// Token: 0x040303F8 RID: 197624
		public bool HasValue;

		// Token: 0x040303F9 RID: 197625
		[Nullable(2)]
		public SInputActive Config;
	}
}
