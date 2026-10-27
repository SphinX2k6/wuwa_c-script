using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F0 RID: 25328
	public class PinballSettleFailTipsView : UiPanelBase
	{
		// Token: 0x0603FBC4 RID: 261060 RVA: 0x00F6BE04 File Offset: 0x00F6A004
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

		// Token: 0x0603FBC5 RID: 261061 RVA: 0x00F6BE4C File Offset: 0x00F6A04C
		[NullableContext(1)]
		public void ShowTxt(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200C4E6 RID: 50406
		private enum EComponent
		{
			// Token: 0x0403B6B3 RID: 243379
			TextTips
		}
	}
}
