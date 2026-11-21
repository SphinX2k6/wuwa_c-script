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
	// Token: 0x020049F5 RID: 18933
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FunctionAttachItemGrid : AutoAttachItem<int[]>
	{
		// Token: 0x0602F753 RID: 194387 RVA: 0x00D3C60E File Offset: 0x00D3A80E
		public FunctionAttachItemGrid(AActor uiItem = null) : base(uiItem)
		{
		}

		// Token: 0x0602F754 RID: 194388 RVA: 0x00D3C618 File Offset: 0x00D3A818
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

		// Token: 0x0602F755 RID: 194389 RVA: 0x00D3C662 File Offset: 0x00D3A862
		public override void OnSelect()
		{
			EventSystem.Instance.Emit<int>(EEventName.FunctionGridSelected, base.GetCurrentShowItemIndex());
		}

		// Token: 0x0602F756 RID: 194390 RVA: 0x00D3C67A File Offset: 0x00D3A87A
		protected override void OnUnSelect()
		{
		}

		// Token: 0x0602F757 RID: 194391 RVA: 0x00D3C67C File Offset: 0x00D3A87C
		protected override void OnMoveItem()
		{
		}

		// Token: 0x0602F758 RID: 194392 RVA: 0x00D3C680 File Offset: 0x00D3A880
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

		// Token: 0x0602F759 RID: 194393 RVA: 0x00D3C6E9 File Offset: 0x00D3A8E9
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<FunctionItem>(base.GetLayoutBase(0), (object functionId, UUIItem uiItem, int index) => this.InitSubItem((int?)functionId, uiItem, index), base.GetItem(1));
		}

		// Token: 0x0602F75A RID: 194394 RVA: 0x00D3C710 File Offset: 0x00D3A910
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

		// Token: 0x0602F75B RID: 194395 RVA: 0x00D3C749 File Offset: 0x00D3A949
		public void SetNeedAnim(bool value)
		{
			this.NeedAnim = value;
		}

		// Token: 0x0602F75C RID: 194396 RVA: 0x00D3C754 File Offset: 0x00D3A954
		protected override void OnBeforeDestroy()
		{
			this.Layout.ClearGridController();
			foreach (FunctionItem child in this.Layout.GetLayoutItemList())
			{
				base.AddChild(child);
			}
		}

		// Token: 0x0602F75D RID: 194397 RVA: 0x00D3C7B8 File Offset: 0x00D3A9B8
		public FunctionItem GetFunctionItem(int functionId)
		{
			return this.Layout.GetLayoutItemByKey(functionId);
		}

		// Token: 0x04019241 RID: 102977
		[Nullable(1)]
		protected GenericLayoutNew<FunctionItem> Layout;

		// Token: 0x04019242 RID: 102978
		private bool NeedAnim;

		// Token: 0x0200A697 RID: 42647
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x040337FC RID: 210940
			public const int LayoutItem = 0;

			// Token: 0x040337FD RID: 210941
			public const int GridItem = 1;
		}
	}
}
