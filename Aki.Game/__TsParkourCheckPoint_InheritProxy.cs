using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B0 RID: 14512
public class __TsParkourCheckPoint_InheritProxy : TsParkourCheckPoint
{
	// Token: 0x0601EA72 RID: 125554 RVA: 0x00895E94 File Offset: 0x00894094
	[NullableContext(1)]
	public __TsParkourCheckPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA73 RID: 125555 RVA: 0x00895EC7 File Offset: 0x008940C7
	protected __TsParkourCheckPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA74 RID: 125556 RVA: 0x00895ED0 File Offset: 0x008940D0
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EA75 RID: 125557 RVA: 0x00895ED8 File Offset: 0x008940D8
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601EA76 RID: 125558 RVA: 0x00895EF8 File Offset: 0x008940F8
	protected unsafe override void __CPPCALL_SetDetectSphere_Implementation(TsParkourCheckPoint.__SetDetectSphere_FunctionParams* __Params)
	{
		base.SetDetectSphere_Implementation(__Params->inRadius);
	}

	// Token: 0x0601EA77 RID: 125559 RVA: 0x00895F08 File Offset: 0x00894108
	protected unsafe override void __CPPCALL_GenerateFx_Implementation(TsParkourCheckPoint.__GenerateFx_FunctionParams* __Params)
	{
		UEffectModelBase orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(__Params->inModelBase);
		base.GenerateFx_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA78 RID: 125560 RVA: 0x00895F28 File Offset: 0x00894128
	protected unsafe override void __CPPCALL_GenerateFxByPath_Implementation(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* __Params)
	{
		string effectPath = FString.ToString((void*)(&__Params->effectPath));
		base.GenerateFxByPath_Implementation(effectPath);
	}
}
