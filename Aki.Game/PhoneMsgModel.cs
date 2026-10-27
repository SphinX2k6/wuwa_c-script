using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002503 RID: 9475
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PhoneMsgModel : ModelBase
{
	// Token: 0x060130CE RID: 78030 RVA: 0x004B7950 File Offset: 0x004B5B50
	public string GetEmptyTexturePath()
	{
		if (string.IsNullOrEmpty(this.EmptyTexturePath))
		{
			this.EmptyTexturePath = UiResourceConfig.Instance.GetResourcePath("T_CommonNone_UI");
		}
		return this.EmptyTexturePath;
	}

	// Token: 0x170018CE RID: 6350
	// (get) Token: 0x060130CF RID: 78031 RVA: 0x004B797A File Offset: 0x004B5B7A
	public bool IsUsingDefaultChatBg
	{
		get
		{
			return this.IsDefaultChatBg(this.CurrentUsingChatBgId);
		}
	}

	// Token: 0x170018CF RID: 6351
	// (get) Token: 0x060130D0 RID: 78032 RVA: 0x004B7988 File Offset: 0x004B5B88
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

	// Token: 0x060130D1 RID: 78033 RVA: 0x004B7A1C File Offset: 0x004B5C1C
	public bool IsDefaultTheme(int id)
	{
		return id == 80891001;
	}

	// Token: 0x060130D2 RID: 78034 RVA: 0x004B7A28 File Offset: 0x004B5C28
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

	// Token: 0x060130D3 RID: 78035 RVA: 0x004B7B6C File Offset: 0x004B5D6C
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

	// Token: 0x060130D4 RID: 78036 RVA: 0x004B7CC0 File Offset: 0x004B5EC0
	public void ClearSelectedFilterIdSet()
	{
		foreach (HashSet<int> hashSet in this.SelectedFilterSetDict.Values)
		{
			hashSet.Clear();
		}
		this.SelectedFilterIdSet_Internal.Clear();
		EventSystem.Instance.Emit(EEventName.OnPhoneMsgFilterChanged);
	}

	// Token: 0x060130D5 RID: 78037 RVA: 0x004B7D30 File Offset: 0x004B5F30
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

	// Token: 0x060130D6 RID: 78038 RVA: 0x004B7D50 File Offset: 0x004B5F50
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

	// Token: 0x060130D7 RID: 78039 RVA: 0x004B7E00 File Offset: 0x004B6000
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

	// Token: 0x060130D8 RID: 78040 RVA: 0x004B7E44 File Offset: 0x004B6044
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

	// Token: 0x060130D9 RID: 78041 RVA: 0x004B7F40 File Offset: 0x004B6140
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

	// Token: 0x060130DA RID: 78042 RVA: 0x004B7FF8 File Offset: 0x004B61F8
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

	// Token: 0x060130DB RID: 78043 RVA: 0x004B8050 File Offset: 0x004B6250
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

	// Token: 0x060130DC RID: 78044 RVA: 0x004B8148 File Offset: 0x004B6348
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

	// Token: 0x060130DD RID: 78045 RVA: 0x004B82A0 File Offset: 0x004B64A0
	private int EncodePhoneMsgRedDot(EPhoneMsgServerRedDotType type, int id)
	{
		return (int)(id * 10 + type);
	}

	// Token: 0x060130DE RID: 78046 RVA: 0x004B82A8 File Offset: 0x004B64A8
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

	// Token: 0x060130DF RID: 78047 RVA: 0x004B8314 File Offset: 0x004B6514
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

	// Token: 0x060130E0 RID: 78048 RVA: 0x004B835C File Offset: 0x004B655C
	public void AddVoiceRedDot(int id)
	{
		this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.VoiceOnce, id);
	}

	// Token: 0x060130E1 RID: 78049 RVA: 0x004B8368 File Offset: 0x004B6568
	public bool TryGetVoiceRedDot(int id)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.VoiceOnce, out hashSet) && hashSet.Contains(id);
	}

	// Token: 0x060130E2 RID: 78050 RVA: 0x004B8398 File Offset: 0x004B6598
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

	// Token: 0x060130E3 RID: 78051 RVA: 0x004B8474 File Offset: 0x004B6674
	public void SetUnLockChatDialogIds(List<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedDialogIds.Add(item);
		}
	}

	// Token: 0x060130E4 RID: 78052 RVA: 0x004B84C8 File Offset: 0x004B66C8
	public void SetUnLockChatBgIds(List<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedBgIds.Add(item);
		}
	}

	// Token: 0x060130E5 RID: 78053 RVA: 0x004B851C File Offset: 0x004B671C
	public void SetUnLockChatThemeIds(List<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedThemeIds.Add(item);
		}
	}

	// Token: 0x060130E6 RID: 78054 RVA: 0x004B8570 File Offset: 0x004B6770
	public void SetUnLockChatCharmIds(List<int> unLockIds)
	{
		foreach (int item in unLockIds)
		{
			this.UnlockedCharmIds.Add(item);
		}
	}

	// Token: 0x060130E7 RID: 78055 RVA: 0x004B85C4 File Offset: 0x004B67C4
	public void OnPhoneMsgDialogAndBgAddNotify(ShortMessageItemUpdateNotify message)
	{
		RepeatedField<int> bubbleIds = message.BubbleIds;
		if (bubbleIds != null && bubbleIds.Count > 0)
		{
			this.SetUnLockChatDialogIds(bubbleIds.ToList<int>());
			foreach (int id in bubbleIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id);
			}
		}
		RepeatedField<int> chatBgIds = message.ChatBgIds;
		if (chatBgIds != null && chatBgIds.Count > 0)
		{
			this.SetUnLockChatBgIds(chatBgIds.ToList<int>());
			foreach (int id2 in chatBgIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id2);
			}
		}
		RepeatedField<int> chatThemeIds = message.ChatThemeIds;
		if (chatThemeIds != null && chatThemeIds.Count > 0)
		{
			this.SetUnLockChatThemeIds(chatThemeIds.ToList<int>());
			foreach (int id3 in chatThemeIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id3);
			}
		}
		RepeatedField<int> chatCharmIds = message.ChatCharmIds;
		if (chatCharmIds != null && chatCharmIds.Count > 0)
		{
			this.SetUnLockChatCharmIds(chatCharmIds.ToList<int>());
			foreach (int id4 in chatCharmIds)
			{
				this.AddPhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id4);
			}
		}
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmUpdate);
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate);
	}

	// Token: 0x060130E8 RID: 78056 RVA: 0x004B8770 File Offset: 0x004B6970
	public bool IsChatDialogUnlocked(int dialogId)
	{
		return this.UnlockedDialogIds.Contains(dialogId);
	}

	// Token: 0x060130E9 RID: 78057 RVA: 0x004B877E File Offset: 0x004B697E
	public bool IsChatBgUnlocked(int bgId)
	{
		return this.UnlockedBgIds.Contains(bgId);
	}

	// Token: 0x060130EA RID: 78058 RVA: 0x004B878C File Offset: 0x004B698C
	public bool IsChatThemeUnlocked(int themeId)
	{
		return this.UnlockedThemeIds.Contains(themeId);
	}

	// Token: 0x060130EB RID: 78059 RVA: 0x004B879A File Offset: 0x004B699A
	public bool IsChatCharmUnlocked(int charmId)
	{
		return this.UnlockedCharmIds.Contains(charmId);
	}

	// Token: 0x060130EC RID: 78060 RVA: 0x004B87A8 File Offset: 0x004B69A8
	public bool IsDefaultChatBg(int id)
	{
		return id == 80820001;
	}

	// Token: 0x060130ED RID: 78061 RVA: 0x004B87B4 File Offset: 0x004B69B4
	public void OnPhoneMsgUpdateNotify(ShortMessageUpdateNotify message)
	{
		ChangeReason reason = message.Reason;
		this.AddMessages(message.Adds.ToList<ShortMessageInfo>(), new ChangeReason?(reason), true, true);
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

	// Token: 0x060130EE RID: 78062 RVA: 0x004B88E4 File Offset: 0x004B6AE4
	public void AddMessages(List<ShortMessageInfo> dataList, ChangeReason? reason = null, bool isNeedShowTips = true, bool isNeedSetLatestShortMsgTime = true)
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

	// Token: 0x060130EF RID: 78063 RVA: 0x004B8B7C File Offset: 0x004B6D7C
	public void SortChatPartnerAndMessages()
	{
		this.SortAllMessages();
		this.SortChatPartnerList();
	}

	// Token: 0x060130F0 RID: 78064 RVA: 0x004B8B8C File Offset: 0x004B6D8C
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

	// Token: 0x060130F1 RID: 78065 RVA: 0x004B8D4C File Offset: 0x004B6F4C
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

	// Token: 0x060130F2 RID: 78066 RVA: 0x004B8E74 File Offset: 0x004B7074
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

	// Token: 0x060130F3 RID: 78067 RVA: 0x004B8EB0 File Offset: 0x004B70B0
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

	// Token: 0x060130F4 RID: 78068 RVA: 0x004B8F18 File Offset: 0x004B7118
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

	// Token: 0x060130F5 RID: 78069 RVA: 0x004B8F93 File Offset: 0x004B7193
	public List<int> GetAllChatPartnerIds()
	{
		return this.ChatPartnerIdList;
	}

	// Token: 0x060130F6 RID: 78070 RVA: 0x004B8F9C File Offset: 0x004B719C
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

	// Token: 0x060130F7 RID: 78071 RVA: 0x004B900C File Offset: 0x004B720C
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

	// Token: 0x060130F8 RID: 78072 RVA: 0x004B902C File Offset: 0x004B722C
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
										item2 = (TextConfig.Instance.GetMultiText("ChatBubble_Content_Attachment", Array.Empty<string>()) ?? "");
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

	// Token: 0x060130F9 RID: 78073 RVA: 0x004B92F0 File Offset: 0x004B74F0
	public bool IsShortMsgRead(int shortMsgId)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		return phoneMsgShortMsgDataByShortMsgId != null && phoneMsgShortMsgDataByShortMsgId.IsRead;
	}

	// Token: 0x060130FA RID: 78074 RVA: 0x004B9310 File Offset: 0x004B7510
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

	// Token: 0x060130FB RID: 78075 RVA: 0x004B9350 File Offset: 0x004B7550
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

	// Token: 0x060130FC RID: 78076 RVA: 0x004B93C0 File Offset: 0x004B75C0
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

	// Token: 0x060130FD RID: 78077 RVA: 0x004B9424 File Offset: 0x004B7624
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

	// Token: 0x060130FE RID: 78078 RVA: 0x004B94B8 File Offset: 0x004B76B8
	public bool IsPhoneMsgUnlock(int shortMsgId)
	{
		return this.Id2ShortMessagesDict.ContainsKey(shortMsgId);
	}

	// Token: 0x060130FF RID: 78079 RVA: 0x004B94C8 File Offset: 0x004B76C8
	public void SetShortMsgOptionData(int shortMsgId, int chatIndex, int optIndex)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		if (phoneMsgShortMsgDataByShortMsgId != null)
		{
			phoneMsgShortMsgDataByShortMsgId.SelectedOptionsDict[chatIndex] = optIndex;
			EventSystem.Instance.Emit<int>(EEventName.OnUpdateShortMsgOptionData, shortMsgId);
		}
	}

	// Token: 0x06013100 RID: 78080 RVA: 0x004B9500 File Offset: 0x004B7700
	public bool GetShortMsgHasAnySelectedOption(int shortMsgId)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		return phoneMsgShortMsgDataByShortMsgId != null && phoneMsgShortMsgDataByShortMsgId.SelectedOptionsDict.Count > 0;
	}

	// Token: 0x06013101 RID: 78081 RVA: 0x004B9528 File Offset: 0x004B7728
	public void SetShortMsgRewardData(int shortMsgId, bool isReceived)
	{
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = this.GetPhoneMsgShortMsgDataByShortMsgId(shortMsgId);
		if (phoneMsgShortMsgDataByShortMsgId != null)
		{
			phoneMsgShortMsgDataByShortMsgId.IsReceived = isReceived;
		}
	}

	// Token: 0x06013102 RID: 78082 RVA: 0x004B9548 File Offset: 0x004B7748
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

	// Token: 0x06013103 RID: 78083 RVA: 0x004B9594 File Offset: 0x004B7794
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

	// Token: 0x06013104 RID: 78084 RVA: 0x004B95E0 File Offset: 0x004B77E0
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

	// Token: 0x06013105 RID: 78085 RVA: 0x004B9634 File Offset: 0x004B7834
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

	// Token: 0x06013106 RID: 78086 RVA: 0x004B9740 File Offset: 0x004B7940
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
				result = ((((config != null) ? config.GetValueOrDefault().Type : null) == "InformationView") ? (TextConfig.Instance.GetMultiText("ChatBubble_Content_Information", Array.Empty<string>()) ?? "") : (TextConfig.Instance.GetMultiText("ChatBubble_Content_Attachment", Array.Empty<string>()) ?? ""));
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

	// Token: 0x06013107 RID: 78087 RVA: 0x004B9910 File Offset: 0x004B7B10
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

	// Token: 0x06013108 RID: 78088 RVA: 0x004B995C File Offset: 0x004B7B5C
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

	// Token: 0x06013109 RID: 78089 RVA: 0x004B99A8 File Offset: 0x004B7BA8
	private void ProcessSetPlotMode(SetPlotMode setPlotModeAction, ShortMessageDisplayData displayData)
	{
		IPhoneMessageConfig phoneMessageConfig = setPlotModeAction.PhoneMessageConfig;
		displayData.IsJumpToFirstOption = (phoneMessageConfig != null && phoneMessageConfig.IsJumpToFirstOption.GetValueOrDefault());
	}

	// Token: 0x0601310A RID: 78090 RVA: 0x004B99D8 File Offset: 0x004B7BD8
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

	// Token: 0x0601310B RID: 78091 RVA: 0x004B9A1C File Offset: 0x004B7C1C
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

	// Token: 0x0601310C RID: 78092 RVA: 0x004B9BB0 File Offset: 0x004B7DB0
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

	// Token: 0x0601310D RID: 78093 RVA: 0x004B9D04 File Offset: 0x004B7F04
	private void ProcessFinalSystemTips(ShortMessage msgConfig, ShortMessageDisplayData displayData)
	{
		PhoneMsgChatData phoneMsgChatData = this.CreateFinalSystemTips(msgConfig, displayData);
		if (phoneMsgChatData != null)
		{
			displayData.ChatDataList.Add(phoneMsgChatData);
		}
	}

	// Token: 0x0601310E RID: 78094 RVA: 0x004B9D2C File Offset: 0x004B7F2C
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

	// Token: 0x0601310F RID: 78095 RVA: 0x004B9D94 File Offset: 0x004B7F94
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

	// Token: 0x06013110 RID: 78096 RVA: 0x004B9E10 File Offset: 0x004B8010
	private bool IsSystemTipMessage(ITalkItem talkItem)
	{
		return talkItem.Type.GetValueOrDefault() == ETalkItemType.PhoneMessage && ((ITalkItemPhoneMessage)talkItem).MessageType.Type == EPhoneMessageType.SystemTip;
	}

	// Token: 0x06013111 RID: 78097 RVA: 0x004B9E44 File Offset: 0x004B8044
	private bool IsOption(ITalkItem talkItem)
	{
		return talkItem.Type.GetValueOrDefault() == ETalkItemType.Option || talkItem.Type.GetValueOrDefault() == ETalkItemType.SystemOption;
	}

	// Token: 0x06013112 RID: 78098 RVA: 0x004B9E78 File Offset: 0x004B8078
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

	// Token: 0x06013113 RID: 78099 RVA: 0x004B9F04 File Offset: 0x004B8104
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

	// Token: 0x06013114 RID: 78100 RVA: 0x004B9F80 File Offset: 0x004B8180
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

	// Token: 0x06013115 RID: 78101 RVA: 0x004BA028 File Offset: 0x004B8228
	private void FillTalkChatData(PhoneMsgChatData chatData, ITalkItem talkItem)
	{
		ITalkItemDialog talkItemDialog = (ITalkItemDialog)talkItem;
		chatData.IsSendError = (talkItemDialog.Style != null && talkItemDialog.Style.Type == ETalkItemStyle.PhoneSendError);
		chatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkItemDialog.TidTalk) ?? "");
		this.SetDialogChatData(chatData, talkItemDialog);
	}

	// Token: 0x06013116 RID: 78102 RVA: 0x004BA084 File Offset: 0x004B8284
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

	// Token: 0x06013117 RID: 78103 RVA: 0x004BA0F0 File Offset: 0x004B82F0
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

	// Token: 0x06013118 RID: 78104 RVA: 0x004BA13C File Offset: 0x004B833C
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

	// Token: 0x06013119 RID: 78105 RVA: 0x004BA1D0 File Offset: 0x004B83D0
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

	// Token: 0x0601311A RID: 78106 RVA: 0x004BA22A File Offset: 0x004B842A
	public void SetDialogChatData(PhoneMsgChatData targetChatData, ITalkItemDialog talkItem)
	{
		targetChatData.ContentType = EChatMsgType.Text;
		if (talkItem.TidTalk != null)
		{
			targetChatData.ContentStr = (PublicUtil.Instance.GetFlowConfigLocalText(talkItem.TidTalk) ?? "");
		}
	}

	// Token: 0x0601311B RID: 78107 RVA: 0x004BA25C File Offset: 0x004B845C
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

	// Token: 0x0601311C RID: 78108 RVA: 0x004BA298 File Offset: 0x004B8498
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

	// Token: 0x0601311D RID: 78109 RVA: 0x004BA2D4 File Offset: 0x004B84D4
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

	// Token: 0x0601311E RID: 78110 RVA: 0x004BA368 File Offset: 0x004B8568
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

	// Token: 0x0601311F RID: 78111 RVA: 0x004BA493 File Offset: 0x004B8693
	public int CoverServerProgressToReadIndex(int progress)
	{
		return progress - 1;
	}

	// Token: 0x06013120 RID: 78112 RVA: 0x004BA498 File Offset: 0x004B8698
	public int CoverReadIndexToServerProgress(int readIndex)
	{
		return readIndex + 1;
	}

	// Token: 0x06013121 RID: 78113 RVA: 0x004BA4A0 File Offset: 0x004B86A0
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

	// Token: 0x06013122 RID: 78114 RVA: 0x004BA544 File Offset: 0x004B8744
	public bool IsChatShowHasRedDotById(int id)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(EPhoneMsgServerRedDotType.Decoration, out hashSet) && hashSet.Contains(id);
	}

	// Token: 0x06013123 RID: 78115 RVA: 0x004BA572 File Offset: 0x004B8772
	public bool IsChatShowHasRedDot()
	{
		return this.HasRedDotByType(EPhoneMsgServerRedDotType.Decoration);
	}

	// Token: 0x06013124 RID: 78116 RVA: 0x004BA57C File Offset: 0x004B877C
	private bool HasRedDotByType(EPhoneMsgServerRedDotType type)
	{
		HashSet<int> hashSet;
		return this.LocalRedDotCache != null && this.LocalRedDotCache.TryGetValue(type, out hashSet) && hashSet.Count > 0;
	}

	// Token: 0x06013125 RID: 78117 RVA: 0x004BA5AC File Offset: 0x004B87AC
	public void RemoveChatShowRedDotById(int id)
	{
		this.RemovePhoneMsgRedDot(EPhoneMsgServerRedDotType.Decoration, id);
		EventSystem.Instance.Emit(EEventName.PhoneMsgDialogBgThemeCharmRedDotUpdate);
	}

	// Token: 0x06013126 RID: 78118 RVA: 0x004BA5C8 File Offset: 0x004B87C8
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

	// Token: 0x06013127 RID: 78119 RVA: 0x004BA608 File Offset: 0x004B8808
	public void SetLatestShortMsgTime(long time)
	{
		if (time > this.LatestShortMsgTime)
		{
			this.LatestShortMsgTime = time;
		}
	}

	// Token: 0x06013128 RID: 78120 RVA: 0x004BA61A File Offset: 0x004B881A
	public bool IsHasPhoneMsgUnReview()
	{
		return this.LatestShortMsgTime > this.LastOpenBigPanelTime;
	}

	// Token: 0x06013129 RID: 78121 RVA: 0x004BA62A File Offset: 0x004B882A
	public ChatPartner? GetChatPartnerConfigNew(int partnerId)
	{
		return PhoneMsgConfig.Instance.GetChatPartnerConfig(partnerId);
	}

	// Token: 0x170018D0 RID: 6352
	// (get) Token: 0x0601312A RID: 78122 RVA: 0x004BA637 File Offset: 0x004B8837
	public static PhoneMsgModel Instance
	{
		get
		{
			return PhoneMsgModel._Instance;
		}
	}

	// Token: 0x0601312B RID: 78123 RVA: 0x004BA63E File Offset: 0x004B883E
	public static PhoneMsgModel GetOrCreateInstance()
	{
		if (PhoneMsgModel._Instance == null)
		{
			PhoneMsgModel.CreateInstance();
		}
		return PhoneMsgModel._Instance;
	}

	// Token: 0x0601312C RID: 78124 RVA: 0x004BA652 File Offset: 0x004B8852
	public static bool CreateInstance()
	{
		if (PhoneMsgModel._Instance != null)
		{
			return true;
		}
		PhoneMsgModel._Instance = new PhoneMsgModel();
		return true;
	}

	// Token: 0x0601312D RID: 78125 RVA: 0x004BA668 File Offset: 0x004B8868
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601312E RID: 78126 RVA: 0x004BA66A File Offset: 0x004B886A
	public static void ResetStaticDefaultValue()
	{
		PhoneMsgModel._Instance = null;
	}

	// Token: 0x0601312F RID: 78127 RVA: 0x004BA672 File Offset: 0x004B8872
	static PhoneMsgModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhoneMsgModel.CreateStaticDefaultValue), new Action(PhoneMsgModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008F76 RID: 36726
	public HashSet<EDungeonSubType> NormalDungeonSet = new HashSet<EDungeonSubType>();

	// Token: 0x04008F77 RID: 36727
	public bool IsPhoneChatShowInitDone;

	// Token: 0x04008F78 RID: 36728
	public int CurrentUsingChatDialogId;

	// Token: 0x04008F79 RID: 36729
	public int CurrentUsingChatBgId;

	// Token: 0x04008F7A RID: 36730
	public int CurrentUsingChatThemeId;

	// Token: 0x04008F7B RID: 36731
	public int CurrentUsingChatCharmId;

	// Token: 0x04008F7C RID: 36732
	private string EmptyTexturePath = "";

	// Token: 0x04008F7D RID: 36733
	private readonly HashSet<int> UnlockedDialogIds = new HashSet<int>();

	// Token: 0x04008F7E RID: 36734
	private readonly HashSet<int> UnlockedBgIds = new HashSet<int>();

	// Token: 0x04008F7F RID: 36735
	private readonly HashSet<int> UnlockedThemeIds = new HashSet<int>();

	// Token: 0x04008F80 RID: 36736
	private readonly HashSet<int> UnlockedCharmIds = new HashSet<int>();

	// Token: 0x04008F81 RID: 36737
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EPhoneMsgServerRedDotType, HashSet<int>> LocalRedDotCache;

	// Token: 0x04008F82 RID: 36738
	[Nullable(2)]
	private ServerStorageSet ServerRedDotSet;

	// Token: 0x04008F83 RID: 36739
	public List<int> CurrentToBeNotifiedMsgArray = new List<int>();

	// Token: 0x04008F84 RID: 36740
	public List<int> CurrentToBeNotifiedMsgInSmallHeadQueue = new List<int>();

	// Token: 0x04008F85 RID: 36741
	public int CurrentShowingMsgIdInSmallHead;

	// Token: 0x04008F86 RID: 36742
	public List<PhoneMsgInputTimeData> MsgInputTimeList = new List<PhoneMsgInputTimeData>();

	// Token: 0x04008F87 RID: 36743
	private readonly Dictionary<int, float> AudioDurationMap = new Dictionary<int, float>();

	// Token: 0x04008F88 RID: 36744
	private Dictionary<int, HashSet<int>> AllFilterTypeSetDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008F89 RID: 36745
	private Dictionary<int, HashSet<int>> SelectedFilterSetDict = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008F8A RID: 36746
	private HashSet<int> SelectedFilterIdSet_Internal = new HashSet<int>();

	// Token: 0x04008F8B RID: 36747
	public List<int> ChatPartnerIdList = new List<int>();

	// Token: 0x04008F8C RID: 36748
	public Dictionary<int, List<int>> ChatPartnerId2ShortMessagesIdsDict = new Dictionary<int, List<int>>();

	// Token: 0x04008F8D RID: 36749
	public Dictionary<int, PhoneMsgShortMsgData> Id2ShortMessagesDict = new Dictionary<int, PhoneMsgShortMsgData>();

	// Token: 0x04008F8E RID: 36750
	[Nullable(2)]
	private List<int> UnreceivedPartnerList;

	// Token: 0x04008F8F RID: 36751
	[Nullable(2)]
	private List<int> ReceivedUnreadPartnerList;

	// Token: 0x04008F90 RID: 36752
	[Nullable(2)]
	private List<int> ReceivedReadPartnerList;

	// Token: 0x04008F91 RID: 36753
	private long LastOpenBigPanelTime;

	// Token: 0x04008F92 RID: 36754
	[Nullable(2)]
	private ServerStorageLong LastOpenBigPanelTimeStorage;

	// Token: 0x04008F93 RID: 36755
	private long LatestShortMsgTime;

	// Token: 0x04008F94 RID: 36756
	[Nullable(2)]
	private static PhoneMsgModel _Instance;
}
