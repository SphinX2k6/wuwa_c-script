using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038D7 RID: 14551
public class __TsUiSceneRoleActor_SubClassMissingExportProxy : __TsUiSceneRoleActor_InheritProxy
{
	// Token: 0x0601EB07 RID: 125703 RVA: 0x00897768 File Offset: 0x00895968
	[NullableContext(1)]
	protected __TsUiSceneRoleActor_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiSceneRoleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB08 RID: 125704 RVA: 0x0089779B File Offset: 0x0089599B
	protected __TsUiSceneRoleActor_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB09 RID: 125705 RVA: 0x008977A4 File Offset: 0x008959A4
	public unsafe override bool IsShowUiWepaonEffect()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsShowUiWepaonEffect"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams*)ptr + 15L / (long)sizeof(TsUiSceneRoleActor.__IsShowUiWepaonEffect_FunctionParams) & -16L);
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
