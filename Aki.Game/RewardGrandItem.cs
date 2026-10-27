using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200135D RID: 4957
public class RewardGrandItem : UiPanelBase
{
	// Token: 0x06008A19 RID: 35353 RVA: 0x001D81F0 File Offset: 0x001D63F0
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

	// Token: 0x06008A1A RID: 35354 RVA: 0x001D82DC File Offset: 0x001D64DC
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

	// Token: 0x06008A1B RID: 35355 RVA: 0x001D8438 File Offset: 0x001D6638
	private void OnClickButton()
	{
		if (this.Data == null)
		{
			return;
		}
		if (!this.Data.IsFinished)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.RewardItemId, true, null);
			return;
		}
		TaskReceive receiveDelegate = this.Data.ReceiveDelegate;
		if (receiveDelegate == null)
		{
			return;
		}
		receiveDelegate(this.Data.TaskId);
	}

	// Token: 0x04003D96 RID: 15766
	[Nullable(1)]
	private TaskData Data;

	// Token: 0x04003D97 RID: 15767
	private int RewardItemId;

	// Token: 0x020079BF RID: 31167
	private class EComponentDefine
	{
		// Token: 0x0402814A RID: 164170
		public const int Count = 0;

		// Token: 0x0402814B RID: 164171
		public const int Content = 1;

		// Token: 0x0402814C RID: 164172
		public const int ItemButton = 2;

		// Token: 0x0402814D RID: 164173
		public const int SpriteBar = 3;

		// Token: 0x0402814E RID: 164174
		public const int Icon = 4;

		// Token: 0x0402814F RID: 164175
		public const int SpriteDone = 5;

		// Token: 0x04028150 RID: 164176
		public const int RedDot = 6;

		// Token: 0x04028151 RID: 164177
		public const int SpriteCanReceive = 7;
	}
}
