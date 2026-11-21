using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B6 RID: 438
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C")]
public class TsAnimNotifyDisableUiMotorSoarWing : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001BF6 RID: 7158 RVA: 0x00093B64 File Offset: 0x00091D64
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

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00093BC4 File Offset: 0x00091DC4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "隐藏Ui摩托翱翔翼";
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00093BCB File Offset: 0x00091DCB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDisableUiMotorSoarWing._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C");
		}
		return TsAnimNotifyDisableUiMotorSoarWing._ClassPtr;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00093BF0 File Offset: 0x00091DF0
	public TsAnimNotifyDisableUiMotorSoarWing() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableUiMotorSoarWing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00093C18 File Offset: 0x00091E18
	[NullableContext(1)]
	public TsAnimNotifyDisableUiMotorSoarWing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableUiMotorSoarWing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00093C4B File Offset: 0x00091E4B
	protected TsAnimNotifyDisableUiMotorSoarWing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00093C54 File Offset: 0x00091E54
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x00093C87 File Offset: 0x00091E87
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x040011C1 RID: 4545
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDisableUiMotorSoarWing.TsAnimNotifyDisableUiMotorSoarWing_C";

	// Token: 0x040011C2 RID: 4546
	private static IntPtr _ClassPtr;

	// Token: 0x040011C3 RID: 4547
	private static IntPtr _ClassDefaultObjectPtr;
}
