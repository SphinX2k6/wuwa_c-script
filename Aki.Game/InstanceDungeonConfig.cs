using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Ui;

// Token: 0x02001FA5 RID: 8101
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InstanceDungeonConfig : ConfigBase
{
	// Token: 0x0600FBAC RID: 64428 RVA: 0x003D044B File Offset: 0x003CE64B
	protected override bool OnInit()
	{
		this.LimitViewCheckMap[EUiViewName.RoleRootView] = new Func<bool>(this.CheckLimitRoleRootView);
		this.LimitViewCheckMap[EUiViewName.WeaponRootView] = new Func<bool>(this.CheckLimitWeaponRootView);
		return true;
	}

	// Token: 0x0600FBAD RID: 64429 RVA: 0x003D0488 File Offset: 0x003CE688
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private TWorldLevelToRecommendLevel[] TryGetRecommendLevelLookupList(int id)
	{
		TWorldLevelToRecommendLevel[] array;
		if (!this.RecommendLevelLookupMap.TryGetValue(id, out array))
		{
			InstanceDungeon? config = this.GetConfig(id);
			if (config != null)
			{
				int recommendLevelLength = config.Value.RecommendLevelLength;
				array = new TWorldLevelToRecommendLevel[recommendLevelLength];
				for (int i = 0; i < recommendLevelLength; i++)
				{
					DicIntInt? dicIntInt = config.Value.RecommendLevel(i);
					if (dicIntInt != null)
					{
						array[i] = new TWorldLevelToRecommendLevel(dicIntInt.Value.Key, dicIntInt.Value.Value);
					}
				}
				Array.Sort<TWorldLevelToRecommendLevel>(array, (TWorldLevelToRecommendLevel a, TWorldLevelToRecommendLevel b) => a.Item1 - b.Item1);
				this.RecommendLevelLookupMap[id] = array;
			}
		}
		return array;
	}

	// Token: 0x0600FBAE RID: 64430 RVA: 0x003D055C File Offset: 0x003CE75C
	public InstanceDungeon? GetConfig(int id)
	{
		InstanceDungeon? config = ConfigInstanceDungeonById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.TL;
			string message = "获取副本配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600FBAF RID: 64431 RVA: 0x003D05B4 File Offset: 0x003CE7B4
	public InstanceEnterControl? GetCountConfig(int id)
	{
		InstanceEnterControl? config = ConfigInstanceEnterControlById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.TL;
			string message = "获取副本配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600FBB0 RID: 64432 RVA: 0x003D060C File Offset: 0x003CE80C
	public InstanceDungeonTitle? GetTitleConfig(int id)
	{
		InstanceDungeonTitle? config = ConfigInstanceDungeonTitleById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.TL;
			string message = "获取副本标题配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600FBB1 RID: 64433 RVA: 0x003D0664 File Offset: 0x003CE864
	public InstanceTrialRoleConfig? GetTrialRoleConfig(int id)
	{
		InstanceTrialRoleConfig? config = ConfigInstanceTrialRoleConfigById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "获取副本试用角色配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600FBB2 RID: 64434 RVA: 0x003D06BC File Offset: 0x003CE8BC
	public InstanceGameplayMode? GetGameplayModeConfig(int id)
	{
		InstanceGameplayMode? config = ConfigInstanceGameplayModeById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InstanceDungeon;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "获取副本玩法模式配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600FBB3 RID: 64435 RVA: 0x003D0714 File Offset: 0x003CE914
	public int GetLimitChallengeTimes(int id)
	{
		InstanceEnterControl? countConfig = this.GetCountConfig(id);
		if (countConfig == null)
		{
			return 0;
		}
		return countConfig.GetValueOrDefault().EnterCount;
	}

	// Token: 0x0600FBB4 RID: 64436 RVA: 0x003D0744 File Offset: 0x003CE944
	public bool CheckViewShield(int id, EUiViewName viewName)
	{
		InstanceDungeon? config = this.GetConfig(id);
		Func<bool> func;
		return config != null && config.Value.LimitViewNameLength != 0 && config.Value.LimitViewNameIter().Any(delegate(string name)
		{
			EUiViewName[] source;
			return name == viewName.ToString() || (this.LimitViewNameMapping.TryGetValue(name, out source) && source.Contains(viewName));
		}) && (!this.LimitViewCheckMap.TryGetValue(viewName, out func) || func());
	}

	// Token: 0x0600FBB5 RID: 64437 RVA: 0x003D07CC File Offset: 0x003CE9CC
	private bool CheckLimitRoleRootView()
	{
		if (TowerModel.Instance.CheckInTower())
		{
			return !this.TeamRoleSelectIsOpen();
		}
		if (ShipTowerModel.Instance.CheckInBattleShipTower())
		{
			return !UiManager.Instance.IsViewOpen(EUiViewName.ShipTowerDescView);
		}
		if (BabelTowerModel.Instance.CheckInBattleBabelTower())
		{
			return !UiManager.Instance.IsViewOpen(EUiViewName.BabelTowerHardLevelInfoViewNew);
		}
		if (LordGymController.Instance.IsInLordGymDungeon())
		{
			return !this.TeamRoleSelectIsOpen();
		}
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			return !UiManager.Instance.IsViewOpen(EUiViewName.WheelTowerTeamSelectView);
		}
		if (BossPilingModel.Instance.CheckIsBossPiling())
		{
			return !this.TeamRoleSelectIsOpen();
		}
		return !AdamSmasherController.Instance.IsInAdamSmasherDungeon() || !this.TeamRoleSelectIsOpen();
	}

	// Token: 0x0600FBB6 RID: 64438 RVA: 0x003D088F File Offset: 0x003CEA8F
	private bool CheckLimitWeaponRootView()
	{
		return this.CheckLimitRoleRootView();
	}

	// Token: 0x0600FBB7 RID: 64439 RVA: 0x003D0898 File Offset: 0x003CEA98
	private bool TeamRoleSelectIsOpen()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.TeamRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.MultiTeamRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.AdamSmasherFormationView) || UiManager.Instance.IsViewOpen(EUiViewName.TowerChallengeFormationView);
	}

	// Token: 0x0600FBB8 RID: 64440 RVA: 0x003D0908 File Offset: 0x003CEB08
	[NullableContext(2)]
	public int[] GetUnlockCondition(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().GetEnterConditionArray();
	}

	// Token: 0x0600FBB9 RID: 64441 RVA: 0x003D0938 File Offset: 0x003CEB38
	public string GetUnlockConditionGroupHintText(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return ((config != null) ? config.GetValueOrDefault().EnterConditionText : null) ?? string.Empty;
	}

	// Token: 0x0600FBBA RID: 64442 RVA: 0x003D0974 File Offset: 0x003CEB74
	public int GetRecommendLevel(int id, int worldLevel)
	{
		TWorldLevelToRecommendLevel[] array = this.TryGetRecommendLevelLookupList(id);
		if (array == null)
		{
			Log.Instance.Error(ELogModule.InstanceDungeon, ELogAuthor.TL, "推荐等级区间配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		int num = 0;
		foreach (TWorldLevelToRecommendLevel tworldLevelToRecommendLevel in array)
		{
			if (num == 0)
			{
				num = tworldLevelToRecommendLevel.Item2;
			}
			else if (worldLevel >= tworldLevelToRecommendLevel.Item1)
			{
				num = tworldLevelToRecommendLevel.Item2;
			}
		}
		return num;
	}

	// Token: 0x0600FBBB RID: 64443 RVA: 0x003D09E8 File Offset: 0x003CEBE8
	public int? GetInstanceRewardId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().RewardId);
	}

	// Token: 0x0600FBBC RID: 64444 RVA: 0x003D0A24 File Offset: 0x003CEC24
	public int? GetInstanceFirstRewardId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().FirstRewardId);
	}

	// Token: 0x0600FBBD RID: 64445 RVA: 0x003D0A60 File Offset: 0x003CEC60
	public bool IsMiniMapShow(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return ((config != null) ? config.GetValueOrDefault().MiniMapId : 0) != 0;
	}

	// Token: 0x0600FBBE RID: 64446 RVA: 0x003D0A94 File Offset: 0x003CEC94
	[NullableContext(0)]
	public ValueTuple<int, int> GetGuide(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return new ValueTuple<int, int>((config != null) ? config.GetValueOrDefault().GuideType : 0, (config != null) ? config.GetValueOrDefault().GuideValue : 0);
	}

	// Token: 0x0600FBBF RID: 64447 RVA: 0x003D0AE4 File Offset: 0x003CECE4
	public TowerDefenceInstance? GetTowerDefenseInstanceByInstance(int id)
	{
		return ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
	}

	// Token: 0x0600FBC0 RID: 64448 RVA: 0x003D0AED File Offset: 0x003CECED
	public TowerDefenseConfig? GetTowerDefenseConfigByActivityId(int id)
	{
		return ConfigTowerDefenseConfigById.GetConfig(id, true);
	}

	// Token: 0x0600FBC1 RID: 64449 RVA: 0x003D0AF6 File Offset: 0x003CECF6
	public TowerDefenseSettle? GetTowerDefenseSettleById(int id)
	{
		return ConfigTowerDefenseSettleById.GetConfig(id, true);
	}

	// Token: 0x0600FBC2 RID: 64450 RVA: 0x003D0AFF File Offset: 0x003CECFF
	public TowerDefenceInstance? GetTowerDefenseConfigById(int id)
	{
		return ConfigTowerDefenceInstanceById.GetConfig(id, true);
	}

	// Token: 0x0600FBC3 RID: 64451 RVA: 0x003D0B08 File Offset: 0x003CED08
	public int GetTowerDefenseRankListSize()
	{
		return ConfigCommonParamById.GetIntConfig("TowerDefenceRankListSize").Value;
	}

	// Token: 0x0600FBC4 RID: 64452 RVA: 0x003D0B27 File Offset: 0x003CED27
	public TowerDefencePhantom? GetTowerDefensePhantomById(int id)
	{
		return ConfigTowerDefencePhantomById.GetConfig(id, true);
	}

	// Token: 0x0600FBC5 RID: 64453 RVA: 0x003D0B30 File Offset: 0x003CED30
	public int? GetInstanceMapConfigId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().MapConfigId);
	}

	// Token: 0x1700134A RID: 4938
	// (get) Token: 0x0600FBC6 RID: 64454 RVA: 0x003D0B6C File Offset: 0x003CED6C
	public static InstanceDungeonConfig Instance
	{
		get
		{
			return InstanceDungeonConfig._Instance;
		}
	}

	// Token: 0x0600FBC7 RID: 64455 RVA: 0x003D0B73 File Offset: 0x003CED73
	public static InstanceDungeonConfig GetOrCreateInstance()
	{
		if (InstanceDungeonConfig._Instance == null)
		{
			InstanceDungeonConfig.CreateInstance();
		}
		return InstanceDungeonConfig._Instance;
	}

	// Token: 0x0600FBC8 RID: 64456 RVA: 0x003D0B87 File Offset: 0x003CED87
	public static bool CreateInstance()
	{
		if (InstanceDungeonConfig._Instance != null)
		{
			return true;
		}
		InstanceDungeonConfig._Instance = new InstanceDungeonConfig();
		return true;
	}

	// Token: 0x0600FBC9 RID: 64457 RVA: 0x003D0B9D File Offset: 0x003CED9D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FBCA RID: 64458 RVA: 0x003D0B9F File Offset: 0x003CED9F
	public static void ResetStaticDefaultValue()
	{
		InstanceDungeonConfig._Instance = null;
	}

	// Token: 0x0600FBCB RID: 64459 RVA: 0x003D0BA7 File Offset: 0x003CEDA7
	static InstanceDungeonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonConfig.CreateStaticDefaultValue), new Action(InstanceDungeonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0600FBCC RID: 64460 RVA: 0x003D0BC8 File Offset: 0x003CEDC8
	public InstanceDungeonConfig()
	{
		Dictionary<string, EUiViewName[]> dictionary = new Dictionary<string, EUiViewName[]>();
		dictionary["EditFormationView"] = new EUiViewName[]
		{
			EUiViewName.Formation2DView,
			EUiViewName.Formation3DView
		};
		dictionary["EditBattleTeamView"] = new EUiViewName[]
		{
			EUiViewName.BattleTeam2DView
		};
		this.LimitViewNameMapping = dictionary;
		this.RecommendLevelLookupMap = new Dictionary<int, TWorldLevelToRecommendLevel[]>();
		this.LimitViewCheckMap = new Dictionary<EUiViewName, Func<bool>>();
		base..ctor();
	}

	// Token: 0x04007517 RID: 29975
	private readonly Dictionary<string, EUiViewName[]> LimitViewNameMapping;

	// Token: 0x04007518 RID: 29976
	private readonly Dictionary<int, TWorldLevelToRecommendLevel[]> RecommendLevelLookupMap;

	// Token: 0x04007519 RID: 29977
	private readonly Dictionary<EUiViewName, Func<bool>> LimitViewCheckMap;

	// Token: 0x0400751A RID: 29978
	[Nullable(2)]
	private static InstanceDungeonConfig _Instance;
}
