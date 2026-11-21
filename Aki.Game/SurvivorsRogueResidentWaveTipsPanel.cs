using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;

// Token: 0x020011E2 RID: 4578
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueResidentWaveTipsPanel : SurvivorsRogueTipsPanelBase
{
	// Token: 0x0600B5BF RID: 46527 RVA: 0x0035B70A File Offset: 0x0035990A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600B5C0 RID: 46528 RVA: 0x0035B743 File Offset: 0x00359943
	protected override void OnStart()
	{
		base.OnStart();
		this.WaveTitleText = base.GetText(0);
		this.WaveNumText = base.GetText(1);
	}

	// Token: 0x0600B5C1 RID: 46529 RVA: 0x0035B768 File Offset: 0x00359968
	protected override void OnAddEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.EndlessBatchLimit.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
	}

	// Token: 0x0600B5C2 RID: 46530 RVA: 0x0035B7C4 File Offset: 0x003599C4
	protected override void OnRemoveEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.EndlessBatchLimit.ToEnumString(), new TTreeVarUpdateDelegate(this.EventRefreshWave));
	}

	// Token: 0x0600B5C3 RID: 46531 RVA: 0x0035B81D File Offset: 0x00359A1D
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		this.RefreshWave();
	}

	// Token: 0x0600B5C4 RID: 46532 RVA: 0x0035B82B File Offset: 0x00359A2B
	private void EventRefreshWave(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshWave();
	}

	// Token: 0x0600B5C5 RID: 46533 RVA: 0x0035B834 File Offset: 0x00359A34
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

	// Token: 0x04006937 RID: 26935
	private UUIText WaveTitleText;

	// Token: 0x04006938 RID: 26936
	private UUIText WaveNumText;

	// Token: 0x020074A2 RID: 29858
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F47 RID: 155463
		public const int WaveTitle = 0;

		// Token: 0x04025F48 RID: 155464
		public const int WaveNum = 1;
	}
}
