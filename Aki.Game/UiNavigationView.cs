using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CD2 RID: 11474
public class UiNavigationView : UiPanelBase
{
	// Token: 0x0601812D RID: 98605 RVA: 0x0061F232 File Offset: 0x0061D432
	protected override void OnBeforeShowImplement()
	{
		this.InitData();
	}

	// Token: 0x0601812E RID: 98606 RVA: 0x0061F23A File Offset: 0x0061D43A
	protected override void OnAfterShowImplement()
	{
		this.AfterActive();
	}

	// Token: 0x0601812F RID: 98607 RVA: 0x0061F242 File Offset: 0x0061D442
	protected bool FindDefault()
	{
		return true;
	}

	// Token: 0x06018130 RID: 98608 RVA: 0x0061F245 File Offset: 0x0061D445
	protected virtual void AfterActive()
	{
	}

	// Token: 0x06018131 RID: 98609 RVA: 0x0061F247 File Offset: 0x0061D447
	protected override void OnBeforeDestroyImplement()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null && rootItem.IsValid())
		{
			this.SetActive(false);
		}
	}

	// Token: 0x06018132 RID: 98610 RVA: 0x0061F264 File Offset: 0x0061D464
	private void InitData()
	{
		this.ViewName = base.GetRootItem().GetDisplayName();
	}

	// Token: 0x0400B314 RID: 45844
	[Nullable(1)]
	protected string ViewName;
}
