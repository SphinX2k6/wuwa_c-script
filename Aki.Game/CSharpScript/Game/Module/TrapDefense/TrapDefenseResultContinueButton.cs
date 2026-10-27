using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AA1 RID: 19105
	public class TrapDefenseResultContinueButton : UiPanelBase
	{
		// Token: 0x06031838 RID: 202808 RVA: 0x00B7AB30 File Offset: 0x00B78D30
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

		// Token: 0x06031839 RID: 202809 RVA: 0x00B7ABF7 File Offset: 0x00B78DF7
		[NullableContext(1)]
		public void ShowText(string key)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), key, Array.Empty<object>());
		}

		// Token: 0x0603183A RID: 202810 RVA: 0x00B7AC10 File Offset: 0x00B78E10
		private void OnClickedBtn()
		{
			if (this.OnClickCb != null)
			{
				this.OnClickCb();
			}
		}

		// Token: 0x0401A778 RID: 108408
		[Nullable(1)]
		public Action OnClickCb;

		// Token: 0x0200ABF9 RID: 44025
		private class EContinueBtn
		{
			// Token: 0x0403441C RID: 214044
			public const int Btn = 0;

			// Token: 0x0403441D RID: 214045
			public const int Txt = 1;

			// Token: 0x0403441E RID: 214046
			public const int RedDot = 2;
		}
	}
}
