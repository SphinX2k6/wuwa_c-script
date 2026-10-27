using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A19 RID: 23065
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FunctionAttachItemGrid : AutoAttachItem<int[]>
	{
		// Token: 0x0603A80A RID: 239626 RVA: 0x00DEC07E File Offset: 0x00DEA27E
		public FunctionAttachItemGrid(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0603A80B RID: 239627 RVA: 0x00DEC088 File Offset: 0x00DEA288
		protected override void OnRefreshItem(int[] data)
		{
			if (data == null)
			{
				return;
			}
			GenericLayoutNew<FunctionItem> layout = this.Layout;
			if (layout != null)
			{
				layout.SetNeedAnim(this.NeedAnim);
			}
			GenericLayoutNew<FunctionItem> layout2 = this.Layout;
			if (layout2 != null)
			{
				layout2.RebuildLayoutByDataNew<int>(data, null);
			}
			this.NeedAnim = false;
		}

		// Token: 0x0603A80C RID: 239628 RVA: 0x00DEC0D2 File Offset: 0x00DEA2D2
		public override void OnSelect()
		{
			EventSystem.Instance.Emit<int>(EEventName.FunctionGridSelected, base.GetCurrentShowItemIndex());
		}

		// Token: 0x0603A80D RID: 239629 RVA: 0x00DEC0EA File Offset: 0x00DEA2EA
		protected override void OnUnSelect()
		{
		}

		// Token: 0x0603A80E RID: 239630 RVA: 0x00DEC0EC File Offset: 0x00DEA2EC
		protected override void OnMoveItem()
		{
		}

		// Token: 0x0603A80F RID: 239631 RVA: 0x00DEC0F0 File Offset: 0x00DEA2F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A810 RID: 239632 RVA: 0x00DEC159 File Offset: 0x00DEA359
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<FunctionItem>(base.GetLayoutBase(0), (object functionId, UUIItem uiItem, int index) => this.InitSubItem((int?)functionId, uiItem, index), base.GetItem(1));
		}

		// Token: 0x0603A811 RID: 239633 RVA: 0x00DEC180 File Offset: 0x00DEA380
		[NullableContext(1)]
		private ILayoutItem<FunctionItem> InitSubItem(int? functionId, UUIItem uiItem, int index)
		{
			FunctionItem functionItem = new FunctionItem(uiItem);
			functionItem.UpdateItem(functionId.Value);
			return new LayoutItem<FunctionItem>
			{
				Key = functionId,
				Value = functionItem
			};
		}

		// Token: 0x0603A812 RID: 239634 RVA: 0x00DEC1B9 File Offset: 0x00DEA3B9
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x0603A813 RID: 239635 RVA: 0x00DEC1C4 File Offset: 0x00DEA3C4
		protected override void OnBeforeDestroy()
		{
			this.Layout.ClearGridController();
			foreach (FunctionItem child in this.Layout.GetLayoutItemList())
			{
				base.AddChild(child);
			}
		}

		// Token: 0x0603A814 RID: 239636 RVA: 0x00DEC228 File Offset: 0x00DEA428
		public FunctionItem GetFunctionItem(int functionId)
		{
			return this.Layout.GetLayoutItemByKey(functionId);
		}

		// Token: 0x0401E79A RID: 124826
		[Nullable(1)]
		protected GenericLayoutNew<FunctionItem> Layout;

		// Token: 0x0401E79B RID: 124827
		private bool NeedAnim;

		// Token: 0x0200BC8E RID: 48270
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04038E31 RID: 233009
			public const int LayoutItem = 0;

			// Token: 0x04038E32 RID: 233010
			public const int GridItem = 1;
		}
	}
}
