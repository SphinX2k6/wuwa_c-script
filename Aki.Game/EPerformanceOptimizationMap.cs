using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x020027FF RID: 10239
public static class EPerformanceOptimizationMap
{
	// Token: 0x06019C5E RID: 105566 RVA: 0x007F0FCA File Offset: 0x007EF1CA
	// Note: this type is marked as 'beforefieldinit'.
	static EPerformanceOptimizationMap()
	{
		Dictionary<EPerformanceOptimizationType, Type> dictionary = new Dictionary<EPerformanceOptimizationType, Type>();
		dictionary[EPerformanceOptimizationType.PlaneMovementOptimization] = typeof(PlanarMoveOptimizationStrategy);
		dictionary[EPerformanceOptimizationType.DamageTextOptimization] = typeof(DamageOptimizationStrategy);
		EPerformanceOptimizationMap.Map = dictionary;
	}

	// Token: 0x0400E22D RID: 57901
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EPerformanceOptimizationType, Type> Map;
}
