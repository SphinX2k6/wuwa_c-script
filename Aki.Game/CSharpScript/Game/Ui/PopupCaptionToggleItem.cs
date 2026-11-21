using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003581 RID: 13697
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupCaptionToggleItem : UiPanelBase
	{
		// Token: 0x06022EC7 RID: 143047 RVA: 0x009E9A10 File Offset: 0x009E7C10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022EC8 RID: 143048 RVA: 0x009E9AB6 File Offset: 0x009E7CB6
		private void OnClickToggle(EToggleState state)
		{
			Action<EToggleState> onClickToggleCallback = this.OnClickToggleCallback;
			if (onClickToggleCallback == null)
			{
				return;
			}
			onClickToggleCallback(state);
		}

		// Token: 0x06022EC9 RID: 143049 RVA: 0x009E9AC9 File Offset: 0x009E7CC9
		public void SetClickToggleCallback(Action<EToggleState> callback)
		{
			this.OnClickToggleCallback = callback;
		}

		// Token: 0x06022ECA RID: 143050 RVA: 0x009E9AD2 File Offset: 0x009E7CD2
		public void SetNameText(string name)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
		}

		// Token: 0x06022ECB RID: 143051 RVA: 0x009E9AEB File Offset: 0x009E7CEB
		public EToggleState GetToggleState()
		{
			return base.GetExtendToggle(0).ToggleState;
		}

		// Token: 0x06022ECC RID: 143052 RVA: 0x009E9AF9 File Offset: 0x009E7CF9
		public void InitToggleState(EToggleState toggleState)
		{
			base.GetExtendToggle(0).SetToggleState(toggleState, false, false, true);
		}

		// Token: 0x04013488 RID: 78984
		protected Action<EToggleState> OnClickToggleCallback;

		// Token: 0x02009271 RID: 37489
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD50 RID: 187728
			public const int Toggle = 0;

			// Token: 0x0402DD51 RID: 187729
			public const int Name = 1;
		}
	}
}
