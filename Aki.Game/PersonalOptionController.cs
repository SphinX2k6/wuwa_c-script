using System;
using System.Collections.Generic;
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

// Token: 0x020018A5 RID: 6309
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PersonalOptionController : UiControllerBase
{
	// Token: 0x0600F977 RID: 63863 RVA: 0x0048EB90 File Offset: 0x0048CD90
	public PersonalOptionController()
	{
		this.InitOptionMap();
	}

	// Token: 0x0600F978 RID: 63864 RVA: 0x0048EBA0 File Offset: 0x0048CDA0
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

	// Token: 0x0600F979 RID: 63865 RVA: 0x0048EE40 File Offset: 0x0048D040
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

	// Token: 0x0600F97A RID: 63866 RVA: 0x0048EE70 File Offset: 0x0048D070
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

	// Token: 0x0600F97B RID: 63867 RVA: 0x0048EF08 File Offset: 0x0048D108
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

	// Token: 0x0600F97C RID: 63868 RVA: 0x0048EF50 File Offset: 0x0048D150
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

	// Token: 0x0600F97D RID: 63869 RVA: 0x0048F014 File Offset: 0x0048D214
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

	// Token: 0x0600F97E RID: 63870 RVA: 0x0048F080 File Offset: 0x0048D280
	private static void CopyUidClick()
	{
		GenericPromptController.Instance.ShowPromptByCode("CopiedMyUid", Array.Empty<object>());
		ULGUIBPLibrary.ClipBoardCopy(PlayerInfoModel.Instance.GetId().ToString());
	}

	// Token: 0x0600F97F RID: 63871 RVA: 0x0048F0BE File Offset: 0x0048D2BE
	private static void ChangeHeadIcon()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.HeadPhoto, null);
	}

	// Token: 0x0600F980 RID: 63872 RVA: 0x0048F0D6 File Offset: 0x0048D2D6
	private static void ChangeCard()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.Card, null);
	}

	// Token: 0x0600F981 RID: 63873 RVA: 0x0048F0EE File Offset: 0x0048D2EE
	private static void ChangePlayerTitle()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalEditView, EPersonalEditDefine.PlayerTitle, null);
	}

	// Token: 0x0600F982 RID: 63874 RVA: 0x0048F106 File Offset: 0x0048D306
	private static void OpenPersonalRootView()
	{
		UiManager.Instance.OpenView(EUiViewName.PersonalRootView, PersonalModel.Instance.GetPersonalInfoData(), null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x0600F983 RID: 63875 RVA: 0x0048F132 File Offset: 0x0048D332
	private static void OpenFeedBackMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
		UiManager.Instance.CloseView(EUiViewName.PersonalOptionView, null);
	}

	// Token: 0x0600F984 RID: 63876 RVA: 0x0048F155 File Offset: 0x0048D355
	private static void ChangeName()
	{
		CommonInputViewController.Instance.OpenSetRoleNameInputView();
	}

	// Token: 0x0600F985 RID: 63877 RVA: 0x0048F161 File Offset: 0x0048D361
	private static void ChangeSign()
	{
		CommonInputViewController.Instance.OpenPersonalSignInputView();
	}

	// Token: 0x0600F986 RID: 63878 RVA: 0x0048F16D File Offset: 0x0048D36D
	private static void SetBirth()
	{
		if (!FunctionModel.Instance.IsOpen(10084))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BirthdaySet_OpenCondition_Tips", Array.Empty<object>());
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.PersonalBirthView, null, null);
	}

	// Token: 0x0600F987 RID: 63879 RVA: 0x0048F1A6 File Offset: 0x0048D3A6
	private static void LookCard()
	{
		PersonalOptionController.CheckOpenLookCardView().Forget();
	}

	// Token: 0x0600F988 RID: 63880 RVA: 0x0048F1B4 File Offset: 0x0048D3B4
	private static UniTask CheckOpenLookCardView()
	{
		PersonalOptionController.<CheckOpenLookCardView>d__18 <CheckOpenLookCardView>d__;
		<CheckOpenLookCardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckOpenLookCardView>d__.<>1__state = -1;
		<CheckOpenLookCardView>d__.<>t__builder.Start<PersonalOptionController.<CheckOpenLookCardView>d__18>(ref <CheckOpenLookCardView>d__);
		return <CheckOpenLookCardView>d__.<>t__builder.Task;
	}

	// Token: 0x0600F989 RID: 63881 RVA: 0x0048F1EF File Offset: 0x0048D3EF
	private static void ChangeRemark()
	{
		CommonInputViewController.Instance.OpenSetPlayerRemarkNameInputView();
	}

	// Token: 0x0600F98A RID: 63882 RVA: 0x0048F1FC File Offset: 0x0048D3FC
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
			personalInfoData.CardShowList = new List<int>(playerDetails.CardShowList);
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

	// Token: 0x17001802 RID: 6146
	// (get) Token: 0x0600F98B RID: 63883 RVA: 0x0048F4DC File Offset: 0x0048D6DC
	public static PersonalOptionController Instance
	{
		get
		{
			return PersonalOptionController._Instance;
		}
	}

	// Token: 0x0600F98C RID: 63884 RVA: 0x0048F4E3 File Offset: 0x0048D6E3
	public static PersonalOptionController GetOrCreateInstance()
	{
		if (PersonalOptionController._Instance == null)
		{
			PersonalOptionController.CreateInstance();
		}
		return PersonalOptionController._Instance;
	}

	// Token: 0x0600F98D RID: 63885 RVA: 0x0048F4F7 File Offset: 0x0048D6F7
	public static bool CreateInstance()
	{
		if (PersonalOptionController._Instance != null)
		{
			return true;
		}
		PersonalOptionController._Instance = new PersonalOptionController();
		return true;
	}

	// Token: 0x0600F98E RID: 63886 RVA: 0x0048F50D File Offset: 0x0048D70D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F98F RID: 63887 RVA: 0x0048F50F File Offset: 0x0048D70F
	public static void ResetStaticDefaultValue()
	{
		PersonalOptionController._Instance = null;
	}

	// Token: 0x0600F990 RID: 63888 RVA: 0x0048F517 File Offset: 0x0048D717
	static PersonalOptionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalOptionController.CreateStaticDefaultValue), new Action(PersonalOptionController.ResetStaticDefaultValue));
	}

	// Token: 0x04008B8A RID: 35722
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, Action> OptionMap;

	// Token: 0x04008B8B RID: 35723
	[Nullable(2)]
	private static PersonalOptionController _Instance;

	// Token: 0x02007AEF RID: 31471
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04027D8B RID: 163211
		[Nullable(0)]
		public static Action <0>__OnClickShieldBtn;

		// Token: 0x04027D8C RID: 163212
		[Nullable(0)]
		public static Action <1>__OnClickBlockBtn;

		// Token: 0x04027D8D RID: 163213
		[Nullable(0)]
		public static Action <2>__OnClickDeleteBtn;

		// Token: 0x04027D8E RID: 163214
		[Nullable(0)]
		public static Action <3>__OnClickReportBtn;

		// Token: 0x04027D8F RID: 163215
		[Nullable(0)]
		public static Action <4>__CopyUidClick;

		// Token: 0x04027D90 RID: 163216
		[Nullable(0)]
		public static Action <5>__ChangeHeadIcon;

		// Token: 0x04027D91 RID: 163217
		[Nullable(0)]
		public static Action <6>__ChangeCard;

		// Token: 0x04027D92 RID: 163218
		[Nullable(0)]
		public static Action <7>__ChangeName;

		// Token: 0x04027D93 RID: 163219
		[Nullable(0)]
		public static Action <8>__ChangeSign;

		// Token: 0x04027D94 RID: 163220
		[Nullable(0)]
		public static Action <9>__SetBirth;

		// Token: 0x04027D95 RID: 163221
		[Nullable(0)]
		public static Action <10>__LookCard;

		// Token: 0x04027D96 RID: 163222
		[Nullable(0)]
		public static Action <11>__ChangeRemark;

		// Token: 0x04027D97 RID: 163223
		[Nullable(0)]
		public static Action <12>__ChangePlayerTitle;

		// Token: 0x04027D98 RID: 163224
		[Nullable(0)]
		public static Action <13>__OpenPersonalRootView;

		// Token: 0x04027D99 RID: 163225
		[Nullable(0)]
		public static Action <14>__OpenFeedBackMainView;
	}
}
