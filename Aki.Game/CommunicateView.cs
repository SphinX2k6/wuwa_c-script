using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019D2 RID: 6610
public class CommunicateView : UiTickViewBase
{
	// Token: 0x0600C10D RID: 49421 RVA: 0x002B8F18 File Offset: 0x002B7118
	[NullableContext(1)]
	public CommunicateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C10E RID: 49422 RVA: 0x002B8F24 File Offset: 0x002B7124
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.ReceiveCommunicate))
		};
	}

	// Token: 0x0600C10F RID: 49423 RVA: 0x002B8FFC File Offset: 0x002B71FC
	protected override void OnStart()
	{
		UUIText text = base.GetText(4);
		text.SetRichText(true);
		text.SetHeight(100f);
		LguiUtil.Instance.SetLocalText(text, "QuestCommunicateConnect", Array.Empty<object>());
		this.ConfigCloseTime = ConfigCommonParamById.GetIntConfig("CommunicateViewCloseTime").Value;
		this.RemainStayTime = (float)this.ConfigCloseTime;
		this.CountDownItem = new GuideCountDownItem((float)this.ConfigCloseTime);
		this.CountDownItem.Init(base.GetItem(0));
		this.CommunicateId = (this.OpenParam as int?).GetValueOrDefault();
		if (this.CommunicateId == 0)
		{
			return;
		}
		Communicate? config = ConfigCommunicateById.GetConfig(this.CommunicateId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Quest;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到通讯配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("communicateId", this.CommunicateId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Speaker? config2 = ConfigSpeakerById.GetConfig(config.Value.Talker, true);
		if (config2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Quest;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "找不到通讯对话人配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("talkerId", config.Value.Talker);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		this.SetCallContent(config2.Value);
		this.SetHeadTexture(config2.Value);
	}

	// Token: 0x0600C110 RID: 49424 RVA: 0x002B9168 File Offset: 0x002B7368
	private void SetCallContent(Speaker speaker)
	{
		string textById = TextConfig.Instance.GetTextById("QuestCommunicateRequest");
		UUIText text = base.GetText(1);
		string configTextByTable = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Id));
		text.SetText("【" + configTextByTable + "】" + textById, true);
	}

	// Token: 0x0600C111 RID: 49425 RVA: 0x002B91BC File Offset: 0x002B73BC
	private void SetHeadTexture(Speaker speaker)
	{
		UUITexture texture = base.GetTexture(2);
		base.SetTextureByPath(speaker.HeadIconAsset, texture, null, null);
	}

	// Token: 0x0600C112 RID: 49426 RVA: 0x002B91EC File Offset: 0x002B73EC
	protected override void OnTick(float delta)
	{
		if (!this.RootItem.bIsUIActive)
		{
			return;
		}
		if (this.RemainStayTime <= 0f && !this.CountDownTrigger)
		{
			this.CountDownTrigger = true;
			this.CloseView(null);
			return;
		}
		this.RemainStayTime -= delta;
		this.CountDownItem.OnDurationChange(this.RemainStayTime);
	}

	// Token: 0x0600C113 RID: 49427 RVA: 0x002B924A File Offset: 0x002B744A
	private void ReceiveCommunicate()
	{
		this.CloseView(delegate(bool success)
		{
			EventSystem.Instance.Emit<int>(EEventName.CommunicateFinished, this.CommunicateId);
		});
	}

	// Token: 0x0600C114 RID: 49428 RVA: 0x002B925E File Offset: 0x002B745E
	[NullableContext(2)]
	private void CloseView(Action<bool> closeCallback = null)
	{
		base.CloseMe(closeCallback);
	}

	// Token: 0x040056CE RID: 22222
	[Nullable(2)]
	private GuideCountDownItem CountDownItem;

	// Token: 0x040056CF RID: 22223
	private int ConfigCloseTime;

	// Token: 0x040056D0 RID: 22224
	private float RemainStayTime;

	// Token: 0x040056D1 RID: 22225
	private bool CountDownTrigger;

	// Token: 0x040056D2 RID: 22226
	private int CommunicateId;

	// Token: 0x02007EF9 RID: 32505
	private static class EChildComponent
	{
		// Token: 0x040297B8 RID: 169912
		public const int CountDownItem = 0;

		// Token: 0x040297B9 RID: 169913
		public const int CallContentText = 1;

		// Token: 0x040297BA RID: 169914
		public const int HeadTexture = 2;

		// Token: 0x040297BB RID: 169915
		public const int ConnectItem = 3;

		// Token: 0x040297BC RID: 169916
		public const int ConnectText = 4;

		// Token: 0x040297BD RID: 169917
		public const int ReceiveBtn = 5;

		// Token: 0x040297BE RID: 169918
		public const int CountDownParent = 6;
	}
}
