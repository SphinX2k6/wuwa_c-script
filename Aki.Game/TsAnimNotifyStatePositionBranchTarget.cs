using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200014F RID: 335
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C")]
public class TsAnimNotifyStatePositionBranchTarget : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600149E RID: 5278 RVA: 0x0007281B File Offset: 0x00070A1B
	static TsAnimNotifyStatePositionBranchTarget()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStatePositionBranchTarget.CreateStaticDefaultValue), new Action(TsAnimNotifyStatePositionBranchTarget.ResetStaticDefaultValue));
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x0007283A File Offset: 0x00070A3A
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStatePositionBranchTarget._paramPool = new List<PositionBranchTargetParams>();
		TsAnimNotifyStatePositionBranchTarget._paramMap = new Dictionary<int, PositionBranchTargetParams>();
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x00072850 File Offset: 0x00070A50
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStatePositionBranchTarget._paramPool = null;
		TsAnimNotifyStatePositionBranchTarget._paramMap = null;
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0007285E File Offset: 0x00070A5E
	// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00072872 File Offset: 0x00070A72
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat MoveCurve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MoveCurve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MoveCurve, value);
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00072887 File Offset: 0x00070A87
	// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00072897 File Offset: 0x00070A97
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x060014A5 RID: 5285 RVA: 0x000728A8 File Offset: 0x00070AA8
	// (set) Token: 0x060014A6 RID: 5286 RVA: 0x000728B8 File Offset: 0x00070AB8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x060014A7 RID: 5287 RVA: 0x000728C9 File Offset: 0x00070AC9
	// (set) Token: 0x060014A8 RID: 5288 RVA: 0x000728D9 File Offset: 0x00070AD9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否永远面向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_是否永远面向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_是否永远面向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000728EA File Offset: 0x00070AEA
	// (set) Token: 0x060014AA RID: 5290 RVA: 0x000728FA File Offset: 0x00070AFA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略Z轴方向
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略Z轴方向) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略Z轴方向) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x060014AB RID: 5291 RVA: 0x0007290B File Offset: 0x00070B0B
	// (set) Token: 0x060014AC RID: 5292 RVA: 0x0007291B File Offset: 0x00070B1B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略水平方向
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略水平方向) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略水平方向) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x060014AD RID: 5293 RVA: 0x0007292C File Offset: 0x00070B2C
	// (set) Token: 0x060014AE RID: 5294 RVA: 0x0007293C File Offset: 0x00070B3C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 永远修正Z轴
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_永远修正Z轴) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_永远修正Z轴) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x060014AF RID: 5295 RVA: 0x0007294D File Offset: 0x00070B4D
	// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0007295D File Offset: 0x00070B5D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 忽略双方半径
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略双方半径) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_忽略双方半径) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0007296E File Offset: 0x00070B6E
	// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0007297E File Offset: 0x00070B7E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsShareTarget
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_IsShareTarget) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_IsShareTarget) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0007298F File Offset: 0x00070B8F
	// (set) Token: 0x060014B4 RID: 5300 RVA: 0x000729A3 File Offset: 0x00070BA3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector TargetOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetOffset) = value;
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x060014B5 RID: 5301 RVA: 0x000729B8 File Offset: 0x00070BB8
	// (set) Token: 0x060014B6 RID: 5302 RVA: 0x000729CC File Offset: 0x00070BCC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator TargetRotation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetRotation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_TargetRotation) = value;
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x060014B7 RID: 5303 RVA: 0x000729E1 File Offset: 0x00070BE1
	// (set) Token: 0x060014B8 RID: 5304 RVA: 0x000729F1 File Offset: 0x00070BF1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OffsetByOrientation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByOrientation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByOrientation) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00072A02 File Offset: 0x00070C02
	// (set) Token: 0x060014BA RID: 5306 RVA: 0x00072A12 File Offset: 0x00070C12
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OffsetByAbsolute
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByAbsolute) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_OffsetByAbsolute) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060014BB RID: 5307 RVA: 0x00072A23 File Offset: 0x00070C23
	// (set) Token: 0x060014BC RID: 5308 RVA: 0x00072A33 File Offset: 0x00070C33
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinHeightFromTargetFloor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MinHeightFromTargetFloor);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_MinHeightFromTargetFloor) = value;
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060014BD RID: 5309 RVA: 0x00072A44 File Offset: 0x00070C44
	// (set) Token: 0x060014BE RID: 5310 RVA: 0x00072A54 File Offset: 0x00070C54
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 允许反向移动
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许反向移动) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许反向移动) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x060014BF RID: 5311 RVA: 0x00072A65 File Offset: 0x00070C65
	// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00072A75 File Offset: 0x00070C75
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 允许正向移动
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许正向移动) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_允许正向移动) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00072A86 File Offset: 0x00070C86
	// (set) Token: 0x060014C2 RID: 5314 RVA: 0x00072A96 File Offset: 0x00070C96
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsBranchTargetBlackboardType 黑板类型
	{
		get
		{
			return (EAnsBranchTargetBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板类型) = (byte)value;
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x060014C3 RID: 5315 RVA: 0x00072AA7 File Offset: 0x00070CA7
	// (set) Token: 0x060014C4 RID: 5316 RVA: 0x00072ABB File Offset: 0x00070CBB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 黑板值
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板值)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板值)), value);
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x060014C5 RID: 5317 RVA: 0x00072AD0 File Offset: 0x00070CD0
	// (set) Token: 0x060014C6 RID: 5318 RVA: 0x00072AE4 File Offset: 0x00070CE4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 黑板目标Socket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板目标Socket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_黑板目标Socket)), value);
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00072AF9 File Offset: 0x00070CF9
	// (set) Token: 0x060014C8 RID: 5320 RVA: 0x00072B09 File Offset: 0x00070D09
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最小吸附距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最小吸附距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最小吸附距离) = value;
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060014C9 RID: 5321 RVA: 0x00072B1A File Offset: 0x00070D1A
	// (set) Token: 0x060014CA RID: 5322 RVA: 0x00072B2A File Offset: 0x00070D2A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最大吸附距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最大吸附距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionBranchTarget.__PropertyOffset_最大吸附距离) = value;
		}
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x00072B3C File Offset: 0x00070D3C
	private void Initialize()
	{
		if (this.IsInitialize && !GlobalData.IsPlayInEditor)
		{
			return;
		}
		this.IsInitialize = true;
		this.TsMoveCurve = this.MoveCurve;
		this.TsDistance = this.Distance;
		this.TsMaxDistance = this.最大吸附距离;
		this.TsMinDistance = this.最小吸附距离;
		this.TsMaxSpeed = this.MaxSpeed;
		this.TsLookAtTarget = this.是否永远面向目标;
		this.TsIgnoreZ = this.忽略Z轴方向;
		this.TsIgnoreHorizontal = this.忽略水平方向;
		this.TsAlwaysMoveZ = this.永远修正Z轴;
		this.TsIgnoreRadius = this.忽略双方半径;
		this.TsIsShareTarget = this.IsShareTarget;
		this.TsAllowReverseMovement = this.允许反向移动;
		this.TsAllowForwardMovement = this.允许正向移动;
		this.TsBlackboardKey = this.黑板值;
		this.TsBlackboardType = this.黑板类型;
		this.TsBlackboardSocket = this.黑板目标Socket;
		this.TsTargetOffset = Vector.Create(this.TargetOffset);
		this.TmpRotator = Rotator.Create();
		Rotator tmpRotator = this.TmpRotator;
		FRotator targetRotation = this.TargetRotation;
		tmpRotator.DeepCopy(targetRotation);
		this.TmpQuat.Reset();
		this.TmpRotator.Quaternion(this.TmpQuat);
		this.TmpQuat.RotateVector(this.TsTargetOffset, this.TsTargetOffset);
		this.TsMinHeightFromTargetFloor = this.MinHeightFromTargetFloor;
		this.TargetPos.Reset();
		this.TmpVector.Reset();
		this.TmpVector2.Reset();
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00072CB8 File Offset: 0x00070EB8
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

	// Token: 0x060014CD RID: 5325 RVA: 0x00072D60 File Offset: 0x00070F60
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Initialize();
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		object obj;
		if (tsBaseCharacter == null)
		{
			obj = null;
		}
		else
		{
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			obj = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseActorComponent>() : null);
		}
		object obj2;
		if ((obj2 = obj) == null)
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				obj2 = null;
			}
			else
			{
				Entity entityNoBlueprint2 = tsBaseVehicle.GetEntityNoBlueprint();
				obj2 = ((entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<BaseActorComponent>() : null);
			}
		}
		BaseActorComponent baseActorComponent = obj2;
		if (baseActorComponent == null)
		{
			return false;
		}
		BaseSkillComponent component = baseActorComponent.Entity.GetComponent<BaseSkillComponent>();
		BaseSkillComponent baseSkillComponent;
		if (this.TsIsShareTarget)
		{
			CreatureDataComponent component2 = baseActorComponent.Entity.GetComponent<CreatureDataComponent>();
			EntityHandle entity = CreatureModel.Instance.GetEntity(component2.GetSummonerId());
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			baseSkillComponent = ((worldEntity != null) ? worldEntity.GetComponent<BaseSkillComponent>() : null);
			if (baseSkillComponent == null)
			{
				baseSkillComponent = component;
			}
		}
		else
		{
			baseSkillComponent = component;
		}
		if (baseSkillComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "No SkillComponent";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", baseActorComponent.Owner);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (TsAnimNotifyStatePositionBranchTarget._paramPool == null || TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(baseActorComponent.Entity.Id, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			if (TsAnimNotifyStatePositionBranchTarget._paramPool.Count > 0)
			{
				positionBranchTargetParams = TsAnimNotifyStatePositionBranchTarget._paramPool[TsAnimNotifyStatePositionBranchTarget._paramPool.Count - 1];
				TsAnimNotifyStatePositionBranchTarget._paramPool.RemoveAt(TsAnimNotifyStatePositionBranchTarget._paramPool.Count - 1);
			}
			else
			{
				positionBranchTargetParams = new PositionBranchTargetParams();
			}
		}
		positionBranchTargetParams.BaseActorComp = baseActorComponent;
		positionBranchTargetParams.BaseUnifiedComp = baseActorComponent.Entity.GetComponent<BaseUnifiedStateComponent>();
		positionBranchTargetParams.BaseSkillComp = baseSkillComponent;
		positionBranchTargetParams.NowTime = 0f;
		positionBranchTargetParams.TotalTime = totalDuration;
		if (!positionBranchTargetParams.RefreshTarget(this.TsBlackboardKey, this.TsBlackboardType, this.TsBlackboardSocket))
		{
			return true;
		}
		TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
		int key = (tsBaseCharacter2 != null) ? tsBaseCharacter2.GetEntityIdNoBlueprint() : (owner as TsBaseVehicle).GetEntityIdNoBlueprint();
		TsAnimNotifyStatePositionBranchTarget._paramMap[key] = positionBranchTargetParams;
		return true;
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x00072F50 File Offset: 0x00071150
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

	// Token: 0x060014CF RID: 5327 RVA: 0x00072FF8 File Offset: 0x000711F8
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		int key = (tsBaseCharacter != null) ? tsBaseCharacter.GetEntityIdNoBlueprint() : tsBaseVehicle.GetEntityIdNoBlueprint();
		if (TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(key, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			return false;
		}
		if (positionBranchTargetParams.RefreshTarget(this.TsBlackboardKey, this.TsBlackboardType, this.TsBlackboardSocket))
		{
			this.MoveToTarget(frameDeltaTime, positionBranchTargetParams);
			positionBranchTargetParams.LastLocation.DeepCopy(positionBranchTargetParams.BaseActorComp.ActorLocationProxy);
		}
		positionBranchTargetParams.NowTime += frameDeltaTime;
		return true;
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x000730A8 File Offset: 0x000712A8
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

	// Token: 0x060014D1 RID: 5329 RVA: 0x00073148 File Offset: 0x00071348
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (TsAnimNotifyStatePositionBranchTarget._paramPool == null || TsAnimNotifyStatePositionBranchTarget._paramMap == null)
		{
			return false;
		}
		PositionBranchTargetParams positionBranchTargetParams;
		if (!TsAnimNotifyStatePositionBranchTarget._paramMap.TryGetValue(characterActorComponent.Entity.Id, out positionBranchTargetParams) || positionBranchTargetParams == null)
		{
			return false;
		}
		TsAnimNotifyStatePositionBranchTarget._paramMap.Remove(characterActorComponent.Entity.Id);
		positionBranchTargetParams.Clear();
		TsAnimNotifyStatePositionBranchTarget._paramPool.Add(positionBranchTargetParams);
		return true;
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x000731C4 File Offset: 0x000713C4
	private void GetTargetPos(PositionBranchTargetParams @params, Vector outVector)
	{
		if (@params.TargetPos != null)
		{
			outVector.DeepCopy(@params.TargetPos);
			if (this.OffsetByAbsolute)
			{
				this.TmpVector.DeepCopy(this.TsTargetOffset);
			}
			else
			{
				if (this.OffsetByOrientation)
				{
					outVector.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
				}
				else
				{
					@params.BaseActorComp.ActorLocationProxy.Subtraction(outVector, this.TmpVector);
				}
				this.TmpVector.ToOrientationQuat(this.TmpQuat);
				this.TmpQuat.RotateVector(this.TsTargetOffset, this.TmpVector);
			}
			outVector.AdditionEqual(this.TmpVector);
			return;
		}
		if (!string.IsNullOrEmpty(@params.SocketName))
		{
			CharacterActorComponent targetCharActorComp = @params.TargetCharActorComp;
			if (((targetCharActorComp != null) ? targetCharActorComp.Actor : null) != null)
			{
				FName inSocketName = FNameUtil.GetDynamicFName(@params.SocketName) ?? FName.NAME_None;
				FVectorDouble fvectorDouble = @params.TargetCharActorComp.Actor.Mesh.D_GetSocketLocation(inSocketName);
				outVector.FromUeVector(fvectorDouble);
			}
			else
			{
				outVector.DeepCopy(@params.TargetBaseActorComp.ActorLocationProxy);
			}
		}
		else
		{
			outVector.DeepCopy(@params.TargetBaseActorComp.ActorLocationProxy);
		}
		if (this.OffsetByAbsolute)
		{
			this.TmpVector.DeepCopy(this.TsTargetOffset);
		}
		else if (this.OffsetByOrientation)
		{
			outVector.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
			this.TmpVector.ToOrientationQuat(this.TmpQuat);
			this.TmpQuat.RotateVector(this.TsTargetOffset, this.TmpVector);
		}
		else
		{
			@params.TargetBaseActorComp.ActorQuatProxy.RotateVector(this.TsTargetOffset, this.TmpVector);
		}
		outVector.AdditionEqual(this.TmpVector);
		if (@params.TargetCharActorComp != null)
		{
			double num = GravityUtils.Instance.GetZnInGravityForActor(@params.TargetBaseActorComp, @params.TargetCharActorComp.FloorLocation) + (double)this.TsMinHeightFromTargetFloor;
			double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(@params.TargetBaseActorComp, outVector);
			if (num > znInGravityForActor)
			{
				GravityUtils.Instance.AddZnInGravityForActor(@params.TargetBaseActorComp, outVector, num - znInGravityForActor);
			}
		}
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x000733E4 File Offset: 0x000715E4
	private double GetTowardVector(PositionBranchTargetParams @params, Vector outVector)
	{
		this.GetTargetPos(@params, this.TargetPos);
		this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
		this.TargetPos.Subtraction(@params.LastLocation, this.TmpVector2);
		double num = this.TmpVector.DotProduct(this.TmpVector2);
		outVector.DeepCopy(this.TmpVector);
		if (this.TsIgnoreZ)
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(@params.BaseActorComp, outVector);
			if (num >= 0.0)
			{
				return outVector.Size();
			}
			return -1.0;
		}
		else if (this.TsIgnoreHorizontal)
		{
			GravityUtils.Instance.ConvertToVerticalVectorForActor(@params.BaseActorComp, outVector);
			if (num >= 0.0)
			{
				return outVector.Size();
			}
			return -1.0;
		}
		else
		{
			if (num >= 0.0)
			{
				return Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(@params.BaseActorComp, outVector));
			}
			return -1.0;
		}
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x000734EC File Offset: 0x000716EC
	private double GetRate(float delta, PositionBranchTargetParams @params)
	{
		float num = @params.NowTime + delta;
		double result;
		if (@params.TotalTime <= num)
		{
			result = 1.0;
		}
		else if (this.TsMoveCurve != null)
		{
			float floatValue = this.TsMoveCurve.GetFloatValue(@params.NowTime / @params.TotalTime);
			float floatValue2 = this.TsMoveCurve.GetFloatValue(num / @params.TotalTime);
			if (floatValue >= 1f)
			{
				return 0.0;
			}
			result = (double)((floatValue2 - floatValue) / (1f - floatValue));
		}
		else
		{
			double cubicValue = MathUtils.Instance.GetCubicValue((double)(@params.NowTime / @params.TotalTime));
			double cubicValue2 = MathUtils.Instance.GetCubicValue((double)(num / @params.TotalTime));
			if (cubicValue >= 1.0)
			{
				return 0.0;
			}
			result = (cubicValue2 - cubicValue) / (1.0 - cubicValue);
		}
		return result;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x000735D4 File Offset: 0x000717D4
	private unsafe void MoveToTarget(float delta, PositionBranchTargetParams @params)
	{
		double towardVector = this.GetTowardVector(@params, this.TmpVector);
		if (this.TsMinDistance > 0f && towardVector < (double)this.TsMinDistance)
		{
			return;
		}
		if (this.TsMaxDistance > 0f && towardVector > (double)this.TsMaxDistance)
		{
			return;
		}
		double num = (double)this.TsDistance;
		if (!this.TsIgnoreRadius)
		{
			num += (double)@params.BaseActorComp.ScaledRadius;
			if (@params.TargetCharActorComp != null && string.IsNullOrEmpty(@params.SocketName))
			{
				num += (double)@params.TargetCharActorComp.ScaledRadius;
			}
		}
		if (towardVector > 0.0001 && ((num < towardVector && this.TsAllowForwardMovement) || (num > towardVector && this.TsAllowReverseMovement)))
		{
			if (this.TsMaxSpeed <= 0f)
			{
				return;
			}
			double rate = this.GetRate(delta, @params);
			if (rate <= 0.0)
			{
				return;
			}
			double num2 = this.TmpVector.Size();
			double num3 = MathUtils.Instance.Clamp((num2 - num) * rate, (double)(-(double)this.TsMaxSpeed * delta), (double)(this.TsMaxSpeed * delta));
			this.TmpVector.MultiplyEqual(num3 / num2);
		}
		else
		{
			@params.LastLocation.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
			if (this.TsAlwaysMoveZ && !this.TsIgnoreZ)
			{
				double rate2 = this.GetRate(delta, @params);
				this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector2);
				double newZ = MathUtils.Instance.Clamp(GravityUtils.Instance.GetZnInGravityForActor(@params.BaseActorComp, this.TmpVector2) * rate2, (double)(-(double)this.TsMaxSpeed * delta), (double)(this.TsMaxSpeed * delta));
				GravityUtils.Instance.SetZnInGravityForActor(@params.BaseActorComp, this.TmpVector, newZ);
			}
			else
			{
				GravityUtils.Instance.ConvertToPlanarVectorForActor(@params.BaseActorComp, this.TmpVector);
			}
			if (this.TmpVector.SizeSquared() > 4000000.0)
			{
				this.TmpVector.Reset();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "LastLocation太远，很危险，无视掉";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "Actor";
				BaseActorComponent baseActorComp = @params.BaseActorComp;
				ptr = new ValueTuple<string, object>(item, (baseActorComp != null) ? baseActorComp.Owner : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Last", @params.LastLocation);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "ActorLast";
				BaseActorComponent baseActorComp2 = @params.BaseActorComp;
				ptr2 = new ValueTuple<string, object>(item2, (baseActorComp2 != null) ? baseActorComp2.LastActorLocation : null);
				ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
				string item3 = "Now";
				BaseActorComponent baseActorComp3 = @params.BaseActorComp;
				ptr3 = new ValueTuple<string, object>(item3, (baseActorComp3 != null) ? baseActorComp3.ActorLocationProxy : null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
		BaseActorComponent baseActorComp4 = @params.BaseActorComp;
		BaseMoveComponent baseMoveComponent = (baseActorComp4 != null) ? baseActorComp4.MoveComp : null;
		if (baseMoveComponent != null)
		{
			baseMoveComponent.MoveCharacter(this.TmpVector, delta, "TsAnimNotifyStatePositionBranchTarget");
			if (this.TsLookAtTarget)
			{
				this.TargetPos.Subtraction(@params.BaseActorComp.ActorLocationProxy, this.TmpVector);
				Vector gravityUp = baseMoveComponent.GravityUp;
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, gravityUp, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				@params.BaseActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStatePositionBranchTarget", false);
				return;
			}
		}
		else
		{
			this.TmpVector.AdditionEqual(@params.BaseActorComp.ActorLocationProxy);
			if (this.TsLookAtTarget)
			{
				BaseActorComponent baseActorComp5 = @params.BaseActorComp;
				Vector vector;
				if (baseActorComp5 == null)
				{
					vector = null;
				}
				else
				{
					VehicleMoveComponent vehicleMoveComp = baseActorComp5.VehicleMoveComp;
					vector = ((vehicleMoveComp != null) ? vehicleMoveComp.GravityUp : null);
				}
				Vector up = vector ?? Vector.UpVectorProxy;
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, up, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				BaseActorComponent baseActorComp6 = @params.BaseActorComp;
				if (baseActorComp6 == null)
				{
					return;
				}
				baseActorComp6.SetActorLocationAndRotation(this.TmpVector.ToUeVector(false), this.TmpRotator.ToUeRotator(), "TsAnimNotifyStatePositionBranchTarget", true, null);
				return;
			}
			else
			{
				BaseActorComponent baseActorComp7 = @params.BaseActorComp;
				if (baseActorComp7 == null)
				{
					return;
				}
				baseActorComp7.SetActorLocation(this.TmpVector.ToUeVector(false), "TsAnimNotifyStatePositionBranchTarget", true);
			}
		}
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x00073A10 File Offset: 0x00071C10
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

	// Token: 0x060014D7 RID: 5335 RVA: 0x00073A8B File Offset: 0x00071C8B
	protected override string GetNotifyName_Implementation()
	{
		return "位移吸附到目标位置";
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x00073A92 File Offset: 0x00071C92
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePositionBranchTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C");
		}
		return TsAnimNotifyStatePositionBranchTarget._ClassPtr;
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x00073AB8 File Offset: 0x00071CB8
	public TsAnimNotifyStatePositionBranchTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionBranchTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00073AE0 File Offset: 0x00071CE0
	public TsAnimNotifyStatePositionBranchTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionBranchTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x00073B14 File Offset: 0x00071D14
	protected TsAnimNotifyStatePositionBranchTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00073BAC File Offset: 0x00071DAC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x00073BE8 File Offset: 0x00071DE8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x00073C24 File Offset: 0x00071E24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x00073C57 File Offset: 0x00071E57
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EAF RID: 3759
	private const double INVALID_LAST_LOCATION_THRESHOLD_SQUARED = 4000000.0;

	// Token: 0x04000EB0 RID: 3760
	private bool IsInitialize;

	// Token: 0x04000EB1 RID: 3761
	[Nullable(2)]
	private UCurveFloat TsMoveCurve;

	// Token: 0x04000EB2 RID: 3762
	private float TsDistance;

	// Token: 0x04000EB3 RID: 3763
	private float TsMaxDistance;

	// Token: 0x04000EB4 RID: 3764
	private float TsMinDistance;

	// Token: 0x04000EB5 RID: 3765
	private float TsMaxSpeed;

	// Token: 0x04000EB6 RID: 3766
	private bool TsLookAtTarget;

	// Token: 0x04000EB7 RID: 3767
	private bool TsIgnoreZ;

	// Token: 0x04000EB8 RID: 3768
	private bool TsIgnoreHorizontal;

	// Token: 0x04000EB9 RID: 3769
	private bool TsAlwaysMoveZ;

	// Token: 0x04000EBA RID: 3770
	private bool TsIgnoreRadius;

	// Token: 0x04000EBB RID: 3771
	private bool TsIsShareTarget;

	// Token: 0x04000EBC RID: 3772
	private Vector TsTargetOffset = Vector.Create();

	// Token: 0x04000EBD RID: 3773
	private float TsMinHeightFromTargetFloor;

	// Token: 0x04000EBE RID: 3774
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x04000EBF RID: 3775
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04000EC0 RID: 3776
	private readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000EC1 RID: 3777
	private Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000EC2 RID: 3778
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000EC3 RID: 3779
	private bool TsAllowReverseMovement;

	// Token: 0x04000EC4 RID: 3780
	private bool TsAllowForwardMovement = true;

	// Token: 0x04000EC5 RID: 3781
	private string TsBlackboardKey = "";

	// Token: 0x04000EC6 RID: 3782
	private string TsBlackboardSocket = "";

	// Token: 0x04000EC7 RID: 3783
	private EAnsBranchTargetBlackboardType TsBlackboardType;

	// Token: 0x04000EC8 RID: 3784
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<PositionBranchTargetParams> _paramPool;

	// Token: 0x04000EC9 RID: 3785
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, PositionBranchTargetParams> _paramMap;

	// Token: 0x04000ECA RID: 3786
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionBranchTarget.TsAnimNotifyStatePositionBranchTarget_C";

	// Token: 0x04000ECB RID: 3787
	private static IntPtr _ClassPtr;

	// Token: 0x04000ECC RID: 3788
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000ECD RID: 3789
	private static int __PropertyOffset_MoveCurve;

	// Token: 0x04000ECE RID: 3790
	private static int __PropertyOffset_Distance;

	// Token: 0x04000ECF RID: 3791
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x04000ED0 RID: 3792
	private static int __PropertyOffset_是否永远面向目标;

	// Token: 0x04000ED1 RID: 3793
	private static int __PropertyOffset_忽略Z轴方向;

	// Token: 0x04000ED2 RID: 3794
	private static int __PropertyOffset_忽略水平方向;

	// Token: 0x04000ED3 RID: 3795
	private static int __PropertyOffset_永远修正Z轴;

	// Token: 0x04000ED4 RID: 3796
	private static int __PropertyOffset_忽略双方半径;

	// Token: 0x04000ED5 RID: 3797
	private static int __PropertyOffset_IsShareTarget;

	// Token: 0x04000ED6 RID: 3798
	private static int __PropertyOffset_TargetOffset;

	// Token: 0x04000ED7 RID: 3799
	private static int __PropertyOffset_TargetRotation;

	// Token: 0x04000ED8 RID: 3800
	private static int __PropertyOffset_OffsetByOrientation;

	// Token: 0x04000ED9 RID: 3801
	private static int __PropertyOffset_OffsetByAbsolute;

	// Token: 0x04000EDA RID: 3802
	private static int __PropertyOffset_MinHeightFromTargetFloor;

	// Token: 0x04000EDB RID: 3803
	private static int __PropertyOffset_允许反向移动;

	// Token: 0x04000EDC RID: 3804
	private static int __PropertyOffset_允许正向移动;

	// Token: 0x04000EDD RID: 3805
	private static int __PropertyOffset_黑板类型;

	// Token: 0x04000EDE RID: 3806
	private static int __PropertyOffset_黑板值;

	// Token: 0x04000EDF RID: 3807
	private static int __PropertyOffset_黑板目标Socket;

	// Token: 0x04000EE0 RID: 3808
	private static int __PropertyOffset_最小吸附距离;

	// Token: 0x04000EE1 RID: 3809
	private static int __PropertyOffset_最大吸附距离;
}
