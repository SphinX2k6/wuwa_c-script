using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x0200328E RID: 12942
public static class EPerformanceOptimizationMap
{
	// Token: 0x0601C04A RID: 114762 RVA: 0x007C9D6C File Offset: 0x007C7F6C
	// Note: this type is marked as 'beforefieldinit'.
	static EPerformanceOptimizationMap()
	{
		Dictionary<EPerformanceOptimizationType, Type> dictionary = new Dictionary<EPerformanceOptimizationType, Type>();
		dictionary[EPerformanceOptimizationType.PlaneMovementOptimization] = typeof(PlanarMoveOptimizationStrategy);
		dictionary[EPerformanceOptimizationType.DamageTextOptimization] = typeof(DamageOptimizationStrategy);
		EPerformanceOptimizationMap.Map = dictionary;
	}

	// Token: 0x0400DD86 RID: 56710
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EPerformanceOptimizationType, Type> Map;
}
