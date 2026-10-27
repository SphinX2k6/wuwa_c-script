using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012AF RID: 4783
[NullableContext(1)]
[Nullable(0)]
public class SevenHillsMainView : UiViewBase
{
	// Token: 0x06008361 RID: 33633 RVA: 0x001BFAD0 File Offset: 0x001BDCD0
	public SevenHillsMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008362 RID: 33634 RVA: 0x001BFADC File Offset: 0x001BDCDC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIInturnAnimController));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008363 RID: 33635 RVA: 0x001BFC0C File Offset: 0x001BDE0C
	protected override UniTask OnBeforeStartAsync()
	{
		SevenHillsMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SevenHillsMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008364 RID: 33636 RVA: 0x001BFC50 File Offset: 0x001BDE50
	protected virtual void RefreshTitleIcon()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("SevenHillsIconPath");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleIcon(stringConfig);
		}
	}

	// Token: 0x06008365 RID: 33637 RVA: 0x001BFC84 File Offset: 0x001BDE84
	protected override void OnBeforeShow()
	{
		int scoreItemCount = this.ActivityBaseData.GetScoreItemCount();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(scoreItemCount.ToString(), true);
		}
		int scoreItemTotal = this.ActivityBaseData.ScoreItemTotal;
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(scoreItemTotal);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.RewardBoxLayout.RefreshByData(this.ActivityBaseData.GetAllScoreRewardData(), null, false);
	}

	// Token: 0x06008366 RID: 33638 RVA: 0x001BFD14 File Offset: 0x001BDF14
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008367 RID: 33639 RVA: 0x001BFD78 File Offset: 0x001BDF78
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x06008368 RID: 33640 RVA: 0x001BFDD9 File Offset: 0x001BDFD9
	private SevenHillsRewardBoxItem CreateRewardBoxItem()
	{
		return new SevenHillsRewardBoxItem
		{
			ActivityData = this.ActivityBaseData
		};
	}

	// Token: 0x06008369 RID: 33641 RVA: 0x001BFDEC File Offset: 0x001BDFEC
	private SevenHillsStageItem CreateStageItem()
	{
		return new SevenHillsStageItem
		{
			ActivityData = this.ActivityBaseData,
			OnClickStageItem = new Action<int>(this.OnClickStageItem)
		};
	}

	// Token: 0x0600836A RID: 33642 RVA: 0x001BFE12 File Offset: 0x001BE012
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x0600836B RID: 33643 RVA: 0x001BFE20 File Offset: 0x001BE020
	private void OnRefreshRewardLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			this.RewardBoxLayout.RefreshByData(this.ActivityBaseData.GetAllScoreRewardData(), null, false);
		}
	}

	// Token: 0x0600836C RID: 33644 RVA: 0x001BFE50 File Offset: 0x001BE050
	protected virtual void OnClickStageItem(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.SevenHillsStageTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x0600836D RID: 33645 RVA: 0x001BFE7A File Offset: 0x001BE07A
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Start" || param == "showviewStart")
		{
			UUIInturnAnimController uiInturnAnimController = base.GetUiInturnAnimController(7);
			if (uiInturnAnimController == null)
			{
				return;
			}
			uiInturnAnimController.Play("", -1, false);
		}
	}

	// Token: 0x04003B2E RID: 15150
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003B2F RID: 15151
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003B30 RID: 15152
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SevenHillsRewardBoxItem, LongShanScoreRewardData> RewardBoxLayout;

	// Token: 0x04003B31 RID: 15153
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SevenHillsStageItem, int> StageLayout;

	// Token: 0x04003B32 RID: 15154
	[Nullable(2)]
	private CommonRewardPopup RewardPopup;

	// Token: 0x020078D0 RID: 30928
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027CD8 RID: 163032
		public const int ItemCaption = 0;

		// Token: 0x04027CD9 RID: 163033
		public const int LayoutRewardBox = 1;

		// Token: 0x04027CDA RID: 163034
		public const int ItemRewardBox = 2;

		// Token: 0x04027CDB RID: 163035
		public const int TextCount = 3;

		// Token: 0x04027CDC RID: 163036
		public const int TextTotal = 4;

		// Token: 0x04027CDD RID: 163037
		public const int LayoutStage = 5;

		// Token: 0x04027CDE RID: 163038
		public const int ItemStage = 6;

		// Token: 0x04027CDF RID: 163039
		public const int ListAnimController = 7;
	}
}
