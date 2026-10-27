using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003812 RID: 14354
public class __TsAnimNotifyDisableAllRoleWithoutControl_InheritProxy : TsAnimNotifyDisableAllRoleWithoutControl
{
	// Token: 0x0601E866 RID: 125030 RVA: 0x008911D0 File Offset: 0x0088F3D0
	[NullableContext(1)]
	public __TsAnimNotifyDisableAllRoleWithoutControl_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableAllRoleWithoutControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E867 RID: 125031 RVA: 0x00891203 File Offset: 0x0088F403
	protected __TsAnimNotifyDisableAllRoleWithoutControl_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E868 RID: 125032 RVA: 0x0089120C File Offset: 0x0088F40C
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E869 RID: 125033 RVA: 0x0089123F File Offset: 0x0088F43F
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
