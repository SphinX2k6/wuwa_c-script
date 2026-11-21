using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C0 RID: 448
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C")]
public class TsAnimNotifyFootstepAudio : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06001C78 RID: 7288 RVA: 0x000958A3 File Offset: 0x00093AA3
	// (set) Token: 0x06001C79 RID: 7289 RVA: 0x000958B3 File Offset: 0x00093AB3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe E_FootstepVariant Variant
	{
		get
		{
			return (E_FootstepVariant)(*(base.NativePtr + (IntPtr)TsAnimNotifyFootstepAudio.__PropertyOffset_Variant));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyFootstepAudio.__PropertyOffset_Variant) = (byte)value;
		}
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x000958C4 File Offset: 0x00093AC4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFootstepAudio) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyFootstepAudio.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C7B RID: 7291 RVA: 0x0009597C File Offset: 0x00093B7C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
		BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.声骸对战.bvb镜头"]))
		{
			return false;
		}
		Entity entityNoBlueprint2 = tsBaseCharacter.GetEntityNoBlueprint();
		RoleAudioComponent roleAudioComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<RoleAudioComponent>() : null;
		Entity entityNoBlueprint3 = tsBaseCharacter.GetEntityNoBlueprint();
		CharacterFootEffectComponent characterFootEffectComponent = (entityNoBlueprint3 != null) ? entityNoBlueprint3.GetComponent<CharacterFootEffectComponent>() : null;
		if (roleAudioComponent == null || characterFootEffectComponent == null)
		{
			return false;
		}
		roleAudioComponent.ChangeFootstepVariant(this.Variant);
		characterFootEffectComponent.PostFootstepVoice();
		return true;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x00095A0C File Offset: 0x00093C0C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFootstepAudio) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyFootstepAudio.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C7D RID: 7293 RVA: 0x00095A9C File Offset: 0x00093C9C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "脚步音效";
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x00095AA3 File Offset: 0x00093CA3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFootstepAudio._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C");
		}
		return TsAnimNotifyFootstepAudio._ClassPtr;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x00095AC8 File Offset: 0x00093CC8
	public TsAnimNotifyFootstepAudio() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootstepAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x00095AF0 File Offset: 0x00093CF0
	[NullableContext(1)]
	public TsAnimNotifyFootstepAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootstepAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x00095B23 File Offset: 0x00093D23
	protected TsAnimNotifyFootstepAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x00095B2C File Offset: 0x00093D2C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x00095B5F File Offset: 0x00093D5F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011F4 RID: 4596
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C";

	// Token: 0x040011F5 RID: 4597
	private static IntPtr _ClassPtr;

	// Token: 0x040011F6 RID: 4598
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011F7 RID: 4599
	private static int __PropertyOffset_Variant;
}
