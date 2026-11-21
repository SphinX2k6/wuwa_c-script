using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019DE RID: 6622
[NullableContext(1)]
[Nullable(0)]
public class VisionTabComponent : UiPanelBase
{
	// Token: 0x06010543 RID: 66883 RVA: 0x004C45DB File Offset: 0x004C27DB
	public VisionTabComponent(UUIItem actor)
	{
		base.CreateThenShowByActor(actor.GetOwner(), null);
	}

	// Token: 0x06010544 RID: 66884 RVA: 0x004C45F0 File Offset: 0x004C27F0
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

	// Token: 0x06010545 RID: 66885 RVA: 0x004C466F File Offset: 0x004C286F
	private void OnToggleOne(EToggleState toggleState)
	{
		Action onClickToggleOne = this.OnClickToggleOne;
		if (onClickToggleOne == null)
		{
			return;
		}
		onClickToggleOne();
	}

	// Token: 0x06010546 RID: 66886 RVA: 0x004C4681 File Offset: 0x004C2881
	private void OnToggleTwo(EToggleState toggleState)
	{
		Action onClickToggleTwo = this.OnClickToggleTwo;
		if (onClickToggleTwo == null)
		{
			return;
		}
		onClickToggleTwo();
	}

	// Token: 0x06010547 RID: 66887 RVA: 0x004C4693 File Offset: 0x004C2893
	public void SetToggleOneButtonClick(Action call)
	{
		this.OnClickToggleOne = call;
	}

	// Token: 0x06010548 RID: 66888 RVA: 0x004C469C File Offset: 0x004C289C
	public void SetToggleTwoButtonClick(Action call)
	{
		this.OnClickToggleTwo = call;
	}

	// Token: 0x04009083 RID: 36995
	[Nullable(2)]
	private Action OnClickToggleOne;

	// Token: 0x04009084 RID: 36996
	[Nullable(2)]
	private Action OnClickToggleTwo;

	// Token: 0x02007C12 RID: 31762
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040282E9 RID: 164585
		ToggleOne,
		// Token: 0x040282EA RID: 164586
		ToggleTwo
	}
}
