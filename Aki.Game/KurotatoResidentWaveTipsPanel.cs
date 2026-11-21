using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200117F RID: 4479
[NullableContext(1)]
[Nullable(0)]
public class KurotatoResidentWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600B29C RID: 45724 RVA: 0x0034CA54 File Offset: 0x0034AC54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600B29D RID: 45725 RVA: 0x0034CADC File Offset: 0x0034ACDC
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoResidentWaveTipsPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoResidentWaveTipsPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B29E RID: 45726 RVA: 0x0034CB1F File Offset: 0x0034AD1F
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B29F RID: 45727 RVA: 0x0034CB34 File Offset: 0x0034AD34
	protected override void OnBeforeShow()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = KurotatoModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnBatchUpdate));
		behaviorDelegate.AddTreeVarUpdateDelegate(EKurotatoSystemVarType.MaxBatch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnMaxBatchUpdate));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.TickEnabled = true;
		this.Refresh(false);
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x0600B2A0 RID: 45728 RVA: 0x0034CBB8 File Offset: 0x0034ADB8
	protected override void OnBeforeHide()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = KurotatoModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnBatchUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.MaxBatch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnMaxBatchUpdate));
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.TickEnabled = false;
		this.NeedTick = false;
	}

	// Token: 0x0600B2A1 RID: 45729 RVA: 0x0034CC2D File Offset: 0x0034AE2D
	public void ShowTips()
	{
		base.Show(null);
	}

	// Token: 0x0600B2A2 RID: 45730 RVA: 0x0034CC36 File Offset: 0x0034AE36
	public void HideTips()
	{
		base.Hide(null);
	}

	// Token: 0x0600B2A3 RID: 45731 RVA: 0x0034CC40 File Offset: 0x0034AE40
	public void OnTick(float delta)
	{
		if (!this.TickEnabled || !this.NeedTick)
		{
			return;
		}
		float num = 0.25f * delta;
		if (this.MoveLengthRecord - num < 0f)
		{
			num = this.MoveLengthRecord;
		}
		this.MoveLengthRecord -= num;
		if (this.MoveLengthRecord <= 0f)
		{
			this.NeedTick = false;
		}
		for (int i = 0; i < 12; i++)
		{
			KurotatoWavePointItem kurotatoWavePointItem = this.WavePointItems[i];
			kurotatoWavePointItem.GetRootItem().SetAnchorOffsetX(kurotatoWavePointItem.GetRootItem().GetAnchorOffsetX() - num);
		}
	}

	// Token: 0x0600B2A4 RID: 45732 RVA: 0x0034CCCC File Offset: 0x0034AECC
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "MoveLeft")
		{
			this.NeedTick = true;
			this.MoveLengthRecord = this.WavePointWidth;
		}
	}

	// Token: 0x0600B2A5 RID: 45733 RVA: 0x0034CCF0 File Offset: 0x0034AEF0
	private void OnBatchUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
		int num2 = (lastVarDefine != null) ? ((int)MathUtils.Instance.LongToNumber(lastVarDefine.Int)) : num;
		bool flag = num > num2;
		this.Refresh(flag);
		if (flag)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Move", false, null);
		}
	}

	// Token: 0x0600B2A6 RID: 45734 RVA: 0x0034CD50 File Offset: 0x0034AF50
	private void OnMaxBatchUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.Refresh(false);
	}

	// Token: 0x0600B2A7 RID: 45735 RVA: 0x0034CD5C File Offset: 0x0034AF5C
	private void Refresh(bool advanced)
	{
		KurotatoModel instance = KurotatoModel.Instance;
		bool isEndlessWave = instance.GetIsEndlessWave();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isEndlessWave ? "SurvivorsCombat_EndlessMode" : "SurvivorsCombat_WavePeriod", Array.Empty<object>());
		base.GetText(0).SetUIActive(!isEndlessWave);
		base.GetItem(2).SetUIActive(!isEndlessWave);
		if (isEndlessWave)
		{
			return;
		}
		int batch = instance.BattleData.GetBatch();
		int maxBatch = instance.BattleData.GetMaxBatch();
		UUIText text = base.GetText(0);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(batch);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxBatch);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		int curLevelId = instance.GetCurLevelId();
		List<KurotatoWave> waveByLevelId = KurotatoConfig.Instance.GetWaveByLevelId(curLevelId);
		bool flag = false;
		foreach (KurotatoWave kurotatoWave in waveByLevelId)
		{
			if (kurotatoWave.Wave == batch)
			{
				flag = (kurotatoWave.WaveType == 1);
				break;
			}
		}
		base.GetItem(4).SetUIActive(flag);
		base.GetText(0).SetUIActive(!flag);
		this.LayoutWavePoints(batch, maxBatch, advanced);
	}

	// Token: 0x0600B2A8 RID: 45736 RVA: 0x0034CEA4 File Offset: 0x0034B0A4
	private void LayoutWavePoints(int curWave, int maxBatch, bool advanced)
	{
		int num = curWave - 1;
		int num2 = Math.Max(0, 6 - num);
		int num3 = (advanced > false) ? 1 : 0;
		for (int i = 0; i < 12; i++)
		{
			UUIItem rootItem = this.WavePointItems[i].GetRootItem();
			if (i < num2)
			{
				rootItem.SetUIActive(false);
			}
			else
			{
				int num4 = i - num2;
				int num5 = num - (6 - num2) + num4;
				rootItem.SetUIActive(num5 < maxBatch);
				this.WavePointItems[i].SetLightVisible(num5 <= num);
				rootItem.SetAnchorOffsetX(this.WavePointWidth * (float)(num2 - 6 + num4 + num3));
			}
		}
	}

	// Token: 0x04006710 RID: 26384
	private const int WAVE_POINT_COUNT = 12;

	// Token: 0x04006711 RID: 26385
	private const int WAVE_POINT_CENTER_INDEX = 6;

	// Token: 0x04006712 RID: 26386
	private const float WAVE_POINT_MOVE_SPEED = 0.25f;

	// Token: 0x04006713 RID: 26387
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006714 RID: 26388
	private readonly KurotatoWavePointItem[] WavePointItems = new KurotatoWavePointItem[12];

	// Token: 0x04006715 RID: 26389
	private float WavePointWidth;

	// Token: 0x04006716 RID: 26390
	private bool NeedTick;

	// Token: 0x04006717 RID: 26391
	private float MoveLengthRecord;

	// Token: 0x04006718 RID: 26392
	private bool TickEnabled;

	// Token: 0x02007434 RID: 29748
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025D3A RID: 154938
		public const int TextWaveNum = 0;

		// Token: 0x04025D3B RID: 154939
		public const int TextWaveTitle = 1;

		// Token: 0x04025D3C RID: 154940
		public const int PanelDrag = 2;

		// Token: 0x04025D3D RID: 154941
		public const int PanelPoint = 3;

		// Token: 0x04025D3E RID: 154942
		public const int Texture = 4;
	}
}
