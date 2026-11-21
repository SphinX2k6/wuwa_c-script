using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.PilotThrow;
using UnrealEngine;

// Token: 0x02001ACC RID: 6860
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PilotThrowModel : ModelBase
{
	// Token: 0x17001980 RID: 6528
	// (get) Token: 0x06011048 RID: 69704 RVA: 0x00500314 File Offset: 0x004FE514
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

	// Token: 0x17001981 RID: 6529
	// (get) Token: 0x06011049 RID: 69705 RVA: 0x00500350 File Offset: 0x004FE550
	public float AimPointInRangeDist
	{
		get
		{
			BP_PilotThrowGameplaySetting_C setting = this.Setting;
			return (float)(setting.目标点高亮距离 * setting.目标点高亮距离);
		}
	}

	// Token: 0x0601104A RID: 69706 RVA: 0x00500372 File Offset: 0x004FE572
	public void InitInteractInfo(int hookPointPbDataId, int titanEntityId, List<IPilotThrowTarget> pilotThrowTargets)
	{
		this.CurrentInteractHookPoint = hookPointPbDataId;
		this.TitanEntityId = titanEntityId;
		this.PilotThrowTargets = pilotThrowTargets;
	}

	// Token: 0x0601104B RID: 69707 RVA: 0x00500389 File Offset: 0x004FE589
	public int GetCurrentInteractHookPoint()
	{
		return this.CurrentInteractHookPoint;
	}

	// Token: 0x0601104C RID: 69708 RVA: 0x00500391 File Offset: 0x004FE591
	public int GetCurrentTitanEntityId()
	{
		return this.TitanEntityId;
	}

	// Token: 0x0601104D RID: 69709 RVA: 0x00500399 File Offset: 0x004FE599
	public IReadOnlyList<IPilotThrowTarget> GetPilotThrowTargets()
	{
		return this.PilotThrowTargets;
	}

	// Token: 0x0601104E RID: 69710 RVA: 0x005003A4 File Offset: 0x004FE5A4
	public float GetSwitchAimTargetTime()
	{
		return ConfigCommonParamById.GetFloatConfig("PilotThrowSwitchTargetTime").Value;
	}

	// Token: 0x0601104F RID: 69711 RVA: 0x005003C4 File Offset: 0x004FE5C4
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

	// Token: 0x06011050 RID: 69712 RVA: 0x00500410 File Offset: 0x004FE610
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

	// Token: 0x17001982 RID: 6530
	// (get) Token: 0x06011051 RID: 69713 RVA: 0x00500433 File Offset: 0x004FE633
	public static PilotThrowModel Instance
	{
		get
		{
			return PilotThrowModel._Instance;
		}
	}

	// Token: 0x06011052 RID: 69714 RVA: 0x0050043A File Offset: 0x004FE63A
	public static PilotThrowModel GetOrCreateInstance()
	{
		if (PilotThrowModel._Instance == null)
		{
			PilotThrowModel.CreateInstance();
		}
		return PilotThrowModel._Instance;
	}

	// Token: 0x06011053 RID: 69715 RVA: 0x0050044E File Offset: 0x004FE64E
	public static bool CreateInstance()
	{
		if (PilotThrowModel._Instance != null)
		{
			return true;
		}
		PilotThrowModel._Instance = new PilotThrowModel();
		return true;
	}

	// Token: 0x06011054 RID: 69716 RVA: 0x00500464 File Offset: 0x004FE664
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011055 RID: 69717 RVA: 0x00500466 File Offset: 0x004FE666
	public static void ResetStaticDefaultValue()
	{
		PilotThrowModel._Instance = null;
	}

	// Token: 0x06011056 RID: 69718 RVA: 0x0050046E File Offset: 0x004FE66E
	static PilotThrowModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PilotThrowModel.CreateStaticDefaultValue), new Action(PilotThrowModel.ResetStaticDefaultValue));
	}

	// Token: 0x040095D6 RID: 38358
	private int CurrentInteractHookPoint;

	// Token: 0x040095D7 RID: 38359
	private int TitanEntityId;

	// Token: 0x040095D8 RID: 38360
	private List<IPilotThrowTarget> PilotThrowTargets = new List<IPilotThrowTarget>();

	// Token: 0x040095D9 RID: 38361
	[Nullable(2)]
	private BP_PilotThrowGameplaySetting_C SettingDataAsset;

	// Token: 0x040095DA RID: 38362
	[Nullable(2)]
	public global::Vector CurrentInRangePoint;

	// Token: 0x040095DB RID: 38363
	public global::Vector LaunchDirection = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040095DC RID: 38364
	public float LaunchSpeed;

	// Token: 0x040095DD RID: 38365
	public float LaunchGravity;

	// Token: 0x040095DE RID: 38366
	public bool NeedMotorRide;

	// Token: 0x040095DF RID: 38367
	public bool DisableInterrupt;

	// Token: 0x040095E0 RID: 38368
	[Nullable(2)]
	public global::Vector ForceLookDir;

	// Token: 0x040095E1 RID: 38369
	public Rotator CameraRot = Rotator.Create(0f, 0f, 0f);

	// Token: 0x040095E2 RID: 38370
	public global::Vector CameraLoc = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040095E3 RID: 38371
	public global::Vector ProjectileSplineLastPoint = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040095E4 RID: 38372
	[Nullable(2)]
	private static PilotThrowModel _Instance;
}
