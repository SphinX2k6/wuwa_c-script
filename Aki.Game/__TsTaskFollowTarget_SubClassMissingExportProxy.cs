using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003683 RID: 13955
public class __TsTaskFollowTarget_SubClassMissingExportProxy : __TsTaskFollowTarget_InheritProxy
{
	// Token: 0x0601E2ED RID: 123629 RVA: 0x00883D4C File Offset: 0x00881F4C
	[NullableContext(1)]
	protected __TsTaskFollowTarget_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2EE RID: 123630 RVA: 0x00883D7F File Offset: 0x00881F7F
	protected __TsTaskFollowTarget_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E2EF RID: 123631 RVA: 0x00883D88 File Offset: 0x00881F88
	[NullableContext(2)]
	protected unsafe override void GetPath(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetPath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTaskFollowTarget.__GetPath_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTaskFollowTarget.__GetPath_FunctionParams*)ptr + 15L / (long)sizeof(TsTaskFollowTarget.__GetPath_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->ownerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->controlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
