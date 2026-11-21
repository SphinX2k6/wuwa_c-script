using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Ui;

// Token: 0x02001467 RID: 5223
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InstanceDungeonConfig : ConfigBase
{
	// Token: 0x0600CFCE RID: 53198 RVA: 0x003DC07F File Offset: 0x003DA27F
	protected override bool OnInit()
	{
		this.LimitViewCheckMap[EUiViewName.RoleRootView] = new Func<bool>(this.CheckLimitRoleRootView);
		this.LimitViewCheckMap[EUiViewName.WeaponRootView] = new Func<bool>(this.CheckLimitWeaponRootView);
		return true;
	}

	// Token: 0x0600CFCF RID: 53199 RVA: 0x003DC0BC File Offset: 0x003DA2BC
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

	// Token: 0x0600CFD0 RID: 53200 RVA: 0x003DC190 File Offset: 0x003DA390
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

	// Token: 0x0600CFD1 RID: 53201 RVA: 0x003DC1E8 File Offset: 0x003DA3E8
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

	// Token: 0x0600CFD2 RID: 53202 RVA: 0x003DC240 File Offset: 0x003DA440
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

	// Token: 0x0600CFD3 RID: 53203 RVA: 0x003DC298 File Offset: 0x003DA498
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

	// Token: 0x0600CFD4 RID: 53204 RVA: 0x003DC2F0 File Offset: 0x003DA4F0
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

	// Token: 0x0600CFD5 RID: 53205 RVA: 0x003DC348 File Offset: 0x003DA548
	public int GetLimitChallengeTimes(int id)
	{
		InstanceEnterControl? countConfig = this.GetCountConfig(id);
		if (countConfig == null)
		{
			return 0;
		}
		return countConfig.GetValueOrDefault().EnterCount;
	}

	// Token: 0x0600CFD6 RID: 53206 RVA: 0x003DC378 File Offset: 0x003DA578
	public bool CheckViewShield(int id, EUiViewName viewName)
	{
		InstanceDungeon? config = this.GetConfig(id);
		if (config == null)
		{
			return false;
		}
		if (config.Value.LimitViewNameLength == 0)
		{
			return false;
		}
		bool flag = false;
		foreach (string text in config.Value.LimitViewNameIter())
		{
			EUiViewName[] array;
			if (text == viewName.ToString() || (this.LimitViewNameMapping.TryGetValue(text, out array) && Array.IndexOf<EUiViewName>(array, viewName) >= 0))
			{
				flag = true;
				break;
			}
		}
		Func<bool> func;
		return flag && (!this.LimitViewCheckMap.TryGetValue(viewName, out func) || func());
	}

	// Token: 0x0600CFD7 RID: 53207 RVA: 0x003DC448 File Offset: 0x003DA648
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

	// Token: 0x0600CFD8 RID: 53208 RVA: 0x003DC50B File Offset: 0x003DA70B
	private bool CheckLimitWeaponRootView()
	{
		return this.CheckLimitRoleRootView();
	}

	// Token: 0x0600CFD9 RID: 53209 RVA: 0x003DC514 File Offset: 0x003DA714
	private bool TeamRoleSelectIsOpen()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.TeamRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.MultiTeamRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView) || UiManager.Instance.IsViewOpen(EUiViewName.AdamSmasherFormationView) || UiManager.Instance.IsViewOpen(EUiViewName.TowerChallengeFormationView);
	}

	// Token: 0x0600CFDA RID: 53210 RVA: 0x003DC584 File Offset: 0x003DA784
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

	// Token: 0x0600CFDB RID: 53211 RVA: 0x003DC5B4 File Offset: 0x003DA7B4
	public string GetUnlockConditionGroupHintText(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return ((config != null) ? config.GetValueOrDefault().EnterConditionText : null) ?? string.Empty;
	}

	// Token: 0x0600CFDC RID: 53212 RVA: 0x003DC5F0 File Offset: 0x003DA7F0
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

	// Token: 0x0600CFDD RID: 53213 RVA: 0x003DC664 File Offset: 0x003DA864
	public int? GetInstanceRewardId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().RewardId);
	}

	// Token: 0x0600CFDE RID: 53214 RVA: 0x003DC6A0 File Offset: 0x003DA8A0
	public int? GetInstanceFirstRewardId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().FirstRewardId);
	}

	// Token: 0x0600CFDF RID: 53215 RVA: 0x003DC6DC File Offset: 0x003DA8DC
	public bool IsMiniMapShow(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return ((config != null) ? config.GetValueOrDefault().MiniMapId : 0) != 0;
	}

	// Token: 0x0600CFE0 RID: 53216 RVA: 0x003DC710 File Offset: 0x003DA910
	[NullableContext(0)]
	public ValueTuple<int, int> GetGuide(int id)
	{
		InstanceDungeon? config = this.GetConfig(id);
		return new ValueTuple<int, int>((config != null) ? config.GetValueOrDefault().GuideType : 0, (config != null) ? config.GetValueOrDefault().GuideValue : 0);
	}

	// Token: 0x0600CFE1 RID: 53217 RVA: 0x003DC760 File Offset: 0x003DA960
	public TowerDefenceInstance? GetTowerDefenseInstanceByInstance(int id)
	{
		return ConfigTowerDefenceInstanceByInstanceId.GetConfig(id, true);
	}

	// Token: 0x0600CFE2 RID: 53218 RVA: 0x003DC769 File Offset: 0x003DA969
	public TowerDefenseConfig? GetTowerDefenseConfigByActivityId(int id)
	{
		return ConfigTowerDefenseConfigById.GetConfig(id, true);
	}

	// Token: 0x0600CFE3 RID: 53219 RVA: 0x003DC772 File Offset: 0x003DA972
	public TowerDefenseSettle? GetTowerDefenseSettleById(int id)
	{
		return ConfigTowerDefenseSettleById.GetConfig(id, true);
	}

	// Token: 0x0600CFE4 RID: 53220 RVA: 0x003DC77B File Offset: 0x003DA97B
	public TowerDefenceInstance? GetTowerDefenseConfigById(int id)
	{
		return ConfigTowerDefenceInstanceById.GetConfig(id, true);
	}

	// Token: 0x0600CFE5 RID: 53221 RVA: 0x003DC784 File Offset: 0x003DA984
	public int GetTowerDefenseRankListSize()
	{
		return ConfigCommonParamById.GetIntConfig("TowerDefenceRankListSize").Value;
	}

	// Token: 0x0600CFE6 RID: 53222 RVA: 0x003DC7A3 File Offset: 0x003DA9A3
	public TowerDefencePhantom? GetTowerDefensePhantomById(int id)
	{
		return ConfigTowerDefencePhantomById.GetConfig(id, true);
	}

	// Token: 0x0600CFE7 RID: 53223 RVA: 0x003DC7AC File Offset: 0x003DA9AC
	public int? GetInstanceMapConfigId(int id)
	{
		if (this.GetConfig(id) == null)
		{
			return null;
		}
		InstanceDungeon? instanceDungeon;
		return new int?(instanceDungeon.GetValueOrDefault().MapConfigId);
	}

	// Token: 0x17001374 RID: 4980
	// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x003DC7E8 File Offset: 0x003DA9E8
	public static InstanceDungeonConfig Instance
	{
		get
		{
			return InstanceDungeonConfig._Instance;
		}
	}

	// Token: 0x0600CFE9 RID: 53225 RVA: 0x003DC7EF File Offset: 0x003DA9EF
	public static InstanceDungeonConfig GetOrCreateInstance()
	{
		if (InstanceDungeonConfig._Instance == null)
		{
			InstanceDungeonConfig.CreateInstance();
		}
		return InstanceDungeonConfig._Instance;
	}

	// Token: 0x0600CFEA RID: 53226 RVA: 0x003DC803 File Offset: 0x003DAA03
	public static bool CreateInstance()
	{
		if (InstanceDungeonConfig._Instance != null)
		{
			return true;
		}
		InstanceDungeonConfig._Instance = new InstanceDungeonConfig();
		return true;
	}

	// Token: 0x0600CFEB RID: 53227 RVA: 0x003DC819 File Offset: 0x003DAA19
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CFEC RID: 53228 RVA: 0x003DC81B File Offset: 0x003DAA1B
	public static void ResetStaticDefaultValue()
	{
		InstanceDungeonConfig._Instance = null;
	}

	// Token: 0x0600CFED RID: 53229 RVA: 0x003DC823 File Offset: 0x003DAA23
	static InstanceDungeonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonConfig.CreateStaticDefaultValue), new Action(InstanceDungeonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0600CFEE RID: 53230 RVA: 0x003DC844 File Offset: 0x003DAA44
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

	// Token: 0x040075FA RID: 30202
	private readonly Dictionary<string, EUiViewName[]> LimitViewNameMapping;

	// Token: 0x040075FB RID: 30203
	private readonly Dictionary<int, TWorldLevelToRecommendLevel[]> RecommendLevelLookupMap;

	// Token: 0x040075FC RID: 30204
	private readonly Dictionary<EUiViewName, Func<bool>> LimitViewCheckMap;

	// Token: 0x040075FD RID: 30205
	[Nullable(2)]
	private static InstanceDungeonConfig _Instance;
}
