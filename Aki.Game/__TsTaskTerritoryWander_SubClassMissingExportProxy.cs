using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036CF RID: 14031
public class __TsTaskTerritoryWander_SubClassMissingExportProxy : __TsTaskTerritoryWander_InheritProxy
{
	// Token: 0x0601E3BB RID: 123835 RVA: 0x0088597C File Offset: 0x00883B7C
	[NullableContext(1)]
	protected __TsTaskTerritoryWander_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3BC RID: 123836 RVA: 0x008859AF File Offset: 0x00883BAF
	protected __TsTaskTerritoryWander_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E3BD RID: 123837 RVA: 0x008859B8 File Offset: 0x00883BB8
	protected unsafe override void FindWanderLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindWanderLocation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E3BE RID: 123838 RVA: 0x00885A28 File Offset: 0x00883C28
	protected unsafe override void FindWanderPath()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindWanderPath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E3BF RID: 123839 RVA: 0x00885A98 File Offset: 0x00883C98
	protected unsafe override void DebugDraw()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DebugDraw"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
