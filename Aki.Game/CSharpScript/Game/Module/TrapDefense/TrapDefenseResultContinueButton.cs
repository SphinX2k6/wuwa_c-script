using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A49 RID: 14921
	public class TrapDefenseResultContinueButton : UiPanelBase
	{
		// Token: 0x060265C8 RID: 157128 RVA: 0x00ABEAE4 File Offset: 0x00ABCCE4
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060265C9 RID: 157129 RVA: 0x00ABEBAB File Offset: 0x00ABCDAB
		[NullableContext(1)]
		public void ShowText(string key)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), key, Array.Empty<object>());
		}

		// Token: 0x060265CA RID: 157130 RVA: 0x00ABEBC4 File Offset: 0x00ABCDC4
		private void OnClickedBtn()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb();
			}
		}

		// Token: 0x040150CA RID: 86218
		[Nullable(1)]
		public Action OnClickCb;

		// Token: 0x02009619 RID: 38425
		private class EContinueBtn
		{
			// Token: 0x0402EDCD RID: 191949
			public const int Btn = 0;

			// Token: 0x0402EDCE RID: 191950
			public const int Txt = 1;

			// Token: 0x0402EDCF RID: 191951
			public const int RedDot = 2;
		}
	}
}
