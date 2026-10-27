using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200017D RID: 381
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C")]
public class TsAnimNotifyStateSwitchNpcFaceExpression : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x0600182C RID: 6188 RVA: 0x00080EE7 File Offset: 0x0007F0E7
	// (set) Token: 0x0600182D RID: 6189 RVA: 0x00080EF7 File Offset: 0x0007F0F7
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

	// Token: 0x0600182E RID: 6190 RVA: 0x00080F08 File Offset: 0x0007F108
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

	// Token: 0x0600182F RID: 6191 RVA: 0x00080FB0 File Offset: 0x0007F1B0
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

	// Token: 0x06001830 RID: 6192 RVA: 0x00081018 File Offset: 0x0007F218
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

	// Token: 0x06001831 RID: 6193 RVA: 0x000810B8 File Offset: 0x0007F2B8
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

	// Token: 0x06001832 RID: 6194 RVA: 0x0008111C File Offset: 0x0007F31C
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

	// Token: 0x06001833 RID: 6195 RVA: 0x00081197 File Offset: 0x0007F397
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "切换Npc表情";
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x0008119E File Offset: 0x0007F39E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSwitchNpcFaceExpression._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C");
		}
		return TsAnimNotifyStateSwitchNpcFaceExpression._ClassPtr;
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x000811C4 File Offset: 0x0007F3C4
	public TsAnimNotifyStateSwitchNpcFaceExpression() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x000811EC File Offset: 0x0007F3EC
	[NullableContext(1)]
	public TsAnimNotifyStateSwitchNpcFaceExpression(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSwitchNpcFaceExpression.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x0008121F File Offset: 0x0007F41F
	protected TsAnimNotifyStateSwitchNpcFaceExpression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x00081228 File Offset: 0x0007F428
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x00081264 File Offset: 0x0007F464
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00081297 File Offset: 0x0007F497
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001034 RID: 4148
	private int PlayExpressionHandle;

	// Token: 0x04001035 RID: 4149
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSwitchNpcFaceExpression.TsAnimNotifyStateSwitchNpcFaceExpression_C";

	// Token: 0x04001036 RID: 4150
	private static IntPtr _ClassPtr;

	// Token: 0x04001037 RID: 4151
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001038 RID: 4152
	private static int __PropertyOffset_FaceExpressionId;
}
