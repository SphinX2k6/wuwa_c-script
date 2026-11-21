using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x020003C7 RID: 967
[NullableContext(1)]
[Nullable(0)]
public class AchievementData
{
	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x060034E0 RID: 13536 RVA: 0x001380FB File Offset: 0x001362FB
	// (set) Token: 0x060034E1 RID: 13537 RVA: 0x00138103 File Offset: 0x00136303
	public long UUID { get; set; }

	// Token: 0x060034E2 RID: 13538 RVA: 0x0013810C File Offset: 0x0013630C
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
		this.NextAchievementId = AchievementConfig.Instance.GetAchievementNextLink(this.Id);
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00138134 File Offset: 0x00136334
	public unsafe void PrintUnsafeAddress()
	{
		fixed (int?* ptr = &this.FinishTime)
		{
		}
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x00138150 File Offset: 0x00136350
	public AchievementData(int id)
	{
		this.Id = id;
		this.NextAchievementId = AchievementConfig.Instance.GetAchievementNextLink(this.Id);
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x001381A9 File Offset: 0x001363A9
	public void SetLastLink(int link)
	{
		this.LastAchievementId = link;
	}

	// Token: 0x060034E6 RID: 13542 RVA: 0x001381B4 File Offset: 0x001363B4
	public void Phrase(AchievementEntry message)
	{
		this.FinishTime = new int?((int)message.FinishTime);
		this.HasGetRewardState = new bool?(message.IsReceive);
		this.CurrentProgress = new int?(message.Progress.CurProgress);
		this.MaxProgress = new int?(message.Progress.TotalProgress);
		this.InitThirdPartyTrophyId();
		this.UpdateThirdPartyTrophyData();
	}

	// Token: 0x060034E7 RID: 13543 RVA: 0x0013821C File Offset: 0x0013641C
	private void UpdateThirdPartyTrophyData()
	{
		string thirdPartyTrophyId = this.GetThirdPartyTrophyId();
		if (this.GetFinishState() != EAchievementStateEnum.UnFinished && thirdPartyTrophyId != "-1")
		{
			KuroSdkController.Instance.UnlockSdkTrophy(thirdPartyTrophyId);
		}
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x00138250 File Offset: 0x00136450
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x00138258 File Offset: 0x00136458
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

	// Token: 0x060034EA RID: 13546 RVA: 0x001382DB File Offset: 0x001364DB
	public string GetThirdPartyTrophyId()
	{
		return this.ThirdPartyTrophyId;
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x001382E3 File Offset: 0x001364E3
	public bool RedPoint()
	{
		return EAchievementStateEnum.CanGetReward == this.GetFinishState() && this.GetShowState();
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x001382FB File Offset: 0x001364FB
	public string GetIconPath()
	{
		return AchievementConfig.Instance.GetAchievementIcon(this.Id);
	}

	// Token: 0x060034ED RID: 13549 RVA: 0x0013830D File Offset: 0x0013650D
	public bool IfSingleAchievement()
	{
		return this.NextAchievementId == -1;
	}

	// Token: 0x060034EE RID: 13550 RVA: 0x0013831C File Offset: 0x0013651C
	public bool GetShowState()
	{
		return this.MaxProgress != null && (!this.GetHiddenState() || this.GetFinishState() != EAchievementStateEnum.UnFinished) && (this.LastAchievementId == -1 || AchievementModel.Instance.GetAchievementData(this.LastAchievementId).GetFinishState() == EAchievementStateEnum.HaveGetReward) && (this.GetFinishState() != EAchievementStateEnum.HaveGetReward || this.NextAchievementId <= 0);
	}

	// Token: 0x060034EF RID: 13551 RVA: 0x00138382 File Offset: 0x00136582
	public bool GetHiddenState()
	{
		return AchievementConfig.Instance.GetAchievementHiddenState(this.Id);
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x00138394 File Offset: 0x00136594
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

	// Token: 0x060034F1 RID: 13553 RVA: 0x00138424 File Offset: 0x00136624
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

	// Token: 0x060034F2 RID: 13554 RVA: 0x001384B3 File Offset: 0x001366B3
	public string GetDesc()
	{
		return AchievementConfig.Instance.GetAchievementDesc(this.Id);
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x001384C5 File Offset: 0x001366C5
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetAchievementTitle(this.Id);
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x001384D8 File Offset: 0x001366D8
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

	// Token: 0x060034F5 RID: 13557 RVA: 0x00138540 File Offset: 0x00136740
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

	// Token: 0x060034F6 RID: 13558 RVA: 0x001385BC File Offset: 0x001367BC
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

	// Token: 0x060034F7 RID: 13559 RVA: 0x001385F8 File Offset: 0x001367F8
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

	// Token: 0x060034F8 RID: 13560 RVA: 0x00138649 File Offset: 0x00136849
	public int GetAchievementConfigStar()
	{
		return AchievementConfig.Instance.GetAchievementLevel(this.GetId());
	}

	// Token: 0x060034F9 RID: 13561 RVA: 0x0013865B File Offset: 0x0013685B
	public int? GetCurrentProgress()
	{
		return this.CurrentProgress;
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x00138663 File Offset: 0x00136863
	public int? GetMaxProgress()
	{
		return this.MaxProgress;
	}

	// Token: 0x060034FB RID: 13563 RVA: 0x0013866C File Offset: 0x0013686C
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

	// Token: 0x060034FC RID: 13564 RVA: 0x00138724 File Offset: 0x00136924
	public bool GetAllFinishState()
	{
		return (this.NextAchievementId == 0 || this.NextAchievementId == -1) && this.GetFinishState() == EAchievementStateEnum.CanGetReward;
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x00138742 File Offset: 0x00136942
	public int GetNextLink()
	{
		return this.NextAchievementId;
	}

	// Token: 0x060034FE RID: 13566 RVA: 0x0013874A File Offset: 0x0013694A
	public bool GetIfLastAchievement()
	{
		return this.IfSingleAchievement() || this.NextAchievementId == 0;
	}

	// Token: 0x060034FF RID: 13567 RVA: 0x00138761 File Offset: 0x00136961
	public bool CanShowStarState()
	{
		return this.GetFinishState() == EAchievementStateEnum.HaveGetReward || this.GetFinishState() == EAchievementStateEnum.CanGetReward;
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x00138778 File Offset: 0x00136978
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

	// Token: 0x06003501 RID: 13569 RVA: 0x001387B4 File Offset: 0x001369B4
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

	// Token: 0x06003502 RID: 13570 RVA: 0x001387D0 File Offset: 0x001369D0
	public long? GetFinishTime()
	{
		int? finishTime = this.FinishTime;
		if (finishTime == null)
		{
			return null;
		}
		return new long?((long)finishTime.GetValueOrDefault());
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x00138804 File Offset: 0x00136A04
	public int GetGroupId()
	{
		return AchievementConfig.Instance.GetAchievementGroup(this.Id);
	}

	// Token: 0x04002CDE RID: 11486
	public int? FinishTime;

	// Token: 0x04002CDF RID: 11487
	private int NextAchievementId;

	// Token: 0x04002CE0 RID: 11488
	private int LastAchievementId = -1;

	// Token: 0x04002CE1 RID: 11489
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04002CE2 RID: 11490
	private bool? HasGetRewardState = new bool?(false);

	// Token: 0x04002CE3 RID: 11491
	private int? CurrentProgress;

	// Token: 0x04002CE4 RID: 11492
	private int? MaxProgress;

	// Token: 0x04002CE5 RID: 11493
	private string ThirdPartyTrophyId = "-1";

	// Token: 0x04002CE6 RID: 11494
	private int Id;
}
