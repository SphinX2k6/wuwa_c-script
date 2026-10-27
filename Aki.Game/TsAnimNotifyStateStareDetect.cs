using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000178 RID: 376
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C")]
public class TsAnimNotifyStateStareDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x060017BB RID: 6075 RVA: 0x0007F6BF File Offset: 0x0007D8BF
	// (set) Token: 0x060017BC RID: 6076 RVA: 0x0007F6D3 File Offset: 0x0007D8D3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 发送GameplayEvent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_发送GameplayEvent);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_发送GameplayEvent) = value;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x060017BD RID: 6077 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
	// (set) Token: 0x060017BE RID: 6078 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 持续时间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_持续时间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_持续时间) = value;
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x060017BF RID: 6079 RVA: 0x0007F709 File Offset: 0x0007D909
	// (set) Token: 0x060017C0 RID: 6080 RVA: 0x0007F71D File Offset: 0x0007D91D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 距离区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_距离区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_距离区间) = value;
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0007F732 File Offset: 0x0007D932
	// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0007F746 File Offset: 0x0007D946
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 水平区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_水平区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_水平区间) = value;
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0007F75B File Offset: 0x0007D95B
	// (set) Token: 0x060017C4 RID: 6084 RVA: 0x0007F76F File Offset: 0x0007D96F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 垂直区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_垂直区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateStareDetect.__PropertyOffset_垂直区间) = value;
		}
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x0007F784 File Offset: 0x0007D984
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

	// Token: 0x060017C6 RID: 6086 RVA: 0x0007F82C File Offset: 0x0007DA2C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (!(meshComp.GetOwner() is TsBaseCharacter))
		{
			return false;
		}
		StareDetectParams value = new StareDetectParams();
		this.ParamsMap[meshComp] = value;
		return true;
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x0007F85C File Offset: 0x0007DA5C
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

	// Token: 0x060017C8 RID: 6088 RVA: 0x0007F904 File Offset: 0x0007DB04
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		StareDetectParams stareDetectParams;
		if (!this.ParamsMap.TryGetValue(meshComp, out stareDetectParams))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (this.StareDetect(characterActorComponent))
		{
			stareDetectParams.NowTime += frameDeltaTime;
		}
		if (stareDetectParams.NowTime > this.持续时间)
		{
			this.ParamsMap.Remove(meshComp);
			this.SendGameplayEvent(tsBaseCharacter.EntityId);
		}
		return true;
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x0007F97C File Offset: 0x0007DB7C
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

	// Token: 0x060017CA RID: 6090 RVA: 0x0007FA1B File Offset: 0x0007DC1B
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!(meshComp.GetOwner() is TsBaseCharacter))
		{
			return false;
		}
		this.ParamsMap.Remove(meshComp);
		return true;
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x0007FA3C File Offset: 0x0007DC3C
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

	// Token: 0x060017CC RID: 6092 RVA: 0x0007FAB7 File Offset: 0x0007DCB7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画广播通知（基于相机位置）";
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x0007FAC0 File Offset: 0x0007DCC0
	[NullableContext(1)]
	private bool StareDetect(CharacterActorComponent myActorComp)
	{
		FVectorDouble actorForward = myActorComp.ActorForward;
		FVectorDouble actorLocation = myActorComp.ActorLocation;
		FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
		FVectorDouble fvectorDouble2 = fvectorDouble - actorLocation;
		FVectorDouble fvectorDouble3 = FVectorDouble.CrossProduct(actorForward, Vector.UpVectorDouble);
		float xDeg = (float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForward, fvectorDouble2, Vector.UpVectorDouble);
		float xDeg2 = (float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForward, fvectorDouble2, fvectorDouble3);
		float distance = (float)fvectorDouble2.Size();
		bool flag = this.AngleInRangeDeg(xDeg, this.水平区间);
		bool flag2 = this.AngleInRangeDeg(xDeg2, this.垂直区间);
		bool flag3 = this.DistanceInRange(distance, this.距离区间);
		return flag && flag2 && flag3;
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0007FB84 File Offset: 0x0007DD84
	private void SendGameplayEvent(int entityId)
	{
		BaseAbilityComponent component = EntitySystem.Instance.GetComponent<BaseAbilityComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SendGameplayEventToActor(this.发送GameplayEvent, null);
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0007FBA4 File Offset: 0x0007DDA4
	private bool AngleInRangeDeg(float xDeg, FVector2D rangeDeg)
	{
		float num = (float)MathUtils.Instance.NormalizeDeg180((double)xDeg);
		float num2 = (float)MathUtils.Instance.NormalizeDeg180((double)rangeDeg.X);
		float num3 = (float)MathUtils.Instance.NormalizeDeg180((double)rangeDeg.Y);
		return MathUtils.Instance.IsAngleInRange((double)num, (double)num2, (double)num3);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x0007FBF8 File Offset: 0x0007DDF8
	private bool DistanceInRange(float distance, FVector2D range)
	{
		float x = range.X;
		float y = range.Y;
		return (x == -1f || distance >= x) && (y == -1f || distance <= y);
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x0007FC32 File Offset: 0x0007DE32
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateStareDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C");
		}
		return TsAnimNotifyStateStareDetect._ClassPtr;
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x0007FC58 File Offset: 0x0007DE58
	public TsAnimNotifyStateStareDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStareDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017D3 RID: 6099 RVA: 0x0007FC80 File Offset: 0x0007DE80
	[NullableContext(1)]
	public TsAnimNotifyStateStareDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStareDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017D4 RID: 6100 RVA: 0x0007FCB3 File Offset: 0x0007DEB3
	protected TsAnimNotifyStateStareDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017D5 RID: 6101 RVA: 0x0007FCC8 File Offset: 0x0007DEC8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x0007FD04 File Offset: 0x0007DF04
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060017D7 RID: 6103 RVA: 0x0007FD40 File Offset: 0x0007DF40
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x0007FD73 File Offset: 0x0007DF73
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001000 RID: 4096
	[Nullable(1)]
	private readonly Dictionary<USkeletalMeshComponent, StareDetectParams> ParamsMap = new Dictionary<USkeletalMeshComponent, StareDetectParams>();

	// Token: 0x04001001 RID: 4097
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C";

	// Token: 0x04001002 RID: 4098
	private static IntPtr _ClassPtr;

	// Token: 0x04001003 RID: 4099
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001004 RID: 4100
	private static int __PropertyOffset_发送GameplayEvent;

	// Token: 0x04001005 RID: 4101
	private static int __PropertyOffset_持续时间;

	// Token: 0x04001006 RID: 4102
	private static int __PropertyOffset_距离区间;

	// Token: 0x04001007 RID: 4103
	private static int __PropertyOffset_水平区间;

	// Token: 0x04001008 RID: 4104
	private static int __PropertyOffset_垂直区间;
}
