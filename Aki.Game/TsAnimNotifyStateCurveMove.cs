using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000125 RID: 293
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCurveMove.TsAnimNotifyStateCurveMove_C")]
public class TsAnimNotifyStateCurveMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000634FC File Offset: 0x000616FC
	// (set) Token: 0x060011AA RID: 4522 RVA: 0x0006350C File Offset: 0x0006170C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_DebugMode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_DebugMode) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x060011AB RID: 4523 RVA: 0x00063520 File Offset: 0x00061720
	// (set) Token: 0x060011AC RID: 4524 RVA: 0x00063559 File Offset: 0x00061759
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSkillBehaviorCondition> 技能条件
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SSkillBehaviorCondition> result;
			if ((result = this._技能条件) == null)
			{
				result = (this._技能条件 = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_技能条件, this));
			}
			return result;
		}
		set
		{
			this.技能条件.CopyAssign(value);
		}
	}

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x060011AD RID: 4525 RVA: 0x00063567 File Offset: 0x00061767
	// (set) Token: 0x060011AE RID: 4526 RVA: 0x0006357B File Offset: 0x0006177B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 技能条件公式
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_技能条件公式);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_技能条件公式) = value;
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060011AF RID: 4527 RVA: 0x00063590 File Offset: 0x00061790
	// (set) Token: 0x060011B0 RID: 4528 RVA: 0x000635A0 File Offset: 0x000617A0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 无视障碍阻挡
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_无视障碍阻挡) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_无视障碍阻挡) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000635B4 File Offset: 0x000617B4
	// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000635ED File Offset: 0x000617ED
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath 运动轨迹曲线
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._运动轨迹曲线) == null)
			{
				result = (this._运动轨迹曲线 = new FSoftObjectPath(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动轨迹曲线, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动轨迹曲线, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00063615 File Offset: 0x00061815
	// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00063625 File Offset: 0x00061825
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 持续更新目标位置
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_持续更新目标位置) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_持续更新目标位置) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00063636 File Offset: 0x00061836
	// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00063646 File Offset: 0x00061846
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EPositionDatumTarget 位置基准目标
	{
		get
		{
			return (EPositionDatumTarget)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置基准目标));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置基准目标) = (byte)value;
		}
	}

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00063657 File Offset: 0x00061857
	// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0006366B File Offset: 0x0006186B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 基于目标骨骼位置
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_基于目标骨骼位置);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_基于目标骨骼位置) = value;
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00063680 File Offset: 0x00061880
	// (set) Token: 0x060011BA RID: 4538 RVA: 0x00063694 File Offset: 0x00061894
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName 目标参数
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标参数);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标参数) = value;
		}
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060011BB RID: 4539 RVA: 0x000636A9 File Offset: 0x000618A9
	// (set) Token: 0x060011BC RID: 4540 RVA: 0x000636B9 File Offset: 0x000618B9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECurveMoveTargetBlackboardType 目标参数类型
	{
		get
		{
			return (ECurveMoveTargetBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标参数类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标参数类型) = (byte)value;
		}
	}

	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x060011BD RID: 4541 RVA: 0x000636CA File Offset: 0x000618CA
	// (set) Token: 0x060011BE RID: 4542 RVA: 0x000636DA File Offset: 0x000618DA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EOffsetDirectionDatum 偏移方向基准
	{
		get
		{
			return (EOffsetDirectionDatum)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_偏移方向基准));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_偏移方向基准) = (byte)value;
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x060011BF RID: 4543 RVA: 0x000636EB File Offset: 0x000618EB
	// (set) Token: 0x060011C0 RID: 4544 RVA: 0x000636FB File Offset: 0x000618FB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 偏移基准消除重力分量
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_偏移基准消除重力分量) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_偏移基准消除重力分量) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0006370C File Offset: 0x0006190C
	// (set) Token: 0x060011C2 RID: 4546 RVA: 0x00063720 File Offset: 0x00061920
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 目标位置偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标位置偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_目标位置偏移) = value;
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00063735 File Offset: 0x00061935
	// (set) Token: 0x060011C4 RID: 4548 RVA: 0x00063745 File Offset: 0x00061945
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 位置修正
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置修正) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置修正) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00063758 File Offset: 0x00061958
	// (set) Token: 0x060011C6 RID: 4550 RVA: 0x00063791 File Offset: 0x00061991
	[UProperty(EPropertyFlags.CPF_None)]
	public SSkillBehaviorAction 位置修正配置
	{
		get
		{
			base.FastCheckIsValid();
			SSkillBehaviorAction result;
			if ((result = this._位置修正配置) == null)
			{
				result = (this._位置修正配置 = new SSkillBehaviorAction(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置修正配置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSkillBehaviorAction.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_位置修正配置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000637B9 File Offset: 0x000619B9
	// (set) Token: 0x060011C8 RID: 4552 RVA: 0x000637CD File Offset: 0x000619CD
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat 运动位置曲线
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCurveMove.__PropertyOffset_运动位置曲线);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateCurveMove.__PropertyOffset_运动位置曲线, value);
		}
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000637E2 File Offset: 0x000619E2
	// (set) Token: 0x060011CA RID: 4554 RVA: 0x000637F2 File Offset: 0x000619F2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EMovementProcessDirection 运动过程朝向
	{
		get
		{
			return (EMovementProcessDirection)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动过程朝向));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动过程朝向) = (byte)value;
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x060011CB RID: 4555 RVA: 0x00063803 File Offset: 0x00061A03
	// (set) Token: 0x060011CC RID: 4556 RVA: 0x00063813 File Offset: 0x00061A13
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 自动更新运动轨迹曲线关键点
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_自动更新运动轨迹曲线关键点) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_自动更新运动轨迹曲线关键点) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x060011CD RID: 4557 RVA: 0x00063824 File Offset: 0x00061A24
	// (set) Token: 0x060011CE RID: 4558 RVA: 0x0006385D File Offset: 0x00061A5D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FSplinePoint> 运动轨迹曲线关键点
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FSplinePoint> result;
			if ((result = this._运动轨迹曲线关键点) == null)
			{
				result = (this._运动轨迹曲线关键点 = new TArray<FSplinePoint>(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动轨迹曲线关键点, this));
			}
			return result;
		}
		set
		{
			this.运动轨迹曲线关键点.CopyAssign(value);
		}
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x060011CF RID: 4559 RVA: 0x0006386C File Offset: 0x00061A6C
	// (set) Token: 0x060011D0 RID: 4560 RVA: 0x000638A5 File Offset: 0x00061AA5
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FInterpCurvePointFloat> 运动轨迹曲线插值ReparamTable
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FInterpCurvePointFloat> result;
			if ((result = this._运动轨迹曲线插值ReparamTable) == null)
			{
				result = (this._运动轨迹曲线插值ReparamTable = new TArray<FInterpCurvePointFloat>(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_运动轨迹曲线插值ReparamTable, this));
			}
			return result;
		}
		set
		{
			this.运动轨迹曲线插值ReparamTable.CopyAssign(value);
		}
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000638B3 File Offset: 0x00061AB3
	// (set) Token: 0x060011D2 RID: 4562 RVA: 0x000638C3 File Offset: 0x00061AC3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 终点贴地检测
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_终点贴地检测) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_终点贴地检测) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000638D4 File Offset: 0x00061AD4
	// (set) Token: 0x060011D4 RID: 4564 RVA: 0x000638E4 File Offset: 0x00061AE4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 终点贴地检测距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_终点贴地检测距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_终点贴地检测距离) = value;
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000638F5 File Offset: 0x00061AF5
	// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00063905 File Offset: 0x00061B05
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最大位移距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_最大位移距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_最大位移距离) = value;
		}
	}

	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00063916 File Offset: 0x00061B16
	// (set) Token: 0x060011D8 RID: 4568 RVA: 0x00063926 File Offset: 0x00061B26
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最大移动速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_最大移动速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCurveMove.__PropertyOffset_最大移动速度) = value;
		}
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00063937 File Offset: 0x00061B37
	private void EditorUpdateSplineCurve()
	{
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x0006393C File Offset: 0x00061B3C
	private void Initialize()
	{
		this.SkillBehaviorCondition = this.技能条件;
		this.SkillBehaviorConditionFormula = (this.技能条件公式.ToString() ?? "");
		this.IgnoreObstacle = this.无视障碍阻挡;
		this.ContinuallyUpdateTargetPosition = this.持续更新目标位置;
		this.PositionDatumTarget = this.位置基准目标;
		this.TargetSocketPosition = (this.基于目标骨骼位置.ToString() ?? "None");
		this.TargetParam = (this.目标参数.ToString() ?? "None");
		this.TargetParamType = this.目标参数类型;
		this.OffsetDirectionDatum = this.偏移方向基准;
		this.ProjectionGravityDirection = this.偏移基准消除重力分量;
		this.MakePositionCorrection = this.位置修正;
		this.PositionCorrectionConfig = this.位置修正配置;
		this.MovementPositionCurve = this.运动位置曲线;
		this.MovementProcessDirection = this.运动过程朝向;
		this.EndLocationDetection = this.终点贴地检测;
		this.EndLocationDetectionDist = this.终点贴地检测距离;
		this.MaxMoveDistance = this.最大位移距离;
		this.MaxMoveSpeed = this.最大移动速度;
		if (this.运动轨迹曲线关键点 != null && this.SplineCurves == null)
		{
			this.SplineCurves = new SplineCurve(10);
		}
		FVector 目标位置偏移 = this.目标位置偏移;
		if (this.TargetPositionOffset != null)
		{
			global::Vector targetPositionOffset = this.TargetPositionOffset;
			FVector 目标位置偏移2 = this.目标位置偏移;
			FVectorDouble fvectorDouble = 目标位置偏移2;
			targetPositionOffset.DeepCopy(fvectorDouble);
			return;
		}
		FVector 目标位置偏移3 = this.目标位置偏移;
		this.TargetPositionOffset = global::Vector.Create(this.目标位置偏移);
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00063ACC File Offset: 0x00061CCC
	private void InitCacheVariable()
	{
		if (this.InitCacheVar)
		{
			return;
		}
		this.InitCacheVar = true;
		this.TmpVector = global::Vector.Create();
		this.TmpVector2 = global::Vector.Create();
		this.TmpVector3 = global::Vector.Create();
		this.TmpVector4 = global::Vector.Create();
		this.TmpRotator = global::Rotator.Create();
		this.TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		this.TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
		this.TmpTransform = global::Transform.Create();
		this.ParamMap = new Dictionary<int, CurveMoveParams>();
		this.ParamPool = new List<CurveMoveParams>();
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00063BA0 File Offset: 0x00061DA0
	[return: Nullable(2)]
	private CurveMoveParams InitCharacterParam(CharacterActorComponent actorComp, double totalDuration)
	{
		CharacterSkillComponent component = actorComp.Entity.GetComponent<CharacterSkillComponent>();
		if (component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "TsAnimNotifyStateCurveMove.InitCharacterParam没有技能组件";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", actorComp.Actor.GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		CurveMoveParams curveMoveParams;
		if (!this.ParamMap.TryGetValue(actorComp.Entity.Id, out curveMoveParams))
		{
			curveMoveParams = ((this.ParamPool.Count > 0) ? this.ParamPool[this.ParamPool.Count - 1] : new CurveMoveParams());
			if (this.ParamPool.Count > 0)
			{
				this.ParamPool.RemoveAt(this.ParamPool.Count - 1);
			}
		}
		curveMoveParams.InitLocation.DeepCopy(actorComp.ActorLocationProxy);
		curveMoveParams.CharActorComp = actorComp;
		curveMoveParams.CharUnifiedComp = actorComp.Entity.GetComponent<CharacterUnifiedStateComponent>();
		curveMoveParams.CharSkillComp = component;
		curveMoveParams.RefreshTarget(this.TargetParam, this.TargetSocketPosition, this.PositionDatumTarget, new ECurveMoveTargetBlackboardType?(this.TargetParamType));
		curveMoveParams.LastSplineDistance = 0f;
		curveMoveParams.NowTime = 0.0;
		curveMoveParams.TotalTime = totalDuration;
		CurveMoveParams curveMoveParams2 = curveMoveParams;
		UCharacterMovementComponent characterMovement = curveMoveParams.CharActorComp.MoveComp.CharacterMovement;
		bool flyingMove;
		if (((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null) != EMovementMode.MOVE_Walking)
		{
			UCharacterMovementComponent characterMovement2 = curveMoveParams.CharActorComp.MoveComp.CharacterMovement;
			flyingMove = (((characterMovement2 != null) ? new TEnumAsByte<EMovementMode>?(characterMovement2.MovementMode) : null) != EMovementMode.MOVE_NavWalking);
		}
		else
		{
			flyingMove = false;
		}
		curveMoveParams2.FlyingMove = flyingMove;
		this.ParamMap.Add(actorComp.Entity.Id, curveMoveParams);
		if (curveMoveParams.TargetActorComp == null)
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove.InitCharacterParam没有目标", default(ReadOnlySpan<ValueTuple<string, object>>));
			return curveMoveParams;
		}
		return curveMoveParams;
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00063DB8 File Offset: 0x00061FB8
	private bool CheckUseCondition(TsBaseCharacter owner)
	{
		TArray<SSkillBehaviorCondition> skillBehaviorCondition = this.SkillBehaviorCondition;
		if (skillBehaviorCondition == null || skillBehaviorCondition.Num() == 0)
		{
			return true;
		}
		Entity entity = owner.CharacterActorComponent.Entity;
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
		Skill skill = (component2 != null) ? component2.CurrentSkill : null;
		if (component == null || skill == null)
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove.CheckUseCondition没有技能组件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		BeginSkillBehaviorConditionParam param = new BeginSkillBehaviorConditionParam
		{
			Entity = entity,
			SkillComponent = component,
			Skill = skill
		};
		if (!global::SkillBehaviorCondition.SatisfyGroup(this.SkillBehaviorCondition, this.SkillBehaviorConditionFormula, param))
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove.CheckUseCondition不满足使用条件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00063E78 File Offset: 0x00062078
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

	// Token: 0x060011DF RID: 4575 RVA: 0x00063F20 File Offset: 0x00062120
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (GlobalData.GameInstance == null)
		{
			this.EditorUpdateSplineCurve();
			return false;
		}
		this.InitCacheVariable();
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return false;
		}
		this.Initialize();
		CurveMoveParams curveMoveParams = this.InitCharacterParam(characterActorComponent, (double)totalDuration);
		if (curveMoveParams == null)
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove初始化角色参数失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (curveMoveParams.AllowMovement)
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove正在移动中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		SplineCurve splineCurves = this.SplineCurves;
		if (splineCurves != null)
		{
			splineCurves.Init(this.运动轨迹曲线关键点, this.运动轨迹曲线插值ReparamTable, null, null);
		}
		if (this.SkillBehaviorCondition != null && !this.CheckUseCondition(owner as TsBaseCharacter))
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "TsAnimNotifyStateCurveMove不满足技能使用条件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		global::Vector targetOffset = curveMoveParams.TargetOffset;
		FVector 目标位置偏移 = this.目标位置偏移;
		FVectorDouble fvectorDouble = 目标位置偏移;
		targetOffset.DeepCopy(fvectorDouble);
		this.GetTargetPos(curveMoveParams, curveMoveParams.TargetPos);
		curveMoveParams.LastTargetPos.DeepCopy(curveMoveParams.TargetPos);
		double towardVector = this.GetTowardVector(curveMoveParams, curveMoveParams.TargetVec);
		if (towardVector < 50.0 || curveMoveParams.TargetVec.SizeSquared2D() < 2500.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "TsAnimNotifyStateCurveMove距离异常，不移动";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CurrentLocation", curveMoveParams.CharActorComp.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetPos", curveMoveParams.TargetPos);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dist", towardVector);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("distSquared2D", curveMoveParams.TargetVec.SizeSquared2D());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return false;
		}
		if (this.IgnoreObstacle)
		{
			CharacterMoveComponent component = characterActorComponent.Entity.GetComponent<CharacterMoveComponent>();
			if (component != null)
			{
				component.SetStepHeight(curveMoveParams.CharActorComp.HalfHeight);
			}
		}
		if (this.运动轨迹曲线关键点 != null && this.SplineCurves != null && this.InitSplineTransform(curveMoveParams))
		{
			curveMoveParams.AlongStraightLine = false;
			curveMoveParams.AllowMovement = true;
			return true;
		}
		curveMoveParams.AlongStraightLine = true;
		curveMoveParams.AllowMovement = true;
		return true;
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x0006418C File Offset: 0x0006238C
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

	// Token: 0x060011E1 RID: 4577 RVA: 0x00064234 File Offset: 0x00062434
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		CurveMoveParams valueOrDefault = this.ParamMap.GetValueOrDefault(characterActorComponent.Entity.Id);
		if (valueOrDefault == null || !valueOrDefault.AllowMovement)
		{
			return false;
		}
		CharacterSkillComponent charSkillComp = valueOrDefault.CharSkillComp;
		if (charSkillComp != null && charSkillComp.IsSkillMontageInvalid(animation.GetName()))
		{
			return false;
		}
		valueOrDefault.CanSetActorTargetPos = false;
		if (this.SplineCurves != null && !valueOrDefault.AlongStraightLine)
		{
			valueOrDefault.RefreshTarget(this.TargetParam, this.TargetSocketPosition, this.PositionDatumTarget, new ECurveMoveTargetBlackboardType?(this.TargetParamType));
			if (valueOrDefault.TargetActorComp != null)
			{
				this.MoveToTargetAlongSpline((double)frameDeltaTime, valueOrDefault);
				valueOrDefault.LastLocation.DeepCopy(valueOrDefault.CharActorComp.ActorLocationProxy);
			}
			valueOrDefault.NowTime += (double)frameDeltaTime;
			if (this.DebugMode)
			{
				int splinePointsNum = this.SplineCurves.GetSplinePointsNum();
				for (int i = 0; i < splinePointsNum; i++)
				{
					this.SplineCurves.GetWorldLocationAtSplinePoint(i, this.TmpVector);
					this.DebugDraw(this.TmpVector.ToUeVector(false), ColorUtils.LinearYellow, 30f, 5);
				}
			}
			return true;
		}
		if (valueOrDefault.AlongStraightLine)
		{
			valueOrDefault.RefreshTarget(this.TargetParam, this.TargetSocketPosition, this.PositionDatumTarget, new ECurveMoveTargetBlackboardType?(this.TargetParamType));
			if (valueOrDefault.TargetActorComp != null)
			{
				this.MoveToTarget((double)frameDeltaTime, valueOrDefault);
				valueOrDefault.LastLocation.DeepCopy(valueOrDefault.CharActorComp.ActorLocationProxy);
			}
			valueOrDefault.NowTime += (double)frameDeltaTime;
			return true;
		}
		return false;
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x000643DC File Offset: 0x000625DC
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

	// Token: 0x060011E3 RID: 4579 RVA: 0x0006447C File Offset: 0x0006267C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		CurveMoveParams valueOrDefault = this.ParamMap.GetValueOrDefault(characterActorComponent.Entity.Id);
		if (valueOrDefault == null)
		{
			return false;
		}
		if (this.IgnoreObstacle)
		{
			CharacterMoveComponent component = characterActorComponent.Entity.GetComponent<CharacterMoveComponent>();
			if (component != null)
			{
				component.ResetStepHeight();
			}
		}
		valueOrDefault.AllowMovement = false;
		if (this.IgnoreObstacle)
		{
			if (valueOrDefault.CanSetActorTargetPos && global::Vector.Dist(valueOrDefault.TargetPos, valueOrDefault.CharActorComp.ActorLocationProxy) > 50.0)
			{
				valueOrDefault.CharActorComp.SetActorLocation(valueOrDefault.TargetPos.ToUeVector(false), "TsAnimNotifyStateCurveMove.技能曲线移动穿越障碍物结束", false);
				Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "技能曲线移动穿越障碍物结束SetActorLocation到终点", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			valueOrDefault.CanSetActorTargetPos = false;
		}
		this.ParamMap.Remove(characterActorComponent.Entity.Id);
		valueOrDefault.Clear();
		this.ParamPool.Add(valueOrDefault);
		return true;
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00064584 File Offset: 0x00062784
	private unsafe bool InitSplineTransform(CurveMoveParams @params)
	{
		SplineCurve splineCurves = this.SplineCurves;
		float? num = (splineCurves != null) ? new float?(splineCurves.GetSplineLength()) : null;
		if (num != null)
		{
			float? num2 = num;
			float num3 = 0f;
			if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
			{
				double num4 = @params.TargetVec.Size();
				int splinePointsNum = this.SplineCurves.GetSplinePointsNum();
				this.SplineCurves.GetWorldLocationAtSplinePoint(0, this.TmpVector3);
				this.SplineCurves.GetWorldLocationAtSplinePoint(splinePointsNum - 1, this.TmpVector2);
				this.TmpVector3.SubtractionEqual(this.TmpVector2);
				double num5 = this.TmpVector3.Size();
				num2 = num;
				num3 = 100f;
				if ((num2.GetValueOrDefault() < num3 & num2 != null) || num4 < 100.0 || num5 < 1.0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "TsAnimNotifyStateCurveMove.样条总长度太短";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("splineLen", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("distance", num4);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("splineLineLength", num5);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return false;
				}
				this.TmpVector.DeepCopy(global::Vector.ForwardVectorProxy);
				MathUtils.Instance.LookRotationForwardFirst(@params.TargetVec, global::Vector.UpVectorProxy, this.TmpQuat);
				MathUtils.Instance.LookRotationForwardFirst(this.TmpVector3, global::Vector.UpVectorProxy, this.TmpQuat2);
				this.TmpQuat2.Inverse(this.TmpQuat2);
				this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector);
				this.TmpQuat2.RotateVector(this.TmpVector, this.TmpVector);
				this.TmpVector.UnaryNegation(this.TmpVector);
				this.TmpVector.Z = -this.TmpVector.Z;
				this.TmpVector.ToOrientationQuat(this.TmpQuat2);
				double num6 = num4 / num5;
				this.TmpVector2.DeepCopy(this.SplineCurves.SplineTransform.GetScale3D());
				if (num6 > 0.0001)
				{
					this.TmpVector2.MultiplyEqual(num6);
				}
				if (this.DebugMode)
				{
					int num7 = 30;
					this.DebugDraw(@params.TargetPos.ToUeVector(false), ColorUtils.LinearBlack, (float)(num7 + 10), 5);
				}
				this.TmpTransform.Set(@params.InitLocation, this.TmpQuat2, this.TmpVector2);
				this.SplineCurves.SetSplineTransform(this.TmpTransform, false);
				this.SplineCurves.GetWorldLocationAtSplinePoint(0, this.TmpVector);
				double num8 = global::Vector.DistSquared(this.TmpVector, @params.InitLocation);
				double num9 = global::Vector.DistSquared(this.TmpVector, @params.CharActorComp.ActorLocationProxy);
				if (num8 > 10000.0 || num9 > 10000.0)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Movement;
					ELogAuthor author2 = ELogAuthor.CWZ;
					string message2 = "初始点位置和样条第一个点位置距离太远了。";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("样条点和初始点距离Squared", num8);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("样条点和当前坐标距离Squared", num9);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("startLocation", this.TmpVector);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3);
					string item = "ActorLocation";
					CharacterActorComponent charActorComp = @params.CharActorComp;
					ptr = new ValueTuple<string, object>(item, (charActorComp != null) ? charActorComp.ActorLocationProxy : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					return false;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00064944 File Offset: 0x00062B44
	private unsafe void GetTargetPos(CurveMoveParams @params, global::Vector outVector)
	{
		if (this.TargetParamType == ECurveMoveTargetBlackboardType.LocationVector)
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(@params.CharActorComp.Entity.Id, this.TargetParam);
			if (vectorValueByEntity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "TsAnimNotifyStateCurveMove 传入目标黑板类型为坐标点，但是黑板里没有这个Vector";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", @params.CharActorComp.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Key", this.TargetParam);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Value", vectorValueByEntity);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				outVector.DeepCopy(@params.CharActorComp.ActorLocationProxy);
				return;
			}
			outVector.Set((double)vectorValueByEntity.X, (double)vectorValueByEntity.Y, (double)vectorValueByEntity.Z);
		}
		else
		{
			if (!@params.RefreshTarget(this.TargetParam, this.TargetSocketPosition, this.PositionDatumTarget, new ECurveMoveTargetBlackboardType?(this.TargetParamType)))
			{
				outVector.DeepCopy(@params.CharActorComp.ActorLocationProxy);
				return;
			}
			if (@params.SocketName != null && @params.SocketName.Length > 0)
			{
				CharacterActorComponent targetCharActorComp = @params.TargetCharActorComp;
				if (((targetCharActorComp != null) ? targetCharActorComp.Actor : null) != null)
				{
					FVectorDouble fvectorDouble = @params.TargetCharActorComp.Actor.Mesh.D_GetSocketLocation(FNameUtil.GetDynamicFName(@params.SocketName).Value);
					outVector.FromUeVector(fvectorDouble);
				}
				else
				{
					outVector.DeepCopy(@params.TargetActorComp.ActorLocationProxy);
				}
			}
			else
			{
				outVector.DeepCopy(@params.TargetActorComp.ActorLocationProxy);
			}
		}
		if (this.TargetPositionOffset == null)
		{
			return;
		}
		if (this.DebugMode)
		{
			this.DebugDraw(outVector.ToUeVector(false), new FLinearColor(1f, 0.5f, 0f, 0f), 30f, 5);
		}
		@params.TargetOffset.DeepCopy(this.TargetPositionOffset);
		this.TmpVector.Reset();
		switch (this.OffsetDirectionDatum)
		{
		case EOffsetDirectionDatum.User:
			if (@params.CharActorComp != null)
			{
				this.TmpVector.DeepCopy(@params.CharActorComp.ActorForwardProxy);
			}
			break;
		case EOffsetDirectionDatum.TargetPosition:
			if (this.TargetParamType == ECurveMoveTargetBlackboardType.LocationVector)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "TsAnimNotifyStateCurveMove 传入目标黑板类型为坐标点，偏移方向基准不应该选TargetPosition";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", @params.CharActorComp.Entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Key", this.TargetParam);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			else if (@params.TargetActorComp != null)
			{
				this.TmpVector.DeepCopy(@params.TargetActorComp.ActorForwardProxy);
			}
			break;
		case EOffsetDirectionDatum.UserToTarget:
			if (@params.CharActorComp != null)
			{
				if (this.TargetParamType == ECurveMoveTargetBlackboardType.LocationVector)
				{
					this.TmpVector.DeepCopy(outVector);
					this.TmpVector.SubtractionEqual(@params.CharActorComp.ActorLocationProxy);
				}
				else if (@params.TargetActorComp != null)
				{
					this.TmpVector.DeepCopy(@params.TargetActorComp.ActorLocationProxy);
					this.TmpVector.SubtractionEqual(@params.CharActorComp.ActorLocationProxy);
				}
			}
			break;
		}
		if (!this.TmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			if (this.ProjectionGravityDirection)
			{
				GravityUtils.Instance.ConvertToPlanarVectorForActor(@params.CharActorComp, this.TmpVector);
			}
			this.TmpVector.Normalize(9.99999993922529E-09);
			this.TmpVector.Rotation(this.TmpRotator);
			this.TmpRotator.Quaternion(this.TmpQuat);
			this.TmpQuat.RotateVector(@params.TargetOffset, @params.TargetOffset);
		}
		outVector.AdditionEqual(@params.TargetOffset);
		if (this.EndLocationDetection && @params.CharActorComp != null)
		{
			this.DetectFloor(@params.CharActorComp, outVector);
		}
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00064D50 File Offset: 0x00062F50
	private bool DetectFloor(CharacterActorComponent actor, global::Vector @out)
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = actor.Actor;
		actorTrace.Radius = actor.ScaledRadius;
		if (this.DebugMode)
		{
			actorTrace.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
		}
		actorTrace.ActorsToIgnore.Empty(true);
		actorTrace.ActorsToIgnore.Add(actor.Actor);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		this.TmpVector.DeepCopy(@out);
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector);
		this.TmpVector.DeepCopy(@out);
		GravityUtils.Instance.AddZnInGravityForActor(actor, this.TmpVector, (double)(-(double)this.EndLocationDetectionDist));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector);
		if (TraceElementCommon.Instance.ShapeTrace(actor.Actor.CapsuleComponent, actorTrace, "TsAnimNotifyStateCurveMove", "TsAnimNotifyStateCurveMove"))
		{
			TraceElementCommon.Instance.GetHitLocation(actorTrace.HitResult, 0, @out);
			GravityUtils.Instance.AddZnInGravityForActor(actor, @out, (double)actor.ScaledHalfHeight);
			if (this.DebugMode)
			{
				this.DebugDraw(@out.ToUeVector(false), ColorUtils.LinearCyan, 30f, 5);
				actorTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			}
			return true;
		}
		if (this.DebugMode)
		{
			actorTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
		}
		return false;
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00064ED0 File Offset: 0x000630D0
	private void PositionCorrection(CurveMoveParams @params, global::Vector targetPos, global::Vector outPos)
	{
		if (!this.MakePositionCorrection || this.PositionCorrectionConfig == null || this.PositionCorrectionConfig.ActionType != ESkillBehaviorActionType.设置位置)
		{
			return;
		}
		CharacterActorComponent charActorComp = @params.CharActorComp;
		FVectorDouble to = targetPos.ToUeVector(false);
		FVectorDouble fvectorDouble = charActorComp.ActorForward;
		global::Vector tmpVector = this.TmpVector2;
		tmpVector.DeepCopy(to);
		FVector locationOffset = this.PositionCorrectionConfig.LocationOffset;
		FVector fvector = this.PositionCorrectionConfig.LocationOffset;
		if (!fvector.IsNearlyZero(0.0001f))
		{
			switch (this.PositionCorrectionConfig.LocationType)
			{
			case 1:
				if (!(!@params.CharSkillComp) && @params.CharSkillComp.SkillTarget != null)
				{
					ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection = SkillBehaviorMisc.GetLocationAndDirection(@params.CharSkillComp.SkillTarget.Entity.GetComponent<BaseActorComponent>().Owner);
					to = locationAndDirection.Item1;
					fvectorDouble = locationAndDirection.Item2;
					to = @params.CharSkillComp.GetTargetTransform().GetLocation();
				}
				break;
			case 2:
			{
				EntityHandle currentTarget = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<CharacterLockOnComponent>().GetCurrentTarget();
				if (currentTarget != null)
				{
					ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection2 = SkillBehaviorMisc.GetLocationAndDirection(currentTarget.Entity.GetComponent<BaseActorComponent>().Owner);
					to = locationAndDirection2.Item1;
					fvectorDouble = locationAndDirection2.Item2;
				}
				break;
			}
			case 3:
			{
				ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection3 = SkillBehaviorMisc.GetLocationAndDirection(Global.BaseCharacter);
				to = locationAndDirection3.Item1;
				fvectorDouble = locationAndDirection3.Item2;
				break;
			}
			case 4:
				if (@params.CharActorComp != null)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(@params.CharActorComp.Entity.GetComponent<CreatureDataComponent>().GetSummonerId());
					BaseActorComponent baseActorComponent;
					if (entity == null)
					{
						baseActorComponent = null;
					}
					else
					{
						WorldEntity entity2 = entity.Entity;
						baseActorComponent = ((entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null);
					}
					ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection4 = SkillBehaviorMisc.GetLocationAndDirection(baseActorComponent.Owner);
					to = locationAndDirection4.Item1;
					fvectorDouble = locationAndDirection4.Item2;
				}
				break;
			case 5:
			{
				ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection5 = SkillBehaviorMisc.GetLocationAndDirection(CameraModel.Instance.MainModel.FightCamera.GetComponent<FightCameraDisplayComponent>().CameraActor);
				to = locationAndDirection5.Item1;
				fvectorDouble = locationAndDirection5.Item2;
				break;
			}
			case 6:
				if (@params.CharActorComp != null)
				{
					to = WorldGlobal.ToUeVector(BlackboardController.Instance.GetVectorValueByEntity(@params.CharActorComp.Entity.Id, this.TargetParam));
				}
				break;
			case 7:
				if (@params.CharActorComp != null)
				{
					int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(@params.CharActorComp.Entity.Id, this.TargetParam);
					Entity entity3 = EntitySystem.Instance.Get(intValueByEntity.Value);
					if (entity3 != null && entity3.Valid)
					{
						ValueTuple<FVectorDouble, FVectorDouble> locationAndDirection6 = SkillBehaviorMisc.GetLocationAndDirection(entity3.GetComponent<BulletActorComponent>().Owner);
						to = locationAndDirection6.Item1;
						fvectorDouble = locationAndDirection6.Item2;
					}
				}
				break;
			}
			switch (this.PositionCorrectionConfig.LocationForwardType)
			{
			case 1:
				fvectorDouble = charActorComp.Actor.D_GetActorForwardVector();
				break;
			case 2:
			{
				FVectorDouble fvectorDouble2 = charActorComp.ActorLocation;
				FVectorDouble fvectorDouble3 = fvectorDouble2 - to;
				fvectorDouble.Set(fvectorDouble3.X, fvectorDouble3.Y, 0.0);
				break;
			}
			case 3:
			{
				FVectorDouble fvectorDouble2 = Global.CharacterCameraManager.D_GetCameraLocation();
				FVectorDouble fvectorDouble4 = to - fvectorDouble2;
				fvectorDouble.Set(fvectorDouble4.X, fvectorDouble4.Y, 0.0);
				break;
			}
			}
			tmpVector.DeepCopy(to);
			FRotator frotator = fvectorDouble.Rotation();
			fvector = global::Vector.OneVectorDouble;
			FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref to, ref fvector);
			FVectorDouble fvectorDouble5 = UKismetMathLibrary.Conv_VectorToVectorDouble(this.PositionCorrectionConfig.LocationOffset);
			to = ftransformDouble.TransformPositionNoScale(fvectorDouble5);
			bool debugMode = this.DebugMode;
		}
		if (this.PositionCorrectionConfig.Restrict)
		{
			FVectorDouble from = charActorComp.ActorLocation;
			switch (this.PositionCorrectionConfig.RestrictType)
			{
			case 0:
				from = Global.BaseCharacter.D_K2_GetActorLocation();
				break;
			case 2:
				if (charActorComp.Entity.GetComponent<CreatureDataComponent>().IsMonster())
				{
					Aki.Protocol.Vector initLocation = charActorComp.GetInitLocation();
					from.Set((double)initLocation.X, (double)initLocation.Y, (double)initLocation.Z);
				}
				break;
			}
			FVectorDouble fvectorDouble2 = to - from;
			double num = fvectorDouble2.Size();
			if (num > (double)this.PositionCorrectionConfig.RestrictDistance)
			{
				double num2 = (double)this.PositionCorrectionConfig.RestrictDistance / num;
				MathUtils.Instance.LerpVector(from, to, (float)num2, ref to);
				bool debugMode2 = this.DebugMode;
			}
		}
		global::Vector vector = this.TmpVector3;
		vector.DeepCopy(to);
		if (this.PositionCorrectionConfig.BestSpot)
		{
			byte b = this.PositionCorrectionConfig.Strategy;
			if (b != 0)
			{
				if (b == 2)
				{
					bool flag = false;
					this.TmpVector4.Reset();
					global::Vector tmpVector2 = this.TmpVector;
					global::Vector tmpVector3 = this.TmpVector4;
					vector.Subtraction(tmpVector, tmpVector2);
					foreach (int num3 in TsAnimNotifyStateCurveMove.angles)
					{
						tmpVector2.RotateAngleAxis((double)num3, global::Vector.UpVectorProxy, tmpVector3);
						tmpVector.Addition(tmpVector3, vector);
						ValueTuple<UKuroHitResult, global::Vector>? valueTuple = SkillBehaviorMisc.TraceWall(charActorComp, tmpVector, vector, this.PositionCorrectionConfig.DebugTrace);
						if (valueTuple == null)
						{
							return;
						}
						if (valueTuple.Value.Item1 == null)
						{
							flag = true;
							vector = valueTuple.Value.Item2;
							break;
						}
					}
					if (!flag)
					{
						return;
					}
				}
			}
			else
			{
				ValueTuple<UKuroHitResult, global::Vector>? valueTuple2 = SkillBehaviorMisc.TraceWall(charActorComp, tmpVector, vector, this.PositionCorrectionConfig.DebugTrace);
				if (valueTuple2 == null)
				{
					return;
				}
				vector = valueTuple2.Value.Item2;
			}
			ValueTuple<bool, global::Vector> valueTuple3 = SkillBehaviorMisc.TraceGroundWithGravity(charActorComp, vector, this.PositionCorrectionConfig.DebugTrace, 2500f);
			if (!valueTuple3.Item1)
			{
				return;
			}
			vector = valueTuple3.Item2;
			@params.CanSetActorTargetPos = true;
			bool debugMode3 = this.DebugMode;
		}
		to = vector.ToUeVector(false);
		FVectorDouble queryExtent = new FVectorDouble();
		if (this.PositionCorrectionConfig.Navigation > 0 && !UNavigationSystemV1.D_K2_ProjectPointToNavigation(GlobalData.World, to, ref queryExtent, null, null, queryExtent, -1.0))
		{
			FVectorDouble fvectorDouble6 = new FVectorDouble();
			if (UNavigationSystemV1.D_K2_GetRandomLocationInNavigableRadius(GlobalData.World, to, ref fvectorDouble6, (float)this.PositionCorrectionConfig.Navigation, null, default(TSubclassOf<UNavigationQueryFilter>)))
			{
				outPos.DeepCopy(fvectorDouble6);
			}
			@params.CanSetActorTargetPos = true;
			return;
		}
		this.TmpVector.DeepCopy(to);
		this.TmpVector.SubtractionEqual(tmpVector);
		targetPos.Addition(this.TmpVector, outPos);
		bool debugMode4 = this.DebugMode;
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00065560 File Offset: 0x00063760
	private unsafe double GetTowardVector(CurveMoveParams @params, global::Vector outVector)
	{
		if (this.MakePositionCorrection && this.PositionCorrectionConfig != null)
		{
			if (this.DebugMode)
			{
				int num = 30;
				this.DebugDraw(@params.TargetPos.ToUeVector(false), new FLinearColor(1f, 0.5f, 1f, 0f), (float)(num + 5), 5);
			}
			this.PositionCorrection(@params, @params.LastTargetPos, @params.TargetPos);
		}
		CharacterUnifiedStateComponent charUnifiedComp = @params.CharUnifiedComp;
		if (charUnifiedComp != null && charUnifiedComp.PositionState == global::ECharPositionState.Ground && global::Vector.DistSquared2D(@params.TargetPos, @params.CharActorComp.ActorLocationProxy) < 1.0)
		{
			return -1.0;
		}
		if (this.DebugMode)
		{
			int num2 = 30;
			this.DebugDraw(@params.TargetPos.ToUeVector(false), ColorUtils.LinearRed, (float)(num2 + 10), 5);
		}
		@params.TargetPos.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector);
		@params.TargetPos.Subtraction(@params.LastLocation, this.TmpVector2);
		double num3 = this.TmpVector.DotProduct(this.TmpVector2);
		double num4 = this.TmpVector.Size();
		if (num4 > (double)this.MaxMoveDistance)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "目标点距离太远了，不动";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dist", num4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("current", @params.CharActorComp.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetPos", @params.TargetPos);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return -1.0;
		}
		outVector.DeepCopy(this.TmpVector);
		if (num3 < 0.0)
		{
			Log.Instance.Warn(ELogModule.Movement, ELogAuthor.CWZ, "和上一次移动相比在后退", default(ReadOnlySpan<ValueTuple<string, object>>));
			return -1.0;
		}
		return num4;
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00065768 File Offset: 0x00063968
	private unsafe double GetRate(double delta, CurveMoveParams @params)
	{
		double num = @params.NowTime + delta;
		double num2;
		if (@params.TotalTime <= num)
		{
			num2 = 1.0;
		}
		else if (this.MovementPositionCurve != null)
		{
			num2 = (double)this.MovementPositionCurve.GetFloatValue((float)(@params.NowTime / @params.TotalTime));
		}
		else
		{
			num2 = MathUtils.Instance.GetCubicValue(@params.NowTime / @params.TotalTime);
		}
		if (num2 > 1.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "rate > 1";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("params.NowTime", @params.NowTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("params.TotalTime", @params.TotalTime);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 1.0;
		}
		return num2;
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00065858 File Offset: 0x00063A58
	private unsafe void MoveToTarget(double delta, CurveMoveParams @params)
	{
		@params.TargetPos.DeepCopy(@params.LastTargetPos);
		if (this.ContinuallyUpdateTargetPosition)
		{
			@params.LastTargetPos.DeepCopy(@params.TargetPos);
			this.GetTargetPos(@params, @params.TargetPos);
		}
		double towardVector = this.GetTowardVector(@params, @params.TargetVec);
		double rate = this.GetRate(delta, @params);
		if (rate <= 0.0 || towardVector < 0.0 || @params.TargetVec.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		global::Vector.Lerp(@params.InitLocation, @params.TargetPos, rate, @params.TargetVec);
		@params.TargetVec.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector3);
		if (this.DebugMode)
		{
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, @params.CharActorComp.ActorLocation, @params.TargetVec.ToUeVector(false), (float)this.TmpVector3.Size(), ColorUtils.LinearWhite, 0f, 0f);
		}
		@params.TargetVec.DeepCopy(this.TmpVector3);
		double num = @params.TargetVec.Size();
		if ((double)this.MaxMoveSpeed > 0.0001)
		{
			num = Math.Min(num, delta * (double)this.MaxMoveSpeed);
		}
		CharacterUnifiedStateComponent charUnifiedComp = @params.CharUnifiedComp;
		if (charUnifiedComp != null && charUnifiedComp.PositionState == global::ECharPositionState.Ground && num < 1.0)
		{
			return;
		}
		this.TmpVector3.Normalize(9.99999993922529E-09);
		this.TmpVector3.MultiplyEqual(num);
		@params.LastLocation.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector);
		if (this.TmpVector.SizeSquared() > 1000000.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "LastLocation太远，很危险，无视掉";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			CharacterActorComponent charActorComp = @params.CharActorComp;
			object item2;
			if (charActorComp == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = charActorComp.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Last", @params.LastLocation);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item3 = "ActorLast";
			CharacterActorComponent charActorComp2 = @params.CharActorComp;
			ptr2 = new ValueTuple<string, object>(item3, (charActorComp2 != null) ? charActorComp2.LastActorLocation : null);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item4 = "Now";
			CharacterActorComponent charActorComp3 = @params.CharActorComp;
			ptr3 = new ValueTuple<string, object>(item4, (charActorComp3 != null) ? charActorComp3.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TargetVec", @params.TargetVec);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("TmpVector", this.TmpVector);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("TmpVector3", this.TmpVector3);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			this.TmpVector3.Reset();
		}
		if (this.DebugMode)
		{
			this.TmpVector2.DeepCopy(@params.CharActorComp.ActorLocationProxy);
			this.TmpVector2.AdditionEqual(this.TmpVector3);
			this.DebugDraw(this.TmpVector2.ToUeVector(false), ColorUtils.LinearWhite, 30f, 5);
		}
		this.TmpVector.DeepCopy(this.TmpVector3);
		@params.CharActorComp.MoveComp.ClampOffsetByChain(this.TmpVector);
		if (!@params.FlyingMove)
		{
			@params.CharActorComp.MoveComp.MoveCharacter(this.TmpVector, (float)delta, "TsAnimNotifyStateCurveMove直线移动");
		}
		else
		{
			@params.CharActorComp.AddActorWorldOffset(this.TmpVector.ToUeVector(false), "TsAnimNotifyStateCurveMove直线移动.AddActorWorldOffset", true);
			@params.CharActorComp.ResetAllCachedTime();
		}
		if (rate == 1.0)
		{
			return;
		}
		EMovementProcessDirection movementProcessDirection = this.MovementProcessDirection;
		if (movementProcessDirection != EMovementProcessDirection.AlongTrack)
		{
			if (movementProcessDirection == EMovementProcessDirection.TowardsTarget)
			{
				@params.TargetPos.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector);
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, global::Vector.UpVectorProxy, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				@params.CharActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStateCurveMove.TowardsTarget", false);
				return;
			}
		}
		else
		{
			@params.TargetPos.Subtraction(@params.InitLocation, this.TmpVector);
			MathUtils.Instance.LookRotationUpFirst(this.TmpVector, global::Vector.UpVectorProxy, this.TmpQuat);
			this.TmpQuat.Rotator(this.TmpRotator);
			@params.CharActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStateCurveMove.AlongTrack", false);
		}
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00065CF0 File Offset: 0x00063EF0
	private unsafe void MoveToTargetAlongSpline(double delta, CurveMoveParams @params)
	{
		@params.TargetPos.DeepCopy(@params.LastTargetPos);
		if (this.ContinuallyUpdateTargetPosition)
		{
			@params.LastTargetPos.DeepCopy(@params.TargetPos);
			this.GetTargetPos(@params, @params.TargetPos);
		}
		double towardVector = this.GetTowardVector(@params, @params.TargetVec);
		double rate = this.GetRate(delta, @params);
		if (rate <= 0.0 || towardVector < 0.0)
		{
			return;
		}
		if (this.ContinuallyUpdateTargetPosition && rate > 0.0)
		{
			int splinePointsNum = this.SplineCurves.GetSplinePointsNum();
			this.SplineCurves.GetWorldLocationAtSplinePoint(splinePointsNum - 1, this.TmpVector);
			double num = global::Vector.DistSquared(this.TmpVector, @params.TargetPos);
			if (num > 100.0 && num < 1000000.0)
			{
				this.SplineCurves.SetLocationAtSplinePoint(splinePointsNum - 1, @params.TargetPos, ESplineCoordinateSpace.World, true);
				bool debugMode = this.DebugMode;
			}
		}
		double num2 = (double)this.SplineCurves.GetSplineLength() * rate;
		double num3 = delta * (double)this.MaxMoveSpeed;
		@params.LastSplineDistance = (float)num2;
		if (num3 > 0.0001)
		{
			double val = (double)@params.LastSplineDistance + num3;
			@params.LastSplineDistance = (float)Math.Min(num2, val);
		}
		this.SplineCurves.GetTransformAtDistanceAlongSpline(Math.Min(@params.LastSplineDistance, this.SplineCurves.GetSplineLength() - 1f), ESplineCoordinateSpace.World, this.TmpTransform);
		global::Vector location = this.TmpTransform.GetLocation();
		this.TmpVector.DeepCopy(location);
		this.TmpVector.SubtractionEqual(@params.CharActorComp.ActorLocationProxy);
		if (this.DebugMode)
		{
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, @params.CharActorComp.ActorLocation, location.ToUeVector(false), (float)this.TmpVector.Size(), ColorUtils.LinearWhite, 0f, 0f);
		}
		double num4 = this.TmpVector.Size();
		if (num3 > 0.0001)
		{
			num4 = Math.Min(num4, num3);
		}
		CharacterUnifiedStateComponent charUnifiedComp = @params.CharUnifiedComp;
		if (charUnifiedComp != null && charUnifiedComp.PositionState == global::ECharPositionState.Ground && num4 < 1.0)
		{
			return;
		}
		this.TmpVector.Normalize(9.99999993922529E-09);
		this.TmpVector.MultiplyEqual(num4);
		if (this.DebugMode)
		{
			this.DebugDraw(location.ToUeVector(false), ColorUtils.LinearWhite, 30f, 5);
		}
		@params.LastLocation.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector2);
		if (this.TmpVector2.SizeSquared() > 1000000.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "LastLocation太远，很危险，无视掉";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			CharacterActorComponent charActorComp = @params.CharActorComp;
			object item2;
			if (charActorComp == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = charActorComp.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Last", @params.LastLocation);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item3 = "ActorLast";
			CharacterActorComponent charActorComp2 = @params.CharActorComp;
			ptr2 = new ValueTuple<string, object>(item3, (charActorComp2 != null) ? charActorComp2.LastActorLocation : null);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item4 = "Now";
			CharacterActorComponent charActorComp3 = @params.CharActorComp;
			ptr3 = new ValueTuple<string, object>(item4, (charActorComp3 != null) ? charActorComp3.ActorLocationProxy : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TargetVec", @params.TargetVec);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("TmpVector", this.TmpVector);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			this.TmpVector.Reset();
		}
		@params.CharActorComp.MoveComp.ClampOffsetByChain(this.TmpVector);
		if (!@params.FlyingMove)
		{
			@params.CharActorComp.MoveComp.MoveCharacter(this.TmpVector, (float)delta, "TsAnimNotifyStateCurveMove沿样条移动");
		}
		else
		{
			@params.CharActorComp.AddActorWorldOffset(this.TmpVector.ToUeVector(false), "TsAnimNotifyStateCurveMove沿样条移动.AddActorWorldOffset", true);
			@params.CharActorComp.ResetAllCachedTime();
		}
		if (rate == 1.0)
		{
			return;
		}
		EMovementProcessDirection movementProcessDirection = this.MovementProcessDirection;
		if (movementProcessDirection != EMovementProcessDirection.AlongTrack)
		{
			if (movementProcessDirection == EMovementProcessDirection.TowardsTarget)
			{
				@params.TargetPos.Subtraction(@params.CharActorComp.ActorLocationProxy, this.TmpVector);
				MathUtils.Instance.LookRotationUpFirst(this.TmpVector, @params.CharActorComp.ActorUpProxy, this.TmpQuat);
				this.TmpQuat.Rotator(this.TmpRotator);
				@params.CharActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStateCurveMove.TowardsTarget", false);
				return;
			}
		}
		else
		{
			this.TmpQuat.FromUeQuat(this.TmpTransform.GetRotation());
			this.TmpRotator.DeepCopy(this.TmpQuat.Rotator(null));
			@params.CharActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "TsAnimNotifyStateCurveMove.AlongTrack", false);
		}
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x000661DA File Offset: 0x000643DA
	private void DebugDraw(FVectorDouble location, FLinearColor color, float radius = 30f, int duration = 5)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, location, radius, 10, new FLinearColor?(color), (float)duration, 0f);
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x000661F8 File Offset: 0x000643F8
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

	// Token: 0x060011EE RID: 4590 RVA: 0x00066273 File Offset: 0x00064473
	protected override string GetNotifyName_Implementation()
	{
		return "曲线定点位移";
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x0006627A File Offset: 0x0006447A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCurveMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCurveMove.TsAnimNotifyStateCurveMove_C");
		}
		return TsAnimNotifyStateCurveMove._ClassPtr;
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x000662A0 File Offset: 0x000644A0
	public TsAnimNotifyStateCurveMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCurveMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x000662C8 File Offset: 0x000644C8
	public TsAnimNotifyStateCurveMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCurveMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x000662FC File Offset: 0x000644FC
	protected TsAnimNotifyStateCurveMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00066354 File Offset: 0x00064554
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00066390 File Offset: 0x00064590
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x000663CC File Offset: 0x000645CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x000663FF File Offset: 0x000645FF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000D39 RID: 3385
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TArray<SSkillBehaviorCondition> SkillBehaviorCondition;

	// Token: 0x04000D3A RID: 3386
	public string SkillBehaviorConditionFormula = "";

	// Token: 0x04000D3B RID: 3387
	public bool IgnoreObstacle;

	// Token: 0x04000D3C RID: 3388
	[Nullable(2)]
	public SplineCurve SplineCurves;

	// Token: 0x04000D3D RID: 3389
	public bool ContinuallyUpdateTargetPosition;

	// Token: 0x04000D3E RID: 3390
	public EPositionDatumTarget PositionDatumTarget;

	// Token: 0x04000D3F RID: 3391
	public string TargetSocketPosition = "None";

	// Token: 0x04000D40 RID: 3392
	public string TargetParam = "None";

	// Token: 0x04000D41 RID: 3393
	public ECurveMoveTargetBlackboardType TargetParamType;

	// Token: 0x04000D42 RID: 3394
	public EOffsetDirectionDatum OffsetDirectionDatum;

	// Token: 0x04000D43 RID: 3395
	public bool ProjectionGravityDirection;

	// Token: 0x04000D44 RID: 3396
	[Nullable(2)]
	public global::Vector TargetPositionOffset;

	// Token: 0x04000D45 RID: 3397
	public bool MakePositionCorrection;

	// Token: 0x04000D46 RID: 3398
	[Nullable(2)]
	public SSkillBehaviorAction PositionCorrectionConfig;

	// Token: 0x04000D47 RID: 3399
	[Nullable(2)]
	public UCurveFloat MovementPositionCurve;

	// Token: 0x04000D48 RID: 3400
	public EMovementProcessDirection MovementProcessDirection;

	// Token: 0x04000D49 RID: 3401
	public bool EndLocationDetection;

	// Token: 0x04000D4A RID: 3402
	public float EndLocationDetectionDist = 1000f;

	// Token: 0x04000D4B RID: 3403
	public float MaxMoveDistance = 3000f;

	// Token: 0x04000D4C RID: 3404
	public float MaxMoveSpeed = -1f;

	// Token: 0x04000D4D RID: 3405
	[Nullable(2)]
	private global::Vector TmpVector;

	// Token: 0x04000D4E RID: 3406
	[Nullable(2)]
	private global::Vector TmpVector2;

	// Token: 0x04000D4F RID: 3407
	[Nullable(2)]
	private global::Vector TmpVector3;

	// Token: 0x04000D50 RID: 3408
	[Nullable(2)]
	private global::Vector TmpVector4;

	// Token: 0x04000D51 RID: 3409
	[Nullable(2)]
	private global::Rotator TmpRotator;

	// Token: 0x04000D52 RID: 3410
	[Nullable(2)]
	private Quat TmpQuat;

	// Token: 0x04000D53 RID: 3411
	[Nullable(2)]
	private Quat TmpQuat2;

	// Token: 0x04000D54 RID: 3412
	[Nullable(2)]
	private global::Transform TmpTransform;

	// Token: 0x04000D55 RID: 3413
	private bool InitCacheVar;

	// Token: 0x04000D56 RID: 3414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<CurveMoveParams> ParamPool;

	// Token: 0x04000D57 RID: 3415
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, CurveMoveParams> ParamMap;

	// Token: 0x04000D58 RID: 3416
	[StaticVariableRuleIgnore]
	public static readonly int[] angles = new int[]
	{
		0,
		270,
		90,
		180
	};

	// Token: 0x04000D59 RID: 3417
	private const float MIN_MOVE_DISTANCE = 50f;

	// Token: 0x04000D5A RID: 3418
	private const float MIN_MOVE_DISTANCE_SQUARED = 2500f;

	// Token: 0x04000D5B RID: 3419
	private const float MIN_UPDATE_SPLINE_LENGTH = 100f;

	// Token: 0x04000D5C RID: 3420
	private const float MIN_UPDATE_SPLINE_LENGTH_SQUARED = 10000f;

	// Token: 0x04000D5D RID: 3421
	private const string PROFILE_KEY = "TsAnimNotifyStateCurveMove";

	// Token: 0x04000D5E RID: 3422
	private const float INVALID_LAST_LOCATION_THRESHOLD_SQUARED = 1000000f;

	// Token: 0x04000D5F RID: 3423
	private const float DEBUG_RADIUS = 30f;

	// Token: 0x04000D60 RID: 3424
	private const int DEBUG_DURATION = 5;

	// Token: 0x04000D61 RID: 3425
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x04000D62 RID: 3426
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCurveMove.TsAnimNotifyStateCurveMove_C";

	// Token: 0x04000D63 RID: 3427
	private static IntPtr _ClassPtr;

	// Token: 0x04000D64 RID: 3428
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000D65 RID: 3429
	private static int __PropertyOffset_DebugMode;

	// Token: 0x04000D66 RID: 3430
	private static int __PropertyOffset_技能条件;

	// Token: 0x04000D67 RID: 3431
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSkillBehaviorCondition> _技能条件;

	// Token: 0x04000D68 RID: 3432
	private static int __PropertyOffset_技能条件公式;

	// Token: 0x04000D69 RID: 3433
	private static int __PropertyOffset_无视障碍阻挡;

	// Token: 0x04000D6A RID: 3434
	private static int __PropertyOffset_运动轨迹曲线;

	// Token: 0x04000D6B RID: 3435
	[Nullable(2)]
	private FSoftObjectPath _运动轨迹曲线;

	// Token: 0x04000D6C RID: 3436
	private static int __PropertyOffset_持续更新目标位置;

	// Token: 0x04000D6D RID: 3437
	private static int __PropertyOffset_位置基准目标;

	// Token: 0x04000D6E RID: 3438
	private static int __PropertyOffset_基于目标骨骼位置;

	// Token: 0x04000D6F RID: 3439
	private static int __PropertyOffset_目标参数;

	// Token: 0x04000D70 RID: 3440
	private static int __PropertyOffset_目标参数类型;

	// Token: 0x04000D71 RID: 3441
	private static int __PropertyOffset_偏移方向基准;

	// Token: 0x04000D72 RID: 3442
	private static int __PropertyOffset_偏移基准消除重力分量;

	// Token: 0x04000D73 RID: 3443
	private static int __PropertyOffset_目标位置偏移;

	// Token: 0x04000D74 RID: 3444
	private static int __PropertyOffset_位置修正;

	// Token: 0x04000D75 RID: 3445
	private static int __PropertyOffset_位置修正配置;

	// Token: 0x04000D76 RID: 3446
	[Nullable(2)]
	private SSkillBehaviorAction _位置修正配置;

	// Token: 0x04000D77 RID: 3447
	private static int __PropertyOffset_运动位置曲线;

	// Token: 0x04000D78 RID: 3448
	private static int __PropertyOffset_运动过程朝向;

	// Token: 0x04000D79 RID: 3449
	private static int __PropertyOffset_自动更新运动轨迹曲线关键点;

	// Token: 0x04000D7A RID: 3450
	private static int __PropertyOffset_运动轨迹曲线关键点;

	// Token: 0x04000D7B RID: 3451
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<FSplinePoint> _运动轨迹曲线关键点;

	// Token: 0x04000D7C RID: 3452
	private static int __PropertyOffset_运动轨迹曲线插值ReparamTable;

	// Token: 0x04000D7D RID: 3453
	[Nullable(2)]
	private TArray<FInterpCurvePointFloat> _运动轨迹曲线插值ReparamTable;

	// Token: 0x04000D7E RID: 3454
	private static int __PropertyOffset_终点贴地检测;

	// Token: 0x04000D7F RID: 3455
	private static int __PropertyOffset_终点贴地检测距离;

	// Token: 0x04000D80 RID: 3456
	private static int __PropertyOffset_最大位移距离;

	// Token: 0x04000D81 RID: 3457
	private static int __PropertyOffset_最大移动速度;
}
