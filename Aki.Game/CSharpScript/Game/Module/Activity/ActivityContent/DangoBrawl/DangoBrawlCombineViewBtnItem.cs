using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067EF RID: 26607
	internal class DangoBrawlCombineViewBtnItem : UiPanelBase
	{
		// Token: 0x060424C2 RID: 271554 RVA: 0x01018884 File Offset: 0x01016A84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCombine));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060424C3 RID: 271555 RVA: 0x0101896C File Offset: 0x01016B6C
		public void SetLock(bool isLock)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isLock);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!isLock);
		}

		// Token: 0x060424C4 RID: 271556 RVA: 0x01018996 File Offset: 0x01016B96
		private void OnClickCombine()
		{
			Action onClickOperationCombine = this.OnClickOperationCombine;
			if (onClickOperationCombine == null)
			{
				return;
			}
			onClickOperationCombine();
		}

		// Token: 0x04022969 RID: 141673
		[Nullable(2)]
		public Action OnClickOperationCombine;

		// Token: 0x0200C92F RID: 51503
		private enum EBtnComponents
		{
			// Token: 0x0403CBD0 RID: 248784
			BtnItem,
			// Token: 0x0403CBD1 RID: 248785
			PnlNormal,
			// Token: 0x0403CBD2 RID: 248786
			PnlLock,
			// Token: 0x0403CBD3 RID: 248787
			TxtBtnName
		}
	}
}
