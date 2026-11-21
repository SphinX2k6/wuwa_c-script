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
	// Token: 0x0200414E RID: 16718
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaSubView : ActivitySubViewBase
	{
		// Token: 0x0602A499 RID: 173209 RVA: 0x00BF1184 File Offset: 0x00BEF384
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

		// Token: 0x0602A49A RID: 173210 RVA: 0x00BF1238 File Offset: 0x00BEF438
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A49B RID: 173211 RVA: 0x00BF127C File Offset: 0x00BEF47C
		protected override void OnBeforeShow()
		{
			string animationName = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "IdleF" : "IdleM";
			base.GetSpine(6).SetAnimation(0, animationName, true);
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x0602A49C RID: 173212 RVA: 0x00BF12C4 File Offset: 0x00BEF4C4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnEventRefresh));
			EventSystem.Instance.Add(EEventName.ActivityCrossDayRefresh, new Action(this.CrossDayRefresh));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnEventQuestChange));
		}

		// Token: 0x0602A49D RID: 173213 RVA: 0x00BF1328 File Offset: 0x00BEF528
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnEventRefresh));
			EventSystem.Instance.Remove(EEventName.ActivityCrossDayRefresh, new Action(this.CrossDayRefresh));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnEventQuestChange));
		}

		// Token: 0x0602A49E RID: 173214 RVA: 0x00BF1389 File Offset: 0x00BEF589
		protected override void OnRefreshView()
		{
			this.RefreshInfo();
			this.BindRedDot();
		}

		// Token: 0x0602A49F RID: 173215 RVA: 0x00BF1398 File Offset: 0x00BEF598
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

		// Token: 0x0602A4A0 RID: 173216 RVA: 0x00BF1424 File Offset: 0x00BEF624
		private void RefreshRecommend()
		{
			PhantomArenaActivityData phantomArenaActivityData = this.ActivityBaseData as PhantomArenaActivityData;
			this.RecommendQuestTips.SetContentByTextId(phantomArenaActivityData.RecommendQuestTips, Array.Empty<string>());
			this.RecommendQuestTips.SetUiActive(phantomArenaActivityData.RecommendQuestId > 0 && !QuestNewModel.Instance.CheckQuestFinished(phantomArenaActivityData.RecommendQuestId));
		}

		// Token: 0x0602A4A1 RID: 173217 RVA: 0x00BF1480 File Offset: 0x00BEF680
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

		// Token: 0x0602A4A2 RID: 173218 RVA: 0x00BF14E2 File Offset: 0x00BEF6E2
		private void OnClickConfirm(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate(ActivityViewJumpClickLogData logData)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceView, this.ActivityBaseData.Id, null);
				logData.i_scene = 3;
			});
		}

		// Token: 0x0602A4A3 RID: 173219 RVA: 0x00BF1500 File Offset: 0x00BEF700
		private void OnClickTask(int _)
		{
			BattleShopViewOpenParam param = new BattleShopViewOpenParam
			{
				TabViewName = EUiTabViewName.PhantomArenaEntranceTaskTabView,
				ActivityId = this.ActivityBaseData.Id
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceShopMainView, param, null);
		}

		// Token: 0x0602A4A4 RID: 173220 RVA: 0x00BF1540 File Offset: 0x00BEF740
		private void OnClickLevel(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMasterInfoView, this.ActivityBaseData.Id, null);
		}

		// Token: 0x0602A4A5 RID: 173221 RVA: 0x00BF1564 File Offset: 0x00BEF764
		private void OnClickRecommend()
		{
			PhantomArenaActivityData phantomArenaActivityData = this.ActivityBaseData as PhantomArenaActivityData;
			if (phantomArenaActivityData.RecommendQuestId > 0 && !QuestNewModel.Instance.CheckQuestFinished(phantomArenaActivityData.RecommendQuestId))
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, phantomArenaActivityData.RecommendQuestId, null);
			}
		}

		// Token: 0x0602A4A6 RID: 173222 RVA: 0x00BF15B3 File Offset: 0x00BEF7B3
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602A4A7 RID: 173223 RVA: 0x00BF15BB File Offset: 0x00BEF7BB
		private void CrossDayRefresh()
		{
			this.RefreshInfo();
		}

		// Token: 0x0602A4A8 RID: 173224 RVA: 0x00BF15C3 File Offset: 0x00BEF7C3
		private void OnEventRefresh(int activityId)
		{
			this.RefreshInfo();
		}

		// Token: 0x0602A4A9 RID: 173225 RVA: 0x00BF15CB File Offset: 0x00BEF7CB
		private void OnEventQuestChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (state >= QuestState.Finish)
			{
				this.RefreshInfo();
			}
		}

		// Token: 0x0602A4AA RID: 173226 RVA: 0x00BF15D8 File Offset: 0x00BEF7D8
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

		// Token: 0x0602A4AB RID: 173227 RVA: 0x00BF1673 File Offset: 0x00BEF873
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

		// Token: 0x0602A4AC RID: 173228 RVA: 0x00BF16B0 File Offset: 0x00BEF8B0
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

		// Token: 0x04017001 RID: 94209
		private ActivitySubViewGeneralInfo InfoComponent;

		// Token: 0x04017002 RID: 94210
		private ActivityQuestTipsItem RecommendQuestTips;

		// Token: 0x04017003 RID: 94211
		private ButtonItem BtnLimit;

		// Token: 0x04017004 RID: 94212
		private ButtonItem BtnLevel;

		// Token: 0x02009D2B RID: 40235
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04030E07 RID: 200199
			public const int InfoItem = 0;

			// Token: 0x04030E08 RID: 200200
			public const int BtnLeft = 1;

			// Token: 0x04030E09 RID: 200201
			public const int RewardRedDot = 2;

			// Token: 0x04030E0A RID: 200202
			public const int BtnLimit = 3;

			// Token: 0x04030E0B RID: 200203
			public const int BtnLevel = 4;

			// Token: 0x04030E0C RID: 200204
			public const int PanelTips = 5;

			// Token: 0x04030E0D RID: 200205
			public const int ItemSpine = 6;
		}
	}
}
