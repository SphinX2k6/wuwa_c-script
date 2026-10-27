using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200118A RID: 4490
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerSubView : ActivitySubViewBase
{
	// Token: 0x060076C9 RID: 30409 RVA: 0x0018BC60 File Offset: 0x00189E60
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

	// Token: 0x060076CA RID: 30410 RVA: 0x0018BDCC File Offset: 0x00189FCC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060076CB RID: 30411 RVA: 0x0018BE0F File Offset: 0x0018A00F
	protected override void OnStart()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), null, 0);
	}

	// Token: 0x060076CC RID: 30412 RVA: 0x0018BE29 File Offset: 0x0018A029
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.BabelTowerQuestRedDot, base.GetItem(5), 0);
	}

	// Token: 0x060076CD RID: 30413 RVA: 0x0018BE44 File Offset: 0x0018A044
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

	// Token: 0x060076CE RID: 30414 RVA: 0x0018BE8C File Offset: 0x0018A08C
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

	// Token: 0x060076CF RID: 30415 RVA: 0x0018BF10 File Offset: 0x0018A110
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

	// Token: 0x060076D0 RID: 30416 RVA: 0x0018BF7C File Offset: 0x0018A17C
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

	// Token: 0x060076D1 RID: 30417 RVA: 0x0018BFE0 File Offset: 0x0018A1E0
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x060076D2 RID: 30418 RVA: 0x0018C010 File Offset: 0x0018A210
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

	// Token: 0x060076D3 RID: 30419 RVA: 0x0018C06D File Offset: 0x0018A26D
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

	// Token: 0x060076D4 RID: 30420 RVA: 0x0018C08C File Offset: 0x0018A28C
	private void RefreshBtnRedDot()
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		bool functionRedDotVisible = babelTowerData.GetDifficultyNewLevelRedDot(0) || babelTowerData.GetDifficultyNewLevelRedDot(1);
		this.FunctionalComponent.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x060076D5 RID: 30421 RVA: 0x0018C0C4 File Offset: 0x0018A2C4
	private void OnClickQuestBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x0400367D RID: 13949
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400367E RID: 13950
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x0400367F RID: 13951
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003680 RID: 13952
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x0200776C RID: 30572
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402764B RID: 161355
		public const int TitleItem = 0;

		// Token: 0x0402764C RID: 161356
		public const int DescItem = 1;

		// Token: 0x0402764D RID: 161357
		public const int RewardItem = 2;

		// Token: 0x0402764E RID: 161358
		public const int FunctionalAreaItem = 3;

		// Token: 0x0402764F RID: 161359
		public const int QuestBtn = 4;

		// Token: 0x04027650 RID: 161360
		public const int QuestRedDotItem = 5;

		// Token: 0x04027651 RID: 161361
		public const int QuestText1 = 6;

		// Token: 0x04027652 RID: 161362
		public const int QuestText2 = 7;
	}
}
