using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012E1 RID: 4833
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestPlotOption : UiPanelBase
{
	// Token: 0x0600BE7F RID: 48767 RVA: 0x003833A0 File Offset: 0x003815A0
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

	// Token: 0x0600BE80 RID: 48768 RVA: 0x00383410 File Offset: 0x00381610
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

	// Token: 0x0600BE81 RID: 48769 RVA: 0x00383440 File Offset: 0x00381640
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

	// Token: 0x0600BE82 RID: 48770 RVA: 0x003834B0 File Offset: 0x003816B0
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x0600BE83 RID: 48771 RVA: 0x003834C8 File Offset: 0x003816C8
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

	// Token: 0x0600BE84 RID: 48772 RVA: 0x0038356D File Offset: 0x0038176D
	public void BindClickToggleBack(TSelectedOpenCallback onClickToggle)
	{
		this.OnClickToggleBack = onClickToggle;
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x00383576 File Offset: 0x00381776
	private void OnToggleClick(EToggleState state)
	{
		if (this.OnClickToggleBack != null && state == EToggleState.ETT_Checked)
		{
			this.OnClickToggleBack(this.PlotId, this.TalkItemId, this.OptionIndex, this.Toggle);
		}
	}

	// Token: 0x04006DAA RID: 28074
	[Nullable(2)]
	public UUIExtendToggle Toggle;

	// Token: 0x04006DAB RID: 28075
	private int TalkItemId = -1;

	// Token: 0x04006DAC RID: 28076
	private int PlotId = -1;

	// Token: 0x04006DAD RID: 28077
	private int OptionIndex;

	// Token: 0x04006DAE RID: 28078
	[Nullable(2)]
	private TSelectedOpenCallback OnClickToggleBack;

	// Token: 0x04006DAF RID: 28079
	private HandBookDefine HandBookDefine = new HandBookDefine();
}
