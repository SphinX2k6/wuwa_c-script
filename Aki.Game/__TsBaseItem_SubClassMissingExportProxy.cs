using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200393F RID: 14655
[NullableContext(1)]
[Nullable(0)]
public class __TsBaseItem_SubClassMissingExportProxy : __TsBaseItem_InheritProxy
{
	// Token: 0x0601EC27 RID: 125991 RVA: 0x00899C94 File Offset: 0x00897E94
	protected __TsBaseItem_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsBaseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC28 RID: 125992 RVA: 0x00899CC7 File Offset: 0x00897EC7
	protected __TsBaseItem_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC29 RID: 125993 RVA: 0x00899CD0 File Offset: 0x00897ED0
	public unsafe override string GetTagDebugStrings()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetTagDebugStrings"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsBaseItem.__GetTagDebugStrings_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsBaseItem.__GetTagDebugStrings_FunctionParams*)ptr + 15L / (long)sizeof(TsBaseItem.__GetTagDebugStrings_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}
}
