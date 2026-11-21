using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vision;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018A RID: 394
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C")]
public class TsAnimNotifyStateVisionMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x06001959 RID: 6489 RVA: 0x00089B63 File Offset: 0x00087D63
	// (set) Token: 0x0600195A RID: 6490 RVA: 0x00089B77 File Offset: 0x00087D77
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

	// Token: 0x0600195B RID: 6491 RVA: 0x00089B8C File Offset: 0x00087D8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVisionMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateVisionMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600195C RID: 6492 RVA: 0x00089C4C File Offset: 0x00087E4C
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

	// Token: 0x0600195D RID: 6493 RVA: 0x00089C90 File Offset: 0x00087E90
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVisionMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateVisionMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600195E RID: 6494 RVA: 0x00089D50 File Offset: 0x00087F50
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

	// Token: 0x0600195F RID: 6495 RVA: 0x00089DC7 File Offset: 0x00087FC7
	private void Init()
	{
		this.Velocity = Vector.Create();
		this.TmpVector = Vector.Create();
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x00089DE0 File Offset: 0x00087FE0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVisionMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateVisionMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001961 RID: 6497 RVA: 0x00089E70 File Offset: 0x00088070
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "幻象移动";
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x00089E77 File Offset: 0x00088077
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVisionMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C");
		}
		return TsAnimNotifyStateVisionMove._ClassPtr;
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x00089E9C File Offset: 0x0008809C
	public TsAnimNotifyStateVisionMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00089EC4 File Offset: 0x000880C4
	[NullableContext(1)]
	public TsAnimNotifyStateVisionMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x00089EF7 File Offset: 0x000880F7
	protected TsAnimNotifyStateVisionMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x00089F00 File Offset: 0x00088100
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x00089F3C File Offset: 0x0008813C
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x00089F75 File Offset: 0x00088175
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010B4 RID: 4276
	[Nullable(2)]
	private Vector Velocity;

	// Token: 0x040010B5 RID: 4277
	[Nullable(2)]
	private Vector TmpVector;

	// Token: 0x040010B6 RID: 4278
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionMove.TsAnimNotifyStateVisionMove_C";

	// Token: 0x040010B7 RID: 4279
	private static IntPtr _ClassPtr;

	// Token: 0x040010B8 RID: 4280
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010B9 RID: 4281
	private static int __PropertyOffset_移动速度;
}
