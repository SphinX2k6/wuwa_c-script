using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E6 RID: 23014
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestInfoItem : UiPanelBase
	{
		// Token: 0x06038AF2 RID: 232178 RVA: 0x00FDD734 File Offset: 0x00FDB934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnQuestClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038AF3 RID: 232179 RVA: 0x00FDD8A0 File Offset: 0x00FDBAA0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolQuestInfoItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AF4 RID: 232180 RVA: 0x00FDD8E4 File Offset: 0x00FDBAE4
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.Refresh));
		}

		// Token: 0x06038AF5 RID: 232181 RVA: 0x00FDD97D File Offset: 0x00FDBB7D
		protected override void OnAfterShow()
		{
			this.Refresh();
		}

		// Token: 0x06038AF6 RID: 232182 RVA: 0x00FDD988 File Offset: 0x00FDBB88
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.Refresh));
		}

		// Token: 0x06038AF7 RID: 232183 RVA: 0x00FDDA37 File Offset: 0x00FDBC37
		public void Refresh()
		{
			UiAsyncTaskManager taskManager = this.TaskManager;
			if (taskManager != null)
			{
				taskManager.CancelPendingByName("SolarSchoolQuestInfoItem.Refresh");
			}
			base.RunAsyncTask(new UiAsyncTask("SolarSchoolQuestInfoItem.Refresh", new Func<UniTask>(this.RefreshAsync), null)).Forget();
		}

		// Token: 0x06038AF8 RID: 232184 RVA: 0x00FDDA74 File Offset: 0x00FDBC74
		private UniTask RefreshAsync()
		{
			SolarSchoolQuestInfoItem.<RefreshAsync>d__15 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoItem.<RefreshAsync>d__15>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AF9 RID: 232185 RVA: 0x00FDDAB8 File Offset: 0x00FDBCB8
		private bool IsSameIdList(IReadOnlyList<int> a, IReadOnlyList<int> b)
		{
			if (a.Count != b.Count)
			{
				return false;
			}
			for (int i = 0; i < a.Count; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038AFA RID: 232186 RVA: 0x00FDDAF9 File Offset: 0x00FDBCF9
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName != "Sequence_Switch")
			{
				return;
			}
			CustomPromise<bool> switchPromise = this.SwitchPromise;
			if (switchPromise == null)
			{
				return;
			}
			switchPromise.SetResult(true);
		}

		// Token: 0x06038AFB RID: 232187 RVA: 0x00FDDB1C File Offset: 0x00FDBD1C
		private UniTask PlaySwitchAsync(IReadOnlyList<int> questIds)
		{
			SolarSchoolQuestInfoItem.<PlaySwitchAsync>d__18 <PlaySwitchAsync>d__;
			<PlaySwitchAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwitchAsync>d__.<>4__this = this;
			<PlaySwitchAsync>d__.questIds = questIds;
			<PlaySwitchAsync>d__.<>1__state = -1;
			<PlaySwitchAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoItem.<PlaySwitchAsync>d__18>(ref <PlaySwitchAsync>d__);
			return <PlaySwitchAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AFC RID: 232188 RVA: 0x00FDDB68 File Offset: 0x00FDBD68
		private UniTask RefreshContentAsync(IReadOnlyList<int> questIds)
		{
			SolarSchoolQuestInfoItem.<RefreshContentAsync>d__19 <RefreshContentAsync>d__;
			<RefreshContentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshContentAsync>d__.<>4__this = this;
			<RefreshContentAsync>d__.questIds = questIds;
			<RefreshContentAsync>d__.<>1__state = -1;
			<RefreshContentAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoItem.<RefreshContentAsync>d__19>(ref <RefreshContentAsync>d__);
			return <RefreshContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AFD RID: 232189 RVA: 0x00FDDBB4 File Offset: 0x00FDBDB4
		private void RefreshContentState(IReadOnlyList<int> questIds)
		{
			SolarSchoolQuestDisplay? currentDisplayRow = this.GetCurrentDisplayRow();
			int num = this.FindImportantQuestId(questIds);
			bool flag = questIds.Count > 0 && num == 0;
			this.SetScrollListVisible(flag);
			base.GetItem(6).SetUIActive(!flag);
			if (num != 0)
			{
				SolarSchoolQuest? solarSchoolQuest;
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), (SolarSchoolConfig.Instance.GetQuest(num) != null) ? solarSchoolQuest.GetValueOrDefault().MainDesc : null, Array.Empty<object>());
			}
			else if (!flag)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), (currentDisplayRow != null) ? currentDisplayRow.GetValueOrDefault().NoQuestTips : null, Array.Empty<object>());
			}
			this.RefreshCountdown(currentDisplayRow);
			this.RefreshTip(flag && this.HasRedDotQuest(questIds));
		}

		// Token: 0x06038AFE RID: 232190 RVA: 0x00FDDC8C File Offset: 0x00FDBE8C
		private void RefreshTip(bool showTip)
		{
			bool? isTipShown = this.IsTipShown;
			if (isTipShown.GetValueOrDefault() == showTip & isTipShown != null)
			{
				return;
			}
			this.IsTipShown = new bool?(showTip);
			if (showTip)
			{
				this.SequencePlayer.PlayOrReplaySequenceByName("Tip_Start", false, null);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Tip_Close", false, false, null, null, true);
		}

		// Token: 0x06038AFF RID: 232191 RVA: 0x00FDDD00 File Offset: 0x00FDBF00
		private bool HasRedDotQuest(IReadOnlyList<int> questIds)
		{
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (int questId in questIds)
			{
				SolarSchoolSingleQuestData questData2 = questData.GetQuestData(questId);
				if (questData2 != null && questData2.ShouldShowQuestUnlockRedDot)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038B00 RID: 232192 RVA: 0x00FDDD68 File Offset: 0x00FDBF68
		private int FindImportantQuestId(IReadOnlyList<int> questIds)
		{
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (int num in questIds)
			{
				SolarSchoolSingleQuestData questData2 = questData.GetQuestData(num);
				if (questData2 != null && questData2.QuestType == ESolarSchoolQuestShowType.Important)
				{
					return num;
				}
			}
			return 0;
		}

		// Token: 0x06038B01 RID: 232193 RVA: 0x00FDDDD4 File Offset: 0x00FDBFD4
		private UniTask PlayPendingSuccessAsync()
		{
			SolarSchoolQuestInfoItem.<PlayPendingSuccessAsync>d__24 <PlayPendingSuccessAsync>d__;
			<PlayPendingSuccessAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPendingSuccessAsync>d__.<>4__this = this;
			<PlayPendingSuccessAsync>d__.<>1__state = -1;
			<PlayPendingSuccessAsync>d__.<>t__builder.Start<SolarSchoolQuestInfoItem.<PlayPendingSuccessAsync>d__24>(ref <PlayPendingSuccessAsync>d__);
			return <PlayPendingSuccessAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B02 RID: 232194 RVA: 0x00FDDE18 File Offset: 0x00FDC018
		private void RefreshCountdown(SolarSchoolQuestDisplay? displayRow)
		{
			if (displayRow == null)
			{
				return;
			}
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			if (dayIndex == displayRow.Value.EndDayIndex)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "SolarSchool_QuestPanel_Time_TheDay", Array.Empty<object>());
				return;
			}
			int num = displayRow.Value.EndDayIndex - dayIndex;
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(SolarSchoolGamePlayModel.Instance.ActivityId, "QuestDeadlineCountDownTime", 0);
			string textStringId = (num < paramInt) ? "SolarSchool_QuestPanel_Time_Deadline" : "SolarSchool_QuestPanel_Time";
			string text = ConfigMultiTextLang.GetLocalTextNew(displayRow.Value.TxtEndDayParam, null) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				text,
				num.ToString()
			}));
		}

		// Token: 0x06038B03 RID: 232195 RVA: 0x00FDDEFA File Offset: 0x00FDC0FA
		private SolarSchoolQuestDisplay? GetCurrentDisplayRow()
		{
			return SolarSchoolConfig.Instance.GetQuestDisplayByDayIndex(SolarSchoolGamePlayModel.Instance.ActivityId, SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
		}

		// Token: 0x06038B04 RID: 232196 RVA: 0x00FDDF20 File Offset: 0x00FDC120
		private void SetScrollListVisible(bool visible)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x06038B05 RID: 232197 RVA: 0x00FDDF51 File Offset: 0x00FDC151
		[NullableContext(2)]
		public UUIItem GetGuideEntryItem(int displayOrder)
		{
			GenericLayout<SolarSchoolQuestInfoEntryItem, int> contentLayout = this.ContentLayout;
			if (contentLayout == null)
			{
				return null;
			}
			SolarSchoolQuestInfoEntryItem layoutItemByIndex = contentLayout.GetLayoutItemByIndex(displayOrder - 1);
			if (layoutItemByIndex == null)
			{
				return null;
			}
			return layoutItemByIndex.GetGuideEntryItem();
		}

		// Token: 0x06038B06 RID: 232198 RVA: 0x00FDDF72 File Offset: 0x00FDC172
		private SolarSchoolQuestInfoEntryItem CreateContentItem()
		{
			return new SolarSchoolQuestInfoEntryItem();
		}

		// Token: 0x06038B07 RID: 232199 RVA: 0x00FDDF79 File Offset: 0x00FDC179
		private void OnQuestChanged(int questId)
		{
			this.Refresh();
		}

		// Token: 0x06038B08 RID: 232200 RVA: 0x00FDDF81 File Offset: 0x00FDC181
		private void OnBtnQuestClick()
		{
			SolarSchoolGamePlayModel.Instance.OpenQuestView();
		}

		// Token: 0x0401DD96 RID: 122262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolQuestInfoEntryItem, int> ContentLayout;

		// Token: 0x0401DD97 RID: 122263
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DD98 RID: 122264
		[Nullable(2)]
		private CustomPromise<bool> SwitchPromise;

		// Token: 0x0401DD99 RID: 122265
		private bool? IsTipShown;

		// Token: 0x0401DD9A RID: 122266
		private const string SwitchEvent = "Sequence_Switch";

		// Token: 0x0401DD9B RID: 122267
		private const string TipStartSequence = "Tip_Start";

		// Token: 0x0401DD9C RID: 122268
		private const string TipCloseSequence = "Tip_Close";

		// Token: 0x0401DD9D RID: 122269
		private const string RefreshTaskName = "SolarSchoolQuestInfoItem.Refresh";

		// Token: 0x0200B598 RID: 46488
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038277 RID: 230007
			public const int BtnQuest = 0;

			// Token: 0x04038278 RID: 230008
			public const int ContentLayout = 1;

			// Token: 0x04038279 RID: 230009
			public const int ContentItem = 2;

			// Token: 0x0403827A RID: 230010
			public const int PnlTips = 3;

			// Token: 0x0403827B RID: 230011
			public const int TxtTips = 4;

			// Token: 0x0403827C RID: 230012
			public const int ScrollList = 5;

			// Token: 0x0403827D RID: 230013
			public const int PnlEmpty = 6;

			// Token: 0x0403827E RID: 230014
			public const int TxtEmpty = 7;
		}
	}
}
