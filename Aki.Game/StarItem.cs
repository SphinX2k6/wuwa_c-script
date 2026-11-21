using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D78 RID: 3448
internal class StarItem : UiPanelBase
{
	// Token: 0x06008DB6 RID: 36278 RVA: 0x002AC6BD File Offset: 0x002AA8BD
	[NullableContext(1)]
	public StarItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}
}
