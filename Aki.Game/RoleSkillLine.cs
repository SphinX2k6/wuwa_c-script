using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E36 RID: 7734
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillLine : UiPanelBase
{
	// Token: 0x06013206 RID: 78342 RVA: 0x00597274 File Offset: 0x00595474
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

	// Token: 0x06013207 RID: 78343 RVA: 0x005972DE File Offset: 0x005954DE
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

	// Token: 0x06013208 RID: 78344 RVA: 0x00597314 File Offset: 0x00595514
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

	// Token: 0x06013209 RID: 78345 RVA: 0x005973B0 File Offset: 0x005955B0
	protected override void OnBeforeDestroy()
	{
		this.StartPosId = null;
		this.EndPosId = null;
		this.InactiveNode = null;
		this.ActiveNode = null;
		this.ActiveEffect = null;
	}

	// Token: 0x0400A428 RID: 42024
	public int? StartPosId;

	// Token: 0x0400A429 RID: 42025
	public int? EndPosId;

	// Token: 0x0400A42A RID: 42026
	private UUIItem InactiveNode;

	// Token: 0x0400A42B RID: 42027
	private UUIItem ActiveNode;

	// Token: 0x0400A42C RID: 42028
	private UUIItem ActiveEffect;
}
