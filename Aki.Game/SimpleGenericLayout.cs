using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200222F RID: 8751
[NullableContext(1)]
[Nullable(0)]
public class SimpleGenericLayout
{
	// Token: 0x060159C2 RID: 88514 RVA: 0x00644E84 File Offset: 0x00643084
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

	// Token: 0x060159C3 RID: 88515 RVA: 0x00644F00 File Offset: 0x00643100
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

	// Token: 0x060159C4 RID: 88516 RVA: 0x00644FEE File Offset: 0x006431EE
	public int GetDisplayCount()
	{
		return this.DisplayCount;
	}

	// Token: 0x060159C5 RID: 88517 RVA: 0x00644FF6 File Offset: 0x006431F6
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UUIItem> GetItemList()
	{
		return this.ItemList;
	}

	// Token: 0x060159C6 RID: 88518 RVA: 0x00645000 File Offset: 0x00643200
	public void SetActive(bool active)
	{
		this.Layout.RootUIComp.Get().SetUIActive(active);
	}

	// Token: 0x0400B682 RID: 46722
	[Nullable(2)]
	public readonly UUILayoutBase Layout;

	// Token: 0x0400B683 RID: 46723
	[Nullable(2)]
	private readonly UUIItem SrcItem;

	// Token: 0x0400B684 RID: 46724
	private readonly List<UUIItem> ItemList = new List<UUIItem>();

	// Token: 0x0400B685 RID: 46725
	private int DisplayCount;
}
