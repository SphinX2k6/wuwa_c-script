using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C7 RID: 14535
public class __TsSceneUiTag_SubClassMissingExportProxy : __TsSceneUiTag_InheritProxy
{
	// Token: 0x0601EADB RID: 125659 RVA: 0x00897238 File Offset: 0x00895438
	[NullableContext(1)]
	protected __TsSceneUiTag_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneUiTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EADC RID: 125660 RVA: 0x0089726B File Offset: 0x0089546B
	protected __TsSceneUiTag_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EADD RID: 125661 RVA: 0x00897274 File Offset: 0x00895474
	protected unsafe override bool OnCanTick()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnCanTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsSceneUiTag.__OnCanTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsSceneUiTag.__OnCanTick_FunctionParams*)ptr + 15L / (long)sizeof(TsSceneUiTag.__OnCanTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}
}
