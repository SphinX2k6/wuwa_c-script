using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B48 RID: 2888
public class AdventureGuideRedDotView : UiPanelBase
{
	// Token: 0x0600789F RID: 30879 RVA: 0x0025538A File Offset: 0x0025358A
	[NullableContext(1)]
	public AdventureGuideRedDotView(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x060078A0 RID: 30880 RVA: 0x0025539C File Offset: 0x0025359C
	public void EnableRedDot(ERedDotName type)
	{
		UUIItem rootItem = base.GetRootItem();
		RedDotController.Instance.BindRedDot(type, rootItem, null, 0);
		this.Type = type;
	}

	// Token: 0x060078A1 RID: 30881 RVA: 0x002553C5 File Offset: 0x002535C5
	protected override void OnBeforeDestroy()
	{
		this.DisableRedDot(this.Type);
	}

	// Token: 0x060078A2 RID: 30882 RVA: 0x002553D3 File Offset: 0x002535D3
	public void DisableRedDot(ERedDotName type)
	{
		RedDotController.Instance.UnBindRedDot(type);
	}

	// Token: 0x04004B33 RID: 19251
	private ERedDotName Type;
}
