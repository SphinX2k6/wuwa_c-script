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

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FE9 RID: 20457
	[NullableContext(2)]
	[Nullable(0)]
	public class GiftItem : GridProxyAbstract<int>
	{
		// Token: 0x060333A5 RID: 209829 RVA: 0x00E5BB78 File Offset: 0x00E59D78
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

		// Token: 0x060333A6 RID: 209830 RVA: 0x00E5BC04 File Offset: 0x00E59E04
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x060333A7 RID: 209831 RVA: 0x00E5BC74 File Offset: 0x00E59E74
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ConfigId = data;
			SpringFestivalScoreReward? scoreRewardConfigById = SpringManorConfig.Instance.GetScoreRewardConfigById(data);
			base.GetText(1).SetText(scoreRewardConfigById.Value.Score.ToString(), true);
			bool uiactive = SpringManorModel.Instance.ActivityData.GetCurrentMilestone() >= scoreRewardConfigById.Value.Score;
			base.GetSprite(0).SetUIActive(uiactive);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(scoreRewardConfigById.Value.DropId);
			this.ItemGrid = new TItem?(dropPackagePreviewItemList[0]);
			this.RefreshGrid(scoreRewardConfigById.Value);
		}

		// Token: 0x060333A8 RID: 209832 RVA: 0x00E5BD24 File Offset: 0x00E59F24
		private void RefreshGrid(SpringFestivalScoreReward config)
		{
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			bool flag = activityData.IsScoreRewardCanReceived(config.Id);
			bool flag2 = activityData.IsScoreRewardReceived(config.Id);
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

		// Token: 0x060333A9 RID: 209833 RVA: 0x00E5BDF0 File Offset: 0x00E59FF0
		[NullableContext(1)]
		private void OnClickedGrid(MediumItemGridExtendCallback _)
		{
			SpringFestivalScoreReward? scoreRewardConfigById = SpringManorConfig.Instance.GetScoreRewardConfigById(this.ConfigId);
			if (!SpringManorModel.Instance.ActivityData.IsScoreRewardCanReceived(scoreRewardConfigById.Value.Id))
			{
				ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null, false);
				return;
			}
			SpringManorController instance = SpringManorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RequestScoreRewardReceive(this.ReceiveCallback);
		}

		// Token: 0x0401B351 RID: 111441
		private int ConfigId;

		// Token: 0x0401B352 RID: 111442
		private SmallItemGrid ItemGridGrid;

		// Token: 0x0401B353 RID: 111443
		private TItem? ItemGrid;

		// Token: 0x0401B354 RID: 111444
		public Action ReceiveCallback;
	}
}
