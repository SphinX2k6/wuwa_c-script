using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D77 RID: 19831
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BattleUiDescInfoItem : GridProxyAbstract<IBattleUiHoverTipsDescInfoC>
	{
		// Token: 0x06031C26 RID: 203814 RVA: 0x00DE9D80 File Offset: 0x00DE7F80
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

		// Token: 0x06031C27 RID: 203815 RVA: 0x00DE9DEC File Offset: 0x00DE7FEC
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

		// Token: 0x0200AA5A RID: 43610
		private enum EDescChildType
		{
			// Token: 0x04034A64 RID: 215652
			TxtTitle,
			// Token: 0x04034A65 RID: 215653
			TxtDesc
		}
	}
}
