using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;

// Token: 0x02001D20 RID: 7456
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueResidentWaveTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600E1A2 RID: 57762 RVA: 0x0034FCDA File Offset: 0x0034DEDA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600E1A3 RID: 57763 RVA: 0x0034FD13 File Offset: 0x0034DF13
	protected override void OnStart()
	{
		base.OnStart();
		this.WaveTitleText = base.GetText(0);
		this.WaveNumText = base.GetText(1);
	}

	// Token: 0x0600E1A4 RID: 57764 RVA: 0x0034FD38 File Offset: 0x0034DF38
	protected override void OnAddEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.EndlessBatchLimit.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
	}

	// Token: 0x0600E1A5 RID: 57765 RVA: 0x0034FD94 File Offset: 0x0034DF94
	protected override void OnRemoveEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.EndlessBatchLimit.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
	}

	// Token: 0x0600E1A6 RID: 57766 RVA: 0x0034FDED File Offset: 0x0034DFED
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.RefreshWave();
	}

	// Token: 0x0600E1A7 RID: 57767 RVA: 0x0034FDFB File Offset: 0x0034DFFB
	private void EventRefreshWave(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshWave();
	}

	// Token: 0x0600E1A8 RID: 57768 RVA: 0x0034FE04 File Offset: 0x0034E004
	private void RefreshWave()
	{
		bool isEndlessWave = SurvivorsRogueModel.Instance.IsEndlessWave;
		LguiUtil.Instance.SetLocalTextNew(this.WaveTitleText, isEndlessWave ? "SurvivorsCombat_EndlessMode" : "SurvivorsCombat_WavePeriod", Array.Empty<object>());
		if (isEndlessWave)
		{
			this.WaveNumText.SetUIActive(false);
			return;
		}
		this.WaveNumText.SetUIActive(true);
		this.WaveNumText.SetText(SurvivorsRogueModel.Instance.BattleData.GetBatch().ToString() + "/" + SurvivorsRogueModel.Instance.MaxWaveNum.ToString(), true);
	}

	// Token: 0x04006858 RID: 26712
	private UUIText WaveTitleText;

	// Token: 0x04006859 RID: 26713
	private UUIText WaveNumText;

	// Token: 0x02008319 RID: 33561
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC1F RID: 175135
		public const int WaveTitle = 0;

		// Token: 0x0402AC20 RID: 175136
		public const int WaveNum = 1;
	}
}
