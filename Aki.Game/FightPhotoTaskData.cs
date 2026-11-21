using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000720 RID: 1824
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTaskData
{
	// Token: 0x06005436 RID: 21558 RVA: 0x001BC637 File Offset: 0x001BA837
	public FightPhotoTaskData(PhotoFightReward config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.RewardId);
	}

	// Token: 0x17000B2C RID: 2860
	// (get) Token: 0x06005437 RID: 21559 RVA: 0x001BC66F File Offset: 0x001BA86F
	public bool IsFinished
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x17000B2D RID: 2861
	// (get) Token: 0x06005438 RID: 21560 RVA: 0x001BC67A File Offset: 0x001BA87A
	public bool IsUnclaimed
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndUnclaimed;
		}
	}

	// Token: 0x17000B2E RID: 2862
	// (get) Token: 0x06005439 RID: 21561 RVA: 0x001BC685 File Offset: 0x001BA885
	public bool IsDoing
	{
		get
		{
			return this.Status == EActivityTaskState.Active;
		}
	}

	// Token: 0x17000B2F RID: 2863
	// (get) Token: 0x0600543A RID: 21562 RVA: 0x001BC690 File Offset: 0x001BA890
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000B30 RID: 2864
	// (get) Token: 0x0600543B RID: 21563 RVA: 0x001BC6AC File Offset: 0x001BA8AC
	public int TabType
	{
		get
		{
			return this.Config.TabId;
		}
	}

	// Token: 0x17000B31 RID: 2865
	// (get) Token: 0x0600543C RID: 21564 RVA: 0x001BC6C8 File Offset: 0x001BA8C8
	public string TaskName
	{
		get
		{
			return this.Config.Title;
		}
	}

	// Token: 0x04003AE8 RID: 15080
	private readonly PhotoFightReward Config;

	// Token: 0x04003AE9 RID: 15081
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04003AEA RID: 15082
	public List<TItem> RewardList = new List<TItem>();
}
