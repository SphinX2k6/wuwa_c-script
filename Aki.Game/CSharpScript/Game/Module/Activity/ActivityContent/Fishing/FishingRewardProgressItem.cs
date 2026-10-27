using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006586 RID: 25990
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingRewardProgressItem : GridProxyAbstract<FishingRewardProgressData>
	{
		// Token: 0x0604122E RID: 266798 RVA: 0x00FC910C File Offset: 0x00FC730C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604122F RID: 266799 RVA: 0x00FC9198 File Offset: 0x00FC7398
		protected override void OnStart()
		{
			this.RewardItemGrid = new SmallItemGrid();
			this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
			this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x06041230 RID: 266800 RVA: 0x00FC9208 File Offset: 0x00FC7408
		public override void Refresh(FishingRewardProgressData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			FishingActivityMilestone? fishingActivityMilestone = FishingConfig.Instance.GetFishingActivityMilestone(data.Id);
			base.GetText(1).SetText(fishingActivityMilestone.Value.ItemNum.ToString(), true);
			UUIItem sprite = base.GetSprite(0);
			bool bUseChangeColor = data.IsFulfilled();
			FColor? fcolor = new FColor?(base.GetSprite(0).changeColor);
			sprite.SetChangeColor(bUseChangeColor, fcolor);
			this.RewardItem = new TItem?(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(fishingActivityMilestone.Value.DropId)[0]);
			this.RefreshGrid();
		}

		// Token: 0x06041231 RID: 266801 RVA: 0x00FC92A8 File Offset: 0x00FC74A8
		private void RefreshGrid()
		{
			bool lockBlackVisible = !this.Data.IsFulfilled();
			bool value = this.Data.IsDone();
			bool value2 = this.Data.IsReceivable();
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = this.Data,
				ItemConfigId = new int?(this.RewardItem.Value.ItemData.ItemId),
				BottomText = this.RewardItem.Value.Count.ToString(),
				IsReceivableVisible = new bool?(value2),
				IsReceivedVisible = new bool?(value),
				IsRedDotVisible = new bool?(value2)
			};
			this.RewardItemGrid.Apply<PropSmallItemGrid>(parameters);
			this.RewardItemGrid.SetLockBlackVisible(lockBlackVisible);
		}

		// Token: 0x06041232 RID: 266802 RVA: 0x00FC936C File Offset: 0x00FC756C
		private void OnClickedGrid(MediumItemGridExtendCallback callback)
		{
			if (!this.Data.IsReceivable())
			{
				ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null);
				return;
			}
			Action onClickToGet = this.OnClickToGet;
			if (onClickToGet == null)
			{
				return;
			}
			onClickToGet();
		}

		// Token: 0x04021EEB RID: 138987
		private FishingRewardProgressData Data;

		// Token: 0x04021EEC RID: 138988
		[Nullable(2)]
		private SmallItemGrid RewardItemGrid;

		// Token: 0x04021EED RID: 138989
		private TItem? RewardItem;

		// Token: 0x04021EEE RID: 138990
		[Nullable(2)]
		public Action OnClickToGet;

		// Token: 0x0200C77D RID: 51069
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x0403C457 RID: 246871
			public const int SpriteBg = 0;

			// Token: 0x0403C458 RID: 246872
			public const int TxtGoal = 1;

			// Token: 0x0403C459 RID: 246873
			public const int RewardItem = 2;
		}
	}
}
