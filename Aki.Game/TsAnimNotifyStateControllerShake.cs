using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.Gamepad;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000122 RID: 290
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateControllerShake.TsAnimNotifyStateControllerShake_C")]
public class TsAnimNotifyStateControllerShake : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x06001179 RID: 4473 RVA: 0x0006235F File Offset: 0x0006055F
	// (set) Token: 0x0600117A RID: 4474 RVA: 0x00062373 File Offset: 0x00060573
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroForceFeedbackEffect Effect
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateControllerShake.__PropertyOffset_Effect);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateControllerShake.__PropertyOffset_Effect, value);
		}
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600117B RID: 4475 RVA: 0x00062388 File Offset: 0x00060588
	// (set) Token: 0x0600117C RID: 4476 RVA: 0x0006239C File Offset: 0x0006059C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName Name
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_Name);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_Name) = value;
		}
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x0600117D RID: 4477 RVA: 0x000623B1 File Offset: 0x000605B1
	// (set) Token: 0x0600117E RID: 4478 RVA: 0x000623C1 File Offset: 0x000605C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsLooping
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsLooping) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsLooping) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x0600117F RID: 4479 RVA: 0x000623D2 File Offset: 0x000605D2
	// (set) Token: 0x06001180 RID: 4480 RVA: 0x000623E2 File Offset: 0x000605E2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsIgnoreTimeDilation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsIgnoreTimeDilation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsIgnoreTimeDilation) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x06001181 RID: 4481 RVA: 0x000623F3 File Offset: 0x000605F3
	// (set) Token: 0x06001182 RID: 4482 RVA: 0x00062403 File Offset: 0x00060603
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsPlayWhilePaused
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsPlayWhilePaused) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateControllerShake.__PropertyOffset_IsPlayWhilePaused) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00062414 File Offset: 0x00060614
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

	// Token: 0x06001184 RID: 4484 RVA: 0x000624BC File Offset: 0x000606BC
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return true;
		}
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.IsAutonomousProxy && Global.CharacterController != null)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById((owner as TsBaseCharacter).GetEntityIdNoBlueprint());
				if (entityById == null || !entityById.Valid)
				{
					return false;
				}
				if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
				{
					return false;
				}
				GamepadController.Instance.PlayKuroForceFeedback(this.Effect, new FName?(this.Name), this.IsLooping, this.IsIgnoreTimeDilation, this.IsPlayWhilePaused, "TsAnimNotifyStateControllerShake");
				if (this.ActiveSet == null)
				{
					this.ActiveSet = new HashSet<USkeletalMeshComponent>();
				}
				this.ActiveSet.Add(meshComp);
			}
		}
		return true;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00062598 File Offset: 0x00060798
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

	// Token: 0x06001186 RID: 4486 RVA: 0x00062637 File Offset: 0x00060837
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.ActiveSet.Remove(meshComp))
		{
			GamepadController.StopKuroForceFeedback(this.Effect, this.Name);
		}
		return true;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x0006265C File Offset: 0x0006085C
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

	// Token: 0x06001188 RID: 4488 RVA: 0x000626D7 File Offset: 0x000608D7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "手柄震动";
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x000626DE File Offset: 0x000608DE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateControllerShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateControllerShake.TsAnimNotifyStateControllerShake_C");
		}
		return TsAnimNotifyStateControllerShake._ClassPtr;
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00062704 File Offset: 0x00060904
	public TsAnimNotifyStateControllerShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateControllerShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x0006272C File Offset: 0x0006092C
	[NullableContext(1)]
	public TsAnimNotifyStateControllerShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateControllerShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x0006275F File Offset: 0x0006095F
	protected TsAnimNotifyStateControllerShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00062774 File Offset: 0x00060974
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x000627B0 File Offset: 0x000609B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x000627E3 File Offset: 0x000609E3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D13 RID: 3347
	[Nullable(1)]
	private HashSet<USkeletalMeshComponent> ActiveSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04000D14 RID: 3348
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateControllerShake.TsAnimNotifyStateControllerShake_C";

	// Token: 0x04000D15 RID: 3349
	private static IntPtr _ClassPtr;

	// Token: 0x04000D16 RID: 3350
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D17 RID: 3351
	private static int __PropertyOffset_Effect;

	// Token: 0x04000D18 RID: 3352
	private static int __PropertyOffset_Name;

	// Token: 0x04000D19 RID: 3353
	private static int __PropertyOffset_IsLooping;

	// Token: 0x04000D1A RID: 3354
	private static int __PropertyOffset_IsIgnoreTimeDilation;

	// Token: 0x04000D1B RID: 3355
	private static int __PropertyOffset_IsPlayWhilePaused;
}
