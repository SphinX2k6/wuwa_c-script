using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023C0 RID: 9152
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PersonalOptionController : UiControllerBase
{
	// Token: 0x060124C5 RID: 74949 RVA: 0x004816AC File Offset: 0x0047F8AC
	public PersonalOptionController()
	{
		this.InitOptionMap();
	}

	// Token: 0x060124C6 RID: 74950 RVA: 0x004816BC File Offset: 0x0047F8BC
	protected void InitOptionMap()
	{
		this.OptionMap = new Dictionary<int, Action>();
		Dictionary<int, Action> optionMap = this.OptionMap;
		int key = 1;
		Action value;
		if ((value = PersonalOptionController.<>O.<0>__OnClickShieldBtn) == null)
		{
			value = (PersonalOptionController.<>O.<0>__OnClickShieldBtn = new Action(PersonalOptionController.OnClickShieldBtn));
		}
		optionMap.TryAdd(key, value);
		Dictionary<int, Action> optionMap2 = this.OptionMap;
		int key2 = 2;
		Action value2;
		if ((value2 = PersonalOptionController.<>O.<0>__OnClickShieldBtn) == null)
		{
			value2 = (PersonalOptionController.<>O.<0>__OnClickShieldBtn = new Action(PersonalOptionController.OnClickShieldBtn));
		}
		optionMap2.TryAdd(key2, value2);
		Dictionary<int, Action> optionMap3 = this.OptionMap;
		int key3 = 3;
		Action value3;
		if ((value3 = PersonalOptionController.<>O.<1>__OnClickBlockBtn) == null)
		{
			value3 = (PersonalOptionController.<>O.<1>__OnClickBlockBtn = new Action(PersonalOptionController.OnClickBlockBtn));
		}
		optionMap3.TryAdd(key3, value3);
		Dictionary<int, Action> optionMap4 = this.OptionMap;
		int key4 = 4;
		Action value4;
		if ((value4 = PersonalOptionController.<>O.<2>__OnClickDeleteBtn) == null)
		{
			value4 = (PersonalOptionController.<>O.<2>__OnClickDeleteBtn = new Action(PersonalOptionController.OnClickDeleteBtn));
		}
		optionMap4.TryAdd(key4, value4);
		Dictionary<int, Action> optionMap5 = this.OptionMap;
		int key5 = 5;
		Action value5;
		if ((value5 = PersonalOptionController.<>O.<3>__OnClickReportBtn) == null)
		{
			value5 = (PersonalOptionController.<>O.<3>__OnClickReportBtn = new Action(PersonalOptionController.OnClickReportBtn));
		}
		optionMap5.TryAdd(key5, value5);
		Dictionary<int, Action> optionMap6 = this.OptionMap;
		int key6 = 11;
		Action value6;
		if ((value6 = PersonalOptionController.<>O.<4>__CopyUidClick) == null)
		{
			value6 = (PersonalOptionController.<>O.<4>__CopyUidClick = new Action(PersonalOptionController.CopyUidClick));
		}
		optionMap6.TryAdd(key6, value6);
		Dictionary<int, Action> optionMap7 = this.OptionMap;
		int key7 = 6;
		Action value7;
		if ((value7 = PersonalOptionController.<>O.<5>__ChangeHeadIcon) == null)
		{
			value7 = (PersonalOptionController.<>O.<5>__ChangeHeadIcon = new Action(PersonalOptionController.ChangeHeadIcon));
		}
		optionMap7.TryAdd(key7, value7);
		Dictionary<int, Action> optionMap8 = this.OptionMap;
		int key8 = 7;
		Action value8;
		if ((value8 = PersonalOptionController.<>O.<6>__ChangeCard) == null)
		{
			value8 = (PersonalOptionController.<>O.<6>__ChangeCard = new Action(PersonalOptionController.ChangeCard));
		}
		optionMap8.TryAdd(key8, value8);
		Dictionary<int, Action> optionMap9 = this.OptionMap;
		int key9 = 8;
		Action value9;
		if ((value9 = PersonalOptionController.<>O.<7>__ChangeName) == null)
		{
			value9 = (PersonalOptionController.<>O.<7>__ChangeName = new Action(PersonalOptionController.ChangeName));
		}
		optionMap9.TryAdd(key9, value9);
		Dictionary<int, Action> optionMap10 = this.OptionMap;
		int key10 = 9;
		Action value10;
		if ((value10 = PersonalOptionController.<>O.<8>__ChangeSign) == null)
		{
			value10 = (PersonalOptionController.<>O.<8>__ChangeSign = new Action(PersonalOptionController.ChangeSign));
		}
		optionMap10.TryAdd(key10, value10);
		Dictionary<int, Action> optionMap11 = this.OptionMap;
		int key11 = 10;
		Action value11;
		if ((value11 = PersonalOptionController.<>O.<9>__SetBirth) == null)
		{
			value11 = (PersonalOptionController.<>O.<9>__SetBirth = new Action(PersonalOptionController.SetBirth));
		}
		optionMap11.TryAdd(key11, value11);
		Dictionary<int, Action> optionMap12 = this.OptionMap;
		int key12 = 12;
		Action value12;
		if ((value12 = PersonalOptionController.<>O.<10>__LookCard) == null)
		{
			value12 = (PersonalOptionController.<>O.<10>__LookCard = new Action(PersonalOptionController.LookCard));
		}
		optionMap12.TryAdd(key12, value12);
		Dictionary<int, Action> optionMap13 = this.OptionMap;
		int key13 = 13;
		Action value13;
		if ((value13 = PersonalOptionController.<>O.<11>__ChangeRemark) == null)
		{
			value13 = (PersonalOptionController.<>O.<11>__ChangeRemark = new Action(PersonalOptionController.ChangeRemark));
		}
		optionMap13.TryAdd(key13, value13);
		Dictionary<int, Action> optionMap14 = this.OptionMap;
		int key14 = 14;
		Action value14;
		if ((value14 = PersonalOptionController.<>O.<12>__ChangePlayerTitle) == null)
		{
			value14 = (PersonalOptionController.<>O.<12>__ChangePlayerTitle = new Action(PersonalOptionController.ChangePlayerTitle));
		}
		optionMap14.TryAdd(key14, value14);
		Dictionary<int, Action> optionMap15 = this.OptionMap;
		int key15 = 15;
		Action value15;
		if ((value15 = PersonalOptionController.<>O.<13>__OpenPersonalRootView) == null)
		{
			value15 = (PersonalOptionController.<>O.<13>__OpenPersonalRootView = new Action(PersonalOptionController.OpenPersonalRootView));
		}
		optionMap15.TryAdd(key15, value15);
		Dictionary<int, Action> optionMap16 = this.OptionMap;
		int key16 = 16;
		Action value16;
		if ((value16 = PersonalOptionController.<>O.<14>__OpenFeedBackMainView) == null)
		{
			value16 = (PersonalOptionController.<>O.<14>__OpenFeedBackMainView = new Action(PersonalOptionController.OpenFeedBackMainView));
		}
		optionMap16.TryAdd(key16, value16);
	}

	// Token: 0x060124C7 RID: 74951 RVA: 0x0048195C File Offset: 0x0047FB5C
	public Action GetOptionFunc(EPersonalOptionDefine optionId)
	{
		if (this.OptionMap.Count == 0)
		{
			this.InitOptionMap();
		}
		Action result;
		this.OptionMap.TryGetValue((int)optionId, out result);
		return result;
	}

	// Token: 0x060124C8 RID: 74952 RVA: 0x0048198C File Offset: 0x0047FB8C
	private static void OnClickShieldBtn()
	{
		IPlayerData playerData;
		if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineProcessView))
		{
			IPlayerData cachePlayerData = FriendModel.Instance.CachePlayerData;
			playerData = cachePlayerData;
		}
		else
		{
			IPlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
			playerData = cachePlayerData;
		}
		IPlayerData playerData2 = playerData;
		if (!FriendModel.Instance.IsMyFriend(playerData2.PlayerId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("NotFriendShieldTips", Array.Empty<object>());
			return;
		}
		if (ChatModel.Instance.IsInMute(playerData2.PlayerId))
		{
			ChatController.Instance.ChatMutePlayerRequest(playerData2.PlayerId, false);
			return;
		}
		ChatController.Instance.ChatMutePlayerRequest(playerData2.PlayerId, true);
	}

	// Token: 0x060124C9 RID: 74953 RVA: 0x00481A24 File Offset: 0x0047FC24
	private static void OnClickReportBtn()
	{
		IPlayerData playerData;
		if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineProcessView))
		{
			IPlayerData cachePlayerData = FriendModel.Instance.CachePlayerData;
			playerData = cachePlayerData;
		}
		else
		{
			IPlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
			playerData = cachePlayerData;
		}
		IPlayerData friendData = playerData;
		ReportController.Instance.OpenReportView(friendData, EReportSourceType.FriendSystem);
	}

	// Token: 0x060124CA RID: 74954 RVA: 0x00481A6C File Offset: 0x0047FC6C
	private static void OnClickDeleteBtn()
	{
		PersonalOptionController.<>c__DisplayClass6_0 CS$<>8__locals1 = new PersonalOptionController.<>c__DisplayClass6_0();
		FriendModel instance = FriendModel.Instance;
		PersonalOptionController.<>c__DisplayClass6_0 CS$<>8__locals2 = CS$<>8__locals1;
		IPlayerData player;
		if (!UiManager.Instance.IsViewOpen(EUiViewName.OnlineProcessView))
		{
			IPlayerData cachePlayerData = instance.CachePlayerData;
			player = cachePlayerData;
		}
		else
		{
			IPlayerData cachePlayerData = OnlineModel.Instance.CachePlayerData;
			player = cachePlayerData;
		}
		CS$<>8__locals2.player = player;
		if (!instance.HasFriend(CS$<>8__locals1.player.PlayerId))
		{
			GenericPromptController.Instance.ShowPromptByCode("NotOnFriendList", Array.Empty<object>());
			UiManager.Instance.CloseView(EUiViewName.FriendProcessView, null);
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DeleteFriend);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			CS$<>8__locals1.player.PlayerName
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			FriendController.Instance.RequestFriendDelete(CS$<>8__locals1.player.PlayerId);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060124CB RID: 74955 RVA: 0x00481B30 File Offset: 0x0047FD30
	private static void OnClickBlockBtn()
	{
		FriendData player = FriendModel.Instance.CachePlayerData;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BlockFriend);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			player.PlayerName
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			FriendController.Instance.RequestBlockPlayer(player.PlayerId);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060124CC RID: 74956 RVA: 0x00481B9C File Offset: 0x0047FD9C
	private static void CopyUidClick()
	{
		GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
	}

	// Token: 0x060124CD RID: 74957 RVA: 0x00481BDA File Offset: 0x0047FDDA
	private static void ChangeHeadIcon()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.HeadPhoto, null);
	}

	// Token: 0x060124CE RID: 74958 RVA: 0x00481BF2 File Offset: 0x0047FDF2
	private static void ChangeCard()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.Card, null);
	}

	// Token: 0x060124CF RID: 74959 RVA: 0x00481C0A File Offset: 0x0047FE0A
	private static void ChangePlayerTitle()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.PlayerTitle, null);
	}

	// Token: 0x060124D0 RID: 74960 RVA: 0x00481C22 File Offset: 0x0047FE22
	private static void OpenPersonalRootView()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalRootView, PersonalModel.Instance.GetPersonalInfoData(), null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x060124D1 RID: 74961 RVA: 0x00481C4E File Offset: 0x0047FE4E
	private static void OpenFeedBackMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x060124D2 RID: 74962 RVA: 0x00481C71 File Offset: 0x0047FE71
	private static void ChangeName()
	{
		CommonInputViewController.Instance.OpenSetRoleNameInputView();
	}

	// Token: 0x060124D3 RID: 74963 RVA: 0x00481C7D File Offset: 0x0047FE7D
	private static void ChangeSign()
	{
		CommonInputViewController.Instance.OpenPersonalSignInputView();
	}

	// Token: 0x060124D4 RID: 74964 RVA: 0x00481C89 File Offset: 0x0047FE89
	private static void SetBirth()
	{
		if (!FunctionModel.Instance.IsOpen(10084))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BirthdaySet_OpenCondition_Tips", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PersonalBirthView, null, null);
	}

	// Token: 0x060124D5 RID: 74965 RVA: 0x00481CC2 File Offset: 0x0047FEC2
	private static void LookCard()
	{
		PersonalOptionController.CheckOpenLookCardView().Forget();
	}

	// Token: 0x060124D6 RID: 74966 RVA: 0x00481CD0 File Offset: 0x0047FED0
	private static UniTask CheckOpenLookCardView()
	{
		PersonalOptionController.<CheckOpenLookCardView>d__18 <CheckOpenLookCardView>d__;
		<CheckOpenLookCardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckOpenLookCardView>d__.<>1__state = -1;
		<CheckOpenLookCardView>d__.<>t__builder.Start<PersonalOptionController.<CheckOpenLookCardView>d__18>(ref <CheckOpenLookCardView>d__);
		return <CheckOpenLookCardView>d__.<>t__builder.Task;
	}

	// Token: 0x060124D7 RID: 74967 RVA: 0x00481D0B File Offset: 0x0047FF0B
	private static void ChangeRemark()
	{
		CommonInputViewController.Instance.OpenSetPlayerRemarkNameInputView();
	}

	// Token: 0x060124D8 RID: 74968 RVA: 0x00481D18 File Offset: 0x0047FF18
	public PersonalInfoData GetPersonalData()
	{
		PersonalInfoData personalInfoData = new PersonalInfoData();
		FriendData selectedPlayerOrItemInstance = FriendModel.Instance.GetSelectedPlayerOrItemInstance(null, null);
		if (selectedPlayerOrItemInstance != null)
		{
			personalInfoData.RoleShowList = selectedPlayerOrItemInstance.RoleShowList;
			personalInfoData.CardShowList = selectedPlayerOrItemInstance.CardShowList;
			personalInfoData.CurCardId = new int?(selectedPlayerOrItemInstance.CurCard);
			personalInfoData.Birthday = selectedPlayerOrItemInstance.Birthday;
			personalInfoData.IsBirthdayDisplay = selectedPlayerOrItemInstance.IsBirthdayDisplay;
			personalInfoData.CardDataList = selectedPlayerOrItemInstance.CardUnlockList;
			personalInfoData.Signature = selectedPlayerOrItemInstance.Signature;
			personalInfoData.HeadPhotoId = new int?(selectedPlayerOrItemInstance.PlayerHeadPhoto);
			personalInfoData.IsOtherData = true;
			personalInfoData.Name = selectedPlayerOrItemInstance.PlayerName;
			personalInfoData.PlayerId = selectedPlayerOrItemInstance.PlayerId;
			personalInfoData.Level = selectedPlayerOrItemInstance.PlayerLevel;
			personalInfoData.WorldLevel = selectedPlayerOrItemInstance.WorldLevel;
			personalInfoData.CurPlayerTitleId = new int?(selectedPlayerOrItemInstance.PlayerTitleId);
			personalInfoData.CurPlayerTitleLevel = new int?(selectedPlayerOrItemInstance.PlayerTitleStarLevel);
			personalInfoData.Sex = selectedPlayerOrItemInstance.PlayerSex;
			personalInfoData.ThirdUserId = selectedPlayerOrItemInstance.GetSdkUserId();
			personalInfoData.ThirdOnlineId = selectedPlayerOrItemInstance.GetSdkOnlineId();
		}
		else
		{
			PlayerDetails playerDetails = OnlineModel.Instance.CachePlayerData.PlayerDetails;
			List<global::RoleShowEntry> list = new List<global::RoleShowEntry>();
			foreach (Aki.Protocol.RoleShowEntry roleShowEntry in playerDetails.RoleShowList)
			{
				global::RoleShowEntry item = new global::RoleShowEntry(roleShowEntry.RoleId, roleShowEntry.Level);
				list.Add(item);
			}
			personalInfoData.RoleShowList = list;
			personalInfoData.CardShowList = playerDetails.CardShowList.ToList<int>();
			personalInfoData.CurCardId = new int?(playerDetails.CurCard);
			personalInfoData.Birthday = playerDetails.Birthday;
			personalInfoData.IsBirthdayDisplay = playerDetails.DisplayBirthday;
			personalInfoData.CardDataList = OnlineModel.Instance.CachePlayerData.CardUnlockList;
			personalInfoData.Signature = (playerDetails.Signature ?? "");
			personalInfoData.HeadPhotoId = new int?(playerDetails.HeadId);
			personalInfoData.IsOtherData = true;
			personalInfoData.Name = (playerDetails.Name ?? "");
			personalInfoData.PlayerId = playerDetails.PlayerId;
			personalInfoData.Level = playerDetails.Level;
			personalInfoData.WorldLevel = playerDetails.CurWorldLevel;
			string thirdUserId = Info.Instance.IsPs5Platform() ? playerDetails.PsnUserId : playerDetails.XboxUserId;
			personalInfoData.ThirdUserId = thirdUserId;
			string thirdOnlineId = Info.Instance.IsPs5Platform() ? playerDetails.PsnOnlineId : playerDetails.XboxOnlineId;
			personalInfoData.ThirdOnlineId = thirdOnlineId;
			personalInfoData.CurPlayerTitleId = new int?(playerDetails.PlayerTitleId);
			personalInfoData.CurPlayerTitleLevel = new int?(playerDetails.PlayerTitleExtraParam);
			personalInfoData.Sex = playerDetails.Sex;
		}
		return personalInfoData;
	}

	// Token: 0x170017C8 RID: 6088
	// (get) Token: 0x060124D9 RID: 74969 RVA: 0x00481FF8 File Offset: 0x004801F8
	public static PersonalOptionController Instance
	{
		get
		{
			return PersonalOptionController._Instance;
		}
	}

	// Token: 0x060124DA RID: 74970 RVA: 0x00481FFF File Offset: 0x004801FF
	public static PersonalOptionController GetOrCreateInstance()
	{
		if (PersonalOptionController._Instance == null)
		{
			PersonalOptionController.CreateInstance();
		}
		return PersonalOptionController._Instance;
	}

	// Token: 0x060124DB RID: 74971 RVA: 0x00482013 File Offset: 0x00480213
	public static bool CreateInstance()
	{
		if (PersonalOptionController._Instance != null)
		{
			return true;
		}
		PersonalOptionController._Instance = new PersonalOptionController();
		return true;
	}

	// Token: 0x060124DC RID: 74972 RVA: 0x00482029 File Offset: 0x00480229
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060124DD RID: 74973 RVA: 0x0048202B File Offset: 0x0048022B
	public static void ResetStaticDefaultValue()
	{
		PersonalOptionController._Instance = null;
	}

	// Token: 0x060124DE RID: 74974 RVA: 0x00482033 File Offset: 0x00480233
	static PersonalOptionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalOptionController.CreateStaticDefaultValue), new Action(PersonalOptionController.ResetStaticDefaultValue));
	}

	// Token: 0x04008A43 RID: 35395
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Action> OptionMap;

	// Token: 0x04008A44 RID: 35396
	[Nullable(2)]
	private static PersonalOptionController _Instance;

	// Token: 0x02008966 RID: 35174
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402CA70 RID: 182896
		[Nullable(0)]
		public static Action <0>__OnClickShieldBtn;

		// Token: 0x0402CA71 RID: 182897
		[Nullable(0)]
		public static Action <1>__OnClickBlockBtn;

		// Token: 0x0402CA72 RID: 182898
		[Nullable(0)]
		public static Action <2>__OnClickDeleteBtn;

		// Token: 0x0402CA73 RID: 182899
		[Nullable(0)]
		public static Action <3>__OnClickReportBtn;

		// Token: 0x0402CA74 RID: 182900
		[Nullable(0)]
		public static Action <4>__CopyUidClick;

		// Token: 0x0402CA75 RID: 182901
		[Nullable(0)]
		public static Action <5>__ChangeHeadIcon;

		// Token: 0x0402CA76 RID: 182902
		[Nullable(0)]
		public static Action <6>__ChangeCard;

		// Token: 0x0402CA77 RID: 182903
		[Nullable(0)]
		public static Action <7>__ChangeName;

		// Token: 0x0402CA78 RID: 182904
		[Nullable(0)]
		public static Action <8>__ChangeSign;

		// Token: 0x0402CA79 RID: 182905
		[Nullable(0)]
		public static Action <9>__SetBirth;

		// Token: 0x0402CA7A RID: 182906
		[Nullable(0)]
		public static Action <10>__LookCard;

		// Token: 0x0402CA7B RID: 182907
		[Nullable(0)]
		public static Action <11>__ChangeRemark;

		// Token: 0x0402CA7C RID: 182908
		[Nullable(0)]
		public static Action <12>__ChangePlayerTitle;

		// Token: 0x0402CA7D RID: 182909
		[Nullable(0)]
		public static Action <13>__OpenPersonalRootView;

		// Token: 0x0402CA7E RID: 182910
		[Nullable(0)]
		public static Action <14>__OpenFeedBackMainView;
	}
}
