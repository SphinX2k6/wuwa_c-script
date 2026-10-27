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
	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060012FA RID: 4858 RVA: 0x0006AFE8 File Offset: 0x000691E8
	// (set) Token: 0x060012FB RID: 4859 RVA: 0x0006AFF8 File Offset: 0x000691F8
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

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060012FC RID: 4860 RVA: 0x0006B009 File Offset: 0x00069209
	// (set) Token: 0x060012FD RID: 4861 RVA: 0x0006B019 File Offset: 0x00069219
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

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060012FE RID: 4862 RVA: 0x0006B02A File Offset: 0x0006922A
	// (set) Token: 0x060012FF RID: 4863 RVA: 0x0006B03A File Offset: 0x0006923A
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

	// Token: 0x06001300 RID: 4864 RVA: 0x0006B04C File Offset: 0x0006924C
	[NullableContext(2)]
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

	// Token: 0x06001301 RID: 4865 RVA: 0x0006B0F4 File Offset: 0x000692F4
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

	// Token: 0x06001302 RID: 4866 RVA: 0x0006B1FC File Offset: 0x000693FC
	[NullableContext(2)]
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

	// Token: 0x06001303 RID: 4867 RVA: 0x0006B29C File Offset: 0x0006949C
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

	// Token: 0x06001304 RID: 4868 RVA: 0x0006B347 File Offset: 0x00069547
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateFoleyAudioEvent._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateFoleyAudioEvent.TsAnimNotifyStateFoleyAudioEvent_C");
		}
		return TsAnimNotifyStateFoleyAudioEvent._ClassPtr;
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x0006B36C File Offset: 0x0006956C
	public TsAnimNotifyStateFoleyAudioEvent() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateFoleyAudioEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0006B394 File Offset: 0x00069594
	[NullableContext(1)]
	public TsAnimNotifyStateFoleyAudioEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateFoleyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x0006B3C7 File Offset: 0x000695C7
	protected TsAnimNotifyStateFoleyAudioEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x0006B3D0 File Offset: 0x000695D0
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0006B40C File Offset: 0x0006960C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000E01 RID: 3585
	private const int DEFAULT_FADE_DURATION = 500;

	// Token: 0x04000E02 RID: 3586
	private bool InitVariables;

	// Token: 0x04000E03 RID: 3587
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, FoleyEventHandle> HandleMap;

	// Token: 0x04000E04 RID: 3588
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateFoleyAudioEvent.TsAnimNotifyStateFoleyAudioEvent_C";

	// Token: 0x04000E05 RID: 3589
	private static IntPtr _ClassPtr;

	// Token: 0x04000E06 RID: 3590
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E07 RID: 3591
	private static int __PropertyOffset_Variant;

	// Token: 0x04000E08 RID: 3592
	private static int __PropertyOffset_FadeDuration;

	// Token: 0x04000E09 RID: 3593
	private static int __PropertyOffset_FadeCurve;
}
