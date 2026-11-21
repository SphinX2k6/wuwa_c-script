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

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Rewards
{
	// Token: 0x02005798 RID: 22424
	[NullableContext(1)]
	[Nullable(0)]
	internal class DangoBrawlGiftItem : GridProxyAbstract<int>
	{
		// Token: 0x17006A98 RID: 27288
		// (get) Token: 0x06037590 RID: 226704 RVA: 0x00F7577E File Offset: 0x00F7397E
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x06037591 RID: 226705 RVA: 0x00F75790 File Offset: 0x00F73990
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

		// Token: 0x06037592 RID: 226706 RVA: 0x00F7581C File Offset: 0x00F73A1C
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x06037593 RID: 226707 RVA: 0x00F7588C File Offset: 0x00F73A8C
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ConfigId = data;
			DangoBrawlScoreReward value = DangoBrawlConfig.Instance.GetScoreRewardConfigById(data).Value;
			UUISprite sprite = base.GetSprite(0);
			UUIText text = base.GetText(1);
			bool flag = this.OutGameData.GetCurrentMilestone() >= value.Score;
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text.SetText(value.Score.ToString(), true);
			UUIItem uuiitem2 = text;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(text.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
			this.ItemGrid = new TItem?(dropPackagePreviewItemList[0]);
			this.RefreshGrid(value);
		}

		// Token: 0x06037594 RID: 226708 RVA: 0x00F75950 File Offset: 0x00F73B50
		private void RefreshGrid(DangoBrawlScoreReward config)
		{
			bool flag = this.OutGameData.IsScoreRewardCanReceived(config.Id);
			bool flag2 = this.OutGameData.IsScoreRewardReceived(config.Id);
			bool lockBlackVisible = !flag && !flag2;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = config,
				ItemConfigId = new int?(this.ItemGrid.Value.ItemData.ItemId),
				BottomText = this.ItemGrid.Value.Count.ToString(),
				IsReceivableVisible = new bool?(flag),
				IsReceivedVisible = new bool?(flag2),
				IsRedDotVisible = new bool?(flag)
			};
			this.ItemGridGrid.Apply<PropSmallItemGrid>(parameters);
			this.ItemGridGrid.SetLockBlackVisible(lockBlackVisible);
		}

		// Token: 0x06037595 RID: 226709 RVA: 0x00F75A1C File Offset: 0x00F73C1C
		private void OnClickedGrid(MediumItemGridExtendCallback cb)
		{
			DangoBrawlScoreReward value = DangoBrawlConfig.Instance.GetScoreRewardConfigById(this.ConfigId).Value;
			if (this.OutGameData.IsScoreRewardCanReceived(value.Id))
			{
				ActivityDangoBrawlController.Instance.RequestDangoBrawlScoreReward(this.ReceiveCallback);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null, false);
		}

		// Token: 0x0401D3A6 RID: 119718
		private int ConfigId;

		// Token: 0x0401D3A7 RID: 119719
		[Nullable(2)]
		private SmallItemGrid ItemGridGrid;

		// Token: 0x0401D3A8 RID: 119720
		private TItem? ItemGrid;

		// Token: 0x0401D3A9 RID: 119721
		[Nullable(2)]
		public Action ReceiveCallback;

		// Token: 0x0200B3DA RID: 46042
		[NullableContext(0)]
		private enum EGift
		{
			// Token: 0x040379E9 RID: 227817
			SpriteBackground,
			// Token: 0x040379EA RID: 227818
			TextNum,
			// Token: 0x040379EB RID: 227819
			ItemGrid
		}
	}
}
