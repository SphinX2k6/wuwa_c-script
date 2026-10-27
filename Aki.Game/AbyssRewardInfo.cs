using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200121C RID: 4636
[NullableContext(1)]
[Nullable(0)]
public class AbyssRewardInfo
{
	// Token: 0x06007C76 RID: 31862 RVA: 0x001A4C66 File Offset: 0x001A2E66
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06007C77 RID: 31863 RVA: 0x001A4C70 File Offset: 0x001A2E70
	public AbyssReward GetConfig()
	{
		return DangoAbyssConfig.Instance.GetAbyssRewardById(this.Id).Value;
	}

	// Token: 0x06007C78 RID: 31864 RVA: 0x001A4C95 File Offset: 0x001A2E95
	public bool GetHasGetReward()
	{
		return this.HasGetReward;
	}

	// Token: 0x06007C79 RID: 31865 RVA: 0x001A4C9D File Offset: 0x001A2E9D
	public bool GetCanGetReward()
	{
		return this.CurrentProgress == this.TargetProgress;
	}

	// Token: 0x06007C7A RID: 31866 RVA: 0x001A4CAD File Offset: 0x001A2EAD
	public int GetCurrentProgress()
	{
		return this.CurrentProgress;
	}

	// Token: 0x06007C7B RID: 31867 RVA: 0x001A4CB5 File Offset: 0x001A2EB5
	public int GetTargetProgress()
	{
		return this.TargetProgress;
	}

	// Token: 0x06007C7C RID: 31868 RVA: 0x001A4CBD File Offset: 0x001A2EBD
	public bool GetIfUnlock()
	{
		return this.IfUnlock;
	}

	// Token: 0x06007C7D RID: 31869 RVA: 0x001A4CC8 File Offset: 0x001A2EC8
	public int GetRewardType()
	{
		int rewardType = this.GetConfig().RewardType;
		return DangoAbyssConfig.Instance.GetAbyssRewardTypeById(rewardType).Value.RewardType;
	}

	// Token: 0x06007C7E RID: 31870 RVA: 0x001A4D00 File Offset: 0x001A2F00
	public int GetTabId()
	{
		int rewardType = this.GetConfig().RewardType;
		return DangoAbyssConfig.Instance.GetAbyssRewardTypeById(rewardType).Value.TabId;
	}

	// Token: 0x06007C7F RID: 31871 RVA: 0x001A4D38 File Offset: 0x001A2F38
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

	// Token: 0x06007C80 RID: 31872 RVA: 0x001A4DD4 File Offset: 0x001A2FD4
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

	// Token: 0x06007C81 RID: 31873 RVA: 0x001A4DFC File Offset: 0x001A2FFC
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

	// Token: 0x06007C82 RID: 31874 RVA: 0x001A4EF4 File Offset: 0x001A30F4
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

	// Token: 0x06007C83 RID: 31875 RVA: 0x001A4F34 File Offset: 0x001A3134
	private int GetDropId()
	{
		return this.GetConfig().DropId;
	}

	// Token: 0x06007C84 RID: 31876 RVA: 0x001A4F50 File Offset: 0x001A3150
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

	// Token: 0x06007C85 RID: 31877 RVA: 0x001A4FDD File Offset: 0x001A31DD
	public void Pharse(Aki.Protocol.AbyssRewardInfo data)
	{
		this.Id = data.Id;
		this.HasGetReward = data.Rewarded;
		this.CurrentProgress = data.Current;
		this.TargetProgress = data.Target;
		this.IfUnlock = data.IsFinish;
	}

	// Token: 0x040038DD RID: 14557
	private int Id;

	// Token: 0x040038DE RID: 14558
	private bool HasGetReward;

	// Token: 0x040038DF RID: 14559
	private int CurrentProgress;

	// Token: 0x040038E0 RID: 14560
	private int TargetProgress;

	// Token: 0x040038E1 RID: 14561
	private bool IfUnlock;
}
