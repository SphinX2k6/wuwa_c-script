using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A6 RID: 422
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C")]
public class TsAnimNotifyChangeAcceleration : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00090CED File Offset: 0x0008EEED
	// (set) Token: 0x06001B29 RID: 6953 RVA: 0x00090CFD File Offset: 0x0008EEFD
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

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00090D0E File Offset: 0x0008EF0E
	// (set) Token: 0x06001B2B RID: 6955 RVA: 0x00090D1E File Offset: 0x0008EF1E
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

	// Token: 0x06001B2C RID: 6956 RVA: 0x00090D30 File Offset: 0x0008EF30
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeAcceleration) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyChangeAcceleration.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00090DE8 File Offset: 0x0008EFE8
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

	// Token: 0x06001B2E RID: 6958 RVA: 0x00090E40 File Offset: 0x0008F040
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeAcceleration) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyChangeAcceleration.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00090ED0 File Offset: 0x0008F0D0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "修改角色位移最大加速度";
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00090ED7 File Offset: 0x0008F0D7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeAcceleration._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C");
		}
		return TsAnimNotifyChangeAcceleration._ClassPtr;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00090EFC File Offset: 0x0008F0FC
	public TsAnimNotifyChangeAcceleration() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeAcceleration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00090F24 File Offset: 0x0008F124
	[NullableContext(1)]
	public TsAnimNotifyChangeAcceleration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeAcceleration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x00090F57 File Offset: 0x0008F157
	protected TsAnimNotifyChangeAcceleration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x00090F60 File Offset: 0x0008F160
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x00090F93 File Offset: 0x0008F193
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001178 RID: 4472
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeAcceleration.TsAnimNotifyChangeAcceleration_C";

	// Token: 0x04001179 RID: 4473
	private static IntPtr _ClassPtr;

	// Token: 0x0400117A RID: 4474
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400117B RID: 4475
	private static int __PropertyOffset_Time;

	// Token: 0x0400117C RID: 4476
	private static int __PropertyOffset_MoveState;
}
