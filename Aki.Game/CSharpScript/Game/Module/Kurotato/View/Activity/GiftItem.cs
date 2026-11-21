using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200475E RID: 18270
	internal class GiftItem : GridProxyAbstract<int>
	{
		// Token: 0x0602DDBA RID: 187834 RVA: 0x00CD5CF0 File Offset: 0x00CD3EF0
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

		// Token: 0x0602DDBB RID: 187835 RVA: 0x00CD5D7C File Offset: 0x00CD3F7C
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x0602DDBC RID: 187836 RVA: 0x00CD5DEC File Offset: 0x00CD3FEC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ConfigId = data;
			KurotatoScoreAward value = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(data).Value;
			base.GetText(1).SetText(value.Score.ToString(), true);
			bool uiactive = KurotatoActivityController.Instance.GetActivityData().GetCurrentMilestone() >= value.Score;
			base.GetSprite(0).SetUIActive(uiactive);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
			this.ItemGrid = new TItem?(dropPackagePreviewItemList[0]);
			this.RefreshGrid(value);
		}

		// Token: 0x0602DDBD RID: 187837 RVA: 0x00CD5E88 File Offset: 0x00CD4088
		private void RefreshGrid(KurotatoScoreAward config)
		{
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
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

		// Token: 0x0602DDBE RID: 187838 RVA: 0x00CD5F54 File Offset: 0x00CD4154
		[NullableContext(1)]
		private void OnClickedGrid(MediumItemGridExtendCallback cb)
		{
			KurotatoScoreAward value = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(this.ConfigId).Value;
			if (KurotatoActivityController.Instance.GetActivityData().IsScoreRewardCanReceived(value.Id))
			{
				KurotatoActivityController.Instance.RequestScoreRewardReceive(this.ReceiveCallback);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null, false);
		}

		// Token: 0x040187FC RID: 100348
		private int ConfigId;

		// Token: 0x040187FD RID: 100349
		[Nullable(2)]
		private SmallItemGrid ItemGridGrid;

		// Token: 0x040187FE RID: 100350
		private TItem? ItemGrid;

		// Token: 0x040187FF RID: 100351
		[Nullable(2)]
		public Action ReceiveCallback;

		// Token: 0x0200A3C0 RID: 41920
		private enum EGift
		{
			// Token: 0x04032C20 RID: 207904
			SpriteBackground,
			// Token: 0x04032C21 RID: 207905
			TextNum,
			// Token: 0x04032C22 RID: 207906
			ItemGrid
		}
	}
}
