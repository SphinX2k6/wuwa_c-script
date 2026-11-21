using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200067B RID: 1659
public class ActivitySubViewCheckInReward : ActivitySubViewBase
{
	// Token: 0x06004CCE RID: 19662 RVA: 0x001A1A78 File Offset: 0x0019FC78
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

	// Token: 0x06004CCF RID: 19663 RVA: 0x001A1BA7 File Offset: 0x0019FDA7
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06004CD0 RID: 19664 RVA: 0x001A1BBC File Offset: 0x0019FDBC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewCheckInReward.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004CD1 RID: 19665 RVA: 0x001A1BFF File Offset: 0x0019FDFF
	protected override void OnStart()
	{
		this.SetStaticText();
		this.RefreshTimerText();
	}

	// Token: 0x06004CD2 RID: 19666 RVA: 0x001A1C0D File Offset: 0x0019FE0D
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06004CD3 RID: 19667 RVA: 0x001A1C15 File Offset: 0x0019FE15
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004CD4 RID: 19668 RVA: 0x001A1C33 File Offset: 0x0019FE33
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004CD5 RID: 19669 RVA: 0x001A1C54 File Offset: 0x0019FE54
	protected override UniTask OnBeforeShowSelfAsync()
	{
		ActivitySubViewCheckInReward.<OnBeforeShowSelfAsync>d__12 <OnBeforeShowSelfAsync>d__;
		<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowSelfAsync>d__.<>4__this = this;
		<OnBeforeShowSelfAsync>d__.<>1__state = -1;
		<OnBeforeShowSelfAsync>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<OnBeforeShowSelfAsync>d__12>(ref <OnBeforeShowSelfAsync>d__);
		return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004CD6 RID: 19670 RVA: 0x001A1C98 File Offset: 0x0019FE98
	private UniTask RefreshRewardLayout()
	{
		ActivitySubViewCheckInReward.<RefreshRewardLayout>d__13 <RefreshRewardLayout>d__;
		<RefreshRewardLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRewardLayout>d__.<>4__this = this;
		<RefreshRewardLayout>d__.<>1__state = -1;
		<RefreshRewardLayout>d__.<>t__builder.Start<ActivitySubViewCheckInReward.<RefreshRewardLayout>d__13>(ref <RefreshRewardLayout>d__);
		return <RefreshRewardLayout>d__.<>t__builder.Task;
	}

	// Token: 0x06004CD7 RID: 19671 RVA: 0x001A1CDB File Offset: 0x0019FEDB
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardLayout();
	}

	// Token: 0x06004CD8 RID: 19672 RVA: 0x001A1CF4 File Offset: 0x0019FEF4
	private void SetStaticText()
	{
		string title = ActivityConfig.Instance.GetActivityConfig(102000009).Value.Title;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), title, Array.Empty<object>());
		string desc = ActivityConfig.Instance.GetActivityConfig(102000009).Value.Desc;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), desc, Array.Empty<object>());
	}

	// Token: 0x06004CD9 RID: 19673 RVA: 0x001A1D70 File Offset: 0x0019FF70
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

	// Token: 0x06004CDA RID: 19674 RVA: 0x001A1DB4 File Offset: 0x0019FFB4
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

	// Token: 0x0400384C RID: 14412
	[Nullable(1)]
	private readonly int[] CardComponentIds = new int[]
	{
		2,
		3
	};

	// Token: 0x0400384D RID: 14413
	[Nullable(2)]
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x0400384E RID: 14414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CheckInRewardCard[] CheckInRewardCards;

	// Token: 0x0400384F RID: 14415
	[Nullable(2)]
	private UiPanelBase BgItem;

	// Token: 0x02006940 RID: 26944
	private enum EComponents
	{
		// Token: 0x04022AB7 RID: 142007
		PnlTime,
		// Token: 0x04022AB8 RID: 142008
		TxtTime,
		// Token: 0x04022AB9 RID: 142009
		BtnWelfare37Card1,
		// Token: 0x04022ABA RID: 142010
		BtnWelfare37Card2,
		// Token: 0x04022ABB RID: 142011
		TxtTitle,
		// Token: 0x04022ABC RID: 142012
		TxtTip,
		// Token: 0x04022ABD RID: 142013
		TextActivityIcon,
		// Token: 0x04022ABE RID: 142014
		TexBg
	}
}
