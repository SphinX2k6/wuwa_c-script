using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200574B RID: 22347
	public class DangoBrawlCardRefreshBtn : UiPanelBase
	{
		// Token: 0x060371A0 RID: 225696 RVA: 0x00F60B60 File Offset: 0x00F5ED60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRefresh));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060371A1 RID: 225697 RVA: 0x00F60C27 File Offset: 0x00F5EE27
		[NullableContext(1)]
		public void SetRefreshCallback(Action callback)
		{
			this.RefreshCallback = callback;
		}

		// Token: 0x060371A2 RID: 225698 RVA: 0x00F60C30 File Offset: 0x00F5EE30
		public void RefreshRemain(int remainNum)
		{
			bool flag = remainNum <= 0;
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(!flag);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			base.GetText(1).SetText(remainNum.ToString(), true);
		}

		// Token: 0x060371A3 RID: 225699 RVA: 0x00F60C85 File Offset: 0x00F5EE85
		private void OnClickRefresh()
		{
			Action refreshCallback = this.RefreshCallback;
			if (refreshCallback == null)
			{
				return;
			}
			refreshCallback();
		}

		// Token: 0x060371A4 RID: 225700 RVA: 0x00F60C97 File Offset: 0x00F5EE97
		public void SetInteractive(bool bInteractive)
		{
			base.GetButton(0).SetSelfInteractive(bInteractive);
		}

		// Token: 0x0401D21A RID: 119322
		[Nullable(2)]
		private Action RefreshCallback;

		// Token: 0x0200B336 RID: 45878
		private enum EComponents
		{
			// Token: 0x0403760B RID: 226827
			RefreshBtn,
			// Token: 0x0403760C RID: 226828
			TxtNum,
			// Token: 0x0403760D RID: 226829
			PnlNum
		}
	}
}
