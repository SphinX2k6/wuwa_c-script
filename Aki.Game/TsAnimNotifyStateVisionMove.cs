using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000186 RID: 390
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C")]
public class TsAnimNotifyStateVisionMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x060018BC RID: 6332 RVA: 0x00083A13 File Offset: 0x00081C13
	// (set) Token: 0x060018BD RID: 6333 RVA: 0x00083A27 File Offset: 0x00081C27
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 移动速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVisionMove.__PropertyOffset_移动速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVisionMove.__PropertyOffset_移动速度) = value;
		}
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00083A3C File Offset: 0x00081C3C
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

	// Token: 0x060018BF RID: 6335 RVA: 0x00083AE4 File Offset: 0x00081CE4
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		if (UKuroStaticLibrary.IsObjectClassByName(meshComp.GetOwner(), CharacterNameDefines.Instance.BP_BASEVISION))
		{
			Vector velocity = this.Velocity;
			FVector 移动速度 = this.移动速度;
			velocity.FromUeVector(移动速度);
			return true;
		}
		return false;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00083B28 File Offset: 0x00081D28
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

	// Token: 0x060018C1 RID: 6337 RVA: 0x00083BD0 File Offset: 0x00081DD0
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		AActor owner = meshComp.GetOwner();
		if (!UKuroStaticLibrary.IsObjectClassByName(owner, CharacterNameDefines.Instance.BP_BASEVISION))
		{
			return false;
		}
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>((owner as BP_BaseVision_C).EntityId);
		if (component == null || !component.Valid)
		{
			return false;
		}
		component.AddActorLocalOffset(this.Velocity.Multiply((double)frameDeltaTime, this.TmpVector).ToUeVector(false), "TsAnimNotifyStateVisionMove", true);
		return true;
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00083C47 File Offset: 0x00081E47
	private void Init()
	{
		this.Velocity = Vector.Create();
		this.TmpVector = Vector.Create();
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00083C60 File Offset: 0x00081E60
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

	// Token: 0x060018C4 RID: 6340 RVA: 0x00083CDB File Offset: 0x00081EDB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "幻象移动";
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00083CE2 File Offset: 0x00081EE2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVisionMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C");
		}
		return TsAnimNotifyStateVisionMove._ClassPtr;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00083D08 File Offset: 0x00081F08
	public TsAnimNotifyStateVisionMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00083D30 File Offset: 0x00081F30
	[NullableContext(1)]
	public TsAnimNotifyStateVisionMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00083D63 File Offset: 0x00081F63
	protected TsAnimNotifyStateVisionMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00083D6C File Offset: 0x00081F6C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00083DA8 File Offset: 0x00081FA8
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00083DE1 File Offset: 0x00081FE1
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001071 RID: 4209
	[Nullable(2)]
	private Vector Velocity;

	// Token: 0x04001072 RID: 4210
	[Nullable(2)]
	private Vector TmpVector;

	// Token: 0x04001073 RID: 4211
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C";

	// Token: 0x04001074 RID: 4212
	private static IntPtr _ClassPtr;

	// Token: 0x04001075 RID: 4213
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001076 RID: 4214
	private static int __PropertyOffset_移动速度;
}
