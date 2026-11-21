using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DA6 RID: 3494
[NullableContext(1)]
[Nullable(0)]
public class TipsBaseSubComponent : UiPanelBase
{
	// Token: 0x06008EEB RID: 36587 RVA: 0x002AFF79 File Offset: 0x002AE179
	public TipsBaseSubComponent(UUIItem rootUiItem)
	{
	}

	// Token: 0x06008EEC RID: 36588 RVA: 0x002AFF8C File Offset: 0x002AE18C
	protected override void OnBeforeShowImplement()
	{
		foreach (Action action in this.OperationMap.Values)
		{
			action();
		}
		this.OperationMap.Clear();
	}

	// Token: 0x06008EED RID: 36589 RVA: 0x002AFFEC File Offset: 0x002AE1EC
	protected override void OnBeforeDestroy()
	{
		this.OperationMap.Clear();
	}

	// Token: 0x06008EEE RID: 36590 RVA: 0x002AFFF9 File Offset: 0x002AE1F9
	public virtual void Refresh(ItemTipsData data)
	{
	}

	// Token: 0x06008EEF RID: 36591 RVA: 0x002AFFFC File Offset: 0x002AE1FC
	public void SetVisible(bool isShow)
	{
		Action action = delegate()
		{
			this.SetActive(isShow);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["SetVisible"] = action;
			return;
		}
		action();
	}

	// Token: 0x06008EF0 RID: 36592 RVA: 0x002B0048 File Offset: 0x002AE248
	public virtual void SetLockButtonShow(bool isShow)
	{
	}

	// Token: 0x06008EF1 RID: 36593 RVA: 0x002B004A File Offset: 0x002AE24A
	public virtual void SetPanelNumVisible(bool isShow)
	{
	}

	// Token: 0x0400559D RID: 21917
	protected readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();
}
