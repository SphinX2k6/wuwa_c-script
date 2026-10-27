using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006356 RID: 25430
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemGridReduceBtnComponent : PinballItemGridComponentBase
	{
		// Token: 0x0603FFEB RID: 262123 RVA: 0x00F7B594 File Offset: 0x00F79794
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedReduceButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FFEC RID: 262124 RVA: 0x00F7B61C File Offset: 0x00F7981C
		protected override void OnStart()
		{
			this.LongPressButton = new LongPressButtonItem(null, null, null);
			this.LongPressButton.Initialize(base.GetButton(0), new Action<bool>(this.OnLongPressActive), null, null, null);
		}

		// Token: 0x0603FFED RID: 262125 RVA: 0x00F7B66D File Offset: 0x00F7986D
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseChoose";
		}

		// Token: 0x0603FFEE RID: 262126 RVA: 0x00F7B674 File Offset: 0x00F79874
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}

		// Token: 0x0603FFEF RID: 262127 RVA: 0x00F7B691 File Offset: 0x00F79891
		private void OnLongPressActive(bool isShortPress)
		{
			if (this.OnLongPressClickCallback != null)
			{
				this.OnLongPressClickCallback(isShortPress);
			}
		}

		// Token: 0x0603FFF0 RID: 262128 RVA: 0x00F7B6A7 File Offset: 0x00F798A7
		public void BindReduceButtonCallback(Action onClickedReduceButton)
		{
			this.OnClickedCallback = onClickedReduceButton;
		}

		// Token: 0x0603FFF1 RID: 262129 RVA: 0x00F7B6B0 File Offset: 0x00F798B0
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedCallback = null;
		}

		// Token: 0x0603FFF2 RID: 262130 RVA: 0x00F7B6B9 File Offset: 0x00F798B9
		private void OnClickedReduceButton()
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback();
			}
		}

		// Token: 0x0603FFF3 RID: 262131 RVA: 0x00F7B6CE File Offset: 0x00F798CE
		public void BindLongPressCallback(Action<bool> callback)
		{
			this.OnLongPressClickCallback = callback;
		}

		// Token: 0x0603FFF4 RID: 262132 RVA: 0x00F7B6D7 File Offset: 0x00F798D7
		public void UnBindLongPressCallback()
		{
			this.OnLongPressClickCallback = null;
			this.LongPressButton.Deactivate();
		}

		// Token: 0x040215D3 RID: 136659
		[Nullable(2)]
		private Action OnClickedCallback;

		// Token: 0x040215D4 RID: 136660
		[Nullable(2)]
		private LongPressButtonItem LongPressButton;

		// Token: 0x040215D5 RID: 136661
		[Nullable(2)]
		private Action<bool> OnLongPressClickCallback;

		// Token: 0x0200C576 RID: 50550
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B9A2 RID: 244130
			ReduceButton
		}
	}
}
