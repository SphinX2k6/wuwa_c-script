using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D35 RID: 7477
public class TrapDefenseComboPanel : BattleChildViewPanel
{
	// Token: 0x0600E285 RID: 57989 RVA: 0x003539BC File Offset: 0x00351BBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600E286 RID: 57990 RVA: 0x00353A18 File Offset: 0x00351C18
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.ComboNumSequence = new UiSequencePlayer(base.GetItem(2));
		this.DurationTime = (float)TrapDefenseConfig.Instance.GetTrapDefenseComboDuration();
		this.AdvancedPerformanceThreshold = (float)TrapDefenseConfig.Instance.GetTrapDefenseComboAdvancedPerformanceThreshold();
	}

	// Token: 0x0600E287 RID: 57991 RVA: 0x00353A6A File Offset: 0x00351C6A
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600E288 RID: 57992 RVA: 0x00353A80 File Offset: 0x00351C80
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseComboPanel.<OnBeforeHideAsync>d__9 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseComboPanel.<OnBeforeHideAsync>d__9>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E289 RID: 57993 RVA: 0x00353AC3 File Offset: 0x00351CC3
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
		this.ComboNumSequence.Clear();
	}

	// Token: 0x0600E28A RID: 57994 RVA: 0x00353ADB File Offset: 0x00351CDB
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return this.RemainTime > 0f;
	}

	// Token: 0x0600E28B RID: 57995 RVA: 0x00353AEA File Offset: 0x00351CEA
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

	// Token: 0x0600E28C RID: 57996 RVA: 0x00353B1C File Offset: 0x00351D1C
	public void RefreshComboNum(int comboNum)
	{
		base.GetArtText(0).SetText(comboNum.ToString());
		this.ComboNumSequence.PlaySequencePurely("Up", false, false);
		base.GetItem(1).SetUIActive((float)comboNum >= this.AdvancedPerformanceThreshold);
		this.RemainTime = this.DurationTime * (float)TimeUtil.Instance.InverseMillisecond;
		base.ShowBattleChildViewPanel();
	}

	// Token: 0x0600E28D RID: 57997 RVA: 0x00353B85 File Offset: 0x00351D85
	public void HideComboPanel()
	{
		if (this.RemainTime > 0f)
		{
			this.RemainTime = 0f;
			base.HideBattleChildViewPanel();
		}
	}

	// Token: 0x040068C0 RID: 26816
	protected float DurationTime;

	// Token: 0x040068C1 RID: 26817
	protected float RemainTime;

	// Token: 0x040068C2 RID: 26818
	protected float AdvancedPerformanceThreshold;

	// Token: 0x040068C3 RID: 26819
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x040068C4 RID: 26820
	[Nullable(1)]
	protected UiSequencePlayer ComboNumSequence;

	// Token: 0x0200833E RID: 33598
	private static class EComponentDefine
	{
		// Token: 0x0402ACBD RID: 175293
		public const int ComboNum = 0;

		// Token: 0x0402ACBE RID: 175294
		public const int AdvancedPerformance = 1;

		// Token: 0x0402ACBF RID: 175295
		public const int ComboItem = 2;
	}
}
