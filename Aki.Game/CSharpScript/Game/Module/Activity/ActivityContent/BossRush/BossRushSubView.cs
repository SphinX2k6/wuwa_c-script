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
	// Token: 0x0200585F RID: 22623
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushSubView : ActivitySubViewBase
	{
		// Token: 0x06037C5B RID: 228443 RVA: 0x00F986AC File Offset: 0x00F968AC
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

		// Token: 0x06037C5C RID: 228444 RVA: 0x00F98781 File Offset: 0x00F96981
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BossRushDataUpdate, new Action(this.OnBossRushDataUpdate));
		}

		// Token: 0x06037C5D RID: 228445 RVA: 0x00F9879F File Offset: 0x00F9699F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BossRushDataUpdate, new Action(this.OnBossRushDataUpdate));
		}

		// Token: 0x06037C5E RID: 228446 RVA: 0x00F987BD File Offset: 0x00F969BD
		private void OnClickRewardbtn()
		{
			BossRushModel.Instance.OnlyOpenRewardView = true;
			BossRushController.Instance.OpenBossRushView(this.ActivityBaseData.Id);
		}

		// Token: 0x06037C5F RID: 228447 RVA: 0x00F987E0 File Offset: 0x00F969E0
		private void OnBossRushDataUpdate()
		{
			this.RefreshRedDot();
		}

		// Token: 0x06037C60 RID: 228448 RVA: 0x00F987E8 File Offset: 0x00F969E8
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037C61 RID: 228449 RVA: 0x00F9882B File Offset: 0x00F96A2B
		protected override void OnStart()
		{
			this.BossRushData = (this.ActivityBaseData as BossRushData);
		}

		// Token: 0x06037C62 RID: 228450 RVA: 0x00F9883E File Offset: 0x00F96A3E
		protected override void OnBeforeShow()
		{
			this.BindRedDot();
		}

		// Token: 0x06037C63 RID: 228451 RVA: 0x00F98846 File Offset: 0x00F96A46
		protected override void OnBeforeHide()
		{
			this.RemoveRedDot();
		}

		// Token: 0x06037C64 RID: 228452 RVA: 0x00F98850 File Offset: 0x00F96A50
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

		// Token: 0x06037C65 RID: 228453 RVA: 0x00F988A4 File Offset: 0x00F96AA4
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

		// Token: 0x06037C66 RID: 228454 RVA: 0x00F98902 File Offset: 0x00F96B02
		private void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.BossRushReward, base.GetItem(6), null, this.BossRushData.Id);
		}

		// Token: 0x06037C67 RID: 228455 RVA: 0x00F98926 File Offset: 0x00F96B26
		private void RemoveRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.BossRushReward, base.GetItem(6), 0);
		}

		// Token: 0x06037C68 RID: 228456 RVA: 0x00F98940 File Offset: 0x00F96B40
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

		// Token: 0x06037C69 RID: 228457 RVA: 0x00F98988 File Offset: 0x00F96B88
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

		// Token: 0x06037C6A RID: 228458 RVA: 0x00F989E8 File Offset: 0x00F96BE8
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

		// Token: 0x06037C6B RID: 228459 RVA: 0x00F98A4C File Offset: 0x00F96C4C
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

		// Token: 0x06037C6C RID: 228460 RVA: 0x00F98AC4 File Offset: 0x00F96CC4
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06037C6D RID: 228461 RVA: 0x00F98B03 File Offset: 0x00F96D03
		protected override void OnTimer(float gap)
		{
			base.OnTimer(gap);
			this.RefreshTitle();
		}

		// Token: 0x06037C6E RID: 228462 RVA: 0x00F98B14 File Offset: 0x00F96D14
		private void RefreshFunctionalComponent()
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("BossRushEnterText", null);
			this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		}

		// Token: 0x06037C6F RID: 228463 RVA: 0x00F98B3E File Offset: 0x00F96D3E
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

		// Token: 0x06037C70 RID: 228464 RVA: 0x00F98B5C File Offset: 0x00F96D5C
		private void RefreshRedDot()
		{
			bool flag = this.BossRushData.EntranceRedDot();
			bool preGuideQuestFinishState = this.BossRushData.GetPreGuideQuestFinishState();
			this.FunctionalComponent.FunctionButton.SetRedDotVisible(preGuideQuestFinishState && flag);
		}

		// Token: 0x0401D6E8 RID: 120552
		private BossRushData BossRushData;

		// Token: 0x0401D6E9 RID: 120553
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401D6EA RID: 120554
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401D6EB RID: 120555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401D6EC RID: 120556
		private ActivityFunctionalArea FunctionalComponent;

		// Token: 0x0200B486 RID: 46214
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037D40 RID: 228672
			TitleItem,
			// Token: 0x04037D41 RID: 228673
			DescItem,
			// Token: 0x04037D42 RID: 228674
			RewardItem,
			// Token: 0x04037D43 RID: 228675
			FunctionalAreaItem,
			// Token: 0x04037D44 RID: 228676
			RewardBtn,
			// Token: 0x04037D45 RID: 228677
			RewardProgress,
			// Token: 0x04037D46 RID: 228678
			RewardRedDot
		}
	}
}
