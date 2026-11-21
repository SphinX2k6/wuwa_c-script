using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C01 RID: 7169
public class RacingBetsGearItem : GridProxyAbstract<RacingBettingGear>
{
	// Token: 0x06011D03 RID: 72963 RVA: 0x0053CB78 File Offset: 0x0053AD78
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

	// Token: 0x06011D04 RID: 72964 RVA: 0x0053CBF5 File Offset: 0x0053ADF5
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06011D05 RID: 72965 RVA: 0x0053CC1C File Offset: 0x0053AE1C
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

	// Token: 0x06011D06 RID: 72966 RVA: 0x0053CC8A File Offset: 0x0053AE8A
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelect(true);
	}

	// Token: 0x06011D07 RID: 72967 RVA: 0x0053CC93 File Offset: 0x0053AE93
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelect(false);
	}

	// Token: 0x06011D08 RID: 72968 RVA: 0x0053CC9C File Offset: 0x0053AE9C
	private void RefreshSelect(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011D09 RID: 72969 RVA: 0x0053CCB9 File Offset: 0x0053AEB9
	[NullableContext(1)]
	public void BindClickGearItemCallBack(Action<RacingBettingGear> clickGearItemCallBack)
	{
		this.ClickGearItemCallBack = clickGearItemCallBack;
	}

	// Token: 0x06011D0A RID: 72970 RVA: 0x0053CCC2 File Offset: 0x0053AEC2
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<RacingBettingGear> clickGearItemCallBack = this.ClickGearItemCallBack;
		if (clickGearItemCallBack == null)
		{
			return;
		}
		clickGearItemCallBack(this.Config);
	}

	// Token: 0x06011D0B RID: 72971 RVA: 0x0053CCDA File Offset: 0x0053AEDA
	private bool CanToggleExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x04009BA3 RID: 39843
	private RacingBettingGear Config;

	// Token: 0x04009BA4 RID: 39844
	[Nullable(2)]
	private Action<RacingBettingGear> ClickGearItemCallBack;

	// Token: 0x02007EF4 RID: 32500
	private class EComponent
	{
		// Token: 0x04029148 RID: 168264
		public const int Toggle = 0;

		// Token: 0x04029149 RID: 168265
		public const int PercentNormalText = 1;

		// Token: 0x0402914A RID: 168266
		public const int PercentSelectText = 2;
	}
}
