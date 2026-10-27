using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C21 RID: 23585
	public class BossPilingBuffCountItem : UiPanelBase
	{
		// Token: 0x0603B964 RID: 244068 RVA: 0x00E3633C File Offset: 0x00E3453C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B965 RID: 244069 RVA: 0x00E36384 File Offset: 0x00E34584
		public void Refresh(int count)
		{
			base.SetUiActive(count >= 2);
			if (count < 2)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200BE0B RID: 48651
		private enum ECount
		{
			// Token: 0x040394E0 RID: 234720
			Txt
		}
	}
}
