using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E7F RID: 7807
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryScoreRewardData
{
	// Token: 0x0600EDFC RID: 60924 RVA: 0x0038C1E9 File Offset: 0x0038A3E9
	public HonamiStoryScoreRewardData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600EDFD RID: 60925 RVA: 0x0038C1F8 File Offset: 0x0038A3F8
	private HonamiStoryScoreReward? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryScoreRewardConfig(this.ConfigId);
	}

	// Token: 0x0600EDFE RID: 60926 RVA: 0x0038C20A File Offset: 0x0038A40A
	public void UpdateState(EHonamiStoryCollectState state)
	{
		this.StateInternal = state;
	}

	// Token: 0x170012C4 RID: 4804
	// (get) Token: 0x0600EDFF RID: 60927 RVA: 0x0038C213 File Offset: 0x0038A413
	public EHonamiStoryCollectState State
	{
		get
		{
			return this.StateInternal;
		}
	}

	// Token: 0x170012C5 RID: 4805
	// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x0038C21C File Offset: 0x0038A41C
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012C6 RID: 4806
	// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0038C240 File Offset: 0x0038A440
	public string Name
	{
		get
		{
			return this.GetConfig().Value.Name;
		}
	}

	// Token: 0x170012C7 RID: 4807
	// (get) Token: 0x0600EE02 RID: 60930 RVA: 0x0038C264 File Offset: 0x0038A464
	public string LockTip
	{
		get
		{
			return this.GetConfig().Value.LockTip;
		}
	}

	// Token: 0x170012C8 RID: 4808
	// (get) Token: 0x0600EE03 RID: 60931 RVA: 0x0038C288 File Offset: 0x0038A488
	public int Score
	{
		get
		{
			return this.GetConfig().Value.Score;
		}
	}

	// Token: 0x170012C9 RID: 4809
	// (get) Token: 0x0600EE04 RID: 60932 RVA: 0x0038C2AC File Offset: 0x0038A4AC
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x04006E6B RID: 28267
	public int ConfigId;

	// Token: 0x04006E6C RID: 28268
	private EHonamiStoryCollectState StateInternal;
}
