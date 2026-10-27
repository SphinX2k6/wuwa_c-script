using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018ED RID: 6381
[NullableContext(1)]
[Nullable(0)]
public class TipsBaseSubComponent : UiPanelBase
{
	// Token: 0x0600BB01 RID: 47873 RVA: 0x002A5809 File Offset: 0x002A3A09
	public TipsBaseSubComponent(UUIItem rootUiItem)
	{
	}

	// Token: 0x0600BB02 RID: 47874 RVA: 0x002A581C File Offset: 0x002A3A1C
	protected override void OnBeforeShowImplement()
	{
		foreach (Action action in this.OperationMap.Values)
		{
			action();
		}
		this.OperationMap.Clear();
	}

	// Token: 0x0600BB03 RID: 47875 RVA: 0x002A587C File Offset: 0x002A3A7C
	protected override void OnBeforeDestroy()
	{
		this.OperationMap.Clear();
	}

	// Token: 0x0600BB04 RID: 47876 RVA: 0x002A5889 File Offset: 0x002A3A89
	public virtual void Refresh(ItemTipsData data)
	{
	}

	// Token: 0x0600BB05 RID: 47877 RVA: 0x002A588C File Offset: 0x002A3A8C
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

	// Token: 0x0600BB06 RID: 47878 RVA: 0x002A58D8 File Offset: 0x002A3AD8
	public virtual void SetLockButtonShow(bool isShow)
	{
	}

	// Token: 0x0600BB07 RID: 47879 RVA: 0x002A58DA File Offset: 0x002A3ADA
	public virtual void SetPanelNumVisible(bool isShow)
	{
	}

	// Token: 0x040054F2 RID: 21746
	protected readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();
}
