using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000666 RID: 1638
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastRewardPanel : UiPanelBase
{
	// Token: 0x06004BCE RID: 19406 RVA: 0x0019B8C8 File Offset: 0x00199AC8
	public BlackCoastRewardPanel(ActivityBlackCoastData data)
	{
		this.ActivityBaseData = data;
	}

	// Token: 0x06004BCF RID: 19407 RVA: 0x0019B8E4 File Offset: 0x00199AE4
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

	// Token: 0x06004BD0 RID: 19408 RVA: 0x0019B9F4 File Offset: 0x00199BF4
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<BlackCoastRewardItem, BlackCoastProgressRewardData>(base.GetHorizontalLayout(3), new Func<BlackCoastRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
	}

	// Token: 0x06004BD1 RID: 19409 RVA: 0x0019BA5D File Offset: 0x00199C5D
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x0019BA68 File Offset: 0x00199C68
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
		this.RewardLayout.RefreshByData(allProgressRewardData, null, false);
		this.LineWidth = (this.MaxProgressWidth - this.RewardWidth * (float)(this.TotalRewardCount - 1)) / (float)this.TotalRewardCount;
		this.SetProgressBarPercent((float)this.CurrentValue / (float)this.MaxValue);
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x0019BB36 File Offset: 0x00199D36
	public void RefreshLayout()
	{
		this.RewardLayout.RefreshByData(this.ActivityBaseData.GetAllProgressRewardData(), null, false);
	}

	// Token: 0x06004BD4 RID: 19412 RVA: 0x0019BB50 File Offset: 0x00199D50
	private void SetProgressBarPercent(float percent)
	{
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, this.TotalRewardCount - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)this.TotalRewardCount * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x06004BD5 RID: 19413 RVA: 0x0019BBAC File Offset: 0x00199DAC
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

	// Token: 0x040037EB RID: 14315
	private const float REWARD_WIDTH = 120f;

	// Token: 0x040037EC RID: 14316
	protected ActivityBlackCoastData ActivityBaseData;

	// Token: 0x040037ED RID: 14317
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<BlackCoastRewardItem, BlackCoastProgressRewardData> RewardLayout;

	// Token: 0x040037EE RID: 14318
	[Nullable(2)]
	private UUIItem ProgressBarItem;

	// Token: 0x040037EF RID: 14319
	private int CurrentValue;

	// Token: 0x040037F0 RID: 14320
	private int MaxValue;

	// Token: 0x040037F1 RID: 14321
	private int CurrentFinishedRewardCount;

	// Token: 0x040037F2 RID: 14322
	private float MaxProgressWidth;

	// Token: 0x040037F3 RID: 14323
	private readonly float RewardWidth = 120f;

	// Token: 0x040037F4 RID: 14324
	private float LineWidth;

	// Token: 0x040037F5 RID: 14325
	private int TotalRewardCount;

	// Token: 0x02006925 RID: 26917
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022A34 RID: 141876
		public const int ProgressPanel = 0;

		// Token: 0x04022A35 RID: 141877
		public const int BarPanel = 1;

		// Token: 0x04022A36 RID: 141878
		public const int BarSprite = 2;

		// Token: 0x04022A37 RID: 141879
		public const int RewardPanel = 3;

		// Token: 0x04022A38 RID: 141880
		public const int RewardItem = 4;

		// Token: 0x04022A39 RID: 141881
		public const int PanelBackground = 5;

		// Token: 0x04022A3A RID: 141882
		public const int BackgroundSprite = 6;
	}
}
