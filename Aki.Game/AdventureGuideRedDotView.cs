using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001690 RID: 5776
public class AdventureGuideRedDotView : UiPanelBase
{
	// Token: 0x0600A4BF RID: 42175 RVA: 0x0024B026 File Offset: 0x00249226
	[NullableContext(1)]
	public AdventureGuideRedDotView(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600A4C0 RID: 42176 RVA: 0x0024B038 File Offset: 0x00249238
	public void EnableRedDot(ERedDotName type)
	{
		UUIItem rootItem = base.GetRootItem();
		RedDotController.Instance.BindRedDot(type, rootItem, null, 0);
		this.Type = type;
	}

	// Token: 0x0600A4C1 RID: 42177 RVA: 0x0024B061 File Offset: 0x00249261
	protected override void OnBeforeDestroy()
	{
		this.DisableRedDot(this.Type);
	}

	// Token: 0x0600A4C2 RID: 42178 RVA: 0x0024B06F File Offset: 0x0024926F
	public void DisableRedDot(ERedDotName type)
	{
		RedDotController.Instance.UnBindRedDot(type);
	}

	// Token: 0x04004A8C RID: 19084
	private ERedDotName Type;
}
