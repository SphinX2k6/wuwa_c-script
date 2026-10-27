using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065BD RID: 26045
	public class DockyardShopGridItem : PayShopItem
	{
		// Token: 0x0604154D RID: 267597 RVA: 0x00FD4F09 File Offset: 0x00FD3109
		protected override void OnStart()
		{
			base.OnStart();
			base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
			base.SetRedDotState(false);
		}

		// Token: 0x0604154E RID: 267598 RVA: 0x00FD4F2C File Offset: 0x00FD312C
		[NullableContext(2)]
		public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
		{
			PayShopGoods payShopGoods = data as PayShopGoods;
			if (payShopGoods == null)
			{
				return;
			}
			base.Refresh(payShopGoods, isSelected, gridIndex);
			base.SetNewFlagState(payShopGoods.GetIfNeedRemind());
		}

		// Token: 0x0604154F RID: 267599 RVA: 0x00FD4F59 File Offset: 0x00FD3159
		[NullableContext(1)]
		private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
		{
			base.SetNewFlagState(data.GetIfNeedRemind());
		}
	}
}
