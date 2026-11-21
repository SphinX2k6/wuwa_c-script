using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004E4 RID: 1252
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerPlotActionRunner
{
	// Token: 0x06003DFB RID: 15867 RVA: 0x0015E1A8 File Offset: 0x0015C3A8
	public void PushPlotActions(IReadOnlyList<GuessJokerPlotAction> actions)
	{
		for (int i = 0; i < actions.Count; i++)
		{
			this.PushPlotAction(actions[i]);
		}
	}

	// Token: 0x06003DFC RID: 15868 RVA: 0x0015E1D4 File Offset: 0x0015C3D4
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

	// Token: 0x06003DFD RID: 15869 RVA: 0x0015E2B4 File Offset: 0x0015C4B4
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

	// Token: 0x06003DFE RID: 15870 RVA: 0x0015E320 File Offset: 0x0015C520
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

	// Token: 0x06003DFF RID: 15871 RVA: 0x0015E370 File Offset: 0x0015C570
	private string GetTimingKey(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		return string.Format("{0}_{1}", timing, playerType);
	}

	// Token: 0x06003E00 RID: 15872 RVA: 0x0015E388 File Offset: 0x0015C588
	private bool IsPlotExecuting(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		string timingKey = this.GetTimingKey(timing, playerType);
		return this.ExecutingTimings.Contains(timingKey);
	}

	// Token: 0x06003E01 RID: 15873 RVA: 0x0015E3AC File Offset: 0x0015C5AC
	private bool IsPlotInCd(EGuessJokerPlotTiming timing, EGuessJokerPlayerType playerType)
	{
		string timingKey = this.GetTimingKey(timing, playerType);
		long num;
		return this.PlotCdMap.TryGetValue(timingKey, out num) && DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() < num;
	}

	// Token: 0x06003E02 RID: 15874 RVA: 0x0015E3E4 File Offset: 0x0015C5E4
	private void UpdateCd(GuessJokerPlotAction action, EGuessJokerPlotTiming timing)
	{
		float cd = action.Cd;
		if (cd > 0f)
		{
			string timingKey = this.GetTimingKey(timing, action.PlayerType);
			this.PlotCdMap[timingKey] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + (long)cd;
		}
	}

	// Token: 0x06003E03 RID: 15875 RVA: 0x0015E42C File Offset: 0x0015C62C
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

	// Token: 0x06003E04 RID: 15876 RVA: 0x0015E508 File Offset: 0x0015C708
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

	// Token: 0x06003E05 RID: 15877 RVA: 0x0015E590 File Offset: 0x0015C790
	protected void OnActionDone(GuessJokerPlotAction action)
	{
		EGuessJokerPlotTiming timing = action.Timing;
		EGuessJokerPlayerType playerType = action.PlayerType;
		string timingKey = this.GetTimingKey(timing, playerType);
		this.ExecutingTimings.Remove(timingKey);
		this.CurrentActionCdUpdated = false;
	}

	// Token: 0x06003E06 RID: 15878 RVA: 0x0015E5C8 File Offset: 0x0015C7C8
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

	// Token: 0x040031A2 RID: 12706
	protected readonly List<GuessJokerPlotAction> Queue = new List<GuessJokerPlotAction>();

	// Token: 0x040031A3 RID: 12707
	[Nullable(2)]
	protected GuessJokerPlotAction CurrentAction;

	// Token: 0x040031A4 RID: 12708
	private readonly Dictionary<string, long> PlotCdMap = new Dictionary<string, long>();

	// Token: 0x040031A5 RID: 12709
	private readonly HashSet<string> ExecutingTimings = new HashSet<string>();

	// Token: 0x040031A6 RID: 12710
	private bool CurrentActionCdUpdated;

	// Token: 0x040031A7 RID: 12711
	private readonly Dictionary<GuessJokerPlotAction, long> ActionEnqueueTimeMap = new Dictionary<GuessJokerPlotAction, long>();
}
