using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200017D RID: 381
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C")]
public class TsAnimNotifyStateStopMontage : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001876 RID: 6262 RVA: 0x00085C10 File Offset: 0x00083E10
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateStopMontage) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateStopMontage.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00085CD0 File Offset: 0x00083ED0
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return false;
		}
		CharacterMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
		if (component != null && component.HasMoveInput)
		{
			CharacterAnimationComponent component2 = entity.GetComponent<CharacterAnimationComponent>();
			if (component2 != null)
			{
				component2.MainAnimInstance.Montage_Stop(0.1f, null);
			}
		}
		return true;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00085D36 File Offset: 0x00083F36
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateStopMontage._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C");
		}
		return TsAnimNotifyStateStopMontage._ClassPtr;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x00085D5C File Offset: 0x00083F5C
	public TsAnimNotifyStateStopMontage() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStopMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00085D84 File Offset: 0x00083F84
	[NullableContext(1)]
	public TsAnimNotifyStateStopMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStopMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00085DB7 File Offset: 0x00083FB7
	protected TsAnimNotifyStateStopMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x00085DC0 File Offset: 0x00083FC0
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0400104C RID: 4172
	private const float QUIT_BLEND_TIME = 0.1f;

	// Token: 0x0400104D RID: 4173
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C";

	// Token: 0x0400104E RID: 4174
	private static IntPtr _ClassPtr;

	// Token: 0x0400104F RID: 4175
	private static IntPtr _ClassDefaultObjectPtr;
}
