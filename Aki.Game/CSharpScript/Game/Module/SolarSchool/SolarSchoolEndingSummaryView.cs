using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A19 RID: 23065
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolEndingSummaryView : UiViewBase
	{
		// Token: 0x06038CC8 RID: 232648 RVA: 0x00FE5FB8 File Offset: 0x00FE41B8
		public SolarSchoolEndingSummaryView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038CC9 RID: 232649 RVA: 0x00FE5FC4 File Offset: 0x00FE41C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnSkipClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038CCA RID: 232650 RVA: 0x00FE61FC File Offset: 0x00FE43FC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolEndingSummaryView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolEndingSummaryView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CCB RID: 232651 RVA: 0x00FE6240 File Offset: 0x00FE4440
		protected override void OnStart()
		{
			this.UiViewSequence.AddSequenceFinishEvent("Start01", new Action<string>(this.OnStart01SequenceFinished), false);
			this.UiViewSequence.AddSequenceFinishEvent("Start02", new Action<string>(this.OnStart02SequenceFinished), false);
			this.UiViewSequence.AddSequenceFinishEvent("Start03", new Action<string>(this.OnStart03SequenceFinished), false);
		}

		// Token: 0x06038CCC RID: 232652 RVA: 0x00FE62A4 File Offset: 0x00FE44A4
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			this.PlayAudio();
			return UniTask.CompletedTask;
		}

		// Token: 0x06038CCD RID: 232653 RVA: 0x00FE62B1 File Offset: 0x00FE44B1
		protected override void OnFinishShow()
		{
			if (this.SummaryLayout == null)
			{
				return;
			}
			this.SummaryLayout.UnBindLateUpdate();
			this.ScrollViewLateUpdateCount = 0;
			this.SummaryLayout.BindLateUpdate(new Action<float>(this.OnSummaryLayoutLateUpdate));
		}

		// Token: 0x06038CCE RID: 232654 RVA: 0x00FE62E8 File Offset: 0x00FE44E8
		protected override void OnBeforeDestroy()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.RemoveSequenceFinishEvent("Start01", new Action<string>(this.OnStart01SequenceFinished));
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.RemoveSequenceFinishEvent("Start02", new Action<string>(this.OnStart02SequenceFinished));
			}
			UiBehaviorLevelSequence uiViewSequence3 = this.UiViewSequence;
			if (uiViewSequence3 != null)
			{
				uiViewSequence3.RemoveSequenceFinishEvent("Start03", new Action<string>(this.OnStart03SequenceFinished));
			}
			this.ClearTimers();
			GenericLayout<SolarSchoolEndingSummaryItem, SolarSchoolEndingSummaryItemData> summaryLayout = this.SummaryLayout;
			if (summaryLayout != null)
			{
				summaryLayout.UnBindLateUpdate();
			}
			GenericLayout<SolarSchoolEndingSummaryItem, SolarSchoolEndingSummaryItemData> summaryLayout2 = this.SummaryLayout;
			if (summaryLayout2 != null)
			{
				summaryLayout2.ClearChildren();
			}
			this.SummaryLayout = null;
			this.NotifyPresentFinished();
			this.Param = null;
			this.SummaryConfig = null;
			if (this.FirstScreenCoverReleased)
			{
				SolarSchoolModel.Instance.OnLoadingViewHidden();
			}
		}

		// Token: 0x06038CCF RID: 232655 RVA: 0x00FE63B8 File Offset: 0x00FE45B8
		protected override void OnBeforeHide()
		{
			this.ClearTimers();
			GenericLayout<SolarSchoolEndingSummaryItem, SolarSchoolEndingSummaryItemData> summaryLayout = this.SummaryLayout;
			if (summaryLayout != null)
			{
				summaryLayout.UnBindLateUpdate();
			}
			this.StopPresentationSequence("Start");
			this.StopPresentationSequence("Start01");
			this.StopPresentationSequence("Start02");
			this.StopPresentationSequence("Start03");
			if (this.AudioHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.AudioHandle, EAudioActionType.Stop, null);
				this.AudioHandle = 0;
			}
		}

		// Token: 0x06038CD0 RID: 232656 RVA: 0x00FE6434 File Offset: 0x00FE4634
		private void OnSummaryLayoutLateUpdate(float _)
		{
			this.ScrollViewLateUpdateCount++;
			if (this.ScrollViewLateUpdateCount < 2)
			{
				return;
			}
			GenericLayout<SolarSchoolEndingSummaryItem, SolarSchoolEndingSummaryItemData> summaryLayout = this.SummaryLayout;
			if (summaryLayout != null)
			{
				summaryLayout.UnBindLateUpdate();
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}
			this.StartPresentation();
		}

		// Token: 0x06038CD1 RID: 232657 RVA: 0x00FE6488 File Offset: 0x00FE4688
		private void RefreshFixedContent()
		{
			EPlayerGender playerGender = SolarSchoolGamePlayModel.Instance.GetPlayerGender();
			bool flag = playerGender == EPlayerGender.Male;
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUITexture texture2 = base.GetTexture(9);
			if (texture2 != null)
			{
				texture2.SetUIActive(!flag);
			}
			UUITexture texture3 = base.GetTexture(10);
			if (texture3 != null)
			{
				texture3.SetUIActive(flag);
			}
			UUITexture texture4 = base.GetTexture(11);
			if (texture4 != null)
			{
				texture4.SetUIActive(!flag);
			}
			UUITexture texture5 = base.GetTexture(12);
			if (texture5 != null)
			{
				texture5.SetUIActive(flag);
			}
			UUITexture texture6 = base.GetTexture(13);
			if (texture6 != null)
			{
				texture6.SetUIActive(!flag);
			}
			int id = (playerGender == EPlayerGender.Male) ? 101 : 102;
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(id);
			if (role != null)
			{
				base.SetTextureShowUntilLoaded(role.Value.HeadIcon, base.GetTexture(2), null);
			}
			this.RefreshInfluenceName(3, ESolarSchoolInfluence.StudentCouncil);
			this.RefreshInfluenceName(4, ESolarSchoolInfluence.LeagueOfSocieties);
		}

		// Token: 0x06038CD2 RID: 232658 RVA: 0x00FE6570 File Offset: 0x00FE4770
		private unsafe void RefreshInfluenceName(int componentIndex, ESolarSchoolInfluence influence)
		{
			UUIText text = base.GetText(componentIndex);
			if (text == null)
			{
				return;
			}
			int influenceLevel = SolarSchoolGamePlayModel.Instance.PlayerData.GetInfluenceLevel(influence);
			if (influenceLevel <= 0)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "SolarSchool_FactionNotJoined", Array.Empty<object>());
				return;
			}
			SolarSchoolInfluenceLevel? influenceLevelConfig = SolarSchoolConfig.Instance.GetInfluenceLevelConfig(influence, influenceLevel);
			if (influenceLevelConfig == null || string.IsNullOrEmpty(influenceLevelConfig.Value.Name))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 阵营等级配置或名称为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("influence", influence);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", influenceLevel);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				text.SetText(string.Empty, true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, influenceLevelConfig.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06038CD3 RID: 232659 RVA: 0x00FE6670 File Offset: 0x00FE4870
		private IReadOnlyList<SolarSchoolEndingSummaryItemData> BuildSummaryItems(int activityId)
		{
			IReadOnlyList<SolarSchoolSummaryItem> endingSummaryItemList = SolarSchoolConfig.Instance.GetEndingSummaryItemList(activityId);
			List<SolarSchoolEndingSummaryItemData> list = new List<SolarSchoolEndingSummaryItemData>(endingSummaryItemList.Count);
			foreach (SolarSchoolSummaryItem solarSchoolSummaryItem in endingSummaryItemList)
			{
				IReadOnlyList<string> contentParams;
				if (this.TryBuildContentParams((ESolarSchoolEndingSummaryContentType)solarSchoolSummaryItem.ContentType, out contentParams))
				{
					list.Add(new SolarSchoolEndingSummaryItemData(solarSchoolSummaryItem.TitleText, solarSchoolSummaryItem.ContentText, contentParams));
				}
			}
			return list;
		}

		// Token: 0x06038CD4 RID: 232660 RVA: 0x00FE66F4 File Offset: 0x00FE48F4
		private bool TryBuildContentParams(ESolarSchoolEndingSummaryContentType type, out IReadOnlyList<string> contentParams)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			switch (type)
			{
			case ESolarSchoolEndingSummaryContentType.Money:
				contentParams = new <>z__ReadOnlySingleElementList<string>(instance.SummaryRecordData.TotalSummaryData.GainedMoney.ToString());
				return true;
			case ESolarSchoolEndingSummaryContentType.Popularity:
				contentParams = new <>z__ReadOnlySingleElementList<string>(instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Popularity).ToString());
				return true;
			case ESolarSchoolEndingSummaryContentType.MaxFavorRoleNames:
			{
				List<string> list = new List<string>();
				foreach (int id in instance.FriendData.GetMaxFavorRoleIds())
				{
					SolarSchoolRole? solarSchoolRole;
					string text = (SolarSchoolConfig.Instance.GetRole(id) != null) ? solarSchoolRole.GetValueOrDefault().Name : null;
					if (!string.IsNullOrEmpty(text))
					{
						string localTextNew = ConfigMultiTextLang.GetLocalTextNew(text, null);
						if (!string.IsNullOrEmpty(localTextNew))
						{
							list.Add(localTextNew);
						}
					}
				}
				contentParams = new <>z__ReadOnlySingleElementList<string>(string.Join("、", list));
				return list.Count > 0;
			}
			case ESolarSchoolEndingSummaryContentType.CompetitionRank:
			case ESolarSchoolEndingSummaryContentType.ExamScore:
				contentParams = Array.Empty<string>();
				return false;
			case ESolarSchoolEndingSummaryContentType.CompletedSpecialCount:
				contentParams = new <>z__ReadOnlySingleElementList<string>(instance.SummaryRecordData.TotalSummaryData.CompletedNoticeCount.ToString());
				return true;
			default:
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 结局总结条目类型无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("contentType", (int)type);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				contentParams = Array.Empty<string>();
				return false;
			}
			}
		}

		// Token: 0x06038CD5 RID: 232661 RVA: 0x00FE6884 File Offset: 0x00FE4A84
		private void StartPresentation()
		{
			SolarSchoolEndingSummary? summaryConfig = this.SummaryConfig;
			if (summaryConfig != null)
			{
				SolarSchoolEndingSummary valueOrDefault = summaryConfig.GetValueOrDefault();
				this.PlayAudio();
				if (valueOrDefault.ScrollDurationMs <= 0)
				{
					this.FinishScroll();
				}
				else
				{
					this.ScrollElapsedMs = 0f;
					this.ScrollTimer = TimerSystem.Instance.Forever(new TTimerAction(this.TickScroll), 50f, 1f, null, null, true);
				}
				base.PlaySequence("Start01", null, false);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.BB;
			string message = "[SolarSchool] 结局总结播放时配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "viewName";
			UiViewInfo viewInfo = this.ViewInfo;
			ptr = new ValueTuple<string, object>(item, (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "activityId";
			SolarSchoolEndingSummaryViewParam param = this.Param;
			ptr2 = new ValueTuple<string, object>(item2, (param != null) ? new int?(param.ActivityId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06038CD6 RID: 232662 RVA: 0x00FE69A8 File Offset: 0x00FE4BA8
		private void PlayAudio()
		{
			if (this.AudioHandle == 0)
			{
				SolarSchoolEndingSummary? summaryConfig = this.SummaryConfig;
				if (summaryConfig != null)
				{
					SolarSchoolEndingSummary valueOrDefault = summaryConfig.GetValueOrDefault();
					if (!string.IsNullOrEmpty(valueOrDefault.AudioResource))
					{
						this.AudioHandle = AudioSystem.Instance.PostEvent(valueOrDefault.AudioResource);
						return;
					}
				}
			}
		}

		// Token: 0x06038CD7 RID: 232663 RVA: 0x00FE69FC File Offset: 0x00FE4BFC
		private void TickScroll(float deltaMs)
		{
			SolarSchoolEndingSummary? summaryConfig = this.SummaryConfig;
			if (summaryConfig != null)
			{
				SolarSchoolEndingSummary valueOrDefault = summaryConfig.GetValueOrDefault();
				if (valueOrDefault.ScrollDurationMs > 0)
				{
					this.ScrollElapsedMs += deltaMs;
					float num = Math.Clamp(this.ScrollElapsedMs / (float)valueOrDefault.ScrollDurationMs, 0f, 1f);
					UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
					if (scrollViewWithScrollbar != null)
					{
						scrollViewWithScrollbar.SetScrollProgress(num);
					}
					if (num >= 1f)
					{
						this.FinishScroll();
					}
					return;
				}
			}
			this.FinishScroll();
		}

		// Token: 0x06038CD8 RID: 232664 RVA: 0x00FE6A81 File Offset: 0x00FE4C81
		private void FinishScroll()
		{
			this.ClearScrollTimer();
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.SetScrollProgress(1f);
		}

		// Token: 0x06038CD9 RID: 232665 RVA: 0x00FE6A9F File Offset: 0x00FE4C9F
		private void OnStart01SequenceFinished(string _)
		{
			this.FinishScroll();
			base.PlaySequence("Start02", null, true);
		}

		// Token: 0x06038CDA RID: 232666 RVA: 0x00FE6AB4 File Offset: 0x00FE4CB4
		private void OnStart02SequenceFinished(string _)
		{
			base.PlaySequence("Start03", null, true);
		}

		// Token: 0x06038CDB RID: 232667 RVA: 0x00FE6AC4 File Offset: 0x00FE4CC4
		private void OnStart03SequenceFinished(string _)
		{
			int num = (this.SummaryConfig != null) ? this.SummaryConfig.GetValueOrDefault().EndStayDurationMs : 0;
			if (num <= 0)
			{
				this.FinishPresentation();
				return;
			}
			this.EndStayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.EndStayTimer = null;
				this.FinishPresentation();
			}, (float)num, null, null, true, 1f);
			if (this.EndStayTimer == null)
			{
				this.FinishPresentation();
			}
		}

		// Token: 0x06038CDC RID: 232668 RVA: 0x00FE6B30 File Offset: 0x00FE4D30
		private void FinishPresentation()
		{
			this.NotifyPresentFinished();
			this.FirstScreenWaitTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				this.TryReleaseFirstScreenCover();
			}, 50f, 1f, null, null, true);
			if (this.FirstScreenWaitTimer == null)
			{
				this.CloseSelf();
			}
		}

		// Token: 0x06038CDD RID: 232669 RVA: 0x00FE6B6F File Offset: 0x00FE4D6F
		private void NotifyPresentFinished()
		{
			if (this.PresentFinished)
			{
				return;
			}
			this.PresentFinished = true;
			SolarSchoolEndingSummaryViewParam param = this.Param;
			if (param == null)
			{
				return;
			}
			Action onPresentFinished = param.OnPresentFinished;
			if (onPresentFinished == null)
			{
				return;
			}
			onPresentFinished();
		}

		// Token: 0x06038CDE RID: 232670 RVA: 0x00FE6B9B File Offset: 0x00FE4D9B
		private void TryReleaseFirstScreenCover()
		{
			if (this.FirstScreenCoverReleased || !SolarSchoolModel.Instance.IsFirstScreenReady)
			{
				return;
			}
			this.ClearFirstScreenWaitTimer();
			this.FirstScreenCoverReleased = true;
			this.CloseSelf();
		}

		// Token: 0x06038CDF RID: 232671 RVA: 0x00FE6BC5 File Offset: 0x00FE4DC5
		private void OnSkipClick()
		{
			if (this.UiViewSequence == null || !this.UiViewSequence.HasSequenceNameInPlaying("Start01"))
			{
				return;
			}
			this.FinishScroll();
			this.UiViewSequence.StopSequenceByKey("Start01", true, true);
		}

		// Token: 0x06038CE0 RID: 232672 RVA: 0x00FE6BFA File Offset: 0x00FE4DFA
		private void StopPresentationSequence(string sequenceName)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null && uiViewSequence.HasSequenceNameInPlaying(sequenceName))
			{
				this.UiViewSequence.StopSequenceByKey(sequenceName, false, false);
			}
		}

		// Token: 0x06038CE1 RID: 232673 RVA: 0x00FE6C1F File Offset: 0x00FE4E1F
		private void ClearScrollTimer()
		{
			if (this.ScrollTimer != null)
			{
				this.ScrollTimer.Remove();
				this.ScrollTimer = null;
			}
		}

		// Token: 0x06038CE2 RID: 232674 RVA: 0x00FE6C3C File Offset: 0x00FE4E3C
		private void ClearFirstScreenWaitTimer()
		{
			if (this.FirstScreenWaitTimer != null)
			{
				this.FirstScreenWaitTimer.Remove();
				this.FirstScreenWaitTimer = null;
			}
		}

		// Token: 0x06038CE3 RID: 232675 RVA: 0x00FE6C59 File Offset: 0x00FE4E59
		private void ClearTimers()
		{
			this.ClearScrollTimer();
			this.ClearFirstScreenWaitTimer();
			if (this.EndStayTimer != null)
			{
				this.EndStayTimer.Remove();
				this.EndStayTimer = null;
			}
		}

		// Token: 0x0401DE5D RID: 122461
		private const int TimerIntervalMs = 50;

		// Token: 0x0401DE5E RID: 122462
		private const int ScrollViewReadyLateUpdateCount = 2;

		// Token: 0x0401DE5F RID: 122463
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolEndingSummaryItem, SolarSchoolEndingSummaryItemData> SummaryLayout;

		// Token: 0x0401DE60 RID: 122464
		[Nullable(2)]
		private SolarSchoolEndingSummaryViewParam Param;

		// Token: 0x0401DE61 RID: 122465
		private SolarSchoolEndingSummary? SummaryConfig;

		// Token: 0x0401DE62 RID: 122466
		[Nullable(2)]
		private TimerHandle ScrollTimer;

		// Token: 0x0401DE63 RID: 122467
		[Nullable(2)]
		private TimerHandle EndStayTimer;

		// Token: 0x0401DE64 RID: 122468
		[Nullable(2)]
		private TimerHandle FirstScreenWaitTimer;

		// Token: 0x0401DE65 RID: 122469
		private int AudioHandle;

		// Token: 0x0401DE66 RID: 122470
		private float ScrollElapsedMs;

		// Token: 0x0401DE67 RID: 122471
		private int ScrollViewLateUpdateCount;

		// Token: 0x0401DE68 RID: 122472
		private bool PresentFinished;

		// Token: 0x0401DE69 RID: 122473
		private bool FirstScreenCoverReleased;

		// Token: 0x0200B5D9 RID: 46553
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383C5 RID: 230341
			public const int SummaryScrollView = 0;

			// Token: 0x040383C6 RID: 230342
			public const int PlayerNameText = 1;

			// Token: 0x040383C7 RID: 230343
			public const int PlayerHeadTexture = 2;

			// Token: 0x040383C8 RID: 230344
			public const int StudentCouncilNameText = 3;

			// Token: 0x040383C9 RID: 230345
			public const int ClubUnionNameText = 4;

			// Token: 0x040383CA RID: 230346
			public const int SummaryLayout = 5;

			// Token: 0x040383CB RID: 230347
			public const int SummaryItemTemplate = 6;

			// Token: 0x040383CC RID: 230348
			public const int SkipPresentationButton = 7;

			// Token: 0x040383CD RID: 230349
			public const int MalePicTexture = 8;

			// Token: 0x040383CE RID: 230350
			public const int FemalePicTexture = 9;

			// Token: 0x040383CF RID: 230351
			public const int MalePic10Texture = 10;

			// Token: 0x040383D0 RID: 230352
			public const int FemalePic10Texture = 11;

			// Token: 0x040383D1 RID: 230353
			public const int MalePic03Texture = 12;

			// Token: 0x040383D2 RID: 230354
			public const int FemalePic03Texture = 13;
		}
	}
}
