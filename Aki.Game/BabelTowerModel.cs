using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001177 RID: 4471
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BabelTowerModel : ModelBase
{
	// Token: 0x17000A37 RID: 2615
	// (get) Token: 0x06007616 RID: 30230 RVA: 0x00187E91 File Offset: 0x00186091
	[Nullable(2)]
	public BabelTowerInstanceData CurrentChallengeInstData
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentChallengeInstDataInternal;
		}
	}

	// Token: 0x06007617 RID: 30231 RVA: 0x00187E99 File Offset: 0x00186099
	public void SetTraceId(string traceId)
	{
		if (this.CurrentChallengeInstDataInternal != null)
		{
			this.CurrentChallengeInstDataInternal.TraceId = traceId;
		}
	}

	// Token: 0x06007618 RID: 30232 RVA: 0x00187EB0 File Offset: 0x001860B0
	protected override bool OnInit()
	{
		this.ItemCountMax = ConfigCommonParamById.GetIntConfig("BabelTowerItemCountMax").GetValueOrDefault();
		return true;
	}

	// Token: 0x06007619 RID: 30233 RVA: 0x00187ED8 File Offset: 0x001860D8
	public void UpdateCurrentChallengeInstDataByNotify(BabelActivityInstInfoNotify notify)
	{
		if (this.CurrentChallengeInstDataInternal == null)
		{
			this.CurrentChallengeInstDataInternal = new BabelTowerInstanceData();
		}
		int roleCD = notify.RoleCD;
		this.CurrentChallengeInstDataInternal.LevelId = notify.LevelId;
		this.CurrentChallengeInstDataInternal.CurStarNum = notify.CurStar;
		this.CurrentChallengeInstDataInternal.UseReviveCount = notify.UseReviveCount;
		this.CurrentChallengeInstDataInternal.RoleCd = roleCD;
		this.CurrentChallengeInstDataInternal.BuffSelection = ((notify.BuffSelection == null) ? null : new List<int>(notify.BuffSelection));
		this.CurrentChallengeInstDataInternal.DeTermIdList = ((notify.BabelDeTermId == null) ? null : new List<int>(notify.BabelDeTermId));
		if (roleCD > 0)
		{
			SceneTeamModel.Instance.UpdateChangeRoleCooldown((float)roleCD);
		}
		EventSystem.Instance.Emit(EEventName.OnBabelActivityInstInfoUpdate);
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x00187FA0 File Offset: 0x001861A0
	public bool GetIfLevelTooLow(int instanceId, int[] roleList)
	{
		int num = 0;
		int num2 = 0;
		foreach (int id in roleList)
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(id);
			if (roleInstanceById != null)
			{
				num += roleInstanceById.GetLevelData().GetLevel();
				num2++;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
			if (roleDataById != null)
			{
				num += roleDataById.GetLevelData().GetLevel();
				num2++;
			}
		}
		if (num2 <= 0)
		{
			return false;
		}
		double num3 = (double)num / (double)num2;
		return num3 < (double)this.GetRecommendLevel(instanceId) && num3 != 0.0;
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x0018803C File Offset: 0x0018623C
	public int GetRecommendLevel(int instanceId)
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x0600761C RID: 30236 RVA: 0x00188054 File Offset: 0x00186254
	public BabelTowerDifficulty? CalculateDifficultyConfigByStarNum(int activityId, int starNum)
	{
		IReadOnlyList<BabelTowerDifficulty> configList = ConfigBabelTowerDifficultyByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			return null;
		}
		for (int i = configList.Count - 1; i >= 0; i--)
		{
			BabelTowerDifficulty value = configList[i];
			if (starNum >= value.StarNum)
			{
				return new BabelTowerDifficulty?(value);
			}
		}
		return null;
	}

	// Token: 0x0600761D RID: 30237 RVA: 0x001880AC File Offset: 0x001862AC
	public List<int> GetSelectedDeTermList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in this.DeTermSelectInfo)
		{
			int key = keyValuePair.Key;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key != 0 && value.State == EBabelTowerDeTermState.Select)
			{
				list.Add(key);
			}
		}
		return list;
	}

	// Token: 0x0600761E RID: 30238 RVA: 0x00188124 File Offset: 0x00186324
	public List<int> GetAllActiveDeTermList()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in this.DeTermSelectInfo)
		{
			int key = keyValuePair.Key;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key != 0 && (value.State == EBabelTowerDeTermState.Select || value.State == EBabelTowerDeTermState.StaticSelect))
			{
				list.Add(key);
			}
		}
		return list;
	}

	// Token: 0x0600761F RID: 30239 RVA: 0x001881A8 File Offset: 0x001863A8
	public int GetCurrentDeTermStar()
	{
		int num = 0;
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in this.DeTermSelectInfo)
		{
			int key = keyValuePair.Key;
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (key != 0 && (value.State == EBabelTowerDeTermState.Select || value.State == EBabelTowerDeTermState.StaticSelect))
			{
				num += BabelTowerConfig.Instance.GetBabelTowerDeTerm(key).Star;
			}
		}
		return num;
	}

	// Token: 0x06007620 RID: 30240 RVA: 0x00188238 File Offset: 0x00186438
	public int GetSelectedDeTermCount()
	{
		int num = 0;
		foreach (KeyValuePair<int, IBabelTowerSelectInfo> keyValuePair in this.DeTermSelectInfo)
		{
			IBabelTowerSelectInfo value = keyValuePair.Value;
			if (value.State == EBabelTowerDeTermState.Select || value.State == EBabelTowerDeTermState.StaticSelect)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06007621 RID: 30241 RVA: 0x001882A8 File Offset: 0x001864A8
	[NullableContext(2)]
	public IBabelTowerSelectInfo GetDeTermSelectInfo(int deTermId)
	{
		return this.DeTermSelectInfo.GetValueOrDefault(deTermId);
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x001882B6 File Offset: 0x001864B6
	public int CoverStarNumToQualityId(int starNum)
	{
		return starNum + 2;
	}

	// Token: 0x06007623 RID: 30243 RVA: 0x001882BC File Offset: 0x001864BC
	public bool CheckInBattleBabelTower()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 30;
	}

	// Token: 0x06007624 RID: 30244 RVA: 0x00188310 File Offset: 0x00186510
	public bool CheckCanRevive()
	{
		BabelTowerInstanceData currentChallengeInstData = this.CurrentChallengeInstData;
		if (currentChallengeInstData == null)
		{
			return false;
		}
		BabelTowerLevel? config = ConfigBabelTowerLevelById.GetConfig(currentChallengeInstData.LevelId, true);
		int num = (config != null) ? config.Value.ReviveStar : 0;
		return currentChallengeInstData.CurStarNum >= num;
	}

	// Token: 0x06007625 RID: 30245 RVA: 0x0018835E File Offset: 0x0018655E
	public int GetCurStarNum()
	{
		BabelTowerInstanceData currentChallengeInstData = this.CurrentChallengeInstData;
		if (currentChallengeInstData == null)
		{
			return 0;
		}
		return currentChallengeInstData.CurStarNum;
	}

	// Token: 0x06007626 RID: 30246 RVA: 0x00188374 File Offset: 0x00186574
	public List<FormationData> GetPresetTeamList()
	{
		List<FormationData> list = new List<FormationData>();
		for (int i = 1; i <= 10; i++)
		{
			FormationData formationData = FormationModel.Instance.GetFormationData(i);
			if (formationData == null)
			{
				formationData = new FormationData(i);
			}
			list.Add(formationData);
		}
		return list;
	}

	// Token: 0x06007627 RID: 30247 RVA: 0x001883B4 File Offset: 0x001865B4
	public List<IBabelTowerTeamTab> GetTeamTabList()
	{
		if (this.TeamTabList.Count > 0)
		{
			return this.TeamTabList;
		}
		this.TeamTabList.Add(new BabelTowerTeamTab
		{
			TabType = EBabelTowerTeamTabType.RoleList,
			Title = "GhostShipRoleList_Text"
		});
		this.TeamTabList.Add(new BabelTowerTeamTab
		{
			TabType = EBabelTowerTeamTabType.UseTeam,
			Title = "GhostShipPreTeam_Text"
		});
		return this.TeamTabList;
	}

	// Token: 0x17000A38 RID: 2616
	// (get) Token: 0x06007628 RID: 30248 RVA: 0x00188420 File Offset: 0x00186620
	public static BabelTowerModel Instance
	{
		get
		{
			return BabelTowerModel._Instance;
		}
	}

	// Token: 0x06007629 RID: 30249 RVA: 0x00188427 File Offset: 0x00186627
	public static BabelTowerModel GetOrCreateInstance()
	{
		if (BabelTowerModel._Instance == null)
		{
			BabelTowerModel.CreateInstance();
		}
		return BabelTowerModel._Instance;
	}

	// Token: 0x0600762A RID: 30250 RVA: 0x0018843B File Offset: 0x0018663B
	public static bool CreateInstance()
	{
		if (BabelTowerModel._Instance != null)
		{
			return true;
		}
		BabelTowerModel._Instance = new BabelTowerModel();
		return true;
	}

	// Token: 0x0600762B RID: 30251 RVA: 0x00188451 File Offset: 0x00186651
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600762C RID: 30252 RVA: 0x00188453 File Offset: 0x00186653
	public static void ResetStaticDefaultValue()
	{
		BabelTowerModel._Instance = null;
	}

	// Token: 0x0600762D RID: 30253 RVA: 0x0018845B File Offset: 0x0018665B
	static BabelTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerModel.CreateStaticDefaultValue), new Action(BabelTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003629 RID: 13865
	[Nullable(2)]
	private BabelTowerInstanceData CurrentChallengeInstDataInternal;

	// Token: 0x0400362A RID: 13866
	public int ItemCountMax;

	// Token: 0x0400362B RID: 13867
	public int CurrentQuickIndex = -1;

	// Token: 0x0400362C RID: 13868
	public Dictionary<int, IBabelTowerSelectInfo> DeTermSelectInfo = new Dictionary<int, IBabelTowerSelectInfo>();

	// Token: 0x0400362D RID: 13869
	public bool IsShowLeftTeamPanel;

	// Token: 0x0400362E RID: 13870
	public int DeTermSelectIndex;

	// Token: 0x0400362F RID: 13871
	public HashSet<int> ClearedDeTerms = new HashSet<int>();

	// Token: 0x04003630 RID: 13872
	public int LevelChoseHandle;

	// Token: 0x04003631 RID: 13873
	public int CurrentSelectLevel;

	// Token: 0x04003632 RID: 13874
	private readonly List<IBabelTowerTeamTab> TeamTabList = new List<IBabelTowerTeamTab>();

	// Token: 0x04003633 RID: 13875
	[Nullable(2)]
	private static BabelTowerModel _Instance;
}
