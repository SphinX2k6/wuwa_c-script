using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022EF RID: 8943
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallSettingButton : UiPanelBase
{
	// Token: 0x060119EA RID: 72170 RVA: 0x00452B10 File Offset: 0x00450D10
	public OnlineHallSettingButton(AActor uiContainerActor, WorldEnterPermission type)
	{
		this.Type = type;
		base.CreateThenShowByActor(uiContainerActor, null);
	}

	// Token: 0x060119EB RID: 72171 RVA: 0x00452B28 File Offset: 0x00450D28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060119EC RID: 72172 RVA: 0x00452B91 File Offset: 0x00450D91
	protected override void OnStart()
	{
		this.InitType(this.Type);
		this.AddEvents();
	}

	// Token: 0x060119ED RID: 72173 RVA: 0x00452BA5 File Offset: 0x00450DA5
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
	}

	// Token: 0x060119EE RID: 72174 RVA: 0x00452BAD File Offset: 0x00450DAD
	private void AddEvents()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnSettingButtonClicked));
	}

	// Token: 0x060119EF RID: 72175 RVA: 0x00452BCC File Offset: 0x00450DCC
	private void RemoveEvents()
	{
		base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnSettingButtonClicked));
	}

	// Token: 0x060119F0 RID: 72176 RVA: 0x00452BEB File Offset: 0x00450DEB
	public void BindOnSettingButtonClickedCallback(Action<WorldEnterPermission> onSettingButtonClickedCallback)
	{
		this.OnSettingButtonClickedCallback = onSettingButtonClickedCallback;
	}

	// Token: 0x060119F1 RID: 72177 RVA: 0x00452BF4 File Offset: 0x00450DF4
	public void BindCanToggleExecuteChange(Func<WorldEnterPermission, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x060119F2 RID: 72178 RVA: 0x00452BFD File Offset: 0x00450DFD
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.Type);
	}

	// Token: 0x060119F3 RID: 72179 RVA: 0x00452C1C File Offset: 0x00450E1C
	public void SetSelected(bool bSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060119F4 RID: 72180 RVA: 0x00452C4C File Offset: 0x00450E4C
	private void InitType(WorldEnterPermission type)
	{
		UUIText text = base.GetText(1);
		string str = "PermissionsSetting_";
		int num = (int)type;
		string textTableId = str + num.ToString();
		LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x060119F5 RID: 72181 RVA: 0x00452CA3 File Offset: 0x00450EA3
	private void OnSettingButtonClicked(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.OnSettingButtonClickedCallback != null)
		{
			this.OnSettingButtonClickedCallback(this.Type);
		}
	}

	// Token: 0x040085C3 RID: 34243
	[Nullable(2)]
	private Action<WorldEnterPermission> OnSettingButtonClickedCallback;

	// Token: 0x040085C4 RID: 34244
	private readonly WorldEnterPermission Type;

	// Token: 0x040085C5 RID: 34245
	[Nullable(2)]
	private Func<WorldEnterPermission, bool> OnCanToggleClicked;

	// Token: 0x02008866 RID: 34918
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402C533 RID: 181555
		Tog,
		// Token: 0x0402C534 RID: 181556
		TogText
	}
}
