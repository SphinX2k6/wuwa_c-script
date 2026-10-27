using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CD6 RID: 11478
[NullableContext(1)]
[Nullable(0)]
public class SimpleGenericLayout
{
	// Token: 0x06018145 RID: 98629 RVA: 0x0061F2CC File Offset: 0x0061D4CC
	public SimpleGenericLayout(UUILayoutBase layout)
	{
		this.Layout = layout;
		UUIItem attachUIChild = layout.RootUIComp.Get().GetAttachUIChild(0);
		if (attachUIChild == null || !attachUIChild.IsValid())
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.LZK, "Layout下不存在有效的子节点", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SrcItem = attachUIChild;
		this.ItemList.Add(this.SrcItem);
	}

	// Token: 0x06018146 RID: 98630 RVA: 0x0061F348 File Offset: 0x0061D548
	public void RebuildLayout(int length)
	{
		if (this.SrcItem == null || !this.SrcItem.IsValid())
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.LZK, "Layout下不存在有效的子节点", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.DisplayCount = length;
		UUIItem parent = this.Layout.RootUIComp.Get();
		for (int i = this.ItemList.Count; i < this.DisplayCount; i++)
		{
			UUIItem item = LguiUtil.Instance.CopyItem(this.SrcItem, parent);
			this.ItemList.Add(item);
		}
		for (int j = 0; j < this.DisplayCount; j++)
		{
			this.ItemList[j].SetUIActive(true);
		}
		for (int k = this.DisplayCount; k < this.ItemList.Count; k++)
		{
			this.ItemList[k].SetUIActive(false);
		}
	}

	// Token: 0x06018147 RID: 98631 RVA: 0x0061F436 File Offset: 0x0061D636
	public int GetDisplayCount()
	{
		return this.DisplayCount;
	}

	// Token: 0x06018148 RID: 98632 RVA: 0x0061F43E File Offset: 0x0061D63E
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UUIItem> GetItemList()
	{
		return this.ItemList;
	}

	// Token: 0x06018149 RID: 98633 RVA: 0x0061F448 File Offset: 0x0061D648
	public void SetActive(bool active)
	{
		this.Layout.RootUIComp.Get().SetUIActive(active);
	}

	// Token: 0x0400B316 RID: 45846
	[Nullable(2)]
	public readonly UUILayoutBase Layout;

	// Token: 0x0400B317 RID: 45847
	[Nullable(2)]
	private readonly UUIItem SrcItem;

	// Token: 0x0400B318 RID: 45848
	private readonly List<UUIItem> ItemList = new List<UUIItem>();

	// Token: 0x0400B319 RID: 45849
	private int DisplayCount;
}
