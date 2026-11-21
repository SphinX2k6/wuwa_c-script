using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D4 RID: 21204
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballItemGridReduceBtnComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CAC RID: 216236 RVA: 0x00EC24F4 File Offset: 0x00EC06F4
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

		// Token: 0x06034CAD RID: 216237 RVA: 0x00EC257C File Offset: 0x00EC077C
		protected override void OnStart()
		{
			this.LongPressButton = new LongPressButtonItem(null, null, null);
			this.LongPressButton.Initialize(base.GetButton(0), new Action<bool>(this.OnLongPressActive), null, null, null);
		}

		// Token: 0x06034CAE RID: 216238 RVA: 0x00EC25CD File Offset: 0x00EC07CD
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseChoose";
		}

		// Token: 0x06034CAF RID: 216239 RVA: 0x00EC25D4 File Offset: 0x00EC07D4
		protected override void OnRefresh(params object[] args)
		{
			bool active = (bool)args[0];
			this.SetActive(active);
		}

		// Token: 0x06034CB0 RID: 216240 RVA: 0x00EC25F1 File Offset: 0x00EC07F1
		private void OnLongPressActive(bool isShortPress)
		{
			if (this.OnLongPressClickCallback != null)
			{
				this.OnLongPressClickCallback(isShortPress);
			}
		}

		// Token: 0x06034CB1 RID: 216241 RVA: 0x00EC2607 File Offset: 0x00EC0807
		public void BindReduceButtonCallback(Action onClickedReduceButton)
		{
			this.OnClickedCallback = onClickedReduceButton;
		}

		// Token: 0x06034CB2 RID: 216242 RVA: 0x00EC2610 File Offset: 0x00EC0810
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedCallback = null;
		}

		// Token: 0x06034CB3 RID: 216243 RVA: 0x00EC2619 File Offset: 0x00EC0819
		private void OnClickedReduceButton()
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback();
			}
		}

		// Token: 0x06034CB4 RID: 216244 RVA: 0x00EC262E File Offset: 0x00EC082E
		public void BindLongPressCallback(Action<bool> callback)
		{
			this.OnLongPressClickCallback = callback;
		}

		// Token: 0x06034CB5 RID: 216245 RVA: 0x00EC2637 File Offset: 0x00EC0837
		public void UnBindLongPressCallback()
		{
			this.OnLongPressClickCallback = null;
			this.LongPressButton.Deactivate();
		}

		// Token: 0x0401BF02 RID: 114434
		[Nullable(2)]
		private Action OnClickedCallback;

		// Token: 0x0401BF03 RID: 114435
		[Nullable(2)]
		private LongPressButtonItem LongPressButton;

		// Token: 0x0401BF04 RID: 114436
		[Nullable(2)]
		private Action<bool> OnLongPressClickCallback;

		// Token: 0x0200AF5D RID: 44893
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036304 RID: 221956
			ReduceButton
		}
	}
}
