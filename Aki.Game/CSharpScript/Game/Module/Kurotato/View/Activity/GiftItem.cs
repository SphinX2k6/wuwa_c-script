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
	// Token: 0x02005787 RID: 22407
	internal class GiftItem : GridProxyAbstract<int>
	{
		// Token: 0x06038EAA RID: 233130 RVA: 0x00D86F98 File Offset: 0x00D85198
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

		// Token: 0x06038EAB RID: 233131 RVA: 0x00D87024 File Offset: 0x00D85224
		protected override void OnStart()
		{
			this.ItemGridGrid = new SmallItemGrid();
			this.ItemGridGrid.Initialize(base.GetItem(2).GetOwner());
			this.ItemGridGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			this.ItemGridGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
		}

		// Token: 0x06038EAC RID: 233132 RVA: 0x00D87094 File Offset: 0x00D85294
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

		// Token: 0x06038EAD RID: 233133 RVA: 0x00D87130 File Offset: 0x00D85330
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

		// Token: 0x06038EAE RID: 233134 RVA: 0x00D871FC File Offset: 0x00D853FC
		[NullableContext(1)]
		private void OnClickedGrid(MediumItemGridExtendCallback cb)
		{
			KurotatoScoreAward value = KurotatoConfig.Instance.GetKurotatoScoreAwardConfigById(this.ConfigId).Value;
			if (KurotatoActivityController.Instance.GetActivityData().IsScoreRewardCanReceived(value.Id))
			{
				KurotatoActivityController.Instance.RequestScoreRewardReceive(this.ReceiveCallback);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGrid.Value.ItemData.ItemId, true, null);
		}

		// Token: 0x0401DD66 RID: 122214
		private int ConfigId;

		// Token: 0x0401DD67 RID: 122215
		[Nullable(2)]
		private SmallItemGrid ItemGridGrid;

		// Token: 0x0401DD68 RID: 122216
		private TItem? ItemGrid;

		// Token: 0x0401DD69 RID: 122217
		[Nullable(2)]
		public Action ReceiveCallback;

		// Token: 0x0200B9AA RID: 47530
		private enum EGift
		{
			// Token: 0x04038230 RID: 229936
			SpriteBackground,
			// Token: 0x04038231 RID: 229937
			TextNum,
			// Token: 0x04038232 RID: 229938
			ItemGrid
		}
	}
}
