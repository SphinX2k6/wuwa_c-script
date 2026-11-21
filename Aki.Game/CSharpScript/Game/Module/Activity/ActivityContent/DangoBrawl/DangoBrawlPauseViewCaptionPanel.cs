using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200577F RID: 22399
	internal class DangoBrawlPauseViewCaptionPanel : UiPanelBase
	{
		// Token: 0x06037454 RID: 226388 RVA: 0x00F6E9D0 File Offset: 0x00F6CBD0
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

		// Token: 0x06037455 RID: 226389 RVA: 0x00F6EA55 File Offset: 0x00F6CC55
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
