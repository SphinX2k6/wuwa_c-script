using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02001781 RID: 6017
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ChannelController : UiControllerBase
{
	// Token: 0x0600AEF9 RID: 44793 RVA: 0x002784C7 File Offset: 0x002766C7
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ThirdPartySharedNotify, new Action<IMessage, Net.CallbackStatus>(this.OnGetThirdPartySharedNotify));
	}

	// Token: 0x0600AEFA RID: 44794 RVA: 0x002784E5 File Offset: 0x002766E5
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ThirdPartySharedNotify);
	}

	// Token: 0x0600AEFB RID: 44795 RVA: 0x002784F7 File Offset: 0x002766F7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnShareResult, new Action<bool>(this.OnShareResultBack));
	}

	// Token: 0x0600AEFC RID: 44796 RVA: 0x00278515 File Offset: 0x00276715
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnShareResult, new Action<bool>(this.OnShareResultBack));
	}

	// Token: 0x0600AEFD RID: 44797 RVA: 0x00278534 File Offset: 0x00276734
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

	// Token: 0x0600AEFE RID: 44798 RVA: 0x00278590 File Offset: 0x00276790
	public bool CheckShareChannelOpen(EChannelShare type)
	{
		return ChannelModel.Instance.CheckShareChannelOpen(type);
	}

	// Token: 0x0600AEFF RID: 44799 RVA: 0x0027859D File Offset: 0x0027679D
	public bool CheckKuroStreetOpen()
	{
		return ChannelModel.Instance.CheckKuroStreetOpen();
	}

	// Token: 0x0600AF00 RID: 44800 RVA: 0x002785A9 File Offset: 0x002767A9
	public bool CheckAccountSettingOpen(EChannelAccountSetting type)
	{
		return ChannelModel.Instance.CheckAccountSettingOpen(type);
	}

	// Token: 0x0600AF01 RID: 44801 RVA: 0x002785B6 File Offset: 0x002767B6
	public bool CheckCustomerServiceOpen()
	{
		return ChannelModel.Instance.CheckCustomerServiceOpen();
	}

	// Token: 0x0600AF02 RID: 44802 RVA: 0x002785C2 File Offset: 0x002767C2
	public void OpenKuroStreet()
	{
		ChannelModel.Instance.OpenKuroStreet();
	}

	// Token: 0x0600AF03 RID: 44803 RVA: 0x002785CE File Offset: 0x002767CE
	public void ProcessAccountSetting(EChannelAccountSetting type)
	{
		ChannelModel.Instance.ProcessAccountSetting(type);
	}

	// Token: 0x0600AF04 RID: 44804 RVA: 0x002785DC File Offset: 0x002767DC
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

	// Token: 0x0600AF05 RID: 44805 RVA: 0x00278660 File Offset: 0x00276860
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

	// Token: 0x0600AF06 RID: 44806 RVA: 0x00278704 File Offset: 0x00276904
	public void RequestFirstShareReward(EShareActionId id)
	{
		ChannelController.<>c__DisplayClass13_0 CS$<>8__locals1 = new ChannelController.<>c__DisplayClass13_0();
		CS$<>8__locals1.id = id;
		ThirdPartyShareRequest thirdPartyShareRequest = ThirdPartyShareRequest.Create();
		thirdPartyShareRequest.SharedId = (int)CS$<>8__locals1.id;
		Net.Instance.Call(ERequestMessageId.ThirdPartyShareRequest, thirdPartyShareRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestFirstShareReward>g__TempResponse|0), 0);
	}

	// Token: 0x0600AF07 RID: 44807 RVA: 0x0027874D File Offset: 0x0027694D
	public List<EChannelShare> GetOpenedShareIds()
	{
		return ChannelModel.Instance.GetOpenedShareIds();
	}

	// Token: 0x0600AF08 RID: 44808 RVA: 0x00278759 File Offset: 0x00276959
	public bool CouldShare()
	{
		return ChannelModel.Instance.GetOpenedShareIds().Count > 0;
	}

	// Token: 0x0600AF09 RID: 44809 RVA: 0x00278770 File Offset: 0x00276970
	[NullableContext(2)]
	public void ShareChannel(EChannelShare channel, TArray<byte> data, EShareActionId actionId, int shareConfigId, EShareReportExtraType reportExtraType)
	{
		if (data != null)
		{
			ChannelModel.Instance.SharingActionId = actionId;
			ChannelModel.Instance.SharingConfigId = shareConfigId;
			ChannelModel.Instance.ShareReportExtraType = reportExtraType;
			ShareData shareData = new ShareData();
			ShareData shareData2 = shareData;
			int num = (int)channel;
			shareData2.platform = num.ToString();
			KuroSdkController.Instance.ShareByteData(shareData, data);
			return;
		}
		Log.Instance.Error(ELogModule.KuroSdk, ELogAuthor.JT, "分享图片数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600AF0A RID: 44810 RVA: 0x002787E4 File Offset: 0x002769E4
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

	// Token: 0x0600AF0B RID: 44811 RVA: 0x00278834 File Offset: 0x00276A34
	private void RecordShare(EShareActionId actionId, int shareConfigId, EShareReportExtraType reportExtraType, bool success)
	{
		ShareEvent shareEvent = new ShareEvent();
		shareEvent.i_share_channel = shareConfigId;
		shareEvent.i_share_result = ((success > false) ? 1 : 0);
		shareEvent.i_share_scene = (int)actionId;
		shareEvent.i_extra_choose = (int)reportExtraType;
		LogReportController.Instance.LogReport(shareEvent);
	}

	// Token: 0x0600AF0C RID: 44812 RVA: 0x00278874 File Offset: 0x00276A74
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

	// Token: 0x17000E81 RID: 3713
	// (get) Token: 0x0600AF0D RID: 44813 RVA: 0x002788E9 File Offset: 0x00276AE9
	public static ChannelController Instance
	{
		get
		{
			return ChannelController._Instance;
		}
	}

	// Token: 0x0600AF0E RID: 44814 RVA: 0x002788F0 File Offset: 0x00276AF0
	public static ChannelController GetOrCreateInstance()
	{
		if (ChannelController._Instance == null)
		{
			ChannelController.CreateInstance();
		}
		return ChannelController._Instance;
	}

	// Token: 0x0600AF0F RID: 44815 RVA: 0x00278904 File Offset: 0x00276B04
	public static bool CreateInstance()
	{
		if (ChannelController._Instance != null)
		{
			return true;
		}
		ChannelController._Instance = new ChannelController();
		return true;
	}

	// Token: 0x0600AF10 RID: 44816 RVA: 0x0027891A File Offset: 0x00276B1A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AF11 RID: 44817 RVA: 0x0027891C File Offset: 0x00276B1C
	public static void ResetStaticDefaultValue()
	{
		ChannelController._Instance = null;
	}

	// Token: 0x0600AF12 RID: 44818 RVA: 0x00278924 File Offset: 0x00276B24
	static ChannelController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ChannelController.CreateStaticDefaultValue), new Action(ChannelController.ResetStaticDefaultValue));
	}

	// Token: 0x04004F65 RID: 20325
	[Nullable(2)]
	private static ChannelController _Instance;
}
