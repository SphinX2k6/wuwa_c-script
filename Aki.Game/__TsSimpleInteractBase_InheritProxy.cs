using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EBD RID: 11965
public class __TsSimpleInteractBase_InheritProxy : TsSimpleInteractBase
{
	// Token: 0x0601C8D7 RID: 116951 RVA: 0x008BD91C File Offset: 0x008BBB1C
	[NullableContext(1)]
	public __TsSimpleInteractBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8D8 RID: 116952 RVA: 0x008BD94F File Offset: 0x008BBB4F
	protected __TsSimpleInteractBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C8D9 RID: 116953 RVA: 0x008BD958 File Offset: 0x008BBB58
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C8DA RID: 116954 RVA: 0x008BD960 File Offset: 0x008BBB60
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C8DB RID: 116955 RVA: 0x008BD980 File Offset: 0x008BBB80
	protected override void __CPPCALL_EditorInit_Implementation()
	{
		base.EditorInit_Implementation();
	}

	// Token: 0x0601C8DC RID: 116956 RVA: 0x008BD988 File Offset: 0x008BBB88
	protected unsafe override void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C8DD RID: 116957 RVA: 0x008BD998 File Offset: 0x008BBB98
	protected unsafe override void __CPPCALL_GetBestTransform_Implementation(TsSimpleInteractBase.__GetBestTransform_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		__Params->__Result = base.GetBestTransform_Implementation(orCreateUObjectByNativePointer, __Params->moveOffset, __Params->halfHeight, __Params->radius);
	}

	// Token: 0x0601C8DE RID: 116958 RVA: 0x008BD9D0 File Offset: 0x008BBBD0
	protected override void __CPPCALL_Draw_Implementation()
	{
		base.Draw_Implementation();
	}
}
