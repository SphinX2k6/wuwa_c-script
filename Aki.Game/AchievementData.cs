using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x02000F12 RID: 3858
[NullableContext(1)]
[Nullable(0)]
public class AchievementData
{
	// Token: 0x17000794 RID: 1940
	// (get) Token: 0x06006148 RID: 24904 RVA: 0x0012F7D7 File Offset: 0x0012D9D7
	// (set) Token: 0x06006149 RID: 24905 RVA: 0x0012F7DF File Offset: 0x0012D9DF
	public long UUID { get; set; }

	// Token: 0x0600614A RID: 24906 RVA: 0x0012F7E8 File Offset: 0x0012D9E8
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
		this.NextAchievementId = AchievementConfig.Instance.GetAchievementNextLink(this.Id);
	}

	// Token: 0x0600614B RID: 24907 RVA: 0x0012F810 File Offset: 0x0012DA10
	public unsafe void PrintUnsafeAddress()
	{
		fixed (int?* ptr = &this.FinishTime)
		{
		}
	}

	// Token: 0x0600614C RID: 24908 RVA: 0x0012F82C File Offset: 0x0012DA2C
	public AchievementData(int id)
	{
		this.Id = id;
		this.NextAchievementId = AchievementConfig.Instance.GetAchievementNextLink(this.Id);
	}

	// Token: 0x0600614D RID: 24909 RVA: 0x0012F885 File Offset: 0x0012DA85
	public void SetLastLink(int link)
	{
		this.LastAchievementId = link;
	}

	// Token: 0x0600614E RID: 24910 RVA: 0x0012F890 File Offset: 0x0012DA90
	public void Phrase(AchievementEntry message)
	{
		this.FinishTime = new int?((int)message.FinishTime);
		this.HasGetRewardState = new bool?(message.IsReceive);
		this.CurrentProgress = new int?(message.Progress.CurProgress);
		this.MaxProgress = new int?(message.Progress.TotalProgress);
		this.InitThirdPartyTrophyId();
		this.UpdateThirdPartyTrophyData();
	}

	// Token: 0x0600614F RID: 24911 RVA: 0x0012F8F8 File Offset: 0x0012DAF8
	private void UpdateThirdPartyTrophyData()
	{
		string thirdPartyTrophyId = this.GetThirdPartyTrophyId();
		if (this.GetFinishState() != EAchievementStateEnum.UnFinished && thirdPartyTrophyId != "-1")
		{
			KuroSdkController.Instance.UnlockSdkTrophy(thirdPartyTrophyId);
		}
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x0012F92C File Offset: 0x0012DB2C
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06006151 RID: 24913 RVA: 0x0012F934 File Offset: 0x0012DB34
	private void InitThirdPartyTrophyId()
	{
		if (this.ThirdPartyTrophyId == "-1")
		{
			if (PlatformSdkManagerNew.Instance.IsSdkOn)
			{
				this.ThirdPartyTrophyId = AchievementConfig.Instance.GetThirdPartyTrophyId(this.Id).ToString();
				return;
			}
			if (Info.Instance.IsXboxPlatform())
			{
				this.ThirdPartyTrophyId = AchievementConfig.Instance.GetXSXExternalTrophyId(this.Id);
				return;
			}
			this.ThirdPartyTrophyId = AchievementConfig.Instance.GetExternalTrophyId(this.Id);
		}
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x0012F9B7 File Offset: 0x0012DBB7
	public string GetThirdPartyTrophyId()
	{
		return this.ThirdPartyTrophyId;
	}

	// Token: 0x06006153 RID: 24915 RVA: 0x0012F9BF File Offset: 0x0012DBBF
	public bool RedPoint()
	{
		return EAchievementStateEnum.CanGetReward == this.GetFinishState() && this.GetShowState();
	}

	// Token: 0x06006154 RID: 24916 RVA: 0x0012F9D7 File Offset: 0x0012DBD7
	public string GetIconPath()
	{
		return AchievementConfig.Instance.GetAchievementIcon(this.Id);
	}

	// Token: 0x06006155 RID: 24917 RVA: 0x0012F9E9 File Offset: 0x0012DBE9
	public bool IfSingleAchievement()
	{
		return this.NextAchievementId == -1;
	}

	// Token: 0x06006156 RID: 24918 RVA: 0x0012F9F8 File Offset: 0x0012DBF8
	public bool GetShowState()
	{
		return this.MaxProgress != null && (!this.GetHiddenState() || this.GetFinishState() != EAchievementStateEnum.UnFinished) && (this.LastAchievementId == -1 || AchievementModel.Instance.GetAchievementData(this.LastAchievementId).GetFinishState() == EAchievementStateEnum.HaveGetReward) && (this.GetFinishState() != EAchievementStateEnum.HaveGetReward || this.NextAchievementId <= 0);
	}

	// Token: 0x06006157 RID: 24919 RVA: 0x0012FA5E File Offset: 0x0012DC5E
	public bool GetHiddenState()
	{
		return AchievementConfig.Instance.GetAchievementHiddenState(this.Id);
	}

	// Token: 0x06006158 RID: 24920 RVA: 0x0012FA70 File Offset: 0x0012DC70
	public string GetReplaceDesc(string searchText)
	{
		string desc = this.GetDesc();
		StringBuilder stringBuilder = new StringBuilder();
		string stringConfig = ConfigCommonParamById.GetStringConfig("TutorialSearchColor");
		stringBuilder.Append("<color=");
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
		appendInterpolatedStringHandler.AppendFormatted((stringConfig != null) ? stringConfig.ToLower() : null);
		appendInterpolatedStringHandler.AppendLiteral(">");
		stringBuilder3.Append(ref appendInterpolatedStringHandler);
		stringBuilder.Append(searchText);
		stringBuilder.Append("</color>");
		string oldValue = searchText ?? "";
		return desc.Replace(oldValue, stringBuilder.ToString());
	}

	// Token: 0x06006159 RID: 24921 RVA: 0x0012FB00 File Offset: 0x0012DD00
	public string GetReplaceTitle(string searchText)
	{
		string title = this.GetTitle();
		StringBuilder stringBuilder = new StringBuilder();
		string stringConfig = ConfigCommonParamById.GetStringConfig("TutorialSearchColor");
		stringBuilder.Append("<color=");
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(1, 1, stringBuilder2);
		appendInterpolatedStringHandler.AppendFormatted((stringConfig != null) ? stringConfig.ToLower() : null);
		appendInterpolatedStringHandler.AppendLiteral(">");
		stringBuilder3.Append(ref appendInterpolatedStringHandler);
		stringBuilder.Append(searchText);
		stringBuilder.Append("</color>");
		string oldValue = searchText ?? "";
		return title.Replace(oldValue, stringBuilder.ToString());
	}

	// Token: 0x0600615A RID: 24922 RVA: 0x0012FB8F File Offset: 0x0012DD8F
	public string GetDesc()
	{
		return AchievementConfig.Instance.GetAchievementDesc(this.Id);
	}

	// Token: 0x0600615B RID: 24923 RVA: 0x0012FBA1 File Offset: 0x0012DDA1
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetAchievementTitle(this.Id);
	}

	// Token: 0x0600615C RID: 24924 RVA: 0x0012FBB4 File Offset: 0x0012DDB4
	public int GetMaxStar()
	{
		if (this.IfSingleAchievement())
		{
			return AchievementConfig.Instance.GetAchievementLevel(this.Id);
		}
		AchievementData achievementData = AchievementModel.Instance.GetAchievementData(this.Id);
		while (achievementData != null && achievementData.NextAchievementId > 0)
		{
			achievementData = AchievementModel.Instance.GetAchievementData(achievementData.NextAchievementId);
		}
		return AchievementConfig.Instance.GetAchievementLevel(achievementData.GetId());
	}

	// Token: 0x0600615D RID: 24925 RVA: 0x0012FC1C File Offset: 0x0012DE1C
	public int GetFinishedStar()
	{
		if (!this.GetShowState())
		{
			return 0;
		}
		int achievementLevel = AchievementConfig.Instance.GetAchievementLevel(this.Id);
		if (this.IfSingleAchievement())
		{
			if (this.GetFinishState() == EAchievementStateEnum.HaveGetReward || this.GetFinishState() == EAchievementStateEnum.CanGetReward)
			{
				return achievementLevel;
			}
			return 0;
		}
		else
		{
			int allLastAchievementStar = this.GetAllLastAchievementStar();
			if (this.GetFinishState() == EAchievementStateEnum.HaveGetReward || this.GetFinishState() == EAchievementStateEnum.CanGetReward)
			{
				return achievementLevel + allLastAchievementStar;
			}
			if (this.GetFinishState() == EAchievementStateEnum.UnFinished)
			{
				return allLastAchievementStar;
			}
			return ((achievementLevel - 1 >= 0) ? (achievementLevel - 1) : 0) + allLastAchievementStar;
		}
	}

	// Token: 0x0600615E RID: 24926 RVA: 0x0012FC98 File Offset: 0x0012DE98
	private int GetAllLastAchievementStar()
	{
		int num = 0;
		AchievementData achievementData;
		for (int lastAchievementId = this.LastAchievementId; lastAchievementId != -1; lastAchievementId = achievementData.LastAchievementId)
		{
			achievementData = AchievementModel.Instance.GetAchievementData(lastAchievementId);
			num += AchievementConfig.Instance.GetAchievementLevel(lastAchievementId);
		}
		return num;
	}

	// Token: 0x0600615F RID: 24927 RVA: 0x0012FCD4 File Offset: 0x0012DED4
	public int GetAchievementShowStar()
	{
		if (!this.GetShowState())
		{
			return 0;
		}
		int achievementLevel = AchievementConfig.Instance.GetAchievementLevel(this.Id);
		if (this.IfSingleAchievement())
		{
			return achievementLevel;
		}
		if (this.GetFinishState() == EAchievementStateEnum.HaveGetReward || this.GetFinishState() == EAchievementStateEnum.CanGetReward)
		{
			return achievementLevel;
		}
		if (achievementLevel - 1 < 0)
		{
			return 0;
		}
		return achievementLevel - 1;
	}

	// Token: 0x06006160 RID: 24928 RVA: 0x0012FD25 File Offset: 0x0012DF25
	public int GetAchievementConfigStar()
	{
		return AchievementConfig.Instance.GetAchievementLevel(this.GetId());
	}

	// Token: 0x06006161 RID: 24929 RVA: 0x0012FD37 File Offset: 0x0012DF37
	public int? GetCurrentProgress()
	{
		return this.CurrentProgress;
	}

	// Token: 0x06006162 RID: 24930 RVA: 0x0012FD3F File Offset: 0x0012DF3F
	public int? GetMaxProgress()
	{
		return this.MaxProgress;
	}

	// Token: 0x06006163 RID: 24931 RVA: 0x0012FD48 File Offset: 0x0012DF48
	public List<TItem> GetRewards()
	{
		if (this.Rewards.Count == 0)
		{
			this.Rewards = new List<TItem>();
			DropPackage? achievementReward = AchievementConfig.Instance.GetAchievementReward(this.Id);
			if (achievementReward != null)
			{
				int dropPreviewLength = achievementReward.Value.DropPreviewLength;
				for (int i = 0; i < dropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = achievementReward.Value.DropPreview(i);
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
					this.Rewards.Add(item);
				}
			}
		}
		return this.Rewards;
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x0012FE00 File Offset: 0x0012E000
	public bool GetAllFinishState()
	{
		return (this.NextAchievementId == 0 || this.NextAchievementId == -1) && this.GetFinishState() == EAchievementStateEnum.CanGetReward;
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x0012FE1E File Offset: 0x0012E01E
	public int GetNextLink()
	{
		return this.NextAchievementId;
	}

	// Token: 0x06006166 RID: 24934 RVA: 0x0012FE26 File Offset: 0x0012E026
	public bool GetIfLastAchievement()
	{
		return this.IfSingleAchievement() || this.NextAchievementId == 0;
	}

	// Token: 0x06006167 RID: 24935 RVA: 0x0012FE3D File Offset: 0x0012E03D
	public bool CanShowStarState()
	{
		return this.GetFinishState() == EAchievementStateEnum.HaveGetReward || this.GetFinishState() == EAchievementStateEnum.CanGetReward;
	}

	// Token: 0x06006168 RID: 24936 RVA: 0x0012FE54 File Offset: 0x0012E054
	public EAchievementStateEnum GetFinishState()
	{
		if (this.HasGetRewardState.GetValueOrDefault())
		{
			return EAchievementStateEnum.HaveGetReward;
		}
		int? finishTime = this.FinishTime;
		int num = 0;
		if (finishTime.GetValueOrDefault() > num & finishTime != null)
		{
			return EAchievementStateEnum.CanGetReward;
		}
		return EAchievementStateEnum.UnFinished;
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x0012FE90 File Offset: 0x0012E090
	public int GetFinishSort()
	{
		if (this.GetFinishState() == EAchievementStateEnum.HaveGetReward)
		{
			return 0;
		}
		if (this.GetFinishState() == EAchievementStateEnum.CanGetReward)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x0012FEAC File Offset: 0x0012E0AC
	public long? GetFinishTime()
	{
		int? finishTime = this.FinishTime;
		if (finishTime == null)
		{
			return null;
		}
		return new long?((long)finishTime.GetValueOrDefault());
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x0012FEE0 File Offset: 0x0012E0E0
	public int GetGroupId()
	{
		return AchievementConfig.Instance.GetAchievementGroup(this.Id);
	}

	// Token: 0x04002C45 RID: 11333
	public int? FinishTime;

	// Token: 0x04002C46 RID: 11334
	private int NextAchievementId;

	// Token: 0x04002C47 RID: 11335
	private int LastAchievementId = -1;

	// Token: 0x04002C48 RID: 11336
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04002C49 RID: 11337
	private bool? HasGetRewardState = new bool?(false);

	// Token: 0x04002C4A RID: 11338
	private int? CurrentProgress;

	// Token: 0x04002C4B RID: 11339
	private int? MaxProgress;

	// Token: 0x04002C4C RID: 11340
	private string ThirdPartyTrophyId = "-1";

	// Token: 0x04002C4D RID: 11341
	private int Id;
}
