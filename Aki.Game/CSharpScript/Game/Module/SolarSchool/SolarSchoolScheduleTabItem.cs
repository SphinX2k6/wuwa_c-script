using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A6 RID: 22950
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class SolarSchoolScheduleTabItem : GridProxyAbstract<SolarSchoolScheduleTabItemData>
	{
		// Token: 0x17006C30 RID: 27696
		// (get) Token: 0x06038954 RID: 231764 RVA: 0x00FD5081 File Offset: 0x00FD3281
		// (set) Token: 0x06038955 RID: 231765 RVA: 0x00FD5089 File Offset: 0x00FD3289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolScheduleTabItemData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038956 RID: 231766 RVA: 0x00FD5094 File Offset: 0x00FD3294
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038957 RID: 231767 RVA: 0x00FD517C File Offset: 0x00FD337C
		[NullableContext(1)]
		public override void Refresh(SolarSchoolScheduleTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.TrySetSpriteByPath(data.IconPath, base.GetSprite(1), false, null, null);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.IsSpecialCategory);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(data.IsSpecialCategory);
			}
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06038958 RID: 231768 RVA: 0x00FD51E8 File Offset: 0x00FD33E8
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x06038959 RID: 231769 RVA: 0x00FD51F1 File Offset: 0x00FD33F1
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x0603895A RID: 231770 RVA: 0x00FD51FA File Offset: 0x00FD33FA
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x0603895B RID: 231771 RVA: 0x00FD5203 File Offset: 0x00FD3403
		public UUIItem GetGuideToggleItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x0603895C RID: 231772 RVA: 0x00FD5218 File Offset: 0x00FD3418
		private void OnToggleStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolScheduleTabItemData>, SolarSchoolScheduleTabItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolScheduleTabItemData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x0603895D RID: 231773 RVA: 0x00FD5266 File Offset: 0x00FD3466
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401DCDC RID: 122076
		private SolarSchoolScheduleTabItemData Data;

		// Token: 0x0200B552 RID: 46418
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040380FB RID: 229627
			public const int Toggle = 0;

			// Token: 0x040380FC RID: 229628
			public const int Icon = 1;

			// Token: 0x040380FD RID: 229629
			public const int NormalPanel = 2;

			// Token: 0x040380FE RID: 229630
			public const int SpecialPanel = 3;
		}
	}
}
