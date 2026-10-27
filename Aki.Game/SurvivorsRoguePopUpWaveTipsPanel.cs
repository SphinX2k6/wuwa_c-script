using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D1F RID: 7455
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoguePopUpWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600E192 RID: 57746 RVA: 0x0034F878 File Offset: 0x0034DA78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600E193 RID: 57747 RVA: 0x0034F8D4 File Offset: 0x0034DAD4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRoguePopUpWaveTipsPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRoguePopUpWaveTipsPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E194 RID: 57748 RVA: 0x0034F917 File Offset: 0x0034DB17
	protected override void OnStart()
	{
		base.OnStart();
		this.WaveNumText = base.GetText(2);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.SequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
				return;
			}
			if (sequenceName == "Close")
			{
				this.WavePointItems[6].PlayResetSequence();
				SurvivorsRogueController.Instance.RequestEnterStep(ESurvivorsStepType.Prepare);
			}
		}, false);
	}

	// Token: 0x0600E195 RID: 57749 RVA: 0x0034F955 File Offset: 0x0034DB55
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.TickEnabled = true;
	}

	// Token: 0x0600E196 RID: 57750 RVA: 0x0034F964 File Offset: 0x0034DB64
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		this.TickEnabled = false;
	}

	// Token: 0x0600E197 RID: 57751 RVA: 0x0034F974 File Offset: 0x0034DB74
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E198 RID: 57752 RVA: 0x0034F9D0 File Offset: 0x0034DBD0
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E199 RID: 57753 RVA: 0x0034FA2C File Offset: 0x0034DC2C
	public void ShowWaveTips()
	{
		base.Show(null);
		this.InitWavePointItem();
		this.WaveNumText.SetText(SurvivorsRogueModel.Instance.CurWaveNum.ToString(), true);
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600E19A RID: 57754 RVA: 0x0034FA80 File Offset: 0x0034DC80
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "TipsShow")
		{
			if (SurvivorsRogueModel.Instance.IsEndlessWave)
			{
				EventSystem.Instance.Emit(EEventName.SurvivorsRogueShowEndlessWaveTips);
			}
			if (SurvivorsRogueModel.Instance.IsBonusWave)
			{
				EventSystem.Instance.Emit(EEventName.SurvivorsRogueShowBonusWaveTips);
				return;
			}
		}
		else if (param == "MoveLeft")
		{
			this.NeedTick = true;
			this.MoveLengthRecord = this.WavePointWidth;
		}
	}

	// Token: 0x0600E19B RID: 57755 RVA: 0x0034FAF3 File Offset: 0x0034DCF3
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.PauseSequence();
		}
	}

	// Token: 0x0600E19C RID: 57756 RVA: 0x0034FB0D File Offset: 0x0034DD0D
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.ResumeSequence();
		}
	}

	// Token: 0x0600E19D RID: 57757 RVA: 0x0034FB28 File Offset: 0x0034DD28
	public void InitWavePointItem()
	{
		int num = SurvivorsRogueModel.Instance.CurWaveNum - 1;
		int num2 = Math.Max(0, 6 - num);
		int num3 = 0;
		for (int i = 0; i < 12; i++)
		{
			SurvivorsRogueWavePointItem survivorsRogueWavePointItem = this.WavePointItems[i];
			if (i < num2)
			{
				survivorsRogueWavePointItem.Hide(null);
			}
			else
			{
				int num4 = num + num3 - (6 - num2);
				if (num4 >= SurvivorsRogueModel.Instance.MaxWaveNum)
				{
					survivorsRogueWavePointItem.Hide(null);
				}
				else
				{
					survivorsRogueWavePointItem.SetState((EWaveType)SurvivorsRogueModel.Instance.WaveTypeArray[num4]);
				}
				survivorsRogueWavePointItem.GetRootItem().SetAnchorOffsetX(this.WavePointWidth * (float)(num2 - 6 + num3 + 1));
				num3++;
			}
		}
	}

	// Token: 0x0600E19E RID: 57758 RVA: 0x0034FBC8 File Offset: 0x0034DDC8
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
			this.WavePointItems[6].PlayBubbleSequence();
		}
		for (int i = 0; i < 12; i++)
		{
			SurvivorsRogueWavePointItem survivorsRogueWavePointItem = this.WavePointItems[i];
			survivorsRogueWavePointItem.GetRootItem().SetAnchorOffsetX(survivorsRogueWavePointItem.GetRootItem().GetAnchorOffsetX() - num);
		}
	}

	// Token: 0x0400684E RID: 26702
	private const int WAVE_POINT_COUNT = 12;

	// Token: 0x0400684F RID: 26703
	private const int WAVE_POINT_START_INDEX = 6;

	// Token: 0x04006850 RID: 26704
	private const float WAVE_POINT_MOVE_SPEED = 0.25f;

	// Token: 0x04006851 RID: 26705
	private UUIText WaveNumText;

	// Token: 0x04006852 RID: 26706
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006853 RID: 26707
	private readonly SurvivorsRogueWavePointItem[] WavePointItems = new SurvivorsRogueWavePointItem[12];

	// Token: 0x04006854 RID: 26708
	private bool NeedTick;

	// Token: 0x04006855 RID: 26709
	private float MoveLengthRecord;

	// Token: 0x04006856 RID: 26710
	private float WavePointWidth;

	// Token: 0x04006857 RID: 26711
	private bool TickEnabled;

	// Token: 0x02008317 RID: 33559
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC17 RID: 175127
		public const int WavePointRoot = 0;

		// Token: 0x0402AC18 RID: 175128
		public const int WavePointTemplate = 1;

		// Token: 0x0402AC19 RID: 175129
		public const int WaveNum = 2;
	}
}
