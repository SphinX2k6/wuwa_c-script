using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011C7 RID: 4551
public class ActivitySubViewCheckInReward : ActivitySubViewBase
{
	// Token: 0x06007937 RID: 31031 RVA: 0x00198DC8 File Offset: 0x00196FC8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007938 RID: 31032 RVA: 0x00198EF7 File Offset: 0x001970F7
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06007939 RID: 31033 RVA: 0x00198F0C File Offset: 0x0019710C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewCheckInReward.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600793A RID: 31034 RVA: 0x00198F4F File Offset: 0x0019714F
	protected override void OnStart()
	{
		this.SetStaticText();
		this.RefreshTimerText();
	}

	// Token: 0x0600793B RID: 31035 RVA: 0x00198F5D File Offset: 0x0019715D
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x0600793C RID: 31036 RVA: 0x00198F65 File Offset: 0x00197165
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600793D RID: 31037 RVA: 0x00198F83 File Offset: 0x00197183
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x00198FA4 File Offset: 0x001971A4
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewCheckInReward.<OnBeforeShowSelfAsync>d__12 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<OnBeforeShowSelfAsync>d__12>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x00198FE8 File Offset: 0x001971E8
	private UniTask RefreshRewardLayout()
	{
		ActivitySubViewCheckInReward.<RefreshRewardLayout>d__13 <RefreshRewardLayout>d__;
		<RefreshRewardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardLayout>d__.<>4__this = this;
		<RefreshRewardLayout>d__.<>1__state = -1;
		<RefreshRewardLayout>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<RefreshRewardLayout>d__13>(ref <RefreshRewardLayout>d__);
		return <RefreshRewardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06007940 RID: 31040 RVA: 0x0019902B File Offset: 0x0019722B
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardLayout();
	}

	// Token: 0x06007941 RID: 31041 RVA: 0x00199044 File Offset: 0x00197244
	private void SetStaticText()
	{
		string title = ActivityConfig.Instance.GetActivityConfig(102000009).Value.Title;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), title, Array.Empty<object>());
		string desc = ActivityConfig.Instance.GetActivityConfig(102000009).Value.Desc;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), desc, Array.Empty<object>());
	}

	// Token: 0x06007942 RID: 31042 RVA: 0x001990C0 File Offset: 0x001972C0
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(1).SetActive(item, false);
		if (item)
		{
			base.GetText(1).SetText(item2, true);
		}
	}

	// Token: 0x06007943 RID: 31043 RVA: 0x00199104 File Offset: 0x00197304
	private void OnClickedButton()
	{
		List<int> list = new List<int>();
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		for (int i = 0; i < this.CardComponentIds.Length; i++)
		{
			if (rewardDataList[i].RewardState == ETimePointRewardState.UnlockAndUnClaimed)
			{
				list.Add(rewardDataList[i].Id);
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		ActivityTimePointRewardController.Instance.GetBatchRewardById(102000009, list);
	}

	// Token: 0x040037B3 RID: 14259
	[Nullable(1)]
	private readonly int[] CardComponentIds = new int[]
	{
		2,
		3
	};

	// Token: 0x040037B4 RID: 14260
	[Nullable(2)]
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x040037B5 RID: 14261
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CheckInRewardCard[] CheckInRewardCards;

	// Token: 0x040037B6 RID: 14262
	[Nullable(2)]
	private UiPanelBase BgItem;

	// Token: 0x020077B5 RID: 30645
	private enum EComponents
	{
		// Token: 0x04027785 RID: 161669
		PnlTime,
		// Token: 0x04027786 RID: 161670
		TxtTime,
		// Token: 0x04027787 RID: 161671
		BtnWelfare37Card1,
		// Token: 0x04027788 RID: 161672
		BtnWelfare37Card2,
		// Token: 0x04027789 RID: 161673
		TxtTitle,
		// Token: 0x0402778A RID: 161674
		TxtTip,
		// Token: 0x0402778B RID: 161675
		TextActivityIcon,
		// Token: 0x0402778C RID: 161676
		TexBg
	}
}
