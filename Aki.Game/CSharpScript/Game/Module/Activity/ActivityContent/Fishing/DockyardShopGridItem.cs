using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200553B RID: 21819
	public class DockyardShopGridItem : PayShopItem
	{
		// Token: 0x06036212 RID: 221714 RVA: 0x00F1BF45 File Offset: 0x00F1A145
		protected override void OnStart()
		{
			base.OnStart();
			base.SetExtraFunction(new Action<PayShopItem, PayShopGoods>(this.ClearNewFlagState));
			base.SetRedDotState(false);
		}

		// Token: 0x06036213 RID: 221715 RVA: 0x00F1BF68 File Offset: 0x00F1A168
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

		// Token: 0x06036214 RID: 221716 RVA: 0x00F1BF95 File Offset: 0x00F1A195
		[NullableContext(1)]
		private void ClearNewFlagState(PayShopItem item, PayShopGoods data)
		{
			base.SetNewFlagState(data.GetIfNeedRemind());
		}
	}
}
