using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A90 RID: 2704
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerSeasonScoreItem : GridProxyAbstract<IWheelTowerSeasonScoreData>
{
	// Token: 0x06007219 RID: 29209 RVA: 0x0023157C File Offset: 0x0022F77C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600721A RID: 29210 RVA: 0x00231608 File Offset: 0x0022F808
	protected override void OnStart()
	{
		this.RewardItemGrid = new SmallItemGrid();
		this.RewardItemGrid.Initialize(base.GetItem(0).GetOwner());
		this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.RewardItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnClickedGrid();
		});
	}

	// Token: 0x0600721B RID: 29211 RVA: 0x00231678 File Offset: 0x0022F878
	[NullableContext(1)]
	public override void Refresh(IWheelTowerSeasonScoreData data, bool isSelected, int gridIndex)
	{
		this.DataInternal = data;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(data.Score.ToString(), true);
		}
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(data.DropId);
		if (dropPackagePreviewItemList.Count <= 0)
		{
			return;
		}
		this.RewardItem = new TItem?(dropPackagePreviewItemList[0]);
		this.RefreshGrid();
		this.RefreshProgress();
	}

	// Token: 0x0600721C RID: 29212 RVA: 0x002316E8 File Offset: 0x0022F8E8
	private void RefreshProgress()
	{
		if (this.DataInternal == null)
		{
			return;
		}
		int num = this.DataInternal.Score - this.DataInternal.PrevScore;
		if (num <= 0)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount((this.DataInternal.CurScore >= this.DataInternal.Score) ? 1f : 0f);
			return;
		}
		else
		{
			float fillAmount = MathF.Min(MathF.Max((float)(this.DataInternal.CurScore - this.DataInternal.PrevScore), 0f) / (float)num, 1f);
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetFillAmount(fillAmount);
			return;
		}
	}

	// Token: 0x0600721D RID: 29213 RVA: 0x00231794 File Offset: 0x0022F994
	private void RefreshGrid()
	{
		if (this.DataInternal == null || this.RewardItem == null || this.RewardItemGrid == null)
		{
			return;
		}
		bool lockBlackBigVisible = this.DataInternal.Score > this.DataInternal.CurScore;
		bool flag = this.DataInternal.Score <= this.DataInternal.CurScore;
		bool isReceived = this.DataInternal.IsReceived;
		this.RewardItemGrid.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = this.DataInternal,
			ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
			BottomText = this.RewardItem.Value.Count.ToString(),
			IsReceivableVisible = new bool?(flag && !isReceived),
			IsReceivedVisible = new bool?(isReceived),
			IsRedDotVisible = new bool?(flag && !isReceived)
		});
		this.RewardItemGrid.SetLockBlackBigVisible(lockBlackBigVisible);
	}

	// Token: 0x0600721E RID: 29214 RVA: 0x0023189C File Offset: 0x0022FA9C
	private void OnClickedGrid()
	{
		if (this.DataInternal == null || this.RewardItem == null)
		{
			return;
		}
		bool flag = this.DataInternal.Score > this.DataInternal.CurScore;
		bool flag2 = this.DataInternal.Score <= this.DataInternal.CurScore;
		bool isReceived = this.DataInternal.IsReceived;
		int motorPreviewId = this.DataInternal.MotorPreviewId;
		if (!isReceived && !flag)
		{
			if (flag2)
			{
				Action onClickToGet = this.OnClickToGet;
				if (onClickToGet == null)
				{
					return;
				}
				onClickToGet();
			}
			return;
		}
		if (motorPreviewId > 0)
		{
			MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(motorPreviewId);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
	}

	// Token: 0x0400470D RID: 18189
	private IWheelTowerSeasonScoreData DataInternal;

	// Token: 0x0400470E RID: 18190
	private SmallItemGrid RewardItemGrid;

	// Token: 0x0400470F RID: 18191
	private TItem? RewardItem;

	// Token: 0x04004710 RID: 18192
	public Action OnClickToGet;
}
