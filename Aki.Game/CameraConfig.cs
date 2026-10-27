using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x020001F5 RID: 501
[NullableContext(1)]
[Nullable(0)]
public class CameraConfig
{
	// Token: 0x06001F87 RID: 8071 RVA: 0x000A00B0 File Offset: 0x0009E2B0
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

	// Token: 0x06001F88 RID: 8072 RVA: 0x000A03CC File Offset: 0x0009E5CC
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

	// Token: 0x06001F89 RID: 8073 RVA: 0x000A0450 File Offset: 0x0009E650
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

	// Token: 0x0400134E RID: 4942
	public EFightCameraType Type;

	// Token: 0x0400134F RID: 4943
	public FGameplayTag? Tag;

	// Token: 0x04001350 RID: 4944
	public bool PcValid;

	// Token: 0x04001351 RID: 4945
	public bool MobileValid;

	// Token: 0x04001352 RID: 4946
	public int Priority;

	// Token: 0x04001353 RID: 4947
	public bool EnableModifyCamera;

	// Token: 0x04001354 RID: 4948
	public bool EnableAdjustCamera;

	// Token: 0x04001355 RID: 4949
	public bool EnableAutoCamera;

	// Token: 0x04001356 RID: 4950
	public bool EnableFocusCamera;

	// Token: 0x04001357 RID: 4951
	public bool EnableSidestepCamera;

	// Token: 0x04001358 RID: 4952
	public bool EnableClimbCamera;

	// Token: 0x04001359 RID: 4953
	public float FadeInTime;

	// Token: 0x0400135A RID: 4954
	public CurveBase FadeInCurve;

	// Token: 0x0400135B RID: 4955
	public float FadeOutTime;

	// Token: 0x0400135C RID: 4956
	public CurveBase FadeOutCurve;

	// Token: 0x0400135D RID: 4957
	public bool IsOpenMainLoop;

	// Token: 0x0400135E RID: 4958
	public string[] LockOnParts;

	// Token: 0x0400135F RID: 4959
	public Dictionary<EFightCameraDefault, float> DefaultConfig;

	// Token: 0x04001360 RID: 4960
	public Dictionary<EFightCameraDefault, CurveBase> DefaultCurveConfig;

	// Token: 0x04001361 RID: 4961
	public Dictionary<int, float> AdjustConfig;

	// Token: 0x04001362 RID: 4962
	public Dictionary<int, CurveBase> CurveAdjustConfig;

	// Token: 0x04001363 RID: 4963
	public Dictionary<int, float> AutoConfig;

	// Token: 0x04001364 RID: 4964
	public Dictionary<int, CurveBase> CurveAutoConfig;

	// Token: 0x04001365 RID: 4965
	public Dictionary<int, float> FocusConfig;

	// Token: 0x04001366 RID: 4966
	public Dictionary<int, CurveBase> CurveFocusConfig;

	// Token: 0x04001367 RID: 4967
	public Dictionary<int, float> InputConfig;

	// Token: 0x04001368 RID: 4968
	public Dictionary<int, CurveBase> CurveInputConfig;

	// Token: 0x04001369 RID: 4969
	public Dictionary<int, float> ModifyConfig;

	// Token: 0x0400136A RID: 4970
	public Dictionary<int, CurveBase> CurveModifyConfig;

	// Token: 0x0400136B RID: 4971
	public Dictionary<int, float> GuideConfig;

	// Token: 0x0400136C RID: 4972
	public Dictionary<int, CurveBase> CurveGuideConfig;

	// Token: 0x0400136D RID: 4973
	public Dictionary<int, float> ExploreConfig;

	// Token: 0x0400136E RID: 4974
	public Dictionary<int, CurveBase> CurveExploreConfig;

	// Token: 0x0400136F RID: 4975
	public Dictionary<int, float> DialogueConfig;

	// Token: 0x04001370 RID: 4976
	public Dictionary<int, CurveBase> CurveDialogueConfig;

	// Token: 0x04001371 RID: 4977
	public Dictionary<int, float> ClimbConfig;

	// Token: 0x04001372 RID: 4978
	public Dictionary<int, CurveBase> CurveClimbConfig;

	// Token: 0x04001373 RID: 4979
	public Dictionary<int, float> SidestepConfig;

	// Token: 0x04001374 RID: 4980
	public Dictionary<int, CurveBase> CurveSidestepConfig;

	// Token: 0x04001375 RID: 4981
	public Dictionary<EFightCameraVehicle, float> VehicleConfig;

	// Token: 0x04001376 RID: 4982
	public Dictionary<EFightCameraVehicle, CurveBase> VehicleCurveConfig;

	// Token: 0x04001377 RID: 4983
	public Dictionary<int, float> GravityConfig;

	// Token: 0x04001378 RID: 4984
	public Dictionary<int, CurveBase> GravityCurveConfig = new Dictionary<int, CurveBase>();

	// Token: 0x04001379 RID: 4985
	public bool IsResetDefaultConfig;

	// Token: 0x0400137A RID: 4986
	public bool IsResetCameraLock;

	// Token: 0x0400137B RID: 4987
	public bool IsUniqueFade;

	// Token: 0x0400137C RID: 4988
	public FName CameraArmLocationSocketName = FNameUtil.EMPTY;

	// Token: 0x0400137D RID: 4989
	public EFightCameraSocketOverrideType CameraArmLocationSocketOverrideType;
}
