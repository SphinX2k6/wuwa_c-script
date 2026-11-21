using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200017C RID: 380
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C")]
public class TsAnimNotifyStateStareDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001858 RID: 6232 RVA: 0x000854EB File Offset: 0x000836EB
	// (set) Token: 0x06001859 RID: 6233 RVA: 0x000854FF File Offset: 0x000836FF
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

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x0600185A RID: 6234 RVA: 0x00085514 File Offset: 0x00083714
	// (set) Token: 0x0600185B RID: 6235 RVA: 0x00085524 File Offset: 0x00083724
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

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x0600185C RID: 6236 RVA: 0x00085535 File Offset: 0x00083735
	// (set) Token: 0x0600185D RID: 6237 RVA: 0x00085549 File Offset: 0x00083749
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

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x0600185E RID: 6238 RVA: 0x0008555E File Offset: 0x0008375E
	// (set) Token: 0x0600185F RID: 6239 RVA: 0x00085572 File Offset: 0x00083772
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

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001860 RID: 6240 RVA: 0x00085587 File Offset: 0x00083787
	// (set) Token: 0x06001861 RID: 6241 RVA: 0x0008559B File Offset: 0x0008379B
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

	// Token: 0x06001862 RID: 6242 RVA: 0x000855B0 File Offset: 0x000837B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateStareDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateStareDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001863 RID: 6243 RVA: 0x00085670 File Offset: 0x00083870
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

	// Token: 0x06001864 RID: 6244 RVA: 0x000856A0 File Offset: 0x000838A0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateStareDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateStareDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001865 RID: 6245 RVA: 0x00085760 File Offset: 0x00083960
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

	// Token: 0x06001866 RID: 6246 RVA: 0x000857D8 File Offset: 0x000839D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateStareDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateStareDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001867 RID: 6247 RVA: 0x0008588E File Offset: 0x00083A8E
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

	// Token: 0x06001868 RID: 6248 RVA: 0x000858B0 File Offset: 0x00083AB0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateStareDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateStareDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001869 RID: 6249 RVA: 0x00085940 File Offset: 0x00083B40
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "发送动画广播通知（基于相机位置）";
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00085948 File Offset: 0x00083B48
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

	// Token: 0x0600186B RID: 6251 RVA: 0x00085A0C File Offset: 0x00083C0C
	private void SendGameplayEvent(int entityId)
	{
		BaseAbilityComponent component = EntitySystem.Instance.GetComponent<BaseAbilityComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SendGameplayEventToActor(this.发送GameplayEvent, null);
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00085A2C File Offset: 0x00083C2C
	private bool AngleInRangeDeg(float xDeg, FVector2D rangeDeg)
	{
		float num = (float)MathUtils.Instance.NormalizeDeg180((double)xDeg);
		float num2 = (float)MathUtils.Instance.NormalizeDeg180((double)rangeDeg.X);
		float num3 = (float)MathUtils.Instance.NormalizeDeg180((double)rangeDeg.Y);
		return MathUtils.Instance.IsAngleInRange((double)num, (double)num2, (double)num3);
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00085A80 File Offset: 0x00083C80
	private bool DistanceInRange(float distance, FVector2D range)
	{
		float x = range.X;
		float y = range.Y;
		return (x == -1f || distance >= x) && (y == -1f || distance <= y);
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00085ABA File Offset: 0x00083CBA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateStareDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C");
		}
		return TsAnimNotifyStateStareDetect._ClassPtr;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00085AE0 File Offset: 0x00083CE0
	public TsAnimNotifyStateStareDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStareDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00085B08 File Offset: 0x00083D08
	[NullableContext(1)]
	public TsAnimNotifyStateStareDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateStareDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00085B3B File Offset: 0x00083D3B
	protected TsAnimNotifyStateStareDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00085B50 File Offset: 0x00083D50
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00085B8C File Offset: 0x00083D8C
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x00085BC8 File Offset: 0x00083DC8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00085BFB File Offset: 0x00083DFB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001043 RID: 4163
	[Nullable(1)]
	private readonly Dictionary<USkeletalMeshComponent, StareDetectParams> ParamsMap = new Dictionary<USkeletalMeshComponent, StareDetectParams>();

	// Token: 0x04001044 RID: 4164
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateStareDetect.TsAnimNotifyStateStareDetect_C";

	// Token: 0x04001045 RID: 4165
	private static IntPtr _ClassPtr;

	// Token: 0x04001046 RID: 4166
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001047 RID: 4167
	private static int __PropertyOffset_发送GameplayEvent;

	// Token: 0x04001048 RID: 4168
	private static int __PropertyOffset_持续时间;

	// Token: 0x04001049 RID: 4169
	private static int __PropertyOffset_距离区间;

	// Token: 0x0400104A RID: 4170
	private static int __PropertyOffset_水平区间;

	// Token: 0x0400104B RID: 4171
	private static int __PropertyOffset_垂直区间;
}
