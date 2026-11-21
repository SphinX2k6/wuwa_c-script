using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickHack;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C9 RID: 457
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C")]
public class TsAnimNotifyOpenQuickHack : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A9 RID: 1193
	// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00097507 File Offset: 0x00095707
	// (set) Token: 0x06001CEF RID: 7407 RVA: 0x00097517 File Offset: 0x00095717
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DeviceId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_DeviceId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_DeviceId) = value;
		}
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00097528 File Offset: 0x00095728
	// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00097538 File Offset: 0x00095738
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CloseWhenInteractFinish
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_CloseWhenInteractFinish) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_CloseWhenInteractFinish) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00097549 File Offset: 0x00095749
	// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0009755D File Offset: 0x0009575D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag InteractFinishGameplayEventTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_InteractFinishGameplayEventTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyOpenQuickHack.__PropertyOffset_InteractFinishGameplayEventTag) = value;
		}
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x00097574 File Offset: 0x00095774
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyOpenQuickHack) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyOpenQuickHack.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x0009762C File Offset: 0x0009582C
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		int deviceId = this.DeviceId;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.IsAutonomousProxy && deviceId > 0)
			{
				QuickHackController.Instance.OpenQuickHack(deviceId, tsBaseCharacter.GetEntityIdNoBlueprint(), this.CloseWhenInteractFinish, new FGameplayTag?(this.InteractFinishGameplayEventTag), null);
			}
		}
		return true;
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x0009768C File Offset: 0x0009588C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyOpenQuickHack) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyOpenQuickHack.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x0009771C File Offset: 0x0009591C
	protected override string GetNotifyName_Implementation()
	{
		return "开启快速破解";
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x00097723 File Offset: 0x00095923
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyOpenQuickHack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C");
		}
		return TsAnimNotifyOpenQuickHack._ClassPtr;
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x00097748 File Offset: 0x00095948
	public TsAnimNotifyOpenQuickHack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyOpenQuickHack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x00097770 File Offset: 0x00095970
	public TsAnimNotifyOpenQuickHack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyOpenQuickHack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x000977A3 File Offset: 0x000959A3
	protected TsAnimNotifyOpenQuickHack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x000977AC File Offset: 0x000959AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x000977DF File Offset: 0x000959DF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400121F RID: 4639
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyOpenQuickHack.TsAnimNotifyOpenQuickHack_C";

	// Token: 0x04001220 RID: 4640
	private static IntPtr _ClassPtr;

	// Token: 0x04001221 RID: 4641
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001222 RID: 4642
	private static int __PropertyOffset_DeviceId;

	// Token: 0x04001223 RID: 4643
	private static int __PropertyOffset_CloseWhenInteractFinish;

	// Token: 0x04001224 RID: 4644
	private static int __PropertyOffset_InteractFinishGameplayEventTag;
}
