using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062EF RID: 25327
	public class PinballSettleDialogView : UiPanelBase
	{
		// Token: 0x0603FBC1 RID: 261057 RVA: 0x00F6BD98 File Offset: 0x00F69F98
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

		// Token: 0x0603FBC2 RID: 261058 RVA: 0x00F6BDE0 File Offset: 0x00F69FE0
		[NullableContext(1)]
		public void ShowTxt(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200C4E5 RID: 50405
		private enum EComponent
		{
			// Token: 0x0403B6B1 RID: 243377
			TextDialog
		}
	}
}
