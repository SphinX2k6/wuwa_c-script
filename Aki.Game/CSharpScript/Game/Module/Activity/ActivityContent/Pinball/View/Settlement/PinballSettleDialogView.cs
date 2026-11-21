using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x0200526D RID: 21101
	public class PinballSettleDialogView : UiPanelBase
	{
		// Token: 0x06034882 RID: 215170 RVA: 0x00EB2CF4 File Offset: 0x00EB0EF4
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

		// Token: 0x06034883 RID: 215171 RVA: 0x00EB2D3C File Offset: 0x00EB0F3C
		[NullableContext(1)]
		public void ShowTxt(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200AECC RID: 44748
		private enum EComponent
		{
			// Token: 0x04036013 RID: 221203
			TextDialog
		}
	}
}
