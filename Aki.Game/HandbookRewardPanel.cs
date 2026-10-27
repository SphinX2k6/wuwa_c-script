using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001339 RID: 4921
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardPanel : UiPanelBase
{
	// Token: 0x06008903 RID: 35075 RVA: 0x001D49C8 File Offset: 0x001D2BC8
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

	// Token: 0x06008904 RID: 35076 RVA: 0x001D4A7C File Offset: 0x001D2C7C
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<HandbookRewardItem, int>(base.GetHorizontalLayout(3), new Func<HandbookRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
	}

	// Token: 0x06008905 RID: 35077 RVA: 0x001D4AE5 File Offset: 0x001D2CE5
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x06008906 RID: 35078 RVA: 0x001D4AED File Offset: 0x001D2CED
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
	}

	// Token: 0x06008907 RID: 35079 RVA: 0x001D4AF8 File Offset: 0x001D2CF8
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

	// Token: 0x06008908 RID: 35080 RVA: 0x001D4BF9 File Offset: 0x001D2DF9
	public void RefreshLayout()
	{
		this.RewardIdList = MoonChasingModel.Instance.HandbookRewardIdList;
		this.RewardLayout.RefreshByData(this.RewardIdList, null, false);
	}

	// Token: 0x06008909 RID: 35081 RVA: 0x001D4C20 File Offset: 0x001D2E20
	private void SetProgressBarPercent(float percent)
	{
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, this.TotalRewardCount - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)this.TotalRewardCount * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x0600890A RID: 35082 RVA: 0x001D4C7C File Offset: 0x001D2E7C
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

	// Token: 0x04003D13 RID: 15635
	private GenericLayout<HandbookRewardItem, int> RewardLayout;

	// Token: 0x04003D14 RID: 15636
	private UUIItem ProgressBarItem;

	// Token: 0x04003D15 RID: 15637
	private int CurrentValue;

	// Token: 0x04003D16 RID: 15638
	private int MaxValue;

	// Token: 0x04003D17 RID: 15639
	private List<int> RewardIdList = new List<int>();

	// Token: 0x04003D18 RID: 15640
	private int CurrentFinishedRewardCount;

	// Token: 0x04003D19 RID: 15641
	private float MaxProgressWidth;

	// Token: 0x04003D1A RID: 15642
	private readonly float RewardWidth = 120f;

	// Token: 0x04003D1B RID: 15643
	private float LineWidth;

	// Token: 0x04003D1C RID: 15644
	private int TotalRewardCount;

	// Token: 0x020079A4 RID: 31140
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040280DF RID: 164063
		public const int ProgressPanel = 0;

		// Token: 0x040280E0 RID: 164064
		public const int BarPanel = 1;

		// Token: 0x040280E1 RID: 164065
		public const int BarSprite = 2;

		// Token: 0x040280E2 RID: 164066
		public const int RewardPanel = 3;

		// Token: 0x040280E3 RID: 164067
		public const int RewardItem = 4;

		// Token: 0x040280E4 RID: 164068
		public const int PanelBackground = 5;

		// Token: 0x040280E5 RID: 164069
		public const int BackgroundSprite = 6;
	}
}
