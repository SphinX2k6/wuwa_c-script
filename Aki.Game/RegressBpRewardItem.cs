using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001485 RID: 5253
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RegressBpRewardItem : GridProxyAbstract<ActivityRegressTaskScoreRewardGridData>
{
	// Token: 0x060094B3 RID: 38067 RVA: 0x002006B4 File Offset: 0x001FE8B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060094B4 RID: 38068 RVA: 0x00200724 File Offset: 0x001FE924
	protected override void OnStart()
	{
		SmallItemGrid smallItemGrid = new SmallItemGrid();
		SmallItemGrid smallItemGrid2 = new SmallItemGrid();
		SmallItemGrid smallItemGrid3 = new SmallItemGrid();
		smallItemGrid.Initialize(base.GetItem(1).GetOwner());
		smallItemGrid2.Initialize(base.GetItem(2).GetOwner());
		smallItemGrid3.Initialize(base.GetItem(3).GetOwner());
		this.ItemGrids = new List<SmallItemGrid>
		{
			smallItemGrid,
			smallItemGrid2,
			smallItemGrid3
		};
		for (int i = 0; i < this.ItemGrids.Count; i++)
		{
			int idx = i;
			this.ItemGrids[idx].BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGrids[idx].BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
			{
				this.OnExtendToggleClicked(idx);
			});
		}
	}

	// Token: 0x060094B5 RID: 38069 RVA: 0x00200824 File Offset: 0x001FEA24
	private void OnExtendToggleClicked(int index)
	{
		IRegressRewardItemInfo regressRewardItemInfo = (this.RewardDataList.Count > index) ? this.RewardDataList[index] : default(IRegressRewardItemInfo);
		if (regressRewardItemInfo.ItemInfo == null)
		{
			return;
		}
		if (regressRewardItemInfo.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
			return;
		}
		int id = regressRewardItemInfo.ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null);
	}

	// Token: 0x060094B6 RID: 38070 RVA: 0x002008A4 File Offset: 0x001FEAA4
	public override void Refresh(ActivityRegressTaskScoreRewardGridData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText((gridIndex + 1).ToString(), true);
		}
		int drop = data.Config.Value.Drop;
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(drop);
		List<IRegressRewardItemInfo> list = new List<IRegressRewardItemInfo>();
		if (dropPackage != null && dropPackage.Value.DropPreviewLength > 0)
		{
			DropPackage value = dropPackage.Value;
			for (int i = 0; i < value.DropPreviewLength; i++)
			{
				DicIntInt? dicIntInt = value.DropPreview(i);
				if (dicIntInt != null)
				{
					int key = dicIntInt.Value.Key;
					int value2 = dicIntInt.Value.Value;
					ItemInfo? config = ItemConfig.Instance.GetConfig(key);
					if (config != null)
					{
						list.Add(new IRegressRewardItemInfo
						{
							ItemInfo = new ItemInfo?(config.Value),
							ItemCount = value2,
							RewardState = data.RewardState
						});
						break;
					}
				}
			}
		}
		int payDrop = data.Config.Value.PayDrop;
		dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(payDrop);
		if (dropPackage != null && dropPackage.Value.DropPreviewLength > 0)
		{
			DropPackage value3 = dropPackage.Value;
			for (int j = 0; j < value3.DropPreviewLength; j++)
			{
				DicIntInt? dicIntInt2 = value3.DropPreview(j);
				if (dicIntInt2 != null)
				{
					int key2 = dicIntInt2.Value.Key;
					int value4 = dicIntInt2.Value.Value;
					ItemInfo? config2 = ItemConfig.Instance.GetConfig(key2);
					if (config2 != null)
					{
						list.Add(new IRegressRewardItemInfo
						{
							ItemInfo = new ItemInfo?(config2.Value),
							ItemCount = value4,
							RewardState = data.PayRewardState
						});
					}
				}
			}
		}
		for (int k = 0; k < this.ItemGrids.Count; k++)
		{
			if (list.Count > k)
			{
				ActivityRegressHelper.RefreshItemGridByData(this.ItemGrids[k], list[k]);
				this.ItemGrids[k].SetUiActive(true);
			}
			else
			{
				this.ItemGrids[k].SetUiActive(false);
			}
		}
		this.RewardDataList = list;
	}

	// Token: 0x040041E1 RID: 16865
	private List<IRegressRewardItemInfo> RewardDataList = new List<IRegressRewardItemInfo>();

	// Token: 0x040041E2 RID: 16866
	private List<SmallItemGrid> ItemGrids = new List<SmallItemGrid>();
}
