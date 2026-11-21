using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001191 RID: 4497
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowScore : UiPanelBase
{
	// Token: 0x0600B35A RID: 45914 RVA: 0x00350170 File Offset: 0x0034E370
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600B35B RID: 45915 RVA: 0x003501E0 File Offset: 0x0034E3E0
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseEvent), false);
		this.SpriteExpress = base.GetSprite(0);
		this.ArtTextScore = base.GetArtText(1);
		this.TextTime = base.GetText(2);
		this.EffectDouble = base.GetItem(3);
		int id = GameModeModel.Instance.InstanceDungeon.Value.Id;
		MotorFightMainLevel? levelByInstId = MotorcycleArrowConfig.Instance.GetLevelByInstId(id);
		this.BigScoreThreshold = ((levelByInstId != null) ? levelByInstId.GetValueOrDefault().BigScore : 10);
		UUIArtText artTextScore = this.ArtTextScore;
		if (artTextScore != null)
		{
			artTextScore.SetText("0");
		}
		this.DigitScroll.Init(0f, 0f, 500f);
		this.SetExpressState("SP_ScoreExpress1");
	}

	// Token: 0x0600B35C RID: 45916 RVA: 0x003502CF File Offset: 0x0034E4CF
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
		this.SequencePlayer = null;
	}

	// Token: 0x0600B35D RID: 45917 RVA: 0x003502E4 File Offset: 0x0034E4E4
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		this.OnMotorArrowScoreUpdate(motorcycleArrowSubModel.Score);
		this.PlayLevelSequence("Start", false);
	}

	// Token: 0x0600B35E RID: 45918 RVA: 0x0035031F File Offset: 0x0034E51F
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600B35F RID: 45919 RVA: 0x00350327 File Offset: 0x0034E527
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowScoreUpdate, new Action<int>(this.OnMotorArrowScoreUpdate));
	}

	// Token: 0x0600B360 RID: 45920 RVA: 0x00350345 File Offset: 0x0034E545
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowScoreUpdate, new Action<int>(this.OnMotorArrowScoreUpdate));
	}

	// Token: 0x0600B361 RID: 45921 RVA: 0x00350364 File Offset: 0x0034E564
	protected void OnMotorArrowScoreUpdate(int score)
	{
		float num = this.DigitScroll.SetTarget((float)score);
		if (num <= 0f)
		{
			return;
		}
		if (num > (float)this.BigScoreThreshold)
		{
			this.NeedDoubleEffect = true;
			this.PlayLevelSequence("Double", true);
			return;
		}
		if (this.CurSeqState == "Double")
		{
			return;
		}
		if (this.CurSeqState == "Score")
		{
			this.PlayLevelSequence("Scoring", false);
			return;
		}
		if (this.CurSeqState == "Loop")
		{
			this.PlayLevelSequence("Score", false);
		}
	}

	// Token: 0x0600B362 RID: 45922 RVA: 0x003503F8 File Offset: 0x0034E5F8
	public void OnTick(float delta)
	{
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		if (motorcycleArrowSubModel == null)
		{
			return;
		}
		this.TextTime.SetText(MotorcycleUtil.TimeFormat((float)(Time.Instance.WorldTimeSeconds - (double)motorcycleArrowSubModel.LevelStartTime)), true);
		if (!this.DigitScroll.IsFinished())
		{
			float num = this.DigitScroll.Tick(delta);
			UUIArtText artTextScore = this.ArtTextScore;
			if (artTextScore != null)
			{
				artTextScore.SetText(MotorcycleUtil.CompactNumberFormat((float)Math.Floor((double)num)));
			}
		}
		else if (this.NeedDoubleEffect)
		{
			this.PlayerEffectDouble();
			this.NeedDoubleEffect = false;
		}
		if (this.EndSeqTime > 0f && (float)Time.Instance.WorldTimeSeconds >= this.EndSeqTime)
		{
			this.EndSeqTime = 0f;
			this.PlayLevelSequence("Loop", false);
		}
	}

	// Token: 0x0600B363 RID: 45923 RVA: 0x003504C3 File Offset: 0x0034E6C3
	private void OnCloseEvent(string sequenceName)
	{
		if (sequenceName == "Start" || sequenceName == "Double")
		{
			this.PlayLevelSequence("Loop", false);
		}
	}

	// Token: 0x0600B364 RID: 45924 RVA: 0x003504EC File Offset: 0x0034E6EC
	private void PlayLevelSequence(string state, bool bRestart)
	{
		if (this.CurSeqState == state && !bRestart)
		{
			this.UpdateEndSeqTime(state);
			return;
		}
		this.CurSeqState = state;
		if (state == "Double" || state == "Scoring" || state == "Score")
		{
			this.SetExpressState("SP_ScoreExpress2");
		}
		else if (state == "Start" || state == "Close")
		{
			this.SetExpressState("SP_ScoreExpress1");
		}
		else if (this.DigitScroll.Target > 0f)
		{
			this.SetExpressState("SP_ScoreExpress3");
		}
		this.UpdateEndSeqTime(state);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayOrReplaySequenceByName(state, false, null);
	}

	// Token: 0x0600B365 RID: 45925 RVA: 0x003505BB File Offset: 0x0034E7BB
	private void UpdateEndSeqTime(string state)
	{
		if (state == "Scoring" || state == "Score")
		{
			this.EndSeqTime = (float)Time.Instance.WorldTimeSeconds + 5000f;
			return;
		}
		this.EndSeqTime = 0f;
	}

	// Token: 0x0600B366 RID: 45926 RVA: 0x003505FC File Offset: 0x0034E7FC
	private void SetExpressState(string state)
	{
		if (this.ExpressState == state)
		{
			return;
		}
		this.ExpressState = state;
		this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(state), this.SpriteExpress, false, null, null);
	}

	// Token: 0x0600B367 RID: 45927 RVA: 0x00350641 File Offset: 0x0034E841
	private void PlayerEffectDouble()
	{
		this.EffectDouble.SetUIActive(false);
		this.EffectDouble.SetUIActive(true);
	}

	// Token: 0x04006786 RID: 26502
	private const int CONSECUTIVE_SCORE_DURATION = 5000;

	// Token: 0x04006787 RID: 26503
	private const int SCORE_ANIM_DURATION = 500;

	// Token: 0x04006788 RID: 26504
	[Nullable(2)]
	protected UUISprite SpriteExpress;

	// Token: 0x04006789 RID: 26505
	[Nullable(2)]
	protected UUIArtText ArtTextScore;

	// Token: 0x0400678A RID: 26506
	[Nullable(2)]
	protected UUIText TextTime;

	// Token: 0x0400678B RID: 26507
	[Nullable(2)]
	protected UUIItem EffectDouble;

	// Token: 0x0400678C RID: 26508
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400678D RID: 26509
	private int BigScoreThreshold = 10;

	// Token: 0x0400678E RID: 26510
	private string CurSeqState = "None";

	// Token: 0x0400678F RID: 26511
	private float EndSeqTime;

	// Token: 0x04006790 RID: 26512
	private string ExpressState = "None";

	// Token: 0x04006791 RID: 26513
	private bool NeedDoubleEffect;

	// Token: 0x04006792 RID: 26514
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x02007458 RID: 29784
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025DDF RID: 155103
		public const int SpriteExpress = 0;

		// Token: 0x04025DE0 RID: 155104
		public const int ArtTextScore = 1;

		// Token: 0x04025DE1 RID: 155105
		public const int TextTime = 2;

		// Token: 0x04025DE2 RID: 155106
		public const int EffectDouble = 3;
	}

	// Token: 0x02007459 RID: 29785
	[Nullable(0)]
	private static class ELevelSequence
	{
		// Token: 0x04025DE3 RID: 155107
		public const string None = "None";

		// Token: 0x04025DE4 RID: 155108
		public const string Start = "Start";

		// Token: 0x04025DE5 RID: 155109
		public const string Score = "Score";

		// Token: 0x04025DE6 RID: 155110
		public const string Scoring = "Scoring";

		// Token: 0x04025DE7 RID: 155111
		public const string Double = "Double";

		// Token: 0x04025DE8 RID: 155112
		public const string Close = "Close";

		// Token: 0x04025DE9 RID: 155113
		public const string Loop = "Loop";
	}

	// Token: 0x0200745A RID: 29786
	[Nullable(0)]
	private static class EExpressDefine
	{
		// Token: 0x04025DEA RID: 155114
		public const string None = "None";

		// Token: 0x04025DEB RID: 155115
		public const string Close = "SP_ScoreExpress1";

		// Token: 0x04025DEC RID: 155116
		public const string Double = "SP_ScoreExpress2";

		// Token: 0x04025DED RID: 155117
		public const string Open = "SP_ScoreExpress3";
	}
}
