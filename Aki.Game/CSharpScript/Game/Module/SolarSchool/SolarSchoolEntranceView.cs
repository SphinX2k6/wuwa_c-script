using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A1B RID: 23067
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolEntranceView : UiTickViewBase
	{
		// Token: 0x06038CEF RID: 232687 RVA: 0x00FE6E10 File Offset: 0x00FE5010
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x06038CF0 RID: 232688 RVA: 0x00FE6ED8 File Offset: 0x00FE50D8
		private void GalleryBtnClick()
		{
			if (!this.ActivityData.IsUnlockGallery)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchoolCollectionUnlocked", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolGalleryView, null, null);
		}

		// Token: 0x06038CF1 RID: 232689 RVA: 0x00FE6F10 File Offset: 0x00FE5110
		private void ContinueBtnClick()
		{
			if (this.ActivityData.GetSavePreview(0) == null)
			{
				return;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
				return;
			}
			if (this.IsEnteringGame())
			{
				return;
			}
			this.IsRequestingLoad = true;
			SolarSchoolController.Instance.RequestLoad(this.ActivityData.Id, 0, new Action<bool>(this.OnLoadResopnse), delegate
			{
				SolarSchoolModel.Instance.OpenLoadingView();
			});
		}

		// Token: 0x06038CF2 RID: 232690 RVA: 0x00FE6FA1 File Offset: 0x00FE51A1
		private void OnLoadResopnse(bool success)
		{
			this.IsRequestingLoad = false;
			if (!success && SolarSchoolModel.Instance.IsLoadingViewOpen())
			{
				SolarSchoolModel.Instance.CloseLoadingView();
			}
		}

		// Token: 0x06038CF3 RID: 232691 RVA: 0x00FE6FC3 File Offset: 0x00FE51C3
		private bool IsEnteringGame()
		{
			return this.IsRequestingLoad || SolarSchoolGamePlayModel.Instance.IsInGamePlay;
		}

		// Token: 0x06038CF4 RID: 232692 RVA: 0x00FE6FDC File Offset: 0x00FE51DC
		private void StartBtnClick()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
				return;
			}
			this.ActivityData.ClearStartBtnRedDot();
			this.StartBtnItem.SetRedDotVisible(false);
			if (this.ActivityData.GetSavePreview(0) == null)
			{
				this.StartNewGame();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolNewGameOverwriteConfirm);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.StartNewGame);
			if (!ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 新游戏覆盖存档确认框弹出失败，检查 ConfirmBox 配表";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", 713);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06038CF5 RID: 232693 RVA: 0x00FE7099 File Offset: 0x00FE5299
		private void StartNewGame()
		{
			if (this.IsEnteringGame())
			{
				return;
			}
			SolarSchoolController.Instance.StartGame(this.ActivityData.Id);
		}

		// Token: 0x06038CF6 RID: 232694 RVA: 0x00FE70BC File Offset: 0x00FE52BC
		private void LookBackBtnClick()
		{
			SolarSchoolSaveViewParam param = new SolarSchoolSaveViewParam(this.ActivityData.Id, ESolarSchoolSaveViewMode.Load, false, false, null);
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSaveView, param, null);
		}

		// Token: 0x06038CF7 RID: 232695 RVA: 0x00FE70EF File Offset: 0x00FE52EF
		private void NormalRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolNormalRewardView, this.ActivityData, null);
		}

		// Token: 0x06038CF8 RID: 232696 RVA: 0x00FE7107 File Offset: 0x00FE5307
		private void LimitTimeRewardBtnClick()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolLimitTimeRewardView, this.ActivityData, null);
		}

		// Token: 0x06038CF9 RID: 232697 RVA: 0x00FE711F File Offset: 0x00FE531F
		[NullableContext(1)]
		public SolarSchoolEntranceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038CFA RID: 232698 RVA: 0x00FE7128 File Offset: 0x00FE5328
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolEntranceView.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolEntranceView.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CFB RID: 232699 RVA: 0x00FE716C File Offset: 0x00FE536C
		private UniTask LoadMainSpineAsync()
		{
			SolarSchoolEntranceView.<LoadMainSpineAsync>d__23 <LoadMainSpineAsync>d__;
			<LoadMainSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMainSpineAsync>d__.<>4__this = this;
			<LoadMainSpineAsync>d__.<>1__state = -1;
			<LoadMainSpineAsync>d__.<>t__builder.Start<SolarSchoolEntranceView.<LoadMainSpineAsync>d__23>(ref <LoadMainSpineAsync>d__);
			return <LoadMainSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CFC RID: 232700 RVA: 0x00FE71B0 File Offset: 0x00FE53B0
		protected override void OnStart()
		{
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
			this.CaptionItem.SetCloseVisible(true);
			this.CaptionItem.SetHelpGroupId(this.ActivityData.LocalConfig.Value.HelpId);
		}

		// Token: 0x06038CFD RID: 232701 RVA: 0x00FE71FC File Offset: 0x00FE53FC
		protected override void OnBeforeShow()
		{
			this.ActivityData.ClearGoEntranceRedDot();
			this.RefreshReddot();
			this.RefreshContinueBtn();
			this.RefreshRewardBtnNum();
			this.RefreshGalleryBtnNum();
			this.RefreshTimeText();
		}

		// Token: 0x06038CFE RID: 232702 RVA: 0x00FE7227 File Offset: 0x00FE5427
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.OnGalleryUpdate));
			EventSystem.Instance.Add(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnRewardTaskUpdate));
		}

		// Token: 0x06038CFF RID: 232703 RVA: 0x00FE7261 File Offset: 0x00FE5461
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.OnGalleryUpdate));
			EventSystem.Instance.Remove(EEventName.SolarSchoolRewardTaskUpdate, new Action(this.OnRewardTaskUpdate));
		}

		// Token: 0x06038D00 RID: 232704 RVA: 0x00FE729B File Offset: 0x00FE549B
		private void OnGalleryUpdate()
		{
			this.RefreshReddot();
			this.RefreshGalleryBtnNum();
		}

		// Token: 0x06038D01 RID: 232705 RVA: 0x00FE72A9 File Offset: 0x00FE54A9
		private void OnRewardTaskUpdate()
		{
			this.RefreshReddot();
			this.RefreshRewardBtnNum();
		}

		// Token: 0x06038D02 RID: 232706 RVA: 0x00FE72B8 File Offset: 0x00FE54B8
		private void RefreshContinueBtn()
		{
			bool flag = this.ActivityData.GetSavePreview(0) == null;
			this.ContinueBtnItem.SetUiActive(!flag);
		}

		// Token: 0x06038D03 RID: 232707 RVA: 0x00FE72E4 File Offset: 0x00FE54E4
		private void RefreshRewardBtnNum()
		{
			SolarSchoolActivityData activityData = this.ActivityData;
			this.LimitTimeRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolLimited));
			this.NormalRewardButtonItem.SetNumText(activityData.GetAllFinishTaskNumTextByType(SolarSchoolTaskType.SolarSchoolResident));
		}

		// Token: 0x06038D04 RID: 232708 RVA: 0x00FE731C File Offset: 0x00FE551C
		private void RefreshGalleryBtnNum()
		{
			this.GalleryBtnItem.SetNumText(this.ActivityData.GetAllGalleryNumTextByType(SolarSchoolGalleryType.Ending));
		}

		// Token: 0x06038D05 RID: 232709 RVA: 0x00FE7338 File Offset: 0x00FE5538
		private void RefreshReddot()
		{
			this.LimitTimeRewardButtonItem.SetRedDotVisible(this.ActivityData.HasLimitTimeReward());
			this.NormalRewardButtonItem.SetRedDotVisible(this.ActivityData.GetTaskHasReward(SolarSchoolTaskType.SolarSchoolResident));
			this.GalleryBtnItem.SetRedDotVisible(this.ActivityData.HasAnyGalleryRedDot());
			this.StartBtnItem.SetRedDotVisible(this.ActivityData.GetStartBtnRedDotState());
			this.ContinueBtnItem.SetRedDotVisible(this.ActivityData.GetSavePreview(0) != null);
		}

		// Token: 0x06038D06 RID: 232710 RVA: 0x00FE73B8 File Offset: 0x00FE55B8
		protected override void OnTick(float delta)
		{
			this.RefreshTimeText();
		}

		// Token: 0x06038D07 RID: 232711 RVA: 0x00FE73C0 File Offset: 0x00FE55C0
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

		// Token: 0x0401DE6B RID: 122475
		[Nullable(1)]
		private const string MainSpineAnimation = "idle";

		// Token: 0x0401DE6C RID: 122476
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DE6D RID: 122477
		private SolarSchoolCaptionItem CaptionItem;

		// Token: 0x0401DE6E RID: 122478
		private SolarSchoolEntranceBtnItem LimitTimeRewardButtonItem;

		// Token: 0x0401DE6F RID: 122479
		private SolarSchoolEntranceBtnItem NormalRewardButtonItem;

		// Token: 0x0401DE70 RID: 122480
		private SolarSchoolBtnItem StartBtnItem;

		// Token: 0x0401DE71 RID: 122481
		private SolarSchoolEntranceBtnItem GalleryBtnItem;

		// Token: 0x0401DE72 RID: 122482
		private SolarSchoolEntranceBtnItem LookBackBtnItem;

		// Token: 0x0401DE73 RID: 122483
		private SolarSchoolBtnItem ContinueBtnItem;

		// Token: 0x0401DE74 RID: 122484
		private bool IsRequestingLoad;

		// Token: 0x0200B5DD RID: 46557
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383DE RID: 230366
			public const int CaptionItem = 0;

			// Token: 0x040383DF RID: 230367
			public const int LimitTimeRewardBtn = 1;

			// Token: 0x040383E0 RID: 230368
			public const int NormalRewardBtn = 2;

			// Token: 0x040383E1 RID: 230369
			public const int ContinueBtn = 3;

			// Token: 0x040383E2 RID: 230370
			public const int StartBtn = 4;

			// Token: 0x040383E3 RID: 230371
			public const int LookBackBtn = 5;

			// Token: 0x040383E4 RID: 230372
			public const int GalleryBtn = 6;

			// Token: 0x040383E5 RID: 230373
			public const int MainSpine = 7;
		}
	}
}
