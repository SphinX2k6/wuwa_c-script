using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C45 RID: 7237
public class ReportRowView : GridProxyAbstract<ReportPlayerInfo>
{
	// Token: 0x06011F7A RID: 73594 RVA: 0x00548E6E File Offset: 0x0054706E
	public override void Refresh(ReportPlayerInfo data, bool isSelected, int gridIndex)
	{
		this.SetData(data);
		this.SetToggleState(isSelected);
	}

	// Token: 0x06011F7B RID: 73595 RVA: 0x00548E7E File Offset: 0x0054707E
	public override void OnSelected(bool fireEvent)
	{
		this.ToggleFunction(this.Id);
	}

	// Token: 0x06011F7C RID: 73596 RVA: 0x00548E94 File Offset: 0x00547094
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

	// Token: 0x06011F7D RID: 73597 RVA: 0x00548F01 File Offset: 0x00547101
	protected void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunction(this.Id);
			return;
		}
		this.ToggleFunction(-1);
	}

	// Token: 0x06011F7E RID: 73598 RVA: 0x00548F28 File Offset: 0x00547128
	public void SetData(ReportPlayerInfo data)
	{
		this.Id = data.Id;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, data.Reason, Array.Empty<object>());
	}

	// Token: 0x06011F7F RID: 73599 RVA: 0x00548F61 File Offset: 0x00547161
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06011F80 RID: 73600 RVA: 0x00548F6A File Offset: 0x0054716A
	public void SetToggleState(bool isChecked)
	{
		base.GetExtendToggle(1).SetToggleState(isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
	}

	// Token: 0x04009CAA RID: 40106
	[Nullable(2)]
	protected Action<int> ToggleFunction;

	// Token: 0x04009CAB RID: 40107
	public int Id;

	// Token: 0x02007F49 RID: 32585
	private static class EReportRowDefine
	{
		// Token: 0x0402932B RID: 168747
		public const int Describe = 0;

		// Token: 0x0402932C RID: 168748
		public const int Toggle = 1;
	}
}
