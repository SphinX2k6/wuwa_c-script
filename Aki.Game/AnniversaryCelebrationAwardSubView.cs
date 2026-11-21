using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000673 RID: 1651
public class AnniversaryCelebrationAwardSubView : ActivitySubViewBase
{
	// Token: 0x06004C8C RID: 19596 RVA: 0x0019F868 File Offset: 0x0019DA68
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

	// Token: 0x06004C8D RID: 19597 RVA: 0x0019F976 File Offset: 0x0019DB76
	protected override void OnSetData()
	{
		this.ActivityTimePointRewardData = (this.ActivityBaseData as ActivityTimePointRewardData);
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x0019F98C File Offset: 0x0019DB8C
	protected override UniTask OnBeforeStartAsync()
	{
		AnniversaryCelebrationAwardSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryCelebrationAwardSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x0019F9CF File Offset: 0x0019DBCF
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x0019F9ED File Offset: 0x0019DBED
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x0019FA0C File Offset: 0x0019DC0C
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

	// Token: 0x06004C92 RID: 19602 RVA: 0x0019FA6C File Offset: 0x0019DC6C
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

	// Token: 0x06004C93 RID: 19603 RVA: 0x0019FAC6 File Offset: 0x0019DCC6
	[NullableContext(1)]
	private string GetTipsTextId(int i)
	{
		if (i == 0)
		{
			return "Anniversary_WelfareTime_430";
		}
		return "Anniversary_WelfareTime_523";
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x0019FAD8 File Offset: 0x0019DCD8
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

	// Token: 0x06004C95 RID: 19605 RVA: 0x0019FB28 File Offset: 0x0019DD28
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (this.ActivityBaseData.Id != id)
		{
			return;
		}
		this.RefreshRewardPanels();
		this.RefreshRewardState();
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x0019FB48 File Offset: 0x0019DD48
	private void RefreshTimeTitle()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.ActivityTimePointRewardData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		base.GetText(1).SetText(item2, true);
		base.GetItem(0).SetUIActive(item);
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x0019FB8E File Offset: 0x0019DD8E
	protected override void OnTimer(float gap)
	{
		this.RefreshRewardState();
		this.RefreshTimeTitle();
	}

	// Token: 0x04003836 RID: 14390
	[Nullable(2)]
	protected ActivityTimePointRewardData ActivityTimePointRewardData;

	// Token: 0x04003837 RID: 14391
	[Nullable(1)]
	private readonly List<AwardPanel> AwardPanelArray = new List<AwardPanel>();

	// Token: 0x04003838 RID: 14392
	private const int AwardPanelBegin = 2;

	// Token: 0x04003839 RID: 14393
	private const int AwardPanelEnd = 3;

	// Token: 0x02006937 RID: 26935
	private class EComponentDefine
	{
		// Token: 0x04022A72 RID: 141938
		public const int TimeItem = 0;

		// Token: 0x04022A73 RID: 141939
		public const int TimeText = 1;

		// Token: 0x04022A74 RID: 141940
		public const int AwardItemA = 2;

		// Token: 0x04022A75 RID: 141941
		public const int AwardItemB = 3;

		// Token: 0x04022A76 RID: 141942
		public const int TitleText = 4;

		// Token: 0x04022A77 RID: 141943
		public const int TipsText = 5;

		// Token: 0x04022A78 RID: 141944
		public const int ActivityLogoTexture = 6;
	}
}
