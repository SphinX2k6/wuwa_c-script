using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042D4 RID: 17108
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewPermanentRogue : ActivitySubViewBase
	{
		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x0602B4ED RID: 177389 RVA: 0x00C2A72A File Offset: 0x00C2892A
		protected new ActivityPermanentRogueData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityPermanentRogueData;
			}
		}

		// Token: 0x0602B4EE RID: 177390 RVA: 0x00C2A738 File Offset: 0x00C28938
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickedHelp))
			};
		}

		// Token: 0x0602B4EF RID: 177391 RVA: 0x00C2A868 File Offset: 0x00C28A68
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewPermanentRogue.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewPermanentRogue.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B4F0 RID: 177392 RVA: 0x00C2A8AB File Offset: 0x00C28AAB
		protected override void OnStart()
		{
			this.ActivityInfoComp.SetBtnText("PrefabTextItem_632974650_Text", Array.Empty<object>());
		}

		// Token: 0x0602B4F1 RID: 177393 RVA: 0x00C2A8C4 File Offset: 0x00C28AC4
		protected override void OnRefreshView()
		{
			this.NewSeasonId = ActivityPermanentRogueModel.Instance.GetNewSeasonId();
			bool functionRedDotVisible = ActivityPermanentRogueModel.Instance.GetActivityData().CheckAllRightSideRedDot();
			RogueResActivitySubViewGeneralInfo activityInfoComp = this.ActivityInfoComp;
			if (activityInfoComp != null)
			{
				activityInfoComp.SetFunctionRedDotVisible(functionRedDotVisible);
			}
			this.RefreshBtn();
			this.BindRedDot();
			this.RefreshChallenge();
			RogueResTheme value = ConfigRogueResThemeById.GetConfig(this.NewSeasonId, true).Value;
			RogueResActivitySubViewGeneralInfo activityInfoComp2 = this.ActivityInfoComp;
			if (activityInfoComp2 != null)
			{
				activityInfoComp2.SetSubTitleTextById(value.Name);
			}
			RogueResTheme value2 = ConfigRogueResThemeById.GetConfig(this.NewSeasonId, true).Value;
			string path = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? value2.CoverF : value2.CoverM;
			base.SetTextureByPath(path, base.GetTexture(7), null, null);
			base.GetSpine(8).SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
			if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EPermanentRogueSaveFlag.FirstOpen))
			{
				this.OnClickedHelp();
			}
		}

		// Token: 0x0602B4F2 RID: 177394 RVA: 0x00C2A9DD File Offset: 0x00C28BDD
		protected override void OnBeforeHide()
		{
			this.UnbindRedDot();
		}

		// Token: 0x0602B4F3 RID: 177395 RVA: 0x00C2A9E5 File Offset: 0x00C28BE5
		protected override void OnBeforeDestroy()
		{
			this.ActivityInfoComp = null;
			this.BtnRogueA = null;
			this.BtnRogueB = null;
		}

		// Token: 0x0602B4F4 RID: 177396 RVA: 0x00C2A9FC File Offset: 0x00C28BFC
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602B4F5 RID: 177397 RVA: 0x00C2A9FE File Offset: 0x00C28BFE
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602B4F6 RID: 177398 RVA: 0x00C2AA00 File Offset: 0x00C28C00
		private void OnClickEnterFunc(ActivityBaseData _)
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			RogueResTheme value = ConfigRogueResThemeById.GetConfig(this.NewSeasonId, true).Value;
			UiManager.Instance.OpenView((EUiViewName)value.ViewName, this.NewSeasonId, null);
		}

		// Token: 0x0602B4F7 RID: 177399 RVA: 0x00C2AA74 File Offset: 0x00C28C74
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

		// Token: 0x0602B4F8 RID: 177400 RVA: 0x00C2AAC8 File Offset: 0x00C28CC8
		private unsafe void OnClickShop()
		{
			if (ActivityPermanentRogueModel.Instance.CheckShopRedDot(this.NewSeasonId))
			{
				ActivityPermanentRogueModel.Instance.RefreshShopRedDot(this.NewSeasonId);
			}
			int shopId = ConfigRogueResThemeById.GetConfig(this.NewSeasonId, true).Value.ShopId;
			PayShopViewData payShopViewData = new PayShopViewData();
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)shopId;
			PayShopViewData payShopViewData2 = payShopViewData;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = shopId;
			payShopViewData2.ShowShopIdList = list;
			PayShopController.Instance.OpenPayShopView(payShopViewData, delegate(bool _, int _)
			{
				int[] shopCount = ActivityPermanentRogueModel.Instance.GetShopCount(this.NewSeasonId);
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

		// Token: 0x0602B4F9 RID: 177401 RVA: 0x00C2AB68 File Offset: 0x00C28D68
		private void BindRedDot()
		{
			RogueButtonItemA btnRogueA = this.BtnRogueA;
			if (btnRogueA != null)
			{
				btnRogueA.BindRedDot(ERedDotName.RogueResTask, null);
			}
			RogueButtonItemA btnRogueB = this.BtnRogueB;
			if (btnRogueB == null)
			{
				return;
			}
			btnRogueB.BindRedDot(ERedDotName.RogueResShop, new int?(this.NewSeasonId));
		}

		// Token: 0x0602B4FA RID: 177402 RVA: 0x00C2ABB4 File Offset: 0x00C28DB4
		private void UnbindRedDot()
		{
			RogueButtonItemA btnRogueA = this.BtnRogueA;
			if (btnRogueA != null)
			{
				btnRogueA.UnBindRedDot();
			}
			RogueButtonItemA btnRogueB = this.BtnRogueB;
			if (btnRogueB == null)
			{
				return;
			}
			btnRogueB.UnBindRedDot();
		}

		// Token: 0x0602B4FB RID: 177403 RVA: 0x00C2ABD8 File Offset: 0x00C28DD8
		private void RefreshBtn()
		{
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			bool flag = this.ActivityBaseData.IsUnLock();
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			if (flag && preGuideQuestFinishState)
			{
				int[] taskCount = instance.GetTaskCount();
				bool taskIsEnd = instance.GetTaskIsEnd();
				UUIItem item = base.GetItem(9);
				if (item != null)
				{
					item.SetUIActive(!taskIsEnd);
				}
				RogueButtonItemA btnRogueA = this.BtnRogueA;
				if (btnRogueA != null)
				{
					btnRogueA.SetUiActive(!taskIsEnd);
				}
				RogueButtonItemA btnRogueA2 = this.BtnRogueA;
				if (btnRogueA2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[0]);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(taskCount[1]);
					btnRogueA2.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				RogueButtonItemA btnRogueB = this.BtnRogueB;
				if (btnRogueB != null)
				{
					btnRogueB.SetUiActive(true);
				}
				int[] shopCount = instance.GetShopCount(this.NewSeasonId);
				RogueButtonItemA btnRogueB2 = this.BtnRogueB;
				if (btnRogueB2 != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[0]);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(shopCount[1]);
					btnRogueB2.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			else
			{
				RogueButtonItemA btnRogueA3 = this.BtnRogueA;
				if (btnRogueA3 != null)
				{
					btnRogueA3.SetUiActive(false);
				}
				RogueButtonItemA btnRogueB3 = this.BtnRogueB;
				if (btnRogueB3 != null)
				{
					btnRogueB3.SetUiActive(false);
				}
			}
			RogueResActivitySubViewGeneralInfo activityInfoComp = this.ActivityInfoComp;
			ActivityFunctionalTypeA activityFunctionalTypeA = (activityInfoComp != null) ? activityInfoComp.GetFunctional() : null;
			if (activityFunctionalTypeA == null)
			{
				return;
			}
			ActivityButtonItem functionButton = activityFunctionalTypeA.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetUiActive(flag);
		}

		// Token: 0x0602B4FC RID: 177404 RVA: 0x00C2AD3C File Offset: 0x00C28F3C
		private void RefreshChallenge()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
			if (flag && preGuideQuestFinishState)
			{
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				int latestDungeonIndex = ActivityPermanentRogueModel.Instance.GetLatestDungeonIndex(this.NewSeasonId);
				base.GetItem(6).SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "PrefabTextItem_2589264504_Text", new <>z__ReadOnlySingleElementList<object>(latestDungeonIndex + 1));
				return;
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0602B4FD RID: 177405 RVA: 0x00C2ADCC File Offset: 0x00C28FCC
		private void OnClickedHelp()
		{
			int? seasonHelpId = ActivityPermanentRogueModel.Instance.GetSeasonHelpId(this.NewSeasonId);
			if (seasonHelpId != null && seasonHelpId.GetValueOrDefault() != 0)
			{
				HelpController.Instance.OpenHelpById(seasonHelpId.Value);
			}
		}

		// Token: 0x0602B4FE RID: 177406 RVA: 0x00C2AE10 File Offset: 0x00C29010
		protected void OnTimer(int gap)
		{
			if (!ActivityPermanentRogueModel.Instance.GetTaskIsEnd())
			{
				UUIItem item = base.GetItem(9);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				RogueButtonItemA btnRogueA = this.BtnRogueA;
				if (btnRogueA == null)
				{
					return;
				}
				btnRogueA.SetLimitTime(this.GetRemainTime());
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(9);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0602B4FF RID: 177407 RVA: 0x00C2AE68 File Offset: 0x00C29068
		[NullableContext(1)]
		protected string GetRemainTime()
		{
			long taskEndTime = ActivityPermanentRogueModel.Instance.GetTaskEndTime();
			return ActivityModel.Instance.GetRemainTimeText(taskEndTime, "{0}");
		}

		// Token: 0x040175BF RID: 95679
		private RogueResActivitySubViewGeneralInfo ActivityInfoComp;

		// Token: 0x040175C0 RID: 95680
		private RogueButtonItemA BtnRogueA;

		// Token: 0x040175C1 RID: 95681
		private RogueButtonItemA BtnRogueB;

		// Token: 0x040175C2 RID: 95682
		private int NewSeasonId;
	}
}
