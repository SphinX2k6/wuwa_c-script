using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000120 RID: 288
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateClearInputCache.TsAnimNotifyStateClearInputCache_C")]
public class TsAnimNotifyStateClearInputCache : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x06001154 RID: 4436 RVA: 0x000630A7 File Offset: 0x000612A7
	// (set) Token: 0x06001155 RID: 4437 RVA: 0x000630B7 File Offset: 0x000612B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EInputAction InputAction
	{
		get
		{
			return (EInputAction)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateClearInputCache.__PropertyOffset_InputAction));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateClearInputCache.__PropertyOffset_InputAction) = (byte)value;
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x06001156 RID: 4438 RVA: 0x000630C8 File Offset: 0x000612C8
	// (set) Token: 0x06001157 RID: 4439 RVA: 0x000630D8 File Offset: 0x000612D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EInputState InputState
	{
		get
		{
			return (EInputState)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateClearInputCache.__PropertyOffset_InputState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateClearInputCache.__PropertyOffset_InputState) = (byte)value;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000630EC File Offset: 0x000612EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateClearInputCache) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateClearInputCache.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001159 RID: 4441 RVA: 0x000631A4 File Offset: 0x000613A4
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterInputComponent component = (owner as TsBaseCharacter).CharacterActorComponent.Entity.GetComponent<CharacterInputComponent>();
			if (component != null)
			{
				component.ClearInputCache((int)this.InputAction, this.InputState);
			}
		}
		return true;
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x000631EC File Offset: 0x000613EC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateClearInputCache._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateClearInputCache.TsAnimNotifyStateClearInputCache_C");
		}
		return TsAnimNotifyStateClearInputCache._ClassPtr;
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00063210 File Offset: 0x00061410
	public TsAnimNotifyStateClearInputCache() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateClearInputCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00063238 File Offset: 0x00061438
	[NullableContext(1)]
	public TsAnimNotifyStateClearInputCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateClearInputCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x0006326B File Offset: 0x0006146B
	protected TsAnimNotifyStateClearInputCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00063274 File Offset: 0x00061474
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000D08 RID: 3336
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateClearInputCache.TsAnimNotifyStateClearInputCache_C";

	// Token: 0x04000D09 RID: 3337
	private static IntPtr _ClassPtr;

	// Token: 0x04000D0A RID: 3338
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D0B RID: 3339
	private static int __PropertyOffset_InputAction;

	// Token: 0x04000D0C RID: 3340
	private static int __PropertyOffset_InputState;
}
