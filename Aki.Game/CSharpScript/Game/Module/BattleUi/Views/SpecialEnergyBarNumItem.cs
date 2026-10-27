using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E21 RID: 24097
	public class SpecialEnergyBarNumItem : UiPanelBase
	{
		// Token: 0x0603D496 RID: 251030 RVA: 0x00EC51CC File Offset: 0x00EC33CC
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

		// Token: 0x0603D497 RID: 251031 RVA: 0x00EC5214 File Offset: 0x00EC3414
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

		// Token: 0x0401FF58 RID: 130904
		private int Num = -1;

		// Token: 0x0200C19F RID: 49567
		private enum EChildType
		{
			// Token: 0x0403A824 RID: 239652
			NumText
		}
	}
}
