using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018BF RID: 6335
internal class StarItem : UiPanelBase
{
	// Token: 0x0600B9CD RID: 47565 RVA: 0x002A1F65 File Offset: 0x002A0165
	[NullableContext(1)]
	public StarItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}
}
