using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001414 RID: 5140
[NullableContext(2)]
[Nullable(0)]
public class RogueScoreMachine
{
	// Token: 0x0600CC4F RID: 52303 RVA: 0x003CC5E6 File Offset: 0x003CA7E6
	[NullableContext(1)]
	public void SetUpdateCallback(Action<float, BattleScoreLevelConf?> updateScore, Action playUpAnim)
	{
		this.UpdateScore = updateScore;
		this.PlayUpAnim = playUpAnim;
	}

	// Token: 0x0600CC50 RID: 52304 RVA: 0x003CC5F8 File Offset: 0x003CA7F8
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

	// Token: 0x0600CC51 RID: 52305 RVA: 0x003CC7D8 File Offset: 0x003CA9D8
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

	// Token: 0x0600CC52 RID: 52306 RVA: 0x003CC824 File Offset: 0x003CAA24
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

	// Token: 0x0600CC53 RID: 52307 RVA: 0x003CC9C1 File Offset: 0x003CABC1
	public void ResetScore()
	{
		this.CurScore = 0f;
		this.TargetScore = 0f;
		this.CurScoreActionConfig = null;
		this.TargetScoreActionConfig = null;
	}

	// Token: 0x04007408 RID: 29704
	private const int SERVER_SCORE_UP_INTERVAL = 300;

	// Token: 0x04007409 RID: 29705
	private const int SERVER_SCORE_DOWN_INTERVAL = 1000;

	// Token: 0x0400740A RID: 29706
	private const int MAX_SCORE_DIFF = 1000;

	// Token: 0x0400740B RID: 29707
	private Action<float, BattleScoreLevelConf?> UpdateScore;

	// Token: 0x0400740C RID: 29708
	private Action PlayUpAnim;

	// Token: 0x0400740D RID: 29709
	private int UpdateFrame;

	// Token: 0x0400740E RID: 29710
	private float CurScore;

	// Token: 0x0400740F RID: 29711
	private float TargetScore;

	// Token: 0x04007410 RID: 29712
	private BattleScoreLevelConf? CurScoreActionConfig;

	// Token: 0x04007411 RID: 29713
	private BattleScoreLevelConf? TargetScoreActionConfig;

	// Token: 0x04007412 RID: 29714
	private float Speed;
}
