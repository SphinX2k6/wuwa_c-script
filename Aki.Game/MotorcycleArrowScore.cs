using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CCF RID: 7375
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowScore : UiPanelBase
{
	// Token: 0x0600DF3D RID: 57149 RVA: 0x00344748 File Offset: 0x00342948
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

	// Token: 0x0600DF3E RID: 57150 RVA: 0x003447B8 File Offset: 0x003429B8
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

	// Token: 0x0600DF3F RID: 57151 RVA: 0x003448A7 File Offset: 0x00342AA7
	protected override void OnBeforeDestroy()
	{
		this.SequencePlayer.Clear();
		this.SequencePlayer = null;
	}

	// Token: 0x0600DF40 RID: 57152 RVA: 0x003448BC File Offset: 0x00342ABC
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		MotorcycleArrowSubModel motorcycleArrowSubModel = (MotorcycleArrowSubModel)KuroSimpleCombatController.Instance.CurSubModel;
		this.OnMotorArrowScoreUpdate(motorcycleArrowSubModel.Score);
		this.PlayLevelSequence("Start", false);
	}

	// Token: 0x0600DF41 RID: 57153 RVA: 0x003448F7 File Offset: 0x00342AF7
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600DF42 RID: 57154 RVA: 0x003448FF File Offset: 0x00342AFF
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorArrowScoreUpdate, new Action<int>(this.OnMotorArrowScoreUpdate));
	}

	// Token: 0x0600DF43 RID: 57155 RVA: 0x0034491D File Offset: 0x00342B1D
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorArrowScoreUpdate, new Action<int>(this.OnMotorArrowScoreUpdate));
	}

	// Token: 0x0600DF44 RID: 57156 RVA: 0x0034493C File Offset: 0x00342B3C
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

	// Token: 0x0600DF45 RID: 57157 RVA: 0x003449D0 File Offset: 0x00342BD0
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

	// Token: 0x0600DF46 RID: 57158 RVA: 0x00344A9B File Offset: 0x00342C9B
	private void OnCloseEvent(string sequenceName)
	{
		if (sequenceName == "Start" || sequenceName == "Double")
		{
			this.PlayLevelSequence("Loop", false);
		}
	}

	// Token: 0x0600DF47 RID: 57159 RVA: 0x00344AC4 File Offset: 0x00342CC4
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

	// Token: 0x0600DF48 RID: 57160 RVA: 0x00344B93 File Offset: 0x00342D93
	private void UpdateEndSeqTime(string state)
	{
		if (state == "Scoring" || state == "Score")
		{
			this.EndSeqTime = (float)Time.Instance.WorldTimeSeconds + 5000f;
			return;
		}
		this.EndSeqTime = 0f;
	}

	// Token: 0x0600DF49 RID: 57161 RVA: 0x00344BD4 File Offset: 0x00342DD4
	private void SetExpressState(string state)
	{
		if (this.ExpressState == state)
		{
			return;
		}
		this.ExpressState = state;
		this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(state), this.SpriteExpress, false, null, null);
	}

	// Token: 0x0600DF4A RID: 57162 RVA: 0x00344C19 File Offset: 0x00342E19
	private void PlayerEffectDouble()
	{
		this.EffectDouble.SetUIActive(false);
		this.EffectDouble.SetUIActive(true);
	}

	// Token: 0x040066A7 RID: 26279
	private const int CONSECUTIVE_SCORE_DURATION = 5000;

	// Token: 0x040066A8 RID: 26280
	private const int SCORE_ANIM_DURATION = 500;

	// Token: 0x040066A9 RID: 26281
	[Nullable(2)]
	protected UUISprite SpriteExpress;

	// Token: 0x040066AA RID: 26282
	[Nullable(2)]
	protected UUIArtText ArtTextScore;

	// Token: 0x040066AB RID: 26283
	[Nullable(2)]
	protected UUIText TextTime;

	// Token: 0x040066AC RID: 26284
	[Nullable(2)]
	protected UUIItem EffectDouble;

	// Token: 0x040066AD RID: 26285
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040066AE RID: 26286
	private int BigScoreThreshold = 10;

	// Token: 0x040066AF RID: 26287
	private string CurSeqState = "None";

	// Token: 0x040066B0 RID: 26288
	private float EndSeqTime;

	// Token: 0x040066B1 RID: 26289
	private string ExpressState = "None";

	// Token: 0x040066B2 RID: 26290
	private bool NeedDoubleEffect;

	// Token: 0x040066B3 RID: 26291
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x020082CF RID: 33487
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AAB7 RID: 174775
		public const int SpriteExpress = 0;

		// Token: 0x0402AAB8 RID: 174776
		public const int ArtTextScore = 1;

		// Token: 0x0402AAB9 RID: 174777
		public const int TextTime = 2;

		// Token: 0x0402AABA RID: 174778
		public const int EffectDouble = 3;
	}

	// Token: 0x020082D0 RID: 33488
	[Nullable(0)]
	private static class ELevelSequence
	{
		// Token: 0x0402AABB RID: 174779
		public const string None = "None";

		// Token: 0x0402AABC RID: 174780
		public const string Start = "Start";

		// Token: 0x0402AABD RID: 174781
		public const string Score = "Score";

		// Token: 0x0402AABE RID: 174782
		public const string Scoring = "Scoring";

		// Token: 0x0402AABF RID: 174783
		public const string Double = "Double";

		// Token: 0x0402AAC0 RID: 174784
		public const string Close = "Close";

		// Token: 0x0402AAC1 RID: 174785
		public const string Loop = "Loop";
	}

	// Token: 0x020082D1 RID: 33489
	[Nullable(0)]
	private static class EExpressDefine
	{
		// Token: 0x0402AAC2 RID: 174786
		public const string None = "None";

		// Token: 0x0402AAC3 RID: 174787
		public const string Close = "SP_ScoreExpress1";

		// Token: 0x0402AAC4 RID: 174788
		public const string Double = "SP_ScoreExpress2";

		// Token: 0x0402AAC5 RID: 174789
		public const string Open = "SP_ScoreExpress3";
	}
}
