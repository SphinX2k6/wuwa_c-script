using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011BF RID: 4543
public class AnniversaryCelebrationAwardSubView : ActivitySubViewBase
{
	// Token: 0x060078F5 RID: 30965 RVA: 0x00196BB8 File Offset: 0x00194DB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060078F6 RID: 30966 RVA: 0x00196CC6 File Offset: 0x00194EC6
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x060078F7 RID: 30967 RVA: 0x00196CDC File Offset: 0x00194EDC
	protected override UniTask OnBeforeStartAsync()
	{
		AnniversaryCelebrationAwardSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryCelebrationAwardSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060078F8 RID: 30968 RVA: 0x00196D1F File Offset: 0x00194F1F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060078F9 RID: 30969 RVA: 0x00196D3D File Offset: 0x00194F3D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060078FA RID: 30970 RVA: 0x00196D5C File Offset: 0x00194F5C
	protected override void OnStart()
	{
		base.GetText(4).SetText(this.ActivityBaseData.GetTitle(), true);
		string activityLogo = CelebrationUtils.GetActivityLogo();
		base.SetTextureByPath(activityLogo, base.GetTexture(6), null, null);
		this.RefreshTimeTitle();
		this.RefreshRewardPanels();
		this.RefreshRewardState();
		this.ActivityTimePointRewardData.SaveClickRedDotState();
	}

	// Token: 0x060078FB RID: 30971 RVA: 0x00196DBC File Offset: 0x00194FBC
	private void RefreshRewardPanels()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		for (int i = 0; i < this.AwardPanelArray.Count; i++)
		{
			AwardPanel awardPanel = this.AwardPanelArray[i];
			TimePointRewardData data = rewardDataList[i];
			awardPanel.SetActivityId(this.ActivityTimePointRewardData.Id);
			awardPanel.Refresh(data);
		}
	}

	// Token: 0x060078FC RID: 30972 RVA: 0x00196E16 File Offset: 0x00195016
	[NullableContext(1)]
	private string GetTipsTextId(int i)
	{
		if (i == 0)
		{
			return "Anniversary_WelfareTime_430";
		}
		return "Anniversary_WelfareTime_523";
	}

	// Token: 0x060078FD RID: 30973 RVA: 0x00196E28 File Offset: 0x00195028
	private void RefreshRewardState()
	{
		List<TimePointRewardData> rewardDataList = this.ActivityTimePointRewardData.GetRewardDataList();
		for (int i = 0; i < this.AwardPanelArray.Count; i++)
		{
			AwardPanel awardPanel = this.AwardPanelArray[i];
			TimePointRewardData data = rewardDataList[i];
			awardPanel.RefreshState(data, this.GetTipsTextId(i));
		}
	}

	// Token: 0x060078FE RID: 30974 RVA: 0x00196E78 File Offset: 0x00195078
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardPanels();
		this.RefreshRewardState();
	}

	// Token: 0x060078FF RID: 30975 RVA: 0x00196E98 File Offset: 0x00195098
	private void RefreshTimeTitle()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityTimePointRewardData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(1).SetText(item2, true);
		base.GetItem(0).SetUIActive(item);
	}

	// Token: 0x06007900 RID: 30976 RVA: 0x00196EDE File Offset: 0x001950DE
	protected override void OnTimer(float gap)
	{
		this.RefreshRewardState();
		this.RefreshTimeTitle();
	}

	// Token: 0x0400379D RID: 14237
	[Nullable(2)]
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x0400379E RID: 14238
	[Nullable(1)]
	private readonly List<AwardPanel> AwardPanelArray = new List<AwardPanel>();

	// Token: 0x0400379F RID: 14239
	private const int AwardPanelBegin = 2;

	// Token: 0x040037A0 RID: 14240
	private const int AwardPanelEnd = 3;

	// Token: 0x020077AC RID: 30636
	private class EComponentDefine
	{
		// Token: 0x04027740 RID: 161600
		public const int TimeItem = 0;

		// Token: 0x04027741 RID: 161601
		public const int TimeText = 1;

		// Token: 0x04027742 RID: 161602
		public const int AwardItemA = 2;

		// Token: 0x04027743 RID: 161603
		public const int AwardItemB = 3;

		// Token: 0x04027744 RID: 161604
		public const int TitleText = 4;

		// Token: 0x04027745 RID: 161605
		public const int TipsText = 5;

		// Token: 0x04027746 RID: 161606
		public const int ActivityLogoTexture = 6;
	}
}
