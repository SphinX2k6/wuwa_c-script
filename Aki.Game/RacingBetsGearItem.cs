using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002716 RID: 10006
public class RacingBetsGearItem : GridProxyAbstract<RacingBettingGear>
{
	// Token: 0x06014821 RID: 84001 RVA: 0x0052DE5C File Offset: 0x0052C05C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06014822 RID: 84002 RVA: 0x0052DED9 File Offset: 0x0052C0D9
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06014823 RID: 84003 RVA: 0x0052DF00 File Offset: 0x0052C100
	public override void Refresh(RacingBettingGear data, bool isSelected, int gridIndex)
	{
		this.Config = data;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Odds);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(newText, true);
		}
		this.RefreshSelect(isSelected);
	}

	// Token: 0x06014824 RID: 84004 RVA: 0x0052DF6E File Offset: 0x0052C16E
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelect(true);
	}

	// Token: 0x06014825 RID: 84005 RVA: 0x0052DF77 File Offset: 0x0052C177
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelect(false);
	}

	// Token: 0x06014826 RID: 84006 RVA: 0x0052DF80 File Offset: 0x0052C180
	private void RefreshSelect(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014827 RID: 84007 RVA: 0x0052DF9D File Offset: 0x0052C19D
	[NullableContext(1)]
	public void BindClickGearItemCallBack(Action<RacingBettingGear> clickGearItemCallBack)
	{
		this.ClickGearItemCallBack = clickGearItemCallBack;
	}

	// Token: 0x06014828 RID: 84008 RVA: 0x0052DFA6 File Offset: 0x0052C1A6
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<RacingBettingGear> clickGearItemCallBack = this.ClickGearItemCallBack;
		if (clickGearItemCallBack == null)
		{
			return;
		}
		clickGearItemCallBack(this.Config);
	}

	// Token: 0x06014829 RID: 84009 RVA: 0x0052DFBE File Offset: 0x0052C1BE
	private bool CanToggleExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x04009A4B RID: 39499
	private RacingBettingGear Config;

	// Token: 0x04009A4C RID: 39500
	[Nullable(2)]
	private Action<RacingBettingGear> ClickGearItemCallBack;

	// Token: 0x02008D6B RID: 36203
	private class EComponent
	{
		// Token: 0x0402DE31 RID: 187953
		public const int Toggle = 0;

		// Token: 0x0402DE32 RID: 187954
		public const int PercentNormalText = 1;

		// Token: 0x0402DE33 RID: 187955
		public const int PercentSelectText = 2;
	}
}
