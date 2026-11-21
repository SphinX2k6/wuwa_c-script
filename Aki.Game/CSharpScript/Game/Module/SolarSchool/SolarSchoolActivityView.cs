using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0E RID: 23054
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolActivityView : ActivitySubViewBase
	{
		// Token: 0x06038C39 RID: 232505 RVA: 0x00FE3B48 File Offset: 0x00FE1D48
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.GoGalleryBtnClick))
			};
		}

		// Token: 0x06038C3A RID: 232506 RVA: 0x00FE3CDE File Offset: 0x00FE1EDE
		protected override void OnSetData()
		{
			this.ActivityData = (SolarSchoolActivityData)this.ActivityBaseData;
		}

		// Token: 0x06038C3B RID: 232507 RVA: 0x00FE3CF1 File Offset: 0x00FE1EF1
		[NullableContext(1)]
		public override string GetBgm()
		{
			return "play_ui_music_solarschool_lobby";
		}

		// Token: 0x06038C3C RID: 232508 RVA: 0x00FE3CF8 File Offset: 0x00FE1EF8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolActivityView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolActivityView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C3D RID: 232509 RVA: 0x00FE3D3C File Offset: 0x00FE1F3C
		private UniTask LoadMainSpineAsync()
		{
			SolarSchoolActivityView.<LoadMainSpineAsync>d__14 <LoadMainSpineAsync>d__;
			<LoadMainSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMainSpineAsync>d__.<>4__this = this;
			<LoadMainSpineAsync>d__.<>1__state = -1;
			<LoadMainSpineAsync>d__.<>t__builder.Start<SolarSchoolActivityView.<LoadMainSpineAsync>d__14>(ref <LoadMainSpineAsync>d__);
			return <LoadMainSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C3E RID: 232510 RVA: 0x00FE3D7F File Offset: 0x00FE1F7F
		protected override UniTask OnBeforeShowSelfAsync()
		{
			this.PlayMainSpineStartAnimation();
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C3F RID: 232511 RVA: 0x00FE3D8C File Offset: 0x00FE1F8C
		private void PlayMainSpineStartAnimation()
		{
			if (!this.IsMainSpineReady)
			{
				return;
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(8);
			object obj;
			if (spine == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = spine.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			UUIItem uuiitem = obj as UUIItem;
			if (spine == null || !spine.IsValid() || uuiitem == null || !uuiitem.IsValid())
			{
				return;
			}
			spine.ClearTracks();
			spine.SetToSetupPose();
			spine.SetAnimation(0, "start", false);
			spine.AddAnimation(0, "idle", true, 0f);
			spine.SetTimeScale(1f);
			spine.SetActive(true, false);
			uuiitem.SetUIActive(true);
		}

		// Token: 0x06038C40 RID: 232512 RVA: 0x00FE3E30 File Offset: 0x00FE2030
		protected override void OnRefreshView()
		{
			this.RefreshCommonInfoPanel();
			this.RefreshGalleryLockPanel();
			this.RefreshReddot();
			this.RefreshRewardBtnNum();
		}

		// Token: 0x06038C41 RID: 232513 RVA: 0x00FE3E4A File Offset: 0x00FE204A
		private void NormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolNormalRewardView, this.ActivityData, null);
		}

		// Token: 0x06038C42 RID: 232514 RVA: 0x00FE3E62 File Offset: 0x00FE2062
		private void LimitTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolLimitTimeRewardView, this.ActivityData, null);
		}

		// Token: 0x06038C43 RID: 232515 RVA: 0x00FE3E7A File Offset: 0x00FE207A
		private void GoGalleryBtnClick()
		{
			if (!this.ActivityData.IsUnlockGallery)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryView, null, null);
		}

		// Token: 0x06038C44 RID: 232516 RVA: 0x00FE3E9B File Offset: 0x00FE209B
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityData, EUiViewName.SolarSchoolEntranceView, null, null);
		}

		// Token: 0x06038C45 RID: 232517 RVA: 0x00FE3EB4 File Offset: 0x00FE20B4
		private void RefreshCommonInfoPanel()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.RefreshView();
			}
			ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
			if (commonInfoPanel2 == null)
			{
				return;
			}
			commonInfoPanel2.SetFunctionRedDotVisible(this.ActivityData.GetGoEntranceRedDotState());
		}

		// Token: 0x06038C46 RID: 232518 RVA: 0x00FE3EE4 File Offset: 0x00FE20E4
		private void RefreshRewardBtnNum()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			this.LimitTimeRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolLimited));
			this.NormalRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolResident));
		}

		// Token: 0x06038C47 RID: 232519 RVA: 0x00FE3F1C File Offset: 0x00FE211C
		private void RefreshGalleryLockPanel()
		{
			if (this.PanelGalleryLock == null)
			{
				return;
			}
			bool isUnlockGallery = this.ActivityData.IsUnlockGallery;
			this.PanelGalleryLock.SetActive(!isUnlockGallery);
			base.GetButton(1).SetSelfInteractive(isUnlockGallery);
			int galleryTotalNumByType = this.ActivityData.GetGalleryTotalNumByType(SolarSchoolGalleryType.Ending);
			int galleryUnlockNumByType = this.ActivityData.GetGalleryUnlockNumByType(SolarSchoolGalleryType.Ending);
			base.GetText(7).SetText(galleryTotalNumByType.ToString(), true);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), "SolarSchool_tujianNum0", new <>z__ReadOnlySingleElementList<object>(galleryUnlockNumByType));
		}

		// Token: 0x06038C48 RID: 232520 RVA: 0x00FE3FAC File Offset: 0x00FE21AC
		private void RefreshReddot()
		{
			bool firstOpenRedDotState = this.ActivityData.GetFirstOpenRedDotState();
			this.LimitTimeRewardButtonItem.SetRedDotVisible(firstOpenRedDotState || this.ActivityData.HasLimitTimeReward());
			this.NormalRewardButtonItem.SetRedDotVisible(firstOpenRedDotState || this.ActivityData.GetTaskHasReward(SolarSchoolTaskType.SolarSchoolResident));
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.ActivityData.GetGalleryHasReward(SolarSchoolGalleryType.Ending));
		}

		// Token: 0x06038C49 RID: 232521 RVA: 0x00FE401C File Offset: 0x00FE221C
		private void OnRefreshActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.SetFunctionRedDotVisible(this.ActivityData.GetGoEntranceRedDotState());
			}
			this.RefreshGalleryLockPanel();
			this.RefreshReddot();
			this.RefreshRewardBtnNum();
		}

		// Token: 0x06038C4A RID: 232522 RVA: 0x00FE405B File Offset: 0x00FE225B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x06038C4B RID: 232523 RVA: 0x00FE4079 File Offset: 0x00FE2279
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshActivityRedDot));
		}

		// Token: 0x06038C4C RID: 232524 RVA: 0x00FE4097 File Offset: 0x00FE2297
		protected override void OnBeforeHide()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.ClearFirstOpenRedDot();
		}

		// Token: 0x06038C4D RID: 232525 RVA: 0x00FE40A9 File Offset: 0x00FE22A9
		protected override UniTask OnBeforeHideSelfAsync()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.ClearFirstOpenRedDot();
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C4E RID: 232526 RVA: 0x00FE40C1 File Offset: 0x00FE22C1
		protected override void OnTimer(float delta)
		{
			this.RefreshTimeText();
		}

		// Token: 0x06038C4F RID: 232527 RVA: 0x00FE40CC File Offset: 0x00FE22CC
		private void RefreshTimeText()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			bool flag = activityData != null && activityData.CheckIfInRewardTime();
			SolarSchoolEntranceBtnItem limitTimeRewardButtonItem = this.LimitTimeRewardButtonItem;
			if (limitTimeRewardButtonItem != null)
			{
				limitTimeRewardButtonItem.SetUiActive(flag);
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

		// Token: 0x0401DE1B RID: 122395
		[Nullable(1)]
		private const string MainSpineStartAnimation = "start";

		// Token: 0x0401DE1C RID: 122396
		[Nullable(1)]
		private const string MainSpineIdleAnimation = "idle";

		// Token: 0x0401DE1D RID: 122397
		[Nullable(1)]
		private const string BGM_EVENT = "play_ui_music_solarschool_lobby";

		// Token: 0x0401DE1E RID: 122398
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DE1F RID: 122399
		private ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401DE20 RID: 122400
		private FunctionalPanelConditionLock PanelGalleryLock;

		// Token: 0x0401DE21 RID: 122401
		private SolarSchoolEntranceBtnItem LimitTimeRewardButtonItem;

		// Token: 0x0401DE22 RID: 122402
		private SolarSchoolEntranceBtnItem NormalRewardButtonItem;

		// Token: 0x0401DE23 RID: 122403
		private bool IsMainSpineReady;

		// Token: 0x0200B5C1 RID: 46529
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403834B RID: 230219
			public const int ItemCommonInfo = 0;

			// Token: 0x0403834C RID: 230220
			public const int GoGalleryBtn = 1;

			// Token: 0x0403834D RID: 230221
			public const int GalleryText = 2;

			// Token: 0x0403834E RID: 230222
			public const int GalleryNumText = 3;

			// Token: 0x0403834F RID: 230223
			public const int GalleryLockPanel = 4;

			// Token: 0x04038350 RID: 230224
			public const int LimitTimeRewardBtn = 5;

			// Token: 0x04038351 RID: 230225
			public const int NormalRewardBtn = 6;

			// Token: 0x04038352 RID: 230226
			public const int GalleryValueText = 7;

			// Token: 0x04038353 RID: 230227
			public const int MainSpine = 8;

			// Token: 0x04038354 RID: 230228
			public const int GoGalleryRedDot = 9;
		}
	}
}
