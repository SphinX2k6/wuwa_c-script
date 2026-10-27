using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005340 RID: 21312
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueSeasonEntranceView : UiTickViewBase
	{
		// Token: 0x06036747 RID: 223047 RVA: 0x00CE4B60 File Offset: 0x00CE2D60
		[NullableContext(1)]
		public RogueSeasonEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036748 RID: 223048 RVA: 0x00CE4B6C File Offset: 0x00CE2D6C
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

		// Token: 0x06036749 RID: 223049 RVA: 0x00CE4DB8 File Offset: 0x00CE2FB8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueSeasonEntranceView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueSeasonEntranceView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603674A RID: 223050 RVA: 0x00CE4DFC File Offset: 0x00CE2FFC
		protected UniTask CheckDungeonProgress()
		{
			RogueSeasonEntranceView.<CheckDungeonProgress>d__12 <CheckDungeonProgress>d__;
			<CheckDungeonProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckDungeonProgress>d__.<>4__this = this;
			<CheckDungeonProgress>d__.<>1__state = -1;
			<CheckDungeonProgress>d__.<>t__builder.Start<RogueSeasonEntranceView.<CheckDungeonProgress>d__12>(ref <CheckDungeonProgress>d__);
			return <CheckDungeonProgress>d__.<>t__builder.Task;
		}

		// Token: 0x0603674B RID: 223051 RVA: 0x00CE4E40 File Offset: 0x00CE3040
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

		// Token: 0x0603674C RID: 223052 RVA: 0x00CE4ED8 File Offset: 0x00CE30D8
		protected override void OnBeforeShow()
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(this.SeasonId, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.Name, Array.Empty<object>());
			this.RefreshButton();
			this.BindRedDot();
			RedDotController.Instance.BindRedDot(ERedDotName.RogueResInst, base.GetItem(16), null, this.SeasonId);
		}

		// Token: 0x0603674D RID: 223053 RVA: 0x00CE4F44 File Offset: 0x00CE3144
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			RogueSeasonEntranceView.<OnBeforeShowAsyncImplement>d__15 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RogueSeasonEntranceView.<OnBeforeShowAsyncImplement>d__15>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603674E RID: 223054 RVA: 0x00CE4F87 File Offset: 0x00CE3187
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RogueResInst, base.GetItem(16), 0);
		}

		// Token: 0x0603674F RID: 223055 RVA: 0x00CE4FA7 File Offset: 0x00CE31A7
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.IllustratedBtnComp = null;
			this.TaskBtnComp = null;
			this.ShopBtnComp = null;
			this.SkillTreeBtnComp = null;
			this.EndingBtnComp = null;
		}

		// Token: 0x06036750 RID: 223056 RVA: 0x00CE4FD3 File Offset: 0x00CE31D3
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06036751 RID: 223057 RVA: 0x00CE4FD5 File Offset: 0x00CE31D5
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06036752 RID: 223058 RVA: 0x00CE4FD8 File Offset: 0x00CE31D8
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

		// Token: 0x06036753 RID: 223059 RVA: 0x00CE5020 File Offset: 0x00CE3220
		[NullableContext(1)]
		protected string GetRemainTime()
		{
			long endTime = MathUtils.Instance.LongToNumber(ActivityPermanentRogueModel.Instance.GetTaskEndTime());
			return ActivityModel.Instance.GetRemainTimeText(endTime, "{0}") ?? "";
		}

		// Token: 0x06036754 RID: 223060 RVA: 0x00CE505B File Offset: 0x00CE325B
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036755 RID: 223061 RVA: 0x00CE5064 File Offset: 0x00CE3264
		private void OnClickHelpInfo()
		{
			int? seasonHelpId = ActivityPermanentRogueModel.Instance.GetSeasonHelpId(this.SeasonId);
			if (seasonHelpId != null)
			{
				HelpController.Instance.OpenHelpById(seasonHelpId.Value);
			}
		}

		// Token: 0x06036756 RID: 223062 RVA: 0x00CE509C File Offset: 0x00CE329C
		private void OnClickIllustrate()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueIllustratedView, null, null);
		}

		// Token: 0x06036757 RID: 223063 RVA: 0x00CE50B0 File Offset: 0x00CE32B0
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

		// Token: 0x06036758 RID: 223064 RVA: 0x00CE5104 File Offset: 0x00CE3304
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

		// Token: 0x06036759 RID: 223065 RVA: 0x00CE5186 File Offset: 0x00CE3386
		private void OnClickSkillTree()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResSkillView, this.SeasonId, null);
		}

		// Token: 0x0603675A RID: 223066 RVA: 0x00CE51A3 File Offset: 0x00CE33A3
		private void OnClickAchievement()
		{
			UiManager.Instance.OpenView(EUiViewName.RogueResEndingView, this.SeasonId, null);
		}

		// Token: 0x0603675B RID: 223067 RVA: 0x00CE51C0 File Offset: 0x00CE33C0
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

		// Token: 0x0603675C RID: 223068 RVA: 0x00CE520C File Offset: 0x00CE340C
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

		// Token: 0x0603675D RID: 223069 RVA: 0x00CE5234 File Offset: 0x00CE3434
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
			rogueDungeonParam.DungeonList = config.Value.InstsIter().ToArray<int>();
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

		// Token: 0x0603675E RID: 223070 RVA: 0x00CE53A4 File Offset: 0x00CE35A4
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

		// Token: 0x0603675F RID: 223071 RVA: 0x00CE5414 File Offset: 0x00CE3614
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

		// Token: 0x06036760 RID: 223072 RVA: 0x00CE559C File Offset: 0x00CE379C
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

		// Token: 0x06036761 RID: 223073 RVA: 0x00CE564C File Offset: 0x00CE384C
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

		// Token: 0x06036762 RID: 223074 RVA: 0x00CE56AD File Offset: 0x00CE38AD
		private void OnConfirmDungeonEntry()
		{
			(ActivityManager.GetActivityController(ActivityType.RogueRes) as ActivityPermanentRogueController).RequestEnterDungeon(this.CurrentDungeon.Value);
		}

		// Token: 0x0401CCEC RID: 117996
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CCED RID: 117997
		private int SeasonId;

		// Token: 0x0401CCEE RID: 117998
		private RogueButtonItemA IllustratedBtnComp;

		// Token: 0x0401CCEF RID: 117999
		private RogueButtonItemA TaskBtnComp;

		// Token: 0x0401CCF0 RID: 118000
		private RogueButtonItemA ShopBtnComp;

		// Token: 0x0401CCF1 RID: 118001
		private RogueButtonItemA SkillTreeBtnComp;

		// Token: 0x0401CCF2 RID: 118002
		private RogueButtonItemA EndingBtnComp;

		// Token: 0x0401CCF3 RID: 118003
		private int? CurrentDungeon;

		// Token: 0x0401CCF4 RID: 118004
		private bool CancelDungeonClicked;
	}
}
