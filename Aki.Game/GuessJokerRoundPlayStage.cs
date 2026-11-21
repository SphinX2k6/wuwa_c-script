using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020004F9 RID: 1273
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerRoundPlayStage : GuessJokerStageBase
{
	// Token: 0x06003E68 RID: 15976 RVA: 0x00160823 File Offset: 0x0015EA23
	public GuessJokerRoundPlayStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x00160837 File Offset: 0x0015EA37
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GuessJokerCardUpdateTaskData, new Action(this.OnGuessJokerCardUpdateTaskData));
	}

	// Token: 0x06003E6A RID: 15978 RVA: 0x00160855 File Offset: 0x0015EA55
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GuessJokerCardUpdateTaskData, new Action(this.OnGuessJokerCardUpdateTaskData));
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x00160874 File Offset: 0x0015EA74
	protected override void OnEnter()
	{
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "RoundPlay Stage OnEnter", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InitTaskList();
		this.TryExecuteTask();
	}

	// Token: 0x06003E6C RID: 15980 RVA: 0x001608AC File Offset: 0x0015EAAC
	protected override void OnTick(float deltaTime)
	{
		if (this.CurrentTask != null)
		{
			this.CurrentTask.Tick(deltaTime);
			if (this.CurrentTask.IsFinished())
			{
				this.TaskList.RemoveAt(0);
				this.CurrentTask = null;
				this.TryExecuteTask();
			}
		}
	}

	// Token: 0x06003E6D RID: 15981 RVA: 0x001608E8 File Offset: 0x0015EAE8
	private void InitTaskList()
	{
		this.UpdateTaskList();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.GuessJokerCard;
		ELogAuthor author = ELogAuthor.LRC;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
		defaultInterpolatedStringHandler.AppendLiteral("RoundPlay Stage InitTaskList: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskList.Count);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x00160944 File Offset: 0x0015EB44
	private void UpdateTaskList()
	{
		List<JokerGuessOp> taskDataList = GuessJokerGamePlayModel.Instance.GetTaskDataList();
		for (int i = 0; i < taskDataList.Count; i++)
		{
			JokerGuessOp taskData = taskDataList[i];
			GuessJokerTaskBase guessJokerTaskBase = this.CreateTaskData(taskData);
			if (guessJokerTaskBase != null)
			{
				this.TaskList.Add(guessJokerTaskBase);
			}
		}
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x0016098C File Offset: 0x0015EB8C
	private void OnGuessJokerCardUpdateTaskData()
	{
		this.UpdateTaskList();
		this.TryExecuteTask();
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x0016099C File Offset: 0x0015EB9C
	private void TryExecuteTask()
	{
		if (this.CurrentTask != null)
		{
			return;
		}
		if (this.TaskList.Count == 0)
		{
			return;
		}
		this.CurrentTask = this.TaskList[0];
		this.CurrentTask.Execute();
		List<string> list = new List<string>();
		for (int i = 0; i < this.TaskList.Count; i++)
		{
			list.Add(this.TaskList[i].GetType().Name);
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "猜鬼牌待执行Task列表: " + string.Join(", ", list), default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x00160A44 File Offset: 0x0015EC44
	[return: Nullable(2)]
	public GuessJokerTaskBase CreateTaskData(JokerGuessOp taskData)
	{
		GuessJokerTaskBase result = null;
		switch (taskData.OpType)
		{
		case JokerActionType.EnterNewRound:
			result = new GuessJokerRoundStartTask(taskData.NewRoundAction);
			break;
		case JokerActionType.DrawCard:
			result = this.ExecuteDrawTaskData(taskData.DrawAction);
			break;
		case JokerActionType.PlayCard:
			result = this.ExecutePlayCardTaskData(taskData.PlayAction);
			break;
		case JokerActionType.TriggerSkill:
			result = this.ExecuteTriggerSkillTaskData(taskData.SkillTriggerAction);
			break;
		case JokerActionType.ExecSkill:
			result = new GuessJokerSkillExecuteTask(taskData.SkillExecAction);
			break;
		case JokerActionType.SettleResult:
			result = new GuessJokerSettleTask(taskData.Winner);
			break;
		case JokerActionType.HealthHpRefresh:
			result = new GuessJokerUpdateHpTask(taskData.HpRefreshAction);
			break;
		case JokerActionType.DisPlayCard:
			result = new GuessJokerAiCheckCardTask(taskData.DisPlayAction);
			break;
		}
		return result;
	}

	// Token: 0x06003E72 RID: 15986 RVA: 0x00160AF4 File Offset: 0x0015ECF4
	private GuessJokerTaskBase ExecuteDrawTaskData(JokerGuessDrawCardAction taskData)
	{
		GuessJokerTaskBase result;
		if (GuessJokerUtils.ServerPlayerTransToClient(taskData.Drawer) == EGuessJokerPlayerType.Me)
		{
			result = new GuessJokerPlayerDrawCardTask();
		}
		else
		{
			result = new GuessJokerAiDrawCardTask(taskData);
		}
		return result;
	}

	// Token: 0x06003E73 RID: 15987 RVA: 0x00160B20 File Offset: 0x0015ED20
	private GuessJokerTaskBase ExecutePlayCardTaskData(JokerGuessPlayCardAction taskData)
	{
		GuessJokerTaskBase result;
		if (GuessJokerUtils.ServerPlayerTransToClient(taskData.PlayActor) == EGuessJokerPlayerType.Me)
		{
			result = new GuessJokerPlayerPlayCardTask();
		}
		else
		{
			result = new GuessJokerAiPlayCardTask(taskData);
		}
		return result;
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x00160B4C File Offset: 0x0015ED4C
	private GuessJokerTaskBase ExecuteTriggerSkillTaskData(JokerGuessSkillTriggerAction taskData)
	{
		GuessJokerTaskBase result;
		if (GuessJokerUtils.ServerPlayerTransToClient(taskData.Owner) == EGuessJokerPlayerType.Me)
		{
			result = new GuessJokerPlayerSkillTriggerTask(taskData);
		}
		else
		{
			result = new GuessJokerAiSkillTriggerTask(taskData);
		}
		return result;
	}

	// Token: 0x040031CE RID: 12750
	protected List<GuessJokerTaskBase> TaskList = new List<GuessJokerTaskBase>();

	// Token: 0x040031CF RID: 12751
	[Nullable(2)]
	protected GuessJokerTaskBase CurrentTask;
}
