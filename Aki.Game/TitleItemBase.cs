using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001820 RID: 6176
[NullableContext(1)]
[Nullable(0)]
public abstract class TitleItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x0600B524 RID: 46372 RVA: 0x0028E3A3 File Offset: 0x0028C5A3
	public TitleItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B525 RID: 46373
	public abstract void ShowTemp(TData data, DropDownItemBase<TData> selectedItemObj);
}
