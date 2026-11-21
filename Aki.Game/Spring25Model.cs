using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Spring25;

// Token: 0x020009C2 RID: 2498
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class Spring25Model : ModelBase
{
	// Token: 0x06006DAB RID: 28075 RVA: 0x0021E393 File Offset: 0x0021C593
	protected override bool OnInit()
	{
		this.ConfigContext = new Spring25ConfigContext(this);
		this.ProtocolContext = new Spring25ProtocolContext(this);
		this.UiContext = new Spring25UiContext(this);
		return true;
	}

	// Token: 0x06006DAC RID: 28076 RVA: 0x0021E3BA File Offset: 0x0021C5BA
	protected override bool OnClear()
	{
		this.ConfigContext.Dispose();
		this.ProtocolContext.Dispose();
		this.UiContext.Dispose();
		return true;
	}

	// Token: 0x17000D52 RID: 3410
	// (get) Token: 0x06006DAD RID: 28077 RVA: 0x0021E3DE File Offset: 0x0021C5DE
	public ActivityBaseData ActivityData
	{
		get
		{
			return this.ProtocolContext;
		}
	}

	// Token: 0x17000D53 RID: 3411
	// (get) Token: 0x06006DAE RID: 28078 RVA: 0x0021E3E6 File Offset: 0x0021C5E6
	public int CurrentActivityId
	{
		get
		{
			return this.ProtocolContext.Id;
		}
	}

	// Token: 0x17000D54 RID: 3412
	// (get) Token: 0x06006DAF RID: 28079 RVA: 0x0021E3F3 File Offset: 0x0021C5F3
	public bool IsLetterListViewAvailable
	{
		get
		{
			return this.ProtocolContext.InvitedCount > 0;
		}
	}

	// Token: 0x17000D55 RID: 3413
	// (get) Token: 0x06006DB0 RID: 28080 RVA: 0x0021E403 File Offset: 0x0021C603
	public bool IsInviteAvailableExternal
	{
		get
		{
			return this.ProtocolContext.IsInviteAvailable;
		}
	}

	// Token: 0x17000D56 RID: 3414
	// (get) Token: 0x06006DB1 RID: 28081 RVA: 0x0021E410 File Offset: 0x0021C610
	public bool IsAllInvited
	{
		get
		{
			return this.ConfigContext.SignCount == this.ProtocolContext.InvitedCount;
		}
	}

	// Token: 0x17000D57 RID: 3415
	// (get) Token: 0x06006DB2 RID: 28082 RVA: 0x0021E42A File Offset: 0x0021C62A
	public int HelpId
	{
		get
		{
			return this.ProtocolContext.GetHelpId();
		}
	}

	// Token: 0x17000D58 RID: 3416
	// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x0021E437 File Offset: 0x0021C637
	public bool IsSkinRewarded
	{
		get
		{
			return this.ProtocolContext.IsSkinRewarded;
		}
	}

	// Token: 0x17000D59 RID: 3417
	// (get) Token: 0x06006DB4 RID: 28084 RVA: 0x0021E444 File Offset: 0x0021C644
	public bool NeedOpenEnvelopeView
	{
		get
		{
			return this.UiContext.CurrentSignId != null;
		}
	}

	// Token: 0x17000D5A RID: 3418
	// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x0021E464 File Offset: 0x0021C664
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

	// Token: 0x17000D5B RID: 3419
	// (get) Token: 0x06006DB6 RID: 28086 RVA: 0x0021E4D4 File Offset: 0x0021C6D4
	public bool HasAnyRewardExternal
	{
		get
		{
			return this.ProtocolContext.HasAnyReward;
		}
	}

	// Token: 0x17000D5C RID: 3420
	// (get) Token: 0x06006DB7 RID: 28087 RVA: 0x0021E4E1 File Offset: 0x0021C6E1
	public bool HasRedDot
	{
		get
		{
			return this.HasAnyRewardExternal || this.IsInviteAvailableExternal;
		}
	}

	// Token: 0x17000D5D RID: 3421
	// (get) Token: 0x06006DB8 RID: 28088 RVA: 0x0021E4F4 File Offset: 0x0021C6F4
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

	// Token: 0x17000D5E RID: 3422
	// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x0021E544 File Offset: 0x0021C744
	public string SharePhotoPath
	{
		get
		{
			SettleReward? config = ConfigSettleRewardByActivityId.GetConfig(this.CurrentActivityId, true);
			return ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? ((config != null) ? config.GetValueOrDefault().MalePhotoPath : null) : ((config != null) ? config.GetValueOrDefault().FemalePhotoPath : null)) ?? string.Empty;
		}
	}

	// Token: 0x17000D5F RID: 3423
	// (get) Token: 0x06006DBA RID: 28090 RVA: 0x0021E5AC File Offset: 0x0021C7AC
	public bool NeedStartDialog
	{
		get
		{
			return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.Spring25FirstEnter, true) && this.ProtocolContext.InvitedCount == 0;
		}
	}

	// Token: 0x06006DBB RID: 28091 RVA: 0x0021E5C8 File Offset: 0x0021C7C8
	public bool IsLetterNewBySignId(int id)
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, null);
		bool flag;
		return player != null && player.TryGetValue(id, out flag) && !flag;
	}

	// Token: 0x06006DBC RID: 28092 RVA: 0x0021E5F4 File Offset: 0x0021C7F4
	public void SetLetterClickedBySignId(int id, bool value)
	{
		Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, null) ?? new Dictionary<int, bool>();
		dictionary[id] = value;
		LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.Spring25FirstLetterClick, dictionary);
	}

	// Token: 0x06006DBD RID: 28093 RVA: 0x0021E624 File Offset: 0x0021C824
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

	// Token: 0x06006DBE RID: 28094 RVA: 0x0021E6F4 File Offset: 0x0021C8F4
	public void SyncSpringSignDrawRewardResponse(int id)
	{
		this.ProtocolContext.SyncTaskStateByTaskId(id);
	}

	// Token: 0x06006DBF RID: 28095 RVA: 0x0021E702 File Offset: 0x0021C902
	public void SyncSpringSignSkinRewardResponse()
	{
		this.ProtocolContext.SyncSkinReward();
	}

	// Token: 0x06006DC0 RID: 28096 RVA: 0x0021E710 File Offset: 0x0021C910
	public void ResetCurrentSignId()
	{
		this.UiContext.CurrentSignId = null;
	}

	// Token: 0x06006DC1 RID: 28097 RVA: 0x0021E734 File Offset: 0x0021C934
	public void TrySetCurrentLetterSignId(int id)
	{
		int? currentLetterSignId = this.UiContext.CurrentLetterSignId;
		if (id == currentLetterSignId.GetValueOrDefault() & currentLetterSignId != null)
		{
			return;
		}
		this.UiContext.CurrentLetterSignId = new int?(id);
	}

	// Token: 0x06006DC2 RID: 28098 RVA: 0x0021E774 File Offset: 0x0021C974
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

	// Token: 0x06006DC3 RID: 28099 RVA: 0x0021E804 File Offset: 0x0021CA04
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

	// Token: 0x06006DC4 RID: 28100 RVA: 0x0021E894 File Offset: 0x0021CA94
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

	// Token: 0x06006DC5 RID: 28101 RVA: 0x0021E9C4 File Offset: 0x0021CBC4
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

	// Token: 0x06006DC6 RID: 28102 RVA: 0x0021EA2C File Offset: 0x0021CC2C
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

	// Token: 0x06006DC7 RID: 28103 RVA: 0x0021EA6C File Offset: 0x0021CC6C
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

	// Token: 0x06006DC8 RID: 28104 RVA: 0x0021EB14 File Offset: 0x0021CD14
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

	// Token: 0x06006DC9 RID: 28105 RVA: 0x0021EB80 File Offset: 0x0021CD80
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

	// Token: 0x06006DCA RID: 28106 RVA: 0x0021EBEC File Offset: 0x0021CDEC
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

	// Token: 0x06006DCB RID: 28107 RVA: 0x0021ED78 File Offset: 0x0021CF78
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

	// Token: 0x06006DCC RID: 28108 RVA: 0x0021EDFC File Offset: 0x0021CFFC
	private List<Spring25LetterListTabData> BuildTabDataListInLetterListView()
	{
		List<int> list = new List<int>(this.ProtocolContext.InvitedRoleSet);
		list.Sort();
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

	// Token: 0x06006DCD RID: 28109 RVA: 0x0021EEC8 File Offset: 0x0021D0C8
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

	// Token: 0x06006DCE RID: 28110 RVA: 0x0021EF50 File Offset: 0x0021D150
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

	// Token: 0x06006DCF RID: 28111 RVA: 0x0021EFF8 File Offset: 0x0021D1F8
	private List<Spring25DialogueChatData> BuildChatDataListInDialogViewBySignId(int id)
	{
		SpringChat? chatConfigBySignId = this.ConfigContext.GetChatConfigBySignId(id, PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildChatDataListInDialogViewByChatCfg(chatConfigBySignId);
	}

	// Token: 0x06006DD0 RID: 28112 RVA: 0x0021F024 File Offset: 0x0021D224
	private List<Spring25DialogueChatData> BuildStartChatDataListInDialogView()
	{
		SpringChat? chatCfg = this.ConfigContext.StartChatCfgByGender(PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildChatDataListInDialogViewByChatCfg(chatCfg);
	}

	// Token: 0x06006DD1 RID: 28113 RVA: 0x0021F050 File Offset: 0x0021D250
	private Spring25DialogueSpineData[] BuildSpineDataBySignId(int id)
	{
		SpringChat? chatConfigBySignId = this.ConfigContext.GetChatConfigBySignId(id, PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildSpineDataByChatCfg(chatConfigBySignId);
	}

	// Token: 0x06006DD2 RID: 28114 RVA: 0x0021F07C File Offset: 0x0021D27C
	private Spring25DialogueSpineData[] BuildStartSpineData()
	{
		SpringChat? chatCfg = this.ConfigContext.StartChatCfgByGender(PlayerInfoModel.Instance.GetPlayerGender());
		return this.BuildSpineDataByChatCfg(chatCfg);
	}

	// Token: 0x17000D60 RID: 3424
	// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x0021F0A6 File Offset: 0x0021D2A6
	public static Spring25Model Instance
	{
		get
		{
			return Spring25Model._Instance;
		}
	}

	// Token: 0x06006DD4 RID: 28116 RVA: 0x0021F0AD File Offset: 0x0021D2AD
	public static Spring25Model GetOrCreateInstance()
	{
		if (Spring25Model._Instance == null)
		{
			Spring25Model.CreateInstance();
		}
		return Spring25Model._Instance;
	}

	// Token: 0x06006DD5 RID: 28117 RVA: 0x0021F0C1 File Offset: 0x0021D2C1
	public static bool CreateInstance()
	{
		if (Spring25Model._Instance != null)
		{
			return true;
		}
		Spring25Model._Instance = new Spring25Model();
		return true;
	}

	// Token: 0x06006DD6 RID: 28118 RVA: 0x0021F0D7 File Offset: 0x0021D2D7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006DD7 RID: 28119 RVA: 0x0021F0D9 File Offset: 0x0021D2D9
	public static void ResetStaticDefaultValue()
	{
		Spring25Model._Instance = null;
	}

	// Token: 0x06006DD8 RID: 28120 RVA: 0x0021F0E1 File Offset: 0x0021D2E1
	static Spring25Model()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Spring25Model.CreateStaticDefaultValue), new Action(Spring25Model.ResetStaticDefaultValue));
	}

	// Token: 0x04004422 RID: 17442
	private Spring25ConfigContext ConfigContext;

	// Token: 0x04004423 RID: 17443
	private Spring25ProtocolContext ProtocolContext;

	// Token: 0x04004424 RID: 17444
	private Spring25UiContext UiContext;

	// Token: 0x04004425 RID: 17445
	[Nullable(2)]
	private static Spring25Model _Instance;
}
