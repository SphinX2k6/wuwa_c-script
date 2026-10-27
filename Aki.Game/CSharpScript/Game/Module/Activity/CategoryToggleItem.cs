using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005F00 RID: 24320
	[NullableContext(2)]
	[Nullable(0)]
	public class CategoryToggleItem : UiPanelBase
	{
		// Token: 0x17008EEE RID: 36590
		// (get) Token: 0x0603DCB9 RID: 253113 RVA: 0x00EF0778 File Offset: 0x00EEE978
		// (set) Token: 0x0603DCBA RID: 253114 RVA: 0x00EF0780 File Offset: 0x00EEE980
		public Action<EToggleState> OnToggleClickCallBack { get; set; }

		// Token: 0x0603DCBB RID: 253115 RVA: 0x00EF078C File Offset: 0x00EEE98C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DCBC RID: 253116 RVA: 0x00EF0853 File Offset: 0x00EEEA53
		private void ToggleClick(EToggleState state)
		{
			Action<EToggleState> onToggleClickCallBack = this.OnToggleClickCallBack;
			if (onToggleClickCallBack == null)
			{
				return;
			}
			onToggleClickCallBack(state);
		}

		// Token: 0x0603DCBD RID: 253117 RVA: 0x00EF0868 File Offset: 0x00EEEA68
		[NullableContext(1)]
		public void SetIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0603DCBE RID: 253118 RVA: 0x00EF088E File Offset: 0x00EEEA8E
		[NullableContext(1)]
		public UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0603DCBF RID: 253119 RVA: 0x00EF0897 File Offset: 0x00EEEA97
		public void SetRedDotState(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0200C233 RID: 49715
		[NullableContext(0)]
		private class EToggleComponents
		{
			// Token: 0x0403AAD2 RID: 240338
			public const int Toggle = 0;

			// Token: 0x0403AAD3 RID: 240339
			public const int Icon = 1;

			// Token: 0x0403AAD4 RID: 240340
			public const int RedDot = 2;
		}
	}
}
