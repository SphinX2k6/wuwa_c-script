using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A2 RID: 418
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C")]
public class TsAnimNotifyChangeAcceleration : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0008A679 File Offset: 0x00088879
	// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0008A689 File Offset: 0x00088889
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Time
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeAcceleration.__PropertyOffset_Time);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeAcceleration.__PropertyOffset_Time) = value;
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0008A69A File Offset: 0x0008889A
	// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0008A6AA File Offset: 0x000888AA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharState MoveState
	{
		get
		{
			return (ECharState)(*(base.NativePtr + (IntPtr)TsAnimNotifyChangeAcceleration.__PropertyOffset_MoveState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeAcceleration.__PropertyOffset_MoveState) = (byte)value;
		}
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x0008A6BC File Offset: 0x000888BC
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

	// Token: 0x06001A90 RID: 6800 RVA: 0x0008A75C File Offset: 0x0008895C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
			CharacterMoveComponent characterMoveComponent = (entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null;
			if (characterMoveComponent != null)
			{
				characterMoveComponent.AccelerationLerpTime = this.Time;
				characterMoveComponent.AccelerationChangeMoveState = new ECharMoveState?((ECharMoveState)this.MoveState);
			}
		}
		return true;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x0008A7B4 File Offset: 0x000889B4
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

	// Token: 0x06001A92 RID: 6802 RVA: 0x0008A82F File Offset: 0x00088A2F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "修改角色位移最大加速度";
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x0008A836 File Offset: 0x00088A36
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeAcceleration._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C");
		}
		return TsAnimNotifyChangeAcceleration._ClassPtr;
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x0008A85C File Offset: 0x00088A5C
	public TsAnimNotifyChangeAcceleration() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeAcceleration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x0008A884 File Offset: 0x00088A84
	[NullableContext(1)]
	public TsAnimNotifyChangeAcceleration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeAcceleration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x0008A8B7 File Offset: 0x00088AB7
	protected TsAnimNotifyChangeAcceleration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x0008A8C0 File Offset: 0x00088AC0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x0008A8F3 File Offset: 0x00088AF3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001135 RID: 4405
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C";

	// Token: 0x04001136 RID: 4406
	private static IntPtr _ClassPtr;

	// Token: 0x04001137 RID: 4407
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001138 RID: 4408
	private static int __PropertyOffset_Time;

	// Token: 0x04001139 RID: 4409
	private static int __PropertyOffset_MoveState;
}
