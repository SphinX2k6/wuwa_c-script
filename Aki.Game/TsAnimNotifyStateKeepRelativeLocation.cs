using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000147 RID: 327
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C")]
public class TsAnimNotifyStateKeepRelativeLocation : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001468 RID: 5224 RVA: 0x00073EDC File Offset: 0x000720DC
	static TsAnimNotifyStateKeepRelativeLocation()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateKeepRelativeLocation.CreateStaticDefaultValue), new Action(TsAnimNotifyStateKeepRelativeLocation.ResetStaticDefaultValue));
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00073F52 File Offset: 0x00072152
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateKeepRelativeLocation.IsInit = false;
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = new Dictionary<AActor, float>();
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00073F64 File Offset: 0x00072164
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateKeepRelativeLocation.IsInit = false;
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = null;
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x0600146B RID: 5227 RVA: 0x00073F72 File Offset: 0x00072172
	// (set) Token: 0x0600146C RID: 5228 RVA: 0x00073F82 File Offset: 0x00072182
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool RelativeSocketEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeSocketEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeSocketEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x0600146D RID: 5229 RVA: 0x00073F93 File Offset: 0x00072193
	// (set) Token: 0x0600146E RID: 5230 RVA: 0x00073FA7 File Offset: 0x000721A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName RelativeSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeSocketName) = value;
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x00073FBC File Offset: 0x000721BC
	// (set) Token: 0x06001470 RID: 5232 RVA: 0x00073FD0 File Offset: 0x000721D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector RelativeOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_RelativeOffset) = value;
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x00073FE5 File Offset: 0x000721E5
	// (set) Token: 0x06001472 RID: 5234 RVA: 0x00073FF5 File Offset: 0x000721F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float KeepDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_KeepDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_KeepDuration) = value;
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x06001473 RID: 5235 RVA: 0x00074006 File Offset: 0x00072206
	// (set) Token: 0x06001474 RID: 5236 RVA: 0x00074016 File Offset: 0x00072216
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x06001475 RID: 5237 RVA: 0x00074027 File Offset: 0x00072227
	// (set) Token: 0x06001476 RID: 5238 RVA: 0x00074037 File Offset: 0x00072237
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ChaseTimeConstant
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_ChaseTimeConstant);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_ChaseTimeConstant) = value;
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x06001477 RID: 5239 RVA: 0x00074048 File Offset: 0x00072248
	// (set) Token: 0x06001478 RID: 5240 RVA: 0x00074058 File Offset: 0x00072258
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateKeepRelativeLocation.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0007406C File Offset: 0x0007226C
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		BaseGroupAiComponent component = characterActorComponent.Entity.GetComponent<BaseGroupAiComponent>();
		EntityHandle entityHandle = (component != null) ? component.GetEcologyAttachTarget() : null;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (entityHandle == null || !entityHandle.Valid || (worldEntity == null || !worldEntity.Valid))
		{
			return false;
		}
		CharacterActorComponent component2 = worldEntity.GetComponent<CharacterActorComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		TsAnimNotifyStateKeepRelativeLocation.Initialize();
		float val = this.KeepDuration / 1000f;
		float value = (this.KeepDuration > 0f) ? Math.Min(totalDuration, val) : totalDuration;
		TsAnimNotifyStateKeepRelativeLocation.CacheMap.Add(owner, value);
		return true;
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00074158 File Offset: 0x00072358
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		Dictionary<AActor, float> cacheMap = TsAnimNotifyStateKeepRelativeLocation.CacheMap;
		float totalDuration;
		if (cacheMap == null || !cacheMap.TryGetValue(owner, out totalDuration))
		{
			return false;
		}
		BaseGroupAiComponent component = characterActorComponent.Entity.GetComponent<BaseGroupAiComponent>();
		EntityHandle entityHandle = (component != null) ? component.GetEcologyAttachTarget() : null;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (entityHandle == null || !entityHandle.Valid || (worldEntity == null || !worldEntity.Valid))
		{
			return false;
		}
		CharacterActorComponent component2 = worldEntity.GetComponent<CharacterActorComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		this.KeepRelativeLocation(characterActorComponent, component2, totalDuration, frameDeltaTime);
		return true;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x0007422C File Offset: 0x0007242C
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Dictionary<AActor, float> cacheMap = TsAnimNotifyStateKeepRelativeLocation.CacheMap;
		if (cacheMap != null)
		{
			cacheMap.Remove(owner);
		}
		return true;
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0007425D File Offset: 0x0007245D
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "保持相对怪物组Attach目标的相对位置";
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00074264 File Offset: 0x00072464
	private void KeepRelativeLocation(CharacterActorComponent actorComp, CharacterActorComponent targetActorComp, float totalDuration, float frameDeltaTime)
	{
		Vector targetLocation = this.GetTargetLocation(targetActorComp);
		Vector vector = this.ComputeSmoothLocation(actorComp, targetLocation, totalDuration, frameDeltaTime);
		CharacterAnimationComponent component = actorComp.Entity.GetComponent<CharacterAnimationComponent>();
		bool flag = component != null && component.Valid && frameDeltaTime > 0.1f;
		FTransformDouble? ftransformDouble = flag ? new FTransformDouble?(component.GetMeshTransform()) : null;
		actorComp.SetActorLocation(vector.ToUeVector(false), "TsAnimNotifyStateKeepRelativeLocation", false);
		if (flag && ftransformDouble != null)
		{
			component.SetModelBuffer(ftransformDouble.Value, frameDeltaTime * 1000f * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		}
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00074304 File Offset: 0x00072504
	private Vector ComputeSmoothLocation(CharacterActorComponent actorComp, Vector targetLocation, float totalDuration, float frameDeltaTime)
	{
		Vector tmpVector = TsAnimNotifyStateKeepRelativeLocation.TmpVector3;
		targetLocation.Subtraction(actorComp.ActorLocationProxy, tmpVector);
		double num = tmpVector.Size();
		if (num < 0.0001)
		{
			return targetLocation;
		}
		float num2 = totalDuration - base.GetCurrentTimeLength();
		float num3;
		if (num2 > frameDeltaTime && (double)num2 > 0.0001)
		{
			num3 = (float)(num * (double)(frameDeltaTime / num2));
		}
		else if ((double)this.ChaseTimeConstant > 0.0001)
		{
			num3 = (float)(num * (1.0 - Math.Exp((double)(-(double)frameDeltaTime / this.ChaseTimeConstant))));
		}
		else
		{
			num3 = ((this.MaxSpeed > 0f) ? (this.MaxSpeed * frameDeltaTime) : ((float)num));
		}
		if (this.MaxSpeed > 0f)
		{
			float num4 = this.MaxSpeed * frameDeltaTime;
			if (num3 > num4)
			{
				num3 = num4;
			}
		}
		if ((double)num3 >= num)
		{
			return targetLocation;
		}
		tmpVector.MultiplyEqual((double)num3 / num);
		tmpVector.AdditionEqual(actorComp.ActorLocationProxy);
		return tmpVector;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x000743F8 File Offset: 0x000725F8
	private Vector GetTargetLocation(CharacterActorComponent targetActorComp)
	{
		Vector tmpVector = TsAnimNotifyStateKeepRelativeLocation.TmpVector1;
		Vector tmpVector2 = TsAnimNotifyStateKeepRelativeLocation.TmpVector2;
		if (this.RelativeSocketEnable && this.RelativeSocketName != null && !StringUtils.IsNothing(this.RelativeSocketName.ToString()))
		{
			Vector vector = tmpVector;
			FVectorDouble socketLocation = targetActorComp.GetSocketLocation(this.RelativeSocketName);
			vector.DeepCopy(socketLocation);
		}
		else
		{
			tmpVector.DeepCopy(targetActorComp.ActorLocationProxy);
		}
		if (this.DebugDraw)
		{
			TsAnimNotifyStateKeepRelativeLocation.DrawDebugSphere(tmpVector, ColorUtils.LinearRed);
		}
		FVector relativeOffset = this.RelativeOffset;
		Vector vector2 = tmpVector2;
		FVector relativeOffset2 = this.RelativeOffset;
		vector2.FromUeVector(relativeOffset2);
		Quat tmpQuat = TsAnimNotifyStateKeepRelativeLocation.TmpQuat;
		targetActorComp.ActorRotationProxy.Quaternion(tmpQuat);
		tmpQuat.RotateVector(tmpVector2, tmpVector2);
		tmpVector.AdditionEqual(tmpVector2);
		if (this.DebugDraw)
		{
			TsAnimNotifyStateKeepRelativeLocation.DrawDebugSphere(tmpVector, ColorUtils.LinearGreen);
		}
		return tmpVector;
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x000744CE File Offset: 0x000726CE
	private static void DrawDebugSphere(Vector location, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, location.ToUeVector(false), 30f, 10, new FLinearColor?(color), 0f, 0f);
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x000744F8 File Offset: 0x000726F8
	private static void Initialize()
	{
		if (TsAnimNotifyStateKeepRelativeLocation.IsInit)
		{
			return;
		}
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = new Dictionary<AActor, float>();
		TsAnimNotifyStateKeepRelativeLocation.IsInit = true;
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00074512 File Offset: 0x00072712
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateKeepRelativeLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C");
		}
		return TsAnimNotifyStateKeepRelativeLocation._ClassPtr;
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00074538 File Offset: 0x00072738
	public TsAnimNotifyStateKeepRelativeLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepRelativeLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00074560 File Offset: 0x00072760
	public TsAnimNotifyStateKeepRelativeLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepRelativeLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00074593 File Offset: 0x00072793
	protected TsAnimNotifyStateKeepRelativeLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x0007459C File Offset: 0x0007279C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000745D8 File Offset: 0x000727D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00074614 File Offset: 0x00072814
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00074647 File Offset: 0x00072847
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000E9F RID: 3743
	private const int DEBUG_SPHERE_RADIUS = 30;

	// Token: 0x04000EA0 RID: 3744
	private const int DEBUG_SPHERE_SEGMENTS = 10;

	// Token: 0x04000EA1 RID: 3745
	private const float MODEL_BUFFER_INTERVAL = 0.1f;

	// Token: 0x04000EA2 RID: 3746
	private static bool IsInit;

	// Token: 0x04000EA3 RID: 3747
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<AActor, float> CacheMap;

	// Token: 0x04000EA4 RID: 3748
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000EA5 RID: 3749
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000EA6 RID: 3750
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x04000EA7 RID: 3751
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000EA8 RID: 3752
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C";

	// Token: 0x04000EA9 RID: 3753
	private static IntPtr _ClassPtr;

	// Token: 0x04000EAA RID: 3754
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EAB RID: 3755
	private static int __PropertyOffset_RelativeSocketEnable;

	// Token: 0x04000EAC RID: 3756
	private static int __PropertyOffset_RelativeSocketName;

	// Token: 0x04000EAD RID: 3757
	private static int __PropertyOffset_RelativeOffset;

	// Token: 0x04000EAE RID: 3758
	private static int __PropertyOffset_KeepDuration;

	// Token: 0x04000EAF RID: 3759
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000EB0 RID: 3760
	private static int __PropertyOffset_ChaseTimeConstant;

	// Token: 0x04000EB1 RID: 3761
	private static int __PropertyOffset_DebugDraw;
}
