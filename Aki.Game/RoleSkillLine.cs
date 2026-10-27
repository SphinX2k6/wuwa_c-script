using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028BB RID: 10427
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillLine : UiPanelBase
{
	// Token: 0x06015806 RID: 88070 RVA: 0x0056C42C File Offset: 0x0056A62C
	[NullableContext(1)]
	public RoleSkillLine(int startNodeId, int endNodeId, string color, UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
		this.InactiveNode = uiItem.GetAttachUIChild(0);
		this.ActiveNode = uiItem.GetAttachUIChild(1);
		this.ActiveEffect = uiItem.GetAttachUIChild(2);
		this.StartPosId = new int?(startNodeId);
		this.EndPosId = new int?(endNodeId);
		this.SetColor(color);
	}

	// Token: 0x06015807 RID: 88071 RVA: 0x0056C496 File Offset: 0x0056A696
	[NullableContext(1)]
	public void SetColor(string color)
	{
		if (this.ActiveEffect != null)
		{
			this.ActiveEffect.SetColor(FColor.FromHex(color));
		}
		if (this.ActiveNode != null)
		{
			this.ActiveNode.SetColor(FColor.FromHex(color));
		}
	}

	// Token: 0x06015808 RID: 88072 RVA: 0x0056C4CC File Offset: 0x0056A6CC
	public void SetLineActive(ELineState lineState)
	{
		switch (lineState)
		{
		case ELineState.None:
			this.RootItem.SetUIActive(false);
			this.ActiveEffect.SetUIActive(false);
			return;
		case ELineState.InActive:
			this.RootItem.SetUIActive(true);
			this.InactiveNode.SetUIActive(true);
			this.ActiveNode.SetUIActive(false);
			this.ActiveEffect.SetUIActive(false);
			return;
		case ELineState.Active:
			this.RootItem.SetUIActive(true);
			this.InactiveNode.SetUIActive(false);
			this.ActiveNode.SetUIActive(true);
			this.ActiveEffect.SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x06015809 RID: 88073 RVA: 0x0056C568 File Offset: 0x0056A768
	protected override void OnBeforeDestroy()
	{
		this.StartPosId = null;
		this.EndPosId = null;
		this.InactiveNode = null;
		this.ActiveNode = null;
		this.ActiveEffect = null;
	}

	// Token: 0x0400A03F RID: 41023
	public int? StartPosId;

	// Token: 0x0400A040 RID: 41024
	public int? EndPosId;

	// Token: 0x0400A041 RID: 41025
	private UUIItem InactiveNode;

	// Token: 0x0400A042 RID: 41026
	private UUIItem ActiveNode;

	// Token: 0x0400A043 RID: 41027
	private UUIItem ActiveEffect;
}
