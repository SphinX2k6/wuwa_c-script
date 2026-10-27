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
	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x0600114E RID: 4430 RVA: 0x00061ABB File Offset: 0x0005FCBB
	// (set) Token: 0x0600114F RID: 4431 RVA: 0x00061ACB File Offset: 0x0005FCCB
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

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x06001150 RID: 4432 RVA: 0x00061ADC File Offset: 0x0005FCDC
	// (set) Token: 0x06001151 RID: 4433 RVA: 0x00061AEC File Offset: 0x0005FCEC
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

	// Token: 0x06001152 RID: 4434 RVA: 0x00061B00 File Offset: 0x0005FD00
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

	// Token: 0x06001153 RID: 4435 RVA: 0x00061BA0 File Offset: 0x0005FDA0
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

	// Token: 0x06001154 RID: 4436 RVA: 0x00061BE8 File Offset: 0x0005FDE8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateClearInputCache._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateClearInputCache.TsAnimNotifyStateClearInputCache_C");
		}
		return TsAnimNotifyStateClearInputCache._ClassPtr;
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00061C0C File Offset: 0x0005FE0C
	public TsAnimNotifyStateClearInputCache() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateClearInputCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00061C34 File Offset: 0x0005FE34
	[NullableContext(1)]
	public TsAnimNotifyStateClearInputCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateClearInputCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00061C67 File Offset: 0x0005FE67
	protected TsAnimNotifyStateClearInputCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00061C70 File Offset: 0x0005FE70
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000D00 RID: 3328
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateClearInputCache.TsAnimNotifyStateClearInputCache_C";

	// Token: 0x04000D01 RID: 3329
	private static IntPtr _ClassPtr;

	// Token: 0x04000D02 RID: 3330
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D03 RID: 3331
	private static int __PropertyOffset_InputAction;

	// Token: 0x04000D04 RID: 3332
	private static int __PropertyOffset_InputState;
}
