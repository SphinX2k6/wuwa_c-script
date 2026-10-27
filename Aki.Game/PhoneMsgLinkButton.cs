using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002532 RID: 9522
public class PhoneMsgLinkButton : UiPanelBase
{
	// Token: 0x06013248 RID: 78408 RVA: 0x004C0690 File Offset: 0x004BE890
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnPhoneCardClick))
		};
	}

	// Token: 0x06013249 RID: 78409 RVA: 0x004C070D File Offset: 0x004BE90D
	[NullableContext(1)]
	public void RefreshContent(string textKey, int infoId, PhoneMsgChatData data)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textKey, Array.Empty<object>());
		this.InfoId = infoId;
		this.Data = data;
	}

	// Token: 0x0601324A RID: 78410 RVA: 0x004C0734 File Offset: 0x004BE934
	private void OnBtnPhoneCardClick()
	{
		InfoDisplayController.Instance.OpenInfoDisplay(this.InfoId, null, null, false, null);
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

	// Token: 0x0400908F RID: 37007
	[Nullable(2)]
	protected PhoneMsgChatData Data;

	// Token: 0x04009090 RID: 37008
	private int InfoId;
}
