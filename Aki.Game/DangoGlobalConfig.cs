using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig;
using UnrealEngine;

// Token: 0x02001A6E RID: 6766
[NullableContext(2)]
[Nullable(0)]
public class DangoGlobalConfig
{
	// Token: 0x0600C73F RID: 51007 RVA: 0x002D5D90 File Offset: 0x002D3F90
	[NullableContext(1)]
	public static DangoGlobalConfig Create(BP_DangoGlobalConfig_C configAsset)
	{
		DangoGlobalConfig dangoGlobalConfig = new DangoGlobalConfig();
		dangoGlobalConfig.ConfigAsset = configAsset;
		dangoGlobalConfig.AttachSocketName = new FName?(configAsset.堆叠绑定骨骼名称);
		dangoGlobalConfig.StackInterval = configAsset.堆叠间隔;
		dangoGlobalConfig.MoveStartingTime = configAsset.跳跃前摇时间;
		dangoGlobalConfig.MoveTime = configAsset.跳跃移动时间;
		dangoGlobalConfig.MoveTotalTime = configAsset.跳跃前摇时间 + configAsset.跳跃移动时间 + configAsset.跳跃后摇时间;
		dangoGlobalConfig.MoveRotateSpeed = configAsset.跳跃旋转速度;
		dangoGlobalConfig.MoveBaseHeightOffset = configAsset.跳跃高度偏移基准;
		dangoGlobalConfig.MaxRiseHeightEdge = Math.Abs(configAsset.跳跃上升偏移曲线高度范围);
		dangoGlobalConfig.MaxFallHeightEdge = Math.Abs(configAsset.跳跃下降偏移曲线高度范围);
		dangoGlobalConfig.MoveRiseCurve = configAsset.跳跃上升偏移曲线;
		dangoGlobalConfig.MoveFallCurve = configAsset.跳跃下降偏移曲线;
		dangoGlobalConfig.BlankHoleFallCurve = configAsset.黑洞下降偏移曲线;
		dangoGlobalConfig.BeforeMoveCameraTriggerDistance = configAsset.跳跃前镜头死区距离基准;
		dangoGlobalConfig.BeforeMoveCameraArmLength = configAsset.跳跃前镜头臂长;
		FInt32Range 跳跃前镜头近距离追踪时间范围 = configAsset.跳跃前镜头近距离追踪时间范围;
		dangoGlobalConfig.BeforeMoveCameraBlendTimeCloseMin = (float)跳跃前镜头近距离追踪时间范围.LowerBound.Value * 0.001f;
		dangoGlobalConfig.BeforeMoveCameraBlendTimeCloseMax = (float)跳跃前镜头近距离追踪时间范围.UpperBound.Value * 0.001f;
		FInt32Range 跳跃前镜头近距离基准范围 = configAsset.跳跃前镜头近距离基准范围;
		dangoGlobalConfig.BeforeMoveCameraCloseDistanceEdgeMin = 跳跃前镜头近距离基准范围.LowerBound.Value;
		dangoGlobalConfig.BeforeMoveCameraCloseDistanceEdgeMax = 跳跃前镜头近距离基准范围.UpperBound.Value;
		dangoGlobalConfig.BeforeMoveCameraBlendTimeFar = (float)configAsset.跳跃前镜头远距离追踪时间 * 0.001f;
		dangoGlobalConfig.BeforeMoveCameraFarDistance = configAsset.跳跃前镜头远距离基准;
		dangoGlobalConfig.BeforeMoveCameraFov = configAsset.跳跃前镜头FOV;
		dangoGlobalConfig.BeforeMoveCameraCurve = CurveUtils.CreateCurveByStruct(configAsset.跳跃前镜头曲线);
		dangoGlobalConfig.MovingCameraArmLength = configAsset.跳跃中镜头臂长;
		dangoGlobalConfig.MovingCameraBlendTime = (float)configAsset.跳跃中镜头追踪时间 * 0.001f;
		dangoGlobalConfig.MovingCameraFov = configAsset.跳跃中镜头FOV;
		dangoGlobalConfig.MovingCameraCurve = CurveUtils.CreateCurveByStruct(configAsset.跳跃中镜头曲线);
		foreach (KeyValuePair<TEnumAsByte<EDangoPerformType>, SDangoPerformData> keyValuePair in configAsset.动作表现)
		{
			TEnumAsByte<EDangoPerformType> tenumAsByte;
			SDangoPerformData sdangoPerformData;
			keyValuePair.Deconstruct(out tenumAsByte, out sdangoPerformData);
			TEnumAsByte<EDangoPerformType> value = tenumAsByte;
			SDangoPerformData sdangoPerformData2 = sdangoPerformData;
			if (!(sdangoPerformData2 == null))
			{
				DangoPerformConfig dangoPerformConfig = new DangoPerformConfig();
				dangoPerformConfig.ActionType = sdangoPerformData2.动画类型;
				dangoPerformConfig.ActionTargetType = sdangoPerformData2.动画目标类型;
				dangoPerformConfig.RecursionActionType = sdangoPerformData2.堆叠上方团子动画类型;
				dangoPerformConfig.Duration = sdangoPerformData2.持续时间;
				foreach (SDangoPerformEffectData sdangoPerformEffectData in sdangoPerformData2.特效列表)
				{
					DangoPerformEffectConfig dangoPerformEffectConfig = new DangoPerformEffectConfig();
					dangoPerformEffectConfig.EffectPath = sdangoPerformEffectData.特效路径.ToAssetPathName();
					dangoPerformEffectConfig.PerformLocationType = sdangoPerformEffectData.特效位置类型;
					Vector locationOffset = dangoPerformEffectConfig.LocationOffset;
					FVector 位置偏移 = sdangoPerformEffectData.位置偏移;
					locationOffset.FromUeVector(位置偏移);
					dangoPerformEffectConfig.DelayTime = sdangoPerformEffectData.释放延迟时间;
					if (!FNameUtil.IsNothing(sdangoPerformEffectData.骨骼名称))
					{
						dangoPerformEffectConfig.AttachSocket = new FName?(sdangoPerformEffectData.骨骼名称);
					}
					dangoPerformConfig.EffectConfigList.Add(dangoPerformEffectConfig);
				}
				dangoGlobalConfig.PerformConfigMap.Add(value, dangoPerformConfig);
			}
		}
		return dangoGlobalConfig;
	}

