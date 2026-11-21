using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200074A RID: 1866
public class LifePointChallengeDataInstance
{
	// Token: 0x060055C4 RID: 21956 RVA: 0x001C25BE File Offset: 0x001C07BE
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x001C25C6 File Offset: 0x001C07C6
	public bool GetHasGetReward()
	{
		return this.HasGetReward;
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x001C25CE File Offset: 0x001C07CE
	public long GetOpenTime()
	{
		return this.OpenTime / 1000L;
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x001C25DD File Offset: 0x001C07DD
	public int GetRewardId()
	{
		return this.RewardId;
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x001C25E5 File Offset: 0x001C07E5
	public int GetEntityConfigId()
	{
		return this.EntityConfigId;
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x001C25ED File Offset: 0x001C07ED
	public bool GetPreChallengeState()
	{
		return this.PreChallengeState;
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x001C25F8 File Offset: 0x001C07F8
	[NullableContext(1)]
	public void Phrase(LifePointChallengeData data)
	{
		this.Id = data.ChallengeId;
		this.HasGetReward = data.Rewarded;
		this.OpenTime = data.OpenTime;
		this.RewardId = data.RewardId;
		this.EntityConfigId = data.EntityConfigId;
		this.PreChallengeState = data.PreChallenged;
	}

	// Token: 0x04003B6C RID: 15212
	private int Id;

	// Token: 0x04003B6D RID: 15213
	private bool HasGetReward;

	// Token: 0x04003B6E RID: 15214
	private long OpenTime;

	// Token: 0x04003B6F RID: 15215
	private int RewardId;

	// Token: 0x04003B70 RID: 15216
	private int EntityConfigId;

	// Token: 0x04003B71 RID: 15217
	private bool PreChallengeState;
}
