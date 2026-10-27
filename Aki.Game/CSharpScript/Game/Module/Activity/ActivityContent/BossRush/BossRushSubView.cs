using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200690F RID: 26895
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushSubView : ActivitySubViewBase
	{
		// Token: 0x06043103 RID: 274691 RVA: 0x01057080 File Offset: 0x01055280
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickRewardbtn))
			};
		}

		// Token: 0x06043104 RID: 274692 RVA: 0x01057155 File Offset: 0x01055355
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BossRushDataUpdate, new Action(this.OnBossRushDataUpdate));
		}

		// Token: 0x06043105 RID: 274693 RVA: 0x01057173 File Offset: 0x01055373
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BossRushDataUpdate, new Action(this.OnBossRushDataUpdate));
		}

		// Token: 0x06043106 RID: 274694 RVA: 0x01057191 File Offset: 0x01055391
		private void OnClickRewardbtn()
		{
			BossRushModel.Instance.OnlyOpenRewardView = true;
			BossRushController.Instance.OpenBossRushView(this.ActivityBaseData.Id);
		}

		// Token: 0x06043107 RID: 274695 RVA: 0x010571B4 File Offset: 0x010553B4
		private void OnBossRushDataUpdate()
		{
			this.RefreshRedDot();
		}

		// Token: 0x06043108 RID: 274696 RVA: 0x010571BC File Offset: 0x010553BC
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043109 RID: 274697 RVA: 0x010571FF File Offset: 0x010553FF
		protected override void OnStart()
		{
			this.BossRushData = (this.ActivityBaseData as BossRushData);
		}

		// Token: 0x0604310A RID: 274698 RVA: 0x01057212 File Offset: 0x01055412
		protected override void OnBeforeShow()
		{
			this.BindRedDot();
		}

		// Token: 0x0604310B RID: 274699 RVA: 0x0105721A File Offset: 0x0105541A
		protected override void OnBeforeHide()
		{
			this.RemoveRedDot();
		}

		// Token: 0x0604310C RID: 274700 RVA: 0x01057224 File Offset: 0x01055424
		protected override void OnRefreshView()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshReward();
			this.RefreshFunctionalComponent();
			this.RefreshRedDot();
			this.RefreshState();
			this.TryShowNewUnlockTips();
			this.RefreshProgressText();
		}

		// Token: 0x0604310D RID: 274701 RVA: 0x01057278 File Offset: 0x01055478
		private void RefreshProgressText()
		{
			int finishTaskCount = this.BossRushData.GetFinishTaskCount();
			int allTaskCount = this.BossRushData.GetAllTaskCount();
			UUIText text = base.GetText(5);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(finishTaskCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(allTaskCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0604310E RID: 274702 RVA: 0x010572D6 File Offset: 0x010554D6
		private void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.BossRushReward, base.GetItem(6), null, this.BossRushData.Id);
		}

		// Token: 0x0604310F RID: 274703 RVA: 0x010572FA File Offset: 0x010554FA
		private void RemoveRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BossRushReward, base.GetItem(6), 0);
		}

		// Token: 0x06043110 RID: 274704 RVA: 0x01057314 File Offset: 0x01055514
		private void TryShowNewUnlockTips()
		{
			if (this.BossRushData.GetNewUnlockState())
			{
				this.BossRushData.CacheNewUnlock();
				DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
				difficultUnlockTipsData.Text = "BossRushUnlockTips";
				UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
			}
		}

		// Token: 0x06043111 RID: 274705 RVA: 0x0105735C File Offset: 0x0105555C
		private void RefreshState()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
			this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		}

		// Token: 0x06043112 RID: 274706 RVA: 0x010573BC File Offset: 0x010555BC
		private void RefreshTitle()
		{
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06043113 RID: 274707 RVA: 0x01057420 File Offset: 0x01055620
		private void RefreshDesc()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			string descTheme = localConfig.Value.DescTheme;
			string desc = localConfig.Value.Desc;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		}

		// Token: 0x06043114 RID: 274708 RVA: 0x01057498 File Offset: 0x01055698
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06043115 RID: 274709 RVA: 0x010574D7 File Offset: 0x010556D7
		protected override void OnTimer(float gap)
		{
			base.OnTimer(gap);
			this.RefreshTitle();
		}

		// Token: 0x06043116 RID: 274710 RVA: 0x010574E8 File Offset: 0x010556E8
		private void RefreshFunctionalComponent()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		}

		// Token: 0x06043117 RID: 274711 RVA: 0x01057512 File Offset: 0x01055712
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				BossRushController.Instance.OpenBossRushView(this.ActivityBaseData.Id);
			});
		}

		// Token: 0x06043118 RID: 274712 RVA: 0x01057530 File Offset: 0x01055730
		private void RefreshRedDot()
		{
			bool flag = this.BossRushData.EntranceRedDot();
			bool preGuideQuestFinishState = this.BossRushData.GetPreGuideQuestFinishState();
			this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
		}

		// Token: 0x04022E8C RID: 142988
		private BossRushData BossRushData;

		// Token: 0x04022E8D RID: 142989
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04022E8E RID: 142990
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04022E8F RID: 142991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04022E90 RID: 142992
		private ActivityFunctionalArea FunctionalComponent;

		// Token: 0x0200CABE RID: 51902
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D466 RID: 250982
			TitleItem,
			// Token: 0x0403D467 RID: 250983
			DescItem,
			// Token: 0x0403D468 RID: 250984
			RewardItem,
			// Token: 0x0403D469 RID: 250985
			FunctionalAreaItem,
			// Token: 0x0403D46A RID: 250986
			RewardBtn,
			// Token: 0x0403D46B RID: 250987
			RewardProgress,
			// Token: 0x0403D46C RID: 250988
			RewardRedDot
		}
	}
}
