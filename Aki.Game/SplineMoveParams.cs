using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x020027DF RID: 10207
[NullableContext(2)]
[Nullable(0)]
public class SplineMoveParams
{
	// Token: 0x17002921 RID: 10529
	// (get) Token: 0x06019ABC RID: 105148 RVA: 0x007E72FE File Offset: 0x007E54FE
	// (set) Token: 0x06019ABD RID: 105149 RVA: 0x007E7306 File Offset: 0x007E5506
	public float CurrentMaxOffset
	{
		get
		{
			return this.CurrentMaxOffsetInternal;
		}
		set
		{
			this.CurrentMaxOffsetInternal = value;
			this.CurrentMaxOffsetSquaredInternal = value * value;
		}
	}

	// Token: 0x17002922 RID: 10530
	// (get) Token: 0x06019ABE RID: 105150 RVA: 0x007E7318 File Offset: 0x007E5518
	public float CurrentMaxOffsetSquared
	{
		get
		{
			return this.CurrentMaxOffsetSquaredInternal;
		}
	}

	// Token: 0x17002923 RID: 10531
	// (get) Token: 0x06019ABF RID: 105151 RVA: 0x007E7320 File Offset: 0x007E5520
	public bool OnlyPositiveMove
	{
		get
		{
			return this.OnlyForward || this.PositiveMoveInternal;
		}
	}

