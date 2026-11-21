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
	// Token: 0x02005504 RID: 21764
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FishingRewardProgressItem : GridProxyAbstract<FishingRewardProgressData>
	{
		// Token: 0x06035EF3 RID: 220915 RVA: 0x00F100C0 File Offset: 0x00F0E2C0
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

		// Token: 0x06035EF4 RID: 220916 RVA: 0x00F1014C File Offset: 0x00F0E34C
		protected override void OnStart()
		{
			this.RewardItemGrid = new SmallItemGrid();
			this.RewardItemGrid.Initialize(base.GetItem(2).GetOwner());
			this.RewardItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.RewardItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x06035EF5 RID: 220917 RVA: 0x00F101BC File Offset: 0x00F0E3BC
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

		// Token: 0x06035EF6 RID: 220918 RVA: 0x00F1025C File Offset: 0x00F0E45C
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

		// Token: 0x06035EF7 RID: 220919 RVA: 0x00F10320 File Offset: 0x00F0E520
		private void OnClickedGrid(MediumItemGridExtendCallback callback)
		{
			if (!this.Data.IsReceivable())
			{
				ItemController.Instance.OpenItemTipsByItemId(this.RewardItem.Value.ItemData.ItemId, true, null, false);
				return;
			}
			Action onClickToGet = this.OnClickToGet;
			if (onClickToGet == null)
			{
				return;
			}
			onClickToGet();
		}

		// Token: 0x0401C81C RID: 116764
		private FishingRewardProgressData Data;

		// Token: 0x0401C81D RID: 116765
		[Nullable(2)]
		private SmallItemGrid RewardItemGrid;

		// Token: 0x0401C81E RID: 116766
		private TItem? RewardItem;

		// Token: 0x0401C81F RID: 116767
		[Nullable(2)]
		public Action OnClickToGet;

		// Token: 0x0200B162 RID: 45410
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x04036DA8 RID: 224680
			public const int SpriteBg = 0;

			// Token: 0x04036DA9 RID: 224681
			public const int TxtGoal = 1;

			// Token: 0x04036DAA RID: 224682
			public const int RewardItem = 2;
		}
	}
}
