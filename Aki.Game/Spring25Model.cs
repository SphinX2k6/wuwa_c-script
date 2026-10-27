using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Spring25;

// Token: 0x0200150A RID: 5386
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class Spring25Model : ModelBase
{
	// Token: 0x060099CD RID: 39373 RVA: 0x002145DB File Offset: 0x002127DB
	protected override bool OnInit()
	{
		this.ConfigContext = new Spring25ConfigContext(this);
		this.ProtocolContext = new Spring25ProtocolContext(this);
		this.UiContext = new Spring25UiContext(this);
		return true;
	}

	// Token: 0x060099CE RID: 39374 RVA: 0x00214602 File Offset: 0x00212802
	protected override bool OnClear()
	{
		this.ConfigContext.Dispose();
		this.ProtocolContext.Dispose();
		this.UiContext.Dispose();
		return true;
	}

	// Token: 0x17000D31 RID: 3377
	// (get) Token: 0x060099CF RID: 39375 RVA: 0x00214626 File Offset: 0x00212826
	public ActivityBaseData ActivityData
	{
		get
		{
			return this.ProtocolContext;
		}
	}

	// Token: 0x17000D32 RID: 3378
	// (get) Token: 0x060099D0 RID: 39376 RVA: 0x0021462E File Offset: 0x0021282E
	public int CurrentActivityId
	{
		get
		{
			return this.ProtocolContext.Id;
		}
	}

	// Token: 0x17000D33 RID: 3379
	// (get) Token: 0x060099D1 RID: 39377 RVA: 0x0021463B File Offset: 0x0021283B
	public bool IsLetterListViewAvailable
	{
		get
		{
			return this.ProtocolContext.InvitedCount > 0;
		}
	}

	// Token: 0x17000D34 RID: 3380
	// (get) Token: 0x060099D2 RID: 39378 RVA: 0x0021464B File Offset: 0x0021284B
	public bool IsInviteAvailableExternal
	{
		get
		{
			return this.ProtocolContext.IsInviteAvailable;
		}
	}

	// Token: 0x17000D35 RID: 3381
	// (get) Token: 0x060099D3 RID: 39379 RVA: 0x00214658 File Offset: 0x00212858
	public bool IsAllInvited
	{
		get
		{
			return this.ConfigContext.SignCount == this.ProtocolContext.InvitedCount;
		}
	}

	// Token: 0x17000D36 RID: 3382
	// (get) Token: 0x060099D4 RID: 39380 RVA: 0x00214672 File Offset: 0x00212872
	public int HelpId
	{
		get
		{
			return this.ProtocolContext.GetHelpId();
		}
	}

	// Token: 0x17000D37 RID: 3383
	// (get) Token: 0x060099D5 RID: 39381 RVA: 0x0021467F File Offset: 0x0021287F
	public bool IsSkinRewarded
	{
		get
		{
			return this.ProtocolContext.IsSkinRewarded;
		}
	}

	// Token: 0x17000D38 RID: 3384
	// (get) Token: 0x060099D6 RID: 39382 RVA: 0x0021468C File Offset: 0x0021288C
	public bool NeedOpenEnvelopeView
	{
		get
		{
			return this.UiContext.CurrentSignId != null;
		}
	}

	// Token: 0x17000D39 RID: 3385
	// (get) Token: 0x060099D7 RID: 39383 RVA: 0x002146AC File Offset: 0x002128AC
	public bool HasNewLetter
	{
		get
		{
			Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, null);
			if (player == null)
			{
				return false;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in player)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				if (!flag)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x17000D3A RID: 3386
	// (get) Token: 0x060099D8 RID: 39384 RVA: 0x0021471C File Offset: 0x0021291C
	public bool HasAnyRewardExternal
	{
		get
		{
			return this.ProtocolContext.HasAnyReward;
		}
	}

	// Token: 0x17000D3B RID: 3387
	// (get) Token: 0x060099D9 RID: 39385 RVA: 0x00214729 File Offset: 0x00212929
	public bool HasRedDot
	{
		get
		{
			return this.HasAnyRewardExternal || this.IsInviteAvailableExternal;
		}
	}

	// Token: 0x17000D3C RID: 3388
	// (get) Token: 0x060099DA RID: 39386 RVA: 0x0021473C File Offset: 0x0021293C
	public ESpring25InfoBottomState BottomStateInInfoView
	{
		get
		{
			if (this.IsSkinRewarded)
			{
				return ESpring25InfoBottomState.SkinRewarded;
			}
			if (this.ConfigContext.TaskCount != this.ProtocolContext.FinishTaskCount)
			{
				return ESpring25InfoBottomState.QuestNotAllDone;
			}
			if (LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.Spring25FirstTimeTaskAllDone, null) == null)
			{
				return ESpring25InfoBottomState.QuestAllDoneFirstTime;
			}
			return ESpring25InfoBottomState.QuestAllDoneButNotFirst;
		}
	}

	// Token: 0x17000D3D RID: 3389
	// (get) Token: 0x060099DB RID: 39387 RVA: 0x0021478C File Offset: 0x0021298C
	public string SharePhotoPath
	{
		get
		{
			SettleReward? config = ConfigSettleRewardByActivityId.GetConfig(this.CurrentActivityId, true);
			return ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? ((config != null) ? config.GetValueOrDefault().MalePhotoPath : null) : ((config != null) ? config.GetValueOrDefault().FemalePhotoPath : null)) ?? string.Empty;
		}
	}

	// Token: 0x17000D3E RID: 3390
	// (get) Token: 0x060099DC RID: 39388 RVA: 0x002147F4 File Offset: 0x002129F4
	public bool NeedStartDialog
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.Spring25FirstEnter, true) && this.ProtocolContext.InvitedCount == 0;
		}
	}

	// Token: 0x060099DD RID: 39389 RVA: 0x00214810 File Offset: 0x00212A10
	public bool IsLetterNewBySignId(int id)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, null);
		bool flag;
		return player != null && player.TryGetValue(id, out flag) && !flag;
	}

	// Token: 0x060099DE RID: 39390 RVA: 0x0021483C File Offset: 0x00212A3C
	public void SetLetterClickedBySignId(int id, bool value)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, null) ?? new Dictionary<int, bool>();
		dictionary[id] = value;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, dictionary);
	}

	// Token: 0x060099DF RID: 39391 RVA: 0x0021486C File Offset: 0x00212A6C
	public void SyncSpringSignDrawRoleResponse(SpringSignDrawRoleResponse response)
	{
		int drawId = response.DrawId;
		this.UiContext.CurrentSignId = new int?(drawId);
		this.ProtocolContext.InvitedRoleSet.Add(drawId);
		this.ProtocolContext.CanInvite = false;
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.ProtocolContext.TaskCache)
		{
			int num;
			ActivityTask activityTask;
			keyValuePair.Deconstruct(out num, out activityTask);
			int id = num;
			ActivityTask activityTask2 = activityTask;
			int taskThresholdByTaskId = this.ConfigContext.GetTaskThresholdByTaskId(id);
			if (activityTask2.Status == ActivityTaskState.ActivityTaskRunning && this.ProtocolContext.InvitedCount >= taskThresholdByTaskId)
			{
				activityTask2.Status = ActivityTaskState.ActivityTaskFinish;
			}
		}
		this.SetLetterClickedBySignId(drawId, false);
	}

	// Token: 0x060099E0 RID: 39392 RVA: 0x0021493C File Offset: 0x00212B3C
	public void SyncSpringSignDrawRewardResponse(int id)
	{
		this.ProtocolContext.SyncTaskStateByTaskId(id);
	}

	// Token: 0x060099E1 RID: 39393 RVA: 0x0021494A File Offset: 0x00212B4A
	public void SyncSpringSignSkinRewardResponse()
	{
		this.ProtocolContext.SyncSkinReward();
	}

	// Token: 0x060099E2 RID: 39394 RVA: 0x00214958 File Offset: 0x00212B58
	public void ResetCurrentSignId()
	{
		this.UiContext.CurrentSignId = null;
	}

	// Token: 0x060099E3 RID: 39395 RVA: 0x0021497C File Offset: 0x00212B7C
	public void TrySetCurrentLetterSignId(int id)
	{
		int? currentLetterSignId = this.UiContext.CurrentLetterSignId;
		if (id == currentLetterSignId.GetValueOrDefault() & currentLetterSignId != null)
		{
			return;
		}
		this.UiContext.CurrentLetterSignId = new int?(id);
	}

	// Token: 0x060099E4 RID: 39396 RVA: 0x002149BC File Offset: 0x00212BBC
	public void InitLetterSignIdForLetterListView()
	{
		int? num = null;
		foreach (int num2 in this.ProtocolContext.InvitedRoleSet)
		{
			if (num != null)
			{
				int? num3 = num;
				int num4 = num2;
				if (!(num3.GetValueOrDefault() > num4 & num3 != null))
				{
					continue;
				}
			}
			num = new int?(num2);
		}
		this.UiContext.CurrentLetterSignId = num;
	}

	// Token: 0x060099E5 RID: 39397 RVA: 0x00214A4C File Offset: 0x00212C4C
	public Spring25ActivitySubViewData BuildActivitySubViewData()
	{
		return new Spring25ActivitySubViewData
		{
			ProgressTextId = "Springsystem_1",
			RewardTextId = "Springsystem_2",
			ButtonTextId = "Springsystem_3",
			Current = this.ProtocolContext.InvitedCount.ToString(),
			TotalTextId = "Springsystem_5",
			TotalTextArg = this.ConfigContext.TaskCount.ToString(),
			IsMale = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male),
			NeedStartDialog = this.NeedStartDialog
		};
	}

	// Token: 0x060099E6 RID: 39398 RVA: 0x00214ADC File Offset: 0x00212CDC
	public Spring25MainViewData BuildMainViewData(bool isOnlyRefresh = false)
	{
		Dictionary<ESpring25RoleType, bool> dictionary = new Dictionary<ESpring25RoleType, bool>();
		ESpring25RoleType value = (ESpring25RoleType)0;
		int num;
		foreach (KeyValuePair<int, SpringSign> keyValuePair in this.ConfigContext.SignCfgMap)
		{
			SpringSign springSign;
			keyValuePair.Deconstruct(out num, out springSign);
			int num2 = num;
			ESpring25RoleType? resourceTypeBySignId = this.ConfigContext.GetResourceTypeBySignId(num2);
			if (resourceTypeBySignId != null)
			{
				dictionary[resourceTypeBySignId.Value] = this.ProtocolContext.IsRoleInvitedById(num2);
				int? currentSignId = this.UiContext.CurrentSignId;
				num = num2;
				if ((currentSignId.GetValueOrDefault() == num & currentSignId != null) && !isOnlyRefresh)
				{
					value = resourceTypeBySignId.Value;
				}
			}
		}
		Spring25MainViewData spring25MainViewData = new Spring25MainViewData();
		Spring25ProtocolContext protocolContext = this.ProtocolContext;
		spring25MainViewData.TitleTextId = (((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? string.Empty);
		num = this.ProtocolContext.SignCountRemain;
		spring25MainViewData.InviteRemainCount = num.ToString();
		spring25MainViewData.CharacterInvitedMap = dictionary;
		spring25MainViewData.NewRoleType = new ESpring25RoleType?(value);
		return spring25MainViewData;
	}

	// Token: 0x060099E7 RID: 39399 RVA: 0x00214C0C File Offset: 0x00212E0C
	public Spring25DialogueViewData BuildDialogueViewData()
	{
		int? currentSignId = this.UiContext.CurrentSignId;
		if (currentSignId == null)
		{
			return null;
		}
		Spring25DialogueSpineData[] array = this.BuildSpineDataBySignId(currentSignId.Value);
		List<Spring25DialogueChatData> chatDataList = this.BuildChatDataListInDialogViewBySignId(currentSignId.Value);
		return new Spring25DialogueViewData
		{
			IsOpening = false,
			LeftSpineData = array[0],
			RightSpineData = array[1],
			ChatDataList = chatDataList
		};
	}

	// Token: 0x060099E8 RID: 39400 RVA: 0x00214C74 File Offset: 0x00212E74
	public Spring25DialogueViewData BuildStartDialogueViewData()
	{
		Spring25DialogueSpineData[] array = this.BuildStartSpineData();
		List<Spring25DialogueChatData> chatDataList = this.BuildStartChatDataListInDialogView();
		return new Spring25DialogueViewData
		{
			IsOpening = true,
			LeftSpineData = array[0],
			RightSpineData = array[1],
			ChatDataList = chatDataList
		};
	}

	// Token: 0x060099E9 RID: 39401 RVA: 0x00214CB4 File Offset: 0x00212EB4
	public Spring25InfoViewData BuildInfoViewData()
	{
		int invitedCount = this.ProtocolContext.InvitedCount;
		int taskCount = this.ConfigContext.TaskCount;
		Spring25InfoViewData spring25InfoViewData = new Spring25InfoViewData();
		Spring25ProtocolContext protocolContext = this.ProtocolContext;
		spring25InfoViewData.TitleTextId = (((protocolContext.LocalConfig != null) ? protocolContext.LocalConfig.GetValueOrDefault().Title : null) ?? string.Empty);
		spring25InfoViewData.CurrentNum = invitedCount.ToString();
		spring25InfoViewData.TotalNumTextId = "Springsystem_5";
		spring25InfoViewData.TotalNumTextArg = taskCount.ToString();
		spring25InfoViewData.BottomState = this.BottomStateInInfoView;
		spring25InfoViewData.ContentList = this.BuildContentListInInfoView();
		spring25InfoViewData.ProgressList = this.BuildProgressListInInfoView();
		return spring25InfoViewData;
	}

	// Token: 0x060099EA RID: 39402 RVA: 0x00214D5C File Offset: 0x00212F5C
	public Spring25LetterListViewData BuildLetterListViewData()
	{
		string infoTextId = null;
		string titleTextId = null;
		int? currentLetterSignId = this.UiContext.CurrentLetterSignId;
		if (currentLetterSignId != null)
		{
			infoTextId = this.ConfigContext.GetLetterContentTextIdBySignId(currentLetterSignId.Value);
			titleTextId = this.ConfigContext.GetLetterTitleTextIdBySignId(currentLetterSignId.Value);
		}
		return new Spring25LetterListViewData
		{
			TabDataList = this.BuildTabDataListInLetterListView(),
			InfoTextId = infoTextId,
			TitleTextId = titleTextId
		};
	}

	// Token: 0x060099EB RID: 39403 RVA: 0x00214DC8 File Offset: 0x00212FC8
	public Spring25EnvelopeViewData BuildEnvelopeViewData()
	{
		int? currentSignId = this.UiContext.CurrentSignId;
		string titleTextId = (currentSignId != null) ? this.ConfigContext.GetLetterTitleTextIdBySignId(currentSignId.Value) : null;
		string infoTextId = (currentSignId != null) ? this.ConfigContext.GetLetterContentTextIdBySignId(currentSignId.Value) : null;
		return new Spring25EnvelopeViewData
		{
			TitleTextId = titleTextId,
			InfoTextId = infoTextId
		};
	}

	// Token: 0x060099EC RID: 39404 RVA: 0x00214E34 File Offset: 0x00213034
	private unsafe List<Spring25InfoContentData> BuildContentListInInfoView()
	{
		List<Spring25InfoContentData> list = new List<Spring25InfoContentData>();
		foreach (KeyValuePair<int, SpringReward> keyValuePair in this.ConfigContext.TaskCfgMap)
		{
			int num;
			SpringReward springReward;
			keyValuePair.Deconstruct(out num, out springReward);
			SpringReward springReward2 = springReward;
			int id = springReward2.Id;
			ActivityTaskState taskStateByTaskId = this.ProtocolContext.GetTaskStateByTaskId(id);
			Spring25InfoContentData spring25InfoContentData = new Spring25InfoContentData();
			spring25InfoContentData.TaskId = id;
			spring25InfoContentData.State = taskStateByTaskId;
			spring25InfoContentData.ItemList = this.ProtocolContext.GetTaskRewardPreviewByTaskId(id);
			spring25InfoContentData.NameTextId = (this.ConfigContext.GetTaskNameTextIdByTaskId(id) ?? string.Empty);
			spring25InfoContentData.SubtitleTextId = "Text_ItemRecycleChosen_text";
			num = 2;
			List<string> list2 = new List<string>(num);
			CollectionsMarshal.SetCount<string>(list2, num);
			Span<string> span = CollectionsMarshal.AsSpan<string>(list2);
			int num2 = 0;
			*span[num2] = ((taskStateByTaskId < ActivityTaskState.ActivityTaskFinish) ? "0" : "1");
			num2++;
			*span[num2] = "1";
			spring25InfoContentData.SubtitleTextArgs = list2;
			spring25InfoContentData.IsDone = (taskStateByTaskId == ActivityTaskState.ActivityTaskTaken);
			spring25InfoContentData.CanReward = (taskStateByTaskId == ActivityTaskState.ActivityTaskFinish);
			spring25InfoContentData.RightTextId = ((taskStateByTaskId == ActivityTaskState.ActivityTaskRunning) ? "Text_NotFinished_Text" : null);
			Spring25InfoContentData item = spring25InfoContentData;
			list.Add(item);
		}
		list.Sort(delegate(Spring25InfoContentData a, Spring25InfoContentData b)
		{
			if (a.State == b.State)
			{
				return a.TaskId.CompareTo(b.TaskId);
			}
			if (a.State == ActivityTaskState.ActivityTaskFinish)
			{
				return -1;
			}
			if (b.State == ActivityTaskState.ActivityTaskFinish)
			{
				return 1;
			}
			if (a.State == ActivityTaskState.ActivityTaskRunning)
			{
				return -1;
			}
			return 1;
		});
		return list;
	}

	// Token: 0x060099ED RID: 39405 RVA: 0x00214FC0 File Offset: 0x002131C0
	private List<Spring25InfoProgressData> BuildProgressListInInfoView()
	{
		List<Spring25InfoProgressData> list = new List<Spring25InfoProgressData>();
		int num = -1;
		for (int i = 0; i < this.ConfigContext.TaskCount; i++)
		{
			bool flag = i < this.ProtocolContext.InvitedCount;
			if (flag)
			{
				num = i;
			}
			list.Add(new Spring25InfoProgressData
			{
				IsLight = flag,
				IsBlink = false
			});
		}
		if (num != -1 && LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.Spring25FirstDoneTaskIndex, -1) < num)
		{
			Spring25InfoProgressData spring25InfoProgressData = list[num];
			spring25InfoProgressData.IsBlink = true;
			list[num] = spring25InfoProgressData;
		}
		return list;
	}

	// Token: 0x060099EE RID: 39406 RVA: 0x00215044 File Offset: 0x00213244
	private List<Spring25LetterListTabData> BuildTabDataListInLetterListView()
	{
		List<int> list = (from id in this.ProtocolContext.InvitedRoleSet
		orderby id
		select id).ToList<int>();
		List<Spring25LetterListTabData> list2 = new List<Spring25LetterListTabData>();
		foreach (int num in list)
		{
			List<Spring25LetterListTabData> list3 = list2;
			Spring25LetterListTabData spring25LetterListTabData = new Spring25LetterListTabData();
			spring25LetterListTabData.SignId = num;
			int num2 = num;
			int? currentLetterSignId = this.UiContext.CurrentLetterSignId;
			spring25LetterListTabData.IsChosen = (num2 == currentLetterSignId.GetValueOrDefault() & currentLetterSignId != null);
			spring25LetterListTabData.IsNew = this.IsLetterNewBySignId(num);
			spring25LetterListTabData.TexturePath = this.ConfigContext.GetLetterIconBySignId(num);
			spring25LetterListTabData.DescriptionTextId = this.ConfigContext.GetLetterTabTextIdBySignId(num);
			list3.Add(spring25LetterListTabData);
		}
		return list2;
	}

	// Token: 0x060099EF RID: 39407 RVA: 0x0021512C File Offset: 0x0021332C
	private List<Spring25DialogueChatData> BuildChatDataListInDialogViewByChatCfg(SpringChat? chatCfg)
	{
		List<Spring25DialogueChatData> list = new List<Spring25DialogueChatData>();
		if (chatCfg == null)
		{
			return list;
		}
		for (int i = 0; i < chatCfg.Value.ContentListLength; i++)
		{
			list.Add(new Spring25DialogueChatData
			{
				ContentTextId = chatCfg.Value.ContentList(i),
				Position = (ESpring25DialogType)chatCfg.Value.PosList(i),
				SpineAnimName = chatCfg.Value.AnimNameList(i)
			});
		}
		return list;
	}

	// Token: 0x060099F0 RID: 39408 RVA: 0x002151B4 File Offset: 0x002133B4
	private Spring25DialogueSpineData[] BuildSpineDataByChatCfg(SpringChat? chatCfg)
	{
		return new Spring25DialogueSpineData[]
		{
			new Spring25DialogueSpineData
			{
				AtlasPath = ((chatCfg != null) ? chatCfg.GetValueOrDefault().LeftSpineAtlas : null),
				SkeletonDataPath = ((chatCfg != null) ? chatCfg.GetValueOrDefault().LeftSpineSkeletonData : null)
			},
			new Spring25DialogueSpineData
			{
				AtlasPath = ((chatCfg != null) ? chatCfg.GetValueOrDefault().RightSpineAtlas : null),
				SkeletonDataPath = ((chatCfg != null) ? chatCfg.GetValueOrDefault().RightSpineSkeletonData : null)
			}
		};
	}

	// Token: 0x060099F1 RID: 39409 RVA: 0x0021525C File Offset: 0x0021345C
	private List<Spring25DialogueChatData> BuildChatDataListInDialogViewBySignId(int id)
	{
		SpringChat? chatConfigBySignId = this.ConfigContext.GetChatConfigBySignId(id, PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildChatDataListInDialogViewByChatCfg(chatConfigBySignId);
	}

	// Token: 0x060099F2 RID: 39410 RVA: 0x00215288 File Offset: 0x00213488
	private List<Spring25DialogueChatData> BuildStartChatDataListInDialogView()
	{
		SpringChat? chatCfg = this.ConfigContext.StartChatCfgByGender(PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildChatDataListInDialogViewByChatCfg(chatCfg);
	}

	// Token: 0x060099F3 RID: 39411 RVA: 0x002152B4 File Offset: 0x002134B4
	private Spring25DialogueSpineData[] BuildSpineDataBySignId(int id)
	{
		SpringChat? chatConfigBySignId = this.ConfigContext.GetChatConfigBySignId(id, PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildSpineDataByChatCfg(chatConfigBySignId);
	}

	// Token: 0x060099F4 RID: 39412 RVA: 0x002152E0 File Offset: 0x002134E0
	private Spring25DialogueSpineData[] BuildStartSpineData()
	{
		SpringChat? chatCfg = this.ConfigContext.StartChatCfgByGender(PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildSpineDataByChatCfg(chatCfg);
	}

	// Token: 0x17000D3F RID: 3391
	// (get) Token: 0x060099F5 RID: 39413 RVA: 0x0021530A File Offset: 0x0021350A
	public static Spring25Model Instance
	{
		get
		{
			return Spring25Model._Instance;
		}
	}

	// Token: 0x060099F6 RID: 39414 RVA: 0x00215311 File Offset: 0x00213511
	public static Spring25Model GetOrCreateInstance()
	{
		if (Spring25Model._Instance == null)
		{
			Spring25Model.CreateInstance();
		}
		return Spring25Model._Instance;
	}

	// Token: 0x060099F7 RID: 39415 RVA: 0x00215325 File Offset: 0x00213525
	public static bool CreateInstance()
	{
		if (Spring25Model._Instance != null)
		{
			return true;
		}
		Spring25Model._Instance = new Spring25Model();
		return true;
	}

	// Token: 0x060099F8 RID: 39416 RVA: 0x0021533B File Offset: 0x0021353B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060099F9 RID: 39417 RVA: 0x0021533D File Offset: 0x0021353D
	public static void ResetStaticDefaultValue()
	{
		Spring25Model._Instance = null;
	}

	// Token: 0x060099FA RID: 39418 RVA: 0x00215345 File Offset: 0x00213545
	static Spring25Model()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Spring25Model.CreateStaticDefaultValue), new Action(Spring25Model.ResetStaticDefaultValue));
	}

	// Token: 0x0400437C RID: 17276
	private Spring25ConfigContext ConfigContext;

	// Token: 0x0400437D RID: 17277
	private Spring25ProtocolContext ProtocolContext;

	// Token: 0x0400437E RID: 17278
	private Spring25UiContext UiContext;

	// Token: 0x0400437F RID: 17279
	[Nullable(2)]
	private static Spring25Model _Instance;
}
