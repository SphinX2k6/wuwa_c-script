using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011B2 RID: 4530
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastRewardPanel : UiPanelBase
{
	// Token: 0x06007837 RID: 30775 RVA: 0x00192CF0 File Offset: 0x00190EF0
	public BlackCoastRewardPanel(ActivityBlackCoastData data)
	{
		this.ActivityBaseData = data;
	}

	// Token: 0x06007838 RID: 30776 RVA: 0x00192D0C File Offset: 0x00190F0C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007839 RID: 30777 RVA: 0x00192E1C File Offset: 0x0019101C
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<BlackCoastRewardItem, BlackCoastProgressRewardData>(base.GetHorizontalLayout(3), new Func<BlackCoastRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
	}

	// Token: 0x0600783A RID: 30778 RVA: 0x00192E85 File Offset: 0x00191085
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
	}

	// Token: 0x0600783B RID: 30779 RVA: 0x00192E90 File Offset: 0x00191090
	public void Refresh()
	{
		this.CurrentValue = this.ActivityBaseData.GetProgressItemCount();
		this.CurrentFinishedRewardCount = 0;
		BlackCoastProgressRewardData[] allProgressRewardData = this.ActivityBaseData.GetAllProgressRewardData();
		foreach (BlackCoastProgressRewardData blackCoastProgressRewardData in allProgressRewardData)
		{
			if (blackCoastProgressRewardData.GetState() != EActivityTaskState.Active)
			{
				this.CurrentFinishedRewardCount++;
			}
			this.MaxValue = Math.Max(blackCoastProgressRewardData.Goal, this.MaxValue);
		}
		this.TotalRewardCount = allProgressRewardData.Length;
		if (this.TotalRewardCount <= 0)
		{
			return;
		}
		this.RewardLayout.RefreshByData(allProgressRewardData.ToList<BlackCoastProgressRewardData>(), null, false);
		this.LineWidth = (this.MaxProgressWidth - this.RewardWidth * (float)(this.TotalRewardCount - 1)) / (float)this.TotalRewardCount;
		this.SetProgressBarPercent((float)this.CurrentValue / (float)this.MaxValue);
	}

	// Token: 0x0600783C RID: 30780 RVA: 0x00192F63 File Offset: 0x00191163
	public void RefreshLayout()
	{
		this.RewardLayout.RefreshByData(this.ActivityBaseData.GetAllProgressRewardData().ToList<BlackCoastProgressRewardData>(), null, false);
	}

	// Token: 0x0600783D RID: 30781 RVA: 0x00192F84 File Offset: 0x00191184
	private void SetProgressBarPercent(float percent)
	{
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, this.TotalRewardCount - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)this.TotalRewardCount * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x0600783E RID: 30782 RVA: 0x00192FE0 File Offset: 0x001911E0
	private BlackCoastRewardItem OnCreateRewardItem()
	{
		UUIItem item = base.GetItem(1);
		UUISprite sprite = base.GetSprite(2);
		LguiUtil.Instance.CopyItem(sprite, item).SetUIActive(true);
		UUIItem item2 = base.GetItem(5);
		UUISprite sprite2 = base.GetSprite(6);
		LguiUtil.Instance.CopyItem(sprite2, item2).SetUIActive(true);
		return new BlackCoastRewardItem
		{
			RequestGetAllAvailableReward = delegate()
			{
				int[] allAvailableProgressRewardIds = this.ActivityBaseData.GetAllAvailableProgressRewardIds();
				if (allAvailableProgressRewardIds.Length != 0)
				{
					ActivityBlackCoastController.Instance.RequestDataProgressReward(this.ActivityBaseData.Id, allAvailableProgressRewardIds);
				}
			}
		};
	}

	// Token: 0x04003752 RID: 14162
	private const float REWARD_WIDTH = 120f;

	// Token: 0x04003753 RID: 14163
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x04003754 RID: 14164
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BlackCoastRewardItem, BlackCoastProgressRewardData> RewardLayout;

	// Token: 0x04003755 RID: 14165
	[Nullable(2)]
	private UUIItem ProgressBarItem;

	// Token: 0x04003756 RID: 14166
	private int CurrentValue;

	// Token: 0x04003757 RID: 14167
	private int MaxValue;

	// Token: 0x04003758 RID: 14168
	private int CurrentFinishedRewardCount;

	// Token: 0x04003759 RID: 14169
	private float MaxProgressWidth;

	// Token: 0x0400375A RID: 14170
	private readonly float RewardWidth = 120f;

	// Token: 0x0400375B RID: 14171
	private float LineWidth;

	// Token: 0x0400375C RID: 14172
	private int TotalRewardCount;

	// Token: 0x02007799 RID: 30617
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040276FE RID: 161534
		public const int ProgressPanel = 0;

		// Token: 0x040276FF RID: 161535
		public const int BarPanel = 1;

		// Token: 0x04027700 RID: 161536
		public const int BarSprite = 2;

		// Token: 0x04027701 RID: 161537
		public const int RewardPanel = 3;

		// Token: 0x04027702 RID: 161538
		public const int RewardItem = 4;

		// Token: 0x04027703 RID: 161539
		public const int PanelBackground = 5;

		// Token: 0x04027704 RID: 161540
		public const int BackgroundSprite = 6;
	}
}
