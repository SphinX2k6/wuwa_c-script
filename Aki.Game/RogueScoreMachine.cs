using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F52 RID: 8018
[NullableContext(2)]
[Nullable(0)]
public class RogueScoreMachine
{
	// Token: 0x0600F830 RID: 63536 RVA: 0x003C0AFA File Offset: 0x003BECFA
	[NullableContext(1)]
	public void SetUpdateCallback(Action<float, BattleScoreLevelConf?> updateScore, Action playUpAnim)
	{
		this.UpdateScore = updateScore;
		this.PlayUpAnim = playUpAnim;
	}

	// Token: 0x0600F831 RID: 63537 RVA: 0x003C0B0C File Offset: 0x003BED0C
	public void UpdateTargetScore(float score, BattleScoreLevelConf? scoreLevelConfig)
	{
		if (scoreLevelConfig != null && score >= (float)scoreLevelConfig.Value.LowerUpperLimits(1))
		{
			this.TargetScore = (float)scoreLevelConfig.Value.LowerUpperLimits(1);
		}
		else
		{
			this.TargetScore = score;
		}
		this.TargetScoreActionConfig = scoreLevelConfig;
		if (this.CurScore == this.TargetScore)
		{
			return;
		}
		bool flag = this.TargetScore > this.CurScore;
		if (flag)
		{
			Action playUpAnim = this.PlayUpAnim;
			if (playUpAnim != null)
			{
				playUpAnim();
			}
		}
		if (this.CurScoreActionConfig == null && this.TargetScoreActionConfig == null)
		{
			return;
		}
		int num = (this.CurScoreActionConfig != null) ? this.CurScoreActionConfig.GetValueOrDefault().Level : 0;
		if (Math.Abs(((this.TargetScoreActionConfig != null) ? this.TargetScoreActionConfig.GetValueOrDefault().Level : 0) - num) > 1)
		{
			this.JumpToTarget();
			return;
		}
		bool flag2 = false;
		if (this.CurScoreActionConfig == null)
		{
			this.CurScore = (float)this.TargetScoreActionConfig.Value.LowerUpperLimits(0);
			this.CurScoreActionConfig = this.TargetScoreActionConfig;
			if (this.CurScore == this.TargetScore)
			{
				this.Speed = 0f;
				Action<float, BattleScoreLevelConf?> updateScore = this.UpdateScore;
				if (updateScore == null)
				{
					return;
				}
				updateScore(this.CurScore, this.CurScoreActionConfig);
				return;
			}
			else
			{
				flag2 = true;
			}
		}
		if (Math.Abs(score - this.CurScore) >= 1000f)
		{
			this.JumpToTarget();
			return;
		}
		if (flag)
		{
			this.Speed = (this.TargetScore - this.CurScore) / 300f;
		}
		else
		{
			this.Speed = (this.TargetScore - this.CurScore) / 1000f;
		}
		if (flag2)
		{
			Action<float, BattleScoreLevelConf?> updateScore2 = this.UpdateScore;
			if (updateScore2 != null)
			{
				updateScore2(this.CurScore, this.CurScoreActionConfig);
			}
			this.UpdateFrame = Time.Instance.Frame;
		}
	}

	// Token: 0x0600F832 RID: 63538 RVA: 0x003C0CEC File Offset: 0x003BEEEC
	private void JumpToTarget()
	{
		this.CurScore = this.TargetScore;
		this.CurScoreActionConfig = this.TargetScoreActionConfig;
		this.Speed = 0f;
		Action<float, BattleScoreLevelConf?> updateScore = this.UpdateScore;
		if (updateScore == null)
		{
			return;
		}
		updateScore(this.CurScore, this.CurScoreActionConfig);
	}

	// Token: 0x0600F833 RID: 63539 RVA: 0x003C0D38 File Offset: 0x003BEF38
	public void Tick(float delta)
	{
		if (this.Speed == 0f || this.UpdateFrame == Time.Instance.Frame)
		{
			return;
		}
		this.CurScore += this.Speed * delta;
		int? num = (this.CurScoreActionConfig != null) ? new int?(this.CurScoreActionConfig.GetValueOrDefault().Level) : null;
		int? num2 = (this.TargetScoreActionConfig != null) ? new int?(this.TargetScoreActionConfig.GetValueOrDefault().Level) : null;
		if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
		{
			int num3 = this.CurScoreActionConfig.Value.LowerUpperLimits(0);
			int num4 = this.CurScoreActionConfig.Value.LowerUpperLimits(1);
			if (this.Speed > 0f)
			{
				if (this.CurScore >= (float)num4)
				{
					this.CurScoreActionConfig = this.TargetScoreActionConfig;
				}
			}
			else if (this.CurScore < (float)num3)
			{
				this.CurScoreActionConfig = this.TargetScoreActionConfig;
			}
		}
		if (this.Speed > 0f)
		{
			if (this.CurScore >= this.TargetScore)
			{
				this.CurScore = this.TargetScore;
				this.Speed = 0f;
			}
		}
		else if (this.CurScore <= this.TargetScore)
		{
			this.CurScore = this.TargetScore;
			this.Speed = 0f;
		}
		Action<float, BattleScoreLevelConf?> updateScore = this.UpdateScore;
		if (updateScore == null)
		{
			return;
		}
		updateScore(this.CurScore, this.CurScoreActionConfig);
	}

	// Token: 0x0600F834 RID: 63540 RVA: 0x003C0ED5 File Offset: 0x003BF0D5
	public void ResetScore()
	{
		this.CurScore = 0f;
		this.TargetScore = 0f;
		this.CurScoreActionConfig = null;
		this.TargetScoreActionConfig = null;
	}

	// Token: 0x04007327 RID: 29479
	private const int SERVER_SCORE_UP_INTERVAL = 300;

	// Token: 0x04007328 RID: 29480
	private const int SERVER_SCORE_DOWN_INTERVAL = 1000;

	// Token: 0x04007329 RID: 29481
	private const int MAX_SCORE_DIFF = 1000;

	// Token: 0x0400732A RID: 29482
	private Action<float, BattleScoreLevelConf?> UpdateScore;

	// Token: 0x0400732B RID: 29483
	private Action PlayUpAnim;

	// Token: 0x0400732C RID: 29484
	private int UpdateFrame;

	// Token: 0x0400732D RID: 29485
	private float CurScore;

	// Token: 0x0400732E RID: 29486
	private float TargetScore;

	// Token: 0x0400732F RID: 29487
	private BattleScoreLevelConf? CurScoreActionConfig;

	// Token: 0x04007330 RID: 29488
	private BattleScoreLevelConf? TargetScoreActionConfig;

	// Token: 0x04007331 RID: 29489
	private float Speed;
}
