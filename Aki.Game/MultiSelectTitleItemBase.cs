using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CD6 RID: 3286
[NullableContext(1)]
[Nullable(0)]
public abstract class MultiSelectTitleItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x06008906 RID: 35078 RVA: 0x002989A0 File Offset: 0x00296BA0
	public MultiSelectTitleItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008907 RID: 35079
	public abstract void ShowMultiSelectTitle(IReadOnlyList<TData> dataList);
}
