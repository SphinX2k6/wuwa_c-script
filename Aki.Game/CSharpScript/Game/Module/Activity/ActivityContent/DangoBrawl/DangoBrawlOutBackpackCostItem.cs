using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005777 RID: 22391
	public class DangoBrawlOutBackpackCostItem : UiPanelBase
	{
		// Token: 0x060373FA RID: 226298 RVA: 0x00F6CF24 File Offset: 0x00F6B124
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

		// Token: 0x060373FB RID: 226299 RVA: 0x00F6CF90 File Offset: 0x00F6B190
		[NullableContext(1)]
		public void SetCostIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x060373FC RID: 226300 RVA: 0x00F6CFB6 File Offset: 0x00F6B1B6
		public void SetCostNum(int costNum)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(costNum.ToString(), true);
		}

		// Token: 0x0200B39B RID: 45979
		private enum EComponents
		{
			// Token: 0x04037868 RID: 227432
			SprCost,
			// Token: 0x04037869 RID: 227433
			TextCost
		}
	}
}
