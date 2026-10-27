using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003516 RID: 13590
[NullableContext(1)]
[Nullable(0)]
public static class WorldDefine
{
	// Token: 0x0400E9D3 RID: 59859
	[StaticVariableRuleIgnore]
	public static readonly string[] dataLayerRuntimeHLOD = new string[]
	{
		"DataLayerRuntime_GenerateHLOD",
		"DataLayerRuntime_GenerateHLOD_Middle",
		"DataLayerRuntime_GenerateHLOD_Small"
	};

	// Token: 0x0400E9D4 RID: 59860
	[StaticVariableRuleIgnore]
	public static readonly FName voxelGridName = FNameUtil.GetDynamicFName("Grid_VoxelPartition").Value;

	// Token: 0x0400E9D5 RID: 59861
	[StaticVariableRuleIgnore]
	public static readonly FName[] lowMemoryDeviceExcludeGridNames = new FName[]
	{
		FNameUtil.GetDynamicFName("Grid_PVS").Value,
		FNameUtil.GetDynamicFName("Grid_GPUNPC").Value
	};

	// Token: 0x0400E9D6 RID: 59862
	[StaticVariableRuleIgnore]
	public static readonly FName[] firstHLODGridNames = new FName[]
	{
		FNameUtil.GetDynamicFName("HLOD0_200m_300m").Value,
		FNameUtil.GetDynamicFName("HLOD0_300m_500m").Value,
		FNameUtil.GetDynamicFName("HLOD0_500m_1000m").Value,
		FNameUtil.GetDynamicFName("HLOD0_500m_1500m").Value
	};

	// Token: 0x0400E9D7 RID: 59863
	[StaticVariableRuleIgnore]
	public static readonly FName[] secondHLODGridNames = new FName[]
	{
		FNameUtil.GetDynamicFName("HLOD1_400m_800m").Value,
		FNameUtil.GetDynamicFName("HLOD1_600m_1200m").Value,
		FNameUtil.GetDynamicFName("HLOD1_800m_2500m").Value,
		FNameUtil.GetDynamicFName("HLOD1_800m_4000m").Value
	};

	// Token: 0x0400E9D8 RID: 59864
	[StaticVariableRuleIgnore]
	public static readonly FName[] allBaseDataLayers = new FName[]
	{
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25FC01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25FC02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25FD01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25FD02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25FD03").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25NYC01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25NYC02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25PYC01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25PYC02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25ZT03").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25ZT02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_25ZT01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_26SLZ01").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_26SLZ02").Value,
		FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_26CL04").Value
	};

	// Token: 0x0400E9D9 RID: 59865
	[StaticVariableRuleIgnore]
	public static FName SpecificVolumeDatalayer1 = FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_26SLZ01").Value;

	// Token: 0x0400E9DA RID: 59866
	[StaticVariableRuleIgnore]
	public static FName SpecificVolumeDatalayer2 = FNameUtil.GetDynamicFName("DataLayerRuntime_DLTask_26SLZ02").Value;
}
