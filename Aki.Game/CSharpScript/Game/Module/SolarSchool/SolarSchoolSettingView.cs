using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A38 RID: 23096
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolSettingView : UiTickViewBase
	{
		// Token: 0x17006C82 RID: 27778
		// (get) Token: 0x06038F30 RID: 233264 RVA: 0x00FF435E File Offset: 0x00FF255E
		private SolarSchoolSettingViewParam SettingParam
		{
			get
			{
				return this.OpenParam as SolarSchoolSettingViewParam;
			}
		}

		// Token: 0x06038F31 RID: 233265 RVA: 0x00FF436B File Offset: 0x00FF256B
		[NullableContext(1)]
		public SolarSchoolSettingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038F32 RID: 233266 RVA: 0x00FF4380 File Offset: 0x00FF2580
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnSetClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnLookBackClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnBtnSaveClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnBtnExitClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038F33 RID: 233267 RVA: 0x00FF4600 File Offset: 0x00FF2800
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolSettingView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolSettingView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038F34 RID: 233268 RVA: 0x00FF4644 File Offset: 0x00FF2844
		protected override void OnStart()
		{
			Dictionary<int, UUIItem> dictionary = new Dictionary<int, UUIItem>();
			dictionary[0] = base.GetItem(3);
			dictionary[1] = base.GetItem(10);
			Dictionary<int, UUIItem> templateItems = dictionary;
			this.QuestList = new MultiTemplateComponent(base.GetItem(2), templateItems);
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			this.ActivityData = SolarSchoolModel.Instance.GetActivityData(activityId);
		}

		// Token: 0x06038F35 RID: 233269 RVA: 0x00FF46A3 File Offset: 0x00FF28A3
		protected override void OnBeforeShow()
		{
			this.RefreshBtnsInfo();
			this.RefreshMissionList();
			this.RefreshLimitRewardTimeText();
		}

		// Token: 0x06038F36 RID: 233270 RVA: 0x00FF46B8 File Offset: 0x00FF28B8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshBtnsInfo));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshMissionList));
		}

		// Token: 0x06038F37 RID: 233271 RVA: 0x00FF4754 File Offset: 0x00FF2954
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshBtnsInfo));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestUnlocked, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestProgressChanged, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolQuestRewardClaimed, new Action<int>(this.OnQuestChanged));
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshMissionList));
		}

		// Token: 0x06038F38 RID: 233272 RVA: 0x00FF47F0 File Offset: 0x00FF29F0
		private void RefreshBtnsInfo()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			this.LimitTimeRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolLimited));
			this.LimitTimeRewardButtonItem.SetRedDotVisible(activityData.HasLimitTimeReward());
			UiPanelBase normalRewardButtonItem = this.NormalRewardButtonItem;
			SolarSchoolSettingViewParam settingParam = this.SettingParam;
			normalRewardButtonItem.SetUiActive(settingParam == null || !settingParam.HideNormalRewardButton);
			this.NormalRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolResident));
			this.NormalRewardButtonItem.SetRedDotVisible(activityData.GetTaskHasReward(SolarSchoolTaskType.SolarSchoolResident));
			UiPanelBase galleryBtnItem = this.GalleryBtnItem;
			SolarSchoolSettingViewParam settingParam2 = this.SettingParam;
			galleryBtnItem.SetUiActive((settingParam2 == null || !settingParam2.HideGalleryButton) && activityData.IsUnlockGallery);
			this.GalleryBtnItem.SetNumText(activityData.GetAllGalleryNumTextByType(SolarSchoolGalleryType.Ending));
			this.GalleryBtnItem.SetRedDotVisible(activityData.HasAnyGalleryRedDot());
		}

		// Token: 0x06038F39 RID: 233273 RVA: 0x00FF48BC File Offset: 0x00FF2ABC
		private void RefreshMissionList()
		{
			List<int> unfinishedShowingQuestIdList = SolarSchoolGamePlayModel.Instance.QuestData.GetUnfinishedShowingQuestIdList();
			int num = Math.Min(unfinishedShowingQuestIdList.Count, 2);
			bool flag = num <= 0;
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				SolarSchoolQuestDisplay? questDisplayByDayIndex = SolarSchoolConfig.Instance.GetQuestDisplayByDayIndex(SolarSchoolGamePlayModel.Instance.ActivityId, SolarSchoolGamePlayModel.Instance.TimeData.DayIndex);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), (questDisplayByDayIndex != null) ? questDisplayByDayIndex.GetValueOrDefault().NoQuestTips : null, Array.Empty<object>());
			}
			this.QuestDataList.Clear();
			for (int i = 0; i < num; i++)
			{
				IMultiTemplateGridData multiTemplateGridData = SolarSchoolQuestNodeGridData.Create(unfinishedShowingQuestIdList[i], new Action<int>(this.OnQuestClick));
				if (multiTemplateGridData != null)
				{
					this.QuestDataList.Add(multiTemplateGridData);
				}
			}
			MultiTemplateComponent questList = this.QuestList;
			if (questList == null)
			{
				return;
			}
			questList.RefreshByData(this.QuestDataList, false);
		}

		// Token: 0x06038F3A RID: 233274 RVA: 0x00FF49D0 File Offset: 0x00FF2BD0
		private void OnQuestChanged(int questId)
		{
			this.RefreshMissionList();
		}

		// Token: 0x06038F3B RID: 233275 RVA: 0x00FF49D8 File Offset: 0x00FF2BD8
		private void OnQuestClick(int questId)
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolQuestDetailView, new SolarSchoolQuestDetailViewParam
			{
				QuestId = questId
			}, null);
		}

		// Token: 0x06038F3C RID: 233276 RVA: 0x00FF49F6 File Offset: 0x00FF2BF6
		private void OnBtnTuJianClick()
		{
			base.Hide(null);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryView, null, null);
		}

		// Token: 0x06038F3D RID: 233277 RVA: 0x00FF4A10 File Offset: 0x00FF2C10
		private void OnBtnSetClick()
		{
			base.Hide(null);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolVolumeView, null, null);
		}

		// Token: 0x06038F3E RID: 233278 RVA: 0x00FF4A2A File Offset: 0x00FF2C2A
		private void OnBtnSaveClick()
		{
			this.OpenSaveView(ESolarSchoolSaveViewMode.Save);
		}

		// Token: 0x06038F3F RID: 233279 RVA: 0x00FF4A33 File Offset: 0x00FF2C33
		private void OnBtnLookBackClick()
		{
			this.OpenSaveView(ESolarSchoolSaveViewMode.Load);
		}

		// Token: 0x06038F40 RID: 233280 RVA: 0x00FF4A3C File Offset: 0x00FF2C3C
		private void OpenSaveView(ESolarSchoolSaveViewMode mode)
		{
			base.Hide(null);
			SolarSchoolSaveViewParam param = new SolarSchoolSaveViewParam(SolarSchoolGamePlayModel.Instance.ActivityId, mode, true, false, null);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSaveView, param, null);
		}

		// Token: 0x06038F41 RID: 233281 RVA: 0x00FF4A75 File Offset: 0x00FF2C75
		private void OnBtnLimitTimeRewardClick()
		{
			base.Hide(null);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolLimitTimeRewardView, this.ActivityData, null);
		}

		// Token: 0x06038F42 RID: 233282 RVA: 0x00FF4A94 File Offset: 0x00FF2C94
		private void OnBtnNormalRewardClick()
		{
			base.Hide(null);
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolModel.Instance.GetActivityData(activityId);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolNormalRewardView, this.ActivityData, null);
		}

		// Token: 0x06038F43 RID: 233283 RVA: 0x00FF4AD8 File Offset: 0x00FF2CD8
		private void OnBtnExitClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolExitConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.DoExit);
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 退出活动确认框弹出失败，检查 ConfirmBox 配表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", 595);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06038F44 RID: 233284 RVA: 0x00FF4B4C File Offset: 0x00FF2D4C
		private void DoExit()
		{
			this.CloseSelf();
			if (!SolarSchoolGamePlayModel.Instance.IsInGamePlay)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 点击退出时局内已结束，跳过状态机切换", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SolarSchoolGamePlayModel.Instance.LogReporter.ReportStageSettle(ESolarSchoolStageSettleType.Exit);
			SolarSchoolGamePlayModel.Instance.ChangeState(ESolarSchoolStageStateType.GameExit);
		}

		// Token: 0x06038F45 RID: 233285 RVA: 0x00FF4BA6 File Offset: 0x00FF2DA6
		protected override void OnTick(float delta)
		{
			this.RefreshLimitRewardTimeText();
		}

		// Token: 0x06038F46 RID: 233286 RVA: 0x00FF4BB0 File Offset: 0x00FF2DB0
		private void RefreshLimitRewardTimeText()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			bool flag = activityData != null && activityData.CheckIfInRewardTime();
			SolarSchoolEntranceBtnItem limitTimeRewardButtonItem = this.LimitTimeRewardButtonItem;
			if (limitTimeRewardButtonItem != null)
			{
				SolarSchoolSettingViewParam settingParam = this.SettingParam;
				limitTimeRewardButtonItem.SetUiActive((settingParam == null || !settingParam.HideLimitTimeRewardButton) && flag);
			}
			if (!flag)
			{
				return;
			}
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityData, "{0}");
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			if (item)
			{
				SolarSchoolEntranceBtnItem limitTimeRewardButtonItem2 = this.LimitTimeRewardButtonItem;
				if (limitTimeRewardButtonItem2 != null)
				{
					limitTimeRewardButtonItem2.SetTimeText(item2);
				}
			}
			SolarSchoolEntranceBtnItem limitTimeRewardButtonItem3 = this.LimitTimeRewardButtonItem;
			if (limitTimeRewardButtonItem3 == null)
			{
				return;
			}
			limitTimeRewardButtonItem3.SetTimeTextVisible(item);
		}

		// Token: 0x0401DF75 RID: 122741
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DF76 RID: 122742
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DF77 RID: 122743
		private MultiTemplateComponent QuestList;

		// Token: 0x0401DF78 RID: 122744
		[Nullable(1)]
		private readonly List<IMultiTemplateGridData> QuestDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401DF79 RID: 122745
		private SolarSchoolEntranceBtnItem LimitTimeRewardButtonItem;

		// Token: 0x0401DF7A RID: 122746
		private SolarSchoolEntranceBtnItem NormalRewardButtonItem;

		// Token: 0x0401DF7B RID: 122747
		private SolarSchoolEntranceBtnItem GalleryBtnItem;

		// Token: 0x0200B640 RID: 46656
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038603 RID: 230915
			public const int Caption = 0;

			// Token: 0x04038604 RID: 230916
			public const int BtnSet = 1;

			// Token: 0x04038605 RID: 230917
			public const int PnlListItem = 2;

			// Token: 0x04038606 RID: 230918
			public const int ItemQuestBig = 3;

			// Token: 0x04038607 RID: 230919
			public const int BtnLimitTimeReward = 4;

			// Token: 0x04038608 RID: 230920
			public const int BtnNormalReward = 5;

			// Token: 0x04038609 RID: 230921
			public const int BtnLookBack = 6;

			// Token: 0x0403860A RID: 230922
			public const int BtnSave = 7;

			// Token: 0x0403860B RID: 230923
			public const int BtnTuJian = 8;

			// Token: 0x0403860C RID: 230924
			public const int BtnExit = 9;

			// Token: 0x0403860D RID: 230925
			public const int ItemQuestSmall = 10;

			// Token: 0x0403860E RID: 230926
			public const int PnlEmpty = 11;

			// Token: 0x0403860F RID: 230927
			public const int TxtQuestEmpty = 12;
		}
	}
}
