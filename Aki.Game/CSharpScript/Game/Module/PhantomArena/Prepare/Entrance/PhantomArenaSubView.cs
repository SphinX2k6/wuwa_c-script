using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200517E RID: 20862
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaSubView : ActivitySubViewBase
	{
		// Token: 0x0603559E RID: 218526 RVA: 0x00CA3BCC File Offset: 0x00CA1DCC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x0603559F RID: 218527 RVA: 0x00CA3C80 File Offset: 0x00CA1E80
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060355A0 RID: 218528 RVA: 0x00CA3CC4 File Offset: 0x00CA1EC4
		protected override void OnBeforeShow()
		{
			string animationName = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "IdleF" : "IdleM";
			base.GetSpine(6).SetAnimation(0, animationName, true);
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x060355A1 RID: 218529 RVA: 0x00CA3D0C File Offset: 0x00CA1F0C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnEventRefresh));
			EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.CrossDayRefresh));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnEventQuestChange));
		}

		// Token: 0x060355A2 RID: 218530 RVA: 0x00CA3D70 File Offset: 0x00CA1F70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnEventRefresh));
			EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.CrossDayRefresh));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnEventQuestChange));
		}

		// Token: 0x060355A3 RID: 218531 RVA: 0x00CA3DD1 File Offset: 0x00CA1FD1
		protected override void OnRefreshView()
		{
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x060355A4 RID: 218532 RVA: 0x00CA3DE0 File Offset: 0x00CA1FE0
		private void RefreshInfo()
		{
			this.InfoComponent.SetBtnText("PhantomBattle_1103", Array.Empty<object>());
			ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
			if (infoComponent != null)
			{
				infoComponent.RefreshFunction();
			}
			ValueTuple<bool, string> valueTuple = PhantomArenaModel.Instance.IsInLimitTime(this.ActivityBaseData.Id, null);
			bool item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			ButtonItem btnLimit = this.BtnLimit;
			if (btnLimit != null)
			{
				btnLimit.SetUiActive(item);
			}
			if (item)
			{
				ButtonItem btnLimit2 = this.BtnLimit;
				if (btnLimit2 != null)
				{
					btnLimit2.SetText(item2);
				}
			}
			this.RefreshRecommend();
			this.RefreshLevel();
		}

		// Token: 0x060355A5 RID: 218533 RVA: 0x00CA3E6C File Offset: 0x00CA206C
		private void RefreshRecommend()
		{
			PhantomArenaActivityData phantomArenaActivityData = this.ActivityBaseData as PhantomArenaActivityData;
			this.RecommendQuestTips.SetContentByTextId(phantomArenaActivityData.RecommendQuestTips, Array.Empty<string>());
			this.RecommendQuestTips.SetUiActive(phantomArenaActivityData.RecommendQuestId > 0 && !QuestNewModel.Instance.CheckQuestFinished(phantomArenaActivityData.RecommendQuestId));
		}

		// Token: 0x060355A6 RID: 218534 RVA: 0x00CA3EC8 File Offset: 0x00CA20C8
		private void RefreshLevel()
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			int masterLevel = instance.GetMasterLevel(this.ActivityBaseData.Id);
			int masterLevelMax = instance.GetMasterLevelMax(this.ActivityBaseData.Id);
			ButtonItem btnLevel = this.BtnLevel;
			if (btnLevel == null)
			{
				return;
			}
			btnLevel.SetLocalTextNew("PhantomBattle_1025", new object[]
			{
				masterLevel,
				masterLevelMax
			});
		}

		// Token: 0x060355A7 RID: 218535 RVA: 0x00CA3F2A File Offset: 0x00CA212A
		private void OnClickConfirm(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate(ActivityViewJumpClickLogData logData)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceView, this.ActivityBaseData.Id, null);
				logData.i_scene = 3;
			});
		}

		// Token: 0x060355A8 RID: 218536 RVA: 0x00CA3F48 File Offset: 0x00CA2148
		private void OnClickTask(int _)
		{
			BattleShopViewOpenParam param = new BattleShopViewOpenParam
			{
				TabViewName = EUiTabViewName.PhantomArenaEntranceTaskTabView,
				ActivityId = this.ActivityBaseData.Id
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceShopMainView, param, null);
		}

		// Token: 0x060355A9 RID: 218537 RVA: 0x00CA3F88 File Offset: 0x00CA2188
		private void OnClickLevel(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMasterInfoView, this.ActivityBaseData.Id, null);
		}

		// Token: 0x060355AA RID: 218538 RVA: 0x00CA3FAC File Offset: 0x00CA21AC
		private void OnClickRecommend()
		{
			PhantomArenaActivityData phantomArenaActivityData = this.ActivityBaseData as PhantomArenaActivityData;
			if (phantomArenaActivityData.RecommendQuestId > 0 && !QuestNewModel.Instance.CheckQuestFinished(phantomArenaActivityData.RecommendQuestId))
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, phantomArenaActivityData.RecommendQuestId, null);
			}
		}

		// Token: 0x060355AB RID: 218539 RVA: 0x00CA3FFB File Offset: 0x00CA21FB
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060355AC RID: 218540 RVA: 0x00CA4003 File Offset: 0x00CA2203
		private void CrossDayRefresh()
		{
			this.RefreshInfo();
		}

		// Token: 0x060355AD RID: 218541 RVA: 0x00CA400B File Offset: 0x00CA220B
		private void OnEventRefresh(int activityId)
		{
			this.RefreshInfo();
		}

		// Token: 0x060355AE RID: 218542 RVA: 0x00CA4013 File Offset: 0x00CA2213
		private void OnEventQuestChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (state >= QuestState.Finish)
			{
				this.RefreshInfo();
			}
		}

		// Token: 0x060355AF RID: 218543 RVA: 0x00CA4020 File Offset: 0x00CA2220
		private void BindRedDot()
		{
			this.UnBindRedDot();
			this.BtnLimit.BindRedDot(ERedDotName.RedDotPhantomArenaLimitReward, this.ActivityBaseData.Id);
			this.BtnLevel.BindRedDot(ERedDotName.RedDotPhantomArenaLevelReward, this.ActivityBaseData.Id);
			ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
			if (infoComponent != null)
			{
				ActivityFunctionalTypeA functional = infoComponent.GetFunctional();
				if (functional != null)
				{
					ActivityButtonItem functionButton = functional.FunctionButton;
					if (functionButton != null)
					{
						functionButton.BindRedDot(ERedDotName.RedDotPhantomArenaActivity, this.ActivityBaseData.Id);
					}
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
		}

		// Token: 0x060355B0 RID: 218544 RVA: 0x00CA40BB File Offset: 0x00CA22BB
		private void UnBindRedDot()
		{
			this.BtnLimit.UnBindRedDot();
			this.BtnLevel.UnBindRedDot();
			ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
			if (infoComponent == null)
			{
				return;
			}
			ActivityFunctionalTypeA functional = infoComponent.GetFunctional();
			if (functional == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functional.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.UnBindRedDot();
		}

		// Token: 0x060355B1 RID: 218545 RVA: 0x00CA40F8 File Offset: 0x00CA22F8
		protected override void OnTimer(float gap)
		{
			ValueTuple<bool, string> valueTuple = PhantomArenaModel.Instance.IsInLimitTime(this.ActivityBaseData.Id, null);
			bool item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			ButtonItem btnLimit = this.BtnLimit;
			if (btnLimit != null)
			{
				btnLimit.SetUiActive(item);
			}
			if (item)
			{
				ButtonItem btnLimit2 = this.BtnLimit;
				if (btnLimit2 == null)
				{
					return;
				}
				btnLimit2.SetText(item2);
			}
		}

		// Token: 0x0401C5CC RID: 116172
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x0401C5CD RID: 116173
		private ActivityQuestTipsItem RecommendQuestTips;

		// Token: 0x0401C5CE RID: 116174
		private ButtonItem BtnLimit;

		// Token: 0x0401C5CF RID: 116175
		private ButtonItem BtnLevel;

		// Token: 0x0200B2F2 RID: 45810
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040363B2 RID: 222130
			public const int InfoItem = 0;

			// Token: 0x040363B3 RID: 222131
			public const int BtnLeft = 1;

			// Token: 0x040363B4 RID: 222132
			public const int RewardRedDot = 2;

			// Token: 0x040363B5 RID: 222133
			public const int BtnLimit = 3;

			// Token: 0x040363B6 RID: 222134
			public const int BtnLevel = 4;

			// Token: 0x040363B7 RID: 222135
			public const int PanelTips = 5;

			// Token: 0x040363B8 RID: 222136
			public const int ItemSpine = 6;
		}
	}
}
