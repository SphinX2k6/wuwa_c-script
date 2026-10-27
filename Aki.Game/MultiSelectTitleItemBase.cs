using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200181D RID: 6173
[NullableContext(1)]
[Nullable(0)]
public abstract class MultiSelectTitleItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x0600B51B RID: 46363 RVA: 0x0028E280 File Offset: 0x0028C480
	public MultiSelectTitleItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B51C RID: 46364
	public abstract void ShowMultiSelectTitle(IReadOnlyList<TData> dataList);
}
