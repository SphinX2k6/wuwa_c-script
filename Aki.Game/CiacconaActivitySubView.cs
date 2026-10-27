using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x020011E0 RID: 4576
[NullableContext(1)]
[Nullable(0)]
public class CiacconaActivitySubView : ActivitySubViewBase
{
	// Token: 0x060079FA RID: 31226 RVA: 0x0019AB28 File Offset: 0x00198D28
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

	// Token: 0x060079FB RID: 31227 RVA: 0x0019AD04 File Offset: 0x00198F04
	protected override UniTask OnBeforeStartAsync()
	{
		CiacconaActivitySubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaActivitySubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060079FC RID: 31228 RVA: 0x0019AD47 File Offset: 0x00198F47
	protected override void OnStart()
	{
		this.Refresh();
	}

	// Token: 0x060079FD RID: 31229 RVA: 0x0019AD4F File Offset: 0x00198F4F
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

	// Token: 0x060079FE RID: 31230 RVA: 0x0019AD72 File Offset: 0x00198F72
	protected override void OnRefreshView()
	{
		this.Refresh();
	}

	// Token: 0x060079FF RID: 31231 RVA: 0x0019AD7C File Offset: 0x00198F7C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaActivityStateUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Add(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06007A00 RID: 31232 RVA: 0x0019ADFC File Offset: 0x00198FFC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaActivityStateUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06007A01 RID: 31233 RVA: 0x0019AE7C File Offset: 0x0019907C
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

	// Token: 0x06007A02 RID: 31234 RVA: 0x0019AEF4 File Offset: 0x001990F4
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
		this.LayoutEndings.RefreshByData(allEndingDataList.ToList<CiacconaGalEndingData>(), null, false);
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

	// Token: 0x06007A03 RID: 31235 RVA: 0x0019B1E8 File Offset: 0x001993E8
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

	// Token: 0x06007A04 RID: 31236 RVA: 0x0019B214 File Offset: 0x00199414
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

	// Token: 0x06007A05 RID: 31237 RVA: 0x0019B25C File Offset: 0x0019945C
	private CiacconaEndingIcon GetEndingItem()
	{
		return new CiacconaEndingIcon();
	}

	// Token: 0x06007A06 RID: 31238 RVA: 0x0019B263 File Offset: 0x00199463
	private void OnEndingRewardClick()
	{
		CiacconaGalController.Instance.OpenEndingView();
	}

	// Token: 0x06007A07 RID: 31239 RVA: 0x0019B26F File Offset: 0x0019946F
	private void OnProgressRewardClick()
	{
		CiacconaGalController.Instance.OpenRewardViewByActivityId(this.ActivityBaseData.Id);
	}

	// Token: 0x06007A08 RID: 31240 RVA: 0x0019B288 File Offset: 0x00199488
	private void OnQuestTipsClick()
	{
		CiacconaGalActivityData activityDataById = CiacconaGalModel.Instance.GetActivityDataById(this.ActivityBaseData.Id);
		if (activityDataById.RecommendQuestId > 0)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, activityDataById.RecommendQuestId, null);
		}
	}

	// Token: 0x06007A09 RID: 31241 RVA: 0x0019B2CF File Offset: 0x001994CF
	private void OnDataUpdate()
	{
		this.Refresh();
	}

	// Token: 0x06007A0A RID: 31242 RVA: 0x0019B2D7 File Offset: 0x001994D7
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

	// Token: 0x04003803 RID: 14339
	private CiacconaActivityInfoPanel CommonActivityInfo;

	// Token: 0x04003804 RID: 14340
	private GenericLayout<CiacconaEndingIcon, CiacconaGalEndingData> LayoutEndings;

	// Token: 0x04003805 RID: 14341
	private ActivityCircleButtonItem EndingRewardItem;

	// Token: 0x04003806 RID: 14342
	private ActivityCircleButtonItem ProgressRewardItem;

	// Token: 0x04003807 RID: 14343
	private ActivityQuestTipsItem QuestTipsItem;

	// Token: 0x020077CB RID: 30667
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040277EA RID: 161770
		public const int ItemCommonActivityInfo = 0;

		// Token: 0x040277EB RID: 161771
		public const int ItemBtnConfirm = 1;

		// Token: 0x040277EC RID: 161772
		public const int ItemRedDot = 2;

		// Token: 0x040277ED RID: 161773
		public const int LayoutEndings = 3;

		// Token: 0x040277EE RID: 161774
		public const int ItemEndingIcon = 4;

		// Token: 0x040277EF RID: 161775
		public const int TextProgress = 5;

		// Token: 0x040277F0 RID: 161776
		public const int SpriteProgress = 6;

		// Token: 0x040277F1 RID: 161777
		public const int ItemEndings = 7;

		// Token: 0x040277F2 RID: 161778
		public const int ItemProgress = 8;

		// Token: 0x040277F3 RID: 161779
		public const int ItemProgressReward = 9;

		// Token: 0x040277F4 RID: 161780
		public const int ItemEndingReward = 10;

		// Token: 0x040277F5 RID: 161781
		public const int ItemQuestTips = 11;

		// Token: 0x040277F6 RID: 161782
		public const int TextRewardLimitTime = 12;
	}
}
