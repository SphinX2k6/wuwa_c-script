using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000811 RID: 2065
public class RewardGrandItem : UiPanelBase
{
	// Token: 0x06005DB4 RID: 23988 RVA: 0x001E104C File Offset: 0x001DF24C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickButton))
		};
	}

	// Token: 0x06005DB5 RID: 23989 RVA: 0x001E1138 File Offset: 0x001DF338
	[NullableContext(1)]
	public void Refresh(TaskData data)
	{
		this.Data = data;
		List<TItem> rewardList = this.Data.RewardList;
		if (rewardList.Count == 0)
		{
			return;
		}
		this.RewardItemId = rewardList[0].ItemData.ItemId;
		base.SetItemIcon(base.GetTexture(4), this.RewardItemId, null, null);
		int count = rewardList[0].Count;
		base.GetText(0).SetText("x" + count.ToString(), true);
		base.GetSprite(3).SetFillAmount(MathUtils.Instance.Clamp((float)this.Data.Current / (float)this.Data.Target, 0f, 1f));
		string textStringId = "Moonfiesta_BigRewardState1";
		if (this.Data.IsTaken)
		{
			textStringId = "Moonfiesta_BigRewardState3";
		}
		else if (this.Data.IsFinished)
		{
			textStringId = "Moonfiesta_BigRewardState2";
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(this.Data.Target));
		base.GetItem(5).SetUIActive(this.Data.IsTaken);
		base.GetItem(6).SetUIActive(this.Data.IsFinished);
		base.GetItem(7).SetUIActive(this.Data.IsFinished);
	}

	// Token: 0x06005DB6 RID: 23990 RVA: 0x001E1294 File Offset: 0x001DF494
	private void OnClickButton()
	{
		if (this.Data == null)
		{
			return;
		}
		if (!this.Data.IsFinished)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItemId, true, null, false);
			return;
		}
		TaskReceive receiveDelegate = this.Data.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.Data.TaskId);
	}

	// Token: 0x04003E2E RID: 15918
	[Nullable(1)]
	private TaskData Data;

	// Token: 0x04003E2F RID: 15919
	private int RewardItemId;

	// Token: 0x02006B49 RID: 27465
	private class EComponentDefine
	{
		// Token: 0x04023477 RID: 144503
		public const int Count = 0;

		// Token: 0x04023478 RID: 144504
		public const int Content = 1;

		// Token: 0x04023479 RID: 144505
		public const int ItemButton = 2;

		// Token: 0x0402347A RID: 144506
		public const int SpriteBar = 3;

		// Token: 0x0402347B RID: 144507
		public const int Icon = 4;

		// Token: 0x0402347C RID: 144508
		public const int SpriteDone = 5;

		// Token: 0x0402347D RID: 144509
		public const int RedDot = 6;

		// Token: 0x0402347E RID: 144510
		public const int SpriteCanReceive = 7;
	}
}
