using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D1 RID: 14545
public class __TsUiBlur_SubClassMissingExportProxy : __TsUiBlur_InheritProxy
{
	// Token: 0x0601EAF3 RID: 125683 RVA: 0x00897530 File Offset: 0x00895730
	[NullableContext(1)]
	protected __TsUiBlur_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiBlur.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAF4 RID: 125684 RVA: 0x00897563 File Offset: 0x00895763
	protected __TsUiBlur_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAF5 RID: 125685 RVA: 0x0089756C File Offset: 0x0089576C
	public unsafe override void SetEnableUiBlur(bool value)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEnableUiBlur"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsUiBlur.__SetEnableUiBlur_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsUiBlur.__SetEnableUiBlur_FunctionParams*)ptr + 15L / (long)sizeof(TsUiBlur.__SetEnableUiBlur_FunctionParams) & -16L);
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
