using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012A2 RID: 4770
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewLongShan : ActivitySubViewBase
{
	// Token: 0x060082CD RID: 33485 RVA: 0x001BC924 File Offset: 0x001BAB24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickMainQuest));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060082CE RID: 33486 RVA: 0x001BCAB2 File Offset: 0x001BACB2
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x060082CF RID: 33487 RVA: 0x001BCAC8 File Offset: 0x001BACC8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewLongShan.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewLongShan.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060082D0 RID: 33488 RVA: 0x001BCB0B File Offset: 0x001BAD0B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060082D1 RID: 33489 RVA: 0x001BCB29 File Offset: 0x001BAD29
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060082D2 RID: 33490 RVA: 0x001BCB47 File Offset: 0x001BAD47
	protected override void OnStart()
	{
		this.RefreshTimerText();
	}

	// Token: 0x060082D3 RID: 33491 RVA: 0x001BCB4F File Offset: 0x001BAD4F
	protected override void OnBeforeShow()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetBtnText("LongShanStage_Join", Array.Empty<object>());
		}
		ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
		if (commonInfoPanel2 != null)
		{
			commonInfoPanel2.SetClickFunc(new Action<ActivityBaseData>(this.OnClickDetail));
		}
		this.RefreshRedDot();
	}

	// Token: 0x060082D4 RID: 33492 RVA: 0x001BCB90 File Offset: 0x001BAD90
	protected override UniTask OnBeforeHideSelfAsync()
	{
		ActivitySubViewLongShan.<OnBeforeHideSelfAsync>d__12 <OnBeforeHideSelfAsync>d__;
		<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideSelfAsync>d__.<>4__this = this;
		<OnBeforeHideSelfAsync>d__.<>1__state = -1;
		<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewLongShan.<OnBeforeHideSelfAsync>d__12>(ref <OnBeforeHideSelfAsync>d__);
		return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060082D5 RID: 33493 RVA: 0x001BCBD3 File Offset: 0x001BADD3
	private void OnClickDetail(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			EventSystem.Instance.Emit<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, false, EActivityViewState.Side, null);
		});
	}

	// Token: 0x060082D6 RID: 33494 RVA: 0x001BCC04 File Offset: 0x001BAE04
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x060082D7 RID: 33495 RVA: 0x001BCC0C File Offset: 0x001BAE0C
	protected override void OnRefreshView()
	{
		this.RefreshTimerText();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.RefreshView();
		}
		this.OnDataUpdate();
		if (this.TransitionAnimFlag)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("TransIn", true, null, false);
			this.TransitionAnimFlag = false;
		}
	}

	// Token: 0x060082D8 RID: 33496 RVA: 0x001BCC60 File Offset: 0x001BAE60
	private void OnDataUpdate()
	{
		if (this.StageItems != null)
		{
			foreach (LongShanStageItem longShanStageItem in this.StageItems)
			{
				longShanStageItem.RefreshState();
			}
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.ActivityData.StageIds.Any((int x) => this.ActivityData.GetStageInfoById(x) == null));
		this.RefreshRedDot();
	}

	// Token: 0x060082D9 RID: 33497 RVA: 0x001BCCF4 File Offset: 0x001BAEF4
	public override void OnCommonViewStateChange(bool show)
	{
		this.PlaySubViewSequence(show ? "SwitchOut" : "SwitchIn", true);
	}

	// Token: 0x060082DA RID: 33498 RVA: 0x001BCD0C File Offset: 0x001BAF0C
	[NullableContext(1)]
	protected override void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			this.SetInternalItemInteractive(false);
			return;
		}
		if (sequenceName == "SwitchOut")
		{
			this.SetInternalItemInteractive(false);
			return;
		}
		if (sequenceName == "SwitchIn")
		{
			this.SetInternalItemInteractive(true);
			if (this.StageItems != null && this.StageItems.Count > 0)
			{
				UiNavigationNewController.Instance.SetNavigationFocusForView(this.StageItems[0].GetLongShanButton(), true, false, false);
			}
		}
	}

	// Token: 0x060082DB RID: 33499 RVA: 0x001BCD8C File Offset: 0x001BAF8C
	private void SetInternalItemInteractive(bool value)
	{
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.SetSelfInteractive(value);
		}
		if (this.StageItems != null)
		{
			foreach (LongShanStageItem longShanStageItem in this.StageItems)
			{
				longShanStageItem.SetButtonInteractive(value);
			}
		}
	}

	// Token: 0x060082DC RID: 33500 RVA: 0x001BCDF8 File Offset: 0x001BAFF8
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(1).SetUIActive(item);
		if (item)
		{
			base.GetText(1).SetText(item2, true);
		}
	}

	// Token: 0x060082DD RID: 33501 RVA: 0x001BCE38 File Offset: 0x001BB038
	private void OnClickMainQuest()
	{
		if (this.ActivityData == null || this.ActivityData.StageIds == null)
		{
			return;
		}
		int? num = null;
		foreach (int num2 in this.ActivityData.StageIds)
		{
			ActivityLongShanData activityData = this.ActivityData;
			if (((activityData != null) ? activityData.GetStageInfoById(num2) : null) == null)
			{
				LongShanStage? config = ConfigLongShanStageById.GetConfig(num2, true);
				num = ((config != null) ? new int?(config.GetValueOrDefault().QuestionId) : null);
				break;
			}
		}
		if (num != null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, num.Value, null);
		}
	}

	// Token: 0x060082DE RID: 33502 RVA: 0x001BCEF4 File Offset: 0x001BB0F4
	private void OnClickStageDetail(int stageId)
	{
		if (this.ActivityData.GetStageInfoById(stageId) != null)
		{
			this.TransitionAnimFlag = true;
			UiManager.Instance.OpenView(EUiViewName.LongShanView, new object[]
			{
				this.ActivityData,
				stageId
			}, null);
			return;
		}
		ActivityLongShanController.Instance.ShowUnlockTip(stageId);
	}

	// Token: 0x060082DF RID: 33503 RVA: 0x001BCF4C File Offset: 0x001BB14C
	private void RefreshRedDot()
	{
		bool functionRedDotVisible = this.ActivityData.CheckAnyStageRed();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel == null)
		{
			return;
		}
		commonInfoPanel.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x04003AFC RID: 15100
	protected ActivityLongShanData ActivityData;

	// Token: 0x04003AFD RID: 15101
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003AFE RID: 15102
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<LongShanStageItem> StageItems;

	// Token: 0x04003AFF RID: 15103
	private bool TransitionAnimFlag;

	// Token: 0x020078BA RID: 30906
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C5E RID: 162910
		public const int ScreenPanel = 0;

		// Token: 0x04027C5F RID: 162911
		public const int TxtTime = 1;

		// Token: 0x04027C60 RID: 162912
		public const int CommonActionInfo = 2;

		// Token: 0x04027C61 RID: 162913
		public const int BtnMainQuest = 3;

		// Token: 0x04027C62 RID: 162914
		public const int TaskBtnItemA = 4;

		// Token: 0x04027C63 RID: 162915
		public const int TaskBtnItemB = 5;

		// Token: 0x04027C64 RID: 162916
		public const int TaskBtnItemC = 6;

		// Token: 0x04027C65 RID: 162917
		public const int TaskBtnItemD = 7;

		// Token: 0x04027C66 RID: 162918
		public const int InfoItem = 8;
	}
}
