using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002894 RID: 10388
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C")]
public class TsAnimNotifyAddCharRendering : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B28 RID: 11048
	// (get) Token: 0x0601A52C RID: 107820 RVA: 0x00825C23 File Offset: 0x00823E23
	// (set) Token: 0x0601A52D RID: 107821 RVA: 0x00825C33 File Offset: 0x00823E33
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterRenderingType RenderType
	{
		get
		{
			return (ECharacterRenderingType)(*(base.NativePtr + (IntPtr)TsAnimNotifyAddCharRendering.__PropertyOffset_RenderType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAddCharRendering.__PropertyOffset_RenderType) = (byte)value;
		}
	}

	// Token: 0x0601A52E RID: 107822 RVA: 0x00825C44 File Offset: 0x00823E44
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAddCharRendering) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyAddCharRendering.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601A52F RID: 107823 RVA: 0x00825CFC File Offset: 0x00823EFC
	[NullableContext(1)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return false;
		}
		AKuroRecordCharacter akuroRecordCharacter = meshComp.GetOwner() as AKuroRecordCharacter;
		if (akuroRecordCharacter == null)
		{
			return false;
		}
		AActor aactor = akuroRecordCharacter;
		TSubclassOf<UActorComponent> @class = CharRenderingComponent.StaticClass();
		bool bManualAttachment = false;
		FTransformDouble ftransformDouble = akuroRecordCharacter.D_GetTransform();
		CharRenderingComponent charRenderingComponent = aactor.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, FNameUtil.GetDynamicFName("CharRenderingComponent") ?? FName.NAME_None) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return false;
		}
		charRenderingComponent.Init(this.RenderType);
		return true;
	}

	// Token: 0x0601A530 RID: 107824 RVA: 0x00825D74 File Offset: 0x00823F74
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAddCharRendering._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C");
		}
		return TsAnimNotifyAddCharRendering._ClassPtr;
	}

	// Token: 0x0601A531 RID: 107825 RVA: 0x00825D98 File Offset: 0x00823F98
	public TsAnimNotifyAddCharRendering() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddCharRendering.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601A532 RID: 107826 RVA: 0x00825DC0 File Offset: 0x00823FC0
	[NullableContext(1)]
	public TsAnimNotifyAddCharRendering(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddCharRendering.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601A533 RID: 107827 RVA: 0x00825DF3 File Offset: 0x00823FF3
	protected TsAnimNotifyAddCharRendering(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601A534 RID: 107828 RVA: 0x00825DFC File Offset: 0x00823FFC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E73B RID: 59195
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C";

	// Token: 0x0400E73C RID: 59196
	private static IntPtr _ClassPtr;

	// Token: 0x0400E73D RID: 59197
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E73E RID: 59198
	private static int __PropertyOffset_RenderType;
}
