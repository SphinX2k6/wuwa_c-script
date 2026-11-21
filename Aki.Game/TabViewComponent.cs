using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E81 RID: 3713
[NullableContext(2)]
[Nullable(0)]
public sealed class TabViewComponent<TData> : GenericTabViewComponent
{
	// Token: 0x060094AD RID: 38061 RVA: 0x002C1AB1 File Offset: 0x002BFCB1
	[NullableContext(1)]
	public TabViewComponent(UUIItem RootViewItem, EKeyMode KeyMode = EKeyMode.Default) : base(RootViewItem, KeyMode)
	{
	}

	// Token: 0x060094AE RID: 38062 RVA: 0x002C1ABB File Offset: 0x002BFCBB
	public void ToggleCallBackNew([Nullable(1)] TData data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
	{
		base.ToggleCallBackNew(data, viewName, tabItem, extraParams, index);
	}

	// Token: 0x060094AF RID: 38063 RVA: 0x002C1ACF File Offset: 0x002BFCCF
	public void ToggleCallBack([Nullable(1)] TData data, EUiTabViewName viewName, CommonTabItemBase tabItem = null, object extraParams = null, int? index = null)
	{
		base.ToggleCallBack(data, viewName, tabItem, extraParams, index);
	}
}
