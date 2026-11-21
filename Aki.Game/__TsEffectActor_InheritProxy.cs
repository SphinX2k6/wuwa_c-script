using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E13 RID: 11795
public class __TsEffectActor_InheritProxy : TsEffectActor
{
	// Token: 0x0601C70E RID: 116494 RVA: 0x008BA9D8 File Offset: 0x008B8BD8
	[NullableContext(1)]
	public __TsEffectActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C70F RID: 116495 RVA: 0x008BAA0B File Offset: 0x008B8C0B
	protected __TsEffectActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C710 RID: 116496 RVA: 0x008BAA14 File Offset: 0x008B8C14
	protected unsafe override void __CPPCALL_GetHandle_Implementation(TsEffectActor.__GetHandle_FunctionParams* __Params)
	{
		base.GetHandle_Implementation(ref __Params->handle);
	}

	// Token: 0x0601C711 RID: 116497 RVA: 0x008BAA22 File Offset: 0x008B8C22
	protected unsafe override void __CPPCALL_SetHandle_Implementation(TsEffectActor.__SetHandle_FunctionParams* __Params)
	{
		base.SetHandle_Implementation(__Params->handle);
	}

	// Token: 0x0601C712 RID: 116498 RVA: 0x008BAA30 File Offset: 0x008B8C30
	protected override void __CPPCALL_RemoveHandle_Implementation()
	{
		base.RemoveHandle_Implementation();
	}

	// Token: 0x0601C713 RID: 116499 RVA: 0x008BAA38 File Offset: 0x008B8C38
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
