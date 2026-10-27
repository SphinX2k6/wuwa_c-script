using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B00 RID: 6912
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchSubDungeonData
{
	// Token: 0x0600CD2A RID: 52522 RVA: 0x002ECBD6 File Offset: 0x002EADD6
	public FloroRanchSubDungeonData(FloroRanchSubIns config)
	{
		this.Config = config;
	}

	// Token: 0x0600CD2B RID: 52523 RVA: 0x002ECBEC File Offset: 0x002EADEC
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x170010FE RID: 4350
	// (get) Token: 0x0600CD2C RID: 52524 RVA: 0x002ECBF5 File Offset: 0x002EADF5
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x0600CD2D RID: 52525 RVA: 0x002ECBFD File Offset: 0x002EADFD
	public void UpdateHistoryData(FloroRanchSubInsRecord historyData)
	{
		this.HasHistoryInternal = true;
		this.MaxDaysInternal = historyData.MaxDay;
		this.MaxCoinInternal = historyData.MaxCoin;
	}

	// Token: 0x170010FF RID: 4351
	// (get) Token: 0x0600CD2F RID: 52527 RVA: 0x002ECC27 File Offset: 0x002EAE27
	// (set) Token: 0x0600CD2E RID: 52526 RVA: 0x002ECC1E File Offset: 0x002EAE1E
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

	// Token: 0x0600CD30 RID: 52528 RVA: 0x002ECC2F File Offset: 0x002EAE2F
	public void SetInstanceId(int instanceId)
	{
		this.InstanceIdInternal = instanceId;
	}

	// Token: 0x17001100 RID: 4352
	// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x002ECC38 File Offset: 0x002EAE38
	public int InstanceId
	{
		get
		{
			return this.InstanceIdInternal;
		}
	}

	// Token: 0x17001101 RID: 4353
	// (get) Token: 0x0600CD33 RID: 52531 RVA: 0x002ECC49 File Offset: 0x002EAE49
	// (set) Token: 0x0600CD32 RID: 52530 RVA: 0x002ECC40 File Offset: 0x002EAE40
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

	// Token: 0x17001102 RID: 4354
	// (get) Token: 0x0600CD35 RID: 52533 RVA: 0x002ECC5A File Offset: 0x002EAE5A
	// (set) Token: 0x0600CD34 RID: 52532 RVA: 0x002ECC51 File Offset: 0x002EAE51
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

	// Token: 0x0600CD36 RID: 52534 RVA: 0x002ECC62 File Offset: 0x002EAE62
	public int GetMaxStage()
	{
		return this.Config.Stage;
	}

	// Token: 0x17001103 RID: 4355
	// (get) Token: 0x0600CD37 RID: 52535 RVA: 0x002ECC6F File Offset: 0x002EAE6F
	public int Difficulty
	{
		get
		{
			return this.Config.Difficulty;
		}
	}

	// Token: 0x0600CD38 RID: 52536 RVA: 0x002ECC7C File Offset: 0x002EAE7C
	public int GetStageDay()
	{
		return this.Config.StageDays()[0];
	}

	// Token: 0x17001104 RID: 4356
	// (get) Token: 0x0600CD39 RID: 52537 RVA: 0x002ECC8B File Offset: 0x002EAE8B
	public int FirstReward
	{
		get
		{
			return this.Config.FirstTechReward;
		}
	}

	// Token: 0x17001105 RID: 4357
	// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x002ECC98 File Offset: 0x002EAE98
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

	// Token: 0x17001106 RID: 4358
	// (get) Token: 0x0600CD3B RID: 52539 RVA: 0x002ECCCA File Offset: 0x002EAECA
	public int TagId
	{
		get
		{
			return this.Config.Tag;
		}
	}

	// Token: 0x17001107 RID: 4359
	// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x002ECCD7 File Offset: 0x002EAED7
	public int[] RaceList
	{
		get
		{
			return this.Config.Race();
		}
	}

	// Token: 0x17001108 RID: 4360
	// (get) Token: 0x0600CD3D RID: 52541 RVA: 0x002ECCE4 File Offset: 0x002EAEE4
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001109 RID: 4361
	// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x002ECCF1 File Offset: 0x002EAEF1
	public bool IsEndlessMode
	{
		get
		{
			return this.Config.EndlessMode;
		}
	}

	// Token: 0x1700110A RID: 4362
	// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x002ECD07 File Offset: 0x002EAF07
	// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x002ECCFE File Offset: 0x002EAEFE
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

	// Token: 0x1700110B RID: 4363
	// (get) Token: 0x0600CD41 RID: 52545 RVA: 0x002ECD24 File Offset: 0x002EAF24
	public List<int> SelectedRaceIds
	{
		get
		{
			List<int> list = this.RaceList.ToList<int>();
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

	// Token: 0x1700110C RID: 4364
	// (get) Token: 0x0600CD42 RID: 52546 RVA: 0x002ECDC4 File Offset: 0x002EAFC4
	public bool HasHistory
	{
		get
		{
			return this.HasHistoryInternal;
		}
	}

	// Token: 0x1700110D RID: 4365
	// (get) Token: 0x0600CD43 RID: 52547 RVA: 0x002ECDCC File Offset: 0x002EAFCC
	public int MaxDays
	{
		get
		{
			return this.MaxDaysInternal;
		}
	}

	// Token: 0x1700110E RID: 4366
	// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x002ECDD4 File Offset: 0x002EAFD4
	public long MaxCoin
	{
		get
		{
			return this.MaxCoinInternal;
		}
	}

	// Token: 0x1700110F RID: 4367
	// (get) Token: 0x0600CD45 RID: 52549 RVA: 0x002ECDDC File Offset: 0x002EAFDC
	public string[] EnvironmentTextList
	{
		get
		{
			return this.Config.EnvironmentText();
		}
	}

	// Token: 0x17001110 RID: 4368
	// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x002ECDE9 File Offset: 0x002EAFE9
	public int[] RecommendCardsList
	{
		get
		{
			return this.Config.RecommendCards();
		}
	}

	// Token: 0x17001111 RID: 4369
	// (get) Token: 0x0600CD47 RID: 52551 RVA: 0x002ECDF6 File Offset: 0x002EAFF6
	public int[] RecommendToysList
	{
		get
		{
			return this.Config.RecommendToys();
		}
	}

	// Token: 0x04005E1E RID: 24094
	private FloroRanchSubIns Config;

	// Token: 0x04005E1F RID: 24095
	private bool IsUnLockInternal;

	// Token: 0x04005E20 RID: 24096
	private bool IsFinishedInternal;

	// Token: 0x04005E21 RID: 24097
	private bool IsInstanceUnLockInternal;

	// Token: 0x04005E22 RID: 24098
	private int InstanceIdInternal;

	// Token: 0x04005E23 RID: 24099
	private int ConditionIdInternal;

	// Token: 0x04005E24 RID: 24100
	private bool HasHistoryInternal;

	// Token: 0x04005E25 RID: 24101
	private int MaxDaysInternal;

	// Token: 0x04005E26 RID: 24102
	private long MaxCoinInternal;

	// Token: 0x04005E27 RID: 24103
	private bool HasRedDotInternal = true;
}
