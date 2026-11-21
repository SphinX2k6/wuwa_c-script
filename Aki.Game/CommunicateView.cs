using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E91 RID: 3729
public class CommunicateView : UiTickViewBase
{
	// Token: 0x0600951A RID: 38170 RVA: 0x002C3EE4 File Offset: 0x002C20E4
	[NullableContext(1)]
	public CommunicateView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600951B RID: 38171 RVA: 0x002C3EF0 File Offset: 0x002C20F0
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

	// Token: 0x0600951C RID: 38172 RVA: 0x002C3FC8 File Offset: 0x002C21C8
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

	// Token: 0x0600951D RID: 38173 RVA: 0x002C4134 File Offset: 0x002C2334
	private void SetCallContent(Speaker speaker)
	{
		string textById = TextConfig.Instance.GetTextById("QuestCommunicateRequest");
		UUIText text = base.GetText(1);
		string configTextByTable = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Id));
		text.SetText("【" + configTextByTable + "】" + textById, true);
	}

	// Token: 0x0600951E RID: 38174 RVA: 0x002C4188 File Offset: 0x002C2388
	private void SetHeadTexture(Speaker speaker)
	{
		UUITexture texture = base.GetTexture(2);
		base.SetTextureByPath(speaker.HeadIconAsset, texture, null, null);
	}

	// Token: 0x0600951F RID: 38175 RVA: 0x002C41B8 File Offset: 0x002C23B8
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

	// Token: 0x06009520 RID: 38176 RVA: 0x002C4216 File Offset: 0x002C2416
	private void ReceiveCommunicate()
	{
		this.CloseView(delegate(bool success)
		{
			EventSystem.Instance.Emit<int>(EEventName.CommunicateFinished, this.CommunicateId);
		});
	}

	// Token: 0x06009521 RID: 38177 RVA: 0x002C422A File Offset: 0x002C242A
	[NullableContext(2)]
	private void CloseView(Action<bool> closeCallback = null)
	{
		base.CloseMe(closeCallback);
	}

	// Token: 0x04005780 RID: 22400
	[Nullable(2)]
	private GuideCountDownItem CountDownItem;

	// Token: 0x04005781 RID: 22401
	private int ConfigCloseTime;

	// Token: 0x04005782 RID: 22402
	private float RemainStayTime;

	// Token: 0x04005783 RID: 22403
	private bool CountDownTrigger;

	// Token: 0x04005784 RID: 22404
	private int CommunicateId;

	// Token: 0x02007088 RID: 28808
	private static class EChildComponent
	{
		// Token: 0x04024AF5 RID: 150261
		public const int CountDownItem = 0;

		// Token: 0x04024AF6 RID: 150262
		public const int CallContentText = 1;

		// Token: 0x04024AF7 RID: 150263
		public const int HeadTexture = 2;

		// Token: 0x04024AF8 RID: 150264
		public const int ConnectItem = 3;

		// Token: 0x04024AF9 RID: 150265
		public const int ConnectText = 4;

		// Token: 0x04024AFA RID: 150266
		public const int ReceiveBtn = 5;

		// Token: 0x04024AFB RID: 150267
		public const int CountDownParent = 6;
	}
}
