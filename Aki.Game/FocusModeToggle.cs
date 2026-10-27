using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265A RID: 9818
public class FocusModeToggle : UiPanelBase
{
	// Token: 0x0601416E RID: 82286 RVA: 0x00510664 File Offset: 0x0050E864
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

	// Token: 0x0601416F RID: 82287 RVA: 0x005106CD File Offset: 0x0050E8CD
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014170 RID: 82288 RVA: 0x005106E8 File Offset: 0x0050E8E8
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

	// Token: 0x06014171 RID: 82289 RVA: 0x00510724 File Offset: 0x0050E924
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

	// Token: 0x06014172 RID: 82290 RVA: 0x0051076B File Offset: 0x0050E96B
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

	// Token: 0x06014173 RID: 82291 RVA: 0x00510798 File Offset: 0x0050E998
	[NullableContext(1)]
	public void SetButtonText(string textTableId)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textTableId, Array.Empty<object>());
	}

	// Token: 0x06014174 RID: 82292 RVA: 0x005107B4 File Offset: 0x0050E9B4
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

	// Token: 0x04009776 RID: 38774
	private bool ManualSetToggleState;

	// Token: 0x02008C95 RID: 35989
	private class EChildComponent
	{
		// Token: 0x0402DA11 RID: 186897
		public const int Toggle = 0;

		// Token: 0x0402DA12 RID: 186898
		public const int ToggleText = 1;
	}
}
