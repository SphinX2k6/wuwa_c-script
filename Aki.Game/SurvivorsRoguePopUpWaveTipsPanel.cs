using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011E1 RID: 4577
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoguePopUpWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600B5AF RID: 46511 RVA: 0x0035B2A8 File Offset: 0x003594A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600B5B0 RID: 46512 RVA: 0x0035B304 File Offset: 0x00359504
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRoguePopUpWaveTipsPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRoguePopUpWaveTipsPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B5B1 RID: 46513 RVA: 0x0035B347 File Offset: 0x00359547
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

	// Token: 0x0600B5B2 RID: 46514 RVA: 0x0035B385 File Offset: 0x00359585
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.TickEnabled = true;
	}

	// Token: 0x0600B5B3 RID: 46515 RVA: 0x0035B394 File Offset: 0x00359594
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		this.TickEnabled = false;
	}

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x0035B3A4 File Offset: 0x003595A4
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B5B5 RID: 46517 RVA: 0x0035B400 File Offset: 0x00359600
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B5B6 RID: 46518 RVA: 0x0035B45C File Offset: 0x0035965C
	public void ShowWaveTips()
	{
		base.Show(null);
		this.InitWavePointItem();
		this.WaveNumText.SetText(SurvivorsRogueModel.Instance.CurWaveNum.ToString(), true);
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B5B7 RID: 46519 RVA: 0x0035B4B0 File Offset: 0x003596B0
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

	// Token: 0x0600B5B8 RID: 46520 RVA: 0x0035B523 File Offset: 0x00359723
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.PauseSequence();
		}
	}

	// Token: 0x0600B5B9 RID: 46521 RVA: 0x0035B53D File Offset: 0x0035973D
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.ResumeSequence();
		}
	}

	// Token: 0x0600B5BA RID: 46522 RVA: 0x0035B558 File Offset: 0x00359758
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

	// Token: 0x0600B5BB RID: 46523 RVA: 0x0035B5F8 File Offset: 0x003597F8
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

	// Token: 0x0400692D RID: 26925
	private const int WAVE_POINT_COUNT = 12;

	// Token: 0x0400692E RID: 26926
	private const int WAVE_POINT_START_INDEX = 6;

	// Token: 0x0400692F RID: 26927
	private const float WAVE_POINT_MOVE_SPEED = 0.25f;

	// Token: 0x04006930 RID: 26928
	private UUIText WaveNumText;

	// Token: 0x04006931 RID: 26929
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006932 RID: 26930
	private readonly SurvivorsRogueWavePointItem[] WavePointItems = new SurvivorsRogueWavePointItem[12];

	// Token: 0x04006933 RID: 26931
	private bool NeedTick;

	// Token: 0x04006934 RID: 26932
	private float MoveLengthRecord;

	// Token: 0x04006935 RID: 26933
	private float WavePointWidth;

	// Token: 0x04006936 RID: 26934
	private bool TickEnabled;

	// Token: 0x020074A0 RID: 29856
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F3F RID: 155455
		public const int WavePointRoot = 0;

		// Token: 0x04025F40 RID: 155456
		public const int WavePointTemplate = 1;

		// Token: 0x04025F41 RID: 155457
		public const int WaveNum = 2;
	}
}
