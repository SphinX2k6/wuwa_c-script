using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200222B RID: 8747
public class UiNavigationView : UiPanelBase
{
	// Token: 0x060159AA RID: 88490 RVA: 0x00644DEA File Offset: 0x00642FEA
	protected override void OnBeforeShowImplement()
	{
		this.InitData();
	}

	// Token: 0x060159AB RID: 88491 RVA: 0x00644DF2 File Offset: 0x00642FF2
	protected override void OnAfterShowImplement()
	{
		this.AfterActive();
	}

	// Token: 0x060159AC RID: 88492 RVA: 0x00644DFA File Offset: 0x00642FFA
	protected bool FindDefault()
	{
		return true;
	}

	// Token: 0x060159AD RID: 88493 RVA: 0x00644DFD File Offset: 0x00642FFD
	protected virtual void AfterActive()
	{
	}

	// Token: 0x060159AE RID: 88494 RVA: 0x00644DFF File Offset: 0x00642FFF
	protected override void OnBeforeDestroyImplement()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null && rootItem.IsValid())
		{
			this.SetActive(false);
		}
	}

	// Token: 0x060159AF RID: 88495 RVA: 0x00644E1C File Offset: 0x0064301C
	private void InitData()
	{
		this.ViewName = base.GetRootItem().GetDisplayName();
	}

	// Token: 0x0400B680 RID: 46720
	[Nullable(1)]
	protected string ViewName;
}
