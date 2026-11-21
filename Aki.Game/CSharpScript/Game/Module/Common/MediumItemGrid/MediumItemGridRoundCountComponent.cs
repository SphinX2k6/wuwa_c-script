using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B31 RID: 19249
	public class MediumItemGridRoundCountComponent : MediumItemGridComponent
	{
		// Token: 0x060302BE RID: 197310 RVA: 0x00D6F150 File Offset: 0x00D6D350
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemGridRound";
		}

		// Token: 0x060302BF RID: 197311 RVA: 0x00D6F158 File Offset: 0x00D6D358
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

		// Token: 0x060302C0 RID: 197312 RVA: 0x00D6F1C4 File Offset: 0x00D6D3C4
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

		// Token: 0x060302C1 RID: 197313 RVA: 0x00D6F218 File Offset: 0x00D6D418
		public void SetRound(int round)
		{
			base.GetText(1).SetText(round.ToString(), true);
		}

		// Token: 0x0200A786 RID: 42886
		private enum EComponents
		{
			// Token: 0x04033C5B RID: 212059
			SpriteBg,
			// Token: 0x04033C5C RID: 212060
			TxtRound
		}
	}
}
