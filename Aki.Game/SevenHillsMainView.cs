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

// Token: 0x02000763 RID: 1891
[NullableContext(1)]
[Nullable(0)]
public class SevenHillsMainView : UiViewBase
{
	// Token: 0x060056F8 RID: 22264 RVA: 0x001C8860 File Offset: 0x001C6A60
	public SevenHillsMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x001C886C File Offset: 0x001C6A6C
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

	// Token: 0x060056FA RID: 22266 RVA: 0x001C899C File Offset: 0x001C6B9C
	protected override UniTask OnBeforeStartAsync()
	{
		SevenHillsMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SevenHillsMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x001C89E0 File Offset: 0x001C6BE0
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

	// Token: 0x060056FC RID: 22268 RVA: 0x001C8A14 File Offset: 0x001C6C14
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

	// Token: 0x060056FD RID: 22269 RVA: 0x001C8AA4 File Offset: 0x001C6CA4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<RewardPopupData>(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x001C8B08 File Offset: 0x001C6D08
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshRewardPopUp, new Action<RewardPopupData>(this.OnRefreshRewardPopUp));
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRewardLayout));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x001C8B69 File Offset: 0x001C6D69
	private SevenHillsRewardBoxItem CreateRewardBoxItem()
	{
		return new SevenHillsRewardBoxItem
		{
			ActivityData = this.ActivityBaseData
		};
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x001C8B7C File Offset: 0x001C6D7C
	private SevenHillsStageItem CreateStageItem()
	{
		return new SevenHillsStageItem
		{
			ActivityData = this.ActivityBaseData,
			OnClickStageItem = new Action<int>(this.OnClickStageItem)
		};
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x001C8BA2 File Offset: 0x001C6DA2
	private void OnRefreshRewardPopUp(RewardPopupData data)
	{
		this.RewardPopup.Refresh(data);
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x001C8BB0 File Offset: 0x001C6DB0
	private void OnRefreshRewardLayout(int activityId)
	{
		if (this.ActivityBaseData != null && this.ActivityBaseData.Id == activityId)
		{
			this.RewardBoxLayout.RefreshByData(this.ActivityBaseData.GetAllScoreRewardData(), null, false);
		}
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x001C8BE0 File Offset: 0x001C6DE0
	protected virtual void OnClickStageItem(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.SevenHillsStageTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x001C8C0A File Offset: 0x001C6E0A
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

	// Token: 0x04003BC6 RID: 15302
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003BC7 RID: 15303
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003BC8 RID: 15304
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SevenHillsRewardBoxItem, LongShanScoreRewardData> RewardBoxLayout;

	// Token: 0x04003BC9 RID: 15305
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SevenHillsStageItem, int> StageLayout;

	// Token: 0x04003BCA RID: 15306
	[Nullable(2)]
	private CommonRewardPopup RewardPopup;

	// Token: 0x02006A5A RID: 27226
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023006 RID: 143366
		public const int ItemCaption = 0;

		// Token: 0x04023007 RID: 143367
		public const int LayoutRewardBox = 1;

		// Token: 0x04023008 RID: 143368
		public const int ItemRewardBox = 2;

		// Token: 0x04023009 RID: 143369
		public const int TextCount = 3;

		// Token: 0x0402300A RID: 143370
		public const int TextTotal = 4;

		// Token: 0x0402300B RID: 143371
		public const int LayoutStage = 5;

		// Token: 0x0402300C RID: 143372
		public const int ItemStage = 6;

		// Token: 0x0402300D RID: 143373
		public const int ListAnimController = 7;
	}
}
