using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi.CommonConfig;
using UnrealEngine;

// Token: 0x02000F2D RID: 3885
[NullableContext(2)]
[Nullable(0)]
public class DangoGlobalConfig
{
	// Token: 0x06009B4F RID: 39759 RVA: 0x002E0E78 File Offset: 0x002DF078
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

	// Token: 0x06009B50 RID: 39760 RVA: 0x002E11D8 File Offset: 0x002DF3D8
	public DangoPerformConfig GetPerformConfig(EDangoPerformType type)
	{
		return this.PerformConfigMap.GetValueOrDefault(type);
	}

	// Token: 0x04005C99 RID: 23705
	public BP_DangoGlobalConfig_C ConfigAsset;

	// Token: 0x04005C9A RID: 23706
	public FName? AttachSocketName;

	// Token: 0x04005C9B RID: 23707
	public int StackInterval;

	// Token: 0x04005C9C RID: 23708
	public int MoveStartingTime;

	// Token: 0x04005C9D RID: 23709
	public int MoveTime;

	// Token: 0x04005C9E RID: 23710
	public int MoveTotalTime;

	// Token: 0x04005C9F RID: 23711
	public int MoveRotateSpeed;

	// Token: 0x04005CA0 RID: 23712
	public int MoveBaseHeightOffset;

	// Token: 0x04005CA1 RID: 23713
	public int MaxRiseHeightEdge;

	// Token: 0x04005CA2 RID: 23714
	public int MaxFallHeightEdge;

	// Token: 0x04005CA3 RID: 23715
	public UCurveFloat MoveRiseCurve;

	// Token: 0x04005CA4 RID: 23716
	public UCurveFloat MoveFallCurve;

	// Token: 0x04005CA5 RID: 23717
	public UCurveFloat BlankHoleFallCurve;

	// Token: 0x04005CA6 RID: 23718
	public int BeforeMoveCameraTriggerDistance;

	// Token: 0x04005CA7 RID: 23719
	public int BeforeMoveCameraArmLength;

	// Token: 0x04005CA8 RID: 23720
	public float BeforeMoveCameraBlendTimeCloseMin;

	// Token: 0x04005CA9 RID: 23721
	public float BeforeMoveCameraBlendTimeCloseMax;

	// Token: 0x04005CAA RID: 23722
	public int BeforeMoveCameraCloseDistanceEdgeMin;

	// Token: 0x04005CAB RID: 23723
	public int BeforeMoveCameraCloseDistanceEdgeMax;

	// Token: 0x04005CAC RID: 23724
	public int BeforeMoveCameraFarDistance;

	// Token: 0x04005CAD RID: 23725
	public float BeforeMoveCameraBlendTimeFar;

	// Token: 0x04005CAE RID: 23726
	public float BeforeMoveCameraFov;

	// Token: 0x04005CAF RID: 23727
	public CurveBase BeforeMoveCameraCurve;

	// Token: 0x04005CB0 RID: 23728
	public int MovingCameraArmLength;

	// Token: 0x04005CB1 RID: 23729
	public float MovingCameraBlendTime;

	// Token: 0x04005CB2 RID: 23730
	public float MovingCameraFov;

	// Token: 0x04005CB3 RID: 23731
	public CurveBase MovingCameraCurve;

	// Token: 0x04005CB4 RID: 23732
	[Nullable(1)]
	private readonly Dictionary<EDangoPerformType, DangoPerformConfig> PerformConfigMap = new Dictionary<EDangoPerformType, DangoPerformConfig>();
}
