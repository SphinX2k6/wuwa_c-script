using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200284A RID: 10314
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorClassifyItem : GridProxyAbstract<RoleFavorClassifyDataBase>
{
	// Token: 0x06015442 RID: 87106 RVA: 0x0055F44B File Offset: 0x0055D64B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06015443 RID: 87107 RVA: 0x0055F484 File Offset: 0x0055D684
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayout<RoleFavorContentItem, RoleFavorContentDataBase>(base.GetVerticalLayout(0), new Func<RoleFavorContentItem>(this.CreateContentItem), null, false, true);
	}

	// Token: 0x06015444 RID: 87108 RVA: 0x0055F4A7 File Offset: 0x0055D6A7
	protected override void OnBeforeDestroy()
	{
		this.ClassifyData = null;
	}

	// Token: 0x06015445 RID: 87109 RVA: 0x0055F4B0 File Offset: 0x0055D6B0
	public override void Refresh(RoleFavorClassifyDataBase data, bool isSelected, int gridIndex)
	{
		this.ClassifyData = data;
		base.GridIndex = gridIndex;
		base.DisplayIndex = gridIndex;
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalText(text, this.ClassifyData.TitleTableId, Array.Empty<object>());
		List<RoleFavorContentDataBase> contentDataList = this.ClassifyData.GetContentDataList();
		GenericLayout<RoleFavorContentItem, RoleFavorContentDataBase> contentGenericLayout = this.ContentGenericLayout;
		if (contentGenericLayout == null)
		{
			return;
		}
		contentGenericLayout.RefreshByData(contentDataList, null, false);
	}

	// Token: 0x06015446 RID: 87110 RVA: 0x0055F514 File Offset: 0x0055D714
	public IReadOnlyList<RoleFavorContentItem> GetContentItemList()
	{
		return this.ContentItemList;
	}

	// Token: 0x06015447 RID: 87111 RVA: 0x0055F51C File Offset: 0x0055D71C
	private RoleFavorContentItem CreateContentItem()
	{
		RoleFavorContentItem roleFavorContentItem = new RoleFavorContentItem();
		this.ContentItemList.Add(roleFavorContentItem);
		return roleFavorContentItem;
	}

	// Token: 0x04009ECF RID: 40655
	[Nullable(2)]
	private RoleFavorClassifyDataBase ClassifyData;

	// Token: 0x04009ED0 RID: 40656
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RoleFavorContentItem, RoleFavorContentDataBase> ContentGenericLayout;

	// Token: 0x04009ED1 RID: 40657
	private readonly List<RoleFavorContentItem> ContentItemList = new List<RoleFavorContentItem>();

	// Token: 0x02008E84 RID: 36484
	[NullableContext(0)]
	private enum ERoleFavorClassifyItemDefine
	{
		// Token: 0x0402E38E RID: 189326
		ContentVerticalLayout,
		// Token: 0x0402E38F RID: 189327
		TitleText
	}
}
