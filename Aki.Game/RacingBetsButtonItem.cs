using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200270B RID: 9995
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsButtonItem : UiPanelBase
{
	// Token: 0x060147D0 RID: 83920 RVA: 0x0052CAB4 File Offset: 0x0052ACB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick))
		};
	}

	// Token: 0x060147D1 RID: 83921 RVA: 0x0052CB1B File Offset: 0x0052AD1B
	protected override void OnBeforeDestroy()
	{
		this.ButtonFunction = null;
		this.ExtraButtonFunctionSet.Clear();
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x060147D2 RID: 83922 RVA: 0x0052CB3C File Offset: 0x0052AD3C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIButtonComponent button = base.GetButton(0);
		UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x060147D3 RID: 83923 RVA: 0x0052CB78 File Offset: 0x0052AD78
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction != null)
		{
			buttonFunction();
		}
		foreach (Action action in this.ExtraButtonFunctionSet)
		{
			action();
		}
	}

	// Token: 0x060147D4 RID: 83924 RVA: 0x0052CBDC File Offset: 0x0052ADDC
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x060147D5 RID: 83925 RVA: 0x0052CBFB File Offset: 0x0052ADFB
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x060147D6 RID: 83926 RVA: 0x0052CC0F File Offset: 0x0052AE0F
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x060147D7 RID: 83927 RVA: 0x0052CC18 File Offset: 0x0052AE18
	public void SetExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Add(buttonFunction);
	}

	// Token: 0x060147D8 RID: 83928 RVA: 0x0052CC27 File Offset: 0x0052AE27
	public void DeleteExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Remove(buttonFunction);
	}

	// Token: 0x060147D9 RID: 83929 RVA: 0x0052CC36 File Offset: 0x0052AE36
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x060147DA RID: 83930 RVA: 0x0052CC4C File Offset: 0x0052AE4C
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		this.RedDotUid = uId;
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, uId);
		}
	}

	// Token: 0x060147DB RID: 83931 RVA: 0x0052CC9D File Offset: 0x0052AE9D
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(1), uId);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x060147DC RID: 83932 RVA: 0x0052CCDC File Offset: 0x0052AEDC
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x04009A28 RID: 39464
	private ERedDotName? RedDotName;

	// Token: 0x04009A29 RID: 39465
	private int RedDotUid;

	// Token: 0x04009A2A RID: 39466
	private readonly HashSet<Action> ExtraButtonFunctionSet = new HashSet<Action>();

	// Token: 0x04009A2B RID: 39467
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02008D59 RID: 36185
	[NullableContext(0)]
	private enum EButtonItemDefine
	{
		// Token: 0x0402DDE6 RID: 187878
		Button,
		// Token: 0x0402DDE7 RID: 187879
		RedDot
	}
}
