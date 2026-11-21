using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020006D0 RID: 1744
[NullableContext(1)]
[Nullable(0)]
public class AbyssRewardInfo
{
	// Token: 0x0600500C RID: 20492 RVA: 0x001AD8EE File Offset: 0x001ABAEE
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x001AD8F8 File Offset: 0x001ABAF8
	public AbyssReward GetConfig()
	{
		return DangoAbyssConfig.Instance.GetAbyssRewardById(this.Id).Value;
	}

	// Token: 0x0600500E RID: 20494 RVA: 0x001AD91D File Offset: 0x001ABB1D
	public bool GetHasGetReward()
	{
		return this.HasGetReward;
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x001AD925 File Offset: 0x001ABB25
	public bool GetCanGetReward()
	{
		return this.CurrentProgress == this.TargetProgress;
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x001AD935 File Offset: 0x001ABB35
	public int GetCurrentProgress()
	{
		return this.CurrentProgress;
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x001AD93D File Offset: 0x001ABB3D
	public int GetTargetProgress()
	{
		return this.TargetProgress;
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x001AD945 File Offset: 0x001ABB45
	public bool GetIfUnlock()
	{
		return this.IfUnlock;
	}

	// Token: 0x06005013 RID: 20499 RVA: 0x001AD950 File Offset: 0x001ABB50
	public int GetRewardType()
	{
		int rewardType = this.GetConfig().RewardType;
		return DangoAbyssConfig.Instance.GetAbyssRewardTypeById(rewardType).Value.RewardType;
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x001AD988 File Offset: 0x001ABB88
	public int GetTabId()
	{
		int rewardType = this.GetConfig().RewardType;
		return DangoAbyssConfig.Instance.GetAbyssRewardTypeById(rewardType).Value.TabId;
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x001AD9C0 File Offset: 0x001ABBC0
	public int[] GetAllSameRewardTypeRewardId()
	{
		List<int> list = new List<int>();
		foreach (AbyssReward abyssReward in DangoAbyssConfig.Instance.GetAllAbyssReward())
		{
			if (abyssReward.RewardType == this.GetConfig().RewardType)
			{
				global::AbyssRewardInfo rewardInfoById = DangoAbyssModel.Instance.GetRewardInfoById(abyssReward.Id);
				if (rewardInfoById != null && rewardInfoById.GetRewardTaskState() == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(abyssReward.Id);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x001ADA5C File Offset: 0x001ABC5C
	public EActivityTaskState GetRewardTaskState()
	{
		EActivityTaskState result = EActivityTaskState.Active;
		if (this.HasGetReward)
		{
			result = EActivityTaskState.FinishedAndClaimed;
		}
		else if (this.GetCanGetReward())
		{
			result = EActivityTaskState.FinishedAndUnclaimed;
		}
		return result;
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x001ADA84 File Offset: 0x001ABC84
	public IActivityRewardData GetActivityRewardData()
	{
		EActivityTaskState rewardTaskState = this.GetRewardTaskState();
		int currentProgress = this.CurrentProgress;
		int targetProgress = this.TargetProgress;
		AbyssReward config = this.GetConfig();
		return new ActivityRewardData
		{
			Id = new int?(this.GetId()),
			NameText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(config.Title, null), new string[]
			{
				targetProgress.ToString()
			}),
			NameTextArgs = new string[]
			{
				currentProgress.ToString() ?? "",
				targetProgress.ToString() ?? ""
			},
			RewardState = TaskStateToRewardStateResolver.Value[rewardTaskState],
			ClickFunction = delegate
			{
				DangoAbyssActivityController.Instance.RequestGetAbyssRewardList(this.GetAllSameRewardTypeRewardId());
			},
			RewardList = this.GetRewardItems(this.GetDropId()),
			RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)TaskStateToRewardStateResolver.Value[rewardTaskState]), null)
		};
	}

	// Token: 0x06005018 RID: 20504 RVA: 0x001ADB7C File Offset: 0x001ABD7C
	private string GetButtonText(int state)
	{
		string result = "";
		switch (state)
		{
		case 0:
			result = "PrefabTextItem_1443074454_Text";
			break;
		case 1:
			result = "CollectActivity_state_CanRecive";
			break;
		case 2:
			result = "CollectActivity_state_recived";
			break;
		}
		return result;
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x001ADBBC File Offset: 0x001ABDBC
	private int GetDropId()
	{
		return this.GetConfig().DropId;
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x001ADBD8 File Offset: 0x001ABDD8
	private TItem[] GetRewardItems(int dropId)
	{
		List<TItem> list = new List<TItem>();
		DropPackage? config = ConfigDropPackageById.GetConfig(dropId, true);
		int dropPreviewLength = config.Value.DropPreviewLength;
		for (int i = 0; i < dropPreviewLength; i++)
		{
			DicIntInt? dicIntInt = config.Value.DropPreview(i);
			int key = dicIntInt.Value.Key;
			int value = dicIntInt.Value.Value;
			list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
		}
		return list.ToArray();
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x001ADC65 File Offset: 0x001ABE65
	public void Pharse(Aki.Protocol.AbyssRewardInfo data)
	{
		this.Id = data.Id;
		this.HasGetReward = data.Rewarded;
		this.CurrentProgress = data.Current;
		this.TargetProgress = data.Target;
		this.IfUnlock = data.IsFinish;
	}

	// Token: 0x04003976 RID: 14710
	private int Id;

	// Token: 0x04003977 RID: 14711
	private bool HasGetReward;

	// Token: 0x04003978 RID: 14712
	private int CurrentProgress;

	// Token: 0x04003979 RID: 14713
	private int TargetProgress;

	// Token: 0x0400397A RID: 14714
	private bool IfUnlock;
}
