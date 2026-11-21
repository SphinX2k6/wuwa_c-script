using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200219E RID: 8606
public class TutorialPageItem : UiPanelBase
{
	// Token: 0x060152E3 RID: 86755 RVA: 0x00629358 File Offset: 0x00627558
	[NullableContext(1)]
	public TutorialPageItem(UUIItem UUIItem)
	{
		this.UUIItem = UUIItem;
	}

	// Token: 0x060152E4 RID: 86756 RVA: 0x00629367 File Offset: 0x00627567
	public void Init()
	{
		base.CreateThenShowByActor(this.UUIItem.GetOwner(), null);
	}

	// Token: 0x060152E5 RID: 86757 RVA: 0x0062937B File Offset: 0x0062757B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x060152E6 RID: 86758 RVA: 0x006293A9 File Offset: 0x006275A9
	public void UpdateShow(bool isShow)
	{
		base.GetItem(0).SetUIActive(isShow);
	}

	// Token: 0x0400B3A7 RID: 45991
	[Nullable(2)]
	private readonly UUIItem UUIItem;

	// Token: 0x0200845C RID: 33884
	private enum EPagesDotComponents
	{
		// Token: 0x0402AB26 RID: 174886
		SprDot
	}
}
