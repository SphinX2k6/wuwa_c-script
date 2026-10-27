using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001107 RID: 4359
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteView : UiTickViewBase
{
	// Token: 0x060071AF RID: 29103 RVA: 0x001741CE File Offset: 0x001723CE
	public ArtemisQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x001741D8 File Offset: 0x001723D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickFishButton))
		};
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x00174258 File Offset: 0x00172458
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x0017429B File Offset: 0x0017249B
	protected override void OnBeforeShow()
	{
		this.PlayAnim(this.ViewSequencePlayer, "Start");
		ArtemisQteProgressItem progressItem = this.ProgressItem;
		if (progressItem == null)
		{
			return;
		}
		progressItem.PlayAnim("Start");
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x001742C4 File Offset: 0x001724C4
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		ArtemisQteView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ArtemisQteView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x00174307 File Offset: 0x00172507
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnArtemisQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x00174325 File Offset: 0x00172525
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnArtemisQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
	}

	// Token: 0x060071B6 RID: 29110 RVA: 0x00174343 File Offset: 0x00172543
	protected override void OnStart()
	{
		this.Init();
		ArtemisQteProgressItem progressItem = this.ProgressItem;
		if (progressItem != null)
		{
			progressItem.InitRing();
		}
		ArtemisQteClickTipsItem tipsItem = this.TipsItem;
		if (tipsItem == null)
		{
			return;
		}
		tipsItem.SetActive(false);
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x0017436D File Offset: 0x0017256D
	private void Init()
	{
		this.GameInfo.SetGameStage(EArtemisQteStage.Ready);
		this.GameInfo.GetRingInfo().EnterNextValidArea();
		this.SetGameStart();
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x00174391 File Offset: 0x00172591
	protected override void OnBeforeDestroy()
	{
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
		if (viewSequencePlayer != null)
		{
			viewSequencePlayer.Clear();
		}
		this.ViewSequencePlayer = null;
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x001743BC File Offset: 0x001725BC
	protected override void OnTick(float delta)
	{
		ArtemisQteProgressItem progressItem = this.ProgressItem;
		if (progressItem != null)
		{
			progressItem.OnTick(delta);
		}
		if (this.GameInfo.IsGamePause())
		{
			return;
		}
		float num = delta / 1000f;
		this.GameInfo.CurrentScore += (int)((float)this.ScoreUp * num);
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		int num2 = (currentPlayConfig != null) ? currentPlayConfig.GetValueOrDefault().MaxScore : 0;
		if (this.GameInfo.CurrentScore >= num2)
		{
			this.EnterNextRound();
		}
	}

	// Token: 0x060071BA RID: 29114 RVA: 0x00174444 File Offset: 0x00172644
	private void EnterNextRound()
	{
		this.GameInfo.CurrentRound = Math.Min(this.GameInfo.CurrentRound + 1, this.GameInfo.MaxRound);
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		if (this.GameInfo.CurrentRound != this.GameInfo.MaxRound)
		{
			this.GameInfo.CurrentScore -= currentPlayConfig.Value.MaxScore;
		}
		else
		{
			this.GameInfo.SetGameStage(EArtemisQteStage.End);
		}
		this.ProgressItem.EnterNextRound();
		if (this.GameInfo.CurrentRound == this.GameInfo.MaxRound)
		{
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.SetGameEnd();
			}, 800f, null, null, true, 1f);
		}
	}

	// Token: 0x060071BB RID: 29115 RVA: 0x0017450E File Offset: 0x0017270E
	private void OnFishingQteAreaChange(int areaRelativeIndex)
	{
		this.ProgressItem.OnArrowStayAreaUpdate(areaRelativeIndex);
	}

	// Token: 0x060071BC RID: 29116 RVA: 0x0017451C File Offset: 0x0017271C
	private void OnClickFishButton()
	{
		if (this.GameInfo.IsGamePause())
		{
			return;
		}
		ArtemisQteRingInfo ringInfo = this.GameInfo.GetRingInfo();
		int currentArrowStayCellIndex = ringInfo.CurrentArrowStayCellIndex;
		ContinuousRingArea continuousRingArea = ringInfo.CheckInArea(ringInfo.GetPerfectAreas(), currentArrowStayCellIndex);
		if (continuousRingArea != null)
		{
			this.OnAreaClick(EArtemisAreaType.PerfectArea, continuousRingArea);
			return;
		}
		ContinuousRingArea continuousRingArea2 = ringInfo.CheckInArea(ringInfo.GetQteAreas(), currentArrowStayCellIndex);
		if (continuousRingArea2 != null)
		{
			this.OnAreaClick(EArtemisAreaType.QteArea, continuousRingArea2);
			return;
		}
		this.OnAreaClick(EArtemisAreaType.BlankArea, null);
	}

	// Token: 0x060071BD RID: 29117 RVA: 0x00174586 File Offset: 0x00172786
	private void SetGameStart()
	{
		this.GameInfo.SetGameStage(EArtemisQteStage.OnGoing);
	}

	// Token: 0x060071BE RID: 29118 RVA: 0x00174594 File Offset: 0x00172794
	private void SetGameEnd()
	{
		base.CloseMe(null);
		ArtemisQteViewParams artemisQteViewParams = this.OpenParam as ArtemisQteViewParams;
		if (artemisQteViewParams == null)
		{
			return;
		}
		artemisQteViewParams.CallBack();
	}

	// Token: 0x060071BF RID: 29119 RVA: 0x001745B8 File Offset: 0x001727B8
	[NullableContext(2)]
	private void OnAreaClick(EArtemisAreaType areaType, ContinuousRingArea area)
	{
		this.ProgressItem.OnAreaClick(areaType, area);
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		int num = (currentPlayConfig != null) ? currentPlayConfig.GetValueOrDefault().MaxScore : 0;
		switch (areaType)
		{
		case EArtemisAreaType.BlankArea:
		{
			this.PlayAnim(this.ViewSequencePlayer, "Miss");
			this.OnMissOn();
			ArtemisQteClickTipsItem tipsItem = this.TipsItem;
			if (tipsItem == null)
			{
				return;
			}
			tipsItem.ShowTip(EArtemisTipsType.Miss);
			return;
		}
		case EArtemisAreaType.QteArea:
		{
			this.ProgressItem.StartAnimProgress();
			this.PlayAnim(this.ViewSequencePlayer, "Success");
			this.OnQteOn();
			ArtemisQteRingInfo ringInfo = this.GameInfo.GetRingInfo();
			if (!ringInfo.IsWholeRing)
			{
				ringInfo.EnterNextValidArea();
			}
			if (this.GameInfo.CurrentScore < num && area != null)
			{
				this.ProgressItem.SpawnContinuousArea(area.ContinuousIndex, EArtemisAreaType.QteArea);
			}
			ArtemisQteClickTipsItem tipsItem2 = this.TipsItem;
			if (tipsItem2 == null)
			{
				return;
			}
			tipsItem2.ShowTip(EArtemisTipsType.None);
			return;
		}
		case EArtemisAreaType.PerfectArea:
		{
			this.ProgressItem.StartAnimProgress();
			this.PlayAnim(this.ViewSequencePlayer, "Perfect");
			this.OnPerfectOn();
			ArtemisQteRingInfo ringInfo2 = this.GameInfo.GetRingInfo();
			if (!ringInfo2.IsWholeRing)
			{
				ringInfo2.EnterNextValidArea();
			}
			if (this.GameInfo.CurrentScore < num && area != null)
			{
				this.ProgressItem.SpawnContinuousArea(area.ContinuousIndex, EArtemisAreaType.PerfectArea);
			}
			ArtemisQteClickTipsItem tipsItem3 = this.TipsItem;
			if (tipsItem3 == null)
			{
				return;
			}
			tipsItem3.ShowTip(EArtemisTipsType.Perfect);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x060071C0 RID: 29120 RVA: 0x00174718 File Offset: 0x00172918
	private void PlayAnim([Nullable(2)] LevelSequencePlayer player, string sequenceName)
	{
		if (player == null)
		{
			return;
		}
		if (player.GetCurrentSequence() == sequenceName)
		{
			player.ReplaySequenceByKey(sequenceName);
			return;
		}
		player.StopPlayingSequence(false, true);
		player.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x17000996 RID: 2454
	// (get) Token: 0x060071C1 RID: 29121 RVA: 0x00174759 File Offset: 0x00172959
	public int GetCurrentGameplayId
	{
		get
		{
			return this.CurrentGameplayId;
		}
	}

	// Token: 0x060071C2 RID: 29122 RVA: 0x00174761 File Offset: 0x00172961
	public bool GameplayStart(int configId, int maxRound)
	{
		this.CurrentGameplayId = configId;
		return this.InitialGameInfo(maxRound);
	}

	// Token: 0x060071C3 RID: 29123 RVA: 0x00174771 File Offset: 0x00172971
	public ArtemisQte? GetCurrentPlayConfig()
	{
		return ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.CurrentGameplayId);
	}

	// Token: 0x060071C4 RID: 29124 RVA: 0x00174784 File Offset: 0x00172984
	private bool InitialGameInfo(int maxRound)
	{
		if (this.GameInfo == null)
		{
			this.GameInfo = new ArtemisQteGameInfo();
		}
		this.GameInfo.Clear();
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		EArrowDirection arrowDirection = (currentPlayConfig != null && currentPlayConfig.GetValueOrDefault().IsAnticlockwise) ? EArrowDirection.Anticlockwise : EArrowDirection.Clockwise;
		this.GameInfo.CreateRingInfo(arrowDirection);
		this.GameInfo.MaxRound = maxRound;
		int num = (currentPlayConfig != null) ? currentPlayConfig.GetValueOrDefault().InvalidAreaLength : 0;
		this.GameInfo.GetRingInfo().IsWholeRing = (num == 0);
		this.AccumulatePerfectCombo = 0;
		return true;
	}

	// Token: 0x17000997 RID: 2455
	// (get) Token: 0x060071C5 RID: 29125 RVA: 0x00174828 File Offset: 0x00172A28
	public int ScoreUp
	{
		get
		{
			ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
			if (currentPlayConfig != null)
			{
				return currentPlayConfig.Value.ScoreUp;
			}
			return 0;
		}
	}

	// Token: 0x17000998 RID: 2456
	// (get) Token: 0x060071C6 RID: 29126 RVA: 0x00174858 File Offset: 0x00172A58
	public int HitAreaScore
	{
		get
		{
			ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
			if (currentPlayConfig != null)
			{
				return currentPlayConfig.Value.HitAreaScore;
			}
			return 0;
		}
	}

	// Token: 0x17000999 RID: 2457
	// (get) Token: 0x060071C7 RID: 29127 RVA: 0x00174888 File Offset: 0x00172A88
	public int PerfectScore
	{
		get
		{
			ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
			if (currentPlayConfig != null)
			{
				return currentPlayConfig.Value.PerfectScore;
			}
			return 0;
		}
	}

	// Token: 0x1700099A RID: 2458
	// (get) Token: 0x060071C8 RID: 29128 RVA: 0x001748B6 File Offset: 0x00172AB6
	// (set) Token: 0x060071C9 RID: 29129 RVA: 0x001748BE File Offset: 0x00172ABE
	protected int AccumulatePerfectCombo
	{
		get
		{
			return this.AccumulatePerfectComboInternal;
		}
		set
		{
			this.AccumulatePerfectComboInternal = value;
			this.RefreshAccumulatePerfectCombo();
		}
	}

	// Token: 0x060071CA RID: 29130 RVA: 0x001748D0 File Offset: 0x00172AD0
	public void OnQteOn()
	{
		this.GameInfo.CurrentScore += this.HitAreaScore;
		int accumulatePerfectCombo = this.AccumulatePerfectCombo;
		this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
	}

	// Token: 0x060071CB RID: 29131 RVA: 0x00174908 File Offset: 0x00172B08
	public void OnPerfectOn()
	{
		this.GameInfo.CurrentScore += this.PerfectScore;
		int accumulatePerfectCombo = this.AccumulatePerfectCombo;
		this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
	}

	// Token: 0x060071CC RID: 29132 RVA: 0x00174940 File Offset: 0x00172B40
	public void OnMissOn()
	{
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		this.GameInfo.CurrentScore = Math.Max(0, this.GameInfo.CurrentScore - currentPlayConfig.Value.MistakeScore);
		this.AccumulatePerfectCombo = 0;
	}

	// Token: 0x060071CD RID: 29133 RVA: 0x00174988 File Offset: 0x00172B88
	private void RefreshAccumulatePerfectCombo()
	{
		int accumulatePerfectCombo = this.AccumulatePerfectCombo;
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		if (currentPlayConfig == null)
		{
			return;
		}
		ArtemisQte config = currentPlayConfig.Value;
		Dictionary<int, int> keyValueMap = ArtemisQteView.BuildDictFromConfigArray(config.CursorSpeedLength, (int j) => config.CursorSpeed(j));
		Dictionary<int, int> keyValueMap2 = ArtemisQteView.BuildDictFromConfigArray(config.RouletteRotateSpeedLength, (int j) => config.RouletteRotateSpeed(j));
		Dictionary<int, int> keyValueMap3 = ArtemisQteView.BuildDictFromConfigArray(config.PerfectAppearRateLength, (int j) => config.PerfectAppearRate(j));
		this.GameInfo.CursorSpeed = (float)ArtemisQteView.RefreshInfoByKey(accumulatePerfectCombo, keyValueMap);
		this.GameInfo.RingSpeed = (float)ArtemisQteView.RefreshInfoByKey(accumulatePerfectCombo, keyValueMap2);
		this.GameInfo.PerfectAppearRate = (float)ArtemisQteView.RefreshInfoByKey(accumulatePerfectCombo, keyValueMap3);
	}

	// Token: 0x060071CE RID: 29134 RVA: 0x00174A54 File Offset: 0x00172C54
	private static Dictionary<int, int> BuildDictFromConfigArray(int length, Func<int, DicIntInt?> getItem)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < length; i++)
		{
			DicIntInt? dicIntInt = getItem(i);
			if (dicIntInt != null)
			{
				DicIntInt value = dicIntInt.Value;
				dictionary[value.Key] = value.Value;
			}
		}
		return dictionary;
	}

	// Token: 0x060071CF RID: 29135 RVA: 0x00174AA4 File Offset: 0x00172CA4
	private static int RefreshInfoByKey(int currentKey, Dictionary<int, int> keyValueMap)
	{
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		foreach (KeyValuePair<int, int> keyValuePair in keyValueMap)
		{
			list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
		}
		for (int i = 0; i < list.Count; i++)
		{
			int item = list[i].Item1;
			int item2 = list[i].Item2;
			if (i >= list.Count - 1)
			{
				return item2;
			}
			int item3 = list[i + 1].Item1;
			if (item <= currentKey && currentKey < item3)
			{
				return item2;
			}
		}
		return 0;
	}

	// Token: 0x040034CC RID: 13516
	private const int MAX_QTE_ROUNG = 1;

	// Token: 0x040034CD RID: 13517
	private const int GAME_END_TIME = 800;

	// Token: 0x040034CE RID: 13518
	protected ArtemisQteGameInfo GameInfo;

	// Token: 0x040034CF RID: 13519
	[Nullable(2)]
	private ArtemisQteProgressItem ProgressItem;

	// Token: 0x040034D0 RID: 13520
	[Nullable(2)]
	private readonly Action FinishCallback;

	// Token: 0x040034D1 RID: 13521
	[Nullable(2)]
	private ArtemisQteClickTipsItem TipsItem;

	// Token: 0x040034D2 RID: 13522
	[Nullable(2)]
	private LevelSequencePlayer ViewSequencePlayer;

	// Token: 0x040034D3 RID: 13523
	public int CurrentGameplayId;

	// Token: 0x040034D4 RID: 13524
	private int AccumulatePerfectComboInternal;

	// Token: 0x020076C9 RID: 30409
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402733F RID: 160575
		public const int CenterPanel = 0;

		// Token: 0x04027340 RID: 160576
		public const int BtnControl = 1;

		// Token: 0x04027341 RID: 160577
		public const int QteTipUiItem = 2;
	}
}
