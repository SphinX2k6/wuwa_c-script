using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B81 RID: 2945
internal class AdviceSelectLineContentItem : UiPanelBase
{
	// Token: 0x06007AA5 RID: 31397 RVA: 0x00260049 File Offset: 0x0025E249
	[NullableContext(1)]
	public AdviceSelectLineContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}
}
