using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200127A RID: 4730
public class FightPhotoFocusView : UiViewBase
{
	// Token: 0x06008108 RID: 33032 RVA: 0x001B579B File Offset: 0x001B399B
	[NullableContext(1)]
	public FightPhotoFocusView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008109 RID: 33033 RVA: 0x001B57A4 File Offset: 0x001B39A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600810A RID: 33034 RVA: 0x001B57C7 File Offset: 0x001B39C7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnNeedShowFightPhotoFocus, new Action<bool>(this.OnNeedShowFightPhotoFocus));
	}

	// Token: 0x0600810B RID: 33035 RVA: 0x001B57E5 File Offset: 0x001B39E5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnNeedShowFightPhotoFocus, new Action<bool>(this.OnNeedShowFightPhotoFocus));
	}

	// Token: 0x0600810C RID: 33036 RVA: 0x001B5803 File Offset: 0x001B3A03
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600810D RID: 33037 RVA: 0x001B5817 File Offset: 0x001B3A17
	private void OnNeedShowFightPhotoFocus(bool needShow)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(needShow);
	}

	// Token: 0x0200788F RID: 30863
	private enum EComponents
	{
		// Token: 0x04027B80 RID: 162688
		ItemFocusFrame
	}
}
