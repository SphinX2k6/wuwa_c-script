using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388D RID: 14477
[NullableContext(1)]
[Nullable(0)]
public class __TsActionHandle_SubClassMissingExportProxy : __TsActionHandle_InheritProxy
{
	// Token: 0x0601E9E1 RID: 125409 RVA: 0x008942A4 File Offset: 0x008924A4
	protected __TsActionHandle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsActionHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9E2 RID: 125410 RVA: 0x008942D7 File Offset: 0x008924D7
	protected __TsActionHandle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9E3 RID: 125411 RVA: 0x008942E0 File Offset: 0x008924E0
	protected unsafe override void OnPressAction(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnPressAction"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsActionHandle.__OnPressAction_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsActionHandle.__OnPressAction_FunctionParams*)ptr + 15L / (long)sizeof(TsActionHandle.__OnPressAction_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E9E4 RID: 125412 RVA: 0x00894370 File Offset: 0x00892570
	protected unsafe override void OnReleaseAction(FKey key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnReleaseAction"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsActionHandle.__OnReleaseAction_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsActionHandle.__OnReleaseAction_FunctionParams*)ptr + 15L / (long)sizeof(TsActionHandle.__OnReleaseAction_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr2->key, (key != null) ? key.NativePtr : ((IntPtr)0), 1, false);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
