using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.BossRush;

// Token: 0x02000672 RID: 1650
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BossRushModel : ModelBase
{
	// Token: 0x06004C80 RID: 19584 RVA: 0x0019F658 File Offset: 0x0019D858
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

	// Token: 0x06004C81 RID: 19585 RVA: 0x0019F6C8 File Offset: 0x0019D8C8
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

	// Token: 0x06004C82 RID: 19586 RVA: 0x0019F6FC File Offset: 0x0019D8FC
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

	// Token: 0x06004C83 RID: 19587 RVA: 0x0019F784 File Offset: 0x0019D984
	public int[] GetLevelSelectRoleIds(BossRushTeamInfo data)
	{
		return data.GetCurrentTeamMembers();
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x0019F78C File Offset: 0x0019D98C
	public bool CheckInBossRush()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 20 && GameModeController.Instance.IsInInstance();
	}

	// Token: 0x17000A6D RID: 2669
	// (get) Token: 0x06004C85 RID: 19589 RVA: 0x0019F7DA File Offset: 0x0019D9DA
	public static BossRushModel Instance
	{
		get
		{
			return BossRushModel._Instance;
		}
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x0019F7E1 File Offset: 0x0019D9E1
	public static BossRushModel GetOrCreateInstance()
	{
		if (BossRushModel._Instance == null)
		{
			BossRushModel.CreateInstance();
		}
		return BossRushModel._Instance;
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x0019F7F5 File Offset: 0x0019D9F5
	public static bool CreateInstance()
	{
		if (BossRushModel._Instance != null)
		{
			return true;
		}
		BossRushModel._Instance = new BossRushModel();
		return true;
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x0019F80B File Offset: 0x0019DA0B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x0019F80D File Offset: 0x0019DA0D
	public static void ResetStaticDefaultValue()
	{
		BossRushModel._Instance = null;
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x0019F815 File Offset: 0x0019DA15
	static BossRushModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BossRushModel.CreateStaticDefaultValue), new Action(BossRushModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400382A RID: 14378
	[Nullable(2)]
	public BossRushLevelDetailInfo CurrentSelectLevelDetailData;

	// Token: 0x0400382B RID: 14379
	[Nullable(2)]
	public BossRushTeamInfo CurrentTeamInfo;

	// Token: 0x0400382C RID: 14380
	public int CurrentChangeBuffSlot;

	// Token: 0x0400382D RID: 14381
	public bool PlayBackAnimation;

	// Token: 0x0400382E RID: 14382
	public List<int> CurrentOpenBossRushActivityIds = new List<int>();

	// Token: 0x0400382F RID: 14383
	public int CurrentSelectActivityId;

	// Token: 0x04003830 RID: 14384
	private readonly Dictionary<int, BossRushTeamInfo> TeamInfoMap = new Dictionary<int, BossRushTeamInfo>();

	// Token: 0x04003831 RID: 14385
	private readonly Dictionary<int, List<int>> CurrentTakeRewardsMap = new Dictionary<int, List<int>>();

	// Token: 0x04003832 RID: 14386
	public EBuffTabName CurrentSelectBuffTabName;

	// Token: 0x04003833 RID: 14387
	public bool OnlyOpenRewardView;

	// Token: 0x04003834 RID: 14388
	public List<int> ChoseBuffInGameHandleList = new List<int>();

	// Token: 0x04003835 RID: 14389
	[Nullable(2)]
	private static BossRushModel _Instance;
}
