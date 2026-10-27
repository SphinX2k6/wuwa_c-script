using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005041 RID: 20545
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatPopView : UiViewBase
	{
		// Token: 0x0603493C RID: 215356 RVA: 0x00C6A517 File Offset: 0x00C68717
		public ChatPopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603493D RID: 215357 RVA: 0x00C6A538 File Offset: 0x00C68738
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603493E RID: 215358 RVA: 0x00C6A5C4 File Offset: 0x00C687C4
		protected override void OnStart()
		{
			this.ChatLayout = new GenericLayout<ChatItemGrid, ChatItemData>(base.GetVerticalLayout(2), new Func<ChatItemGrid>(this.CreateChatItem), null, false, true);
			ChatPopViewData chatPopViewData = this.OpenParam as ChatPopViewData;
			if (chatPopViewData == null)
			{
				return;
			}
			if (chatPopViewData.ParentViewId != null)
			{
				UiViewBase view = UiManager.Instance.GetView(chatPopViewData.ParentViewId.Value);
				if (view != null)
				{
					view.AddChild(this);
				}
			}
			if (chatPopViewData.FlowId != null)
			{
				this.LoadFlowData(chatPopViewData.FlowId);
			}
			this.OnAllShownCallback = chatPopViewData.OnAllShownCallback;
			this.ConditionId = chatPopViewData.Condition;
			if (this.ConditionId > 0)
			{
				this.RegisterCondition();
				return;
			}
			this.StartPlay();
		}

		// Token: 0x0603493F RID: 215359 RVA: 0x00C6A674 File Offset: 0x00C68874
		private void RegisterCondition()
		{
			this.IsWaitingCondition = true;
			this.ConditionCallback = new ConditionPassCallback(new TConditionPassCallback(this.OnConditionPass), null);
			if (!LevelConditionRegistry.Instance.RegisterConditionGroup(this.ConditionId, this.ConditionCallback))
			{
				this.IsWaitingCondition = false;
				this.ConditionCallback = null;
				this.StartPlay();
			}
		}

		// Token: 0x06034940 RID: 215360 RVA: 0x00C6A6CC File Offset: 0x00C688CC
		private void OnConditionPass([Nullable(new byte[]
		{
			2,
			1
		})] object[] parameters)
		{
			if (!this.IsWaitingCondition)
			{
				return;
			}
			this.UnRegisterCondition();
			this.StartPlay();
		}

		// Token: 0x06034941 RID: 215361 RVA: 0x00C6A6E3 File Offset: 0x00C688E3
		private void UnRegisterCondition()
		{
			if (!this.IsWaitingCondition)
			{
				return;
			}
			this.IsWaitingCondition = false;
			if (this.ConditionCallback != null)
			{
				LevelConditionRegistry.Instance.UnRegisterConditionGroup(this.ConditionId, this.ConditionCallback);
				this.ConditionCallback = null;
			}
		}

		// Token: 0x06034942 RID: 215362 RVA: 0x00C6A71A File Offset: 0x00C6891A
		private void StartPlay()
		{
			if (this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = true;
			this.ShowNextTalk();
		}

		// Token: 0x06034943 RID: 215363 RVA: 0x00C6A734 File Offset: 0x00C68934
		public void LoadFlowData(List<string> flowId)
		{
			this.AllTalkItems.Clear();
			this.DisplayedItems.Clear();
			this.CurrentTalkIndex = 0;
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowId[0], int.Parse(flowId[1]), int.Parse(flowId[2]));
			if (flowStateActions == null)
			{
				return;
			}
			foreach (ActionInfo actionInfo in flowStateActions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					foreach (ITalkItem talkItem in ((ShowTalk)actionInfo.Params).TalkItems)
					{
						Speaker? speaker = (talkItem.WhoId != null) ? ConfigSpeakerById.GetConfig(talkItem.WhoId.Value, true) : null;
						string name = (speaker != null) ? (PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(speaker.Value.Id)) ?? "") : "";
						string icon = (talkItem.WhoId.GetValueOrDefault() == 750088) ? ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male) ? "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_4_a_UI.T_IconRoleHead256_4_a_UI" : "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_5_a_UI.T_IconRoleHead256_5_a_UI") : (((speaker != null) ? speaker.GetValueOrDefault().HeadIconAsset : null) ?? "");
						string text = PublicUtil.Instance.GetFlowConfigLocalText(talkItem.TidTalk ?? "") ?? "";
						if (!StringUtils.IsEmpty(text))
						{
							this.AllTalkItems.Add(new ChatItemData
							{
								Icon = icon,
								Name = name,
								Message = text,
								Time = "",
								TidTalk = talkItem.TidTalk
							});
						}
					}
				}
			}
		}

		// Token: 0x06034944 RID: 215364 RVA: 0x00C6A978 File Offset: 0x00C68B78
		public bool ShowNextTalk()
		{
			if (this.CurrentTalkIndex >= this.AllTalkItems.Count)
			{
				return false;
			}
			foreach (ChatItemData chatItemData in this.DisplayedItems)
			{
				chatItemData.IsCompleted = true;
			}
			ChatItemData chatItemData2 = this.AllTalkItems[this.CurrentTalkIndex];
			chatItemData2.IsCompleted = false;
			this.DisplayedItems.Add(chatItemData2);
			if (this.DisplayedItems.Count > 2)
			{
				this.DisplayedItems.RemoveRange(0, this.DisplayedItems.Count - 2);
			}
			this.UpdateDisplayedItemModes();
			this.CurrentTalkIndex++;
			this.ChatLayout.RefreshByData(this.DisplayedItems, new Action(this.ScrollToBottom), false);
			this.PlayVoiceForItem(chatItemData2);
			return true;
		}

		// Token: 0x06034945 RID: 215365 RVA: 0x00C6AA64 File Offset: 0x00C68C64
		private void UpdateDisplayedItemModes()
		{
			int num = this.DisplayedItems.Count - 1;
			for (int i = 0; i < this.DisplayedItems.Count; i++)
			{
				ChatItemData chatItemData = this.DisplayedItems[i];
				int num2 = num - i;
				if (num2 == 0)
				{
					chatItemData.DisplayMode = new ChatItemDisplayMode?(ChatItemDisplayMode.Start);
					chatItemData.IsCompleted = false;
				}
				else if (num2 == 1)
				{
					chatItemData.DisplayMode = new ChatItemDisplayMode?(ChatItemDisplayMode.GreyOnly);
					chatItemData.IsCompleted = true;
				}
				else
				{
					chatItemData.DisplayMode = new ChatItemDisplayMode?(ChatItemDisplayMode.Close);
					chatItemData.IsCompleted = true;
				}
			}
		}

		// Token: 0x06034946 RID: 215366 RVA: 0x00C6AAEC File Offset: 0x00C68CEC
		private unsafe void PlayVoiceForItem(ChatItemData item)
		{
			ChatPopView.<>c__DisplayClass29_0 CS$<>8__locals1 = new ChatPopView.<>c__DisplayClass29_0();
			CS$<>8__locals1.<>4__this = this;
			this.StopCurrentAudio();
			string tidTalk = item.TidTalk;
			if (tidTalk == null)
			{
				global::Log.Instance.Error(ELogModule.Log, ELogAuthor.SWC, "[ChatPopView] 无TidTalk，跳过语音", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.OnVoiceFinished();
				return;
			}
			PlotAudio? config = ConfigPlotAudioById.GetConfig(tidTalk, true);
			if (config == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[ChatPopView] 无语音配置，跳过语音";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tidTalk", tidTalk);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.OnVoiceFinished();
				return;
			}
			ChatPopView.<>c__DisplayClass29_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.DialogVersion + 1;
			this.DialogVersion = num;
			CS$<>8__locals2.currentVersion = num;
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
			this.PlotPlayEventResult = AudioSystem.Instance.PostEvent("play_vo_caccona_gal", null, new PostEventArgs?(new PostEventArgs
			{
				ExternalSourceName = "external_caccona_gal_voice",
				ExternalSourceMediaName = externalSourcesMediaName,
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Plot;
						ELogAuthor author2 = ELogAuthor.SWC;
						string message2 = "[ChatPopView] [Error_CALLBACK] EAkCallbackType.EndOfEvent";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("DialogVersion", CS$<>8__locals1.<>4__this.DialogVersion);
						instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					else if (callbackType == EAkCallbackType.Duration)
					{
						global::Log instance3 = global::Log.Instance;
						ELogModule module3 = ELogModule.Plot;
						ELogAuthor author3 = ELogAuthor.SWC;
						string message3 = "[ChatPopView] [Error_CALLBACK] EAkCallbackType.Duration";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("DialogVersion", CS$<>8__locals1.<>4__this.DialogVersion);
						instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
					if (CS$<>8__locals1.currentVersion != CS$<>8__locals1.<>4__this.DialogVersion)
					{
						global::Log instance4 = global::Log.Instance;
						ELogModule module4 = ELogModule.Plot;
						ELogAuthor author4 = ELogAuthor.SWC;
						string message4 = "[ChatPopView] [Error_CALLBACK] DialogVersion Not Matched";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DialogVersion", CS$<>8__locals1.<>4__this.DialogVersion);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentVersion", CS$<>8__locals1.currentVersion);
						instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						return;
					}
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						CS$<>8__locals1.<>4__this.ClearVoiceCallbackTimeoutTimer();
						CS$<>8__locals1.<>4__this.PlotPlayEventResult = 0;
						CS$<>8__locals1.<>4__this.OnVoiceFinished();
					}
				}
			}));
			this.StartVoiceCallbackTimeout(CS$<>8__locals1.currentVersion);
		}

		// Token: 0x06034947 RID: 215367 RVA: 0x00C6AC08 File Offset: 0x00C68E08
		private void OnVoiceFinished()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			if (!this.ShowNextTalk())
			{
				this.DelayOnAllTalkFinished();
			}
		}

		// Token: 0x06034948 RID: 215368 RVA: 0x00C6AC21 File Offset: 0x00C68E21
		private void DelayOnAllTalkFinished()
		{
			this.ClearOnAllTalkFinishedTimer();
			this.OnAllTalkFinishedTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnAllTalkFinishedTimer = null;
				this.OnAllTalkFinished();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x06034949 RID: 215369 RVA: 0x00C6AC52 File Offset: 0x00C68E52
		private void OnAllTalkFinished()
		{
			this.IsPlaying = false;
			Action onAllShownCallback = this.OnAllShownCallback;
			if (onAllShownCallback != null)
			{
				onAllShownCallback();
			}
			base.CloseMe(null);
		}

		// Token: 0x0603494A RID: 215370 RVA: 0x00C6AC73 File Offset: 0x00C68E73
		public bool HasMoreTalks()
		{
			return this.CurrentTalkIndex < this.AllTalkItems.Count;
		}

		// Token: 0x0603494B RID: 215371 RVA: 0x00C6AC88 File Offset: 0x00C68E88
		public int GetRemainingTalkCount()
		{
			return this.AllTalkItems.Count - this.CurrentTalkIndex;
		}

		// Token: 0x0603494C RID: 215372 RVA: 0x00C6AC9C File Offset: 0x00C68E9C
		private void StopCurrentAudio()
		{
			this.DialogVersion++;
			this.ClearVoiceCallbackTimeoutTimer();
			AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.PlotPlayEventResult = 0;
		}

		// Token: 0x0603494D RID: 215373 RVA: 0x00C6ACF0 File Offset: 0x00C68EF0
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnRegisterCondition();
			this.StopCurrentAudio();
			this.ClearOnAllTalkFinishedTimer();
			this.ClearVoiceCallbackTimeoutTimer();
		}

		// Token: 0x0603494E RID: 215374 RVA: 0x00C6AD10 File Offset: 0x00C68F10
		private void ClearOnAllTalkFinishedTimer()
		{
			if (this.OnAllTalkFinishedTimer != null)
			{
				TimerSystem.Instance.Remove(this.OnAllTalkFinishedTimer);
				this.OnAllTalkFinishedTimer = null;
			}
		}

		// Token: 0x0603494F RID: 215375 RVA: 0x00C6AD34 File Offset: 0x00C68F34
		private void StartVoiceCallbackTimeout(int currentVersion)
		{
			this.ClearVoiceCallbackTimeoutTimer();
			this.VoiceCallbackTimeoutTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.VoiceCallbackTimeoutTimer = null;
				if (currentVersion != this.DialogVersion)
				{
					return;
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[ChatPopView] [Error_CALLBACK] Voice callback timeout, auto continue";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DialogVersion", this.DialogVersion);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.PlotPlayEventResult = 0;
				this.OnVoiceFinished();
			}, 10000f, null, null, true, 1f);
		}

		// Token: 0x06034950 RID: 215376 RVA: 0x00C6AD84 File Offset: 0x00C68F84
		private void ClearVoiceCallbackTimeoutTimer()
		{
			if (this.VoiceCallbackTimeoutTimer != null)
			{
				TimerSystem.Instance.Remove(this.VoiceCallbackTimeoutTimer);
				this.VoiceCallbackTimeoutTimer = null;
			}
		}

		// Token: 0x06034951 RID: 215377 RVA: 0x00C6ADA8 File Offset: 0x00C68FA8
		private void ScrollToBottom()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(2);
			UUIItem uuiitem = (verticalLayout != null) ? verticalLayout.RootUIComp.Get() : null;
			TArray<UUIItem> tarray = (uuiitem != null) ? uuiitem.GetAttachUIChildren() : null;
			int num = (tarray != null) ? tarray.Num() : 0;
			if (num <= 0)
			{
				return;
			}
			UUIItem attachUIChild = uuiitem.GetAttachUIChild(num - 1);
			if (attachUIChild == null)
			{
				return;
			}
			scrollViewWithScrollbar.ScrollToBottomLater(attachUIChild, false);
		}

		// Token: 0x06034952 RID: 215378 RVA: 0x00C6AE12 File Offset: 0x00C69012
		private ChatItemGrid CreateChatItem()
		{
			return new ChatItemGrid();
		}

		// Token: 0x0401C04E RID: 114766
		private const int MAX_CHAT_ITEM_COUNT = 2;

		// Token: 0x0401C04F RID: 114767
		private const int ON_ALL_TALK_FINISHED_DELAY_MS = 2000;

		// Token: 0x0401C050 RID: 114768
		private const int VOICE_CALLBACK_TIMEOUT_MS = 10000;

		// Token: 0x0401C051 RID: 114769
		private const string PROTAGONIST_ICON_FEMALE = "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_5_a_UI.T_IconRoleHead256_5_a_UI";

		// Token: 0x0401C052 RID: 114770
		private const string PROTAGONIST_ICON_MALE = "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_4_a_UI.T_IconRoleHead256_4_a_UI";

		// Token: 0x0401C053 RID: 114771
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ChatItemGrid, ChatItemData> ChatLayout;

		// Token: 0x0401C054 RID: 114772
		private readonly List<ChatItemData> AllTalkItems = new List<ChatItemData>();

		// Token: 0x0401C055 RID: 114773
		private readonly List<ChatItemData> DisplayedItems = new List<ChatItemData>();

		// Token: 0x0401C056 RID: 114774
		private int CurrentTalkIndex;

		// Token: 0x0401C057 RID: 114775
		private bool IsPlaying;

		// Token: 0x0401C058 RID: 114776
		private bool IsWaitingCondition;

		// Token: 0x0401C059 RID: 114777
		[Nullable(2)]
		private Action OnAllShownCallback;

		// Token: 0x0401C05A RID: 114778
		private int ConditionId;

		// Token: 0x0401C05B RID: 114779
		[Nullable(2)]
		private ConditionPassCallback ConditionCallback;

		// Token: 0x0401C05C RID: 114780
		private int PlotPlayEventResult;

		// Token: 0x0401C05D RID: 114781
		private int DialogVersion;

		// Token: 0x0401C05E RID: 114782
		[Nullable(2)]
		private TimerHandle OnAllTalkFinishedTimer;

		// Token: 0x0401C05F RID: 114783
		[Nullable(2)]
		private TimerHandle VoiceCallbackTimeoutTimer;

		// Token: 0x0200B191 RID: 45457
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04035DB3 RID: 220595
			public const int ScrollPanel = 0;

			// Token: 0x04035DB4 RID: 220596
			public const int ChatItem = 1;

			// Token: 0x04035DB5 RID: 220597
			public const int Content = 2;
		}
	}
}
