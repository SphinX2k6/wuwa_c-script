using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200573F RID: 22335
	internal class DangoBrawlCombineViewBtnItem : UiPanelBase
	{
		// Token: 0x06037017 RID: 225303 RVA: 0x00F59D14 File Offset: 0x00F57F14
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

		// Token: 0x06037018 RID: 225304 RVA: 0x00F59DFC File Offset: 0x00F57FFC
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

		// Token: 0x06037019 RID: 225305 RVA: 0x00F59E26 File Offset: 0x00F58026
		private void OnClickCombine()
		{
			Action onClickOperationCombine = this.OnClickOperationCombine;
			if (onClickOperationCombine == null)
			{
				return;
			}
			onClickOperationCombine();
		}

		// Token: 0x0401D1C6 RID: 119238
		[Nullable(2)]
		public Action OnClickOperationCombine;

		// Token: 0x0200B2FC RID: 45820
		private enum EBtnComponents
		{
			// Token: 0x040374C0 RID: 226496
			BtnItem,
			// Token: 0x040374C1 RID: 226497
			PnlNormal,
			// Token: 0x040374C2 RID: 226498
			PnlLock,
			// Token: 0x040374C3 RID: 226499
			TxtBtnName
		}
	}
}
