using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02000A10 RID: 2576
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VersionPreheatModel : ModelBase
{
	// Token: 0x0600708B RID: 28811 RVA: 0x00228170 File Offset: 0x00226370
	protected override bool OnInit()
	{
		this.ActivityContext = new VersionPreheatActivityContext();
		this.ConfigContext = new VersionPreheatConfigContext();
		return true;
	}

	// Token: 0x0600708C RID: 28812 RVA: 0x00228189 File Offset: 0x00226389
	protected override bool OnClear()
	{
		this.ActivityContext.Dispose();
		return true;
	}

	// Token: 0x17000D94 RID: 3476
	// (get) Token: 0x0600708D RID: 28813 RVA: 0x00228197 File Offset: 0x00226397
	public VersionPreheatActivityContext ActivityData
	{
		get
		{
			return this.ActivityContext;
		}
	}

	// Token: 0x17000D95 RID: 3477
	// (get) Token: 0x0600708E RID: 28814 RVA: 0x002281A0 File Offset: 0x002263A0
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

	// Token: 0x17000D96 RID: 3478
	// (get) Token: 0x0600708F RID: 28815 RVA: 0x00228220 File Offset: 0x00226420
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

	// Token: 0x06007090 RID: 28816 RVA: 0x002282C0 File Offset: 0x002264C0
	public void SyncPreheatSignSurveyInfo(int id, PreheatSignSurveyInfo info)
	{
		this.ActivityContext.SyncPreheatSignSurveyInfo(id, info);
	}

	// Token: 0x06007091 RID: 28817 RVA: 0x002282CF File Offset: 0x002264CF
	public void SyncPreheatRewardedState(int id)
	{
		this.ActivityContext.SyncPreheatRewardedState(id);
	}

	// Token: 0x06007092 RID: 28818 RVA: 0x002282DD File Offset: 0x002264DD
	public int GetQuestIdById(int id)
	{
		return this.ConfigContext.GetQuestIdById(id);
	}

	// Token: 0x06007093 RID: 28819 RVA: 0x002282EC File Offset: 0x002264EC
	public EVersionPreheatQuestState GetQuestStateById(int id)
	{
		VersionPreheatQuestInfoCache cache;
		if (this.ActivityContext.QuestCache.TryGetValue(id, out cache))
		{
			return this.GetQuestStateByQuestInfo(cache);
		}
		return EVersionPreheatQuestState.Lock;
	}

	// Token: 0x06007094 RID: 28820 RVA: 0x00228318 File Offset: 0x00226518
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

	// Token: 0x06007095 RID: 28821 RVA: 0x002283E8 File Offset: 0x002265E8
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

	// Token: 0x06007096 RID: 28822 RVA: 0x002284E5 File Offset: 0x002266E5
	public VersionPreheatBonusData BuildBonusQuestData()
	{
		return new VersionPreheatBonusData
		{
			NumberTextId = "Preheating_Serial_Number",
			NumberTextArg = "7",
			ContentTextId = this.ConfigContext.BonusQuestContentTextId
		};
	}

	// Token: 0x06007097 RID: 28823 RVA: 0x00228514 File Offset: 0x00226714
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

	// Token: 0x06007098 RID: 28824 RVA: 0x00228580 File Offset: 0x00226780
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

	// Token: 0x06007099 RID: 28825 RVA: 0x00228620 File Offset: 0x00226820
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

	// Token: 0x0600709A RID: 28826 RVA: 0x00228710 File Offset: 0x00226910
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

	// Token: 0x0600709B RID: 28827 RVA: 0x0022878D File Offset: 0x0022698D
	public bool IsQuestClickedById(int id)
	{
		if (this.QuestClickedCache == null)
		{
			this.QuestClickedCache = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestClicked, null);
		}
		Dictionary<int, bool> questClickedCache = this.QuestClickedCache;
		return questClickedCache != null && questClickedCache.GetValueOrDefault(id);
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x002287B8 File Offset: 0x002269B8
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

	// Token: 0x0600709D RID: 28829 RVA: 0x0022880E File Offset: 0x00226A0E
	public bool IsQuestPlayedById(int id)
	{
		if (this.QuestPlayedCache == null)
		{
			this.QuestPlayedCache = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestPlayed, null);
		}
		Dictionary<int, bool> questPlayedCache = this.QuestPlayedCache;
		return questPlayedCache != null && questPlayedCache.GetValueOrDefault(id);
	}

	// Token: 0x0600709E RID: 28830 RVA: 0x00228838 File Offset: 0x00226A38
	public void SetQuestPlayedById(int id)
	{
		if (this.QuestPlayedCache == null)
		{
			this.QuestPlayedCache = new Dictionary<int, bool>();
		}
		this.QuestPlayedCache[id] = true;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.VersionPreheatToQuestPlayed, this.QuestPlayedCache);
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x00228868 File Offset: 0x00226A68
	public bool IsBonusClicked()
	{
		if (this.BonusClickedCache == null)
		{
			this.BonusClickedCache = LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.VersionPreheatBonusClicked, null);
		}
		return this.BonusClickedCache.GetValueOrDefault();
	}

	// Token: 0x060070A0 RID: 28832 RVA: 0x002288A4 File Offset: 0x00226AA4
	public void SetBonusClicked()
	{
		if (this.BonusClickedCache == null)
		{
			this.BonusClickedCache = new bool?(true);
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VersionPreheatBonusClicked, this.BonusClickedCache.Value);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityContext.Id);
	}

	// Token: 0x060070A1 RID: 28833 RVA: 0x002288F8 File Offset: 0x00226AF8
	public bool IsBonusPlayed()
	{
		if (this.BonusPlayedCache == null)
		{
			this.BonusPlayedCache = LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.VersionPreheatBonusPlayed, null);
		}
		return this.BonusPlayedCache.GetValueOrDefault();
	}

	// Token: 0x060070A2 RID: 28834 RVA: 0x00228933 File Offset: 0x00226B33
	public void SetBonusPlayed()
	{
		if (this.BonusPlayedCache == null)
		{
			this.BonusPlayedCache = new bool?(true);
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VersionPreheatBonusPlayed, this.BonusPlayedCache.Value);
	}

	// Token: 0x060070A3 RID: 28835 RVA: 0x00228964 File Offset: 0x00226B64
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

	// Token: 0x060070A4 RID: 28836 RVA: 0x002289F0 File Offset: 0x00226BF0
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

	// Token: 0x060070A5 RID: 28837 RVA: 0x00228ADC File Offset: 0x00226CDC
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

	// Token: 0x060070A6 RID: 28838 RVA: 0x00228B22 File Offset: 0x00226D22
	private VersionPreheatQuestDetailChatData BuildBonusDetailChatData()
	{
		return new VersionPreheatQuestDetailChatData
		{
			NpcContentTextId = this.ConfigContext.BonusNpcContentTextId,
			NpcIconPath = this.ConfigContext.BonusNpcIconPath
		};
	}

	// Token: 0x060070A7 RID: 28839 RVA: 0x00228B4C File Offset: 0x00226D4C
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

	// Token: 0x060070A8 RID: 28840 RVA: 0x00228BC8 File Offset: 0x00226DC8
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

	// Token: 0x17000D97 RID: 3479
	// (get) Token: 0x060070A9 RID: 28841 RVA: 0x00228C30 File Offset: 0x00226E30
	public static VersionPreheatModel Instance
	{
		get
		{
			return VersionPreheatModel._Instance;
		}
	}

	// Token: 0x060070AA RID: 28842 RVA: 0x00228C37 File Offset: 0x00226E37
	public static VersionPreheatModel GetOrCreateInstance()
	{
		if (VersionPreheatModel._Instance == null)
		{
			VersionPreheatModel.CreateInstance();
		}
		return VersionPreheatModel._Instance;
	}

	// Token: 0x060070AB RID: 28843 RVA: 0x00228C4B File Offset: 0x00226E4B
	public static bool CreateInstance()
	{
		if (VersionPreheatModel._Instance != null)
		{
			return true;
		}
		VersionPreheatModel._Instance = new VersionPreheatModel();
		return true;
	}

	// Token: 0x060070AC RID: 28844 RVA: 0x00228C61 File Offset: 0x00226E61
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060070AD RID: 28845 RVA: 0x00228C63 File Offset: 0x00226E63
	public static void ResetStaticDefaultValue()
	{
		VersionPreheatModel._Instance = null;
	}

	// Token: 0x060070AE RID: 28846 RVA: 0x00228C6B File Offset: 0x00226E6B
	static VersionPreheatModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VersionPreheatModel.CreateStaticDefaultValue), new Action(VersionPreheatModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400452A RID: 17706
	public int? CurrentUsingVersionPreheatId;

	// Token: 0x0400452B RID: 17707
	[Nullable(2)]
	private Dictionary<int, bool> QuestClickedCache;

	// Token: 0x0400452C RID: 17708
	private bool? BonusClickedCache;

	// Token: 0x0400452D RID: 17709
	[Nullable(2)]
	private Dictionary<int, bool> QuestPlayedCache;

	// Token: 0x0400452E RID: 17710
	private bool? BonusPlayedCache;

	// Token: 0x0400452F RID: 17711
	private VersionPreheatActivityContext ActivityContext;

	// Token: 0x04004530 RID: 17712
	private VersionPreheatConfigContext ConfigContext;

	// Token: 0x04004531 RID: 17713
	[Nullable(2)]
	private static VersionPreheatModel _Instance;
}
