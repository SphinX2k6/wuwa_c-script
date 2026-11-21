using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Audio;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000136 RID: 310
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateFoleyAudioEvent.TsAnimNotifyStateFoleyAudioEvent_C")]
public class TsAnimNotifyStateFoleyAudioEvent : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06001300 RID: 4864 RVA: 0x0006C9F4 File Offset: 0x0006ABF4
	// (set) Token: 0x06001301 RID: 4865 RVA: 0x0006CA04 File Offset: 0x0006AC04
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe E_FoleyVariant Variant
	{
		get
		{
			return (E_FoleyVariant)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_Variant));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_Variant) = (byte)value;
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06001302 RID: 4866 RVA: 0x0006CA15 File Offset: 0x0006AC15
	// (set) Token: 0x06001303 RID: 4867 RVA: 0x0006CA25 File Offset: 0x0006AC25
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FadeDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_FadeDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_FadeDuration) = value;
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06001304 RID: 4868 RVA: 0x0006CA36 File Offset: 0x0006AC36
	// (set) Token: 0x06001305 RID: 4869 RVA: 0x0006CA46 File Offset: 0x0006AC46
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAudioFadeCurve FadeCurve
	{
		get
		{
			return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_FadeCurve));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateFoleyAudioEvent.__PropertyOffset_FadeCurve) = (byte)value;
		}
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0006CA58 File Offset: 0x0006AC58
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateFoleyAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateFoleyAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x0006CB18 File Offset: 0x0006AD18
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!this.InitVariables)
		{
			this.InitVariables = true;
			this.HandleMap = new Dictionary<int, FoleyEventHandle>();
		}
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		BaseTagComponent baseTagComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["系统.活动.声骸对战.bvb镜头"]))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entityNoBlueprint2 = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		RoleAudioComponent roleAudioComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<RoleAudioComponent>() : null;
		if (characterActorComponent == null || roleAudioComponent == null)
		{
			return false;
		}
		roleAudioComponent.ChangeFoleyVariant(this.Variant);
		UAkComponent uakComponent = (roleAudioComponent != null) ? roleAudioComponent.GetAkComponent(null) : null;
		string foleyEvent = roleAudioComponent.GetFoleyEvent();
		if (uakComponent != null && foleyEvent != null)
		{
			int id = AudioSystem.Instance.PostEvent(foleyEvent, uakComponent, null);
			this.HandleMap[characterActorComponent.Entity.Id] = new FoleyEventHandle(id, foleyEvent);
		}
		return true;
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x0006CC20 File Offset: 0x0006AE20
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateFoleyAudioEvent) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateFoleyAudioEvent.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0006CCD8 File Offset: 0x0006AED8
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return false;
		}
		Dictionary<int, FoleyEventHandle> handleMap = this.HandleMap;
		FoleyEventHandle foleyEventHandle = (handleMap != null) ? handleMap.GetValueOrDefault(characterActorComponent.Entity.Id) : null;
		if (foleyEventHandle != null)
		{
			AudioSystem.Instance.ExecuteAction(foleyEventHandle.Id, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(this.FadeDuration),
				TransitionFadeCurve = new EAudioFadeCurve?(this.FadeCurve)
			}));
			this.HandleMap.Remove(characterActorComponent.Entity.Id);
		}
		return true;
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x0006CD83 File Offset: 0x0006AF83
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateFoleyAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateFoleyAudioEvent.TsAnimNotifyStateFoleyAudioEvent_C");
		}
		return TsAnimNotifyStateFoleyAudioEvent._ClassPtr;
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0006CDA8 File Offset: 0x0006AFA8
	public TsAnimNotifyStateFoleyAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateFoleyAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x0006CDD0 File Offset: 0x0006AFD0
	[NullableContext(1)]
	public TsAnimNotifyStateFoleyAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateFoleyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x0006CE03 File Offset: 0x0006B003
	protected TsAnimNotifyStateFoleyAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x0006CE0C File Offset: 0x0006B00C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0006CE48 File Offset: 0x0006B048
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000E09 RID: 3593
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x04000E0A RID: 3594
	private bool InitVariables;

	// Token: 0x04000E0B RID: 3595
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, FoleyEventHandle> HandleMap;

	// Token: 0x04000E0C RID: 3596
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateFoleyAudioEvent.TsAnimNotifyStateFoleyAudioEvent_C";

	// Token: 0x04000E0D RID: 3597
	private static IntPtr _ClassPtr;

	// Token: 0x04000E0E RID: 3598
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E0F RID: 3599
	private static int __PropertyOffset_Variant;

	// Token: 0x04000E10 RID: 3600
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x04000E11 RID: 3601
	private static int __PropertyOffset_FadeCurve;
}
