using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000154 RID: 340
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateReplaceHitEffect.TsAnimNotifyStateReplaceHitEffect_C")]
public class TsAnimNotifyStateReplaceHitEffect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000375 RID: 885
	// (get) Token: 0x0600152C RID: 5420 RVA: 0x00074F83 File Offset: 0x00073183
	// (set) Token: 0x0600152D RID: 5421 RVA: 0x00074F97 File Offset: 0x00073197
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe BP_ReplaceHitEffect_C Setting
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<BP_ReplaceHitEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateReplaceHitEffect.__PropertyOffset_Setting);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateReplaceHitEffect.__PropertyOffset_Setting, value);
		}
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x00074FAC File Offset: 0x000731AC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00075054 File Offset: 0x00073254
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		if (this.Setting == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "替换受击效果的ANS缺少配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", owner);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterHitComponent component = entity.GetComponent<CharacterHitComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		component.ReplaceHitEffect(this.Setting);
		return true;
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000750F8 File Offset: 0x000732F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x06001531 RID: 5425 RVA: 0x00075198 File Offset: 0x00073398
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (aactor as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterHitComponent component = entity.GetComponent<CharacterHitComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		component.RemoveHitEffectReplaced();
		return true;
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x00075208 File Offset: 0x00073408
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001533 RID: 5427 RVA: 0x00075283 File Offset: 0x00073483
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "替换受击效果";
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x0007528A File Offset: 0x0007348A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateReplaceHitEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateReplaceHitEffect.TsAnimNotifyStateReplaceHitEffect_C");
		}
		return TsAnimNotifyStateReplaceHitEffect._ClassPtr;
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x000752B0 File Offset: 0x000734B0
	public TsAnimNotifyStateReplaceHitEffect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateReplaceHitEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x000752D8 File Offset: 0x000734D8
	[NullableContext(1)]
	public TsAnimNotifyStateReplaceHitEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateReplaceHitEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0007530B File Offset: 0x0007350B
	protected TsAnimNotifyStateReplaceHitEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00075314 File Offset: 0x00073514
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00075350 File Offset: 0x00073550
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00075383 File Offset: 0x00073583
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F04 RID: 3844
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateReplaceHitEffect.TsAnimNotifyStateReplaceHitEffect_C";

	// Token: 0x04000F05 RID: 3845
	private static IntPtr _ClassPtr;

	// Token: 0x04000F06 RID: 3846
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F07 RID: 3847
	private static int __PropertyOffset_Setting;
}
