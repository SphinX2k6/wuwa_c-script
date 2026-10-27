using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016C9 RID: 5833
internal class AdviceSelectLineContentItem : UiPanelBase
{
	// Token: 0x0600A6C5 RID: 42693 RVA: 0x00255C39 File Offset: 0x00253E39
	[NullableContext(1)]
	public AdviceSelectLineContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}
}
