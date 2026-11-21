using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02000FBF RID: 4031
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSubDungeonData
{
	// Token: 0x0600A13B RID: 41275 RVA: 0x002F7CC2 File Offset: 0x002F5EC2
	public FloroRanchSubDungeonData(FloroRanchSubIns config)
	{
		this.Config = config;
	}

	// Token: 0x0600A13C RID: 41276 RVA: 0x002F7CD8 File Offset: 0x002F5ED8
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x17001123 RID: 4387
	// (get) Token: 0x0600A13D RID: 41277 RVA: 0x002F7CE1 File Offset: 0x002F5EE1
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x0600A13E RID: 41278 RVA: 0x002F7CE9 File Offset: 0x002F5EE9
	public void UpdateHistoryData(FloroRanchSubInsRecord historyData)
	{
		this.HasHistoryInternal = true;
		this.MaxDaysInternal = historyData.MaxDay;
		this.MaxCoinInternal = historyData.MaxCoin;
	}

	// Token: 0x17001124 RID: 4388
	// (get) Token: 0x0600A140 RID: 41280 RVA: 0x002F7D13 File Offset: 0x002F5F13
	// (set) Token: 0x0600A13F RID: 41279 RVA: 0x002F7D0A File Offset: 0x002F5F0A
	public bool IsFinished
	{
		get
		{
			return this.IsFinishedInternal;
		}
		set
		{
			this.IsFinishedInternal = value;
		}
	}

	// Token: 0x0600A141 RID: 41281 RVA: 0x002F7D1B File Offset: 0x002F5F1B
	public void SetInstanceId(int instanceId)
	{
		this.InstanceIdInternal = instanceId;
	}

	// Token: 0x17001125 RID: 4389
	// (get) Token: 0x0600A142 RID: 41282 RVA: 0x002F7D24 File Offset: 0x002F5F24
	public int InstanceId
	{
		get
		{
			return this.InstanceIdInternal;
		}
	}

	// Token: 0x17001126 RID: 4390
	// (get) Token: 0x0600A144 RID: 41284 RVA: 0x002F7D35 File Offset: 0x002F5F35
	// (set) Token: 0x0600A143 RID: 41283 RVA: 0x002F7D2C File Offset: 0x002F5F2C
	public bool IsInstanceUnlock
	{
		get
		{
			return this.IsInstanceUnLockInternal;
		}
		set
		{
			this.IsInstanceUnLockInternal = value;
		}
	}

	// Token: 0x17001127 RID: 4391
	// (get) Token: 0x0600A146 RID: 41286 RVA: 0x002F7D46 File Offset: 0x002F5F46
	// (set) Token: 0x0600A145 RID: 41285 RVA: 0x002F7D3D File Offset: 0x002F5F3D
	public int ConditionId
	{
		get
		{
			return this.ConditionIdInternal;
		}
		set
		{
			this.ConditionIdInternal = value;
		}
	}

	// Token: 0x0600A147 RID: 41287 RVA: 0x002F7D4E File Offset: 0x002F5F4E
	public int GetMaxStage()
	{
		return this.Config.Stage;
	}

	// Token: 0x17001128 RID: 4392
	// (get) Token: 0x0600A148 RID: 41288 RVA: 0x002F7D5B File Offset: 0x002F5F5B
	public int Difficulty
	{
		get
		{
			return this.Config.Difficulty;
		}
	}

	// Token: 0x0600A149 RID: 41289 RVA: 0x002F7D68 File Offset: 0x002F5F68
	public int GetStageDay()
	{
		return this.Config.StageDays()[0];
	}

	// Token: 0x17001129 RID: 4393
	// (get) Token: 0x0600A14A RID: 41290 RVA: 0x002F7D77 File Offset: 0x002F5F77
	public int FirstReward
	{
		get
		{
			return this.Config.FirstTechReward;
		}
	}

	// Token: 0x1700112A RID: 4394
	// (get) Token: 0x0600A14B RID: 41291 RVA: 0x002F7D84 File Offset: 0x002F5F84
	public int AgainReward
	{
		get
		{
			int num = 0;
			foreach (int num2 in this.Config.TechReward())
			{
				num += num2;
			}
			return num;
		}
	}

	// Token: 0x1700112B RID: 4395
	// (get) Token: 0x0600A14C RID: 41292 RVA: 0x002F7DB6 File Offset: 0x002F5FB6
	public int TagId
	{
		get
		{
			return this.Config.Tag;
		}
	}

	// Token: 0x1700112C RID: 4396
	// (get) Token: 0x0600A14D RID: 41293 RVA: 0x002F7DC3 File Offset: 0x002F5FC3
	public int[] RaceList
	{
		get
		{
			return this.Config.Race();
		}
	}

	// Token: 0x1700112D RID: 4397
	// (get) Token: 0x0600A14E RID: 41294 RVA: 0x002F7DD0 File Offset: 0x002F5FD0
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x1700112E RID: 4398
	// (get) Token: 0x0600A14F RID: 41295 RVA: 0x002F7DDD File Offset: 0x002F5FDD
	public bool IsEndlessMode
	{
		get
		{
			return this.Config.EndlessMode;
		}
	}

	// Token: 0x1700112F RID: 4399
	// (get) Token: 0x0600A151 RID: 41297 RVA: 0x002F7DF3 File Offset: 0x002F5FF3
	// (set) Token: 0x0600A150 RID: 41296 RVA: 0x002F7DEA File Offset: 0x002F5FEA
	public bool HasRedDot
	{
		get
		{
			return this.IsUnLock && this.IsInstanceUnLockInternal && this.HasRedDotInternal;
		}
		set
		{
			this.HasRedDotInternal = value;
		}
	}

	// Token: 0x17001130 RID: 4400
	// (get) Token: 0x0600A152 RID: 41298 RVA: 0x002F7E10 File Offset: 0x002F6010
	public List<int> SelectedRaceIds
	{
		get
		{
			List<int> list = new List<int>(this.RaceList);
			Dictionary<int, List<int>> player = LocalStorage.GetPlayer<Dictionary<int, List<int>>>(ELocalStoragePlayerKey.FloroRanchSelectedRaceIds, null);
			if (player == null)
			{
				return list;
			}
			List<int> recordRaceIds;
			player.TryGetValue(this.Id, out recordRaceIds);
			if (recordRaceIds == null || list.Count != recordRaceIds.Count)
			{
				return list;
			}
			if (list.FindAll((int id) => id != 0).TrueForAll((int id) => recordRaceIds.Contains(id)))
			{
				return recordRaceIds;
			}
			return list;
		}
	}

	// Token: 0x17001131 RID: 4401
	// (get) Token: 0x0600A153 RID: 41299 RVA: 0x002F7EB0 File Offset: 0x002F60B0
	public bool HasHistory
	{
		get
		{
			return this.HasHistoryInternal;
		}
	}

	// Token: 0x17001132 RID: 4402
	// (get) Token: 0x0600A154 RID: 41300 RVA: 0x002F7EB8 File Offset: 0x002F60B8
	public int MaxDays
	{
		get
		{
			return this.MaxDaysInternal;
		}
	}

	// Token: 0x17001133 RID: 4403
	// (get) Token: 0x0600A155 RID: 41301 RVA: 0x002F7EC0 File Offset: 0x002F60C0
	public long MaxCoin
	{
		get
		{
			return this.MaxCoinInternal;
		}
	}

	// Token: 0x17001134 RID: 4404
	// (get) Token: 0x0600A156 RID: 41302 RVA: 0x002F7EC8 File Offset: 0x002F60C8
	public string[] EnvironmentTextList
	{
		get
		{
			return this.Config.EnvironmentText();
		}
	}

	// Token: 0x17001135 RID: 4405
	// (get) Token: 0x0600A157 RID: 41303 RVA: 0x002F7ED5 File Offset: 0x002F60D5
	public int[] RecommendCardsList
	{
		get
		{
			return this.Config.RecommendCards();
		}
	}

	// Token: 0x17001136 RID: 4406
	// (get) Token: 0x0600A158 RID: 41304 RVA: 0x002F7EE2 File Offset: 0x002F60E2
	public int[] RecommendToysList
	{
		get
		{
			return this.Config.RecommendToys();
		}
	}

	// Token: 0x04005EED RID: 24301
	private FloroRanchSubIns Config;

	// Token: 0x04005EEE RID: 24302
	private bool IsUnLockInternal;

	// Token: 0x04005EEF RID: 24303
	private bool IsFinishedInternal;

	// Token: 0x04005EF0 RID: 24304
	private bool IsInstanceUnLockInternal;

	// Token: 0x04005EF1 RID: 24305
	private int InstanceIdInternal;

	// Token: 0x04005EF2 RID: 24306
	private int ConditionIdInternal;

	// Token: 0x04005EF3 RID: 24307
	private bool HasHistoryInternal;

	// Token: 0x04005EF4 RID: 24308
	private int MaxDaysInternal;

	// Token: 0x04005EF5 RID: 24309
	private long MaxCoinInternal;

	// Token: 0x04005EF6 RID: 24310
	private bool HasRedDotInternal = true;
}
