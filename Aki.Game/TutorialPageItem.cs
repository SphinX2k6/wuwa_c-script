using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C23 RID: 11299
public class TutorialPageItem : UiPanelBase
{
	// Token: 0x060178B1 RID: 96433 RVA: 0x005FC934 File Offset: 0x005FAB34
	[NullableContext(1)]
	public TutorialPageItem(UUIItem UUIItem)
	{
		this.UUIItem = UUIItem;
	}

	// Token: 0x060178B2 RID: 96434 RVA: 0x005FC943 File Offset: 0x005FAB43
	public void Init()
	{
		base.CreateThenShowByActor(this.UUIItem.GetOwner(), null);
	}

	// Token: 0x060178B3 RID: 96435 RVA: 0x005FC957 File Offset: 0x005FAB57
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060178B4 RID: 96436 RVA: 0x005FC985 File Offset: 0x005FAB85
	public void UpdateShow(bool isShow)
	{
		base.GetItem(0).SetUIActive(isShow);
	}

	// Token: 0x0400AFA2 RID: 44962
	[Nullable(2)]
	private readonly UUIItem UUIItem;

	// Token: 0x02009219 RID: 37401
	private enum EPagesDotComponents
	{
		// Token: 0x0402F425 RID: 193573
		SprDot
	}
}
