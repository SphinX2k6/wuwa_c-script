using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E5F RID: 7775
[NullableContext(1)]
[Nullable(0)]
public class RoleVisionAttribute : UiPanelBase
{
	// Token: 0x060133D3 RID: 78803 RVA: 0x0059F572 File Offset: 0x0059D772
	public RoleVisionAttribute(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x060133D4 RID: 78804 RVA: 0x0059F5A6 File Offset: 0x0059D7A6
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x060133D5 RID: 78805 RVA: 0x0059F5BC File Offset: 0x0059D7BC
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

	// Token: 0x060133D6 RID: 78806 RVA: 0x0059F625 File Offset: 0x0059D825
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<RoleAttributeItem, RoleAttributeSt>(base.GetVerticalLayout(0), this.CreateSwitchItem, base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060133D7 RID: 78807 RVA: 0x0059F654 File Offset: 0x0059D854
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

	// Token: 0x0400A4B3 RID: 42163
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RoleAttributeItem, RoleAttributeSt> AttributeScroller;

	// Token: 0x0400A4B4 RID: 42164
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0400A4B5 RID: 42165
	private readonly Func<RoleAttributeItem> CreateSwitchItem = () => new RoleAttributeItem();

	// Token: 0x0200813F RID: 33087
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029CB4 RID: 171188
		VerticalLayout,
		// Token: 0x04029CB5 RID: 171189
		LayoutItem
	}
}
