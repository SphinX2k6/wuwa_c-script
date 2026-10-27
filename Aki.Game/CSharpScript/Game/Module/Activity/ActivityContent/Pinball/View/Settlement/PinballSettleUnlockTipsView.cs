using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062FB RID: 25339
	public class PinballSettleUnlockTipsView : UiPanelBase
	{
		// Token: 0x0603FC49 RID: 261193 RVA: 0x00F6E018 File Offset: 0x00F6C218
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

		// Token: 0x0603FC4A RID: 261194 RVA: 0x00F6E060 File Offset: 0x00F6C260
		[NullableContext(1)]
		public void ShowTxt(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0200C4F5 RID: 50421
		private enum EComponent
		{
			// Token: 0x0403B708 RID: 243464
			TextTips
		}
	}
}
