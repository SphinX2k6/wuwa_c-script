using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000179 RID: 377
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C")]
public class TsAnimNotifyStateStopMontage : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060017D9 RID: 6105 RVA: 0x0007FD88 File Offset: 0x0007DF88
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x0007FE30 File Offset: 0x0007E030
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

	// Token: 0x060017DB RID: 6107 RVA: 0x0007FE96 File Offset: 0x0007E096
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateStopMontage._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C");
		}
		return TsAnimNotifyStateStopMontage._ClassPtr;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x0007FEBC File Offset: 0x0007E0BC
	public TsAnimNotifyStateStopMontage() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStopMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x0007FEE4 File Offset: 0x0007E0E4
	[NullableContext(1)]
	public TsAnimNotifyStateStopMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStopMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x0007FF17 File Offset: 0x0007E117
	protected TsAnimNotifyStateStopMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x0007FF20 File Offset: 0x0007E120
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x04001009 RID: 4105
	private const float QUIT_BLEND_TIME = 0.1f;

	// Token: 0x0400100A RID: 4106
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStopMontage.TsAnimNotifyStateStopMontage_C";

	// Token: 0x0400100B RID: 4107
	private static IntPtr _ClassPtr;

	// Token: 0x0400100C RID: 4108
	private static IntPtr _ClassDefaultObjectPtr;
}
