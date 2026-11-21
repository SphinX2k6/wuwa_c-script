using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E06 RID: 19974
	public class SpecialEnergyBarNumItem : UiPanelBase
	{
		// Token: 0x06032425 RID: 205861 RVA: 0x00E1672C File Offset: 0x00E1492C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032426 RID: 205862 RVA: 0x00E16774 File Offset: 0x00E14974
		public void SetNum(int num)
		{
			if (this.Num == num)
			{
				return;
			}
			this.Num = num;
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x0401AA1F RID: 109087
		private int Num = -1;

		// Token: 0x0200ABAE RID: 43950
		private enum EChildType
		{
			// Token: 0x04035216 RID: 217622
			NumText
		}
	}
}
