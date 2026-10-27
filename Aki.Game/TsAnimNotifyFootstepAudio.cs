using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BC RID: 444
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C")]
public class TsAnimNotifyFootstepAudio : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0008EE3B File Offset: 0x0008D03B
	// (set) Token: 0x06001BDC RID: 7132 RVA: 0x0008EE4B File Offset: 0x0008D04B
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

	// Token: 0x06001BDD RID: 7133 RVA: 0x0008EE5C File Offset: 0x0008D05C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x0008EEFC File Offset: 0x0008D0FC
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

	// Token: 0x06001BDF RID: 7135 RVA: 0x0008EF8C File Offset: 0x0008D18C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x0008F007 File Offset: 0x0008D207
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "脚步音效";
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x0008F00E File Offset: 0x0008D20E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFootstepAudio._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C");
		}
		return TsAnimNotifyFootstepAudio._ClassPtr;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x0008F034 File Offset: 0x0008D234
	public TsAnimNotifyFootstepAudio() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootstepAudio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x0008F05C File Offset: 0x0008D25C
	[NullableContext(1)]
	public TsAnimNotifyFootstepAudio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootstepAudio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x0008F08F File Offset: 0x0008D28F
	protected TsAnimNotifyFootstepAudio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x0008F098 File Offset: 0x0008D298
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x0008F0CB File Offset: 0x0008D2CB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011B1 RID: 4529
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootstepAudio.TsAnimNotifyFootstepAudio_C";

	// Token: 0x040011B2 RID: 4530
	private static IntPtr _ClassPtr;

	// Token: 0x040011B3 RID: 4531
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011B4 RID: 4532
	private static int __PropertyOffset_Variant;
}
