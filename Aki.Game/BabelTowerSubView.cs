using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200063E RID: 1598
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSubView : ActivitySubViewBase
{
	// Token: 0x06004A60 RID: 19040 RVA: 0x00194810 File Offset: 0x00192A10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickQuestBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004A61 RID: 19041 RVA: 0x0019497C File Offset: 0x00192B7C
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x001949BF File Offset: 0x00192BBF
	protected override void OnStart()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), null, 0);
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x001949D9 File Offset: 0x00192BD9
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x06004A64 RID: 19044 RVA: 0x001949F4 File Offset: 0x00192BF4
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
		this.RefreshState();
		this.RefreshBtnRedDot();
		this.RefreshQuestText();
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x00194A3C File Offset: 0x00192C3C
	private void RefreshQuestText()
	{
		ValueTuple<int, int> normalQuestCount = BabelTowerController.Instance.GetBabelTowerData().GetNormalQuestCount();
		int item = normalQuestCount.Item1;
		int item2 = normalQuestCount.Item2;
		int value = item;
		int value2 = item2;
		UUIText text = base.GetText(6);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIText text2 = base.GetText(7);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06004A66 RID: 19046 RVA: 0x00194AC0 File Offset: 0x00192CC0
	private void RefreshDesc()
	{
		Activity value = this.ActivityBaseData.LocalConfig.Value;
		string descTheme = value.DescTheme;
		string desc = value.Desc;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
	}

	// Token: 0x06004A67 RID: 19047 RVA: 0x00194B2C File Offset: 0x00192D2C
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

	// Token: 0x06004A68 RID: 19048 RVA: 0x00194B90 File Offset: 0x00192D90
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06004A69 RID: 19049 RVA: 0x00194BC0 File Offset: 0x00192DC0
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

	// Token: 0x06004A6A RID: 19050 RVA: 0x00194C1D File Offset: 0x00192E1D
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
			UiManager.Instance.OpenView(EUiViewName.BabelTowerMainView, null, null);
		});
	}

	// Token: 0x06004A6B RID: 19051 RVA: 0x00194C3C File Offset: 0x00192E3C
	private void RefreshBtnRedDot()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		bool functionRedDotVisible = babelTowerData.GetDifficultyNewLevelRedDot(0) || babelTowerData.GetDifficultyNewLevelRedDot(1);
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x06004A6C RID: 19052 RVA: 0x00194C74 File Offset: 0x00192E74
	private void OnClickQuestBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x04003716 RID: 14102
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003717 RID: 14103
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003718 RID: 14104
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003719 RID: 14105
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x020068F9 RID: 26873
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022984 RID: 141700
		public const int TitleItem = 0;

		// Token: 0x04022985 RID: 141701
		public const int DescItem = 1;

		// Token: 0x04022986 RID: 141702
		public const int RewardItem = 2;

		// Token: 0x04022987 RID: 141703
		public const int FunctionalAreaItem = 3;

		// Token: 0x04022988 RID: 141704
		public const int QuestBtn = 4;

		// Token: 0x04022989 RID: 141705
		public const int QuestRedDotItem = 5;

		// Token: 0x0402298A RID: 141706
		public const int QuestText1 = 6;

		// Token: 0x0402298B RID: 141707
		public const int QuestText2 = 7;
	}
}