	// Token: 0x0600C740 RID: 51008 RVA: 0x002D60E8 File Offset: 0x002D42E8
	public DangoPerformConfig GetPerformConfig(EDangoPerformType type)
	{
		return this.PerformConfigMap.GetValueOrDefault(type);
	}

	// Token: 0x04005BCA RID: 23498
	public BP_DangoGlobalConfig_C ConfigAsset;

	// Token: 0x04005BCB RID: 23499
	public FName? AttachSocketName;

	// Token: 0x04005BCC RID: 23500
	public int StackInterval;

	// Token: 0x04005BCD RID: 23501
	public int MoveStartingTime;

	// Token: 0x04005BCE RID: 23502
	public int MoveTime;

	// Token: 0x04005BCF RID: 23503
	public int MoveTotalTime;

	// Token: 0x04005BD0 RID: 23504
	public int MoveRotateSpeed;

	// Token: 0x04005BD1 RID: 23505
	public int MoveBaseHeightOffset;

	// Token: 0x04005BD2 RID: 23506
	public int MaxRiseHeightEdge;

	// Token: 0x04005BD3 RID: 23507
	public int MaxFallHeightEdge;

	// Token: 0x04005BD4 RID: 23508
	public UCurveFloat MoveRiseCurve;

	// Token: 0x04005BD5 RID: 23509
	public UCurveFloat MoveFallCurve;

	// Token: 0x04005BD6 RID: 23510
	public UCurveFloat BlankHoleFallCurve;

	// Token: 0x04005BD7 RID: 23511
	public int BeforeMoveCameraTriggerDistance;

	// Token: 0x04005BD8 RID: 23512
	public int BeforeMoveCameraArmLength;

	// Token: 0x04005BD9 RID: 23513
	public float BeforeMoveCameraBlendTimeCloseMin;

	// Token: 0x04005BDA RID: 23514
	public float BeforeMoveCameraBlendTimeCloseMax;

	// Token: 0x04005BDB RID: 23515
	public int BeforeMoveCameraCloseDistanceEdgeMin;

	// Token: 0x04005BDC RID: 23516
	public int BeforeMoveCameraCloseDistanceEdgeMax;

	// Token: 0x04005BDD RID: 23517
	public int BeforeMoveCameraFarDistance;

	// Token: 0x04005BDE RID: 23518
	public float BeforeMoveCameraBlendTimeFar;

	// Token: 0x04005BDF RID: 23519
	public float BeforeMoveCameraFov;

	// Token: 0x04005BE0 RID: 23520
	public CurveBase BeforeMoveCameraCurve;

	// Token: 0x04005BE1 RID: 23521
	public int MovingCameraArmLength;

	// Token: 0x04005BE2 RID: 23522
	public float MovingCameraBlendTime;

	// Token: 0x04005BE3 RID: 23523
	public float MovingCameraFov;

	// Token: 0x04005BE4 RID: 23524
	public CurveBase MovingCameraCurve;

	// Token: 0x04005BE5 RID: 23525
	[Nullable(1)]
	private readonly Dictionary<EDangoPerformType, DangoPerformConfig> PerformConfigMap = new Dictionary<EDangoPerformType, DangoPerformConfig>();
}
