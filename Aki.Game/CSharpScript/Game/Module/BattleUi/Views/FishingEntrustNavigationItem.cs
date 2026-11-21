using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D4A RID: 19786
	public class FishingEntrustNavigationItem : UiPanelBase
	{
		// Token: 0x06031AC4 RID: 203460 RVA: 0x00DE47F8 File Offset: 0x00DE29F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			ref ValueTuple<int, Delegate> ptr = ref span2[num];
			int item = 0;
			Action item2;
			if ((item2 = FishingEntrustNavigationItem.<>O.<0>__OnViewButtonClick) == null)
			{
				item2 = (FishingEntrustNavigationItem.<>O.<0>__OnViewButtonClick = new Action(FishingEntrustNavigationItem.OnViewButtonClick));
			}
			ptr = new ValueTuple<int, Delegate>(item, item2);
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AC5 RID: 203461 RVA: 0x00DE488C File Offset: 0x00DE2A8C
		private static void OnViewButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
		}

		// Token: 0x0200AA20 RID: 43552
		private enum EViewComponent
		{
			// Token: 0x04034942 RID: 215362
			ViewButton
		}

		// Token: 0x0200AA21 RID: 43553
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034943 RID: 215363
			public static Action <0>__OnViewButtonClick;
		}
	}
}
