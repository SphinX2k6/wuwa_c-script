using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200388F RID: 14479
public class __TsAxisHandle_SubClassMissingExportProxy : __TsAxisHandle_InheritProxy
{
	// Token: 0x0601E9E8 RID: 125416 RVA: 0x0089444C File Offset: 0x0089264C
	[NullableContext(1)]
	protected __TsAxisHandle_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAxisHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9E9 RID: 125417 RVA: 0x0089447F File Offset: 0x0089267F
	protected __TsAxisHandle_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9EA RID: 125418 RVA: 0x00894488 File Offset: 0x00892688
	protected unsafe override void OnInputAxis(float value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnInputAxis"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAxisHandle.__OnInputAxis_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAxisHandle.__OnInputAxis_FunctionParams*)ptr + 15L / (long)sizeof(TsAxisHandle.__OnInputAxis_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->value = value;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
