using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02004310 RID: 17168
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueSeasonEntranceView : UiTickViewBase
	{
		// Token: 0x0602B643 RID: 177731 RVA: 0x00C32530 File Offset: 0x00C30730
		[NullableContext(1)]
		public RogueSeasonEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B644 RID: 177732 RVA: 0x00C3253C File Offset: 0x00C3073C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUITexture)),
				new ValueTuple<int, Type>(14, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelpInfo)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickCancel)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickEntry)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickTrial))
			};
		}

		// Token: 0x0602B645 RID: 177733 RVA: 0x00C32788 File Offset: 0x00C30988
		protected override UniTask OnBeforeStartAsync()
		{
			RogueSeasonEntranceView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueSeasonEntranceView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B646 RID: 177734 RVA: 0x00C327CC File Offset: 0x00C309CC
		protected UniTask CheckDungeonProgress()
		{
			RogueSeasonEntranceView.<CheckDungeonProgress>d__12 <CheckDungeonProgress>d__;
			<CheckDungeonProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckDungeonProgress>d__.<>4__this = this;
			<CheckDungeonProgress>d__.<>1__state = -1;
			<CheckDungeonProgress>d__.<>t__builder.Start<RogueSeasonEntranceView.<CheckDungeonProgress>d__12>(ref <CheckDungeonProgress>d__);
			return <CheckDungeonProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0602B647 RID: 177735 RVA: 0x00C32810 File Offset: 0x00C30A10
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBack));
			this.CaptionItem.SetTitleTextActive(false);
			this.CaptionItem.SetTitleIconVisible(false);
			this.CaptionItem.SetHelpBtnActive(false);
			long trailEndTime = ActivityPermanentRogueModel.Instance.GetTrailEndTime(this.SeasonId);
			long cacheTrailOpen = ActivityPermanentRogueModel.Instance.GetCacheTrailOpen(this.SeasonId);
			UUIItem item = base.GetItem(15);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(trailEndTime != cacheTrailOpen);
		}

		// Token: 0x0602B648 RID: 177736 RVA: 0x00C328A8 File Offset: 0x00C30AA8
		protected override void OnBeforeShow()
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(this.SeasonId, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.Name, Array.Empty<object>());
			this.RefreshButton();
			this.BindRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.RogueResInst, base.GetItem(16), null, this.SeasonId);
		}

		// Token: 0x0602B649 RID: 177737 RVA: 0x00C32914 File Offset: 0x00C30B14
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RogueSeasonEntranceView.<OnBeforeShowAsyncImplement>d__15 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RogueSeasonEntranceView.<OnBeforeShowAsyncImplement>d__15>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602B64A RID: 177738 RVA: 0x00C32957 File Offset: 0x00C30B57
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RogueResInst, base.GetItem(16), 0);
		}

		// Token: 0x0602B64B RID: 177739 RVA: 0x00C32977 File Offset: 0x00C30B77
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.IllustratedBtnComp = null;
			this.TaskBtnComp = null;
			this.ShopBtnComp = null;
			this.SkillTreeBtnComp = null;
			this.EndingBtnComp = null;
		}

		// Token: 0x0602B64C RID: 177740 RVA: 0x00C329A3 File Offset: 0x00C30BA3
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602B64D RID: 177741 RVA: 0x00C329A5 File Offset: 0x00C30BA5
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602B64E RID: 177742 RVA: 0x00C329A8 File Offset: 0x00C30BA8
		protected override void OnTick(float delta)
		{
			bool taskIsEnd = ActivityPermanentRogueModel.Instance.GetTaskIsEnd();
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(!taskIsEnd);
			}
			if (!taskIsEnd)
			{
				RogueButtonItemA taskBtnComp = this.TaskBtnComp;
				if (taskBtnComp == null)
				{
					return;
				}
				taskBtnComp.SetLimitTime(this.GetRemainTime());
			}
		}

		// Token: 0x0602B64F RID: 177743 RVA: 0x00C329F0 File Offset: 0x00C30BF0
		[NullableContext(1)]
		protected string GetRemainTime()
		{
			long endTime = MathUtils.Instance.LongToNumber(ActivityPermanentRogueModel.Instance.GetTaskEndTime());
			return ActivityModel.Instance.GetRemainTimeText(endTime, "{0}") ?? "";
		}

		// Token: 0x0602B650 RID: 177744 RVA: 0x00C32A2B File Offset: 0x00C30C2B
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B651 RID: 177745 RVA: 0x00C32A34 File Offset: 0x00C30C34
		private void OnClickHelpInfo()
		{
			int? seasonHelpId = ActivityPermanentRogueModel.Instance.GetSeasonHelpId(this.SeasonId);
			if (seasonHelpId != null)
			{
				HelpController.Instance.OpenHelpById(seasonHelpId.Value);
			}
		}

		// Token: 0x0602B652 RID: 177746 RVA: 0x00C32A6C File Offset: 0x00C30C6C
		private void OnClickIllustrate()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueIllustratedView, null, null);
		}

		// Token: 0x0602B653 RID: 177747 RVA: 0x00C32A80 File Offset: 0x00C30C80
		private void OnClickTask()
		{
			long cacheTaskOpen = ActivityPermanentRogueModel.Instance.GetCacheTaskOpen();
			if (TimeUtil.Instance.GetServerTime() >= (double)cacheTaskOpen)
			{
				ActivityPermanentRogueModel.Instance.SetCacheTaskOpen();
				EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
			}
			UiManager.Instance.OpenView(EUiViewName.RogueTaskView, null, null);
		}

		// Token: 0x0602B654 RID: 177748 RVA: 0x00C32AD4 File Offset: 0x00C30CD4
		private void OnClickShop()
		{
			if (ActivityPermanentRogueModel.Instance.CheckShopRedDot(this.SeasonId))
			{
				ActivityPermanentRogueModel.Instance.RefreshShopRedDot(this.SeasonId);
			}
			int shopId = ConfigRogueResThemeById.GetConfig(this.SeasonId, true).Value.ShopId;
			PayShopViewData payShopViewData = new PayShopViewData();
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)shopId;
			payShopViewData.ShowShopIdList = new List<int>
			{
				shopId
			};
			PayShopController.Instance.OpenPayShopView(payShopViewData, delegate(bool success, int viewId)
			{
				int[] shopCount = ActivityPermanentRogueModel.Instance.GetShopCount(this.SeasonId);
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.RefreshShopAccumulateCurrency;
				string p = "Item_Cumulative_Acquisition";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[0]);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[1]);
				instance.Emit<string, IReadOnlyList<string>>(name, p, new <>z__ReadOnlySingleElementList<string>(defaultInterpolatedStringHandler.ToStringAndClear()));
			});
		}

		// Token: 0x0602B655 RID: 177749 RVA: 0x00C32B56 File Offset: 0x00C30D56
		private void OnClickSkillTree()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResSkillView, this.SeasonId, null);
		}

		// Token: 0x0602B656 RID: 177750 RVA: 0x00C32B73 File Offset: 0x00C30D73
		private void OnClickAchievement()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResEndingView, this.SeasonId, null);
		}

		// Token: 0x0602B657 RID: 177751 RVA: 0x00C32B90 File Offset: 0x00C30D90
		private void OnClickCancel()
		{
			if (this.CancelDungeonClicked)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RogueResCancelDungeonConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.ClickedCancelConfirmFunc));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602B658 RID: 177752 RVA: 0x00C32BDC File Offset: 0x00C30DDC
		private void ClickedCancelConfirmFunc()
		{
			this.CancelDungeonClicked = true;
			MapRogueController.Instance.RequestInstResultEnd().ContinueWith(delegate()
			{
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				this.CancelDungeonClicked = false;
				this.CurrentDungeon = new int?(0);
			});
		}

		// Token: 0x0602B659 RID: 177753 RVA: 0x00C32C04 File Offset: 0x00C30E04
		private void OnClickEntry()
		{
			if (this.CancelDungeonClicked)
			{
				Log.Instance.Info(ELogModule.RogueBattle, ELogAuthor.WHJ, "肉鸽进度请求中，未返回。", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int? num;
			int num2;
			if (this.CurrentDungeon != null)
			{
				num = this.CurrentDungeon;
				num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RogueResDungeonContinue);
					confirmBoxDataNew.IsEscViewTriggerCallBack = false;
					confirmBoxDataNew.FunctionMap.Add(1, new Action(this.OnClickCancel));
					confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnConfirmDungeonEntry));
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
			}
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(this.SeasonId, true);
			RogueDungeonParam rogueDungeonParam = new RogueDungeonParam();
			rogueDungeonParam.SeasonId = this.SeasonId;
			rogueDungeonParam.DungeonList = NoLinq.ToArray<int>(config.Value.InstsIter());
			int? cacheDungeonNewest = ActivityPermanentRogueModel.Instance.GetCacheDungeonNewest(this.SeasonId);
			int latestDungeon = ActivityPermanentRogueModel.Instance.GetLatestDungeon(this.SeasonId);
			num = cacheDungeonNewest;
			num2 = latestDungeon;
			if (!(num.GetValueOrDefault() == num2 & num != null))
			{
				ActivityPermanentRogueModel.Instance.SetCacheDungeonNewest(this.SeasonId);
				EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, this.SeasonId);
				ActivityPermanentRogueModel.Instance.SetCurrentSelectedInst(latestDungeon);
			}
			UiManager.Instance.OpenView(EUiViewName.RogueDungeonEntryView, rogueDungeonParam, null);
		}

		// Token: 0x0602B65A RID: 177754 RVA: 0x00C32D74 File Offset: 0x00C30F74
		private void OnClickTrial()
		{
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			long trailEndTime = ActivityPermanentRogueModel.Instance.GetTrailEndTime(this.SeasonId);
			long cacheTrailOpen = ActivityPermanentRogueModel.Instance.GetCacheTrailOpen(this.SeasonId);
			if (trailEndTime != cacheTrailOpen)
			{
				ActivityPermanentRogueModel.Instance.SetCacheTrailOpen(this.SeasonId);
			}
			UiManager.Instance.OpenView(EUiViewName.RogueResTrialView, this.SeasonId, null);
		}

		// Token: 0x0602B65B RID: 177755 RVA: 0x00C32DE4 File Offset: 0x00C30FE4
		private void RefreshButton()
		{
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			RogueButtonItemA illustratedBtnComp = this.IllustratedBtnComp;
			if (illustratedBtnComp != null)
			{
				illustratedBtnComp.SetNum("");
			}
			int[] taskCount = instance.GetTaskCount();
			bool taskIsEnd = instance.GetTaskIsEnd();
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(!taskIsEnd);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (!taskIsEnd)
			{
				RogueButtonItemA taskBtnComp = this.TaskBtnComp;
				if (taskBtnComp != null)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[0]);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[1]);
					taskBtnComp.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				RogueButtonItemA taskBtnComp2 = this.TaskBtnComp;
				if (taskBtnComp2 != null)
				{
					taskBtnComp2.SetLimitTime(this.GetRemainTime());
				}
			}
			int[] shopCount = instance.GetShopCount(this.SeasonId);
			RogueButtonItemA shopBtnComp = this.ShopBtnComp;
			if (shopBtnComp != null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[0]);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[1]);
				shopBtnComp.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			int skillTreeLevel = instance.GetSkillTreeLevel(this.SeasonId);
			RogueButtonItemA skillTreeBtnComp = this.SkillTreeBtnComp;
			if (skillTreeBtnComp != null)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(skillTreeLevel);
				skillTreeBtnComp.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			int[] endingCount = instance.GetEndingCount(this.SeasonId);
			RogueButtonItemA endingBtnComp = this.EndingBtnComp;
			if (endingBtnComp == null)
			{
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingCount[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingCount[1]);
			endingBtnComp.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0602B65C RID: 177756 RVA: 0x00C32F6C File Offset: 0x00C3116C
		private void BindRedDot()
		{
			RogueButtonItemA illustratedBtnComp = this.IllustratedBtnComp;
			if (illustratedBtnComp != null)
			{
				illustratedBtnComp.BindRedDot(ERedDotName.RogueResIllustrated, null);
			}
			RogueButtonItemA taskBtnComp = this.TaskBtnComp;
			if (taskBtnComp != null)
			{
				taskBtnComp.BindRedDot(ERedDotName.RogueResTask, null);
			}
			RogueButtonItemA shopBtnComp = this.ShopBtnComp;
			if (shopBtnComp != null)
			{
				shopBtnComp.BindRedDot(ERedDotName.RogueResShop, new int?(this.SeasonId));
			}
			RogueButtonItemA skillTreeBtnComp = this.SkillTreeBtnComp;
			if (skillTreeBtnComp != null)
			{
				skillTreeBtnComp.BindRedDot(ERedDotName.RogueResSkillTree, new int?(this.SeasonId));
			}
			RogueButtonItemA endingBtnComp = this.EndingBtnComp;
			if (endingBtnComp == null)
			{
				return;
			}
			endingBtnComp.BindRedDot(ERedDotName.RogueResEnding, new int?(this.SeasonId));
		}

		// Token: 0x0602B65D RID: 177757 RVA: 0x00C3301C File Offset: 0x00C3121C
		private void UnbindRedDot()
		{
			RogueButtonItemA illustratedBtnComp = this.IllustratedBtnComp;
			if (illustratedBtnComp != null)
			{
				illustratedBtnComp.UnBindRedDot();
			}
			RogueButtonItemA taskBtnComp = this.TaskBtnComp;
			if (taskBtnComp != null)
			{
				taskBtnComp.UnBindRedDot();
			}
			RogueButtonItemA shopBtnComp = this.ShopBtnComp;
			if (shopBtnComp != null)
			{
				shopBtnComp.UnBindRedDot();
			}
			RogueButtonItemA endingBtnComp = this.EndingBtnComp;
			if (endingBtnComp != null)
			{
				endingBtnComp.UnBindRedDot();
			}
			RogueButtonItemA skillTreeBtnComp = this.SkillTreeBtnComp;
			if (skillTreeBtnComp == null)
			{
				return;
			}
			skillTreeBtnComp.UnBindRedDot();
		}

		// Token: 0x0602B65E RID: 177758 RVA: 0x00C3307D File Offset: 0x00C3127D
		private void OnConfirmDungeonEntry()
		{
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestEnterDungeon(this.CurrentDungeon.Value);
		}

		// Token: 0x04017722 RID: 96034
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017723 RID: 96035
		private int SeasonId;

		// Token: 0x04017724 RID: 96036
		private RogueButtonItemA IllustratedBtnComp;

		// Token: 0x04017725 RID: 96037
		private RogueButtonItemA TaskBtnComp;

		// Token: 0x04017726 RID: 96038
		private RogueButtonItemA ShopBtnComp;

		// Token: 0x04017727 RID: 96039
		private RogueButtonItemA SkillTreeBtnComp;

		// Token: 0x04017728 RID: 96040
		private RogueButtonItemA EndingBtnComp;

		// Token: 0x04017729 RID: 96041
		private int? CurrentDungeon;

		// Token: 0x0401772A RID: 96042
		private bool CancelDungeonClicked;
	}
}
