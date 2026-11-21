using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000181 RID: 385
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C")]
public class TsAnimNotifyStateSwitchNpcFaceExpression : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00086E0F File Offset: 0x0008500F
	// (set) Token: 0x060018CA RID: 6346 RVA: 0x00086E1F File Offset: 0x0008501F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FaceExpressionId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSwitchNpcFaceExpression.__PropertyOffset_FaceExpressionId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSwitchNpcFaceExpression.__PropertyOffset_FaceExpressionId) = value;
		}
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00086E30 File Offset: 0x00085030
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSwitchNpcFaceExpression) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018CC RID: 6348 RVA: 0x00086EF0 File Offset: 0x000850F0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		CommonNpcPerformComponent commonNpcPerformComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CommonNpcPerformComponent>() : null;
		if (commonNpcPerformComponent == null)
		{
			return false;
		}
		if (this.PlayExpressionHandle == 0)
		{
			this.PlayExpressionHandle = commonNpcPerformComponent.ExpressionController.ChangeFaceForExpressionFromAnimNotify(new int?(this.FaceExpressionId));
		}
		return true;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x00086F58 File Offset: 0x00085158
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSwitchNpcFaceExpression) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018CE RID: 6350 RVA: 0x00087010 File Offset: 0x00085210
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		CommonNpcPerformComponent commonNpcPerformComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CommonNpcPerformComponent>() : null;
		if (commonNpcPerformComponent == null)
		{
			return false;
		}
		if (this.PlayExpressionHandle != 0)
		{
			commonNpcPerformComponent.ExpressionController.ResetFaceForExpressionFromAnimNotify(this.PlayExpressionHandle);
			this.PlayExpressionHandle = 0;
		}
		return true;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00087074 File Offset: 0x00085274
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSwitchNpcFaceExpression) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), out intPtr, out num))
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

	// Token: 0x060018D0 RID: 6352 RVA: 0x00087104 File Offset: 0x00085304
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "切换Npc表情";
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x0008710B File Offset: 0x0008530B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSwitchNpcFaceExpression._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C");
		}
		return TsAnimNotifyStateSwitchNpcFaceExpression._ClassPtr;
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x00087130 File Offset: 0x00085330
	public TsAnimNotifyStateSwitchNpcFaceExpression() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00087158 File Offset: 0x00085358
	[NullableContext(1)]
	public TsAnimNotifyStateSwitchNpcFaceExpression(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x0008718B File Offset: 0x0008538B
	protected TsAnimNotifyStateSwitchNpcFaceExpression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x00087194 File Offset: 0x00085394
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x000871D0 File Offset: 0x000853D0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00087203 File Offset: 0x00085403
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001077 RID: 4215
	private int PlayExpressionHandle;

	// Token: 0x04001078 RID: 4216
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C";

	// Token: 0x04001079 RID: 4217
	private static IntPtr _ClassPtr;

	// Token: 0x0400107A RID: 4218
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400107B RID: 4219
	private static int __PropertyOffset_FaceExpressionId;
}
