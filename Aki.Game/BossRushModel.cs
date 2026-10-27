using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;

// Token: 0x020011BE RID: 4542
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BossRushModel : ModelBase
{
	// Token: 0x060078E9 RID: 30953 RVA: 0x001969A8 File Offset: 0x00194BA8
	public int GetFullScore(int activityId)
	{
		BossRushData bossRushData = ActivityModel.Instance.GetActivityById(activityId) as BossRushData;
		if (bossRushData == null)
		{
			return 0;
		}
		int num = 0;
		foreach (BossRushLevelDetailInfo bossRushLevelDetailInfo in bossRushData.GetBossRushLevelDetailInfo())
		{
			num += bossRushLevelDetailInfo.GetScore();
		}
		return num;
	}

	// Token: 0x060078EA RID: 30954 RVA: 0x00196A18 File Offset: 0x00194C18
	public BossRushTeamInfo GetBossRushTeamInfoByActivityId(int activityId)
	{
		BossRushTeamInfo bossRushTeamInfo;
		if (!this.TeamInfoMap.TryGetValue(activityId, out bossRushTeamInfo))
		{
			bossRushTeamInfo = new BossRushTeamInfo();
			this.TeamInfoMap[activityId] = bossRushTeamInfo;
		}
		return bossRushTeamInfo;
	}

	// Token: 0x060078EB RID: 30955 RVA: 0x00196A4C File Offset: 0x00194C4C
	public int[] GetHaveUnTakeRewardIds(int activityId)
	{
		List<int> list = new List<int>();
		int fullScore = this.GetFullScore(activityId);
		List<int> list2 = new List<int>();
		foreach (int item in list)
		{
			int num = 0;
			List<int> list3;
			if (fullScore >= num && this.CurrentTakeRewardsMap.TryGetValue(activityId, out list3) && !list3.Contains(item))
			{
				list2.Add(item);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x060078EC RID: 30956 RVA: 0x00196AD4 File Offset: 0x00194CD4
	public int[] GetLevelSelectRoleIds(BossRushTeamInfo data)
	{
		return data.GetCurrentTeamMembers();
	}

	// Token: 0x060078ED RID: 30957 RVA: 0x00196ADC File Offset: 0x00194CDC
	public bool CheckInBossRush()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 20 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x17000A4D RID: 2637
	// (get) Token: 0x060078EE RID: 30958 RVA: 0x00196B2A File Offset: 0x00194D2A
	public static BossRushModel Instance
	{
		get
		{
			return BossRushModel._Instance;
		}
	}

	// Token: 0x060078EF RID: 30959 RVA: 0x00196B31 File Offset: 0x00194D31
	public static BossRushModel GetOrCreateInstance()
	{
		if (BossRushModel._Instance == null)
		{
			BossRushModel.CreateInstance();
		}
		return BossRushModel._Instance;
	}

	// Token: 0x060078F0 RID: 30960 RVA: 0x00196B45 File Offset: 0x00194D45
	public static bool CreateInstance()
	{
		if (BossRushModel._Instance != null)
		{
			return true;
		}
		BossRushModel._Instance = new BossRushModel();
		return true;
	}

	// Token: 0x060078F1 RID: 30961 RVA: 0x00196B5B File Offset: 0x00194D5B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060078F2 RID: 30962 RVA: 0x00196B5D File Offset: 0x00194D5D
	public static void ResetStaticDefaultValue()
	{
		BossRushModel._Instance = null;
	}

	// Token: 0x060078F3 RID: 30963 RVA: 0x00196B65 File Offset: 0x00194D65
	static BossRushModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BossRushModel.CreateStaticDefaultValue), new Action(BossRushModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003791 RID: 14225
	[Nullable(2)]
	public BossRushLevelDetailInfo CurrentSelectLevelDetailData;

	// Token: 0x04003792 RID: 14226
	[Nullable(2)]
	public BossRushTeamInfo CurrentTeamInfo;

	// Token: 0x04003793 RID: 14227
	public int CurrentChangeBuffSlot;

	// Token: 0x04003794 RID: 14228
	public bool PlayBackAnimation;

	// Token: 0x04003795 RID: 14229
	public List<int> CurrentOpenBossRushActivityIds = new List<int>();

	// Token: 0x04003796 RID: 14230
	public int CurrentSelectActivityId;

	// Token: 0x04003797 RID: 14231
	private readonly Dictionary<int, BossRushTeamInfo> TeamInfoMap = new Dictionary<int, BossRushTeamInfo>();

	// Token: 0x04003798 RID: 14232
	private readonly Dictionary<int, List<int>> CurrentTakeRewardsMap = new Dictionary<int, List<int>>();

	// Token: 0x04003799 RID: 14233
	public EBuffTabName CurrentSelectBuffTabName;

	// Token: 0x0400379A RID: 14234
	public bool OnlyOpenRewardView;

	// Token: 0x0400379B RID: 14235
	public List<int> ChoseBuffInGameHandleList = new List<int>();

	// Token: 0x0400379C RID: 14236
	[Nullable(2)]
	private static BossRushModel _Instance;
}
