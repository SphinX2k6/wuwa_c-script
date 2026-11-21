using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A06 RID: 2566
[NullableContext(1)]
[Nullable(0)]
public class ActivityCircleButtonItem : UiPanelBase
{
	// Token: 0x06006FC9 RID: 28617 RVA: 0x00225CFC File Offset: 0x00223EFC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006FCA RID: 28618 RVA: 0x00225DC3 File Offset: 0x00223FC3
	public void SetOnClick(Action onClick)
	{
		this.OnClickInternal = onClick;
	}

	// Token: 0x06006FCB RID: 28619 RVA: 0x00225DCC File Offset: 0x00223FCC
	public void SetSubText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06006FCC RID: 28620 RVA: 0x00225DDC File Offset: 0x00223FDC
	public void SetRedDotVisible(bool value)
	{
		base.GetItem(2).SetUIActive(value);
	}

	// Token: 0x06006FCD RID: 28621 RVA: 0x00225DEC File Offset: 0x00223FEC
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06006FCE RID: 28622 RVA: 0x00225E34 File Offset: 0x00224034
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06006FCF RID: 28623 RVA: 0x00225E74 File Offset: 0x00224074
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x06006FD0 RID: 28624 RVA: 0x00225EA0 File Offset: 0x002240A0
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x06006FD1 RID: 28625 RVA: 0x00225ED0 File Offset: 0x002240D0
	private void OnClick()
	{
		this.OnClickInternal();
	}

	// Token: 0x04004516 RID: 17686
	private Action OnClickInternal = delegate()
	{
	};

	// Token: 0x04004517 RID: 17687
	private ERedDotName? RedDotName;

	// Token: 0x02006D0E RID: 27918
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023CEB RID: 146667
		public const int BtnCircle = 0;

		// Token: 0x04023CEC RID: 146668
		public const int TextSub = 1;

		// Token: 0x04023CED RID: 146669
		public const int ItemRedDot = 2;
	}
}
