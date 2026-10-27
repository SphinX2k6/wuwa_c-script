using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067FB RID: 26619
	public class DangoBrawlCardRefreshBtn : UiPanelBase
	{
		// Token: 0x0604264B RID: 271947 RVA: 0x0101F61C File Offset: 0x0101D81C
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

		// Token: 0x0604264C RID: 271948 RVA: 0x0101F6E3 File Offset: 0x0101D8E3
		[NullableContext(1)]
		public void SetRefreshCallback(Action callback)
		{
			this.RefreshCallback = callback;
		}

		// Token: 0x0604264D RID: 271949 RVA: 0x0101F6EC File Offset: 0x0101D8EC
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

		// Token: 0x0604264E RID: 271950 RVA: 0x0101F741 File Offset: 0x0101D941
		private void OnClickRefresh()
		{
			Action refreshCallback = this.RefreshCallback;
			if (refreshCallback == null)
			{
				return;
			}
			refreshCallback();
		}

		// Token: 0x0604264F RID: 271951 RVA: 0x0101F753 File Offset: 0x0101D953
		public void SetInteractive(bool bInteractive)
		{
			base.GetButton(0).SetSelfInteractive(bInteractive);
		}

		// Token: 0x040229BD RID: 141757
		[Nullable(2)]
		private Action RefreshCallback;

		// Token: 0x0200C969 RID: 51561
		private enum EComponents
		{
			// Token: 0x0403CD1E RID: 249118
			RefreshBtn,
			// Token: 0x0403CD1F RID: 249119
			TxtNum,
			// Token: 0x0403CD20 RID: 249120
			PnlNum
		}
	}
}
