using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B52 RID: 23378
	public class MediumItemGridRoundCountComponent : MediumItemGridComponent
	{
		// Token: 0x0603B372 RID: 242546 RVA: 0x00E1EBE4 File Offset: 0x00E1CDE4
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemGridRound";
		}

		// Token: 0x0603B373 RID: 242547 RVA: 0x00E1EBEC File Offset: 0x00E1CDEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B374 RID: 242548 RVA: 0x00E1EC58 File Offset: 0x00E1CE58
		[NullableContext(2)]
		protected override void OnRefresh(object data)
		{
			if (data is int)
			{
				int num = (int)data;
				UUISprite sprite = base.GetSprite(0);
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = num == 0;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				this.SetRound(num);
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0603B375 RID: 242549 RVA: 0x00E1ECAC File Offset: 0x00E1CEAC
		public void SetRound(int round)
		{
			base.GetText(1).SetText(round.ToString(), true);
		}

		// Token: 0x0200BD7C RID: 48508
		private enum EComponents
		{
			// Token: 0x0403928D RID: 234125
			SpriteBg,
			// Token: 0x0403928E RID: 234126
			TxtRound
		}
	}
}
