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
	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x0600117F RID: 4479 RVA: 0x000639A7 File Offset: 0x00061BA7
	// (set) Token: 0x06001180 RID: 4480 RVA: 0x000639BB File Offset: 0x00061BBB
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

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x06001181 RID: 4481 RVA: 0x000639D0 File Offset: 0x00061BD0
	// (set) Token: 0x06001182 RID: 4482 RVA: 0x000639E4 File Offset: 0x00061BE4
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

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x06001183 RID: 4483 RVA: 0x000639F9 File Offset: 0x00061BF9
	// (set) Token: 0x06001184 RID: 4484 RVA: 0x00063A09 File Offset: 0x00061C09
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

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x06001185 RID: 4485 RVA: 0x00063A1A File Offset: 0x00061C1A
	// (set) Token: 0x06001186 RID: 4486 RVA: 0x00063A2A File Offset: 0x00061C2A
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

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x06001187 RID: 4487 RVA: 0x00063A3B File Offset: 0x00061C3B
	// (set) Token: 0x06001188 RID: 4488 RVA: 0x00063A4B File Offset: 0x00061C4B
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

	// Token: 0x06001189 RID: 4489 RVA: 0x00063A5C File Offset: 0x00061C5C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateControllerShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateControllerShake.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600118A RID: 4490 RVA: 0x00063B1C File Offset: 0x00061D1C
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

	// Token: 0x0600118B RID: 4491 RVA: 0x00063BF8 File Offset: 0x00061DF8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateControllerShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateControllerShake.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600118C RID: 4492 RVA: 0x00063CAE File Offset: 0x00061EAE
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.ActiveSet.Remove(meshComp))
		{
			GamepadController.StopKuroForceFeedback(this.Effect, this.Name);
		}
		return true;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00063CD0 File Offset: 0x00061ED0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateControllerShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateControllerShake.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00063D60 File Offset: 0x00061F60
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "手柄震动";
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00063D67 File Offset: 0x00061F67
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateControllerShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateControllerShake.TsAnimNotifyStateControllerShake_C");
		}
		return TsAnimNotifyStateControllerShake._ClassPtr;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00063D8C File Offset: 0x00061F8C
	public TsAnimNotifyStateControllerShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateControllerShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00063DB4 File Offset: 0x00061FB4
	[NullableContext(1)]
	public TsAnimNotifyStateControllerShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateControllerShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00063DE7 File Offset: 0x00061FE7
	protected TsAnimNotifyStateControllerShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00063DFC File Offset: 0x00061FFC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00063E38 File Offset: 0x00062038
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00063E6B File Offset: 0x0006206B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D1B RID: 3355
	[Nullable(1)]
	private HashSet<USkeletalMeshComponent> ActiveSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04000D1C RID: 3356
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateControllerShake.TsAnimNotifyStateControllerShake_C";

	// Token: 0x04000D1D RID: 3357
	private static IntPtr _ClassPtr;

	// Token: 0x04000D1E RID: 3358
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D1F RID: 3359
	private static int __PropertyOffset_Effect;

	// Token: 0x04000D20 RID: 3360
	private static int __PropertyOffset_Name;

	// Token: 0x04000D21 RID: 3361
	private static int __PropertyOffset_IsLooping;

	// Token: 0x04000D22 RID: 3362
	private static int __PropertyOffset_IsIgnoreTimeDilation;

	// Token: 0x04000D23 RID: 3363
	private static int __PropertyOffset_IsPlayWhilePaused;
}
