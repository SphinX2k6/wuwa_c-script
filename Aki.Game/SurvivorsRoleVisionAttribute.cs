using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020A6 RID: 8358
[NullableContext(1)]
[Nullable(0)]
internal class SurvivorsRoleVisionAttribute : UiPanelBase
{
	// Token: 0x06014934 RID: 84276 RVA: 0x005FF2E6 File Offset: 0x005FD4E6
	public SurvivorsRoleVisionAttribute(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06014935 RID: 84277 RVA: 0x005FF2F5 File Offset: 0x005FD4F5
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x06014936 RID: 84278 RVA: 0x005FF309 File Offset: 0x005FD509
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06014937 RID: 84279 RVA: 0x005FF342 File Offset: 0x005FD542
	protected override void OnStart()
	{
		this.AttributeScroller = new GenericLayout<SurvivorsAttributeDescItem, ISurvivorsAttributeUiData>(base.GetVerticalLayout(0), new Func<SurvivorsAttributeDescItem>(this.CreateSwitchItem), (AUIBaseActor)base.GetItem(1).GetOwner(), false, true);
	}

	// Token: 0x06014938 RID: 84280 RVA: 0x005FF375 File Offset: 0x005FD575
	private SurvivorsAttributeDescItem CreateSwitchItem()
	{
		return new SurvivorsAttributeDescItem();
	}

	// Token: 0x06014939 RID: 84281 RVA: 0x005FF37C File Offset: 0x005FD57C
	public void Refresh(IReadOnlyList<ISurvivorsAttributeUiData> data, bool playGridAnim = false)
	{
		this.AttributeScroller.RefreshByData(data, null, playGridAnim);
	}

	// Token: 0x0400AECE RID: 44750
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<SurvivorsAttributeDescItem, ISurvivorsAttributeUiData> AttributeScroller;

	// Token: 0x0400AECF RID: 44751
	private readonly UUIItem SourceItem;
}
