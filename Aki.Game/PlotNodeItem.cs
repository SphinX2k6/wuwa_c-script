using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012DA RID: 4826
[NullableContext(1)]
[Nullable(0)]
public class PlotNodeItem : UiPanelBase
{
	// Token: 0x0600BE5F RID: 48735 RVA: 0x00382C44 File Offset: 0x00380E44
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickExtendToggle))
		};
	}

	// Token: 0x0600BE60 RID: 48736 RVA: 0x00382CC1 File Offset: 0x00380EC1
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600BE61 RID: 48737 RVA: 0x00382CE0 File Offset: 0x00380EE0
	private void OnClickExtendToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.OnCallBack != null)
		{
			this.OnCallBack(this.TidText, this.ExtendToggle);
		}
	}

	// Token: 0x0600BE62 RID: 48738 RVA: 0x00382D06 File Offset: 0x00380F06
	public void BindClickCallback(TSelectedCallback onClickCallback)
	{
		this.OnCallBack = onClickCallback;
	}

	// Token: 0x0600BE63 RID: 48739 RVA: 0x00382D10 File Offset: 0x00380F10
	public void Update(string data, bool isSelect)
	{
		this.TidText = data;
		string newText = PublicUtil.Instance.GetConfigTextByKey(data).Replace("{q_count}", "0").Replace("{q_countMax}", "-");
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		UUIExtendToggle extendToggle = this.ExtendToggle;
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600BE64 RID: 48740 RVA: 0x00382D7C File Offset: 0x00380F7C
	public string GetTidText()
	{
		return this.TidText;
	}

	// Token: 0x0600BE65 RID: 48741 RVA: 0x00382D84 File Offset: 0x00380F84
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = this.ExtendToggle;
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600BE66 RID: 48742 RVA: 0x00382D9A File Offset: 0x00380F9A
	public UUIExtendToggle GetNodeToggle()
	{
		return this.ExtendToggle;
	}

	// Token: 0x04006D92 RID: 28050
	[Nullable(2)]
	private TSelectedCallback OnCallBack;

	// Token: 0x04006D93 RID: 28051
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04006D94 RID: 28052
	private string TidText = "";
}
