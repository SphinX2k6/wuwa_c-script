using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000694 RID: 1684
[NullableContext(1)]
[Nullable(0)]
public class CiacconaActivitySubView : ActivitySubViewBase
{
	// Token: 0x06004D91 RID: 19857 RVA: 0x001A37D8 File Offset: 0x001A19D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004D92 RID: 19858 RVA: 0x001A39B4 File Offset: 0x001A1BB4
	protected override UniTask OnBeforeStartAsync()
	{
		CiacconaActivitySubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivitySubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004D93 RID: 19859 RVA: 0x001A39F7 File Offset: 0x001A1BF7
	protected override void OnStart()
	{
		this.Refresh();
	}

	// Token: 0x06004D94 RID: 19860 RVA: 0x001A39FF File Offset: 0x001A1BFF
	protected override void OnBeforeDestroy()
	{
		ActivityCircleButtonItem endingRewardItem = this.EndingRewardItem;
		if (endingRewardItem != null)
		{
			endingRewardItem.UnBindRedDot();
		}
		ActivityCircleButtonItem progressRewardItem = this.ProgressRewardItem;
		if (progressRewardItem == null)
		{
			return;
		}
		progressRewardItem.UnBindRedDot();
	}

	// Token: 0x06004D95 RID: 19861 RVA: 0x001A3A22 File Offset: 0x001A1C22
	protected override void OnRefreshView()
	{
		this.Refresh();
	}

	// Token: 0x06004D96 RID: 19862 RVA: 0x001A3A2C File Offset: 0x001A1C2C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaActivityStateUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06004D97 RID: 19863 RVA: 0x001A3AAC File Offset: 0x001A1CAC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaActivityStateUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06004D98 RID: 19864 RVA: 0x001A3B2C File Offset: 0x001A1D2C
	protected override void OnTimer(float _)
	{
		CiacconaGalModel instance = CiacconaGalModel.Instance;
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		CiacconaGalActivityData activityDataById = instance.GetActivityDataById((activityBaseData != null) ? activityBaseData.Id : 0);
		if (activityDataById != null)
		{
			ActivityCircleButtonItem progressRewardItem = this.ProgressRewardItem;
			if (progressRewardItem != null)
			{
				progressRewardItem.SetUiActive(activityDataById.IsInRewardTime && activityDataById.State2Unlock);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(activityDataById.State2Unlock && activityDataById.IsInRewardTime);
			}
			this.RefreshRewardTimeText();
		}
	}

	// Token: 0x06004D99 RID: 19865 RVA: 0x001A3BA4 File Offset: 0x001A1DA4
	private void Refresh()
	{
		this.CommonActivityInfo.SetTitle(this.ActivityBaseData.GetTitle());
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		this.CommonActivityInfo.SetSubTitle(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null), ((localConfig != null) ? localConfig.GetValueOrDefault().DescTheme : null) ?? "");
		this.CommonActivityInfo.SetDesc(!StringUtils.IsEmpty((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null), ((localConfig != null) ? localConfig.GetValueOrDefault().Desc : null) ?? "");
		this.CommonActivityInfo.SetReward(true, this.ActivityBaseData.GetPreviewReward(null));
		this.RefreshTimeText();
		CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(this.ActivityBaseData.Id);
		this.CommonActivityInfo.RefreshFunctionArea();
		CiacconaGalEndingData[] allEndingDataList = CiacconaGalModel.Instance.GetAllEndingDataList();
		this.LayoutEndings.RefreshByData(allEndingDataList, null, false);
		base.GetItem(7).SetUIActive(false);
		ValueTuple<int, int> progressRewardProgress = CiacconaGalModel.Instance.GetProgressRewardProgress();
		int item = progressRewardProgress.Item1;
		int item2 = progressRewardProgress.Item2;
		base.GetSprite(6).fillAmount = (float)item / (float)item2;
		UUIText text = base.GetText(5);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetItem(8).SetUIActive(activityDataById.State2Unlock && activityDataById.IsInRewardTime);
		this.RefreshRewardTimeText();
		this.QuestTipsItem.SetContentByTextId(activityDataById.RecommendQuestTipsTextId, Array.Empty<string>());
		this.QuestTipsItem.SetUiActive(activityDataById.RecommendQuestId > 0 && !QuestNewModel.Instance.CheckQuestFinished(activityDataById.RecommendQuestId));
		ValueTuple<int, int> endingProgress = CiacconaGalModel.Instance.GetEndingProgress();
		int item3 = endingProgress.Item1;
		int item4 = endingProgress.Item2;
		ActivityCircleButtonItem endingRewardItem = this.EndingRewardItem;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item3);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item4);
		endingRewardItem.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		this.EndingRewardItem.SetUiActive(activityDataById.State3Unlock);
		this.EndingRewardItem.SetRedDotVisible(CiacconaGalModel.Instance.HasAnyEndingReward());
		ActivityCircleButtonItem progressRewardItem = this.ProgressRewardItem;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(item);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
		progressRewardItem.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		this.ProgressRewardItem.SetUiActive(activityDataById.IsInRewardTime && activityDataById.State2Unlock);
		this.ProgressRewardItem.SetRedDotVisible(CiacconaGalModel.Instance.HasAnyProgressReward());
	}

	// Token: 0x06004D9A RID: 19866 RVA: 0x001A3E94 File Offset: 0x001A2094
	private void RefreshTimeText()
	{
		string item = this.GetTimeVisibleAndRemainTime().Item2;
		CiacconaActivityInfoPanel commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return;
		}
		commonActivityInfo.SetTimer(false, item);
	}

	// Token: 0x06004D9B RID: 19867 RVA: 0x001A3EC0 File Offset: 0x001A20C0
	private void RefreshRewardTimeText()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Xkjsx_Rewards_Timeless", null);
		string rewardRemainTimeStr = CiacconaGalModel.Instance.ActivityData.RewardRemainTimeStr;
		string newText = localTextNew + " " + rewardRemainTimeStr;
		UUIText text = base.GetText(12);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x06004D9C RID: 19868 RVA: 0x001A3F08 File Offset: 0x001A2108
	private CiacconaEndingIcon GetEndingItem()
	{
		return new CiacconaEndingIcon();
	}

	// Token: 0x06004D9D RID: 19869 RVA: 0x001A3F0F File Offset: 0x001A210F
	private void OnEndingRewardClick()
	{
		CiacconaGalController.Instance.OpenEndingView();
	}

	// Token: 0x06004D9E RID: 19870 RVA: 0x001A3F1B File Offset: 0x001A211B
	private void OnProgressRewardClick()
	{
		CiacconaGalController.Instance.OpenRewardViewByActivityId(this.ActivityBaseData.Id);
	}

	// Token: 0x06004D9F RID: 19871 RVA: 0x001A3F34 File Offset: 0x001A2134
	private void OnQuestTipsClick()
	{
		CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(this.ActivityBaseData.Id);
		if (activityDataById.RecommendQuestId > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, activityDataById.RecommendQuestId, null);
		}
	}

	// Token: 0x06004DA0 RID: 19872 RVA: 0x001A3F7B File Offset: 0x001A217B
	private void OnDataUpdate()
	{
		this.Refresh();
	}

	// Token: 0x06004DA1 RID: 19873 RVA: 0x001A3F83 File Offset: 0x001A2183
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		CiacconaActivityInfoPanel commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return null;
		}
		return commonActivityInfo.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0400389C RID: 14492
	private CiacconaActivityInfoPanel CommonActivityInfo;

	// Token: 0x0400389D RID: 14493
	private GenericLayout<CiacconaEndingIcon, CiacconaGalEndingData> LayoutEndings;

	// Token: 0x0400389E RID: 14494
	private ActivityCircleButtonItem EndingRewardItem;

	// Token: 0x0400389F RID: 14495
	private ActivityCircleButtonItem ProgressRewardItem;

	// Token: 0x040038A0 RID: 14496
	private ActivityQuestTipsItem QuestTipsItem;

	// Token: 0x02006956 RID: 26966
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022B1C RID: 142108
		public const int ItemCommonActivityInfo = 0;

		// Token: 0x04022B1D RID: 142109
		public const int ItemBtnConfirm = 1;

		// Token: 0x04022B1E RID: 142110
		public const int ItemRedDot = 2;

		// Token: 0x04022B1F RID: 142111
		public const int LayoutEndings = 3;

		// Token: 0x04022B20 RID: 142112
		public const int ItemEndingIcon = 4;

		// Token: 0x04022B21 RID: 142113
		public const int TextProgress = 5;

		// Token: 0x04022B22 RID: 142114
		public const int SpriteProgress = 6;

		// Token: 0x04022B23 RID: 142115
		public const int ItemEndings = 7;

		// Token: 0x04022B24 RID: 142116
		public const int ItemProgress = 8;

		// Token: 0x04022B25 RID: 142117
		public const int ItemProgressReward = 9;

		// Token: 0x04022B26 RID: 142118
		public const int ItemEndingReward = 10;

		// Token: 0x04022B27 RID: 142119
		public const int ItemQuestTips = 11;

		// Token: 0x04022B28 RID: 142120
		public const int TextRewardLimitTime = 12;
	}
}
