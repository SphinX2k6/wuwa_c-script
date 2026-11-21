using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B45 RID: 6981
public class FocusModeToggle : UiPanelBase
{
	// Token: 0x06011650 RID: 71248 RVA: 0x0051F31C File Offset: 0x0051D51C
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

	// Token: 0x06011651 RID: 71249 RVA: 0x0051F385 File Offset: 0x0051D585
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011652 RID: 71250 RVA: 0x0051F3A0 File Offset: 0x0051D5A0
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Clear();
			extendToggle.OnPointUpCallBack.Unbind();
			extendToggle.CanExecuteChange.Unbind();
		}
	}

	// Token: 0x06011653 RID: 71251 RVA: 0x0051F3DC File Offset: 0x0051D5DC
	[NullableContext(1)]
	public void BindToggleCallback(Action<EToggleState> onToggleStateChange, Action<EToggleState> onPointUpCallBack)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Add(onToggleStateChange);
			extendToggle.OnPointUpCallBack.Bind(onPointUpCallBack);
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		}
	}

	// Token: 0x06011654 RID: 71252 RVA: 0x0051F423 File Offset: 0x0051D623
	public void SetToggleState(bool bActive)
	{
		this.ManualSetToggleState = true;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(bActive ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}
		this.ManualSetToggleState = false;
	}

	// Token: 0x06011655 RID: 71253 RVA: 0x0051F450 File Offset: 0x0051D650
	[NullableContext(1)]
	public void SetButtonText(string textTableId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textTableId, Array.Empty<object>());
	}

	// Token: 0x06011656 RID: 71254 RVA: 0x0051F46C File Offset: 0x0051D66C
	private bool CanToggleExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		EToggleState? etoggleState = (extendToggle != null) ? new EToggleState?(extendToggle.GetToggleState()) : null;
		if (!this.ManualSetToggleState)
		{
			EToggleState? etoggleState2 = etoggleState;
			EToggleState etoggleState3 = EToggleState.ETT_Checked;
			return etoggleState2.GetValueOrDefault() == etoggleState3 & etoggleState2 != null;
		}
		return true;
	}

	// Token: 0x040098CE RID: 39118
	private bool ManualSetToggleState;

	// Token: 0x02007E1E RID: 32286
	private class EChildComponent
	{
		// Token: 0x04028D28 RID: 167208
		public const int Toggle = 0;

		// Token: 0x04028D29 RID: 167209
		public const int ToggleText = 1;
	}
}
