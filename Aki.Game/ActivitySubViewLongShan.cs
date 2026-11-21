using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000756 RID: 1878
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewLongShan : ActivitySubViewBase
{
	// Token: 0x06005664 RID: 22116 RVA: 0x001C56B4 File Offset: 0x001C38B4
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

	// Token: 0x06005665 RID: 22117 RVA: 0x001C5842 File Offset: 0x001C3A42
	protected override void OnSetData()
	{
		this.ActivityData = (ActivityLongShanData)this.ActivityBaseData;
	}

	// Token: 0x06005666 RID: 22118 RVA: 0x001C5858 File Offset: 0x001C3A58
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewLongShan.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewLongShan.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005667 RID: 22119 RVA: 0x001C589B File Offset: 0x001C3A9B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06005668 RID: 22120 RVA: 0x001C58B9 File Offset: 0x001C3AB9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x06005669 RID: 22121 RVA: 0x001C58D7 File Offset: 0x001C3AD7
	protected override void OnStart()
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600566A RID: 22122 RVA: 0x001C58DF File Offset: 0x001C3ADF
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

	// Token: 0x0600566B RID: 22123 RVA: 0x001C5920 File Offset: 0x001C3B20
	protected override UniTask OnBeforeHideSelfAsync()
	{
		ActivitySubViewLongShan.<OnBeforeHideSelfAsync>d__12 <OnBeforeHideSelfAsync>d__;
		<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideSelfAsync>d__.<>4__this = this;
		<OnBeforeHideSelfAsync>d__.<>1__state = -1;
		<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivitySubViewLongShan.<OnBeforeHideSelfAsync>d__12>(ref <OnBeforeHideSelfAsync>d__);
		return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600566C RID: 22124 RVA: 0x001C5963 File Offset: 0x001C3B63
	private void OnClickDetail(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			EventSystem.Instance.Emit<bool, EActivityViewState, bool?>(EEventName.SetActivityViewState, false, EActivityViewState.Side, null);
		});
	}

	// Token: 0x0600566D RID: 22125 RVA: 0x001C5994 File Offset: 0x001C3B94
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600566E RID: 22126 RVA: 0x001C599C File Offset: 0x001C3B9C
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

	// Token: 0x0600566F RID: 22127 RVA: 0x001C59F0 File Offset: 0x001C3BF0
	private void OnDataUpdate()
	{
		if (this.StageItems != null)
		{
			foreach (LongShanStageItem longShanStageItem in this.StageItems)
			{
				longShanStageItem.RefreshState();
			}
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(Array.Exists<int>(this.ActivityData.StageIds, (int x) => this.ActivityData.GetStageInfoById(x) == null));
		this.RefreshRedDot();
	}

	// Token: 0x06005670 RID: 22128 RVA: 0x001C5A84 File Offset: 0x001C3C84
	public override void OnCommonViewStateChange(bool show)
	{
		this.PlaySubViewSequence(show ? "SwitchOut" : "SwitchIn", true);
	}

	// Token: 0x06005671 RID: 22129 RVA: 0x001C5A9C File Offset: 0x001C3C9C
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

	// Token: 0x06005672 RID: 22130 RVA: 0x001C5B1C File Offset: 0x001C3D1C
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

	// Token: 0x06005673 RID: 22131 RVA: 0x001C5B88 File Offset: 0x001C3D88
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

	// Token: 0x06005674 RID: 22132 RVA: 0x001C5BC8 File Offset: 0x001C3DC8
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

	// Token: 0x06005675 RID: 22133 RVA: 0x001C5C84 File Offset: 0x001C3E84
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

	// Token: 0x06005676 RID: 22134 RVA: 0x001C5CDC File Offset: 0x001C3EDC
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

	// Token: 0x04003B94 RID: 15252
	protected ActivityLongShanData ActivityData;

	// Token: 0x04003B95 RID: 15253
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04003B96 RID: 15254
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<LongShanStageItem> StageItems;

	// Token: 0x04003B97 RID: 15255
	private bool TransitionAnimFlag;

	// Token: 0x02006A44 RID: 27204
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022F8C RID: 143244
		public const int ScreenPanel = 0;

		// Token: 0x04022F8D RID: 143245
		public const int TxtTime = 1;

		// Token: 0x04022F8E RID: 143246
		public const int CommonActionInfo = 2;

		// Token: 0x04022F8F RID: 143247
		public const int BtnMainQuest = 3;

		// Token: 0x04022F90 RID: 143248
		public const int TaskBtnItemA = 4;

		// Token: 0x04022F91 RID: 143249
		public const int TaskBtnItemB = 5;

		// Token: 0x04022F92 RID: 143250
		public const int TaskBtnItemC = 6;

		// Token: 0x04022F93 RID: 143251
		public const int TaskBtnItemD = 7;

		// Token: 0x04022F94 RID: 143252
		public const int InfoItem = 8;
	}
}
