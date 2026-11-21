using System;
using System.Collections.Generic;
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

// Token: 0x02001897 RID: 6295
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PersonalController : UiControllerBase
{
	// Token: 0x0600F931 RID: 63793 RVA: 0x0048DED0 File Offset: 0x0048C0D0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.PlayerTitleRequest));
		EventSystem.Instance.Add(EEventName.BattleViewActiveSequenceFinish, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Add(EEventName.OnPlayerTitleUnlock, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Add<FArrayBuffer>(EEventName.TsSyncHeadInfo, new Action<FArrayBuffer>(this.TsSyncHeadInfo));
	}

	// Token: 0x0600F932 RID: 63794 RVA: 0x0048DF88 File Offset: 0x0048C188
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.PlayerTitleRequest));
		EventSystem.Instance.Remove(EEventName.BattleViewActiveSequenceFinish, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Remove(EEventName.OnPlayerTitleUnlock, new Action(this.ShowTitleGetView));
		EventSystem.Instance.Remove(EEventName.TsSyncHeadInfo, new Action<FArrayBuffer>(this.TsSyncHeadInfo));
	}

	// Token: 0x0600F933 RID: 63795 RVA: 0x0048E03D File Offset: 0x0048C23D
	private void OnLoadingNetDataDone()
	{
		this.PlayerHeadRequest();
	}

	// Token: 0x0600F934 RID: 63796 RVA: 0x0048E048 File Offset: 0x0048C248
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
			int[] array = new int[playerHeadResponse.PlayerHeadIds.Count];
			playerHeadResponse.PlayerHeadIds.CopyTo(array, 0);
			PersonalModel.Instance.InitPlayerHeadData(array);
		}, 0);
	}

	// Token: 0x0600F935 RID: 63797 RVA: 0x0048E08C File Offset: 0x0048C28C
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(birthdayInitResponse.ErrorCode, 29356, null, true, true);
		}, 0);
	}

	// Token: 0x0600F936 RID: 63798 RVA: 0x0048E0D8 File Offset: 0x0048C2D8
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(birthdayShowSetResponse.ErrorCode, 29672, null, true, true);
		}, 0);
	}

	// Token: 0x0600F937 RID: 63799 RVA: 0x0048E124 File Offset: 0x0048C324
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleShowListUpdateResponse.ErrorCode, 23280, null, true, true);
		}, 0);
	}

	// Token: 0x0600F938 RID: 63800 RVA: 0x0048E174 File Offset: 0x0048C374
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

	// Token: 0x0600F939 RID: 63801 RVA: 0x0048E1B8 File Offset: 0x0048C3B8
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(changeCardResponse.ErrorCode, 29040, null, true, true);
		}, 0);
	}

	// Token: 0x0600F93A RID: 63802 RVA: 0x0048E204 File Offset: 0x0048C404
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(readCardResponse.ErrorCode, 19779, null, true, true);
		}, 0);
	}

	// Token: 0x0600F93B RID: 63803 RVA: 0x0048E250 File Offset: 0x0048C450
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(modifySignatureResponse.ErrorCode, 18895, null, true, true);
		}, 0);
	}

	// Token: 0x0600F93C RID: 63804 RVA: 0x0048E29C File Offset: 0x0048C49C
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

	// Token: 0x0600F93D RID: 63805 RVA: 0x0048E2E0 File Offset: 0x0048C4E0
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(changeHeadPhotoResponse.ErrorCode, 28817, null, true, true);
		}, 0);
	}

	// Token: 0x0600F93E RID: 63806 RVA: 0x0048E32C File Offset: 0x0048C52C
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

	// Token: 0x0600F93F RID: 63807 RVA: 0x0048E36F File Offset: 0x0048C56F
	public bool CheckCardIsUsing(int cardId)
	{
		return PersonalModel.Instance.GetCurCardId() == cardId;
	}

	// Token: 0x0600F940 RID: 63808 RVA: 0x0048E380 File Offset: 0x0048C580
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
			PersonalModel.Instance.SetRoleShowList(roleShowListUpdateNotify.RoleShowList);
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
			int[] array = new int[playerHeadAddNotify.AddPlayerHeadIds.Count];
			playerHeadAddNotify.AddPlayerHeadIds.CopyTo(array, 0);
			PersonalModel.Instance.UpdatePlayerHeadData(array);
		});
		Net.Instance.Register(ENotifyMessageId.DressPlayerTitleUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DressPlayerTitleUpdateNotify dressPlayerTitleUpdateNotify = (DressPlayerTitleUpdateNotify)msg;
			PersonalModel.Instance.SetDressedPlayerTitle(dressPlayerTitleUpdateNotify.PlayerTitleId, new int?(dressPlayerTitleUpdateNotify.PlayerTitleExtraParam));
		});
		Net.Instance.Register(ENotifyMessageId.PlayerTitleUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerTitleUpdateNotify playerTitleUpdateNotify = (PlayerTitleUpdateNotify)msg;
			PlayerTitleInfo[] array = new PlayerTitleInfo[playerTitleUpdateNotify.PlayerTitleInfos.Count];
			playerTitleUpdateNotify.PlayerTitleInfos.CopyTo(array, 0);
			PersonalModel.Instance.UpdateUnDressedPlayerTitleList(array);
		});
		Net.Instance.Register(ENotifyMessageId.PlayerTitleInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PlayerTitleInfoUpdateNotify playerTitleInfoUpdateNotify = (PlayerTitleInfoUpdateNotify)msg;
			PlayerTitleInfo[] array = new PlayerTitleInfo[playerTitleInfoUpdateNotify.PlayerTitleInfo.Count];
			playerTitleInfoUpdateNotify.PlayerTitleInfo.CopyTo(array, 0);
			PlayerTitleLimitInfo[] array2 = new PlayerTitleLimitInfo[playerTitleInfoUpdateNotify.PlayerTitleLimitInfos.Count];
			playerTitleInfoUpdateNotify.PlayerTitleLimitInfos.CopyTo(array2, 0);
			PersonalModel.Instance.InitPlayerTitleData(array, array2);
		});
	}

	// Token: 0x0600F941 RID: 63809 RVA: 0x0048E534 File Offset: 0x0048C734
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

	// Token: 0x0600F942 RID: 63810 RVA: 0x0048E5D1 File Offset: 0x0048C7D1
	private void OnFunctionOpenSet(EFunctionType id, bool isOpen)
	{
		this.PlayerTitleRequest(id, isOpen);
	}

	// Token: 0x0600F943 RID: 63811 RVA: 0x0048E5DC File Offset: 0x0048C7DC
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
			PlayerTitleInfo[] array = new PlayerTitleInfo[playerTitleResponse.PlayerTitleInfo.Count];
			playerTitleResponse.PlayerTitleInfo.CopyTo(array, 0);
			PlayerTitleLimitInfo[] array2 = new PlayerTitleLimitInfo[playerTitleResponse.PlayerTitleLimitInfos.Count];
			playerTitleResponse.PlayerTitleLimitInfos.CopyTo(array2, 0);
			PersonalModel.Instance.InitPlayerTitleData(array, array2);
		}, 0);
	}

	// Token: 0x0600F944 RID: 63812 RVA: 0x0048E62C File Offset: 0x0048C82C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(changePlayerTitleResponse.ErrorCode, 23826, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600F945 RID: 63813 RVA: 0x0048E676 File Offset: 0x0048C876
	private void ShowTitleGetView()
	{
		this.TryOpenTitleGetView();
	}

	// Token: 0x0600F946 RID: 63814 RVA: 0x0048E680 File Offset: 0x0048C880
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

	// Token: 0x0600F947 RID: 63815 RVA: 0x0048E6C4 File Offset: 0x0048C8C4
	private void TsSyncHeadInfo(FArrayBuffer buffer)
	{
		PlayerHeadResponse playerHeadResponse = new PlayerHeadResponse();
		playerHeadResponse.MergeFrom(buffer.ToByteArray());
		if (playerHeadResponse == null)
		{
			return;
		}
		int[] array = new int[playerHeadResponse.PlayerHeadIds.Count];
		playerHeadResponse.PlayerHeadIds.CopyTo(array, 0);
		PersonalModel.Instance.InitPlayerHeadData(array);
	}

	// Token: 0x170017F8 RID: 6136
	// (get) Token: 0x0600F948 RID: 63816 RVA: 0x0048E710 File Offset: 0x0048C910
	public static PersonalController Instance
	{
		get
		{
			return PersonalController._Instance;
		}
	}

	// Token: 0x0600F949 RID: 63817 RVA: 0x0048E717 File Offset: 0x0048C917
	public static PersonalController GetOrCreateInstance()
	{
		if (PersonalController._Instance == null)
		{
			PersonalController.CreateInstance();
		}
		return PersonalController._Instance;
	}

	// Token: 0x0600F94A RID: 63818 RVA: 0x0048E72B File Offset: 0x0048C92B
	public static bool CreateInstance()
	{
		if (PersonalController._Instance != null)
		{
			return true;
		}
		PersonalController._Instance = new PersonalController();
		return true;
	}

	// Token: 0x0600F94B RID: 63819 RVA: 0x0048E741 File Offset: 0x0048C941
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F94C RID: 63820 RVA: 0x0048E743 File Offset: 0x0048C943
	public static void ResetStaticDefaultValue()
	{
		PersonalController._Instance = null;
	}

	// Token: 0x0600F94D RID: 63821 RVA: 0x0048E74B File Offset: 0x0048C94B
	static PersonalController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PersonalController.CreateStaticDefaultValue), new Action(PersonalController.ResetStaticDefaultValue));
	}

	// Token: 0x04008B3D RID: 35645
	[Nullable(2)]
	private static PersonalController _Instance;
}
