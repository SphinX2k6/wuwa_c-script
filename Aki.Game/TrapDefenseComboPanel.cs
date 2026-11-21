using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011F7 RID: 4599
public class TrapDefenseComboPanel : BattleChildViewPanel
{
	// Token: 0x0600B6A2 RID: 46754 RVA: 0x0035F3EC File Offset: 0x0035D5EC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600B6A3 RID: 46755 RVA: 0x0035F448 File Offset: 0x0035D648
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.ComboNumSequence = new UiSequencePlayer(base.GetItem(2));
		this.DurationTime = (float)TrapDefenseConfig.Instance.GetTrapDefenseComboDuration();
		this.AdvancedPerformanceThreshold = (float)TrapDefenseConfig.Instance.GetTrapDefenseComboAdvancedPerformanceThreshold();
	}

	// Token: 0x0600B6A4 RID: 46756 RVA: 0x0035F49A File Offset: 0x0035D69A
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600B6A5 RID: 46757 RVA: 0x0035F4B0 File Offset: 0x0035D6B0
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseComboPanel.<OnBeforeHideAsync>d__9 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseComboPanel.<OnBeforeHideAsync>d__9>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6A6 RID: 46758 RVA: 0x0035F4F3 File Offset: 0x0035D6F3
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
		this.ComboNumSequence.Clear();
	}

	// Token: 0x0600B6A7 RID: 46759 RVA: 0x0035F50B File Offset: 0x0035D70B
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return this.RemainTime > 0f;
	}

	// Token: 0x0600B6A8 RID: 46760 RVA: 0x0035F51A File Offset: 0x0035D71A
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (this.RemainTime <= 0f)
		{
			return;
		}
		this.RemainTime -= delta;
		if (this.RemainTime <= 0f)
		{
			base.HideBattleChildViewPanel();
		}
	}

	// Token: 0x0600B6A9 RID: 46761 RVA: 0x0035F54C File Offset: 0x0035D74C
	public void RefreshComboNum(int comboNum)
	{
		base.GetArtText(0).SetText(comboNum.ToString());
		this.ComboNumSequence.PlaySequencePurely("Up", false, false);
		base.GetItem(1).SetUIActive((float)comboNum >= this.AdvancedPerformanceThreshold);
		this.RemainTime = this.DurationTime * (float)TimeUtil.Instance.InverseMillisecond;
		base.ShowBattleChildViewPanel();
	}

	// Token: 0x0600B6AA RID: 46762 RVA: 0x0035F5B5 File Offset: 0x0035D7B5
	public void HideComboPanel()
	{
		if (this.RemainTime > 0f)
		{
			this.RemainTime = 0f;
			base.HideBattleChildViewPanel();
		}
	}

	// Token: 0x0400699F RID: 27039
	protected float DurationTime;

	// Token: 0x040069A0 RID: 27040
	protected float RemainTime;

	// Token: 0x040069A1 RID: 27041
	protected float AdvancedPerformanceThreshold;

	// Token: 0x040069A2 RID: 27042
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x040069A3 RID: 27043
	[Nullable(1)]
	protected UiSequencePlayer ComboNumSequence;

	// Token: 0x020074C7 RID: 29895
	private static class EComponentDefine
	{
		// Token: 0x04025FE5 RID: 155621
		public const int ComboNum = 0;

		// Token: 0x04025FE6 RID: 155622
		public const int AdvancedPerformance = 1;

		// Token: 0x04025FE7 RID: 155623
		public const int ComboItem = 2;
	}
}
