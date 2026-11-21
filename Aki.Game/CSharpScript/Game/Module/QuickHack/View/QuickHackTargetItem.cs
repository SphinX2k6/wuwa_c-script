using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F5D RID: 16221
	public class QuickHackTargetItem : UiPanelBase
	{
		// Token: 0x06029123 RID: 168227 RVA: 0x00B88F98 File Offset: 0x00B87198
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06029124 RID: 168228 RVA: 0x00B88FE0 File Offset: 0x00B871E0
		[NullableContext(1)]
		public void RefreshTitle(string title)
		{
			base.GetText(3).SetText(title, true);
		}

		// Token: 0x02009AD8 RID: 39640
		private class ETargetItemComponentType
		{
			// Token: 0x0403043A RID: 197690
			public const int TitleText = 3;
		}
	}
}
