using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E29 RID: 11817
public class __TsParkourCheckPoint_InheritProxy : TsParkourCheckPoint
{
	// Token: 0x0601C746 RID: 116550 RVA: 0x008BB068 File Offset: 0x008B9268
	[NullableContext(1)]
	public __TsParkourCheckPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C747 RID: 116551 RVA: 0x008BB09B File Offset: 0x008B929B
	protected __TsParkourCheckPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C748 RID: 116552 RVA: 0x008BB0A4 File Offset: 0x008B92A4
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C749 RID: 116553 RVA: 0x008BB0AC File Offset: 0x008B92AC
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C74A RID: 116554 RVA: 0x008BB0CC File Offset: 0x008B92CC
	protected unsafe override void __CPPCALL_SetDetectSphere_Implementation(TsParkourCheckPoint.__SetDetectSphere_FunctionParams* __Params)
	{
		base.SetDetectSphere_Implementation(__Params->inRadius);
	}

	// Token: 0x0601C74B RID: 116555 RVA: 0x008BB0DC File Offset: 0x008B92DC
	protected unsafe override void __CPPCALL_GenerateFx_Implementation(TsParkourCheckPoint.__GenerateFx_FunctionParams* __Params)
	{
		UEffectModelBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(__Params->inModelBase);
		base.GenerateFx_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C74C RID: 116556 RVA: 0x008BB0FC File Offset: 0x008B92FC
	protected unsafe override void __CPPCALL_GenerateFxByPath_Implementation(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* __Params)
	{
		string effectPath = FString.ToString((void*)(&__Params->effectPath));
		base.GenerateFxByPath_Implementation(effectPath);
	}
}
