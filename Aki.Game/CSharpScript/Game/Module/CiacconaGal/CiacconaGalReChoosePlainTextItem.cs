using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBA RID: 19386
	public class CiacconaGalReChoosePlainTextItem : UiPanelBase
	{
		// Token: 0x06030667 RID: 198247 RVA: 0x00D7CFE4 File Offset: 0x00D7B1E4
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

		// Token: 0x06030668 RID: 198248 RVA: 0x00D7D02C File Offset: 0x00D7B22C
		[NullableContext(1)]
		public void Refresh(string text)
		{
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), text, Array.Empty<object>());
		}

		// Token: 0x0200A7C3 RID: 42947
		public class EPlainTextComponentDefine
		{
			// Token: 0x04033D34 RID: 212276
			public const int Text = 0;
		}
	}
}
