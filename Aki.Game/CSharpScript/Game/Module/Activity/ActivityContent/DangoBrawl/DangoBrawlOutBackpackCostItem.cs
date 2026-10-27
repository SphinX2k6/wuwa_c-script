using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006827 RID: 26663
	public class DangoBrawlOutBackpackCostItem : UiPanelBase
	{
		// Token: 0x060428A6 RID: 272550 RVA: 0x0102B9E8 File Offset: 0x01029BE8
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

		// Token: 0x060428A7 RID: 272551 RVA: 0x0102BA54 File Offset: 0x01029C54
		[NullableContext(1)]
		public void SetCostIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x060428A8 RID: 272552 RVA: 0x0102BA7A File Offset: 0x01029C7A
		public void SetCostNum(int costNum)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(costNum.ToString(), true);
		}

		// Token: 0x0200C9CF RID: 51663
		private enum EComponents
		{
			// Token: 0x0403CF7E RID: 249726
			SprCost,
			// Token: 0x0403CF7F RID: 249727
			TextCost
		}
	}
}
