using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200062B RID: 1579
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BabelTowerModel : ModelBase
{
	// Token: 0x17000A57 RID: 2647
	// (get) Token: 0x060049AD RID: 18861 RVA: 0x00190A41 File Offset: 0x0018EC41
	[Nullable(2)]
	public BabelTowerInstanceData CurrentChallengeInstData
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentChallengeInstDataInternal;
		}
	}

	// Token: 0x060049AE RID: 18862 RVA: 0x00190A49 File Offset: 0x0018EC49
	public void SetTraceId(string traceId)
	{
		if (this.CurrentChallengeInstDataInternal != null)
		{
			this.CurrentChallengeInstDataInternal.TraceId = traceId;
		}
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x00190A60 File Offset: 0x0018EC60
	protected override bool OnInit()
	{
		this.ItemCountMax = ConfigCommonParamById.GetIntConfig("BabelTowerItemCountMax").GetValueOrDefault();
		return true;
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x00190A88 File Offset: 0x0018EC88
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

	// Token: 0x060049B1 RID: 18865 RVA: 0x00190B50 File Offset: 0x0018ED50
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

	// Token: 0x060049B2 RID: 18866 RVA: 0x00190BEC File Offset: 0x0018EDEC
	public int GetRecommendLevel(int instanceId)
	{
		return InstanceDungeonConfig.Instance.GetRecommendLevel(instanceId, WorldLevelModel.Instance.CurWorldLevel);
	}

	// Token: 0x060049B3 RID: 18867 RVA: 0x00190C04 File Offset: 0x0018EE04
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

	// Token: 0x060049B4 RID: 18868 RVA: 0x00190C5C File Offset: 0x0018EE5C
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

	// Token: 0x060049B5 RID: 18869 RVA: 0x00190CD4 File Offset: 0x0018EED4
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

	// Token: 0x060049B6 RID: 18870 RVA: 0x00190D58 File Offset: 0x0018EF58
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

	// Token: 0x060049B7 RID: 18871 RVA: 0x00190DE8 File Offset: 0x0018EFE8
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

	// Token: 0x060049B8 RID: 18872 RVA: 0x00190E58 File Offset: 0x0018F058
	[NullableContext(2)]
	public IBabelTowerSelectInfo GetDeTermSelectInfo(int deTermId)
	{
		return this.DeTermSelectInfo.GetValueOrDefault(deTermId);
	}

	// Token: 0x060049B9 RID: 18873 RVA: 0x00190E66 File Offset: 0x0018F066
	public int CoverStarNumToQualityId(int starNum)
	{
		return starNum + 2;
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x00190E6C File Offset: 0x0018F06C
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

	// Token: 0x060049BB RID: 18875 RVA: 0x00190EC0 File Offset: 0x0018F0C0
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

	// Token: 0x060049BC RID: 18876 RVA: 0x00190F0E File Offset: 0x0018F10E
	public int GetCurStarNum()
	{
		BabelTowerInstanceData currentChallengeInstData = this.CurrentChallengeInstData;
		if (currentChallengeInstData == null)
		{
			return 0;
		}
		return currentChallengeInstData.CurStarNum;
	}

	// Token: 0x060049BD RID: 18877 RVA: 0x00190F24 File Offset: 0x0018F124
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

	// Token: 0x060049BE RID: 18878 RVA: 0x00190F64 File Offset: 0x0018F164
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

	// Token: 0x17000A58 RID: 2648
	// (get) Token: 0x060049BF RID: 18879 RVA: 0x00190FD0 File Offset: 0x0018F1D0
	public static BabelTowerModel Instance
	{
		get
		{
			return BabelTowerModel._Instance;
		}
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x00190FD7 File Offset: 0x0018F1D7
	public static BabelTowerModel GetOrCreateInstance()
	{
		if (BabelTowerModel._Instance == null)
		{
			BabelTowerModel.CreateInstance();
		}
		return BabelTowerModel._Instance;
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x00190FEB File Offset: 0x0018F1EB
	public static bool CreateInstance()
	{
		if (BabelTowerModel._Instance != null)
		{
			return true;
		}
		BabelTowerModel._Instance = new BabelTowerModel();
		return true;
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x00191001 File Offset: 0x0018F201
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x00191003 File Offset: 0x0018F203
	public static void ResetStaticDefaultValue()
	{
		BabelTowerModel._Instance = null;
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x0019100B File Offset: 0x0018F20B
	static BabelTowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BabelTowerModel.CreateStaticDefaultValue), new Action(BabelTowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x040036C2 RID: 14018
	[Nullable(2)]
	private BabelTowerInstanceData CurrentChallengeInstDataInternal;

	// Token: 0x040036C3 RID: 14019
	public int ItemCountMax;

	// Token: 0x040036C4 RID: 14020
	public int CurrentQuickIndex = -1;

	// Token: 0x040036C5 RID: 14021
	public Dictionary<int, IBabelTowerSelectInfo> DeTermSelectInfo = new Dictionary<int, IBabelTowerSelectInfo>();

	// Token: 0x040036C6 RID: 14022
	public bool IsShowLeftTeamPanel;

	// Token: 0x040036C7 RID: 14023
	public int DeTermSelectIndex;

	// Token: 0x040036C8 RID: 14024
	public HashSet<int> ClearedDeTerms = new HashSet<int>();

	// Token: 0x040036C9 RID: 14025
	public int LevelChoseHandle;

	// Token: 0x040036CA RID: 14026
	public int CurrentSelectLevel;

	// Token: 0x040036CB RID: 14027
	private readonly List<IBabelTowerTeamTab> TeamTabList = new List<IBabelTowerTeamTab>();

	// Token: 0x040036CC RID: 14028
	[Nullable(2)]
	private static BabelTowerModel _Instance;
}
