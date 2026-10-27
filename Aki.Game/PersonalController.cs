using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extensions;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020023B2 RID: 9138
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PersonalController : UiControllerBase
{
	// Token: 0x0601247F RID: 74879 RVA: 0x004809FC File Offset: 0x0047EBFC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.PlayerTitleRequest));
		EventSystem.Instance.Add(EEventName.BattleViewActiveSequenceFinish, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleUnlock, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsSyncHeadInfo, new Action<FArrayBuffer>(this.TsSyncHeadInfo));
	}

	// Token: 0x06012480 RID: 74880 RVA: 0x00480AB4 File Offset: 0x0047ECB4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.PlayerTitleRequest));
		EventSystem.Instance.Remove(EEventName.BattleViewActiveSequenceFinish, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleUnlock, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Remove(EEventName.TsSyncHeadInfo, new Action<FArrayBuffer>(this.TsSyncHeadInfo));
	}

	// Token: 0x06012481 RID: 74881 RVA: 0x00480B69 File Offset: 0x0047ED69
	private void OnLoadingNetDataDone()
	{
		this.PlayerHeadRequest();
	}

	// Token: 0x06012482 RID: 74882 RVA: 0x00480B74 File Offset: 0x0047ED74
	private void PlayerHeadRequest()
	{
		PlayerHeadRequest message = Aki.Protocol.PlayerHeadRequest.Create();
		Net.Instance.Call(ERequestMessageId.PlayerHeadRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerHeadResponse playerHeadResponse = (PlayerHeadResponse)msg;
			if (playerHeadResponse == null)
			{
				return;
			}
			PersonalModel.Instance.InitPlayerHeadData(playerHeadResponse.PlayerHeadIds.ToArray<int>());
		}, 0);
	}

	// Token: 0x06012483 RID: 74883 RVA: 0x00480BB8 File Offset: 0x0047EDB8
	public void SendBirthdayInitRequest(int birthday)
	{
		BirthdayInitRequest birthdayInitRequest = BirthdayInitRequest.Create();
		birthdayInitRequest.Birthday = birthday;
		Net.Instance.Call(ERequestMessageId.BirthdayInitRequest, birthdayInitRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthdayInitResponse birthdayInitResponse = (BirthdayInitResponse)msg;
			if (birthdayInitResponse == null)
			{
				return;
			}
			if (birthdayInitResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.SetBirthday(birthday);
				BirthdayModel.Instance.ResetBirthday();
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(birthdayInitResponse.ErrorCode, 23451, null, true, true);
		}, 0);
	}

	// Token: 0x06012484 RID: 74884 RVA: 0x00480C04 File Offset: 0x0047EE04
	public void SendBirthdayShowSetRequest(bool display)
	{
		BirthdayShowSetRequest birthdayShowSetRequest = BirthdayShowSetRequest.Create();
		birthdayShowSetRequest.DisPlay = display;
		Net.Instance.Call(ERequestMessageId.BirthdayShowSetRequest, birthdayShowSetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BirthdayShowSetResponse birthdayShowSetResponse = (BirthdayShowSetResponse)msg;
			if (birthdayShowSetResponse == null)
			{
				return;
			}
			if (birthdayShowSetResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.SetBirthdayDisplay(display);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(birthdayShowSetResponse.ErrorCode, 19338, null, true, true);
		}, 0);
	}

	// Token: 0x06012485 RID: 74885 RVA: 0x00480C50 File Offset: 0x0047EE50
	public void SendRoleShowListUpdateRequest(List<int> roleList)
	{
		RoleShowListUpdateRequest roleShowListUpdateRequest = RoleShowListUpdateRequest.Create();
		roleShowListUpdateRequest.RoleList.AddRange(roleList);
		Net.Instance.Call(ERequestMessageId.RoleShowListUpdateRequest, roleShowListUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleShowListUpdateResponse roleShowListUpdateResponse = (RoleShowListUpdateResponse)msg;
			if (roleShowListUpdateResponse == null)
			{
				return;
			}
			if (roleShowListUpdateResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.UpdateRoleShowList(roleList.ToArray());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleShowListUpdateResponse.ErrorCode, 21892, null, true, true);
		}, 0);
	}

	// Token: 0x06012486 RID: 74886 RVA: 0x00480CA0 File Offset: 0x0047EEA0
	[NullableContext(0)]
	public UniTask<bool> SendRoleShowListUpdateRequestAsync([Nullable(1)] List<int> roleList)
	{
		PersonalController.<SendRoleShowListUpdateRequestAsync>d__7 <SendRoleShowListUpdateRequestAsync>d__;
		<SendRoleShowListUpdateRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendRoleShowListUpdateRequestAsync>d__.roleList = roleList;
		<SendRoleShowListUpdateRequestAsync>d__.<>1__state = -1;
		<SendRoleShowListUpdateRequestAsync>d__.<>t__builder.Start<PersonalController.<SendRoleShowListUpdateRequestAsync>d__7>(ref <SendRoleShowListUpdateRequestAsync>d__);
		return <SendRoleShowListUpdateRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012487 RID: 74887 RVA: 0x00480CE4 File Offset: 0x0047EEE4
	public void SendChangeCardRequest(int cardId)
	{
		ChangeCardRequest changeCardRequest = ChangeCardRequest.Create();
		changeCardRequest.CardId = cardId;
		Net.Instance.Call(ERequestMessageId.ChangeCardRequest, changeCardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ChangeCardResponse changeCardResponse = (ChangeCardResponse)msg;
			if (changeCardResponse == null)
			{
				return;
			}
			if (changeCardResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.SetCurCardId(cardId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(changeCardResponse.ErrorCode, 28852, null, true, true);
		}, 0);
	}

	// Token: 0x06012488 RID: 74888 RVA: 0x00480D30 File Offset: 0x0047EF30
	public void SendReadCardRequest(int cardId)
	{
		ReadCardRequest readCardRequest = ReadCardRequest.Create();
		readCardRequest.CardId = cardId;
		Net.Instance.Call(ERequestMessageId.ReadCardRequest, readCardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ReadCardResponse readCardResponse = (ReadCardResponse)msg;
			if (readCardResponse == null)
			{
				return;
			}
			if (readCardResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.UpdateCardUnlockList(cardId, true);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(readCardResponse.ErrorCode, 25329, null, true, true);
		}, 0);
	}

	// Token: 0x06012489 RID: 74889 RVA: 0x00480D7C File Offset: 0x0047EF7C
	public void SendModifySignatureRequest(string sign)
	{
		ModifySignatureRequest modifySignatureRequest = ModifySignatureRequest.Create();
		modifySignatureRequest.Signature = sign;
		Net.Instance.Call(ERequestMessageId.ModifySignatureRequest, modifySignatureRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ModifySignatureResponse modifySignatureResponse = (ModifySignatureResponse)msg;
			if (modifySignatureResponse == null)
			{
				return;
			}
			if (modifySignatureResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.SetSignature(sign);
				return;
			}
			if (modifySignatureResponse.ErrorCode == ErrorCode.ContainsDirtyWord || modifySignatureResponse.ErrorCode == ErrorCode.ErrRoleInvalidNameLength)
			{
				ScrollingTipsController.Instance.ShowTipsById("NotElegantName", Array.Empty<object>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(modifySignatureResponse.ErrorCode, 19625, null, true, true);
		}, 0);
	}

	// Token: 0x0601248A RID: 74890 RVA: 0x00480DC8 File Offset: 0x0047EFC8
	[NullableContext(0)]
	public UniTask<ErrorCode> RequestModifySignature([Nullable(1)] string sign)
	{
		PersonalController.<RequestModifySignature>d__11 <RequestModifySignature>d__;
		<RequestModifySignature>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<RequestModifySignature>d__.sign = sign;
		<RequestModifySignature>d__.<>1__state = -1;
		<RequestModifySignature>d__.<>t__builder.Start<PersonalController.<RequestModifySignature>d__11>(ref <RequestModifySignature>d__);
		return <RequestModifySignature>d__.<>t__builder.Task;
	}

	// Token: 0x0601248B RID: 74891 RVA: 0x00480E0C File Offset: 0x0047F00C
	public void SendChangeHeadPhotoRequest(int headPhotoId)
	{
		ChangeHeadPhotoRequest changeHeadPhotoRequest = ChangeHeadPhotoRequest.Create();
		changeHeadPhotoRequest.HeadPhotoId = headPhotoId;
		Net.Instance.Call(ERequestMessageId.ChangeHeadPhotoRequest, changeHeadPhotoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ChangeHeadPhotoResponse changeHeadPhotoResponse = (ChangeHeadPhotoResponse)msg;
			if (changeHeadPhotoResponse == null)
			{
				return;
			}
			if (changeHeadPhotoResponse.ErrorCode == ErrorCode.Success)
			{
				PersonalModel.Instance.SetHeadPhotoId(headPhotoId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(changeHeadPhotoResponse.ErrorCode, 20433, null, true, true);
		}, 0);
	}

	// Token: 0x0601248C RID: 74892 RVA: 0x00480E58 File Offset: 0x0047F058
	[NullableContext(0)]
	public UniTask<ErrorCode> RequestModifyName([Nullable(1)] string name)
	{
		PersonalController.<RequestModifyName>d__13 <RequestModifyName>d__;
		<RequestModifyName>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<RequestModifyName>d__.name = name;
		<RequestModifyName>d__.<>1__state = -1;
		<RequestModifyName>d__.<>t__builder.Start<PersonalController.<RequestModifyName>d__13>(ref <RequestModifyName>d__);
		return <RequestModifyName>d__.<>t__builder.Task;
	}

	// Token: 0x0601248D RID: 74893 RVA: 0x00480E9B File Offset: 0x0047F09B
	public bool CheckCardIsUsing(int cardId)
	{
		return PersonalModel.Instance.GetCurCardId() == cardId;
	}

	// Token: 0x0601248E RID: 74894 RVA: 0x00480EAC File Offset: 0x0047F0AC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.UnlockCardNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			UnlockCardNotify unlockCardNotify = (UnlockCardNotify)msg;
			PersonalModel.Instance.AddCardUnlockList(unlockCardNotify.CardId, false);
		});
		Net.Instance.Register(ENotifyMessageId.HeadIdUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			HeadIdUpdateNotify headIdUpdateNotify = (HeadIdUpdateNotify)msg;
			PersonalModel.Instance.SetHeadPhotoId(headIdUpdateNotify.HeadId);
		});
		Net.Instance.Register(ENotifyMessageId.RoleShowListUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleShowListUpdateNotify roleShowListUpdateNotify = (RoleShowListUpdateNotify)msg;
			PersonalModel.Instance.SetRoleShowList(roleShowListUpdateNotify.RoleShowList.ToList<Aki.Protocol.RoleShowEntry>());
		});
		Net.Instance.Register(ENotifyMessageId.SignatureUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SignatureUpdateNotify signatureUpdateNotify = (SignatureUpdateNotify)msg;
			PersonalModel.Instance.SetSignature(signatureUpdateNotify.Signature);
		});
		Net.Instance.Register(ENotifyMessageId.NameModifyNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NameModifyNotify nameModifyNotify = (NameModifyNotify)msg;
			PlayerInfoModel.Instance.SetPlayerName(nameModifyNotify.Name);
			PersonalModel.Instance.SetModifyNameInfo(nameModifyNotify.LastModifyNameTime, string.Empty);
		});
		Net.Instance.Register(ENotifyMessageId.PlayerHeadAddNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerHeadAddNotify playerHeadAddNotify = (PlayerHeadAddNotify)msg;
			PersonalModel.Instance.UpdatePlayerHeadData(playerHeadAddNotify.AddPlayerHeadIds.ToArray<int>());
		});
		Net.Instance.Register(ENotifyMessageId.DressPlayerTitleUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DressPlayerTitleUpdateNotify dressPlayerTitleUpdateNotify = (DressPlayerTitleUpdateNotify)msg;
			PersonalModel.Instance.SetDressedPlayerTitle(dressPlayerTitleUpdateNotify.PlayerTitleId, new int?(dressPlayerTitleUpdateNotify.PlayerTitleExtraParam));
		});
		Net.Instance.Register(ENotifyMessageId.PlayerTitleUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerTitleUpdateNotify playerTitleUpdateNotify = (PlayerTitleUpdateNotify)msg;
			PersonalModel.Instance.UpdateUnDressedPlayerTitleList(playerTitleUpdateNotify.PlayerTitleInfos.ToArray<PlayerTitleInfo>());
		});
		Net.Instance.Register(ENotifyMessageId.PlayerTitleInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerTitleInfoUpdateNotify playerTitleInfoUpdateNotify = (PlayerTitleInfoUpdateNotify)msg;
			PersonalModel.Instance.InitPlayerTitleData(playerTitleInfoUpdateNotify.PlayerTitleInfo.ToArray<PlayerTitleInfo>(), playerTitleInfoUpdateNotify.PlayerTitleLimitInfos.ToArray<PlayerTitleLimitInfo>());
		});
	}

	// Token: 0x0601248F RID: 74895 RVA: 0x00481060 File Offset: 0x0047F260
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.UnlockCardNotify);
		Net.Instance.UnRegister(ENotifyMessageId.HeadIdUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleShowListUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SignatureUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NameModifyNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerHeadAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.DressPlayerTitleUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerTitleUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PlayerTitleInfoUpdateNotify);
	}

	// Token: 0x06012490 RID: 74896 RVA: 0x004810FD File Offset: 0x0047F2FD
	private void OnFunctionOpenSet(EFunctionType id, bool isOpen)
	{
		this.PlayerTitleRequest(id, isOpen);
	}

	// Token: 0x06012491 RID: 74897 RVA: 0x00481108 File Offset: 0x0047F308
	private void PlayerTitleRequest(EFunctionType id, bool isOpen)
	{
		if (id != EFunctionType.PlayerTitle)
		{
			return;
		}
		if (!isOpen)
		{
			return;
		}
		PlayerTitleRequest message = Aki.Protocol.PlayerTitleRequest.Create();
		Net.Instance.Call(ERequestMessageId.PlayerTitleRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerTitleResponse playerTitleResponse = (PlayerTitleResponse)msg;
			if (playerTitleResponse == null)
			{
				return;
			}
			PersonalModel.Instance.InitPlayerTitleData(playerTitleResponse.PlayerTitleInfo.ToArray<PlayerTitleInfo>(), playerTitleResponse.PlayerTitleLimitInfos.ToArray<PlayerTitleLimitInfo>());
		}, 0);
	}

	// Token: 0x06012492 RID: 74898 RVA: 0x00481158 File Offset: 0x0047F358
	public void SendChangePlayerTitleRequest(int playerTitleId)
	{
		ChangePlayerTitleRequest changePlayerTitleRequest = ChangePlayerTitleRequest.Create();
		changePlayerTitleRequest.PlayerTitleId = playerTitleId;
		Net.Instance.Call(ERequestMessageId.ChangePlayerTitleRequest, changePlayerTitleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ChangePlayerTitleResponse changePlayerTitleResponse = (ChangePlayerTitleResponse)msg;
			if (changePlayerTitleResponse == null)
			{
				return;
			}
			if (changePlayerTitleResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(changePlayerTitleResponse.ErrorCode, 21696, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06012493 RID: 74899 RVA: 0x004811A2 File Offset: 0x0047F3A2
	private void ShowTitleGetView()
	{
		this.TryOpenTitleGetView();
	}

	// Token: 0x06012494 RID: 74900 RVA: 0x004811AC File Offset: 0x0047F3AC
	public void TryOpenTitleGetView()
	{
		List<PersonalPlayerTitleData> currentNewUnLockTitleArray = PersonalModel.Instance.CurrentNewUnLockTitleArray;
		while (currentNewUnLockTitleArray.Count > 0)
		{
			PersonalPlayerTitleData param = currentNewUnLockTitleArray[0];
			currentNewUnLockTitleArray.RemoveAt(0);
			UiManager.Instance.OpenView(EUiViewName.PersonalPlayerTitleUnLockTipsView, param, null);
		}
	}

	// Token: 0x06012495 RID: 74901 RVA: 0x004811F0 File Offset: 0x0047F3F0
	private void TsSyncHeadInfo(FArrayBuffer buffer)
	{
		PlayerHeadResponse playerHeadResponse = new PlayerHeadResponse();
		playerHeadResponse.MergeFrom(buffer.ToByteArray());
		if (playerHeadResponse == null)
		{
			return;
		}
		PersonalModel.Instance.InitPlayerHeadData(playerHeadResponse.PlayerHeadIds.ToArray<int>());
	}

	// Token: 0x170017BE RID: 6078
	// (get) Token: 0x06012496 RID: 74902 RVA: 0x00481228 File Offset: 0x0047F428
	public static PersonalController Instance
	{
		get
		{
			return PersonalController._Instance;
		}
	}

	// Token: 0x06012497 RID: 74903 RVA: 0x0048122F File Offset: 0x0047F42F
	public static PersonalController GetOrCreateInstance()
	{
		if (PersonalController._Instance == null)
		{
			PersonalController.CreateInstance();
		}
		return PersonalController._Instance;
	}

	// Token: 0x06012498 RID: 74904 RVA: 0x00481243 File Offset: 0x0047F443
	public static bool CreateInstance()
	{
		if (PersonalController._Instance != null)
		{
			return true;
		}
		PersonalController._Instance = new PersonalController();
		return true;
	}

	// Token: 0x06012499 RID: 74905 RVA: 0x00481259 File Offset: 0x0047F459
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601249A RID: 74906 RVA: 0x0048125B File Offset: 0x0047F45B
	public static void ResetStaticDefaultValue()
	{
		PersonalController._Instance = null;
	}

	// Token: 0x0601249B RID: 74907 RVA: 0x00481263 File Offset: 0x0047F463
	static PersonalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalController.CreateStaticDefaultValue), new Action(PersonalController.ResetStaticDefaultValue));
	}

	// Token: 0x040089F6 RID: 35318
	[Nullable(2)]
	private static PersonalController _Instance;
}
