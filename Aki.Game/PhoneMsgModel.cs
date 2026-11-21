using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

// Token: 0x020019EA RID: 6634
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhoneMsgModel : ModelBase
{
	// Token: 0x0601058D RID: 66957 RVA: 0x004C55DC File Offset: 0x004C37DC
	public string GetEmptyTexturePath()
	{
		if (string.IsNullOrEmpty(this.EmptyTexturePath))
		{
			this.EmptyTexturePath = UiResourceConfig.Instance.GetResourcePath("T_CommonNone_UI");
		}
		return this.EmptyTexturePath;
	}

	// Token: 0x17001908 RID: 6408
	// (get) Token: 0x0601058E RID: 66958 RVA: 0x004C5606 File Offset: 0x004C3806
	public bool IsUsingDefaultChatBg
	{
		get
		{
			return this.IsDefaultChatBg(this.CurrentUsingChatBgId);
		}
	}

	// Token: 0x17001909 RID: 6409
	// (get) Token: 0x0601058F RID: 66959 RVA: 0x004C5614 File Offset: 0x004C3814
	public HashSet<int> SelectedFilterIdSet
	{
		get
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (HashSet<int> hashSet2 in this.SelectedFilterSetDict.Values)
			{
				foreach (int item in hashSet2)
				{
					hashSet.Add(item);
				}
			}
			return hashSet;
		}
	}

	// Token: 0x06010590 RID: 66960 RVA: 0x004C56A8 File Offset: 0x004C38A8
	public bool IsDefaultTheme(int id)
	{
		return id == 80891001;
	}

	// Token: 0x06010591 RID: 66961 RVA: 0x004C56B4 File Offset: 0x004C38B4
	public void InitFilterSets()
	{
		this.AllFilterTypeSetDict.Clear();
		this.SelectedFilterSetDict.Clear();
		IEnumerable<ChatFilterType> allChatFilterTypeConfigList = PhoneMsgConfig.Instance.GetAllChatFilterTypeConfigList();
		IEnumerable<ChatPartnerFilter> allChatPartnerFilterConfigList = PhoneMsgConfig.Instance.GetAllChatPartnerFilterConfigList();
		if (allChatFilterTypeConfigList == null || allChatPartnerFilterConfigList == null)
		{
			return;
		}
		foreach (ChatFilterType chatFilterType in allChatFilterTypeConfigList)
		{
			this.AllFilterTypeSetDict[chatFilterType.Id] = new HashSet<int>();
			this.SelectedFilterSetDict[chatFilterType.Id] = new HashSet<int>();
		}
		foreach (ChatPartnerFilter chatPartnerFilter in allChatPartnerFilterConfigList)
		{
			foreach (int num in this.AllFilterTypeSetDict.Keys)
			{
				if (chatPartnerFilter.Type == num)
				{
					this.AllFilterTypeSetDict[num].Add(chatPartnerFilter.Id);
					break;
				}
			}
		}
	}

	// Token: 0x06010592 RID: 66962 RVA: 0x004C57F8 File Offset: 0x004C39F8
	public void SetSelectedFilterIdSet(HashSet<int> filterIds)
	{
		foreach (HashSet<int> hashSet in this.SelectedFilterSetDict.Values)
		{
			hashSet.Clear();
		}
		foreach (int item in filterIds)
		{
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.AllFilterTypeSetDict)
			{
				if (keyValuePair.Value.Contains(item))
				{
					this.SelectedFilterSetDict[keyValuePair.Key].Add(item);
					break;
				}
			}
		}
		this.SelectedFilterIdSet_Internal.Clear();
		foreach (int item2 in filterIds)
		{
			this.SelectedFilterIdSet_Internal.Add(item2);
		}
		EventSystem.Instance.Emit(EEventName.OnPhoneMsgFilterChanged);
	}

	// Token: 0x06010593 RID: 66963 RVA: 0x004C594C File Offset: 0x004C3B4C
	public void ClearSelectedFilterIdSet()
	{
		foreach (HashSet<int> hashSet in this.SelectedFilterSetDict.Values)
		{
			hashSet.Clear();
		}
		this.SelectedFilterIdSet_Internal.Clear();
		EventSystem.Instance.Emit(EEventName.OnPhoneMsgFilterChanged);
	}

	// Token: 0x06010594 RID: 66964 RVA: 0x004C59BC File Offset: 0x004C3BBC
	private int GetContentFilterId(EChatMsgType chatMsgType)
	{
		if (chatMsgType == EChatMsgType.Task)
		{
			return 3001;
		}
		if (chatMsgType != EChatMsgType.Reward)
		{
			return 3003;
		}
		return 3002;
	}

	// Token: 0x06010595 RID: 66965 RVA: 0x004C59DC File Offset: 0x004C3BDC
	private bool IsIdPassFilter(int id)
	{
		int num = -1;
		if (this.AllFilterTypeSetDict.Count == 0 || this.SelectedFilterSetDict.Count == 0)
		{
			this.InitFilterSets();
		}
		foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.AllFilterTypeSetDict)
		{
			if (keyValuePair.Value.Contains(id))
			{
				num = keyValuePair.Key;
				break;
			}
		}
		HashSet<int> hashSet;
		return num != -1 && (!this.SelectedFilterSetDict.TryGetValue(num, out hashSet) || hashSet.Count == 0 || hashSet.Contains(id));
	}

	// Token: 0x06010596 RID: 66966 RVA: 0x004C5A8C File Offset: 0x004C3C8C
	public bool IsThisMessageCanShow(int shortMsgId)
	{
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMsgId);
		if (phoneMsgConfig == null)
		{
			return false;
		}
		int contentFilterId = this.GetContentFilterId((EChatMsgType)phoneMsgConfig.Value.FinallPopType);
		return this.IsIdPassFilter(contentFilterId);
	}

	// Token: 0x06010597 RID: 66967 RVA: 0x004C5AD0 File Offset: 0x004C3CD0
	public bool IsThisChatPartnerCanShow(int chatPartnerId)
	{
		ChatPartner? chatPartnerConfig = PhoneMsgConfig.Instance.GetChatPartnerConfig(chatPartnerId);
		if (chatPartnerConfig == null)
		{
			return false;
		}
		List<PhoneMsgShortMsgData> allPhoneMsgShortMsgDataByChatPartnerId = this.GetAllPhoneMsgShortMsgDataByChatPartnerId(chatPartnerId);
		if (allPhoneMsgShortMsgDataByChatPartnerId == null)
		{
			return false;
		}
		bool flag = false;
		int count = allPhoneMsgShortMsgDataByChatPartnerId.Count;
		for (int i = 0; i < count; i++)
		{
			PhoneMsgShortMsgData phoneMsgShortMsgData = allPhoneMsgShortMsgDataByChatPartnerId[i];
			if (this.IsThisMessageCanShow(phoneMsgShortMsgData.ShortMsgId))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		int id = chatPartnerConfig.Value.IsGroupChat ? 1003 : chatPartnerConfig.Value.TypeFilter;
		bool flag2 = this.IsIdPassFilter(id);
		bool flag3 = false;
		if (chatPartnerConfig.Value.RegionFilterListLength > 0)
		{
			for (int j = 0; j < chatPartnerConfig.Value.RegionFilterListLength; j++)
			{
				if (this.IsIdPassFilter(chatPartnerConfig.Value.RegionFilterList(j)))
				{
					flag3 = true;
					break;
				}
			}
		}
		return flag2 && flag3;
	}

	// Token: 0x06010598 RID: 66968 RVA: 0x004C5BCC File Offset: 0x004C3DCC
	protected override bool OnInit()
	{
		IReadOnlyList<PhoneTipShowList> configList = ConfigPhoneTipShowListAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (PhoneTipShowList phoneTipShowList in configList)
			{
				this.NormalDungeonSet.Add((EDungeonSubType)phoneTipShowList.DungeonSubType);
			}
		}
		IReadOnlyList<PhoneInputTime> configList2 = ConfigPhoneInputTimeAll.GetConfigList(true);
		if (configList2 != null)
		{
			foreach (PhoneInputTime config in configList2)
			{
				PhoneMsgInputTimeData item = new PhoneMsgInputTimeData(config);
				this.MsgInputTimeList.Add(item);
			}
		}
		this.InitFilterSets();
		return true;
	}

	// Token: 0x06010599 RID: 66969 RVA: 0x004C5C84 File Offset: 0x004C3E84
	public void InitChatShow(int dialogId, int bgId, int themeId, int charmId, List<int> unLockDialogIds, List<int> unLockBgIds, List<int> unLockThemeIds, List<int> unLockCharmIds)
	{
		this.CurrentUsingChatDialogId = dialogId;
		this.CurrentUsingChatBgId = bgId;
		this.CurrentUsingChatThemeId = themeId;
		this.CurrentUsingChatCharmId = charmId;
		this.SetUnLockChatDialogIds(unLockDialogIds);
		this.SetUnLockChatBgIds(unLockBgIds);
		this.SetUnLockChatThemeIds(unLockThemeIds);
		this.SetUnLockChatCharmIds(unLockCharmIds);
		this.IsPhoneChatShowInitDone = true;
		this.InitServerRedDotSetAndLocalRedDotCache();
	}

	// Token: 0x0601059A RID: 66970 RVA: 0x004C5CDC File Offset: 0x004C3EDC
	public void InitServerRedDotSetAndLocalRedDotCache()
	{
		this.ServerRedDotSet = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhoneMsgChatShowRedDot) as ServerStorageSet);
		this.LocalRedDotCache = new Dictionary<EPhoneMsgServerRedDotType, HashSet<int>>();
		foreach (int num in this.ServerRedDotSet.GetContainer())
		{
			int num2 = num % 10;
			int item = num / 10;
			EPhoneMsgServerRedDotType key = (EPhoneMsgServerRedDotType)num2;
			if (!this.LocalRedDotCache.ContainsKey(key))
			{
				this.LocalRedDotCache[key] = new HashSet<int>();
			}
			this.LocalRedDotCache[key].Add(item);
		}
		this.LastOpenBigPanelTimeStorage = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PhoneMsgLastOpenBigPanelTime) as ServerStorageLong);
		ServerStorageLong lastOpenBigPanelTimeStorage = this.LastOpenBigPanelTimeStorage;
		this.LastOpenBigPanelTime = ((lastOpenBigPanelTimeStorage != null) ? lastOpenBigPanelTimeStorage.Get() : null).GetValueOrDefault();
		this.CleanInvalidChatShowRedDot();
	}

	// Token: 0x0601059B RID: 66971 RVA: 0x004C5DD4 File Offset: 0x004C3FD4
	private void CleanInvalidChatShowRedDot()
	{
		HashSet<int> hashSet;
		if (this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.Preview, out hashSet) && hashSet.Count > 0)
		{
			foreach (int id in new List<int>(hashSet))
			{
				this.RemovePhoneMsgRedDot(EPhoneMsgServerRedDotType.Preview, id);
			}
		}
		HashSet<int> hashSet2;
		if (this.LocalRedDotCache == null || !this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.Decoration, out hashSet2))
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (int item in hashSet2)
		{
			if (!this.UnlockedDialogIds.Contains(item) && !this.UnlockedBgIds.Contains(item) && !this.UnlockedThemeIds.Contains(item) && !this.UnlockedCharmIds.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (int id2 in list)
		{
			this.RemovePhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id2);
		}
	}

	// Token: 0x0601059C RID: 66972 RVA: 0x004C5F2C File Offset: 0x004C412C
	private int EncodePhoneMsgRedDot(EPhoneMsgServerRedDotType type, int id)
	{
		return (int)(id * 10 + type);
	}

	// Token: 0x0601059D RID: 66973 RVA: 0x004C5F34 File Offset: 0x004C4134
	private void AddPhoneMsgRedDot(EPhoneMsgServerRedDotType type, int id)
	{
		if (this.LocalRedDotCache == null)
		{
			this.LocalRedDotCache = new Dictionary<EPhoneMsgServerRedDotType, HashSet<int>>();
		}
		if (!this.LocalRedDotCache.ContainsKey(type))
		{
			this.LocalRedDotCache[type] = new HashSet<int>();
		}
		this.LocalRedDotCache[type].Add(id);
		int value = this.EncodePhoneMsgRedDot(type, id);
		ServerStorageSet serverRedDotSet = this.ServerRedDotSet;
		if (serverRedDotSet == null)
		{
			return;
		}
		serverRedDotSet.Add(value);
	}

	// Token: 0x0601059E RID: 66974 RVA: 0x004C5FA0 File Offset: 0x004C41A0
	private void RemovePhoneMsgRedDot(EPhoneMsgServerRedDotType type, int id)
	{
		if (this.LocalRedDotCache == null)
		{
			return;
		}
		HashSet<int> hashSet;
		if (this.LocalRedDotCache.TryGetValue(type, out hashSet))
		{
			hashSet.Remove(id);
		}
		int value = this.EncodePhoneMsgRedDot(type, id);
		ServerStorageSet serverRedDotSet = this.ServerRedDotSet;
		if (serverRedDotSet == null)
		{
			return;
		}
		serverRedDotSet.Remove(value);
	}

	// Token: 0x0601059F RID: 66975 RVA: 0x004C5FE8 File Offset: 0x004C41E8
	public void AddVoiceRedDot(int id)
	{
		this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.VoiceOnce, id);
	}

	// Token: 0x060105A0 RID: 66976 RVA: 0x004C5FF4 File Offset: 0x004C41F4
	public bool TryGetVoiceRedDot(int id)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.VoiceOnce, out hashSet) && hashSet.Contains(id);
	}

	// Token: 0x060105A1 RID: 66977 RVA: 0x004C6024 File Offset: 0x004C4224
	public bool CheckIsInWhiteList()
	{
		if (BattleUiControl.Instance.GetMainViewName() != EUiViewName.BattleView)
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config == null || !this.NormalDungeonSet.Contains((EDungeonSubType)config.Value.InstSubType))
			{
				return false;
			}
			if (config.Value.InstSubType == 12)
			{
				PhoneTipShowList? config2 = ConfigPhoneTipShowListByDungeonSubType.GetConfig(12, true);
				if (config2 == null)
				{
					return false;
				}
				bool flag = false;
				int[] array = config2.Value.WorldDungeonSubTypeList();
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					if (array[i] == config.Value.WorldDungeonSubType)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060105A2 RID: 66978 RVA: 0x004C6100 File Offset: 0x004C4300
	public void SetUnLockChatDialogIds(IEnumerable<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedDialogIds.Add(item);
		}
	}

	// Token: 0x060105A3 RID: 66979 RVA: 0x004C6150 File Offset: 0x004C4350
	public void SetUnLockChatBgIds(IEnumerable<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedBgIds.Add(item);
		}
	}

	// Token: 0x060105A4 RID: 66980 RVA: 0x004C61A0 File Offset: 0x004C43A0
	public void SetUnLockChatThemeIds(IEnumerable<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedThemeIds.Add(item);
		}
	}

	// Token: 0x060105A5 RID: 66981 RVA: 0x004C61F0 File Offset: 0x004C43F0
	public void SetUnLockChatCharmIds(IEnumerable<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedCharmIds.Add(item);
		}
	}

	// Token: 0x060105A6 RID: 66982 RVA: 0x004C6240 File Offset: 0x004C4440
	public void OnPhoneMsgDialogAndBgAddNotify(ShortMessageItemUpdateNotify message)
	{
		RepeatedField<int> bubbleIds = message.BubbleIds;
		if (bubbleIds != null && bubbleIds.Count > 0)
		{
			this.SetUnLockChatDialogIds(bubbleIds);
			foreach (int id in bubbleIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id);
			}
		}
		RepeatedField<int> chatBgIds = message.ChatBgIds;
		if (chatBgIds != null && chatBgIds.Count > 0)
		{
			this.SetUnLockChatBgIds(chatBgIds);
			foreach (int id2 in chatBgIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id2);
			}
		}
		RepeatedField<int> chatThemeIds = message.ChatThemeIds;
		if (chatThemeIds != null && chatThemeIds.Count > 0)
		{
			this.SetUnLockChatThemeIds(chatThemeIds);
			foreach (int id3 in chatThemeIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id3);
			}
		}
		RepeatedField<int> chatCharmIds = message.ChatCharmIds;
		if (chatCharmIds != null && chatCharmIds.Count > 0)
		{
			this.SetUnLockChatCharmIds(chatCharmIds);
			foreach (int id4 in chatCharmIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id4);
			}
		}
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmUpdate);
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate);
	}

	// Token: 0x060105A7 RID: 66983 RVA: 0x004C63D8 File Offset: 0x004C45D8
	public bool IsChatDialogUnlocked(int dialogId)
	{
		return this.UnlockedDialogIds.Contains(dialogId);
	}

	// Token: 0x060105A8 RID: 66984 RVA: 0x004C63E6 File Offset: 0x004C45E6
	public bool IsChatBgUnlocked(int bgId)
	{
		return this.UnlockedBgIds.Contains(bgId);
	}

	// Token: 0x060105A9 RID: 66985 RVA: 0x004C63F4 File Offset: 0x004C45F4
	public bool IsChatThemeUnlocked(int themeId)
	{
		return this.UnlockedThemeIds.Contains(themeId);
	}

	// Token: 0x060105AA RID: 66986 RVA: 0x004C6402 File Offset: 0x004C4602
	public bool IsChatCharmUnlocked(int charmId)
	{
		return this.UnlockedCharmIds.Contains(charmId);
	}

	// Token: 0x060105AB RID: 66987 RVA: 0x004C6410 File Offset: 0x004C4610
	public bool IsDefaultChatBg(int id)
	{
		return id == 80820001;
	}

	// Token: 0x060105AC RID: 66988 RVA: 0x004C641C File Offset: 0x004C461C
	public void OnPhoneMsgUpdateNotify(ShortMessageUpdateNotify message)
	{
		ChangeReason reason = message.Reason;
		this.AddMessages(message.Adds, new ChangeReason?(reason), true, true);
		RepeatedField<int> removes = message.Removes;
		int count = removes.Count;
		for (int i = 0; i < count; i++)
		{
			int num = removes[i];
			if (this.Id2ShortMessagesDict.ContainsKey(num))
			{
				this.Id2ShortMessagesDict.Remove(num);
			}
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(num);
			if (phoneMsgConfig != null && this.ChatPartnerId2ShortMessagesIdsDict.ContainsKey(phoneMsgConfig.Value.WhichChat))
			{
				int whichChat = phoneMsgConfig.Value.WhichChat;
				List<int> list = this.ChatPartnerId2ShortMessagesIdsDict[whichChat];
				int num2 = list.IndexOf(num);
				if (num2 != -1)
				{
					list.RemoveAt(num2);
				}
				if (list.Count == 0)
				{
					this.ChatPartnerId2ShortMessagesIdsDict.Remove(whichChat);
					int num3 = this.ChatPartnerIdList.IndexOf(whichChat);
					if (num3 != -1)
					{
						this.ChatPartnerIdList.RemoveAt(num3);
					}
				}
			}
		}
		if (count > 0)
		{
			EventSystem.Instance.Emit(EEventName.OnPhoneHaveMsgToRemove);
		}
	}

	// Token: 0x060105AD RID: 66989 RVA: 0x004C6548 File Offset: 0x004C4748
	public void AddMessages(IReadOnlyList<ShortMessageInfo> dataList, ChangeReason? reason = null, bool isNeedShowTips = true, bool isNeedSetLatestShortMsgTime = true)
	{
		bool flag = isNeedShowTips;
		long num = 0L;
		int count = dataList.Count;
		for (int i = 0; i < count; i++)
		{
			ShortMessageInfo shortMessageInfo = dataList[i];
			int configId = shortMessageInfo.ConfigId;
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(configId);
			if (phoneMsgConfig != null)
			{
				PhoneMsgShortMsgData phoneMsgShortMsgData = new PhoneMsgShortMsgData(configId);
				this.Id2ShortMessagesDict[configId] = phoneMsgShortMsgData;
				phoneMsgShortMsgData.IsRead = shortMessageInfo.IsRead;
				phoneMsgShortMsgData.IsReceived = shortMessageInfo.IsReceived;
				phoneMsgShortMsgData.LatestProgress = shortMessageInfo.LastConfigId;
				phoneMsgShortMsgData.UnLockTime = shortMessageInfo.UnlockTime;
				MapField<int, int> options = shortMessageInfo.Options;
				int count2 = options.Count;
				foreach (KeyValuePair<int, int> keyValuePair in options)
				{
					phoneMsgShortMsgData.SelectedOptionsDict[keyValuePair.Key] = keyValuePair.Value;
				}
				ShortMessage? phoneMsgConfig2 = PhoneMsgConfig.Instance.GetPhoneMsgConfig(configId);
				long unLockTime = phoneMsgShortMsgData.UnLockTime;
				if (!phoneMsgShortMsgData.IsRead && phoneMsgConfig2 != null && phoneMsgConfig2.Value.TipType == 1 && unLockTime > num)
				{
					num = unLockTime;
				}
				int whichChat = phoneMsgConfig.Value.WhichChat;
				if (!this.ChatPartnerIdList.Contains(whichChat))
				{
					this.ChatPartnerIdList.Add(whichChat);
				}
				if (this.ChatPartnerId2ShortMessagesIdsDict.ContainsKey(whichChat))
				{
					List<int> list = this.ChatPartnerId2ShortMessagesIdsDict[whichChat];
					if (!list.Contains(configId))
					{
						list.Add(configId);
					}
				}
				else
				{
					this.ChatPartnerId2ShortMessagesIdsDict[whichChat] = new List<int>
					{
						configId
					};
				}
				if (reason != null)
				{
					switch (reason.Value)
					{
					case ChangeReason.None:
						global::Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "短信通知原因为Proto_None, 请联系后端", default(ReadOnlySpan<ValueTuple<string, object>>));
						flag = false;
						break;
					case ChangeReason.QuestFix:
						flag = false;
						break;
					case ChangeReason.ActionRevert:
						flag = false;
						break;
					}
				}
				if (flag && phoneMsgConfig.Value.TipType != 0)
				{
					if (phoneMsgConfig.Value.TipType == 1)
					{
						this.CurrentToBeNotifiedMsgInSmallHeadQueue.Add(configId);
					}
					else
					{
						this.CurrentToBeNotifiedMsgArray.Add(configId);
					}
					EventSystem.Instance.Emit(EEventName.OnNewPhoneMsgNeedShowTips);
				}
			}
		}
		if (isNeedSetLatestShortMsgTime)
		{
			this.SetLatestShortMsgTime(num);
		}
		EventSystem.Instance.Emit<int>(EEventName.OnPhoneMsgAdd, 0);
		this.SortChatPartnerAndMessages();
	}

	// Token: 0x060105AE RID: 66990 RVA: 0x004C67E0 File Offset: 0x004C49E0
	public void SortChatPartnerAndMessages()
	{
		this.SortAllMessages();
		this.SortChatPartnerList();
	}

	// Token: 0x060105AF RID: 66991 RVA: 0x004C67F0 File Offset: 0x004C49F0
	public void SortAllMessages()
	{
		if (this.ChatPartnerId2ShortMessagesIdsDict.Count <= 1)
		{
			return;
		}
		foreach (KeyValuePair<int, List<int>> keyValuePair in this.ChatPartnerId2ShortMessagesIdsDict)
		{
			List<int> value = keyValuePair.Value;
			if (value.Count > 1)
			{
				List<int> list = new List<int>();
				List<int> list2 = new List<int>();
				Dictionary<int, int> otherMsgIdIndexMap = new Dictionary<int, int>();
				for (int i = 0; i < value.Count; i++)
				{
					int num = value[i];
					PhoneMsgShortMsgData phoneMsgShortMsgData;
					if (!this.Id2ShortMessagesDict.TryGetValue(num, out phoneMsgShortMsgData))
					{
						otherMsgIdIndexMap[num] = list2.Count;
						list2.Add(num);
					}
					else
					{
						ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(num);
						if (phoneMsgShortMsgData != null && phoneMsgConfig != null && phoneMsgConfig.Value.FinallPopType == 6 && !phoneMsgShortMsgData.IsReceived)
						{
							list.Add(num);
						}
						else
						{
							otherMsgIdIndexMap[num] = list2.Count;
							list2.Add(num);
						}
					}
				}
				list2.Sort(delegate(int a, int b)
				{
					PhoneMsgShortMsgData phoneMsgShortMsgData2 = this.Id2ShortMessagesDict[a];
					PhoneMsgShortMsgData phoneMsgShortMsgData3 = this.Id2ShortMessagesDict[b];
					if (!phoneMsgShortMsgData2.IsRead && phoneMsgShortMsgData3.IsRead)
					{
						return -1;
					}
					if (phoneMsgShortMsgData2.IsRead && !phoneMsgShortMsgData3.IsRead)
					{
						return 1;
					}
					long unLockTime = phoneMsgShortMsgData2.UnLockTime;
					long unLockTime2 = phoneMsgShortMsgData3.UnLockTime;
					if (unLockTime == unLockTime2)
					{
						int num2;
						otherMsgIdIndexMap.TryGetValue(a, out num2);
						int num3;
						otherMsgIdIndexMap.TryGetValue(b, out num3);
						if (num2 == num3)
						{
							return 0;
						}
						if (num2 >= num3)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						if (unLockTime >= unLockTime2)
						{
							return -1;
						}
						return 1;
					}
				});
				value.Clear();
				for (int j = 0; j < list.Count; j++)
				{
					value.Add(list[j]);
				}
				for (int k = 0; k < list2.Count; k++)
				{
					value.Add(list2[k]);
				}
			}
		}
	}

	// Token: 0x060105B0 RID: 66992 RVA: 0x004C69B0 File Offset: 0x004C4BB0
	public void SortChatPartnerList()
	{
		this.UnreceivedPartnerList = new List<int>();
		this.ReceivedUnreadPartnerList = new List<int>();
		this.ReceivedReadPartnerList = new List<int>();
		for (int i = 0; i < this.ChatPartnerIdList.Count; i++)
		{
			int num = this.ChatPartnerIdList[i];
			if (this.IsSomeOneHasUnReceivedMsg(num))
			{
				this.UnreceivedPartnerList.Add(num);
			}
			else if (this.IsPartnerHasUnreadMsg(num))
			{
				this.ReceivedUnreadPartnerList.Add(num);
			}
			else
			{
				this.ReceivedReadPartnerList.Add(num);
			}
		}
		this.SortReceivedPartnerList();
		this.ChatPartnerIdList = new List<int>();
		for (int j = 0; j < this.UnreceivedPartnerList.Count; j++)
		{
			this.ChatPartnerIdList.Add(this.UnreceivedPartnerList[j]);
		}
		for (int k = 0; k < this.ReceivedUnreadPartnerList.Count; k++)
		{
			this.ChatPartnerIdList.Add(this.ReceivedUnreadPartnerList[k]);
		}
		for (int l = 0; l < this.ReceivedReadPartnerList.Count; l++)
		{
			this.ChatPartnerIdList.Add(this.ReceivedReadPartnerList[l]);
		}
	}

	// Token: 0x060105B1 RID: 66993 RVA: 0x004C6AD8 File Offset: 0x004C4CD8
	private bool IsPartnerHasUnreadMsg(int chatPartnerId)
	{
		List<PhoneMsgShortMsgData> allPhoneMsgShortMsgDataByChatPartnerId = this.GetAllPhoneMsgShortMsgDataByChatPartnerId(chatPartnerId);
		if (allPhoneMsgShortMsgDataByChatPartnerId == null)
		{
			return false;
		}
		for (int i = 0; i < allPhoneMsgShortMsgDataByChatPartnerId.Count; i++)
		{
			if (!allPhoneMsgShortMsgDataByChatPartnerId[i].IsRead)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060105B2 RID: 66994 RVA: 0x004C6B14 File Offset: 0x004C4D14
	public void SortReceivedPartnerList()
	{
		if (this.ReceivedUnreadPartnerList != null && this.ReceivedUnreadPartnerList.Count > 0)
		{
			this.ReceivedUnreadPartnerList.Sort((int a, int b) => this.ComparePartnerByUnlockTime(a, b));
		}
		if (this.ReceivedReadPartnerList != null && this.ReceivedReadPartnerList.Count > 0)
		{
			this.ReceivedReadPartnerList.Sort((int a, int b) => this.ComparePartnerByUnlockTime(a, b));
		}
	}

	// Token: 0x060105B3 RID: 66995 RVA: 0x004C6B7C File Offset: 0x004C4D7C
	private int ComparePartnerByUnlockTime(int a, int b)
	{
		List<int> list = this.ChatPartnerId2ShortMessagesIdsDict[a];
		List<int> list2 = this.ChatPartnerId2ShortMessagesIdsDict[b];
		PhoneMsgShortMsgData phoneMsgShortMsgData = this.Id2ShortMessagesDict[list[0]];
		PhoneMsgShortMsgData phoneMsgShortMsgData2 = this.Id2ShortMessagesDict[list2[0]];
		long unLockTime = phoneMsgShortMsgData.UnLockTime;
		long unLockTime2 = phoneMsgShortMsgData2.UnLockTime;
		if (unLockTime == unLockTime2)
		{
			if (list[0] >= list2[0])
			{
				return -1;
			}
			return 1;
		}
		else
		{
			if (unLockTime >= unLockTime2)
			{
				return -1;
			}
			return 1;
		}
	}

	// Token: 0x060105B4 RID: 66996 RVA: 0x004C6BF7 File Offset: 0x004C4DF7
	public List<int> GetAllChatPartnerIds()
	{
		return this.ChatPartnerIdList;
	}

	// Token: 0x060105B5 RID: 66997 RVA: 0x004C6C00 File Offset: 0x004C4E00
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhoneMsgShortMsgData> GetAllPhoneMsgShortMsgDataByChatPartnerId(int chatPartnerId)
	{
		if (!this.ChatPartnerIdList.Contains(chatPartnerId))
		{
			return null;
		}
		List<int> list;
		if (!this.ChatPartnerId2ShortMessagesIdsDict.TryGetValue(chatPartnerId, out list))
		{
			return null;
		}
		List<PhoneMsgShortMsgData> list2 = new List<PhoneMsgShortMsgData>();
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			int key = list[i];
			PhoneMsgShortMsgData phoneMsgShortMsgData;
			if (this.Id2ShortMessagesDict.TryGetValue(key, out phoneMsgShortMsgData) && phoneMsgShortMsgData != null)
			{
				list2.Add(phoneMsgShortMsgData);
			}
		}
		return list2;
	}

	// Token: 0x060105B6 RID: 66998 RVA: 0x004C6C70 File Offset: 0x004C4E70
	[NullableContext(2)]
	public PhoneMsgShortMsgData GetPhoneMsgShortMsgDataByShortMsgId(int shortMsgId)
	{
		PhoneMsgShortMsgData result;
		if (this.Id2ShortMessagesDict.TryGetValue(shortMsgId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060105B7 RID: 66999 RVA: 0x004C6C90 File Offset: 0x004C4E90
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public ValueTuple<string, string, string>? GetFirstMsgDataByShortMsgId(int shortMsgId)
	{
		if (this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId) == null)
		{
			return null;
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(shortMsgId);
		if (phoneMsgConfig == null)
		{
			return null;
		}
		string[] array = phoneMsgConfig.Value.FlowParam();
		List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(array[0], int.Parse(array[1]), int.Parse(array[2]));
		if (flowStateActions == null)
		{
			return null;
		}
		if (flowStateActions[0] == null)
		{
			return null;
		}
		int count = flowStateActions.Count;
		for (int i = 0; i < count; i++)
		{
			ActionInfo actionInfo = flowStateActions[i];
			if (actionInfo.Name == EAction.ShowTalk)
			{
				List<ITalkItem> talkItems = ((ShowTalk)actionInfo.Params).TalkItems;
				int count2 = talkItems.Count;
				int j = 0;
				while (j < count2)
				{
					ITalkItem talkItem = talkItems[j];
					if (!this.IsSystemTipMessage(talkItem))
					{
						int? whoId = talkItem.WhoId;
						Speaker? speaker = null;
						if (whoId != null)
						{
							speaker = ConfigSpeakerById.GetConfig(whoId.Value, true);
						}
						if (speaker == null)
						{
							return null;
						}
						string item = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Value.Id)) ?? "";
						string headIconAsset = ConfigSpeakerById.GetConfig(talkItem.WhoId.Value, true).Value.HeadIconAsset;
						string item2 = "";
						ETalkItemType value = talkItem.Type.Value;
						if (value != ETalkItemType.Talk)
						{
							if (value == ETalkItemType.PhoneMessage)
							{
								ITalkItemPhoneMessage talkItemPhoneMessage = (ITalkItemPhoneMessage)talkItem;
								EPhoneMessageType type = talkItemPhoneMessage.MessageType.Type;
								if (type != EPhoneMessageType.Emoji)
								{
									if (type == EPhoneMessageType.Attachment)
									{
										PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(((ITalkItemPhoneMessageAttachment)talkItemPhoneMessage.MessageType).AttachmentId, true);
										item2 = ((((config != null) ? config.GetValueOrDefault().Type : null) == "CoordinateTeleport") ? (TextConfig.Instance.GetMultiText("PhoneSystem_MapCoordinates", Array.Empty<string>()) ?? "") : (TextConfig.Instance.GetMultiText("ChatBubble_Content_Attachment", Array.Empty<string>()) ?? ""));
									}
								}
								else
								{
									int emojiId = ((ITalkItemPhoneMessageEmoji)talkItemPhoneMessage.MessageType).EmojiId;
									ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(emojiId);
									if (expressionConfig != null)
									{
										string name = expressionConfig.Value.Name;
										string text = TextConfig.Instance.GetMultiText(name, Array.Empty<string>()) ?? "";
										item2 = TextConfig.Instance.GetMultiText("ChatBubble_Content_Expression", new string[]
										{
											text
										});
									}
								}
							}
						}
						else
						{
							item2 = (PublicUtil.Instance.GetFlowConfigLocalText(talkItem.TidTalk) ?? "");
						}
						return new ValueTuple<string, string, string>?(new ValueTuple<string, string, string>(item, headIconAsset, item2));
					}
					else
					{
						j++;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060105B8 RID: 67000 RVA: 0x004C6FB8 File Offset: 0x004C51B8
	public bool IsShortMsgRead(int shortMsgId)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		return phoneMsgShortMsgDataByShortMsgId != null && phoneMsgShortMsgDataByShortMsgId.IsRead;
	}

	// Token: 0x060105B9 RID: 67001 RVA: 0x004C6FD8 File Offset: 0x004C51D8
	public bool IsSomeOneHasUnReadMsg(int chatPartnerId)
	{
		List<PhoneMsgShortMsgData> allPhoneMsgShortMsgDataByChatPartnerId = this.GetAllPhoneMsgShortMsgDataByChatPartnerId(chatPartnerId);
		if (allPhoneMsgShortMsgDataByChatPartnerId == null)
		{
			return false;
		}
		int count = allPhoneMsgShortMsgDataByChatPartnerId.Count;
		for (int i = 0; i < count; i++)
		{
			if (!allPhoneMsgShortMsgDataByChatPartnerId[i].IsRead)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060105BA RID: 67002 RVA: 0x004C7018 File Offset: 0x004C5218
	public bool IsSomeOneHasUnReceivedMsg(int chatPartnerId)
	{
		List<PhoneMsgShortMsgData> allPhoneMsgShortMsgDataByChatPartnerId = this.GetAllPhoneMsgShortMsgDataByChatPartnerId(chatPartnerId);
		if (allPhoneMsgShortMsgDataByChatPartnerId == null)
		{
			return false;
		}
		int count = allPhoneMsgShortMsgDataByChatPartnerId.Count;
		for (int i = 0; i < count; i++)
		{
			PhoneMsgShortMsgData phoneMsgShortMsgData = allPhoneMsgShortMsgDataByChatPartnerId[i];
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(phoneMsgShortMsgData.ShortMsgId);
			if (phoneMsgConfig != null && phoneMsgConfig.Value.FinallPopType == 6 && !phoneMsgShortMsgData.IsReceived)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060105BB RID: 67003 RVA: 0x004C7088 File Offset: 0x004C5288
	public bool IsAllPhoneMsgRead()
	{
		foreach (KeyValuePair<int, PhoneMsgShortMsgData> keyValuePair in this.Id2ShortMessagesDict)
		{
			if (!keyValuePair.Value.IsRead)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060105BC RID: 67004 RVA: 0x004C70EC File Offset: 0x004C52EC
	public bool IsHasUnReceivedMsg()
	{
		foreach (KeyValuePair<int, PhoneMsgShortMsgData> keyValuePair in this.Id2ShortMessagesDict)
		{
			PhoneMsgShortMsgData value = keyValuePair.Value;
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(value.ShortMsgId);
			if (phoneMsgConfig != null && phoneMsgConfig.Value.FinallPopType == 6 && !value.IsReceived)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060105BD RID: 67005 RVA: 0x004C7180 File Offset: 0x004C5380
	public bool IsPhoneMsgUnlock(int shortMsgId)
	{
		return this.Id2ShortMessagesDict.ContainsKey(shortMsgId);
	}

	// Token: 0x060105BE RID: 67006 RVA: 0x004C7190 File Offset: 0x004C5390
	public void SetShortMsgOptionData(int shortMsgId, int chatIndex, int optIndex)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		if (phoneMsgShortMsgDataByShortMsgId != null)
		{
			phoneMsgShortMsgDataByShortMsgId.SelectedOptionsDict[chatIndex] = optIndex;
			EventSystem.Instance.Emit<int>(EEventName.OnUpdateShortMsgOptionData, shortMsgId);
		}
	}

	// Token: 0x060105BF RID: 67007 RVA: 0x004C71C8 File Offset: 0x004C53C8
	public bool GetShortMsgHasAnySelectedOption(int shortMsgId)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		return phoneMsgShortMsgDataByShortMsgId != null && phoneMsgShortMsgDataByShortMsgId.SelectedOptionsDict.Count > 0;
	}

	// Token: 0x060105C0 RID: 67008 RVA: 0x004C71F0 File Offset: 0x004C53F0
	public void SetShortMsgRewardData(int shortMsgId, bool isReceived)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		if (phoneMsgShortMsgDataByShortMsgId != null)
		{
			phoneMsgShortMsgDataByShortMsgId.IsReceived = isReceived;
		}
	}

	// Token: 0x060105C1 RID: 67009 RVA: 0x004C7210 File Offset: 0x004C5410
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<ShortMessageDisplayData> CreateShortMessageDisplayDataByShortMsgId(int shortMsgId)
	{
		PhoneMsgModel.<CreateShortMessageDisplayDataByShortMsgId>d__84 <CreateShortMessageDisplayDataByShortMsgId>d__;
		<CreateShortMessageDisplayDataByShortMsgId>d__.<>t__builder = AsyncUniTaskMethodBuilder<ShortMessageDisplayData>.Create();
		<CreateShortMessageDisplayDataByShortMsgId>d__.<>4__this = this;
		<CreateShortMessageDisplayDataByShortMsgId>d__.shortMsgId = shortMsgId;
		<CreateShortMessageDisplayDataByShortMsgId>d__.<>1__state = -1;
		<CreateShortMessageDisplayDataByShortMsgId>d__.<>t__builder.Start<PhoneMsgModel.<CreateShortMessageDisplayDataByShortMsgId>d__84>(ref <CreateShortMessageDisplayDataByShortMsgId>d__);
		return <CreateShortMessageDisplayDataByShortMsgId>d__.<>t__builder.Task;
	}

	// Token: 0x060105C2 RID: 67010 RVA: 0x004C725C File Offset: 0x004C545C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<ShortMessageDisplayData> CreateShortMessageDisplayData(PhoneMsgShortMsgData shortMsgData)
	{
		PhoneMsgModel.<CreateShortMessageDisplayData>d__85 <CreateShortMessageDisplayData>d__;
		<CreateShortMessageDisplayData>d__.<>t__builder = AsyncUniTaskMethodBuilder<ShortMessageDisplayData>.Create();
		<CreateShortMessageDisplayData>d__.<>4__this = this;
		<CreateShortMessageDisplayData>d__.shortMsgData = shortMsgData;
		<CreateShortMessageDisplayData>d__.<>1__state = -1;
		<CreateShortMessageDisplayData>d__.<>t__builder.Start<PhoneMsgModel.<CreateShortMessageDisplayData>d__85>(ref <CreateShortMessageDisplayData>d__);
		return <CreateShortMessageDisplayData>d__.<>t__builder.Task;
	}

	// Token: 0x060105C3 RID: 67011 RVA: 0x004C72A8 File Offset: 0x004C54A8
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<string> GetLastChatTextByShortMsgId(int shortMsgId, EGetLastChatTextType type = EGetLastChatTextType.FromReadIndex)
	{
		PhoneMsgModel.<GetLastChatTextByShortMsgId>d__86 <GetLastChatTextByShortMsgId>d__;
		<GetLastChatTextByShortMsgId>d__.<>t__builder = AsyncUniTaskMethodBuilder<string>.Create();
		<GetLastChatTextByShortMsgId>d__.<>4__this = this;
		<GetLastChatTextByShortMsgId>d__.shortMsgId = shortMsgId;
		<GetLastChatTextByShortMsgId>d__.type = type;
		<GetLastChatTextByShortMsgId>d__.<>1__state = -1;
		<GetLastChatTextByShortMsgId>d__.<>t__builder.Start<PhoneMsgModel.<GetLastChatTextByShortMsgId>d__86>(ref <GetLastChatTextByShortMsgId>d__);
		return <GetLastChatTextByShortMsgId>d__.<>t__builder.Task;
	}

	// Token: 0x060105C4 RID: 67012 RVA: 0x004C72FC File Offset: 0x004C54FC
	public string GetLastChatTextByDisplayData(ShortMessageDisplayData displayData, EGetLastChatTextType type = EGetLastChatTextType.FromReadIndex)
	{
		List<PhoneMsgChatData> chatDataList = displayData.ChatDataList;
		if (chatDataList.Count == 0)
		{
			return "";
		}
		string text = "";
		int num = 0;
		if (type != EGetLastChatTextType.FromReadIndex)
		{
			if (type == EGetLastChatTextType.FromLastCanReadIndex)
			{
				num = chatDataList.Count - 1;
			}
		}
		else
		{
			num = displayData.ReadIndex;
		}
		for (int i = num; i >= 0; i--)
		{
			PhoneMsgChatData phoneMsgChatData = chatDataList[i];
			if (phoneMsgChatData != null && phoneMsgChatData.ChatContentType != EPhoneMsgContentType.Tips)
			{
				PhoneMsgChatData lastChatData = phoneMsgChatData;
				text = this.GetTalkText(lastChatData, displayData);
				if (!(text == ""))
				{
					break;
				}
			}
		}
		if (text == "")
		{
			if (displayData.ReadIndex < 0)
			{
				int count = chatDataList.Count;
				for (int j = 0; j < count; j++)
				{
					PhoneMsgChatData phoneMsgChatData2 = chatDataList[j];
					if (phoneMsgChatData2 != null && phoneMsgChatData2.ChatContentType != EPhoneMsgContentType.Tips)
					{
						PhoneMsgChatData lastChatData = phoneMsgChatData2;
						text = this.GetTalkText(lastChatData, displayData);
						if (!(text == ""))
						{
							break;
						}
					}
				}
			}
			else
			{
				text = (TextConfig.Instance.GetMultiText("ChatBubble_Content_Input", Array.Empty<string>()) ?? "");
			}
		}
		return text;
	}

	// Token: 0x060105C5 RID: 67013 RVA: 0x004C7408 File Offset: 0x004C5608
	private string GetTalkText(PhoneMsgChatData lastChatData, ShortMessageDisplayData displayData)
	{
		string result = "";
		if (lastChatData != null)
		{
			EChatMsgType contentType = lastChatData.ContentType;
			switch (contentType)
			{
			case EChatMsgType.Text:
				result = lastChatData.ContentStr;
				break;
			case EChatMsgType.Emoji:
			{
				int contentNum = lastChatData.ContentNum;
				ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(contentNum);
				if (expressionConfig != null)
				{
					string name = expressionConfig.Value.Name;
					string text = TextConfig.Instance.GetMultiText(name, Array.Empty<string>()) ?? "";
					result = TextConfig.Instance.GetMultiText("ChatBubble_Content_Expression", new string[]
					{
						text
					});
				}
				break;
			}
			case EChatMsgType.Attachment:
			{
				PhoneMessageAttachment? config = ConfigPhoneMessageAttachmentById.GetConfig(lastChatData.ContentNum, true);
				string a = (config != null) ? config.GetValueOrDefault().Type : null;
				if (a == "InformationView")
				{
					result = (TextConfig.Instance.GetMultiText("ChatBubble_Content_Information", Array.Empty<string>()) ?? "");
				}
				else if (a == "CoordinateTeleport")
				{
					result = (TextConfig.Instance.GetMultiText("PhoneSystem_MapCoordinates", Array.Empty<string>()) ?? "");
				}
				else
				{
					result = (TextConfig.Instance.GetMultiText("ChatBubble_Content_Attachment", Array.Empty<string>()) ?? "");
				}
				break;
			}
			default:
				if (contentType == EChatMsgType.Voice)
				{
					string value = TextConfig.Instance.GetMultiText("MessagePreview_Voice", Array.Empty<string>()) ?? "";
					double num = Math.Round((double)(lastChatData.VoiceDuration / 1000f), MidpointRounding.AwayFromZero);
					num = Math.Max(num, 1.0);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted(value);
					defaultInterpolatedStringHandler.AppendFormatted<double>(num);
					defaultInterpolatedStringHandler.AppendLiteral("″");
					result = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				break;
			}
			return result;
		}
		ValueTuple<string, string, string>? firstMsgDataByShortMsgId = PhoneMsgModel.Instance.GetFirstMsgDataByShortMsgId(displayData.ShortMsgId);
		if (firstMsgDataByShortMsgId == null)
		{
			return "";
		}
		return firstMsgDataByShortMsgId.Value.Item3;
	}

	// Token: 0x060105C6 RID: 67014 RVA: 0x004C7614 File Offset: 0x004C5814
	private UniTask LoadDurationForShowTalkAsync(ShowTalk showTalkAction)
	{
		PhoneMsgModel.<LoadDurationForShowTalkAsync>d__89 <LoadDurationForShowTalkAsync>d__;
		<LoadDurationForShowTalkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDurationForShowTalkAsync>d__.<>4__this = this;
		<LoadDurationForShowTalkAsync>d__.showTalkAction = showTalkAction;
		<LoadDurationForShowTalkAsync>d__.<>1__state = -1;
		<LoadDurationForShowTalkAsync>d__.<>t__builder.Start<PhoneMsgModel.<LoadDurationForShowTalkAsync>d__89>(ref <LoadDurationForShowTalkAsync>d__);
		return <LoadDurationForShowTalkAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060105C7 RID: 67015 RVA: 0x004C7660 File Offset: 0x004C5860
	private UniTask LoadDurationForTalkItemAsync(ITalkItem talkItem)
	{
		PhoneMsgModel.<LoadDurationForTalkItemAsync>d__90 <LoadDurationForTalkItemAsync>d__;
		<LoadDurationForTalkItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDurationForTalkItemAsync>d__.<>4__this = this;
		<LoadDurationForTalkItemAsync>d__.talkItem = talkItem;
		<LoadDurationForTalkItemAsync>d__.<>1__state = -1;
		<LoadDurationForTalkItemAsync>d__.<>t__builder.Start<PhoneMsgModel.<LoadDurationForTalkItemAsync>d__90>(ref <LoadDurationForTalkItemAsync>d__);
		return <LoadDurationForTalkItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060105C8 RID: 67016 RVA: 0x004C76AC File Offset: 0x004C58AC
	private void ProcessSetPlotMode(SetPlotMode setPlotModeAction, ShortMessageDisplayData displayData)
	{
		IPhoneMessageConfig phoneMessageConfig = setPlotModeAction.PhoneMessageConfig;
		displayData.IsJumpToFirstOption = (phoneMessageConfig != null && phoneMessageConfig.IsJumpToFirstOption.GetValueOrDefault());
	}

	// Token: 0x060105C9 RID: 67017 RVA: 0x004C76DC File Offset: 0x004C58DC
	private void ProcessShowTalk(ShowTalk showTalkAction, ShortMessage msgConfig, ShortMessageDisplayData displayData, int startTalkItemIndex = 0)
	{
		List<ITalkItem> talkItems = showTalkAction.TalkItems;
		int num = startTalkItemIndex;
		int count = talkItems.Count;
		while (num >= 0 && num < count)
		{
			num = this.ProcessTalkItem(showTalkAction, msgConfig, displayData, num);
		}
		if (!displayData.IsLastOption())
		{
			this.ProcessFinalSystemTips(msgConfig, displayData);
		}
	}

	// Token: 0x060105CA RID: 67018 RVA: 0x004C7720 File Offset: 0x004C5920
	private int ProcessTalkItem(ShowTalk showTalkAction, ShortMessage msgConfig, ShortMessageDisplayData displayData, int startTalkItemIndex = 0)
	{
		List<ITalkItem> talkItems = showTalkAction.TalkItems;
		ITalkItem talkItem = talkItems[startTalkItemIndex];
		PhoneMsgChatData phoneMsgChatData = null;
		int num = -1;
		bool flag = false;
		if (this.IsSystemTipMessage(talkItem))
		{
			phoneMsgChatData = this.CreateSystemTipChatData((ITalkItemPhoneMessage)talkItem);
		}
		else if (this.IsOption(talkItem))
		{
			if (displayData.OptionSelectedMap.ContainsKey(startTalkItemIndex))
			{
				num = this.ProcessTalkItemOptions(talkItems, startTalkItemIndex, displayData);
			}
			else
			{
				phoneMsgChatData = this.CreateSelfPhoneMsgChatData(talkItem, true);
				flag = true;
			}
		}
		else if (talkItem.WhoId.GetValueOrDefault() == 750088 || talkItem.WhoId.GetValueOrDefault() == 701052)
		{
			phoneMsgChatData = this.CreateSelfPhoneMsgChatData(talkItem, false);
		}
		else
		{
			phoneMsgChatData = this.CreateOtherPhoneMsgChatData(talkItem);
		}
		if (phoneMsgChatData != null)
		{
			displayData.ChatDataList.Add(phoneMsgChatData);
			if (phoneMsgChatData.ContentType == EChatMsgType.Voice)
			{
				phoneMsgChatData.VoiceEventHash = msgConfig.Id * 1000 + startTalkItemIndex;
				if (phoneMsgChatData.ChatContentType == EPhoneMsgContentType.Self)
				{
					this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.VoiceOnce, phoneMsgChatData.VoiceEventHash);
				}
			}
		}
		if (num >= 0)
		{
			return num;
		}
		if (flag)
		{
			return -1;
		}
		List<ActionInfo> actions = talkItem.Actions;
		if (actions != null && actions.Count > 0)
		{
			ActionInfo actionInfo = actions[0];
			EAction name = actionInfo.Name;
			if (name == EAction.FinishTalk)
			{
				return -1;
			}
			if (name == EAction.JumpTalk)
			{
				return this.ProcessJumpTalkAction(actionInfo, displayData);
			}
		}
		List<ITalkOption> options = talkItem.Options;
		if (options != null && options.Count > 0)
		{
			if (displayData.OptionSelectedMap.ContainsKey(startTalkItemIndex))
			{
				return this.ProcessTalkItemOptions(talkItems, startTalkItemIndex, displayData);
			}
			PhoneMsgChatData phoneMsgChatData2 = this.CreateSelfPhoneMsgChatData(talkItem, true);
			if (phoneMsgChatData2 != null)
			{
				displayData.ChatDataList.Add(phoneMsgChatData2);
				return -1;
			}
		}
		return startTalkItemIndex + 1;
	}

	// Token: 0x060105CB RID: 67019 RVA: 0x004C78B4 File Offset: 0x004C5AB4
	private unsafe int ProcessTalkItemOptions(List<ITalkItem> talkItems, int inTalkItemIndex, ShortMessageDisplayData displayData)
	{
		List<ITalkOption> options = talkItems[inTalkItemIndex].Options;
		if (options == null)
		{
			return inTalkItemIndex;
		}
		int num;
		if (!displayData.OptionSelectedMap.TryGetValue(inTalkItemIndex, out num))
		{
			num = -1;
		}
		if (num < 0 || num >= options.Count)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhoneSystem;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[短信剧本配置ERROR] 选项选择索引错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("短信ID", displayData.ShortMsgId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		List<ActionInfo> actions = options[num].Actions;
		if (actions == null || actions.Count == 0)
		{
			return inTalkItemIndex + 1;
		}
		ActionInfo actionInfo = actions.Find((ActionInfo action) => action.Name == EAction.JumpTalk);
		if (actionInfo != null)
		{
			return this.ProcessJumpTalkAction(actionInfo, displayData);
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(displayData.ShortMsgId);
		if (phoneMsgConfig != null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.PhoneSystem;
			ELogAuthor author2 = ELogAuthor.LZK;
			string message2 = "[短信剧本配置ERROR] 选项配置中找不到JumpTalk类型，注意！JumpTalk必须指向玩家选项所对应的完整发言，而非下一句NPC发言，否则将不显示玩家发言";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("短信ID", displayData.ShortMsgId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("剧本ID", phoneMsgConfig.Value.FlowParam()[0]);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return -1;
	}

	// Token: 0x060105CC RID: 67020 RVA: 0x004C7A08 File Offset: 0x004C5C08
	private void ProcessFinalSystemTips(ShortMessage msgConfig, ShortMessageDisplayData displayData)
	{
		PhoneMsgChatData phoneMsgChatData = this.CreateFinalSystemTips(msgConfig, displayData);
		if (phoneMsgChatData != null)
		{
			displayData.ChatDataList.Add(phoneMsgChatData);
		}
	}

	// Token: 0x060105CD RID: 67021 RVA: 0x004C7A30 File Offset: 0x004C5C30
	private int ProcessJumpTalkAction(ActionInfo action, ShortMessageDisplayData displayData)
	{
		JumpTalk jumpTalk = (JumpTalk)action.Params;
		int result;
		if (!displayData.IdToIndexMap.TryGetValue(jumpTalk.TalkId, out result))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.PhoneSystem;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[短信剧本配置ERROR] JumpTalk指向的选项Index不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("短信ID", displayData.ShortMsgId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		return result;
	}

	// Token: 0x060105CE RID: 67022 RVA: 0x004C7A98 File Offset: 0x004C5C98
	public void ProcessAfterAnswer(ShortMessageDisplayData displayData, int talkItemIndex)
	{
		if (talkItemIndex < 0)
		{
			return;
		}
		ShowTalk showTalkConfig = displayData.ShowTalkConfig;
		if (showTalkConfig == null)
		{
			return;
		}
		int count = displayData.ChatDataList.Count;
		if (count > 0)
		{
			displayData.ChatDataList.RemoveAt(count - 1);
		}
		int num = this.ProcessTalkItemOptions(showTalkConfig.TalkItems, talkItemIndex, displayData);
		if (num < 0)
		{
			return;
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(displayData.ShortMsgId);
		if (phoneMsgConfig != null)
		{
			this.ProcessShowTalk(showTalkConfig, phoneMsgConfig.Value, displayData, num);
		}
	}

	// Token: 0x060105CF RID: 67023 RVA: 0x004C7B14 File Offset: 0x004C5D14
	private bool IsSystemTipMessage(ITalkItem talkItem)
	{
		return talkItem.Type.GetValueOrDefault() == ETalkItemType.PhoneMessage && ((ITalkItemPhoneMessage)talkItem).MessageType.Type == EPhoneMessageType.SystemTip;
	}

	// Token: 0x060105D0 RID: 67024 RVA: 0x004C7B48 File Offset: 0x004C5D48
	private bool IsOption(ITalkItem talkItem)
	{
		return talkItem.Type.GetValueOrDefault() == ETalkItemType.Option || talkItem.Type.GetValueOrDefault() == ETalkItemType.SystemOption;
	}

	// Token: 0x060105D1 RID: 67025 RVA: 0x004C7B7C File Offset: 0x004C5D7C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private ValueTuple<string, string> GetSpeakerNameAndHead(int? whoId)
	{
		if (whoId == null)
		{
			return new ValueTuple<string, string>("", "");
		}
		Speaker? config = ConfigSpeakerById.GetConfig(whoId.Value, true);
		if (config == null)
		{
			return new ValueTuple<string, string>("", "");
		}
		string item = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) ?? "";
		string headIconAsset = config.Value.HeadIconAsset;
		return new ValueTuple<string, string>(item, headIconAsset);
	}

	// Token: 0x060105D2 RID: 67026 RVA: 0x004C7C08 File Offset: 0x004C5E08
	private void FillChatDataContent(PhoneMsgChatData chatData, ITalkItem talkItem, bool bOption = false)
	{
		if (bOption)
		{
			this.FillOptionChatData(chatData, talkItem);
			return;
		}
		ETalkItemType value = talkItem.Type.Value;
		if (value == ETalkItemType.Talk)
		{
			this.FillTalkChatData(chatData, talkItem);
			ITalkItemDialog talkItemDialog = (ITalkItemDialog)talkItem;
			chatData.SetScrollWaitTime((int)talkItemDialog.OtherIsTypingDuration.GetValueOrDefault());
			return;
		}
		if (value != ETalkItemType.PhoneMessage)
		{
			return;
		}
		this.FillPhoneMessageChatData(chatData, talkItem);
		ITalkItemPhoneMessage talkItemPhoneMessage = (ITalkItemPhoneMessage)talkItem;
		chatData.SetScrollWaitTime((int)talkItemPhoneMessage.OtherIsTypingDuration.GetValueOrDefault());
	}

	// Token: 0x060105D3 RID: 67027 RVA: 0x004C7C84 File Offset: 0x004C5E84
	private void FillOptionChatData(PhoneMsgChatData chatData, ITalkItem talkItem)
	{
		List<ITalkOption> options = talkItem.Options;
		if (options == null || options.Count == 0)
		{
			global::Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[短信剧本配置ERROR] 选项配置中找不到选项", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		ITalkOption talkOption = options[0];
		EChatMsgType? echatMsgType = null;
		if (talkOption.TypeParams == null)
		{
			echatMsgType = new EChatMsgType?(EChatMsgType.TextOption);
		}
		else
		{
			if (talkOption.TypeParams.Type != ETalkOptionParamType.PhoneMessageEmoji)
			{
				global::Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[短信剧本配置ERROR] 选项配置中找不到选项类型", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			echatMsgType = new EChatMsgType?(EChatMsgType.EmojiOption);
		}
		chatData.ContentType = echatMsgType.Value;
	}

	// Token: 0x060105D4 RID: 67028 RVA: 0x004C7D2C File Offset: 0x004C5F2C
	private void FillTalkChatData(PhoneMsgChatData chatData, ITalkItem talkItem)
	{
		ITalkItemDialog talkItemDialog = (ITalkItemDialog)talkItem;
		chatData.IsSendError = (talkItemDialog.Style != null && talkItemDialog.Style.Type == ETalkItemStyle.PhoneSendError);
		chatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkItemDialog.TidTalk) ?? "");
		this.SetDialogChatData(chatData, talkItemDialog);
	}

	// Token: 0x060105D5 RID: 67029 RVA: 0x004C7D88 File Offset: 0x004C5F88
	private void FillPhoneMessageChatData(PhoneMsgChatData chatData, ITalkItem talkItem)
	{
		ITalkItemPhoneMessage talkItemPhoneMessage = (ITalkItemPhoneMessage)talkItem;
		chatData.IsSendError = (talkItemPhoneMessage.Style != null && talkItemPhoneMessage.Style.Type == ETalkItemStyle.PhoneSendError);
		switch (talkItemPhoneMessage.MessageType.Type)
		{
		case EPhoneMessageType.Voice:
			this.SetVoiceChatData(chatData, talkItemPhoneMessage);
			return;
		case EPhoneMessageType.Emoji:
			this.SetEmojiChatData(chatData, talkItemPhoneMessage);
			return;
		case EPhoneMessageType.Attachment:
			this.SetAttachmentChatData(chatData, talkItemPhoneMessage);
			return;
		default:
			return;
		}
	}

	// Token: 0x060105D6 RID: 67030 RVA: 0x004C7DF4 File Offset: 0x004C5FF4
	public PhoneMsgChatData CreateOtherPhoneMsgChatData(ITalkItem talkItem)
	{
		PhoneMsgChatData phoneMsgChatData = new PhoneMsgChatData(EPhoneMsgContentType.Other);
		phoneMsgChatData.TalkItem = talkItem;
		ValueTuple<string, string> speakerNameAndHead = this.GetSpeakerNameAndHead(talkItem.WhoId);
		phoneMsgChatData.SpeakerName = speakerNameAndHead.Item1;
		phoneMsgChatData.SpeakerHeadIconPath = speakerNameAndHead.Item2;
		this.FillChatDataContent(phoneMsgChatData, talkItem, false);
		return phoneMsgChatData;
	}

	// Token: 0x060105D7 RID: 67031 RVA: 0x004C7E40 File Offset: 0x004C6040
	[return: Nullable(2)]
	public PhoneMsgChatData CreateSelfPhoneMsgChatData(ITalkItem talkItem, bool bOption = false)
	{
		PhoneMsgChatData phoneMsgChatData = new PhoneMsgChatData(EPhoneMsgContentType.Self);
		phoneMsgChatData.TalkItem = talkItem;
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		if (curSelectMainRoleId == null)
		{
			return null;
		}
		int roleSkinIdByRoleId = RoleSkinModel.Instance.GetRoleSkinIdByRoleId(curSelectMainRoleId.Value);
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(roleSkinIdByRoleId);
		if (roleSkinConfig != null)
		{
			phoneMsgChatData.SpeakerHeadIconPath = roleSkinConfig.Value.RoleHeadIconCircle;
		}
		phoneMsgChatData.SpeakerName = (FunctionModel.Instance.GetPlayerName() ?? "");
		this.FillChatDataContent(phoneMsgChatData, talkItem, bOption);
		return phoneMsgChatData;
	}

	// Token: 0x060105D8 RID: 67032 RVA: 0x004C7ED4 File Offset: 0x004C60D4
	[return: Nullable(2)]
	public PhoneMsgChatData CreateSystemTipChatData(ITalkItemPhoneMessage talkMsgItem)
	{
		if (talkMsgItem.MessageType.Type != EPhoneMessageType.SystemTip)
		{
			return null;
		}
		PhoneMsgChatData phoneMsgChatData = new PhoneMsgChatData(EPhoneMsgContentType.Tips);
		phoneMsgChatData.TalkItem = talkMsgItem;
		phoneMsgChatData.ContentType = EChatMsgType.Tips;
		if (talkMsgItem.TidTalk != null)
		{
			phoneMsgChatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkMsgItem.TidTalk) ?? "");
		}
		return phoneMsgChatData;
	}

	// Token: 0x060105D9 RID: 67033 RVA: 0x004C7F2E File Offset: 0x004C612E
	public void SetDialogChatData(PhoneMsgChatData targetChatData, ITalkItemDialog talkItem)
	{
		targetChatData.ContentType = EChatMsgType.Text;
		if (talkItem.TidTalk != null)
		{
			targetChatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkItem.TidTalk) ?? "");
		}
	}

	// Token: 0x060105DA RID: 67034 RVA: 0x004C7F60 File Offset: 0x004C6160
	public void SetEmojiChatData(PhoneMsgChatData targetChatData, ITalkItemPhoneMessage talkMsgItem)
	{
		if (talkMsgItem.MessageType.Type != EPhoneMessageType.Emoji)
		{
			return;
		}
		ITalkItemPhoneMessageEmoji talkItemPhoneMessageEmoji = (ITalkItemPhoneMessageEmoji)talkMsgItem.MessageType;
		targetChatData.ContentType = EChatMsgType.Emoji;
		targetChatData.ContentNum = talkItemPhoneMessageEmoji.EmojiId;
	}

	// Token: 0x060105DB RID: 67035 RVA: 0x004C7F9C File Offset: 0x004C619C
	public void SetAttachmentChatData(PhoneMsgChatData targetChatData, ITalkItemPhoneMessage talkMsgItem)
	{
		if (talkMsgItem.MessageType.Type != EPhoneMessageType.Attachment)
		{
			return;
		}
		ITalkItemPhoneMessageAttachment talkItemPhoneMessageAttachment = (ITalkItemPhoneMessageAttachment)talkMsgItem.MessageType;
		targetChatData.ContentType = EChatMsgType.Attachment;
		targetChatData.ContentNum = talkItemPhoneMessageAttachment.AttachmentId;
	}

	// Token: 0x060105DC RID: 67036 RVA: 0x004C7FD8 File Offset: 0x004C61D8
	public void SetVoiceChatData(PhoneMsgChatData targetChatData, ITalkItemPhoneMessage talkMsgItem)
	{
		if (talkMsgItem.MessageType.Type != EPhoneMessageType.Voice)
		{
			return;
		}
		ITalkItemPhoneMessageVoice talkItemPhoneMessageVoice = (ITalkItemPhoneMessageVoice)talkMsgItem.MessageType;
		targetChatData.ContentType = EChatMsgType.Voice;
		targetChatData.TalkItem = talkMsgItem;
		float voiceDuration;
		if (this.AudioDurationMap.TryGetValue(talkMsgItem.Id, out voiceDuration))
		{
			targetChatData.VoiceDuration = voiceDuration;
		}
		targetChatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkMsgItem.TidTalk) ?? "");
		targetChatData.PushCondition = talkItemPhoneMessageVoice.PushCondition;
		targetChatData.IsAutoPlay = talkItemPhoneMessageVoice.AutoPlay.GetValueOrDefault();
	}

	// Token: 0x060105DD RID: 67037 RVA: 0x004C806C File Offset: 0x004C626C
	[return: Nullable(2)]
	private PhoneMsgChatData CreateFinalSystemTips(ShortMessage msgConfig, ShortMessageDisplayData displayData)
	{
		if (msgConfig.FinallPopType == 0)
		{
			return null;
		}
		PhoneMsgChatData phoneMsgChatData = new PhoneMsgChatData(EPhoneMsgContentType.Tips);
		switch (msgConfig.FinallPopType)
		{
		case 4:
			phoneMsgChatData.ContentType = EChatMsgType.Task;
			phoneMsgChatData.QuestId = msgConfig.QuestId;
			break;
		case 5:
		{
			phoneMsgChatData.ContentType = EChatMsgType.Birthday;
			BirthDay? config = ConfigBirthDayByMsgId.GetConfig(msgConfig.Id, true);
			phoneMsgChatData.BirthdayCardItemId = ((config != null) ? config.Value.BirthDayCardItemId : 0);
			break;
		}
		case 6:
			phoneMsgChatData.ContentType = EChatMsgType.Reward;
			phoneMsgChatData.DropId = msgConfig.DropId;
			phoneMsgChatData.IsFinish = displayData.IsReceivedReward;
			break;
		case 11:
			phoneMsgChatData.ContentType = EChatMsgType.Activity;
			phoneMsgChatData.ActivityId = msgConfig.ActivityId;
			break;
		case 12:
			phoneMsgChatData.ContentType = EChatMsgType.ActivityMainView;
			phoneMsgChatData.ActivityId = msgConfig.ActivityId;
			break;
		}
		int whichChat = msgConfig.WhichChat;
		ChatPartner? chatPartnerConfigNew = this.GetChatPartnerConfigNew(whichChat);
		phoneMsgChatData.IsGroupChat = (chatPartnerConfigNew != null && chatPartnerConfigNew.Value.IsGroupChat);
		phoneMsgChatData.ShortMessageId = msgConfig.Id;
		phoneMsgChatData.ChatPartnerId = msgConfig.WhichChat;
		PhoneMsgShortMsgData phoneMsgShortMsgData;
		if (this.Id2ShortMessagesDict.TryGetValue(msgConfig.Id, out phoneMsgShortMsgData) && phoneMsgShortMsgData != null)
		{
			phoneMsgChatData.UnLockTime = phoneMsgShortMsgData.UnLockTime;
		}
		else
		{
			phoneMsgChatData.UnLockTime = 0L;
		}
		return phoneMsgChatData;
	}

	// Token: 0x060105DE RID: 67038 RVA: 0x004C81E3 File Offset: 0x004C63E3
	public int CoverServerProgressToReadIndex(int progress)
	{
		return progress - 1;
	}

	// Token: 0x060105DF RID: 67039 RVA: 0x004C81E8 File Offset: 0x004C63E8
	public int CoverReadIndexToServerProgress(int readIndex)
	{
		return readIndex + 1;
	}

	// Token: 0x060105E0 RID: 67040 RVA: 0x004C81F0 File Offset: 0x004C63F0
	public string GetEmojiTexturePathByEmojiId(int emojiId)
	{
		ChatExpression? expressionConfig = ChatConfig.Instance.GetExpressionConfig(emojiId);
		if (expressionConfig == null)
		{
			global::Log.Instance.Error(ELogModule.PhoneSystem, ELogAuthor.LZK, "[短信表情包配置ERROR] 表情包配置中不存在对应Id" + emojiId.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return "";
		}
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
		if (!string.IsNullOrEmpty(expressionConfig.Value.MaleVariant) && flag)
		{
			return expressionConfig.Value.MaleVariant;
		}
		return expressionConfig.Value.ExpressionTexturePath ?? "";
	}

	// Token: 0x060105E1 RID: 67041 RVA: 0x004C8294 File Offset: 0x004C6494
	public bool IsChatShowHasRedDotById(int id)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.Decoration, out hashSet) && hashSet.Contains(id);
	}

	// Token: 0x060105E2 RID: 67042 RVA: 0x004C82C2 File Offset: 0x004C64C2
	public bool IsChatShowHasRedDot()
	{
		return this.HasRedDotByType(EPhoneMsgServerRedDotType.Decoration);
	}

	// Token: 0x060105E3 RID: 67043 RVA: 0x004C82CC File Offset: 0x004C64CC
	private bool HasRedDotByType(EPhoneMsgServerRedDotType type)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(type, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x060105E4 RID: 67044 RVA: 0x004C82FC File Offset: 0x004C64FC
	public void RemoveChatShowRedDotById(int id)
	{
		this.RemovePhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id);
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate);
	}

	// Token: 0x060105E5 RID: 67045 RVA: 0x004C8318 File Offset: 0x004C6518
	public void SetLastOpenBigPanelTime(double time)
	{
		long num = (long)(time / 1000.0);
		if (num > this.LastOpenBigPanelTime)
		{
			this.LastOpenBigPanelTime = num;
			ServerStorageLong lastOpenBigPanelTimeStorage = this.LastOpenBigPanelTimeStorage;
			if (lastOpenBigPanelTimeStorage == null)
			{
				return;
			}
			lastOpenBigPanelTimeStorage.Set(new long?(num));
		}
	}

	// Token: 0x060105E6 RID: 67046 RVA: 0x004C8358 File Offset: 0x004C6558
	public void SetLatestShortMsgTime(long time)
	{
		if (time > this.LatestShortMsgTime)
		{
			this.LatestShortMsgTime = time;
		}
	}

	// Token: 0x060105E7 RID: 67047 RVA: 0x004C836A File Offset: 0x004C656A
	public bool IsHasPhoneMsgUnReview()
	{
		return this.LatestShortMsgTime > this.LastOpenBigPanelTime;
	}

	// Token: 0x060105E8 RID: 67048 RVA: 0x004C837A File Offset: 0x004C657A
	public ChatPartner? GetChatPartnerConfigNew(int partnerId)
	{
		return PhoneMsgConfig.Instance.GetChatPartnerConfig(partnerId);
	}

	// Token: 0x1700190A RID: 6410
	// (get) Token: 0x060105E9 RID: 67049 RVA: 0x004C8387 File Offset: 0x004C6587
	public static PhoneMsgModel Instance
	{
		get
		{
			return PhoneMsgModel._Instance;
		}
	}

	// Token: 0x060105EA RID: 67050 RVA: 0x004C838E File Offset: 0x004C658E
	public static PhoneMsgModel GetOrCreateInstance()
	{
		if (PhoneMsgModel._Instance == null)
		{
			PhoneMsgModel.CreateInstance();
		}
		return PhoneMsgModel._Instance;
	}

	// Token: 0x060105EB RID: 67051 RVA: 0x004C83A2 File Offset: 0x004C65A2
	public static bool CreateInstance()
	{
		if (PhoneMsgModel._Instance != null)
		{
			return true;
		}
		PhoneMsgModel._Instance = new PhoneMsgModel();
		return true;
	}

	// Token: 0x060105EC RID: 67052 RVA: 0x004C83B8 File Offset: 0x004C65B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060105ED RID: 67053 RVA: 0x004C83BA File Offset: 0x004C65BA
	public static void ResetStaticDefaultValue()
	{
		PhoneMsgModel._Instance = null;
	}

	// Token: 0x060105EE RID: 67054 RVA: 0x004C83C2 File Offset: 0x004C65C2
	static PhoneMsgModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgModel.CreateStaticDefaultValue), new Action(PhoneMsgModel.ResetStaticDefaultValue));
	}

	// Token: 0x040090C0 RID: 37056
	public HashSet<EDungeonSubType> NormalDungeonSet = new HashSet<EDungeonSubType>();

	// Token: 0x040090C1 RID: 37057
	public bool IsPhoneChatShowInitDone;

	// Token: 0x040090C2 RID: 37058
	public int CurrentUsingChatDialogId;

	// Token: 0x040090C3 RID: 37059
	public int CurrentUsingChatBgId;

	// Token: 0x040090C4 RID: 37060
	public int CurrentUsingChatThemeId;

	// Token: 0x040090C5 RID: 37061
	public int CurrentUsingChatCharmId;

	// Token: 0x040090C6 RID: 37062
	private string EmptyTexturePath = "";

	// Token: 0x040090C7 RID: 37063
	private readonly HashSet<int> UnlockedDialogIds = new HashSet<int>();

	// Token: 0x040090C8 RID: 37064
	private readonly HashSet<int> UnlockedBgIds = new HashSet<int>();

	// Token: 0x040090C9 RID: 37065
	private readonly HashSet<int> UnlockedThemeIds = new HashSet<int>();

	// Token: 0x040090CA RID: 37066
	private readonly HashSet<int> UnlockedCharmIds = new HashSet<int>();

	// Token: 0x040090CB RID: 37067
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EPhoneMsgServerRedDotType, HashSet<int>> LocalRedDotCache;

	// Token: 0x040090CC RID: 37068
	[Nullable(2)]
	private ServerStorageSet ServerRedDotSet;

	// Token: 0x040090CD RID: 37069
	public List<int> CurrentToBeNotifiedMsgArray = new List<int>();

	// Token: 0x040090CE RID: 37070
	public List<int> CurrentToBeNotifiedMsgInSmallHeadQueue = new List<int>();

	// Token: 0x040090CF RID: 37071
	public int CurrentShowingMsgIdInSmallHead;

	// Token: 0x040090D0 RID: 37072
	public List<PhoneMsgInputTimeData> MsgInputTimeList = new List<PhoneMsgInputTimeData>();

	// Token: 0x040090D1 RID: 37073
	private readonly Dictionary<int, float> AudioDurationMap = new Dictionary<int, float>();

	// Token: 0x040090D2 RID: 37074
	private Dictionary<int, HashSet<int>> AllFilterTypeSetDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x040090D3 RID: 37075
	private Dictionary<int, HashSet<int>> SelectedFilterSetDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x040090D4 RID: 37076
	private HashSet<int> SelectedFilterIdSet_Internal = new HashSet<int>();

	// Token: 0x040090D5 RID: 37077
	public List<int> ChatPartnerIdList = new List<int>();

	// Token: 0x040090D6 RID: 37078
	public Dictionary<int, List<int>> ChatPartnerId2ShortMessagesIdsDict = new Dictionary<int, List<int>>();

	// Token: 0x040090D7 RID: 37079
	public Dictionary<int, PhoneMsgShortMsgData> Id2ShortMessagesDict = new Dictionary<int, PhoneMsgShortMsgData>();

	// Token: 0x040090D8 RID: 37080
	[Nullable(2)]
	private List<int> UnreceivedPartnerList;

	// Token: 0x040090D9 RID: 37081
	[Nullable(2)]
	private List<int> ReceivedUnreadPartnerList;

	// Token: 0x040090DA RID: 37082
	[Nullable(2)]
	private List<int> ReceivedReadPartnerList;

	// Token: 0x040090DB RID: 37083
	private long LastOpenBigPanelTime;

	// Token: 0x040090DC RID: 37084
	[Nullable(2)]
	private ServerStorageLong LastOpenBigPanelTimeStorage;

	// Token: 0x040090DD RID: 37085
	private long LatestShortMsgTime;

	// Token: 0x040090DE RID: 37086
	[Nullable(2)]
	private static PhoneMsgModel _Instance;
}
