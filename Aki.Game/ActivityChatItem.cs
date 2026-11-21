using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A1E RID: 6686
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityChatItem : SyncGridProxyAbstract<PhoneMsgChatData>
{
	// Token: 0x06010724 RID: 67364 RVA: 0x004CECE0 File Offset: 0x004CCEE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnGoToClick))
		};
	}

	// Token: 0x06010725 RID: 67365 RVA: 0x004CEDB5 File Offset: 0x004CCFB5
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		EventSystem.Instance.Add(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06010726 RID: 67366 RVA: 0x004CEDE4 File Offset: 0x004CCFE4
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnActivityUpdate, new Action(this.OnActivityUpdate));
	}

	// Token: 0x06010727 RID: 67367 RVA: 0x004CEE02 File Offset: 0x004CD002
	private void OnActivityUpdate()
	{
		if (this.PhoneMsgChatData != null)
		{
			this.Refresh(this.PhoneMsgChatData);
		}
	}

	// Token: 0x06010728 RID: 67368 RVA: 0x004CEE18 File Offset: 0x004CD018
	[NullableContext(1)]
	public override void Refresh(PhoneMsgChatData data)
	{
		this.PhoneMsgChatData = data;
		if (!ActivityModel.Instance.IsActivityOpen(data.ActivityId))
		{
			this.SetActive(false);
			return;
		}
		this.SetActive(true);
		base.GetSprite(5).SetUIActive(false);
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(data.ActivityId);
		string newText = (activityById != null) ? activityById.GetTitle() : "";
		base.GetText(3).SetText(newText, true);
		if (activityById != null && activityById.LocalConfig != null)
		{
			int num = activityById.LocalConfig.Value.ShowTabTypeId;
			if (num != 4 && num != 5 && num != 8)
			{
				num = 0;
			}
			string resourceId = "SP_PhoneSystemActivity" + num.ToString();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
			}
		}
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(data.ShortMessageId);
		if (this.activitypre == null && phoneMsgConfig != null && !string.IsNullOrEmpty(phoneMsgConfig.Value.ActivityPre))
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				this.activitypre = new UiPanelBase();
				this.activitypre.CreateThenShowByPathAsync(phoneMsgConfig.Value.ActivityPre, item, false);
			}
		}
		bool flag = activityById == null || activityById.IsHiddenByConfig() || ActivityChatItem.IsJumpToActivityRestricted();
		if (data.ContentType == EChatMsgType.ActivityMainView)
		{
			flag = (flag || !activityById.IsUnLock());
		}
		base.GetText(2).SetUIActive(true);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PhoneSystem_ConnotToActivity", Array.Empty<object>());
			base.GetButton(4).SetSelfInteractive(false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "PhoneSystem_ToActivity", Array.Empty<object>());
		base.GetButton(4).SetSelfInteractive(true);
	}

	// Token: 0x06010729 RID: 67369 RVA: 0x004CF008 File Offset: 0x004CD208
	private void OnGoToClick()
	{
		if (this.PhoneMsgChatData == null || this.PhoneMsgChatData.ActivityId == 0)
		{
			return;
		}
		if (ActivityChatItem.IsJumpToActivityRestricted())
		{
			return;
		}
		this.JumpToActivity(this.PhoneMsgChatData);
		ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(this.PhoneMsgChatData.ShortMessageId);
		if (phoneMsgConfig == null)
		{
			return;
		}
		OnJumpInShortMessageLogEvent onJumpInShortMessageLogEvent = new OnJumpInShortMessageLogEvent();
		onJumpInShortMessageLogEvent.i_id = this.PhoneMsgChatData.ActivityId;
		onJumpInShortMessageLogEvent.i_type = (this.PhoneMsgChatData.IsGroupChat ? 1 : 2);
		onJumpInShortMessageLogEvent.i_role_id = phoneMsgConfig.Value.WhichChat;
		onJumpInShortMessageLogEvent.l_received_time = this.PhoneMsgChatData.UnLockTime;
		onJumpInShortMessageLogEvent.i_trigger_type = 3;
		onJumpInShortMessageLogEvent.i_config_id = this.PhoneMsgChatData.ActivityId;
		LogReportController.Instance.LogReport(onJumpInShortMessageLogEvent);
	}

	// Token: 0x0601072A RID: 67370 RVA: 0x004CF0D8 File Offset: 0x004CD2D8
	[NullableContext(1)]
	private void JumpToActivity(PhoneMsgChatData data)
	{
		if (UiManager.Instance.GetViewByName(EUiViewName.QuestView) != null)
		{
			UiManager.Instance.CloseView(EUiViewName.QuestView, null);
		}
		if (UiManager.Instance.GetViewByName(EUiViewName.FunctionView) != null)
		{
			UiManager.Instance.CloseView(EUiViewName.FunctionView, null);
		}
		if (data.ContentType == EChatMsgType.ActivityMainView)
		{
			ActivityViewName? config = ConfigActivityViewNameById.GetConfig(data.ActivityId, true);
			if (config != null && !string.IsNullOrEmpty(config.Value.ViewName))
			{
				IActivityControllerBase activityController = ActivityManager.GetActivityController(config.Value.Type);
				if (activityController != null)
				{
					activityController.OpenViewByViewName((EUiViewName)config.Value.ViewName, data.ActivityId).Forget<bool>();
					if (UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView) != null)
					{
						UiManager.Instance.CloseView(EUiViewName.CommonActivityView, null);
					}
					this.ClosePhoneMsgViews();
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhoneSystem;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "活动主界面跳转缺少 ActivityViewName 配置，回退到活动中心";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", data.ActivityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			ActivityController.Instance.OpenActivityById(data.ActivityId, EActivityViewOpenType.Other, null, null);
			return;
		}
		ActivityController.Instance.OpenActivityById(data.ActivityId, EActivityViewOpenType.Other, null, null);
	}

	// Token: 0x0601072B RID: 67371 RVA: 0x004CF222 File Offset: 0x004CD422
	private static bool IsJumpToActivityRestricted()
	{
		return GameModeController.Instance.IsInInstance();
	}

	// Token: 0x0601072C RID: 67372 RVA: 0x004CF230 File Offset: 0x004CD430
	private void ClosePhoneMsgViews()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhoneMsgPanelViewBig))
		{
			UiManager.Instance.CloseView(EUiViewName.PhoneMsgPanelViewBig, null);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhoneMsgPanelViewSmall))
		{
			UiManager.Instance.CloseView(EUiViewName.PhoneMsgPanelViewSmall, null);
		}
	}

	// Token: 0x0601072D RID: 67373 RVA: 0x004CF280 File Offset: 0x004CD480
	public UniTask PlayActivityAnimationAsync()
	{
		ActivityChatItem.<PlayActivityAnimationAsync>d__13 <PlayActivityAnimationAsync>d__;
		<PlayActivityAnimationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayActivityAnimationAsync>d__.<>4__this = this;
		<PlayActivityAnimationAsync>d__.<>1__state = -1;
		<PlayActivityAnimationAsync>d__.<>t__builder.Start<ActivityChatItem.<PlayActivityAnimationAsync>d__13>(ref <PlayActivityAnimationAsync>d__);
		return <PlayActivityAnimationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601072E RID: 67374 RVA: 0x004CF2C3 File Offset: 0x004CD4C3
	public void StopActivityAnimation()
	{
		this.LevelSequencePlayer.StopSequenceByKey("In", false, true);
	}

	// Token: 0x040091ED RID: 37357
	private PhoneMsgChatData PhoneMsgChatData;

	// Token: 0x040091EE RID: 37358
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040091EF RID: 37359
	private UiPanelBase activitypre;

	// Token: 0x02007C45 RID: 31813
	[NullableContext(0)]
	private enum EItemActivityComponent
	{
		// Token: 0x040283F8 RID: 164856
		SpriteColor,
		// Token: 0x040283F9 RID: 164857
		SpriteIconTask,
		// Token: 0x040283FA RID: 164858
		TxtTaskState,
		// Token: 0x040283FB RID: 164859
		TxtTaskName,
		// Token: 0x040283FC RID: 164860
		BtnGoTo,
		// Token: 0x040283FD RID: 164861
		SpriteFinish,
		// Token: 0x040283FE RID: 164862
		PnlTag
	}
}
