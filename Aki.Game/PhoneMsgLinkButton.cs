using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A19 RID: 6681
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgLinkButton : UiPanelBase
{
	// Token: 0x06010708 RID: 67336 RVA: 0x004CE39C File Offset: 0x004CC59C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnPhoneCardClick))
		};
	}

	// Token: 0x06010709 RID: 67337 RVA: 0x004CE430 File Offset: 0x004CC630
	public void RefreshContent(string textKey, int infoId, PhoneMsgChatData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textKey, Array.Empty<object>());
		this.InfoId = infoId;
		this.Data = data;
		this.attachmentConfig = ConfigPhoneMessageAttachmentById.GetConfig(data.ContentNum, true);
		string a = (this.attachmentConfig != null) ? this.attachmentConfig.GetValueOrDefault().Type : null;
		if (a == "InformationView")
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PhoneSystemCardIcon");
			base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
			return;
		}
		if (a == "CoordinateTeleport")
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_PhoneSystemCardIcon02");
			base.SetTextureByPath(resourcePath2, base.GetTexture(3), null, null);
		}
	}

	// Token: 0x0601070A RID: 67338 RVA: 0x004CE504 File Offset: 0x004CC704
	public void RefreshCoordinateContent(PhoneMsgChatData data)
	{
		this.Data = data;
		this.attachmentConfig = ConfigPhoneMessageAttachmentById.GetConfig(data.ContentNum, true);
		string coordinateMarkName = this.GetCoordinateMarkName((this.attachmentConfig != null) ? this.attachmentConfig.GetValueOrDefault().CoordinateTeleportId : 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), coordinateMarkName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PhoneSystem_ClickToMap", Array.Empty<object>());
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PhoneSystemCardIcon02");
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
	}

	// Token: 0x0601070B RID: 67339 RVA: 0x004CE5AC File Offset: 0x004CC7AC
	private string GetCoordinateMarkName(int accessPathId)
	{
		if (accessPathId <= 0)
		{
			return "";
		}
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(accessPathId);
		if (accessPathConfig == null || string.IsNullOrEmpty(accessPathConfig.Value.Val1))
		{
			return "";
		}
		int num;
		if (!int.TryParse(accessPathConfig.Value.Val1, out num))
		{
			return "";
		}
		DynamicMapMark? config = ConfigDynamicMapMarkByMarkId.GetConfig(num, true);
		if (config != null)
		{
			return config.Value.MarkTitle;
		}
		MapMark? configMark = MapConfig.Instance.GetConfigMark(num);
		if (configMark != null)
		{
			return configMark.Value.MarkTitle;
		}
		return "";
	}

	// Token: 0x0601070C RID: 67340 RVA: 0x004CE664 File Offset: 0x004CC864
	private void OnBtnPhoneCardClick()
	{
		string a = (this.attachmentConfig != null) ? this.attachmentConfig.GetValueOrDefault().Type : null;
		if (a == "InformationView")
		{
			this.OnBtnPhoneCardClickInfo();
			return;
		}
		if (a == "CoordinateTeleport")
		{
			this.OnBtnPhoneCardClickCoordinate();
		}
	}

	// Token: 0x0601070D RID: 67341 RVA: 0x004CE6B8 File Offset: 0x004CC8B8
	private void OnBtnPhoneCardClickInfo()
	{
		InfoDisplayController.Instance.OpenInfoDisplay(this.InfoId, null, null, false, null, null);
		PhoneMsgShortMsgData phoneMsgShortMsgDataByShortMsgId = PhoneMsgModel.Instance.GetPhoneMsgShortMsgDataByShortMsgId(this.Data.ShortMessageId);
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(this.Data.ShortMessageId);
		if (phoneMsgShortMsgDataByShortMsgId == null || phoneMsgConfig == null)
		{
			return;
		}
		OnClickShortMessageLogEvent onClickShortMessageLogEvent = new OnClickShortMessageLogEvent();
		onClickShortMessageLogEvent.i_id = this.Data.ShortMessageId;
		onClickShortMessageLogEvent.i_type = (this.Data.IsGroupChat ? 1 : 2);
		onClickShortMessageLogEvent.i_role_id = phoneMsgConfig.Value.WhichChat;
		onClickShortMessageLogEvent.l_received_time = phoneMsgShortMsgDataByShortMsgId.UnLockTime;
		onClickShortMessageLogEvent.i_config_id = this.InfoId;
		LogReportController.Instance.LogReport(onClickShortMessageLogEvent);
	}

	// Token: 0x0601070E RID: 67342 RVA: 0x004CE784 File Offset: 0x004CC984
	private void OnBtnPhoneCardClickCoordinate()
	{
		SkipTaskManager.RunByConfigId(this.attachmentConfig.Value.CoordinateTeleportId, null);
	}

	// Token: 0x040091E5 RID: 37349
	[Nullable(2)]
	protected PhoneMsgChatData Data;

	// Token: 0x040091E6 RID: 37350
	private PhoneMessageAttachment? attachmentConfig;

	// Token: 0x040091E7 RID: 37351
	private int InfoId;
}
