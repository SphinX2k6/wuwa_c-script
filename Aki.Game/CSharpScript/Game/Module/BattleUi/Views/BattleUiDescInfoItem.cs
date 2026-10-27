using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D95 RID: 23957
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BattleUiDescInfoItem : GridProxyAbstract<IBattleUiHoverTipsDescInfoC>
	{
		// Token: 0x0603CCC9 RID: 249033 RVA: 0x00E994C8 File Offset: 0x00E976C8
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

		// Token: 0x0603CCCA RID: 249034 RVA: 0x00E99534 File Offset: 0x00E97734
		[NullableContext(1)]
		public override void Refresh(IBattleUiHoverTipsDescInfoC data, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, data.DescKey, Array.Empty<object>());
			if (text2 != null)
			{
				text2.SetUIActive(!string.IsNullOrEmpty(data.TitleKey));
			}
			if (!string.IsNullOrEmpty(data.TitleKey))
			{
				LguiUtil.Instance.SetLocalTextNew(text2, data.TitleKey, Array.Empty<object>());
			}
		}

		// Token: 0x0200C054 RID: 49236
		private enum EDescChildType
		{
			// Token: 0x0403A0A1 RID: 237729
			TxtTitle,
			// Token: 0x0403A0A2 RID: 237730
			TxtDesc
		}
	}
}
