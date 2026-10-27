using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028E4 RID: 10468
[NullableContext(1)]
[Nullable(0)]
public class RoleVisionAttribute : UiPanelBase
{
	// Token: 0x060159CF RID: 88527 RVA: 0x005746AA File Offset: 0x005728AA
	public RoleVisionAttribute(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x060159D0 RID: 88528 RVA: 0x005746DE File Offset: 0x005728DE
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x060159D1 RID: 88529 RVA: 0x005746F4 File Offset: 0x005728F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060159D2 RID: 88530 RVA: 0x0057475D File Offset: 0x0057295D
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<RoleAttributeItem, RoleAttributeSt>(base.GetVerticalLayout(0), this.CreateSwitchItem, base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060159D3 RID: 88531 RVA: 0x0057478C File Offset: 0x0057298C
	public void Refresh(List<AttrListScrollData> data, bool needCheckBg = false)
	{
		List<RoleAttributeSt> list = new List<RoleAttributeSt>();
		if (data != null)
		{
			foreach (AttrListScrollData data2 in data)
			{
				list.Add(new RoleAttributeSt
				{
					Data = data2,
					NeedCheckBg = needCheckBg
				});
			}
		}
		this.AttributeScroller.RefreshByData(list, null, false);
	}

	// Token: 0x0400A0C9 RID: 41161
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RoleAttributeItem, RoleAttributeSt> AttributeScroller;

	// Token: 0x0400A0CA RID: 41162
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0400A0CB RID: 41163
	private readonly Func<RoleAttributeItem> CreateSwitchItem = () => new RoleAttributeItem();

	// Token: 0x02008EF7 RID: 36599
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E5B9 RID: 189881
		VerticalLayout,
		// Token: 0x0402E5BA RID: 189882
		LayoutItem
	}
}
