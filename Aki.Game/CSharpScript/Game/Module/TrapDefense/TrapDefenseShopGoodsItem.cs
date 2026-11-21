using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A77 RID: 14967
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseShopGoodsItem : LoopScrollMediumItemGrid<ITrapDefenseShopGoods>
	{
		// Token: 0x06026748 RID: 157512 RVA: 0x00AC5642 File Offset: 0x00AC3842
		protected override void OnStart()
		{
			base.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedGrid));
			TrapDefenseModel.Instance.ViewModelShop.AddOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x06026749 RID: 157513 RVA: 0x00AC5671 File Offset: 0x00AC3871
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
		}

		// Token: 0x0602674A RID: 157514 RVA: 0x00AC568E File Offset: 0x00AC388E
		protected override void OnRefresh(ITrapDefenseShopGoods data, bool isSelected, int gridIndex)
		{
			this.GoodsData = data;
			base.Apply<PropMediumItemGrid>(data.GetItemGridParam());
		}

		// Token: 0x0602674B RID: 157515 RVA: 0x00AC56A8 File Offset: 0x00AC38A8
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

		// Token: 0x0602674C RID: 157516 RVA: 0x00AC56D4 File Offset: 0x00AC38D4
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

		// Token: 0x0602674D RID: 157517 RVA: 0x00AC5720 File Offset: 0x00AC3920
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

		// Token: 0x0401515A RID: 86362
		private ITrapDefenseShopGoods GoodsData;
	}
}
