using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004650 RID: 18000
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupCaptionToggleItem : UiPanelBase
	{
		// Token: 0x0602E77D RID: 190333 RVA: 0x00ABC3E0 File Offset: 0x00ABA5E0
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

		// Token: 0x0602E77E RID: 190334 RVA: 0x00ABC486 File Offset: 0x00ABA686
		private void OnClickToggle(EToggleState state)
		{
			Action<EToggleState> onClickToggleCallback = this.OnClickToggleCallback;
			if (onClickToggleCallback == null)
			{
				return;
			}
			onClickToggleCallback(state);
		}

		// Token: 0x0602E77F RID: 190335 RVA: 0x00ABC499 File Offset: 0x00ABA699
		public void SetClickToggleCallback(Action<EToggleState> callback)
		{
			this.OnClickToggleCallback = callback;
		}

		// Token: 0x0602E780 RID: 190336 RVA: 0x00ABC4A2 File Offset: 0x00ABA6A2
		public void SetNameText(string name)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
		}

		// Token: 0x0602E781 RID: 190337 RVA: 0x00ABC4BB File Offset: 0x00ABA6BB
		public EToggleState GetToggleState()
		{
			return base.GetExtendToggle(0).ToggleState;
		}

		// Token: 0x0602E782 RID: 190338 RVA: 0x00ABC4C9 File Offset: 0x00ABA6C9
		public void InitToggleState(EToggleState toggleState)
		{
			base.GetExtendToggle(0).SetToggleState(toggleState, false, false, true);
		}

		// Token: 0x04018E2F RID: 101935
		protected Action<EToggleState> OnClickToggleCallback;

		// Token: 0x0200A8B5 RID: 43189
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040335BA RID: 210362
			public const int Toggle = 0;

			// Token: 0x040335BB RID: 210363
			public const int Name = 1;
		}
	}
}
