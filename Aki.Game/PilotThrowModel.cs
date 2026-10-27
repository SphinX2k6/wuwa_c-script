using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.PilotThrow;
using UnrealEngine;

// Token: 0x020025E1 RID: 9697
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PilotThrowModel : ModelBase
{
	// Token: 0x17001948 RID: 6472
	// (get) Token: 0x06013B66 RID: 80742 RVA: 0x004F15E4 File Offset: 0x004EF7E4
	[Nullable(2)]
	public BP_PilotThrowGameplaySetting_C Setting
	{
		[NullableContext(2)]
		get
		{
			if (this.SettingDataAsset == null)
			{
				Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowModel] SettingDataAsset is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.SettingDataAsset;
		}
	}

	// Token: 0x17001949 RID: 6473
	// (get) Token: 0x06013B67 RID: 80743 RVA: 0x004F1620 File Offset: 0x004EF820
	public float AimPointInRangeDist
	{
		get
		{
			BP_PilotThrowGameplaySetting_C setting = this.Setting;
			return (float)(setting.目标点高亮距离 * setting.目标点高亮距离);
		}
	}

	// Token: 0x06013B68 RID: 80744 RVA: 0x004F1642 File Offset: 0x004EF842
	public void InitInteractInfo(int hookPointPbDataId, int titanEntityId, List<IPilotThrowTarget> pilotThrowTargets)
	{
		this.CurrentInteractHookPoint = hookPointPbDataId;
		this.TitanEntityId = titanEntityId;
		this.PilotThrowTargets = pilotThrowTargets;
	}

	// Token: 0x06013B69 RID: 80745 RVA: 0x004F1659 File Offset: 0x004EF859
	public int GetCurrentInteractHookPoint()
	{
		return this.CurrentInteractHookPoint;
	}

	// Token: 0x06013B6A RID: 80746 RVA: 0x004F1661 File Offset: 0x004EF861
	public int GetCurrentTitanEntityId()
	{
		return this.TitanEntityId;
	}

	// Token: 0x06013B6B RID: 80747 RVA: 0x004F1669 File Offset: 0x004EF869
	public IReadOnlyList<IPilotThrowTarget> GetPilotThrowTargets()
	{
		return this.PilotThrowTargets;
	}

	// Token: 0x06013B6C RID: 80748 RVA: 0x004F1674 File Offset: 0x004EF874
	public float GetSwitchAimTargetTime()
	{
		return ConfigCommonParamById.GetFloatConfig("PilotThrowSwitchTargetTime").Value;
	}

	// Token: 0x06013B6D RID: 80749 RVA: 0x004F1694 File Offset: 0x004EF894
	public bool IsInProjectileSplineLastPointRange(global::Vector point)
	{
		USplineComponent projectileSpline = PilotThrowController.Instance.ProjectileSpline;
		if (projectileSpline == null)
		{
			return false;
		}
		USplineComponent usplineComponent = projectileSpline;
		FVectorDouble fvectorDouble = point.ToUeVector(false);
		global::Vector v = global::Vector.Create(usplineComponent.D_FindLocationClosestToWorldLocation(fvectorDouble, ESplineCoordinateSpace.World));
		return global::Vector.DistSquared(point, v) <= (double)this.AimPointInRangeDist;
	}

	// Token: 0x06013B6E RID: 80750 RVA: 0x004F16E0 File Offset: 0x004EF8E0
	protected override bool OnInit()
	{
		ResourceSystem.Instance.LoadTypeAsync("BP_PilotThrowGameplaySetting_C", delegate
		{
			ResourceSystem.Instance.LoadAsync<BP_PilotThrowGameplaySetting_C>("/Game/Aki/Data/Gameplay/PilotThrow/DA_PilotThrowSetting.DA_PilotThrowSetting", delegate([Nullable(2)] BP_PilotThrowGameplaySetting_C result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PilotThrow;
					ELogAuthor author = ELogAuthor.CH;
					string message = "[PilotThrowModel] Load DA_PilotThrowSetting Failed";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Data/Gameplay/PilotThrow/DA_PilotThrowSetting.DA_PilotThrowSetting");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.SettingDataAsset = result;
			}, 100, "js_undefined");
		}, "js_undefined");
		return true;
	}

	// Token: 0x1700194A RID: 6474
	// (get) Token: 0x06013B6F RID: 80751 RVA: 0x004F1703 File Offset: 0x004EF903
	public static PilotThrowModel Instance
	{
		get
		{
			return PilotThrowModel._Instance;
		}
	}

	// Token: 0x06013B70 RID: 80752 RVA: 0x004F170A File Offset: 0x004EF90A
	public static PilotThrowModel GetOrCreateInstance()
	{
		if (PilotThrowModel._Instance == null)
		{
			PilotThrowModel.CreateInstance();
		}
		return PilotThrowModel._Instance;
	}

	// Token: 0x06013B71 RID: 80753 RVA: 0x004F171E File Offset: 0x004EF91E
	public static bool CreateInstance()
	{
		if (PilotThrowModel._Instance != null)
		{
			return true;
		}
		PilotThrowModel._Instance = new PilotThrowModel();
		return true;
	}

	// Token: 0x06013B72 RID: 80754 RVA: 0x004F1734 File Offset: 0x004EF934
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013B73 RID: 80755 RVA: 0x004F1736 File Offset: 0x004EF936
	public static void ResetStaticDefaultValue()
	{
		PilotThrowModel._Instance = null;
	}

	// Token: 0x06013B74 RID: 80756 RVA: 0x004F173E File Offset: 0x004EF93E
	static PilotThrowModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PilotThrowModel.CreateStaticDefaultValue), new Action(PilotThrowModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400947F RID: 38015
	private int CurrentInteractHookPoint;

	// Token: 0x04009480 RID: 38016
	private int TitanEntityId;

	// Token: 0x04009481 RID: 38017
	private List<IPilotThrowTarget> PilotThrowTargets = new List<IPilotThrowTarget>();

	// Token: 0x04009482 RID: 38018
	[Nullable(2)]
	private BP_PilotThrowGameplaySetting_C SettingDataAsset;

	// Token: 0x04009483 RID: 38019
	[Nullable(2)]
	public global::Vector CurrentInRangePoint;

	// Token: 0x04009484 RID: 38020
	public global::Vector LaunchDirection = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04009485 RID: 38021
	public float LaunchSpeed;

	// Token: 0x04009486 RID: 38022
	public float LaunchGravity;

	// Token: 0x04009487 RID: 38023
	public bool NeedMotorRide;

	// Token: 0x04009488 RID: 38024
	public bool DisableInterrupt;

	// Token: 0x04009489 RID: 38025
	[Nullable(2)]
	public global::Vector ForceLookDir;

	// Token: 0x0400948A RID: 38026
	public Rotator CameraRot = Rotator.Create(0f, 0f, 0f);

	// Token: 0x0400948B RID: 38027
	public global::Vector CameraLoc = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400948C RID: 38028
	public global::Vector ProjectileSplineLastPoint = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400948D RID: 38029
	[Nullable(2)]
	private static PilotThrowModel _Instance;
}
