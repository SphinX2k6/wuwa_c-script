using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200072E RID: 1838
public class FightPhotoFocusView : UiViewBase
{
	// Token: 0x0600549F RID: 21663 RVA: 0x001BE46B File Offset: 0x001BC66B
	[NullableContext(1)]
	public FightPhotoFocusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x001BE474 File Offset: 0x001BC674
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x001BE497 File Offset: 0x001BC697
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnNeedShowFightPhotoFocus, new Action<bool>(this.OnNeedShowFightPhotoFocus));
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x001BE4B5 File Offset: 0x001BC6B5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnNeedShowFightPhotoFocus, new Action<bool>(this.OnNeedShowFightPhotoFocus));
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x001BE4D3 File Offset: 0x001BC6D3
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x001BE4E7 File Offset: 0x001BC6E7
	private void OnNeedShowFightPhotoFocus(bool needShow)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(needShow);
	}

	// Token: 0x02006A1A RID: 27162
	private enum EComponents
	{
		// Token: 0x04022EB1 RID: 143025
		ItemFocusFrame
	}
}
