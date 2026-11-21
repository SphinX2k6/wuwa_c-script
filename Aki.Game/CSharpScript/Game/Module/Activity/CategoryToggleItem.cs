using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE7 RID: 20199
	[NullableContext(2)]
	[Nullable(0)]
	public class CategoryToggleItem : UiPanelBase
	{
		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x06032C54 RID: 207956 RVA: 0x00E4243C File Offset: 0x00E4063C
		// (set) Token: 0x06032C55 RID: 207957 RVA: 0x00E42444 File Offset: 0x00E40644
		public Action<EToggleState> OnToggleClickCallBack { get; set; }

		// Token: 0x06032C56 RID: 207958 RVA: 0x00E42450 File Offset: 0x00E40650
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

		// Token: 0x06032C57 RID: 207959 RVA: 0x00E42517 File Offset: 0x00E40717
		private void ToggleClick(EToggleState state)
		{
			Action<EToggleState> onToggleClickCallBack = this.OnToggleClickCallBack;
			if (onToggleClickCallBack == null)
			{
				return;
			}
			onToggleClickCallBack(state);
		}

		// Token: 0x06032C58 RID: 207960 RVA: 0x00E4252C File Offset: 0x00E4072C
		[NullableContext(1)]
		public void SetIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x06032C59 RID: 207961 RVA: 0x00E42552 File Offset: 0x00E40752
		[NullableContext(1)]
		public UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06032C5A RID: 207962 RVA: 0x00E4255B File Offset: 0x00E4075B
		public void SetRedDotState(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0200AC41 RID: 44097
		[NullableContext(0)]
		private class EToggleComponents
		{
			// Token: 0x040354C6 RID: 218310
			public const int Toggle = 0;

			// Token: 0x040354C7 RID: 218311
			public const int Icon = 1;

			// Token: 0x040354C8 RID: 218312
			public const int RedDot = 2;
		}
	}
}
