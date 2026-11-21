using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BF6 RID: 7158
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsButtonItem : UiPanelBase
{
	// Token: 0x06011CB2 RID: 72882 RVA: 0x0053B7D0 File Offset: 0x005399D0
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

	// Token: 0x06011CB3 RID: 72883 RVA: 0x0053B837 File Offset: 0x00539A37
	protected override void OnBeforeDestroy()
	{
		this.ButtonFunction = null;
		this.ExtraButtonFunctionSet.Clear();
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x06011CB4 RID: 72884 RVA: 0x0053B858 File Offset: 0x00539A58
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

	// Token: 0x06011CB5 RID: 72885 RVA: 0x0053B894 File Offset: 0x00539A94
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

	// Token: 0x06011CB6 RID: 72886 RVA: 0x0053B8F8 File Offset: 0x00539AF8
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x06011CB7 RID: 72887 RVA: 0x0053B917 File Offset: 0x00539B17
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06011CB8 RID: 72888 RVA: 0x0053B92B File Offset: 0x00539B2B
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06011CB9 RID: 72889 RVA: 0x0053B934 File Offset: 0x00539B34
	public void SetExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Add(buttonFunction);
	}

	// Token: 0x06011CBA RID: 72890 RVA: 0x0053B943 File Offset: 0x00539B43
	public void DeleteExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Remove(buttonFunction);
	}

	// Token: 0x06011CBB RID: 72891 RVA: 0x0053B952 File Offset: 0x00539B52
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06011CBC RID: 72892 RVA: 0x0053B968 File Offset: 0x00539B68
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

	// Token: 0x06011CBD RID: 72893 RVA: 0x0053B9B9 File Offset: 0x00539BB9
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(1), uId);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x06011CBE RID: 72894 RVA: 0x0053B9F8 File Offset: 0x00539BF8
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x04009B80 RID: 39808
	private ERedDotName? RedDotName;

	// Token: 0x04009B81 RID: 39809
	private int RedDotUid;

	// Token: 0x04009B82 RID: 39810
	private readonly HashSet<Action> ExtraButtonFunctionSet = new HashSet<Action>();

	// Token: 0x04009B83 RID: 39811
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02007EE2 RID: 32482
	[NullableContext(0)]
	private enum EButtonItemDefine
	{
		// Token: 0x040290FD RID: 168189
		Button,
		// Token: 0x040290FE RID: 168190
		RedDot
	}
}
