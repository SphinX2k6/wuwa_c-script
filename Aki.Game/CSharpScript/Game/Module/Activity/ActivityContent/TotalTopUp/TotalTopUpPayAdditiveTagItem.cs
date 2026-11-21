using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA6 RID: 20390
	public class TotalTopUpPayAdditiveTagItem : UiPanelBase
	{
		// Token: 0x060331B0 RID: 209328 RVA: 0x00E531F4 File Offset: 0x00E513F4
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

		// Token: 0x060331B1 RID: 209329 RVA: 0x00E53260 File Offset: 0x00E51460
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

		// Token: 0x060331B2 RID: 209330 RVA: 0x00E532A4 File Offset: 0x00E514A4
		public void RefreshByGoodsId(int goodsId)
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			if (instance == null)
			{
				return;
			}
			int goodsScore = instance.GetGoodsScore(goodsId);
			if (goodsScore <= 0)
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
			text.SetText(goodsScore.ToString(), true);
		}

		// Token: 0x0200ACA2 RID: 44194
		private enum ENode
		{
			// Token: 0x04035669 RID: 218729
			Text,
			// Token: 0x0403566A RID: 218730
			TextureIcon
		}
	}
}
