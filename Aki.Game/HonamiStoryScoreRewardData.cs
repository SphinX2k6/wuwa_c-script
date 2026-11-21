using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001341 RID: 4929
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryScoreRewardData
{
	// Token: 0x0600C21B RID: 49691 RVA: 0x00397DD9 File Offset: 0x00395FD9
	public HonamiStoryScoreRewardData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600C21C RID: 49692 RVA: 0x00397DE8 File Offset: 0x00395FE8
	private HonamiStoryScoreReward? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryScoreRewardConfig(this.ConfigId);
	}

	// Token: 0x0600C21D RID: 49693 RVA: 0x00397DFA File Offset: 0x00395FFA
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012EE RID: 4846
	// (get) Token: 0x0600C21E RID: 49694 RVA: 0x00397E03 File Offset: 0x00396003
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012EF RID: 4847
	// (get) Token: 0x0600C21F RID: 49695 RVA: 0x00397E0C File Offset: 0x0039600C
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012F0 RID: 4848
	// (get) Token: 0x0600C220 RID: 49696 RVA: 0x00397E30 File Offset: 0x00396030
	public string Name
	{
		get
		{
			return this.GetConfig().Value.Name;
		}
	}

	// Token: 0x170012F1 RID: 4849
	// (get) Token: 0x0600C221 RID: 49697 RVA: 0x00397E54 File Offset: 0x00396054
	public string LockTip
	{
		get
		{
			return this.GetConfig().Value.LockTip;
		}
	}

	// Token: 0x170012F2 RID: 4850
	// (get) Token: 0x0600C222 RID: 49698 RVA: 0x00397E78 File Offset: 0x00396078
	public int Score
	{
		get
		{
			return this.GetConfig().Value.Score;
		}
	}

	// Token: 0x170012F3 RID: 4851
	// (get) Token: 0x0600C223 RID: 49699 RVA: 0x00397E9C File Offset: 0x0039609C
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x04006F4C RID: 28492
	public int ConfigId;

	// Token: 0x04006F4D RID: 28493
	private EHonamiStoryCollectState StateInternal;
}
