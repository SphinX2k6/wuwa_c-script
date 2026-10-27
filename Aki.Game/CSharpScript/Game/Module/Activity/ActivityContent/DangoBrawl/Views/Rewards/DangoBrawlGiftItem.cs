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
	// Token: 0x02006848 RID: 26696
	[NullableContext(1)]
	[Nullable(0)]
	internal class DangoBrawlGiftItem : GridProxyAbstract<int>
	{
		// Token: 0x17009757 RID: 38743
		// (get) Token: 0x06042A3B RID: 272955 RVA: 0x0103425A File Offset: 0x0103245A
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x06042A3C RID: 272956 RVA: 0x0103426C File Offset: 0x0103246C
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

		// Token: 0x06042A3D RID: 272957 RVA: 0x010342F8 File Offset: 0x010324F8
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x06042A3E RID: 272958 RVA: 0x01034368 File Offset: 0x01032568
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

		// Token: 0x06042A3F RID: 272959 RVA: 0x0103442C File Offset: 0x0103262C
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

		// Token: 0x06042A40 RID: 272960 RVA: 0x010344F8 File Offset: 0x010326F8
		private void OnClickedGrid(MediumItemGridExtendCallback cb)
		{
			DangoBrawlScoreReward value = DangoBrawlConfig.Instance.GetScoreRewardConfigById(this.ConfigId).Value;
			if (this.OutGameData.IsScoreRewardCanReceived(value.Id))
			{
				ActivityDangoBrawlController.Instance.RequestDangoBrawlScoreReward(this.ReceiveCallback);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null);
		}

		// Token: 0x04022B49 RID: 142153
		private int ConfigId;

		// Token: 0x04022B4A RID: 142154
		[Nullable(2)]
		private SmallItemGrid ItemGridGrid;

		// Token: 0x04022B4B RID: 142155
		private TItem? ItemGrid;

		// Token: 0x04022B4C RID: 142156
		[Nullable(2)]
		public Action ReceiveCallback;

		// Token: 0x0200CA0F RID: 51727
		[NullableContext(0)]
		private enum EGift
		{
			// Token: 0x0403D102 RID: 250114
			SpriteBackground,
			// Token: 0x0403D103 RID: 250115
			TextNum,
			// Token: 0x0403D104 RID: 250116
			ItemGrid
		}
	}
}
