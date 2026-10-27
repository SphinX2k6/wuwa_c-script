using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200389A RID: 14490
public class __TsEffectActor_InheritProxy : TsEffectActor
{
	// Token: 0x0601EA30 RID: 125488 RVA: 0x00895300 File Offset: 0x00893500
	[NullableContext(1)]
	public __TsEffectActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA31 RID: 125489 RVA: 0x00895333 File Offset: 0x00893533
	protected __TsEffectActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA32 RID: 125490 RVA: 0x0089533C File Offset: 0x0089353C
	protected unsafe override void __CPPCALL_GetHandle_Implementation(TsEffectActor.__GetHandle_FunctionParams* __Params)
	{
		base.GetHandle_Implementation(ref __Params->handle);
	}

	// Token: 0x0601EA33 RID: 125491 RVA: 0x0089534A File Offset: 0x0089354A
	protected unsafe override void __CPPCALL_SetHandle_Implementation(TsEffectActor.__SetHandle_FunctionParams* __Params)
	{
		base.SetHandle_Implementation(__Params->handle);
	}

	// Token: 0x0601EA34 RID: 125492 RVA: 0x00895358 File Offset: 0x00893558
	protected override void __CPPCALL_RemoveHandle_Implementation()
	{
		base.RemoveHandle_Implementation();
	}

	// Token: 0x0601EA35 RID: 125493 RVA: 0x00895360 File Offset: 0x00893560
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
