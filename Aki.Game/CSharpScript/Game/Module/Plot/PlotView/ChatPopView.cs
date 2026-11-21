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
	// Token: 0x02004010 RID: 16400
	[NullableContext(1)]
	[Nullable(0)]
	public class ChatPopView : UiViewBase
	{
		// Token: 0x06029818 RID: 170008 RVA: 0x00BB75B7 File Offset: 0x00BB57B7
		public ChatPopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06029819 RID: 170009 RVA: 0x00BB75D8 File Offset: 0x00BB57D8
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

		// Token: 0x0602981A RID: 170010 RVA: 0x00BB7664 File Offset: 0x00BB5864
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

		// Token: 0x0602981B RID: 170011 RVA: 0x00BB7714 File Offset: 0x00BB5914
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

		// Token: 0x0602981C RID: 170012 RVA: 0x00BB776C File Offset: 0x00BB596C
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

		// Token: 0x0602981D RID: 170013 RVA: 0x00BB7783 File Offset: 0x00BB5983
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

		// Token: 0x0602981E RID: 170014 RVA: 0x00BB77BA File Offset: 0x00BB59BA
		private void StartPlay()
		{
			if (this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = true;
			this.ShowNextTalk();
		}

		// Token: 0x0602981F RID: 170015 RVA: 0x00BB77D4 File Offset: 0x00BB59D4
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

		// Token: 0x06029820 RID: 170016 RVA: 0x00BB7A18 File Offset: 0x00BB5C18
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

		// Token: 0x06029821 RID: 170017 RVA: 0x00BB7B04 File Offset: 0x00BB5D04
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

		// Token: 0x06029822 RID: 170018 RVA: 0x00BB7B8C File Offset: 0x00BB5D8C
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

		// Token: 0x06029823 RID: 170019 RVA: 0x00BB7CA8 File Offset: 0x00BB5EA8
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

		// Token: 0x06029824 RID: 170020 RVA: 0x00BB7CC1 File Offset: 0x00BB5EC1
		private void DelayOnAllTalkFinished()
		{
			this.ClearOnAllTalkFinishedTimer();
			this.OnAllTalkFinishedTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnAllTalkFinishedTimer = null;
				this.OnAllTalkFinished();
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x06029825 RID: 170021 RVA: 0x00BB7CF2 File Offset: 0x00BB5EF2
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

		// Token: 0x06029826 RID: 170022 RVA: 0x00BB7D13 File Offset: 0x00BB5F13
		public bool HasMoreTalks()
		{
			return this.CurrentTalkIndex < this.AllTalkItems.Count;
		}

		// Token: 0x06029827 RID: 170023 RVA: 0x00BB7D28 File Offset: 0x00BB5F28
		public int GetRemainingTalkCount()
		{
			return this.AllTalkItems.Count - this.CurrentTalkIndex;
		}

		// Token: 0x06029828 RID: 170024 RVA: 0x00BB7D3C File Offset: 0x00BB5F3C
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

		// Token: 0x06029829 RID: 170025 RVA: 0x00BB7D90 File Offset: 0x00BB5F90
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.UnRegisterCondition();
			this.StopCurrentAudio();
			this.ClearOnAllTalkFinishedTimer();
			this.ClearVoiceCallbackTimeoutTimer();
		}

		// Token: 0x0602982A RID: 170026 RVA: 0x00BB7DB0 File Offset: 0x00BB5FB0
		private void ClearOnAllTalkFinishedTimer()
		{
			if (this.OnAllTalkFinishedTimer != null)
			{
				TimerSystem.Instance.Remove(this.OnAllTalkFinishedTimer);
				this.OnAllTalkFinishedTimer = null;
			}
		}

		// Token: 0x0602982B RID: 170027 RVA: 0x00BB7DD4 File Offset: 0x00BB5FD4
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

		// Token: 0x0602982C RID: 170028 RVA: 0x00BB7E24 File Offset: 0x00BB6024
		private void ClearVoiceCallbackTimeoutTimer()
		{
			if (this.VoiceCallbackTimeoutTimer != null)
			{
				TimerSystem.Instance.Remove(this.VoiceCallbackTimeoutTimer);
				this.VoiceCallbackTimeoutTimer = null;
			}
		}

		// Token: 0x0602982D RID: 170029 RVA: 0x00BB7E48 File Offset: 0x00BB6048
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

		// Token: 0x0602982E RID: 170030 RVA: 0x00BB7EB2 File Offset: 0x00BB60B2
		private ChatItemGrid CreateChatItem()
		{
			return new ChatItemGrid();
		}

		// Token: 0x04016A71 RID: 92785
		private const int MAX_CHAT_ITEM_COUNT = 2;

		// Token: 0x04016A72 RID: 92786
		private const int ON_ALL_TALK_FINISHED_DELAY_MS = 2000;

		// Token: 0x04016A73 RID: 92787
		private const int VOICE_CALLBACK_TIMEOUT_MS = 10000;

		// Token: 0x04016A74 RID: 92788
		private const string PROTAGONIST_ICON_FEMALE = "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_5_a_UI.T_IconRoleHead256_5_a_UI";

		// Token: 0x04016A75 RID: 92789
		private const string PROTAGONIST_ICON_MALE = "/Game/Aki/UI/UIResources/Common/Image/IconRoleHead256/T_IconRoleHead256_4_a_UI.T_IconRoleHead256_4_a_UI";

		// Token: 0x04016A76 RID: 92790
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ChatItemGrid, ChatItemData> ChatLayout;

		// Token: 0x04016A77 RID: 92791
		private readonly List<ChatItemData> AllTalkItems = new List<ChatItemData>();

		// Token: 0x04016A78 RID: 92792
		private readonly List<ChatItemData> DisplayedItems = new List<ChatItemData>();

		// Token: 0x04016A79 RID: 92793
		private int CurrentTalkIndex;

		// Token: 0x04016A7A RID: 92794
		private bool IsPlaying;

		// Token: 0x04016A7B RID: 92795
		private bool IsWaitingCondition;

		// Token: 0x04016A7C RID: 92796
		[Nullable(2)]
		private Action OnAllShownCallback;

		// Token: 0x04016A7D RID: 92797
		private int ConditionId;

		// Token: 0x04016A7E RID: 92798
		[Nullable(2)]
		private ConditionPassCallback ConditionCallback;

		// Token: 0x04016A7F RID: 92799
		private int PlotPlayEventResult;

		// Token: 0x04016A80 RID: 92800
		private int DialogVersion;

		// Token: 0x04016A81 RID: 92801
		[Nullable(2)]
		private TimerHandle OnAllTalkFinishedTimer;

		// Token: 0x04016A82 RID: 92802
		[Nullable(2)]
		private TimerHandle VoiceCallbackTimeoutTimer;

		// Token: 0x02009BCB RID: 39883
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030808 RID: 198664
			public const int ScrollPanel = 0;

			// Token: 0x04030809 RID: 198665
			public const int ChatItem = 1;

			// Token: 0x0403080A RID: 198666
			public const int Content = 2;
		}
	}
}