	// Token: 0x06019AC0 RID: 105152 RVA: 0x007E7334 File Offset: 0x007E5534
	[NullableContext(1)]
	public void InitBase(int id, ISplineMovePattern config, Entity entity)
	{
		this.Id = id;
		this.Config = config;
		this.Entity = entity;
		this.Type = config.Type;
		this.MaxOffsetDist = config.MaxOffsetDistance.GetValueOrDefault();
		this.OnlyForward = config.IsOneWay.GetValueOrDefault();
		this.AutoExitSplineDist = (float)config.AutoExitDistance.GetValueOrDefault();
		this.UseSplineGravity = config.DynamicGravity.GetValueOrDefault();
		this.LayerVerticalLimit = config.LayerVerticalLimit.GetValueOrDefault(100000f);
		switch (config.Type)
		{
		case ESplineMovePattern.PathLine:
		{
			IPathLineFacingType facingConfig = (config as IPathLineMove).FacingConfig;
			this.AdjustFacingType = ((facingConfig != null) ? new EPathLineFacingType?(facingConfig.Type) : null);
			if ((config as IPathLineMove).FacingConfig != null)
			{
				EPathLineFacingType type = (config as IPathLineMove).FacingConfig.Type;
				if (type != EPathLineFacingType.Current)
				{
					if (type == EPathLineFacingType.Custom)
					{
						this.AdjustFacingLimit = ((config as IPathLineMove).FacingConfig as IPathLineFacingCustomDirection).Yaw;
					}
				}
				else
				{
					this.AdjustFacingLimit = ((config as IPathLineMove).FacingConfig as IPathLineFacingCurrentDirection).YawOffset.GetValueOrDefault();
				}
			}
			this.ConfigDaPath = (config as IPathLineMove).SplineMoveConfigDaPath;
			this.IsAdaptiveClimbInput = (config as IPathLineMove).IsAdaptiveClimbInput.GetValueOrDefault();
			this.IsDisableStopAnim = (config as IPathLineMove).IsDisableStopAnim.GetValueOrDefault();
			this.IsAllowEarlyExitClimb = (config as IPathLineMove).IsAllowEarlyExitClimb.GetValueOrDefault();
			break;
		}
		case ESplineMovePattern.RacingTrack:
			this.InputLimitAngle = (config as IRacingTrackMove).DirectionAngleLimit;
			this.InputLimitCos = (float)Math.Cos((double)(this.InputLimitAngle * 0.017453292f));
			this.InputLimitSin = (float)Math.Sin((double)(this.InputLimitAngle * 0.017453292f));
			break;
		case ESplineMovePattern.SlideTrack:
			this.InputLimitAngle = (config as ISlideTrackMove).DirectionAngleLimit;
			this.EdgeLimitCurve = new PowerCurve3(new float[]
			{
				(config as ISlideTrackMove).EdgeLimitCurveFactor
			});
			break;
		case ESplineMovePattern.AirPassage:
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(id);
			SceneItemWindPipelineComponent sceneItemWindPipelineComponent;
			if (entityByPbDataId == null)
			{
				sceneItemWindPipelineComponent = null;
			}
			else
			{
				WorldEntity entity2 = entityByPbDataId.Entity;
				sceneItemWindPipelineComponent = ((entity2 != null) ? entity2.GetComponent<SceneItemWindPipelineComponent>() : null);
			}
			SceneItemWindPipelineComponent sceneItemWindPipelineComponent2 = sceneItemWindPipelineComponent;
			if (((sceneItemWindPipelineComponent2 != null) ? sceneItemWindPipelineComponent2.SplineData : null) != null)
			{
				this.MaxSoarSplineSpeed = sceneItemWindPipelineComponent2.SplineData.SpeedLimit;
				this.MaxOffsetDist = sceneItemWindPipelineComponent2.SplineData.MovableRadius;
				this.SoarFriction = sceneItemWindPipelineComponent2.SplineData.Resistance;
				this.SoarSprintLimit = sceneItemWindPipelineComponent2.SplineData.SprintSpeedLimit;
			}
			else
			{
				this.MaxSoarSplineSpeed = 3000f;
				this.SoarFriction = 0.5f;
				this.SoarSprintLimit = 0f;
			}
			this.NeedLimitSoarTransform = ((config as IAirPassageMove).Limit != null);
			if ((config as IAirPassageMove).Limit != null)
			{
				this.InputLimitAngle = (config as IAirPassageMove).Limit.DirectionAngleLimit;
				this.EdgeLimitCurve = new PowerCurve3(new float[]
				{
					(config as IAirPassageMove).Limit.EdgeLimitCurveFactor
				});
			}
			break;
		}
		case ESplineMovePattern.MotorcycleTrack:
		{
			if (this.MaxOffsetDist <= 0f)
			{
				this.MaxOffsetDist = 1f;
			}
			this.AdjustFacingLimit = (((config as IMotorcycleTrack).ForwardAngleLimit >= 0f) ? (config as IMotorcycleTrack).ForwardAngleLimit : 180f);
			if ((config as IMotorcycleTrack).LongitudinalAngleLimit != null)
			{
				this.AdjustFacingLimitPitchSin = (float)Math.Sin((double)(0.017453292f * (config as IMotorcycleTrack).LongitudinalAngleLimit.Value));
			}
			if ((config as IMotorcycleTrack).CorrectionPredictionDistance != null)
			{
				this.PredictDist = (config as IMotorcycleTrack).CorrectionPredictionDistance.Value;
			}
			else
			{
				this.PredictDist = 2000f;
			}
			this.InputCorrectionBaseAngle = (config as IMotorcycleTrack).InputCorrectionBaseAngle.GetValueOrDefault(30f);
			if ((config as IMotorcycleTrack).ForwardAngleLimitCurve != null)
			{
				this.AdjustFacingLimitCurve = ResourceSystem.Instance.Load<UCurveFloat>((config as IMotorcycleTrack).ForwardAngleLimitCurve, "js_undefined");
			}
			this.InputCorrectionCurve = ResourceSystem.Instance.Load<UCurveFloat>((config as IMotorcycleTrack).InputCorrectionCurve, "js_undefined");
			IAutomaticDrive automaticDrive = (config as IMotorcycleTrack).AutomaticDrive;
			bool flag;
			if (automaticDrive == null)
			{
				flag = false;
			}
			else
			{
				float standbyTime = automaticDrive.StandbyTime;
				flag = true;
			}
			this.AutoDriveStandbyTime = (flag ? (config as IMotorcycleTrack).AutomaticDrive.StandbyTime : -1f);
			this.DisableAutoForward = (config as IMotorcycleTrack).DisableAutoForward.GetValueOrDefault();
			break;
		}
		}
		this.CurrentMaxOffset = this.MaxOffsetDist + 100000f;
		if (this.Type == ESplineMovePattern.AirPassage)
		{
			this.EarliestLeaveTime = Time.Instance.NowSeconds + 1.0;
			return;
		}
		if (this.Type == ESplineMovePattern.MotorcycleTrack && this.UseSplineGravity)
		{
			this.EarliestLeaveTime = Time.Instance.NowSeconds + 0.5;
			return;
		}
		this.EarliestLeaveTime = Time.Instance.NowSeconds;
	}

	// Token: 0x06019AC1 RID: 105153 RVA: 0x007E784C File Offset: 0x007E5A4C
	[NullableContext(1)]
	public void InitByAutoPilotRoute(UAutopilotRoute route, Entity entity)
	{
		this.Id = -1;
		this.Entity = entity;
		this.AutopilotRoute = route;
		this.Spline = route.RoadSpline;
		this.Type = ESplineMovePattern.MotorcycleTrack;
		this.CurrentMaxOffset = 0f;
		this.UpdateRouteParamsByIndex(0);
		this.CurrentMaxOffset += 100000f;
		this.OnlyForward = false;
		this.PositiveMoveInternal = true;
		this.LayerVerticalLimit = 100000f;
		this.AdjustFacingLimit = 180f;
		this.AdjustFacingLimitPitchSin = (float)Math.Sin(1.0471975803375244);
		this.PredictDist = 2000f;
		this.AdjustFacingLimitCurve = null;
		this.InputCorrectionCurve = null;
		this.EarliestLeaveTime = Time.Instance.NowSeconds;
		int num = route.RoadSegmentInfos.Num();
		for (int i = 0; i < num; i++)
		{
			FRoadSegmentInfo froadSegmentInfo = route.RoadSegmentInfos.Get(i);
			this.KeyOfAutopilotRoute.Add(froadSegmentInfo.StartKey);
		}
	}

	// Token: 0x06019AC2 RID: 105154 RVA: 0x007E7940 File Offset: 0x007E5B40
	public void UpdateParamsByTimeKey(float timeKey)
	{
		if (this.AutopilotRoute == null)
		{
			return;
		}
		int num = 0;
		int num2 = this.KeyOfAutopilotRoute.Count;
		while (num2 - num > 1)
		{
			int num3 = num + num2 >> 1;
			if (this.KeyOfAutopilotRoute[num3] <= timeKey)
			{
				num = num3;
			}
			else
			{
				num2 = num3;
			}
		}
		this.UpdateRouteParamsByIndex(num);
	}

	// Token: 0x06019AC3 RID: 105155 RVA: 0x007E7990 File Offset: 0x007E5B90
	protected void UpdateRouteParamsByIndex(int index)
	{
		this.CurrentRouteIndex = index;
		UKuroRoadway roadInfo = this.AutopilotRoute.RoadSegmentInfos.Get(index).RoadInfo;
		this.MaxOffsetDist = (float)(roadInfo.Width / 2);
		this.AutoSprint = MathUtils.Instance.IsNearlyEqual((double)roadInfo.PavedRoadConfig, 2.0, null);
		if (this.MaxOffsetDist <= 0f)
		{
			this.MaxOffsetDist = 1f;
		}
		this.CurrentMaxOffset = Math.Max(this.CurrentMaxOffset, this.MaxOffsetDist);
	}

	// Token: 0x06019AC4 RID: 105156 RVA: 0x007E7A24 File Offset: 0x007E5C24
	public void EnableParams(bool enable)
	{
		if (this.Spline == null && enable)
		{
			this.Spline = GameSplineModel.Instance.LoadAndGetSplineComponent(this.Id, this.Entity.Id, EIdType.EntityId);
		}
		else if (this.Spline != null && !enable)
		{
			GameSplineModel.Instance.ReleaseSpline(this.Id, (long)this.Entity.Id, EIdType.EntityId);
			this.Spline = null;
		}
		if (!enable)
		{
			this.Clear();
		}
	}

	// Token: 0x06019AC5 RID: 105157 RVA: 0x007E7A9A File Offset: 0x007E5C9A
	public void Clear()
	{
		if (this.AutopilotRoute != null && !this.MarkInherited)
		{
			this.AutopilotRoute.Clear();
		}
	}

	// Token: 0x0400E111 RID: 57617
	private const float MAX_OFFSET_INCREASE = 100000f;

	// Token: 0x0400E112 RID: 57618
	private const float HEIGHT_LIMIT = 100000f;

	// Token: 0x0400E113 RID: 57619
	public int Id;

	// Token: 0x0400E114 RID: 57620
	public ISplineMovePattern Config;

	// Token: 0x0400E115 RID: 57621
	public Entity Entity;

	// Token: 0x0400E116 RID: 57622
	public bool AllowInherit;

	// Token: 0x0400E117 RID: 57623
	public bool MarkInherited;

	// Token: 0x0400E118 RID: 57624
	public USplineComponent Spline;

	// Token: 0x0400E119 RID: 57625
	private float CurrentMaxOffsetInternal;

	// Token: 0x0400E11A RID: 57626
	private float CurrentMaxOffsetSquaredInternal;

	// Token: 0x0400E11B RID: 57627
	public ESplineMovePattern Type;

	// Token: 0x0400E11C RID: 57628
	public float MaxOffsetDist;

	// Token: 0x0400E11D RID: 57629
	public bool OnlyForward;

	// Token: 0x0400E11E RID: 57630
	private bool PositiveMoveInternal;

	// Token: 0x0400E11F RID: 57631
	public float InputLimitAngle;

	// Token: 0x0400E120 RID: 57632
	public float InputLimitCos;

	// Token: 0x0400E121 RID: 57633
	public float InputLimitSin;

	// Token: 0x0400E122 RID: 57634
	public float LayerVerticalLimit = 100000f;

	// Token: 0x0400E123 RID: 57635
	public float AutoExitSplineDist;

	// Token: 0x0400E124 RID: 57636
	public bool UseSplineGravity;

	// Token: 0x0400E125 RID: 57637
	public EPathLineFacingType? AdjustFacingType;

	// Token: 0x0400E126 RID: 57638
	public string ConfigDaPath;

	// Token: 0x0400E127 RID: 57639
	public bool IsAdaptiveClimbInput;

	// Token: 0x0400E128 RID: 57640
	public bool IsDisableStopAnim;

	// Token: 0x0400E129 RID: 57641
	public bool IsAllowEarlyExitClimb;

	// Token: 0x0400E12A RID: 57642
	public float AdjustFacingLimit;

	// Token: 0x0400E12B RID: 57643
	public UCurveFloat AdjustFacingLimitCurve;

	// Token: 0x0400E12C RID: 57644
	public float AdjustFacingLimitPitchSin = (float)Math.Sin(1.0471975803375244);

	// Token: 0x0400E12D RID: 57645
	[Nullable(1)]
	public CurveBase EdgeLimitCurve = CurveUtils.DefaultLinear;

	// Token: 0x0400E12E RID: 57646
	public bool IsDelayClear;

	// Token: 0x0400E12F RID: 57647
	public double EarliestLeaveTime;

	// Token: 0x0400E130 RID: 57648
	public bool NeedLimitSoarTransform;

	// Token: 0x0400E131 RID: 57649
	public float MaxSoarSplineSpeed;

	// Token: 0x0400E132 RID: 57650
	public float SoarFriction;

	// Token: 0x0400E133 RID: 57651
	public float SoarSprintLimit;

	// Token: 0x0400E134 RID: 57652
	public float PredictDist = 2000f;

	// Token: 0x0400E135 RID: 57653
	public float InputCorrectionBaseAngle = 30f;

	// Token: 0x0400E136 RID: 57654
	public UCurveFloat InputCorrectionCurve;

	// Token: 0x0400E137 RID: 57655
	public float AutoDriveStandbyTime;

	// Token: 0x0400E138 RID: 57656
	public bool AutoSprint;

	// Token: 0x0400E139 RID: 57657
	public bool DisableAutoForward;

	// Token: 0x0400E13A RID: 57658
	public UAutopilotRoute AutopilotRoute;

	// Token: 0x0400E13B RID: 57659
	public int CurrentRouteIndex;

	// Token: 0x0400E13C RID: 57660
	[Nullable(1)]
	protected readonly List<float> KeyOfAutopilotRoute = new List<float>();
}
