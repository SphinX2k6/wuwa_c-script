using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012DE RID: 4830
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotTalkItem : UiPanelBase
{
	// Token: 0x0600BE75 RID: 48757 RVA: 0x0038312C File Offset: 0x0038132C
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

	// Token: 0x0600BE76 RID: 48758 RVA: 0x003831C0 File Offset: 0x003813C0
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

	// Token: 0x0600BE77 RID: 48759 RVA: 0x00383218 File Offset: 0x00381418
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

	// Token: 0x0600BE78 RID: 48760 RVA: 0x00383338 File Offset: 0x00381538
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

	// Token: 0x04006DA4 RID: 28068
	private bool IsPlayingAudio;

	// Token: 0x04006DA5 RID: 28069
	private PlotAudio? PlotAudio;
}
