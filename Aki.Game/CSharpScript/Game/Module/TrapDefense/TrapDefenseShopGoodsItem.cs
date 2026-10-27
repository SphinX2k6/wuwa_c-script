using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ACF RID: 19151
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseShopGoodsItem : LoopScrollMediumItemGrid<ITrapDefenseShopGoods>
	{
		// Token: 0x060319B8 RID: 203192 RVA: 0x00B8168E File Offset: 0x00B7F88E
		protected override void OnStart()
		{
			base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
			TrapDefenseModel.Instance.ViewModelShop.AddOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x060319B9 RID: 203193 RVA: 0x00B816BD File Offset: 0x00B7F8BD
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x060319BA RID: 203194 RVA: 0x00B816DA File Offset: 0x00B7F8DA
		protected override void OnRefresh(ITrapDefenseShopGoods data, bool isSelected, int gridIndex)
		{
			this.GoodsData = data;
			base.Apply<PropMediumItemGrid>(data.GetItemGridParam());
		}

		// Token: 0x060319BB RID: 203195 RVA: 0x00B816F4 File Offset: 0x00B7F8F4
		private void OnClickedGrid(MediumItemGridExtendCallback _)
		{
			if (this.GoodsData == null)
			{
				return;
			}
			if (this.IsSelected)
			{
				return;
			}
			TrapDefenseModel.Instance.ViewModelShop.SelectGoods(this.GoodsData);
		}

		// Token: 0x060319BC RID: 203196 RVA: 0x00B81720 File Offset: 0x00B7F920
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
			if (state == EToggleState.ETT_UnChecked && this.IsSelected)
			{
				itemGridExtendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			if (state == EToggleState.ETT_Checked && !this.IsSelected)
			{
				TrapDefenseModel.Instance.ViewModelShop.SelectGoods(this.GoodsData);
			}
		}

		// Token: 0x060319BD RID: 203197 RVA: 0x00B8176C File Offset: 0x00B7F96C
		private void OnSelectGoods(ITrapDefenseShopGoods goods)
		{
			UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
			if (goods == this.GoodsData && itemGridExtendToggle.GetToggleState() != EToggleState.ETT_Checked)
			{
				this.IsSelected = true;
				itemGridExtendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			if (goods != this.GoodsData && itemGridExtendToggle.GetToggleState() != EToggleState.ETT_UnChecked)
			{
				this.IsSelected = false;
				itemGridExtendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0401A808 RID: 108552
		private ITrapDefenseShopGoods GoodsData;
	}
}
