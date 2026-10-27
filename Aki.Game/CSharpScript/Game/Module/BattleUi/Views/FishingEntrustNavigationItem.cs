using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D68 RID: 23912
	public class FishingEntrustNavigationItem : UiPanelBase
	{
		// Token: 0x0603CB68 RID: 248680 RVA: 0x00E93FB0 File Offset: 0x00E921B0
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

		// Token: 0x0603CB69 RID: 248681 RVA: 0x00E94044 File Offset: 0x00E92244
		private static void OnViewButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
		}

		// Token: 0x0200C01A RID: 49178
		private enum EViewComponent
		{
			// Token: 0x04039F7F RID: 237439
			ViewButton
		}

		// Token: 0x0200C01B RID: 49179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039F80 RID: 237440
			public static Action <0>__OnViewButtonClick;
		}
	}
}
