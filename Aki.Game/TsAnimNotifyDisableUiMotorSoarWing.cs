using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B2 RID: 434
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C")]
public class TsAnimNotifyDisableUiMotorSoarWing : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001B59 RID: 7001 RVA: 0x0008D25C File Offset: 0x0008B45C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsSkeletalObserver))
		{
			return false;
		}
		UiDecorationLoadComponent uiDecorationLoadComponent = (owner as TsSkeletalObserver).Model.CheckGetComponent<UiDecorationLoadComponent>();
		object obj;
		if (uiDecorationLoadComponent == null)
		{
			obj = null;
		}
		else
		{
			UiModelActorComponent attachActorComponent = uiDecorationLoadComponent.GetAttachActorComponent();
			obj = ((attachActorComponent != null) ? attachActorComponent.Owner : null);
		}
		object obj2 = obj;
		UiMotorSoarWingComponent uiMotorSoarWingComponent = (obj2 != null) ? obj2.CheckGetComponent<UiMotorSoarWingComponent>() : null;
		if (uiMotorSoarWingComponent == null)
		{
			return false;
		}
		uiMotorSoarWingComponent.SetActive(false);
		return true;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0008D2BC File Offset: 0x0008B4BC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "隐藏Ui摩托翱翔翼";
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x0008D2C3 File Offset: 0x0008B4C3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableUiMotorSoarWing._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C");
		}
		return TsAnimNotifyDisableUiMotorSoarWing._ClassPtr;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x0008D2E8 File Offset: 0x0008B4E8
	public TsAnimNotifyDisableUiMotorSoarWing() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableUiMotorSoarWing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x0008D310 File Offset: 0x0008B510
	[NullableContext(1)]
	public TsAnimNotifyDisableUiMotorSoarWing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableUiMotorSoarWing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x0008D343 File Offset: 0x0008B543
	protected TsAnimNotifyDisableUiMotorSoarWing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0008D34C File Offset: 0x0008B54C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x0008D37F File Offset: 0x0008B57F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x0400117E RID: 4478
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C";

	// Token: 0x0400117F RID: 4479
	private static IntPtr _ClassPtr;

	// Token: 0x04001180 RID: 4480
	private static IntPtr _ClassDefaultObjectPtr;
}
