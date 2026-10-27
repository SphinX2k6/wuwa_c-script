using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E1C RID: 7708
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotTalkItem : UiPanelBase
{
	// Token: 0x0600EA56 RID: 59990 RVA: 0x00377424 File Offset: 0x00375624
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnPlayToggleClick))
		};
	}

	// Token: 0x0600EA57 RID: 59991 RVA: 0x003774B8 File Offset: 0x003756B8
	private void OnPlayToggleClick(EToggleState state)
	{
		if (this.PlotAudio == null)
		{
			return;
		}
		if (!this.IsPlayingAudio)
		{
			HandBookQuestPlotTalkAudioUtil.PlayAudio(this.PlotAudio.Value, new Action<string>(this.OnAudioPlayEnd));
		}
		else
		{
			HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
		}
		this.IsPlayingAudio = !this.IsPlayingAudio;
	}

	// Token: 0x0600EA58 RID: 59992 RVA: 0x00377510 File Offset: 0x00375710
	public void Refresh(string nameText, string constantText, PlotAudio? audio)
	{
		this.PlotAudio = audio;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(nameText ?? "", true);
		}
		string text2 = PlotModel.Instance.PlotTextReplacer.Replace(constantText, false);
		UUIText text3 = base.GetText(1);
		if (text3 != null)
		{
			text3.SetText(text2 ?? "", true);
		}
		bool havePlot = (this.PlotAudio != null) > false;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(havePlot);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Bind(() => havePlot);
		}
		this.IsPlayingAudio = (havePlot && HandBookQuestPlotTalkAudioUtil.IsPlayingAudio((this.PlotAudio != null) ? this.PlotAudio.GetValueOrDefault().Id : null));
		if (this.IsPlayingAudio)
		{
			HandBookQuestPlotTalkAudioUtil.ResetPlayEndCallBack(new Action<string>(this.OnAudioPlayEnd));
		}
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(this.IsPlayingAudio ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EA59 RID: 59993 RVA: 0x00377630 File Offset: 0x00375830
	private void OnAudioPlayEnd(string nextPlayingAudio = null)
	{
		if (nextPlayingAudio != null && nextPlayingAudio == ((this.PlotAudio != null) ? this.PlotAudio.GetValueOrDefault().Id : null))
		{
			return;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.IsPlayingAudio = false;
	}

	// Token: 0x04006CC3 RID: 27843
	private bool IsPlayingAudio;

	// Token: 0x04006CC4 RID: 27844
	private PlotAudio? PlotAudio;
}
