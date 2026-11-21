using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CD9 RID: 3289
[NullableContext(1)]
[Nullable(0)]
public abstract class TitleItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x0600890F RID: 35087 RVA: 0x00298AC3 File Offset: 0x00296CC3
	public TitleItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008910 RID: 35088
	public abstract void ShowTemp(TData data, DropDownItemBase<TData> selectedItemObj);
}
