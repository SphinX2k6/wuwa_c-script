using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001558 RID: 5464
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VersionPreheatModel : ModelBase
{
	// Token: 0x06009CAD RID: 40109 RVA: 0x0021E3C0 File Offset: 0x0021C5C0
	protected override bool OnInit()
	{
		this.ActivityContext = new VersionPreheatActivityContext();
		this.ConfigContext = new VersionPreheatConfigContext();
		return true;
	}

	// Token: 0x06009CAE RID: 40110 RVA: 0x0021E3D9 File Offset: 0x0021C5D9
	protected override bool OnClear()
	{
		this.ActivityContext.Dispose();
		return true;
	}

	// Token: 0x17000D73 RID: 3443
	// (get) Token: 0x06009CAF RID: 40111 RVA: 0x0021E3E7 File Offset: 0x0021C5E7
	public VersionPreheatActivityContext ActivityData
	{
		get
		{
			return this.ActivityContext;
		}
	}

	// Token: 0x17000D74 RID: 3444
	// (get) Token: 0x06009CB0 RID: 40112 RVA: 0x0021E3F0 File Offset: 0x0021C5F0
	public bool IsBonusAvailable
	{
		get
		{
			if (this.ActivityContext.QuestCache.Count == 0)
			{
				return false;
			}
			foreach (VersionPreheatQuestInfoCache versionPreheatQuestInfoCache in this.ActivityContext.QuestCache.Values)
			{
				if (this.GetQuestStateById(versionPreheatQuestInfoCache.Id) != EVersionPreheatQuestState.QuestCompleted)
				{
					return false;
				}
			}
			return true;
		}
	}

	// Token: 0x17000D75 RID: 3445
	// (get) Token: 0x06009CB1 RID: 40113 RVA: 0x0021E470 File Offset: 0x0021C670
	public bool HasNewQuest
	{
		get
		{
			if (this.IsBonusAvailable && !this.IsBonusClicked())
			{
				return true;
			}
			foreach (PreheatSignRe preheatSignRe in this.ConfigContext.AllQuestCfg)
			{
				VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
				if (this.ActivityContext.QuestCache.TryGetValue(preheatSignRe.Id, out versionPreheatQuestInfoCache) && this.GetQuestStateById(preheatSignRe.Id) != EVersionPreheatQuestState.Lock && !this.IsQuestClickedById(preheatSignRe.Id))
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x06009CB2 RID: 40114 RVA: 0x0021E510 File Offset: 0x0021C710
	public void SyncPreheatSignSurveyInfo(int id, PreheatSignSurveyInfo info)
	{
		this.ActivityContext.SyncPreheatSignSurveyInfo(id, info);
	}

	// Token: 0x06009CB3 RID: 40115 RVA: 0x0021E51F File Offset: 0x0021C71F
	public void SyncPreheatRewardedState(int id)
	{
		this.ActivityContext.SyncPreheatRewardedState(id);
	}

	// Token: 0x06009CB4 RID: 40116 RVA: 0x0021E52D File Offset: 0x0021C72D
	public int GetQuestIdById(int id)
	{
		return this.ConfigContext.GetQuestIdById(id);
	}

	// Token: 0x06009CB5 RID: 40117 RVA: 0x0021E53C File Offset: 0x0021C73C
	public EVersionPreheatQuestState GetQuestStateById(int id)
	{
		VersionPreheatQuestInfoCache cache;
		if (this.ActivityContext.QuestCache.TryGetValue(id, out cache))
		{
			return this.GetQuestStateByQuestInfo(cache);
		}
		return EVersionPreheatQuestState.Lock;
	}

	// Token: 0x06009CB6 RID: 40118 RVA: 0x0021E568 File Offset: 0x0021C768
	public List<VersionPreheatQuestData> BuildQuestDataList()
	{
		List<VersionPreheatQuestData> list = new List<VersionPreheatQuestData>();
		foreach (KeyValuePair<int, VersionPreheatQuestInfoCache> keyValuePair in this.ActivityContext.QuestCache)
		{
			int key = keyValuePair.Key;
			VersionPreheatQuestInfoCache value = keyValuePair.Value;
			VersionPreheatQuestData item = new VersionPreheatQuestData
			{
				Id = key,
				State = this.GetQuestStateByQuestInfo(value),
				NumberTextId = "Preheating_Serial_Number",
				NumberTextArg = key.ToString().PadLeft(2, '0'),
				TitleTextId = this.ConfigContext.GetQuestTitleTextIdById(key),
				UnlockTimestamp = value.UnlockTimestamp
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06009CB7 RID: 40119 RVA: 0x0021E638 File Offset: 0x0021C838
	public VersionPreheatActivityInfoData BuildActivityInfoData()
	{
		Activity? localConfig = this.ActivityContext.LocalConfig;
		VersionPreheatActivityInfoData versionPreheatActivityInfoData = new VersionPreheatActivityInfoData();
		versionPreheatActivityInfoData.TitleData = new VersionPreheatActivityTitleData
		{
			TitleTextId = (((localConfig != null) ? localConfig.GetValueOrDefault().Title : null) ?? ""),
			SubTitleTextId = (((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null) ?? "")
		};
		VersionPreheatActivityDescriptionData versionPreheatActivityDescriptionData = new VersionPreheatActivityDescriptionData();
		VersionPreheatActivityContext activityContext = this.ActivityContext;
		versionPreheatActivityDescriptionData.ContentTextId = (((activityContext.LocalConfig != null) ? activityContext.LocalConfig.GetValueOrDefault().Desc : null) ?? "");
		versionPreheatActivityInfoData.DescriptionData = versionPreheatActivityDescriptionData;
		versionPreheatActivityInfoData.RewardData = new VersionPreheatActivityRewardData
		{
			TitleId = "CollectActivity_reward",
			RewardList = this.ActivityContext.GetPreviewReward(null)
		};
		versionPreheatActivityInfoData.BottomData = new VersionPreheatActivityBottomData
		{
			Test = true
		};
		return versionPreheatActivityInfoData;
	}

	// Token: 0x06009CB8 RID: 40120 RVA: 0x0021E735 File Offset: 0x0021C935
	public VersionPreheatBonusData BuildBonusQuestData()
	{
		return new VersionPreheatBonusData
		{
			NumberTextId = "Preheating_Serial_Number",
			NumberTextArg = "7",
			ContentTextId = this.ConfigContext.BonusQuestContentTextId
		};
	}

	// Token: 0x06009CB9 RID: 40121 RVA: 0x0021E764 File Offset: 0x0021C964
	public VersionPreheatQuestDetailData BuildQuestDetailDataById(int id)
	{
		EVersionPreheatQuestState questStateById = this.GetQuestStateById(id);
		VersionPreheatQuestDetailVoteData voteData = null;
		if (questStateById >= EVersionPreheatQuestState.AfterVote)
		{
			voteData = this.BuildQuestDetailVoteDataById(id);
		}
		VersionPreheatQuestDetailChatData chatData = null;
		if (questStateById == EVersionPreheatQuestState.QuestCompleted)
		{
			chatData = this.BuildQuestDetailChatDataById(id, questStateById);
		}
		VersionPreheatQuestDetailRewardData rewardData = null;
		if (questStateById > EVersionPreheatQuestState.Lock && questStateById <= EVersionPreheatQuestState.AfterVote)
		{
			rewardData = this.BuildQuestDetailRewardDataById(id, questStateById);
		}
		return new VersionPreheatQuestDetailData
		{
			PersistentData = this.BuildQuestDetailPersistentDataById(id),
			VoteData = voteData,
			ChatData = chatData,
			RewardData = rewardData
		};
	}

	// Token: 0x06009CBA RID: 40122 RVA: 0x0021E7D0 File Offset: 0x0021C9D0
	public VersionPreheatQuestDetailData BuildBonusDetailData()
	{
		return new VersionPreheatQuestDetailData
		{
			PersistentData = new VersionPreheatQuestDetailPersistentData
			{
				Index = 6,
				QuestPhotoPath = this.ConfigContext.BonusPhotoPath,
				QuestTitleTextId = this.ConfigContext.BonusQuestTitleTextId,
				QuestContentTextId = this.ConfigContext.BonusQuestContentTextId,
				QuestCrestIndex = this.ConfigContext.BonusCrestIndex,
				QuestSharePhotoPath = this.ConfigContext.BonusSharePhotoPath,
				CanShare = false
			},
			ChatData = this.BuildBonusDetailChatData(),
			BonusTextId = this.ConfigContext.BonusTextId
		};
	}

	// Token: 0x06009CBB RID: 40123 RVA: 0x0021E870 File Offset: 0x0021CA70
	public VersionPreheatVoteData BuildVoteDataById(int id)
	{
		return new VersionPreheatVoteData
		{
			TitleTextId = this.ConfigContext.GetVoteTitleTextIdById(id),
			ContentTextId = this.ConfigContext.GetVoteContentTextIdById(id),
			CrestIndex = this.ConfigContext.GetQuestCrestIndexById(id),
			LeftToggleData = new VersionPreheatVoteToggleData
			{
				Id = id,
				ContentTextId = this.ConfigContext.GetVoteLeftTipsTextIdById(id),
				ClickFunc = new TVersionPreheatVoteClickFunc(ActivityVersionPreheatController.Instance.HandleVoteClickAsync),
				ClickPassData = true
			},
			RightToggleData = new VersionPreheatVoteToggleData
			{
				Id = id,
				ContentTextId = this.ConfigContext.GetVoteRightTipsTextIdById(id),
				ClickFunc = new TVersionPreheatVoteClickFunc(ActivityVersionPreheatController.Instance.HandleVoteClickAsync),
				ClickPassData = false
			},
			ItemListData = this.ConfigContext.GetQuestRewardItemListById(id),
			IsLeftChosen = this.ActivityContext.IsLeftChosen(id)
		};
	}

	// Token: 0x06009CBC RID: 40124 RVA: 0x0021E960 File Offset: 0x0021CB60
	private EVersionPreheatQuestState GetQuestStateByQuestInfo(VersionPreheatQuestInfoCache cache)
	{
		if (TimeUtil.Instance.GetServerTimeStamp() < (double)cache.UnlockTimestamp)
		{
			return EVersionPreheatQuestState.Lock;
		}
		int preIdById = this.ConfigContext.GetPreIdById(cache.Id);
		if (preIdById > 0)
		{
			VersionPreheatQuestInfoCache versionPreheatQuestInfoCache;
			if (!this.ActivityContext.QuestCache.TryGetValue(preIdById, out versionPreheatQuestInfoCache))
			{
				return EVersionPreheatQuestState.Lock;
			}
			if (!ActivityVersionPreheatController.Instance.IsQuestFinishedById(preIdById))
			{
				return EVersionPreheatQuestState.Lock;
			}
		}
		if (ActivityVersionPreheatController.Instance.IsQuestFinishedById(cache.Id))
		{
			return EVersionPreheatQuestState.QuestCompleted;
		}
		if (cache.Rewarded)
		{
			return EVersionPreheatQuestState.AfterVote;
		}
		return EVersionPreheatQuestState.BeforeVote;
	}

	// Token: 0x06009CBD RID: 40125 RVA: 0x0021E9DD File Offset: 0x0021CBDD
	public bool IsQuestClickedById(int id)
	{
		if (this.QuestClickedCache == null)
		{
			this.QuestClickedCache = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestClicked, null);
		}
		Dictionary<int, bool> questClickedCache = this.QuestClickedCache;
		return questClickedCache != null && questClickedCache.GetValueOrDefault(id);
	}

	// Token: 0x06009CBE RID: 40126 RVA: 0x0021EA08 File Offset: 0x0021CC08
	public void SetQuestClickedById(int id)
	{
		if (this.QuestClickedCache == null)
		{
			this.QuestClickedCache = new Dictionary<int, bool>();
		}
		this.QuestClickedCache[id] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestClicked, this.QuestClickedCache);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityContext.Id);
	}

	// Token: 0x06009CBF RID: 40127 RVA: 0x0021EA5E File Offset: 0x0021CC5E
	public bool IsQuestPlayedById(int id)
	{
		if (this.QuestPlayedCache == null)
		{
			this.QuestPlayedCache = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestPlayed, null);
		}
		Dictionary<int, bool> questPlayedCache = this.QuestPlayedCache;
		return questPlayedCache != null && questPlayedCache.GetValueOrDefault(id);
	}

	// Token: 0x06009CC0 RID: 40128 RVA: 0x0021EA88 File Offset: 0x0021CC88
	public void SetQuestPlayedById(int id)
	{
		if (this.QuestPlayedCache == null)
		{
			this.QuestPlayedCache = new Dictionary<int, bool>();
		}
		this.QuestPlayedCache[id] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestPlayed, this.QuestPlayedCache);
	}

	// Token: 0x06009CC1 RID: 40129 RVA: 0x0021EAB8 File Offset: 0x0021CCB8
	public bool IsBonusClicked()
	{
		if (this.BonusClickedCache == null)
		{
			this.BonusClickedCache = LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.VersionPreheatBonusClicked, null);
		}
		return this.BonusClickedCache.GetValueOrDefault();
	}

	// Token: 0x06009CC2 RID: 40130 RVA: 0x0021EAF4 File Offset: 0x0021CCF4
	public void SetBonusClicked()
	{
		if (this.BonusClickedCache == null)
		{
			this.BonusClickedCache = new bool?(true);
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VersionPreheatBonusClicked, this.BonusClickedCache.Value);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityContext.Id);
	}

	// Token: 0x06009CC3 RID: 40131 RVA: 0x0021EB48 File Offset: 0x0021CD48
	public bool IsBonusPlayed()
	{
		if (this.BonusPlayedCache == null)
		{
			this.BonusPlayedCache = LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.VersionPreheatBonusPlayed, null);
		}
		return this.BonusPlayedCache.GetValueOrDefault();
	}

	// Token: 0x06009CC4 RID: 40132 RVA: 0x0021EB83 File Offset: 0x0021CD83
	public void SetBonusPlayed()
	{
		if (this.BonusPlayedCache == null)
		{
			this.BonusPlayedCache = new bool?(true);
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VersionPreheatBonusPlayed, this.BonusPlayedCache.Value);
	}

	// Token: 0x06009CC5 RID: 40133 RVA: 0x0021EBB4 File Offset: 0x0021CDB4
	private VersionPreheatQuestDetailPersistentData BuildQuestDetailPersistentDataById(int id)
	{
		VersionPreheatConfigContext configContext = this.ConfigContext;
		bool flag = this.ActivityContext.IsRewardedById(id);
		return new VersionPreheatQuestDetailPersistentData
		{
			Index = id - 1,
			QuestPhotoPath = configContext.GetQuestPhotoPathById(id),
			QuestTitleTextId = configContext.GetQuestTitleTextIdById(id),
			QuestContentTextId = (flag ? configContext.GetQuestAfterThemeTextIdById(id) : configContext.GetQuestBeforeThemeTextIdById(id)),
			QuestCrestIndex = configContext.GetQuestCrestIndexById(id),
			QuestSharePhotoPath = configContext.GetQuestSharePhotoPathById(id),
			CanShare = (this.GetQuestStateById(id) == EVersionPreheatQuestState.QuestCompleted)
		};
	}

	// Token: 0x06009CC6 RID: 40134 RVA: 0x0021EC40 File Offset: 0x0021CE40
	private VersionPreheatQuestDetailVoteData BuildQuestDetailVoteDataById(int id)
	{
		long voteLeftCountById = this.ActivityContext.GetVoteLeftCountById(id);
		long voteRightCountById = this.ActivityContext.GetVoteRightCountById(id);
		float num;
		float rightNormalized;
		if (voteLeftCountById == voteRightCountById)
		{
			num = 0.5f;
			rightNormalized = 0.5f;
		}
		else
		{
			num = (float)voteLeftCountById / (float)(voteLeftCountById + voteRightCountById);
			rightNormalized = (float)voteRightCountById / (float)(voteLeftCountById + voteRightCountById);
		}
		int num2 = (int)Math.Round((double)(num * 100f));
		int num3 = 100 - num2;
		return new VersionPreheatQuestDetailVoteData
		{
			LeftNormalized = num,
			RightNormalized = rightNormalized,
			LeftPercentageText = num2.ToString() + "%",
			RightPercentageText = num3.ToString() + "%",
			LeftThemeTextId = this.ConfigContext.GetVoteLeftThemeTextIdById(id),
			RightThemeTextId = this.ConfigContext.GetVoteRightThemeTextIdById(id),
			IsLeftChosen = this.ActivityContext.IsLeftChosen(id).GetValueOrDefault()
		};
	}

	// Token: 0x06009CC7 RID: 40135 RVA: 0x0021ED2C File Offset: 0x0021CF2C
	private VersionPreheatQuestDetailChatData BuildQuestDetailChatDataById(int id, EVersionPreheatQuestState state)
	{
		VersionPreheatQuestDetailChatData selfChatData = this.BuildQuestDetailSelfChatDataById(id, state);
		return new VersionPreheatQuestDetailChatData
		{
			NpcContentTextId = this.ConfigContext.GetNpcContentTextIdById(id),
			NpcIconPath = this.ConfigContext.GetNpcIconPathById(id),
			SelfChatData = selfChatData
		};
	}

	// Token: 0x06009CC8 RID: 40136 RVA: 0x0021ED72 File Offset: 0x0021CF72
	private VersionPreheatQuestDetailChatData BuildBonusDetailChatData()
	{
		return new VersionPreheatQuestDetailChatData
		{
			NpcContentTextId = this.ConfigContext.BonusNpcContentTextId,
			NpcIconPath = this.ConfigContext.BonusNpcIconPath
		};
	}

	// Token: 0x06009CC9 RID: 40137 RVA: 0x0021ED9C File Offset: 0x0021CF9C
	[NullableContext(2)]
	private VersionPreheatQuestDetailChatData BuildQuestDetailSelfChatDataById(int id, EVersionPreheatQuestState state)
	{
		if (state < EVersionPreheatQuestState.AfterVote)
		{
			return null;
		}
		int id2 = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? 1501 : 1502;
		RoleInfo? roleInfo;
		return new VersionPreheatQuestDetailChatData
		{
			NpcIconPath = (((RoleConfig.Instance.GetRoleConfig(id2) != null) ? roleInfo.GetValueOrDefault().RoleHeadIconCircle : null) ?? ""),
			NpcContentTextId = this.ConfigContext.GetSelfChatContentTextIdById(id)
		};
	}

	// Token: 0x06009CCA RID: 40138 RVA: 0x0021EE18 File Offset: 0x0021D018
	private VersionPreheatQuestDetailRewardData BuildQuestDetailRewardDataById(int id, EVersionPreheatQuestState state)
	{
		return new VersionPreheatQuestDetailRewardData
		{
			QuestContentTextId = this.ConfigContext.GetQuestContentTextIdById(id),
			ItemListData = this.ConfigContext.GetQuestRewardItemListById(id),
			IsReceived = (state == EVersionPreheatQuestState.AfterVote),
			ClickFunc = new TVersionPreheatQuestDetailClickFunc(ActivityVersionPreheatController.Instance.HandleQuestDetailClickInReward),
			ClickPassData = this.ConfigContext.GetQuestIdById(id)
		};
	}

	// Token: 0x17000D76 RID: 3446
	// (get) Token: 0x06009CCB RID: 40139 RVA: 0x0021EE80 File Offset: 0x0021D080
	public static VersionPreheatModel Instance
	{
		get
		{
			return VersionPreheatModel._Instance;
		}
	}

	// Token: 0x06009CCC RID: 40140 RVA: 0x0021EE87 File Offset: 0x0021D087
	public static VersionPreheatModel GetOrCreateInstance()
	{
		if (VersionPreheatModel._Instance == null)
		{
			VersionPreheatModel.CreateInstance();
		}
		return VersionPreheatModel._Instance;
	}

	// Token: 0x06009CCD RID: 40141 RVA: 0x0021EE9B File Offset: 0x0021D09B
	public static bool CreateInstance()
	{
		if (VersionPreheatModel._Instance != null)
		{
			return true;
		}
		VersionPreheatModel._Instance = new VersionPreheatModel();
		return true;
	}

	// Token: 0x06009CCE RID: 40142 RVA: 0x0021EEB1 File Offset: 0x0021D0B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CCF RID: 40143 RVA: 0x0021EEB3 File Offset: 0x0021D0B3
	public static void ResetStaticDefaultValue()
	{
		VersionPreheatModel._Instance = null;
	}

	// Token: 0x06009CD0 RID: 40144 RVA: 0x0021EEBB File Offset: 0x0021D0BB
	static VersionPreheatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VersionPreheatModel.CreateStaticDefaultValue), new Action(VersionPreheatModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004484 RID: 17540
	public int? CurrentUsingVersionPreheatId;

	// Token: 0x04004485 RID: 17541
	[Nullable(2)]
	private Dictionary<int, bool> QuestClickedCache;

	// Token: 0x04004486 RID: 17542
	private bool? BonusClickedCache;

	// Token: 0x04004487 RID: 17543
	[Nullable(2)]
	private Dictionary<int, bool> QuestPlayedCache;

	// Token: 0x04004488 RID: 17544
	private bool? BonusPlayedCache;

	// Token: 0x04004489 RID: 17545
	private VersionPreheatActivityContext ActivityContext;

	// Token: 0x0400448A RID: 17546
	private VersionPreheatConfigContext ConfigContext;

	// Token: 0x0400448B RID: 17547
	[Nullable(2)]
	private static VersionPreheatModel _Instance;
}
