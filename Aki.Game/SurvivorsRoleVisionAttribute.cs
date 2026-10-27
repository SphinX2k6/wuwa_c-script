using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B2A RID: 11050
[NullableContext(1)]
[Nullable(0)]
internal class SurvivorsRoleVisionAttribute : UiPanelBase
{
	// Token: 0x06016F03 RID: 93955 RVA: 0x005D276A File Offset: 0x005D096A
	public SurvivorsRoleVisionAttribute(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06016F04 RID: 93956 RVA: 0x005D2779 File Offset: 0x005D0979
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x06016F05 RID: 93957 RVA: 0x005D278D File Offset: 0x005D098D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06016F06 RID: 93958 RVA: 0x005D27C6 File Offset: 0x005D09C6
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<SurvivorsAttributeDescItem, ISurvivorsAttributeUiData>(base.GetVerticalLayout(0), new Func<SurvivorsAttributeDescItem>(this.CreateSwitchItem), (AUIBaseActor)base.GetItem(1).GetOwner(), false, true);
	}

	// Token: 0x06016F07 RID: 93959 RVA: 0x005D27F9 File Offset: 0x005D09F9
	private SurvivorsAttributeDescItem CreateSwitchItem()
	{
		return new SurvivorsAttributeDescItem();
	}

	// Token: 0x06016F08 RID: 93960 RVA: 0x005D2800 File Offset: 0x005D0A00
	public void Refresh(IReadOnlyList<ISurvivorsAttributeUiData> data, bool playGridAnim = false)
	{
		this.AttributeScroller.RefreshByData(data.ToList<ISurvivorsAttributeUiData>(), null, playGridAnim);
	}

	// Token: 0x0400AAC8 RID: 43720
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<SurvivorsAttributeDescItem, ISurvivorsAttributeUiData> AttributeScroller;

	// Token: 0x0400AAC9 RID: 43721
	private readonly UUIItem SourceItem;
}
