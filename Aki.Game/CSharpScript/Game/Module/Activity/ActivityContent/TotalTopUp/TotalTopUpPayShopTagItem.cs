using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FC0 RID: 24512
	public class TotalTopUpPayShopTagItem : PayShopExtraTagItem
	{
		// Token: 0x0603E21A RID: 254490 RVA: 0x00F01640 File Offset: 0x00EFF840
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E21B RID: 254491 RVA: 0x00F016AC File Offset: 0x00EFF8AC
		protected override void OnStart()
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			string text = (instance != null) ? instance.GetCurrentScoreIconPath() : null;
			if (!string.IsNullOrEmpty(text))
			{
				UUITexture texture = base.GetTexture(1);
				base.SetTextureByPath(text, texture, null, null);
			}
		}

		// Token: 0x0603E21C RID: 254492 RVA: 0x00F016F0 File Offset: 0x00EFF8F0
		[NullableContext(1)]
		public override void Refresh(IPayShopUnionData data)
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			if (instance == null)
			{
				return;
			}
			int num = 0;
			PayShopGoods payShopGoods = data as PayShopGoods;
			if (payShopGoods != null)
			{
				num = instance.GetGoodsScore(payShopGoods.GetGoodsId());
			}
			else
			{
				PayItemData payItemData = data as PayItemData;
				if (payItemData != null)
				{
					num = instance.GetRechargeItemScore(payItemData.PayItemId);
				}
			}
			if (num <= 0)
			{
				base.SetUiActive(false);
				return;
			}
			base.SetUiActive(true);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x0200C298 RID: 49816
		private class ENode
		{
			// Token: 0x0403AC8F RID: 240783
			public const int Text = 0;

			// Token: 0x0403AC90 RID: 240784
			public const int TextureIcon = 1;
		}
	}
}
