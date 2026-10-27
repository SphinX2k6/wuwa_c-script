using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001030 RID: 4144
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerPlotActionRunner
{
	// Token: 0x06006A66 RID: 27238 RVA: 0x00155880 File Offset: 0x00153A80
	public void PushPlotActions(IReadOnlyList<GuessJokerPlotAction> actions)
	{
		for (int i = 0; i < actions.Count; i++)
		{
			this.PushPlotAction(actions[i]);
		}
	}

	// Token: 0x06006A67 RID: 27239 RVA: 0x001558AC File Offset: 0x00153AAC
	private void PushPlotAction(GuessJokerPlotAction action)
	{
		EGuessJokerPlotTiming timing = action.Timing;
		if (this.CurrentAction != null && this.CurrentAction.CanHardCut && action.CanHardCut)
		{
			Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, string.Format("猜鬼牌剧情 - PlotActionRunner.PushPlotAction.硬切：打断当前plot {0}，执行新plot {1}", this.CurrentAction.PlotId, action.PlotId), default(ReadOnlySpan<ValueTuple<string, object>>));
			this.InterruptCurrentAction();
			this.CurrentAction = action;
			this.CurrentAction.Start();
			return;
		}
		bool flag = this.IsPlotInQueue(timing, action.PlayerType);
		bool flag2 = this.IsPlotExecuting(timing, action.PlayerType);
		bool flag3 = this.IsPlotInCd(timing, action.PlayerType);
		if (flag || flag2 || flag3)
		{
			return;
		}
		this.ActionEnqueueTimeMap[action] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		this.Queue.Add(action);
	}

	// Token: 0x06006A68 RID: 27240 RVA: 0x0015598C File Offset: 0x00153B8C
	private void InterruptCurrentAction()
	{
		if (this.CurrentAction == null)
		{
			return;
		}
		GuessJokerPlotAction currentAction = this.CurrentAction;
		EGuessJokerPlotTiming timing = currentAction.Timing;
		EGuessJokerPlayerType playerType = currentAction.PlayerType;
		string timingKey = this.GetTimingKey(timing, playerType);
		this.ExecutingTimings.Remove(timingKey);
		this.CurrentActionCdUpdated = false;
		this.ActionEnqueueTimeMap.Remove(currentAction);
		this.OnActionDone(currentAction);
		currentAction.Finish();
		this.CurrentAction = null;
	}

	// Token: 0x06006A69 RID: 27241 RVA: 0x001559F8 File Offset: 0x00153BF8
	private bool IsPlotInQueue(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		for (int i = 0; i < this.Queue.Count; i++)
		{
			GuessJokerPlotAction guessJokerPlotAction = this.Queue[i];
			if (guessJokerPlotAction != null && !guessJokerPlotAction.IsDone() && guessJokerPlotAction.Timing == timing && guessJokerPlotAction.PlayerType == playerType)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006A6A RID: 27242 RVA: 0x00155A48 File Offset: 0x00153C48
	private string GetTimingKey(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		return string.Format("{0}_{1}", timing, playerType);
	}

	// Token: 0x06006A6B RID: 27243 RVA: 0x00155A60 File Offset: 0x00153C60
	private bool IsPlotExecuting(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		string timingKey = this.GetTimingKey(timing, playerType);
		return this.ExecutingTimings.Contains(timingKey);
	}

	// Token: 0x06006A6C RID: 27244 RVA: 0x00155A84 File Offset: 0x00153C84
	private bool IsPlotInCd(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		string timingKey = this.GetTimingKey(timing, playerType);
		long num;
		return this.PlotCdMap.TryGetValue(timingKey, out num) && DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() < num;
	}

	// Token: 0x06006A6D RID: 27245 RVA: 0x00155ABC File Offset: 0x00153CBC
	private void UpdateCd(GuessJokerPlotAction action, EGuessJokerPlotTiming timing)
	{
		float cd = action.Cd;
		if (cd > 0f)
		{
			string timingKey = this.GetTimingKey(timing, action.PlayerType);
			this.PlotCdMap[timingKey] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (long)cd;
		}
	}

	// Token: 0x06006A6E RID: 27246 RVA: 0x00155B04 File Offset: 0x00153D04
	public void Tick(float delta)
	{
		if (this.CurrentAction == null && this.Queue.Count > 0)
		{
			this.CurrentAction = this.GetNextAction();
			if (this.CurrentAction != null)
			{
				this.CurrentAction.Start();
			}
		}
		if (this.CurrentAction != null)
		{
			this.CurrentAction.Tick(delta);
			GuessJokerPlotAction currentAction = this.CurrentAction;
			EGuessJokerPlotTiming timing = currentAction.Timing;
			EGuessJokerPlayerType playerType = currentAction.PlayerType;
			string timingKey = this.GetTimingKey(timing, playerType);
			if (!this.ExecutingTimings.Contains(timingKey))
			{
				this.ExecutingTimings.Add(timingKey);
			}
			if (!this.CurrentActionCdUpdated && !currentAction.IsInDelay)
			{
				this.UpdateCd(currentAction, timing);
				this.CurrentActionCdUpdated = true;
			}
			if (this.CurrentAction.IsDone())
			{
				this.OnActionDone(this.CurrentAction);
				this.CurrentAction.Finish();
				this.CurrentAction = null;
			}
		}
	}

	// Token: 0x06006A6F RID: 27247 RVA: 0x00155BE0 File Offset: 0x00153DE0
	[NullableContext(2)]
	protected GuessJokerPlotAction GetNextAction()
	{
		GuessJokerPlotAction result = null;
		while (this.Queue.Count > 0)
		{
			GuessJokerPlotAction guessJokerPlotAction = this.Queue[0];
			this.Queue.RemoveAt(0);
			if (guessJokerPlotAction == null)
			{
				break;
			}
			long num;
			if (!this.ActionEnqueueTimeMap.TryGetValue(guessJokerPlotAction, out num))
			{
				result = guessJokerPlotAction;
				break;
			}
			this.ActionEnqueueTimeMap.Remove(guessJokerPlotAction);
			float waitDeleteTime = guessJokerPlotAction.WaitDeleteTime;
			if (waitDeleteTime <= 0f)
			{
				result = guessJokerPlotAction;
				break;
			}
			if ((float)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - num) < waitDeleteTime)
			{
				result = guessJokerPlotAction;
				break;
			}
		}
		return result;
	}

	// Token: 0x06006A70 RID: 27248 RVA: 0x00155C68 File Offset: 0x00153E68
	protected void OnActionDone(GuessJokerPlotAction action)
	{
		EGuessJokerPlotTiming timing = action.Timing;
		EGuessJokerPlayerType playerType = action.PlayerType;
		string timingKey = this.GetTimingKey(timing, playerType);
		this.ExecutingTimings.Remove(timingKey);
		this.CurrentActionCdUpdated = false;
	}

	// Token: 0x06006A71 RID: 27249 RVA: 0x00155CA0 File Offset: 0x00153EA0
	public void Destroy()
	{
		if (this.CurrentAction != null)
		{
			this.CurrentAction.Finish();
			this.CurrentAction = null;
		}
		this.PlotCdMap.Clear();
		this.ExecutingTimings.Clear();
		this.CurrentActionCdUpdated = false;
		this.Queue.Clear();
	}

	// Token: 0x04003109 RID: 12553
	protected readonly List<GuessJokerPlotAction> Queue = new List<GuessJokerPlotAction>();

	// Token: 0x0400310A RID: 12554
	[Nullable(2)]
	protected GuessJokerPlotAction CurrentAction;

	// Token: 0x0400310B RID: 12555
	private readonly Dictionary<string, long> PlotCdMap = new Dictionary<string, long>();

	// Token: 0x0400310C RID: 12556
	private readonly HashSet<string> ExecutingTimings = new HashSet<string>();

	// Token: 0x0400310D RID: 12557
	private bool CurrentActionCdUpdated;

	// Token: 0x0400310E RID: 12558
	private readonly Dictionary<GuessJokerPlotAction, long> ActionEnqueueTimeMap = new Dictionary<GuessJokerPlotAction, long>();
}
