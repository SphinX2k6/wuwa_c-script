using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004706 RID: 18182
	public class KurotatoSettleTipInfoItem : UiPanelBase
	{
		// Token: 0x0602DAE3 RID: 187107 RVA: 0x00CC5D5C File Offset: 0x00CC3F5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DAE4 RID: 187108 RVA: 0x00CC5DC5 File Offset: 0x00CC3FC5
		[NullableContext(1)]
		public void Refresh(string tipsText, string valueText)
		{
			base.GetText(0).ShowTextNew(tipsText);
			base.GetText(1).SetText(valueText, true);
		}

		// Token: 0x0200A319 RID: 41753
		private class EComps
		{
			// Token: 0x0403292F RID: 207151
			public const int TextTips = 0;

			// Token: 0x04032930 RID: 207152
			public const int TextValue = 1;
		}
	}
}
