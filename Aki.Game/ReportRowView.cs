using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200275A RID: 10074
public class ReportRowView : GridProxyAbstract<ReportPlayerInfo>
{
	// Token: 0x06014A97 RID: 84631 RVA: 0x00539FDA File Offset: 0x005381DA
	public override void Refresh(ReportPlayerInfo data, bool isSelected, int gridIndex)
	{
		this.SetData(data);
		this.SetToggleState(isSelected);
	}

	// Token: 0x06014A98 RID: 84632 RVA: 0x00539FEA File Offset: 0x005381EA
	public override void OnSelected(bool fireEvent)
	{
		this.ToggleFunction(this.Id);
	}

	// Token: 0x06014A99 RID: 84633 RVA: 0x0053A000 File Offset: 0x00538200
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x06014A9A RID: 84634 RVA: 0x0053A06D File Offset: 0x0053826D
	protected void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunction(this.Id);
			return;
		}
		this.ToggleFunction(-1);
	}

	// Token: 0x06014A9B RID: 84635 RVA: 0x0053A094 File Offset: 0x00538294
	public void SetData(ReportPlayerInfo data)
	{
		this.Id = data.Id;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, data.Reason, Array.Empty<object>());
	}

	// Token: 0x06014A9C RID: 84636 RVA: 0x0053A0CD File Offset: 0x005382CD
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06014A9D RID: 84637 RVA: 0x0053A0D6 File Offset: 0x005382D6
	public void SetToggleState(bool isChecked)
	{
		base.GetExtendToggle(1).SetToggleState(isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
	}

	// Token: 0x04009B51 RID: 39761
	[Nullable(2)]
	protected Action<int> ToggleFunction;

	// Token: 0x04009B52 RID: 39762
	public int Id;

	// Token: 0x02008DC0 RID: 36288
	private static class EReportRowDefine
	{
		// Token: 0x0402E014 RID: 188436
		public const int Describe = 0;

		// Token: 0x0402E015 RID: 188437
		public const int Toggle = 1;
	}
}
