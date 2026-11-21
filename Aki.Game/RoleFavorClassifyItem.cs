using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DC5 RID: 7621
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleFavorClassifyItem : GridProxyAbstract<RoleFavorClassifyDataBase>
{
	// Token: 0x06012E40 RID: 77376 RVA: 0x0058A1A7 File Offset: 0x005883A7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012E41 RID: 77377 RVA: 0x0058A1E0 File Offset: 0x005883E0
	protected override void OnStart()
	{
		this.ContentGenericLayout = new GenericLayout<RoleFavorContentItem, RoleFavorContentDataBase>(base.GetVerticalLayout(0), new Func<RoleFavorContentItem>(this.CreateContentItem), null, false, true);
	}

	// Token: 0x06012E42 RID: 77378 RVA: 0x0058A203 File Offset: 0x00588403
	protected override void OnBeforeDestroy()
	{
		this.ClassifyData = null;
	}

	// Token: 0x06012E43 RID: 77379 RVA: 0x0058A20C File Offset: 0x0058840C
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

	// Token: 0x06012E44 RID: 77380 RVA: 0x0058A270 File Offset: 0x00588470
	public IReadOnlyList<RoleFavorContentItem> GetContentItemList()
	{
		return this.ContentItemList;
	}

	// Token: 0x06012E45 RID: 77381 RVA: 0x0058A278 File Offset: 0x00588478
	private RoleFavorContentItem CreateContentItem()
	{
		RoleFavorContentItem roleFavorContentItem = new RoleFavorContentItem();
		this.ContentItemList.Add(roleFavorContentItem);
		return roleFavorContentItem;
	}

	// Token: 0x0400A2B8 RID: 41656
	[Nullable(2)]
	private RoleFavorClassifyDataBase ClassifyData;

	// Token: 0x0400A2B9 RID: 41657
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RoleFavorContentItem, RoleFavorContentDataBase> ContentGenericLayout;

	// Token: 0x0400A2BA RID: 41658
	private readonly List<RoleFavorContentItem> ContentItemList = new List<RoleFavorContentItem>();

	// Token: 0x020080CA RID: 32970
	[NullableContext(0)]
	private enum ERoleFavorClassifyItemDefine
	{
		// Token: 0x04029A88 RID: 170632
		ContentVerticalLayout,
		// Token: 0x04029A89 RID: 170633
		TitleText
	}
}
