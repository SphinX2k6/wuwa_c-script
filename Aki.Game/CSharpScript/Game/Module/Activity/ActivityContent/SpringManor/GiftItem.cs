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
	// Token: 0x0200606B RID: 24683
	[NullableContext(2)]
	[Nullable(0)]
	public class GiftItem : GridProxyAbstract<int>
	{
		// Token: 0x0603E6E1 RID: 255713 RVA: 0x00F14DB4 File Offset: 0x00F12FB4
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

		// Token: 0x0603E6E2 RID: 255714 RVA: 0x00F14E40 File Offset: 0x00F13040
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x0603E6E3 RID: 255715 RVA: 0x00F14EB0 File Offset: 0x00F130B0
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

		// Token: 0x0603E6E4 RID: 255716 RVA: 0x00F14F60 File Offset: 0x00F13160
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

		// Token: 0x0603E6E5 RID: 255717 RVA: 0x00F1502C File Offset: 0x00F1322C
		[NullableContext(1)]
		private void OnClickedGrid(MediumItemGridExtendCallback _)
		{
			SpringFestivalScoreReward? scoreRewardConfigById = SpringManorConfig.Instance.GetScoreRewardConfigById(this.ConfigId);
			if (!SpringManorModel.Instance.ActivityData.IsScoreRewardCanReceived(scoreRewardConfigById.Value.Id))
			{
				ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null);
				return;
			}
			SpringManorController instance = SpringManorController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RequestScoreRewardReceive(this.ReceiveCallback);
		}

		// Token: 0x04020A24 RID: 133668
		private int ConfigId;

		// Token: 0x04020A25 RID: 133669
		private SmallItemGrid ItemGridGrid;

		// Token: 0x04020A26 RID: 133670
		private TItem? ItemGrid;

		// Token: 0x04020A27 RID: 133671
		public Action ReceiveCallback;
	}
}
