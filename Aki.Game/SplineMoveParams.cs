using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02003270 RID: 12912
[NullableContext(2)]
[Nullable(0)]
public class SplineMoveParams
{
	// Token: 0x17002689 RID: 9865
	// (get) Token: 0x0601BEDC RID: 114396 RVA: 0x007BFD6E File Offset: 0x007BDF6E
	// (set) Token: 0x0601BEDD RID: 114397 RVA: 0x007BFD76 File Offset: 0x007BDF76
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

	// Token: 0x1700268A RID: 9866
	// (get) Token: 0x0601BEDE RID: 114398 RVA: 0x007BFD88 File Offset: 0x007BDF88
	public float CurrentMaxOffsetSquared
	{
		get
		{
			return this.CurrentMaxOffsetSquaredInternal;
		}
	}

	// Token: 0x1700268B RID: 9867
	// (get) Token: 0x0601BEDF RID: 114399 RVA: 0x007BFD90 File Offset: 0x007BDF90
	public bool OnlyPositiveMove
	{
		get
		{
			return this.OnlyForward || this.PositiveMoveInternal;
		}
	}

	// Token: 0x0601BEE0 RID: 114400 RVA: 0x007BFDA4 File Offset: 0x007BDFA4
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

	// Token: 0x0601BEE1 RID: 114401 RVA: 0x007C02BC File Offset: 0x007BE4BC
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

	// Token: 0x0601BEE2 RID: 114402 RVA: 0x007C03B0 File Offset: 0x007BE5B0
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

	// Token: 0x0601BEE3 RID: 114403 RVA: 0x007C0400 File Offset: 0x007BE600
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

	// Token: 0x0601BEE4 RID: 114404 RVA: 0x007C0494 File Offset: 0x007BE694
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

	// Token: 0x0601BEE5 RID: 114405 RVA: 0x007C050A File Offset: 0x007BE70A
	public void Clear()
	{
		if (this.AutopilotRoute != null && !this.MarkInherited)
		{
			this.AutopilotRoute.Clear();
		}
	}

	// Token: 0x0400DC72 RID: 56434
	private const float MAX_OFFSET_INCREASE = 100000f;

	// Token: 0x0400DC73 RID: 56435
	private const float HEIGHT_LIMIT = 100000f;

	// Token: 0x0400DC74 RID: 56436
	public int Id;

	// Token: 0x0400DC75 RID: 56437
	public ISplineMovePattern Config;

	// Token: 0x0400DC76 RID: 56438
	public Entity Entity;

	// Token: 0x0400DC77 RID: 56439
	public bool AllowInherit;

	// Token: 0x0400DC78 RID: 56440
	public bool MarkInherited;

	// Token: 0x0400DC79 RID: 56441
	public USplineComponent Spline;

	// Token: 0x0400DC7A RID: 56442
	private float CurrentMaxOffsetInternal;

	// Token: 0x0400DC7B RID: 56443
	private float CurrentMaxOffsetSquaredInternal;

	// Token: 0x0400DC7C RID: 56444
	public ESplineMovePattern Type;

	// Token: 0x0400DC7D RID: 56445
	public float MaxOffsetDist;

	// Token: 0x0400DC7E RID: 56446
	public bool OnlyForward;

	// Token: 0x0400DC7F RID: 56447
	private bool PositiveMoveInternal;

	// Token: 0x0400DC80 RID: 56448
	public float InputLimitAngle;

	// Token: 0x0400DC81 RID: 56449
	public float InputLimitCos;

	// Token: 0x0400DC82 RID: 56450
	public float InputLimitSin;

	// Token: 0x0400DC83 RID: 56451
	public float LayerVerticalLimit = 100000f;

	// Token: 0x0400DC84 RID: 56452
	public float AutoExitSplineDist;

	// Token: 0x0400DC85 RID: 56453
	public bool UseSplineGravity;

	// Token: 0x0400DC86 RID: 56454
	public EPathLineFacingType? AdjustFacingType;

	// Token: 0x0400DC87 RID: 56455
	public string ConfigDaPath;

	// Token: 0x0400DC88 RID: 56456
	public bool IsAdaptiveClimbInput;

	// Token: 0x0400DC89 RID: 56457
	public bool IsDisableStopAnim;

	// Token: 0x0400DC8A RID: 56458
	public bool IsAllowEarlyExitClimb;

	// Token: 0x0400DC8B RID: 56459
	public float AdjustFacingLimit;

	// Token: 0x0400DC8C RID: 56460
	public UCurveFloat AdjustFacingLimitCurve;

	// Token: 0x0400DC8D RID: 56461
	public float AdjustFacingLimitPitchSin = (float)Math.Sin(1.0471975803375244);

	// Token: 0x0400DC8E RID: 56462
	[Nullable(1)]
	public CurveBase EdgeLimitCurve = CurveUtils.DefaultLinear;

	// Token: 0x0400DC8F RID: 56463
	public bool IsDelayClear;

	// Token: 0x0400DC90 RID: 56464
	public double EarliestLeaveTime;

	// Token: 0x0400DC91 RID: 56465
	public bool NeedLimitSoarTransform;

	// Token: 0x0400DC92 RID: 56466
	public float MaxSoarSplineSpeed;

	// Token: 0x0400DC93 RID: 56467
	public float SoarFriction;

	// Token: 0x0400DC94 RID: 56468
	public float SoarSprintLimit;

	// Token: 0x0400DC95 RID: 56469
	public float PredictDist = 2000f;

	// Token: 0x0400DC96 RID: 56470
	public float InputCorrectionBaseAngle = 30f;

	// Token: 0x0400DC97 RID: 56471
	public UCurveFloat InputCorrectionCurve;

	// Token: 0x0400DC98 RID: 56472
	public float AutoDriveStandbyTime;

	// Token: 0x0400DC99 RID: 56473
	public bool AutoSprint;

	// Token: 0x0400DC9A RID: 56474
	public bool DisableAutoForward;

	// Token: 0x0400DC9B RID: 56475
	public UAutopilotRoute AutopilotRoute;

	// Token: 0x0400DC9C RID: 56476
	public int CurrentRouteIndex;

	// Token: 0x0400DC9D RID: 56477
	[Nullable(1)]
	protected readonly List<float> KeyOfAutopilotRoute = new List<float>();
}
