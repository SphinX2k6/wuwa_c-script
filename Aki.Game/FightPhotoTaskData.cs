using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200126C RID: 4716
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoTaskData
{
	// Token: 0x0600809F RID: 32927 RVA: 0x001B3967 File Offset: 0x001B1B67
	public FightPhotoTaskData(PhotoFightReward config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.RewardId);
	}

	// Token: 0x17000B0C RID: 2828
	// (get) Token: 0x060080A0 RID: 32928 RVA: 0x001B399F File Offset: 0x001B1B9F
	public bool IsFinished
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x17000B0D RID: 2829
	// (get) Token: 0x060080A1 RID: 32929 RVA: 0x001B39AA File Offset: 0x001B1BAA
	public bool IsUnclaimed
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndUnclaimed;
		}
	}

	// Token: 0x17000B0E RID: 2830
	// (get) Token: 0x060080A2 RID: 32930 RVA: 0x001B39B5 File Offset: 0x001B1BB5
	public bool IsDoing
	{
		get
		{
			return this.Status == EActivityTaskState.Active;
		}
	}

	// Token: 0x17000B0F RID: 2831
	// (get) Token: 0x060080A3 RID: 32931 RVA: 0x001B39C0 File Offset: 0x001B1BC0
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17000B10 RID: 2832
	// (get) Token: 0x060080A4 RID: 32932 RVA: 0x001B39DC File Offset: 0x001B1BDC
	public int TabType
	{
		get
		{
			return this.Config.TabId;
		}
	}

	// Token: 0x17000B11 RID: 2833
	// (get) Token: 0x060080A5 RID: 32933 RVA: 0x001B39F8 File Offset: 0x001B1BF8
	public string TaskName
	{
		get
		{
			return this.Config.Title;
		}
	}

	// Token: 0x04003A50 RID: 14928
	private readonly PhotoFightReward Config;

	// Token: 0x04003A51 RID: 14929
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04003A52 RID: 14930
	public List<TItem> RewardList = new List<TItem>();
}
