using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x0200526E RID: 21102
	public class PinballSettleFailTipsView : UiPanelBase
	{
		// Token: 0x06034885 RID: 215173 RVA: 0x00EB2D60 File Offset: 0x00EB0F60
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

		// Token: 0x06034886 RID: 215174 RVA: 0x00EB2DA8 File Offset: 0x00EB0FA8
		[NullableContext(1)]
		public void ShowTxt(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200AECD RID: 44749
		private enum EComponent
		{
			// Token: 0x04036015 RID: 221205
			TextTips
		}
	}
}
