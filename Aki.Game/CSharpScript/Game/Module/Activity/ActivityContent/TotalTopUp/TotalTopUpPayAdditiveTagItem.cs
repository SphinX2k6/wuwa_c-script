using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBF RID: 24511
	public class TotalTopUpPayAdditiveTagItem : UiPanelBase
	{
		// Token: 0x0603E216 RID: 254486 RVA: 0x00F01538 File Offset: 0x00EFF738
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

		// Token: 0x0603E217 RID: 254487 RVA: 0x00F015A4 File Offset: 0x00EFF7A4
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

		// Token: 0x0603E218 RID: 254488 RVA: 0x00F015E8 File Offset: 0x00EFF7E8
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

		// Token: 0x0200C297 RID: 49815
		private enum ENode
		{
			// Token: 0x0403AC8D RID: 240781
			Text,
			// Token: 0x0403AC8E RID: 240782
			TextureIcon
		}
	}
}
