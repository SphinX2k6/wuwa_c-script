using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C3A RID: 23610
	public class FlagChallengePauseButton : UiPanelBase
	{
		// Token: 0x0603BA74 RID: 244340 RVA: 0x00E3C3FC File Offset: 0x00E3A5FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603BA75 RID: 244341 RVA: 0x00E3C4A2 File Offset: 0x00E3A6A2
		private void OnClicked()
		{
			Action clickCb = this.ClickCb;
			if (clickCb == null)
			{
				return;
			}
			clickCb();
		}

		// Token: 0x0401F0E1 RID: 127201
		[Nullable(2)]
		public Action ClickCb;

		// Token: 0x0200BE30 RID: 48688
		private enum EPauseButtonType
		{
			// Token: 0x040395A4 RID: 234916
			Panel,
			// Token: 0x040395A5 RID: 234917
			Button
		}
	}
}
