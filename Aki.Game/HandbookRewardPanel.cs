using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007ED RID: 2029
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardPanel : UiPanelBase
{
	// Token: 0x06005C9E RID: 23710 RVA: 0x001DD834 File Offset: 0x001DBA34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite))
		};
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x001DD8E8 File Offset: 0x001DBAE8
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<HandbookRewardItem, int>(base.GetHorizontalLayout(3), new Func<HandbookRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x001DD951 File Offset: 0x001DBB51
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x001DD959 File Offset: 0x001DBB59
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
	}

	// Token: 0x06005CA2 RID: 23714 RVA: 0x001DD964 File Offset: 0x001DBB64
	public void Refresh()
	{
		this.RewardIdList = MoonChasingModel.Instance.HandbookRewardIdList;
		this.CurrentValue = MoonChasingModel.Instance.GetHandbookUnlockCount();
		this.CurrentFinishedRewardCount = 0;
		for (int i = 0; i < this.RewardIdList.Count; i++)
		{
			int id = this.RewardIdList[i];
			HandbookRewardData handbookRewardDataById = MoonChasingModel.Instance.GetHandbookRewardDataById(id);
			if (handbookRewardDataById != null)
			{
				if (handbookRewardDataById.GetState(this.CurrentValue) != EHandbookRewardState.Active)
				{
					this.CurrentFinishedRewardCount++;
				}
				this.MaxValue = Math.Max(handbookRewardDataById.Goal, this.MaxValue);
			}
		}
		this.TotalRewardCount = this.RewardIdList.Count;
		if (this.TotalRewardCount <= 0)
		{
			return;
		}
		this.RewardLayout.RefreshByData(this.RewardIdList, null, false);
		this.LineWidth = (this.MaxProgressWidth - this.RewardWidth * (float)(this.TotalRewardCount - 1)) / (float)this.TotalRewardCount;
		this.SetProgressBarPercent((float)this.CurrentValue / (float)this.MaxValue);
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x001DDA65 File Offset: 0x001DBC65
	public void RefreshLayout()
	{
		this.RewardIdList = MoonChasingModel.Instance.HandbookRewardIdList;
		this.RewardLayout.RefreshByData(this.RewardIdList, null, false);
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x001DDA8C File Offset: 0x001DBC8C
	private void SetProgressBarPercent(float percent)
	{
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, this.TotalRewardCount - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)this.TotalRewardCount * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x001DDAE8 File Offset: 0x001DBCE8
	private HandbookRewardItem OnCreateRewardItem()
	{
		UUIItem item = base.GetItem(1);
		UUISprite sprite = base.GetSprite(2);
		LguiUtil.Instance.CopyItem(sprite, item).SetUIActive(true);
		UUIItem item2 = base.GetItem(5);
		UUISprite sprite2 = base.GetSprite(6);
		LguiUtil.Instance.CopyItem(sprite2, item2).SetUIActive(true);
		return new HandbookRewardItem();
	}

	// Token: 0x04003DAB RID: 15787
	private GenericLayout<HandbookRewardItem, int> RewardLayout;

	// Token: 0x04003DAC RID: 15788
	private UUIItem ProgressBarItem;

	// Token: 0x04003DAD RID: 15789
	private int CurrentValue;

	// Token: 0x04003DAE RID: 15790
	private int MaxValue;

	// Token: 0x04003DAF RID: 15791
	private List<int> RewardIdList = new List<int>();

	// Token: 0x04003DB0 RID: 15792
	private int CurrentFinishedRewardCount;

	// Token: 0x04003DB1 RID: 15793
	private float MaxProgressWidth;

	// Token: 0x04003DB2 RID: 15794
	private readonly float RewardWidth = 120f;

	// Token: 0x04003DB3 RID: 15795
	private float LineWidth;

	// Token: 0x04003DB4 RID: 15796
	private int TotalRewardCount;

	// Token: 0x02006B2E RID: 27438
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402340C RID: 144396
		public const int ProgressPanel = 0;

		// Token: 0x0402340D RID: 144397
		public const int BarPanel = 1;

		// Token: 0x0402340E RID: 144398
		public const int BarSprite = 2;

		// Token: 0x0402340F RID: 144399
		public const int RewardPanel = 3;

		// Token: 0x04023410 RID: 144400
		public const int RewardItem = 4;

		// Token: 0x04023411 RID: 144401
		public const int PanelBackground = 5;

		// Token: 0x04023412 RID: 144402
		public const int BackgroundSprite = 6;
	}
}
