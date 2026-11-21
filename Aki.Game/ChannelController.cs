using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02000C3A RID: 3130
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ChannelController : UiControllerBase
{
	// Token: 0x060082E0 RID: 33504 RVA: 0x0028298B File Offset: 0x00280B8B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ThirdPartySharedNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGetThirdPartySharedNotify));
	}

	// Token: 0x060082E1 RID: 33505 RVA: 0x002829A9 File Offset: 0x00280BA9
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ThirdPartySharedNotify);
	}

	// Token: 0x060082E2 RID: 33506 RVA: 0x002829BB File Offset: 0x00280BBB
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnShareResult, new Action<bool>(this.OnShareResultBack));
	}

	// Token: 0x060082E3 RID: 33507 RVA: 0x002829D9 File Offset: 0x00280BD9
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnShareResult, new Action<bool>(this.OnShareResultBack));
	}

	// Token: 0x060082E4 RID: 33508 RVA: 0x002829F8 File Offset: 0x00280BF8
	[NullableContext(2)]
	private void OnGetThirdPartySharedNotify(IMessage msg, Net.CallbackStatus _)
	{
		ThirdPartySharedNotify thirdPartySharedNotify = (ThirdPartySharedNotify)msg;
		if (thirdPartySharedNotify != null)
		{
			foreach (int id in thirdPartySharedNotify.SharedIds)
			{
				ChannelModel.Instance.MarkActionShared((EShareActionId)id);
			}
		}
	}

	// Token: 0x060082E5 RID: 33509 RVA: 0x00282A54 File Offset: 0x00280C54
	public bool CheckShareChannelOpen(EChannelShare type)
	{
		return ChannelModel.Instance.CheckShareChannelOpen(type);
	}

	// Token: 0x060082E6 RID: 33510 RVA: 0x00282A61 File Offset: 0x00280C61
	public bool CheckKuroStreetOpen()
	{
		return ChannelModel.Instance.CheckKuroStreetOpen();
	}

	// Token: 0x060082E7 RID: 33511 RVA: 0x00282A6D File Offset: 0x00280C6D
	public bool CheckAccountSettingOpen(EChannelAccountSetting type)
	{
		return ChannelModel.Instance.CheckAccountSettingOpen(type);
	}

	// Token: 0x060082E8 RID: 33512 RVA: 0x00282A7A File Offset: 0x00280C7A
	public bool CheckCustomerServiceOpen()
	{
		return ChannelModel.Instance.CheckCustomerServiceOpen();
	}

	// Token: 0x060082E9 RID: 33513 RVA: 0x00282A86 File Offset: 0x00280C86
	public void OpenKuroStreet()
	{
		ChannelModel.Instance.OpenKuroStreet();
	}

	// Token: 0x060082EA RID: 33514 RVA: 0x00282A92 File Offset: 0x00280C92
	public void ProcessAccountSetting(EChannelAccountSetting type)
	{
		ChannelModel.Instance.ProcessAccountSetting(type);
	}

	// Token: 0x060082EB RID: 33515 RVA: 0x00282AA0 File Offset: 0x00280CA0
	public void OpenGameIntroduction()
	{
		string text = ChannelModel.Instance.GameIntroductionUrl;
		if (string.IsNullOrEmpty(text))
		{
			if (KuroSdkController.Instance.GetIfGlobalSdk())
			{
				text = CommonConfig.Instance.GetGameIntroductionGlobalUrl();
			}
			else
			{
				text = CommonConfig.Instance.GetGameIntroductionUrl();
			}
		}
		string url = PublicUtil.Instance.GetExternalUrl(text, PublicUtil.EExternalUrlReason.GameIntroduction) ?? "";
		GameInformationClickLogEvent logData = new GameInformationClickLogEvent();
		LogReportController.Instance.LogReport(logData);
		KuroSdkController.Instance.OpenWebView("", url, true, true, true, "Default");
	}

	// Token: 0x060082EC RID: 33516 RVA: 0x00282B24 File Offset: 0x00280D24
	public void OpenGameIntroductionByRoleId(int roleId)
	{
		string text = ChannelModel.Instance.GameIntroductionUrl;
		if (string.IsNullOrEmpty(text))
		{
			if (KuroSdkController.Instance.GetIfGlobalSdk())
			{
				text = CommonConfig.Instance.GetGameIntroductionGlobalUrl();
			}
			else
			{
				text = CommonConfig.Instance.GetGameIntroductionUrl();
			}
		}
		string externalUrl = PublicUtil.Instance.GetExternalUrl(text, PublicUtil.EExternalUrlReason.GameIntroduction);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("&role_id=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
		string url = externalUrl + defaultInterpolatedStringHandler.ToStringAndClear();
		GameInformationClickLogEvent logData = new GameInformationClickLogEvent();
		LogReportController.Instance.LogReport(logData);
		KuroSdkController.Instance.OpenWebView("", url, true, true, true, "Default");
	}

	// Token: 0x060082ED RID: 33517 RVA: 0x00282BC8 File Offset: 0x00280DC8
	public void RequestFirstShareReward(EShareActionId id)
	{
		ChannelController.<>c__DisplayClass13_0 CS$<>8__locals1 = new ChannelController.<>c__DisplayClass13_0();
		CS$<>8__locals1.id = id;
		ThirdPartyShareRequest thirdPartyShareRequest = ThirdPartyShareRequest.Create();
		thirdPartyShareRequest.SharedId = (int)CS$<>8__locals1.id;
		Net.Instance.Call(ERequestMessageId.ThirdPartyShareRequest, thirdPartyShareRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestFirstShareReward>g__TempResponse|0), 0);
	}

	// Token: 0x060082EE RID: 33518 RVA: 0x00282C11 File Offset: 0x00280E11
	public List<EChannelShare> GetOpenedShareIds()
	{
		return ChannelModel.Instance.GetOpenedShareIds();
	}

	// Token: 0x060082EF RID: 33519 RVA: 0x00282C1D File Offset: 0x00280E1D
	public bool CouldShare()
	{
		return ChannelModel.Instance.GetOpenedShareIds().Count > 0;
	}

	// Token: 0x060082F0 RID: 33520 RVA: 0x00282C34 File Offset: 0x00280E34
	[NullableContext(2)]
	public void ShareChannel(EChannelShare channel, TArray<byte> data, EShareActionId actionId, int shareConfigId, EShareReportExtraType reportExtraType)
	{
		if (data != null)
		{
			ChannelModel.Instance.SharingActionId = actionId;
			ChannelModel.Instance.SharingConfigId = shareConfigId;
			ChannelModel.Instance.ShareReportExtraType = reportExtraType;
			ShareData shareData = new ShareData();
			shareData.platform = this.GetSharePlatform(channel, shareConfigId);
			KuroSdkController.Instance.ShareByteData(shareData, data);
			return;
		}
		Log.Instance.Error(ELogModule.KuroSdk, ELogAuthor.JT, "分享图片数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060082F1 RID: 33521 RVA: 0x00282CA8 File Offset: 0x00280EA8
	private string GetSharePlatform(EChannelShare channel, int shareConfigId)
	{
		if (Info.Instance.IsOpenHarmonyPlatform())
		{
			SharePlatform? config = ConfigSharePlatformById.GetConfig(shareConfigId, true);
			if (config != null)
			{
				return config.Value.ShareName;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "GetSharePlatform Empty";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("shareConfigId", shareConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		int num = (int)channel;
		return num.ToString();
	}

	// Token: 0x060082F2 RID: 33522 RVA: 0x00282D18 File Offset: 0x00280F18
	private void OnShareResultBack(bool success)
	{
		EShareActionId sharingActionId = ChannelModel.Instance.SharingActionId;
		int sharingConfigId = ChannelModel.Instance.SharingConfigId;
		EShareReportExtraType shareReportExtraType = ChannelModel.Instance.ShareReportExtraType;
		if (success && ChannelModel.Instance.CouldGetShareReward(sharingActionId))
		{
			this.RequestFirstShareReward(sharingActionId);
		}
		this.RecordShare(sharingActionId, sharingConfigId, shareReportExtraType, success);
	}

	// Token: 0x060082F3 RID: 33523 RVA: 0x00282D68 File Offset: 0x00280F68
	private void RecordShare(EShareActionId actionId, int shareConfigId, EShareReportExtraType reportExtraType, bool success)
	{
		ShareEvent shareEvent = new ShareEvent();
		shareEvent.i_share_channel = shareConfigId;
		shareEvent.i_share_result = ((success > false) ? 1 : 0);
		shareEvent.i_share_scene = (int)actionId;
		shareEvent.i_extra_choose = (int)reportExtraType;
		LogReportController.Instance.LogReport(shareEvent);
	}

	// Token: 0x060082F4 RID: 33524 RVA: 0x00282DA8 File Offset: 0x00280FA8
	public void ShareGacha(IReadOnlyList<global::GachaResult> result)
	{
		EShareActionId shareId = EShareActionId.TenGacha;
		if (result.Count == 1)
		{
			shareId = ((GachaConfig.Instance.GetItemIdType(result[0].Proto_GachaReward.ItemId) == InventoryDefine.EItemDataType.WeaponItem) ? EShareActionId.Weapon : EShareActionId.Character);
		}
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = false,
			IsHiddenBattleView = false,
			HandBookPhotoData = null,
			GachaData = result,
			ShareId = (int)shareId
		};
		UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
	}

	// Token: 0x17000EA4 RID: 3748
	// (get) Token: 0x060082F5 RID: 33525 RVA: 0x00282E1D File Offset: 0x0028101D
	public static ChannelController Instance
	{
		get
		{
			return ChannelController._Instance;
		}
	}

	// Token: 0x060082F6 RID: 33526 RVA: 0x00282E24 File Offset: 0x00281024
	public static ChannelController GetOrCreateInstance()
	{
		if (ChannelController._Instance == null)
		{
			ChannelController.CreateInstance();
		}
		return ChannelController._Instance;
	}

	// Token: 0x060082F7 RID: 33527 RVA: 0x00282E38 File Offset: 0x00281038
	public static bool CreateInstance()
	{
		if (ChannelController._Instance != null)
		{
			return true;
		}
		ChannelController._Instance = new ChannelController();
		return true;
	}

	// Token: 0x060082F8 RID: 33528 RVA: 0x00282E4E File Offset: 0x0028104E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060082F9 RID: 33529 RVA: 0x00282E50 File Offset: 0x00281050
	public static void ResetStaticDefaultValue()
	{
		ChannelController._Instance = null;
	}

	// Token: 0x060082FA RID: 33530 RVA: 0x00282E58 File Offset: 0x00281058
	static ChannelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChannelController.CreateStaticDefaultValue), new Action(ChannelController.ResetStaticDefaultValue));
	}

	// Token: 0x0400500F RID: 20495
	[Nullable(2)]
	private static ChannelController _Instance;
}
