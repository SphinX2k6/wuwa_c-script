using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x020001F9 RID: 505
[NullableContext(1)]
[Nullable(0)]
public class CameraConfig
{
	// Token: 0x06002036 RID: 8246 RVA: 0x000A747C File Offset: 0x000A567C
	public CameraConfig(SCameraConfig config)
	{
		this.Type = config.Type;
		this.Tag = ((config.Tag.TagName == FName.NAME_None) ? null : new FGameplayTag?(config.Tag));
		this.PcValid = config.PC生效;
		this.MobileValid = config.手机生效;
		this.Priority = config.优先级;
		this.EnableModifyCamera = config.启用Modify镜头;
		this.EnableAdjustCamera = config.启用技能修正镜头;
		this.EnableAutoCamera = config.启用自动镜头;
		this.EnableFocusCamera = config.启用锁定镜头;
		this.EnableSidestepCamera = config.启用移动自动镜头;
		this.EnableClimbCamera = config.启用攀爬镜头;
		this.FadeInTime = config.淡入时间;
		this.FadeInCurve = CurveUtils.CreateCurveByStruct(config.淡入曲线);
		this.FadeOutTime = config.淡出时间;
		this.FadeOutCurve = CurveUtils.CreateCurveByStruct(config.淡出曲线);
		this.LockOnParts = FightCameraLogicComponent.TArrayToArray<string>(config.锁定点名称);
		this.DefaultConfig = FightCameraLogicComponent.TMapToMap<EFightCameraDefault>(config.基础);
		this.DefaultCurveConfig = FightCameraLogicComponent.TMapToCurveMap<EFightCameraDefault>(config.基础曲线配置);
		this.AdjustConfig = CameraConfig.LoadConfigMap<EFightCameraAdjust>(config.技能修正);
		this.CurveAdjustConfig = CameraConfig.LoadCurveConfigMap<EFightCameraAdjust>(config.技能修正曲线配置);
		this.AutoConfig = CameraConfig.LoadConfigMap<EFightCameraAuto>(config.自动镜头);
		this.CurveAutoConfig = CameraConfig.LoadCurveConfigMap<EFightCameraAuto>(config.自动镜头曲线配置);
		this.FocusConfig = CameraConfig.LoadConfigMap<EFightCameraFocus>(config.锁定镜头);
		this.CurveFocusConfig = CameraConfig.LoadCurveConfigMap<EFightCameraFocus>(config.锁定镜头曲线配置);
		this.InputConfig = CameraConfig.LoadConfigMap<EFightCameraInput>(config.镜头输入);
		this.CurveInputConfig = CameraConfig.LoadCurveConfigMap<EFightCameraInput>(config.镜头输入曲线配置);
		this.ModifyConfig = CameraConfig.LoadConfigMap<EFightCameraModify>(config.Modify镜头);
		this.CurveModifyConfig = CameraConfig.LoadCurveConfigMap<EFightCameraModify>(config.Modify镜头曲线配置);
		this.GuideConfig = CameraConfig.LoadConfigMap<EFightCameraGuide>(config.引导镜头);
		this.CurveGuideConfig = CameraConfig.LoadCurveConfigMap<EFightCameraGuide>(config.引导镜头曲线配置);
		this.ExploreConfig = CameraConfig.LoadConfigMap<EFightCameraExplore>(config.跑图镜头);
		this.CurveExploreConfig = CameraConfig.LoadCurveConfigMap<EFightCameraExplore>(config.跑图镜头曲线配置);
		this.DialogueConfig = CameraConfig.LoadConfigMap<EFightCameraDialogue>(config.对话镜头);
		this.CurveDialogueConfig = CameraConfig.LoadCurveConfigMap<EFightCameraDialogue>(config.对话镜头曲线配置);
		this.ClimbConfig = CameraConfig.LoadConfigMap<EFightCameraClimb>(config.攀爬镜头);
		this.CurveClimbConfig = CameraConfig.LoadCurveConfigMap<EFightCameraClimb>(config.攀爬镜头曲线配置);
		this.SidestepConfig = CameraConfig.LoadConfigMap<EFightCameraSidestep>(config.移动自动镜头);
		this.CurveSidestepConfig = CameraConfig.LoadCurveConfigMap<EFightCameraSidestep>(config.移动自动镜头曲线配置);
		this.VehicleConfig = FightCameraLogicComponent.TMapToMap<EFightCameraVehicle>(config.载具镜头);
		this.VehicleCurveConfig = FightCameraLogicComponent.TMapToCurveMap<EFightCameraVehicle>(config.载具镜头曲线配置);
		this.GravityConfig = CameraConfig.LoadConfigMap<EFightCameraGravity>(config.镜头重力);
		this.IsOpenMainLoop = config.是否开启主镜头缓入缓出;
		this.IsResetDefaultConfig = config.是否重置默认配置;
		this.IsResetCameraLock = config.是否重置镜头锁定;
		this.IsUniqueFade = config.是否独立过渡时间;
		this.CameraArmLocationSocketName = config.主控角色骨骼;
		this.CameraArmLocationSocketOverrideType = config.主控角色骨骼覆盖方式;
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000A7798 File Offset: 0x000A5998
	[NullableContext(0)]
	[return: Nullable(2)]
	private static Dictionary<int, float> LoadConfigMap<TEnum>([Nullable(new byte[]
	{
		1,
		0,
		0
	})] TMap<TEnumAsByte<TEnum>, float> source) where TEnum : struct, Enum
	{
		int num = source.Num();
		if (num < 0)
		{
			return null;
		}
		Dictionary<int, float> dictionary = new Dictionary<int, float>(num);
		foreach (KeyValuePair<TEnumAsByte<TEnum>, float> keyValuePair in source)
		{
			TEnumAsByte<TEnum> tenumAsByte;
			float num2;
			keyValuePair.Deconstruct(out tenumAsByte, out num2);
			TEnumAsByte<TEnum> value = tenumAsByte;
			float value2 = num2;
			dictionary[Convert.ToInt32(value)] = value2;
		}
		return dictionary;
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000A7820 File Offset: 0x000A5A20
	[NullableContext(0)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, CurveBase> LoadCurveConfigMap<TEnum>([Nullable(new byte[]
	{
		1,
		0,
		0,
		1
	})] TMap<TEnumAsByte<TEnum>, SBaseCurve> source) where TEnum : struct, Enum
	{
		int num = source.Num();
		if (num < 0)
		{
			return null;
		}
		Dictionary<int, CurveBase> dictionary = new Dictionary<int, CurveBase>(num);
		foreach (KeyValuePair<TEnumAsByte<TEnum>, SBaseCurve> keyValuePair in source)
		{
			TEnumAsByte<TEnum> tenumAsByte;
			SBaseCurve sbaseCurve;
			keyValuePair.Deconstruct(out tenumAsByte, out sbaseCurve);
			TEnumAsByte<TEnum> value = tenumAsByte;
			SBaseCurve curveStruct = sbaseCurve;
			dictionary[Convert.ToInt32(value)] = CurveUtils.CreateCurveByStruct(curveStruct);
		}
		return dictionary;
	}

	// Token: 0x04001391 RID: 5009
	public EFightCameraType Type;

	// Token: 0x04001392 RID: 5010
	public FGameplayTag? Tag;

	// Token: 0x04001393 RID: 5011
	public bool PcValid;

	// Token: 0x04001394 RID: 5012
	public bool MobileValid;

	// Token: 0x04001395 RID: 5013
	public int Priority;

	// Token: 0x04001396 RID: 5014
	public bool EnableModifyCamera;

	// Token: 0x04001397 RID: 5015
	public bool EnableAdjustCamera;

	// Token: 0x04001398 RID: 5016
	public bool EnableAutoCamera;

	// Token: 0x04001399 RID: 5017
	public bool EnableFocusCamera;

	// Token: 0x0400139A RID: 5018
	public bool EnableSidestepCamera;

	// Token: 0x0400139B RID: 5019
	public bool EnableClimbCamera;

	// Token: 0x0400139C RID: 5020
	public float FadeInTime;

	// Token: 0x0400139D RID: 5021
	public CurveBase FadeInCurve;

	// Token: 0x0400139E RID: 5022
	public float FadeOutTime;

	// Token: 0x0400139F RID: 5023
	public CurveBase FadeOutCurve;

	// Token: 0x040013A0 RID: 5024
	public bool IsOpenMainLoop;

	// Token: 0x040013A1 RID: 5025
	public string[] LockOnParts;

	// Token: 0x040013A2 RID: 5026
	public Dictionary<EFightCameraDefault, float> DefaultConfig;

	// Token: 0x040013A3 RID: 5027
	public Dictionary<EFightCameraDefault, CurveBase> DefaultCurveConfig;

	// Token: 0x040013A4 RID: 5028
	public Dictionary<int, float> AdjustConfig;

	// Token: 0x040013A5 RID: 5029
	public Dictionary<int, CurveBase> CurveAdjustConfig;

	// Token: 0x040013A6 RID: 5030
	public Dictionary<int, float> AutoConfig;

	// Token: 0x040013A7 RID: 5031
	public Dictionary<int, CurveBase> CurveAutoConfig;

	// Token: 0x040013A8 RID: 5032
	public Dictionary<int, float> FocusConfig;

	// Token: 0x040013A9 RID: 5033
	public Dictionary<int, CurveBase> CurveFocusConfig;

	// Token: 0x040013AA RID: 5034
	public Dictionary<int, float> InputConfig;

	// Token: 0x040013AB RID: 5035
	public Dictionary<int, CurveBase> CurveInputConfig;

	// Token: 0x040013AC RID: 5036
	public Dictionary<int, float> ModifyConfig;

	// Token: 0x040013AD RID: 5037
	public Dictionary<int, CurveBase> CurveModifyConfig;

	// Token: 0x040013AE RID: 5038
	public Dictionary<int, float> GuideConfig;

	// Token: 0x040013AF RID: 5039
	public Dictionary<int, CurveBase> CurveGuideConfig;

	// Token: 0x040013B0 RID: 5040
	public Dictionary<int, float> ExploreConfig;

	// Token: 0x040013B1 RID: 5041
	public Dictionary<int, CurveBase> CurveExploreConfig;

	// Token: 0x040013B2 RID: 5042
	public Dictionary<int, float> DialogueConfig;

	// Token: 0x040013B3 RID: 5043
	public Dictionary<int, CurveBase> CurveDialogueConfig;

	// Token: 0x040013B4 RID: 5044
	public Dictionary<int, float> ClimbConfig;

	// Token: 0x040013B5 RID: 5045
	public Dictionary<int, CurveBase> CurveClimbConfig;

	// Token: 0x040013B6 RID: 5046
	public Dictionary<int, float> SidestepConfig;

	// Token: 0x040013B7 RID: 5047
	public Dictionary<int, CurveBase> CurveSidestepConfig;

	// Token: 0x040013B8 RID: 5048
	public Dictionary<EFightCameraVehicle, float> VehicleConfig;

	// Token: 0x040013B9 RID: 5049
	public Dictionary<EFightCameraVehicle, CurveBase> VehicleCurveConfig;

	// Token: 0x040013BA RID: 5050
	public Dictionary<int, float> GravityConfig;

	// Token: 0x040013BB RID: 5051
	public Dictionary<int, CurveBase> GravityCurveConfig = new Dictionary<int, CurveBase>();

	// Token: 0x040013BC RID: 5052
	public bool IsResetDefaultConfig;

	// Token: 0x040013BD RID: 5053
	public bool IsResetCameraLock;

	// Token: 0x040013BE RID: 5054
	public bool IsUniqueFade;

	// Token: 0x040013BF RID: 5055
	public FName CameraArmLocationSocketName = FNameUtil.EMPTY;

	// Token: 0x040013C0 RID: 5056
	public EFightCameraSocketOverrideType CameraArmLocationSocketOverrideType;
}
