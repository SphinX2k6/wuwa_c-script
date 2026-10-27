using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001296 RID: 4758
public class LifePointChallengeDataInstance
{
	// Token: 0x0600822D RID: 33325 RVA: 0x001B98EE File Offset: 0x001B7AEE
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600822E RID: 33326 RVA: 0x001B98F6 File Offset: 0x001B7AF6
	public bool GetHasGetReward()
	{
		return this.HasGetReward;
	}

	// Token: 0x0600822F RID: 33327 RVA: 0x001B98FE File Offset: 0x001B7AFE
	public long GetOpenTime()
	{
		return this.OpenTime / 1000L;
	}

	// Token: 0x06008230 RID: 33328 RVA: 0x001B990D File Offset: 0x001B7B0D
	public int GetRewardId()
	{
		return this.RewardId;
	}

	// Token: 0x06008231 RID: 33329 RVA: 0x001B9915 File Offset: 0x001B7B15
	public int GetEntityConfigId()
	{
		return this.EntityConfigId;
	}

	// Token: 0x06008232 RID: 33330 RVA: 0x001B991D File Offset: 0x001B7B1D
	public bool GetPreChallengeState()
	{
		return this.PreChallengeState;
	}

	// Token: 0x06008233 RID: 33331 RVA: 0x001B9928 File Offset: 0x001B7B28
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

	// Token: 0x04003AD4 RID: 15060
	private int Id;

	// Token: 0x04003AD5 RID: 15061
	private bool HasGetReward;

	// Token: 0x04003AD6 RID: 15062
	private long OpenTime;

	// Token: 0x04003AD7 RID: 15063
	private int RewardId;

	// Token: 0x04003AD8 RID: 15064
	private int EntityConfigId;

	// Token: 0x04003AD9 RID: 15065
	private bool PreChallengeState;
}
