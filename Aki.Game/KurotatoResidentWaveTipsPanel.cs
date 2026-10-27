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

// Token: 0x02001CBD RID: 7357
[NullableContext(1)]
[Nullable(0)]
public class KurotatoResidentWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600DE7F RID: 56959 RVA: 0x0034102C File Offset: 0x0033F22C
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

	// Token: 0x0600DE80 RID: 56960 RVA: 0x003410B4 File Offset: 0x0033F2B4
	protected override UniTask OnBeforeStartAsync()
	{
		KurotatoResidentWaveTipsPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoResidentWaveTipsPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE81 RID: 56961 RVA: 0x003410F7 File Offset: 0x0033F2F7
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600DE82 RID: 56962 RVA: 0x0034110C File Offset: 0x0033F30C
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

	// Token: 0x0600DE83 RID: 56963 RVA: 0x00341190 File Offset: 0x0033F390
	protected override void OnBeforeHide()
	{
		BehaviorTreeUpdateDelegateProxy behaviorDelegate = KurotatoModel.Instance.BattleData.BehaviorDelegate;
		behaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.Batch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnBatchUpdate));
		behaviorDelegate.RemoveTreeVarUpdateDelegate(EKurotatoSystemVarType.MaxBatch.ToEnumString(), new TTreeVarUpdateDelegate(this.OnMaxBatchUpdate));
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		this.TickEnabled = false;
		this.NeedTick = false;
	}

	// Token: 0x0600DE84 RID: 56964 RVA: 0x00341205 File Offset: 0x0033F405
	public void ShowTips()
	{
		base.Show(null);
	}

	// Token: 0x0600DE85 RID: 56965 RVA: 0x0034120E File Offset: 0x0033F40E
	public void HideTips()
	{
		base.Hide(null);
	}

	// Token: 0x0600DE86 RID: 56966 RVA: 0x00341218 File Offset: 0x0033F418
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

	// Token: 0x0600DE87 RID: 56967 RVA: 0x003412A4 File Offset: 0x0033F4A4
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "MoveLeft")
		{
			this.NeedTick = true;
			this.MoveLengthRecord = this.WavePointWidth;
		}
	}

	// Token: 0x0600DE88 RID: 56968 RVA: 0x003412C8 File Offset: 0x0033F4C8
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

	// Token: 0x0600DE89 RID: 56969 RVA: 0x00341328 File Offset: 0x0033F528
	private void OnMaxBatchUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.Refresh(false);
	}

	// Token: 0x0600DE8A RID: 56970 RVA: 0x00341334 File Offset: 0x0033F534
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

	// Token: 0x0600DE8B RID: 56971 RVA: 0x0034147C File Offset: 0x0033F67C
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

	// Token: 0x04006631 RID: 26161
	private const int WAVE_POINT_COUNT = 12;

	// Token: 0x04006632 RID: 26162
	private const int WAVE_POINT_CENTER_INDEX = 6;

	// Token: 0x04006633 RID: 26163
	private const float WAVE_POINT_MOVE_SPEED = 0.25f;

	// Token: 0x04006634 RID: 26164
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006635 RID: 26165
	private readonly KurotatoWavePointItem[] WavePointItems = new KurotatoWavePointItem[12];

	// Token: 0x04006636 RID: 26166
	private float WavePointWidth;

	// Token: 0x04006637 RID: 26167
	private bool NeedTick;

	// Token: 0x04006638 RID: 26168
	private float MoveLengthRecord;

	// Token: 0x04006639 RID: 26169
	private bool TickEnabled;

	// Token: 0x020082AB RID: 33451
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA12 RID: 174610
		public const int TextWaveNum = 0;

		// Token: 0x0402AA13 RID: 174611
		public const int TextWaveTitle = 1;

		// Token: 0x0402AA14 RID: 174612
		public const int PanelDrag = 2;

		// Token: 0x0402AA15 RID: 174613
		public const int PanelPoint = 3;

		// Token: 0x0402AA16 RID: 174614
		public const int Texture = 4;
	}
}
