using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000143 RID: 323
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C")]
public class TsAnimNotifyStateKeepRelativeLocation : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060013CB RID: 5067 RVA: 0x0006ED20 File Offset: 0x0006CF20
	static TsAnimNotifyStateKeepRelativeLocation()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateKeepRelativeLocation.CreateStaticDefaultValue), new Action(TsAnimNotifyStateKeepRelativeLocation.ResetStaticDefaultValue));
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0006ED96 File Offset: 0x0006CF96
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateKeepRelativeLocation.IsInit = false;
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = new Dictionary<AActor, float>();
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x0006EDA8 File Offset: 0x0006CFA8
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateKeepRelativeLocation.IsInit = false;
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = null;
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x060013CE RID: 5070 RVA: 0x0006EDB6 File Offset: 0x0006CFB6
	// (set) Token: 0x060013CF RID: 5071 RVA: 0x0006EDC6 File Offset: 0x0006CFC6
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

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0006EDD7 File Offset: 0x0006CFD7
	// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0006EDEB File Offset: 0x0006CFEB
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

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0006EE00 File Offset: 0x0006D000
	// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0006EE14 File Offset: 0x0006D014
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

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0006EE29 File Offset: 0x0006D029
	// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0006EE39 File Offset: 0x0006D039
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

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0006EE4A File Offset: 0x0006D04A
	// (set) Token: 0x060013D7 RID: 5079 RVA: 0x0006EE5A File Offset: 0x0006D05A
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

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0006EE6B File Offset: 0x0006D06B
	// (set) Token: 0x060013D9 RID: 5081 RVA: 0x0006EE7B File Offset: 0x0006D07B
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

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x060013DA RID: 5082 RVA: 0x0006EE8C File Offset: 0x0006D08C
	// (set) Token: 0x060013DB RID: 5083 RVA: 0x0006EE9C File Offset: 0x0006D09C
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

	// Token: 0x060013DC RID: 5084 RVA: 0x0006EEB0 File Offset: 0x0006D0B0
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

	// Token: 0x060013DD RID: 5085 RVA: 0x0006EF9C File Offset: 0x0006D19C
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

	// Token: 0x060013DE RID: 5086 RVA: 0x0006F070 File Offset: 0x0006D270
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

	// Token: 0x060013DF RID: 5087 RVA: 0x0006F0A1 File Offset: 0x0006D2A1
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "保持相对怪物组Attach目标的相对位置";
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
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

	// Token: 0x060013E1 RID: 5089 RVA: 0x0006F148 File Offset: 0x0006D348
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

	// Token: 0x060013E2 RID: 5090 RVA: 0x0006F23C File Offset: 0x0006D43C
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

	// Token: 0x060013E3 RID: 5091 RVA: 0x0006F312 File Offset: 0x0006D512
	private static void DrawDebugSphere(Vector location, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, location.ToUeVector(false), 30f, 10, new FLinearColor?(color), 0f, 0f);
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x0006F33C File Offset: 0x0006D53C
	private static void Initialize()
	{
		if (TsAnimNotifyStateKeepRelativeLocation.IsInit)
		{
			return;
		}
		TsAnimNotifyStateKeepRelativeLocation.CacheMap = new Dictionary<AActor, float>();
		TsAnimNotifyStateKeepRelativeLocation.IsInit = true;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x0006F356 File Offset: 0x0006D556
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateKeepRelativeLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C");
		}
		return TsAnimNotifyStateKeepRelativeLocation._ClassPtr;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x0006F37C File Offset: 0x0006D57C
	public TsAnimNotifyStateKeepRelativeLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepRelativeLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x0006F3A4 File Offset: 0x0006D5A4
	public TsAnimNotifyStateKeepRelativeLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateKeepRelativeLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x0006F3D7 File Offset: 0x0006D5D7
	protected TsAnimNotifyStateKeepRelativeLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x0006F3E0 File Offset: 0x0006D5E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x0006F41C File Offset: 0x0006D61C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0006F458 File Offset: 0x0006D658
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x0006F48B File Offset: 0x0006D68B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000E5C RID: 3676
	private const int DEBUG_SPHERE_RADIUS = 30;

	// Token: 0x04000E5D RID: 3677
	private const int DEBUG_SPHERE_SEGMENTS = 10;

	// Token: 0x04000E5E RID: 3678
	private const float MODEL_BUFFER_INTERVAL = 0.1f;

	// Token: 0x04000E5F RID: 3679
	private static bool IsInit;

	// Token: 0x04000E60 RID: 3680
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<AActor, float> CacheMap;

	// Token: 0x04000E61 RID: 3681
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000E62 RID: 3682
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000E63 RID: 3683
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x04000E64 RID: 3684
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000E65 RID: 3685
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateKeepRelativeLocation.TsAnimNotifyStateKeepRelativeLocation_C";

	// Token: 0x04000E66 RID: 3686
	private static IntPtr _ClassPtr;

	// Token: 0x04000E67 RID: 3687
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E68 RID: 3688
	private static int __PropertyOffset_RelativeSocketEnable;

	// Token: 0x04000E69 RID: 3689
	private static int __PropertyOffset_RelativeSocketName;

	// Token: 0x04000E6A RID: 3690
	private static int __PropertyOffset_RelativeOffset;

	// Token: 0x04000E6B RID: 3691
	private static int __PropertyOffset_KeepDuration;

	// Token: 0x04000E6C RID: 3692
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000E6D RID: 3693
	private static int __PropertyOffset_ChaseTimeConstant;

	// Token: 0x04000E6E RID: 3694
	private static int __PropertyOffset_DebugDraw;
}
