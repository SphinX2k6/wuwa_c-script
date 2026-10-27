using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E1F RID: 7711
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestPlotOption : UiPanelBase
{
	// Token: 0x0600EA60 RID: 60000 RVA: 0x00377698 File Offset: 0x00375898
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600EA61 RID: 60001 RVA: 0x00377708 File Offset: 0x00375908
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(1);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleClick));
	}

	// Token: 0x0600EA62 RID: 60002 RVA: 0x00377738 File Offset: 0x00375938
	public void RefreshByOption(ITalkOption option, int plotId, int talkItemId, int index, bool isChoseOption)
	{
		this.PlotId = plotId;
		this.TalkItemId = talkItemId;
		this.OptionIndex = index;
		string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(option.TidTalkOption);
		string newText = PlotModel.Instance.PlotTextReplacer.Replace(flowConfigLocalText, false);
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		this.SetToggleState(isChoseOption ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked);
		this.SelectShow(isChoseOption);
	}

	// Token: 0x0600EA63 RID: 60003 RVA: 0x003777A8 File Offset: 0x003759A8
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600EA64 RID: 60004 RVA: 0x003777C0 File Offset: 0x003759C0
	public void SelectShow(bool isSelect)
	{
		if (isSelect)
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetColor(this.HandBookDefine.selectColor);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetAlpha(1f);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetColor(this.HandBookDefine.noSelectColor);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetAlpha(0f);
			}
			UUIItem item4 = base.GetItem(3);
			if (item4 == null)
			{
				return;
			}
			item4.SetAlpha(0f);
			return;
		}
	}

	// Token: 0x0600EA65 RID: 60005 RVA: 0x00377865 File Offset: 0x00375A65
	public void BindClickToggleBack(TSelectedOpenCallback onClickToggle)
	{
		this.OnClickToggleBack = onClickToggle;
	}

	// Token: 0x0600EA66 RID: 60006 RVA: 0x0037786E File Offset: 0x00375A6E
	private void OnToggleClick(EToggleState state)
	{
		if (this.OnClickToggleBack != null && state == EToggleState.ETT_Checked)
		{
			this.OnClickToggleBack(this.PlotId, this.TalkItemId, this.OptionIndex, this.Toggle);
		}
	}

	// Token: 0x04006CC9 RID: 27849
	[Nullable(2)]
	public UUIExtendToggle Toggle;

	// Token: 0x04006CCA RID: 27850
	private int TalkItemId = -1;

	// Token: 0x04006CCB RID: 27851
	private int PlotId = -1;

	// Token: 0x04006CCC RID: 27852
	private int OptionIndex;

	// Token: 0x04006CCD RID: 27853
	[Nullable(2)]
	private TSelectedOpenCallback OnClickToggleBack;

	// Token: 0x04006CCE RID: 27854
	private HandBookDefine HandBookDefine = new HandBookDefine();
}
