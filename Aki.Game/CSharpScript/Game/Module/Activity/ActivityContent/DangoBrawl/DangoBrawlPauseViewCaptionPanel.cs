using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200682F RID: 26671
	internal class DangoBrawlPauseViewCaptionPanel : UiPanelBase
	{
		// Token: 0x06042900 RID: 272640 RVA: 0x0102D494 File Offset: 0x0102B694
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBackButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06042901 RID: 272641 RVA: 0x0102D519 File Offset: 0x0102B719
		private void OnBackButtonClick()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.DangoBrawlPauseView))
			{
				UiManager.Instance.CloseView(EUiViewName.DangoBrawlPauseView, null);
				DangoBrawlModel.Instance.ApplyPlayRate();
			}
		}
	}
}
