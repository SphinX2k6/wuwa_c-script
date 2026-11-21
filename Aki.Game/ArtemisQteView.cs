using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005BB RID: 1467
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteView : UiTickViewBase
{
	// Token: 0x06004545 RID: 17733 RVA: 0x0017CB8A File Offset: 0x0017AD8A
	public ArtemisQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x0017CB94 File Offset: 0x0017AD94
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

	// Token: 0x06004547 RID: 17735 RVA: 0x0017CC14 File Offset: 0x0017AE14
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x0017CC57 File Offset: 0x0017AE57
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

	// Token: 0x06004549 RID: 17737 RVA: 0x0017CC80 File Offset: 0x0017AE80
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		ArtemisQteView.<OnPlayingCloseSequenceAsync>d__14 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ArtemisQteView.<OnPlayingCloseSequenceAsync>d__14>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x0017CCC3 File Offset: 0x0017AEC3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnArtemisQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x0017CCE1 File Offset: 0x0017AEE1
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnArtemisQteAreaChange, new Action<int>(this.OnFishingQteAreaChange));
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x0017CCFF File Offset: 0x0017AEFF
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

	// Token: 0x0600454D RID: 17741 RVA: 0x0017CD29 File Offset: 0x0017AF29
	private void Init()
	{
		this.GameInfo.SetGameStage(EArtemisQteStage.Ready);
		this.GameInfo.GetRingInfo().EnterNextValidArea();
		this.SetGameStart();
	}

	// Token: 0x0600454E RID: 17742 RVA: 0x0017CD4D File Offset: 0x0017AF4D
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

	// Token: 0x0600454F RID: 17743 RVA: 0x0017CD78 File Offset: 0x0017AF78
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

	// Token: 0x06004550 RID: 17744 RVA: 0x0017CE00 File Offset: 0x0017B000
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

	// Token: 0x06004551 RID: 17745 RVA: 0x0017CECA File Offset: 0x0017B0CA
	private void OnFishingQteAreaChange(int areaRelativeIndex)
	{
		this.ProgressItem.OnArrowStayAreaUpdate(areaRelativeIndex);
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x0017CED8 File Offset: 0x0017B0D8
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

	// Token: 0x06004553 RID: 17747 RVA: 0x0017CF42 File Offset: 0x0017B142
	private void SetGameStart()
	{
		this.GameInfo.SetGameStage(EArtemisQteStage.OnGoing);
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x0017CF50 File Offset: 0x0017B150
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

	// Token: 0x06004555 RID: 17749 RVA: 0x0017CF74 File Offset: 0x0017B174
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

	// Token: 0x06004556 RID: 17750 RVA: 0x0017D0D4 File Offset: 0x0017B2D4
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

	// Token: 0x170009B6 RID: 2486
	// (get) Token: 0x06004557 RID: 17751 RVA: 0x0017D115 File Offset: 0x0017B315
	public int GetCurrentGameplayId
	{
		get
		{
			return this.CurrentGameplayId;
		}
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x0017D11D File Offset: 0x0017B31D
	public bool GameplayStart(int configId, int maxRound)
	{
		this.CurrentGameplayId = configId;
		return this.InitialGameInfo(maxRound);
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x0017D12D File Offset: 0x0017B32D
	public ArtemisQte? GetCurrentPlayConfig()
	{
		return ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.CurrentGameplayId);
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x0017D140 File Offset: 0x0017B340
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

	// Token: 0x170009B7 RID: 2487
	// (get) Token: 0x0600455B RID: 17755 RVA: 0x0017D1E4 File Offset: 0x0017B3E4
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

	// Token: 0x170009B8 RID: 2488
	// (get) Token: 0x0600455C RID: 17756 RVA: 0x0017D214 File Offset: 0x0017B414
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

	// Token: 0x170009B9 RID: 2489
	// (get) Token: 0x0600455D RID: 17757 RVA: 0x0017D244 File Offset: 0x0017B444
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

	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x0600455E RID: 17758 RVA: 0x0017D272 File Offset: 0x0017B472
	// (set) Token: 0x0600455F RID: 17759 RVA: 0x0017D27A File Offset: 0x0017B47A
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

	// Token: 0x06004560 RID: 17760 RVA: 0x0017D28C File Offset: 0x0017B48C
	public void OnQteOn()
	{
		this.GameInfo.CurrentScore += this.HitAreaScore;
		int accumulatePerfectCombo = this.AccumulatePerfectCombo;
		this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x0017D2C4 File Offset: 0x0017B4C4
	public void OnPerfectOn()
	{
		this.GameInfo.CurrentScore += this.PerfectScore;
		int accumulatePerfectCombo = this.AccumulatePerfectCombo;
		this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x0017D2FC File Offset: 0x0017B4FC
	public void OnMissOn()
	{
		ArtemisQte? currentPlayConfig = this.GetCurrentPlayConfig();
		this.GameInfo.CurrentScore = Math.Max(0, this.GameInfo.CurrentScore - currentPlayConfig.Value.MistakeScore);
		this.AccumulatePerfectCombo = 0;
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x0017D344 File Offset: 0x0017B544
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

	// Token: 0x06004564 RID: 17764 RVA: 0x0017D410 File Offset: 0x0017B610
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

	// Token: 0x06004565 RID: 17765 RVA: 0x0017D460 File Offset: 0x0017B660
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

	// Token: 0x04003565 RID: 13669
	private const int MAX_QTE_ROUNG = 1;

	// Token: 0x04003566 RID: 13670
	private const int GAME_END_TIME = 800;

	// Token: 0x04003567 RID: 13671
	protected ArtemisQteGameInfo GameInfo;

	// Token: 0x04003568 RID: 13672
	[Nullable(2)]
	private ArtemisQteProgressItem ProgressItem;

	// Token: 0x04003569 RID: 13673
	[Nullable(2)]
	private readonly Action FinishCallback;

	// Token: 0x0400356A RID: 13674
	[Nullable(2)]
	private ArtemisQteClickTipsItem TipsItem;

	// Token: 0x0400356B RID: 13675
	[Nullable(2)]
	private LevelSequencePlayer ViewSequencePlayer;

	// Token: 0x0400356C RID: 13676
	public int CurrentGameplayId;

	// Token: 0x0400356D RID: 13677
	private int AccumulatePerfectComboInternal;

	// Token: 0x0200685D RID: 26717
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022688 RID: 140936
		public const int CenterPanel = 0;

		// Token: 0x04022689 RID: 140937
		public const int BtnControl = 1;

		// Token: 0x0402268A RID: 140938
		public const int QteTipUiItem = 2;
	}
}
