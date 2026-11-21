using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA3 RID: 3235
public class ButtonSpriteItem : UiPanelBase
{
	// Token: 0x0600870D RID: 34573 RVA: 0x00292208 File Offset: 0x00290408
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600870E RID: 34574 RVA: 0x002922CF File Offset: 0x002904CF
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600870F RID: 34575 RVA: 0x002922D7 File Offset: 0x002904D7
	private void ButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x06008710 RID: 34576 RVA: 0x002922EC File Offset: 0x002904EC
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x06008711 RID: 34577 RVA: 0x002922F8 File Offset: 0x002904F8
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x06008712 RID: 34578 RVA: 0x00292318 File Offset: 0x00290518
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(state);
		}
	}

	// Token: 0x06008713 RID: 34579 RVA: 0x00292337 File Offset: 0x00290537
	[NullableContext(1)]
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06008714 RID: 34580 RVA: 0x00292340 File Offset: 0x00290540
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(1).SetUIActive(bVisible);
	}

	// Token: 0x06008715 RID: 34581 RVA: 0x00292350 File Offset: 0x00290550
	[NullableContext(1)]
	public void SetSprite(string path)
	{
		UUISprite sprite = base.GetSprite(1);
		sprite.SetUIActive(false);
		this.SetSpriteByPath(path, sprite, false, null, delegate(bool success)
		{
			sprite.SetUIActive(success);
		});
	}

	// Token: 0x06008716 RID: 34582 RVA: 0x0029239F File Offset: 0x0029059F
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06008717 RID: 34583 RVA: 0x002923B4 File Offset: 0x002905B4
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		this.RedDotUid = uId;
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06008718 RID: 34584 RVA: 0x00292404 File Offset: 0x00290604
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, this.RedDotUid);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x040051C5 RID: 20933
	private ERedDotName? RedDotName;

	// Token: 0x040051C6 RID: 20934
	private int RedDotUid;

	// Token: 0x040051C7 RID: 20935
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02006F5D RID: 28509
	private class EButtonItemDefine
	{
		// Token: 0x0402463E RID: 149054
		public const int Button = 0;

		// Token: 0x0402463F RID: 149055
		public const int Sprite = 1;

		// Token: 0x04024640 RID: 149056
		public const int RedDot = 2;
	}
}
