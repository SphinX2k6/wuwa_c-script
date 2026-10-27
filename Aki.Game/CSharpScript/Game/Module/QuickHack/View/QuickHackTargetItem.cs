using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F94 RID: 20372
	public class QuickHackTargetItem : UiPanelBase
	{
		// Token: 0x060342B5 RID: 213685 RVA: 0x00C3F7EC File Offset: 0x00C3D9EC
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

		// Token: 0x060342B6 RID: 213686 RVA: 0x00C3F834 File Offset: 0x00C3DA34
		[NullableContext(1)]
		public void RefreshTitle(string title)
		{
			base.GetText(3).SetText(title, true);
		}

		// Token: 0x0200B0A8 RID: 45224
		private class ETargetItemComponentType
		{
			// Token: 0x04035A0F RID: 219663
			public const int TitleText = 3;
		}
	}
}
