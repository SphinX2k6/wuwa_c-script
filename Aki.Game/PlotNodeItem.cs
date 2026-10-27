using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E18 RID: 7704
[NullableContext(1)]
[Nullable(0)]
public class PlotNodeItem : UiPanelBase
{
	// Token: 0x0600EA40 RID: 59968 RVA: 0x00376F3C File Offset: 0x0037513C
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

	// Token: 0x0600EA41 RID: 59969 RVA: 0x00376FB9 File Offset: 0x003751B9
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EA42 RID: 59970 RVA: 0x00376FD8 File Offset: 0x003751D8
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

	// Token: 0x0600EA43 RID: 59971 RVA: 0x00376FFE File Offset: 0x003751FE
	public void BindClickCallback(TSelectedCallback onClickCallback)
	{
		this.OnCallBack = onClickCallback;
	}

	// Token: 0x0600EA44 RID: 59972 RVA: 0x00377008 File Offset: 0x00375208
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

	// Token: 0x0600EA45 RID: 59973 RVA: 0x00377074 File Offset: 0x00375274
	public string GetTidText()
	{
		return this.TidText;
	}

	// Token: 0x0600EA46 RID: 59974 RVA: 0x0037707C File Offset: 0x0037527C
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = this.ExtendToggle;
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600EA47 RID: 59975 RVA: 0x00377092 File Offset: 0x00375292
	public UUIExtendToggle GetNodeToggle()
	{
		return this.ExtendToggle;
	}

	// Token: 0x04006CB1 RID: 27825
	[Nullable(2)]
	private TSelectedCallback OnCallBack;

	// Token: 0x04006CB2 RID: 27826
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04006CB3 RID: 27827
	private string TidText = "";
}
