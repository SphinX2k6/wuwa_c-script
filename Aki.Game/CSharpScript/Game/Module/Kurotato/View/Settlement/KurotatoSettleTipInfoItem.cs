using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572F RID: 22319
	public class KurotatoSettleTipInfoItem : UiPanelBase
	{
		// Token: 0x06038BD3 RID: 232403 RVA: 0x00D776B0 File Offset: 0x00D758B0
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

		// Token: 0x06038BD4 RID: 232404 RVA: 0x00D77719 File Offset: 0x00D75919
		[NullableContext(1)]
		public void Refresh(string tipsText, string valueText)
		{
			base.GetText(0).ShowTextNew(tipsText);
			base.GetText(1).SetText(valueText, true);
		}

		// Token: 0x0200B8F8 RID: 47352
		private class EComps
		{
			// Token: 0x04037F1F RID: 229151
			public const int TextTips = 0;

			// Token: 0x04037F20 RID: 229152
			public const int TextValue = 1;
		}
	}
}
