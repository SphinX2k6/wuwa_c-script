using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003942 RID: 14658
public class __TsSimpleInteractBase_InheritProxy : TsSimpleInteractBase
{
	// Token: 0x0601EC31 RID: 126001 RVA: 0x00899DFC File Offset: 0x00897FFC
	[NullableContext(1)]
	public __TsSimpleInteractBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC32 RID: 126002 RVA: 0x00899E2F File Offset: 0x0089802F
	protected __TsSimpleInteractBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC33 RID: 126003 RVA: 0x00899E38 File Offset: 0x00898038
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EC34 RID: 126004 RVA: 0x00899E40 File Offset: 0x00898040
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601EC35 RID: 126005 RVA: 0x00899E60 File Offset: 0x00898060
	protected override void __CPPCALL_EditorInit_Implementation()
	{
		base.EditorInit_Implementation();
	}

	// Token: 0x0601EC36 RID: 126006 RVA: 0x00899E68 File Offset: 0x00898068
	protected unsafe override void __CPPCALL_EditorTick_Implementation(AKuroEffectActor.__EditorTick_FunctionParams* __Params)
	{
		base.EditorTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601EC37 RID: 126007 RVA: 0x00899E78 File Offset: 0x00898078
	protected unsafe override void __CPPCALL_GetBestTransform_Implementation(TsSimpleInteractBase.__GetBestTransform_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		__Params->__Result = base.GetBestTransform_Implementation(orCreateUObjectByNativePointer, __Params->moveOffset, __Params->halfHeight, __Params->radius);
	}

	// Token: 0x0601EC38 RID: 126008 RVA: 0x00899EB0 File Offset: 0x008980B0
	protected override void __CPPCALL_Draw_Implementation()
	{
		base.Draw_Implementation();
	}
}
