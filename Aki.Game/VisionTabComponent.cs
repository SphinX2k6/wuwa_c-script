using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024F7 RID: 9463
[NullableContext(1)]
[Nullable(0)]
public class VisionTabComponent : UiPanelBase
{
	// Token: 0x06013084 RID: 77956 RVA: 0x004B694B File Offset: 0x004B4B4B
	public VisionTabComponent(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x06013085 RID: 77957 RVA: 0x004B6960 File Offset: 0x004B4B60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleOne)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleTwo))
		};
	}

	// Token: 0x06013086 RID: 77958 RVA: 0x004B69DF File Offset: 0x004B4BDF
	private void OnToggleOne(EToggleState toggleState)
	{
		Action onClickToggleOne = this.OnClickToggleOne;
		if (onClickToggleOne == null)
		{
			return;
		}
		onClickToggleOne();
	}

	// Token: 0x06013087 RID: 77959 RVA: 0x004B69F1 File Offset: 0x004B4BF1
	private void OnToggleTwo(EToggleState toggleState)
	{
		Action onClickToggleTwo = this.OnClickToggleTwo;
		if (onClickToggleTwo == null)
		{
			return;
		}
		onClickToggleTwo();
	}

	// Token: 0x06013088 RID: 77960 RVA: 0x004B6A03 File Offset: 0x004B4C03
	public void SetToggleOneButtonClick(Action call)
	{
		this.OnClickToggleOne = call;
	}

	// Token: 0x06013089 RID: 77961 RVA: 0x004B6A0C File Offset: 0x004B4C0C
	public void SetToggleTwoButtonClick(Action call)
	{
		this.OnClickToggleTwo = call;
	}

	// Token: 0x04008F39 RID: 36665
	[Nullable(2)]
	private Action OnClickToggleOne;

	// Token: 0x04008F3A RID: 36666
	[Nullable(2)]
	private Action OnClickToggleTwo;

	// Token: 0x02008A8A RID: 35466
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CFD1 RID: 184273
		ToggleOne,
		// Token: 0x0402CFD2 RID: 184274
		ToggleTwo
	}
}
