using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001045 RID: 4165
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerRoundPlayStage : GuessJokerStageBase
{
	// Token: 0x06006AD3 RID: 27347 RVA: 0x00157EFB File Offset: 0x001560FB
	public GuessJokerRoundPlayStage(GuessJokerStageFsm stageFsm) : base(stageFsm)
	{
	}

	// Token: 0x06006AD4 RID: 27348 RVA: 0x00157F0F File Offset: 0x0015610F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GuessJokerCardUpdateTaskData, new Action(this.OnGuessJokerCardUpdateTaskData));
	}

	// Token: 0x06006AD5 RID: 27349 RVA: 0x00157F2D File Offset: 0x0015612D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GuessJokerCardUpdateTaskData, new Action(this.OnGuessJokerCardUpdateTaskData));
	}

	// Token: 0x06006AD6 RID: 27350 RVA: 0x00157F4C File Offset: 0x0015614C
	protected override void OnEnter()
	{
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "RoundPlay Stage OnEnter", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InitTaskList();
		this.TryExecuteTask();
	}

	// Token: 0x06006AD7 RID: 27351 RVA: 0x00157F84 File Offset: 0x00156184
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

	// Token: 0x06006AD8 RID: 27352 RVA: 0x00157FC0 File Offset: 0x001561C0
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

	// Token: 0x06006AD9 RID: 27353 RVA: 0x0015801C File Offset: 0x0015621C
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

	// Token: 0x06006ADA RID: 27354 RVA: 0x00158064 File Offset: 0x00156264
	private void OnGuessJokerCardUpdateTaskData()
	{
		this.UpdateTaskList();
		this.TryExecuteTask();
	}

	// Token: 0x06006ADB RID: 27355 RVA: 0x00158074 File Offset: 0x00156274
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

	// Token: 0x06006ADC RID: 27356 RVA: 0x0015811C File Offset: 0x0015631C
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

	// Token: 0x06006ADD RID: 27357 RVA: 0x001581CC File Offset: 0x001563CC
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

	// Token: 0x06006ADE RID: 27358 RVA: 0x001581F8 File Offset: 0x001563F8
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

	// Token: 0x06006ADF RID: 27359 RVA: 0x00158224 File Offset: 0x00156424
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

	// Token: 0x04003135 RID: 12597
	protected List<GuessJokerTaskBase> TaskList = new List<GuessJokerTaskBase>();

	// Token: 0x04003136 RID: 12598
	[Nullable(2)]
	protected GuessJokerTaskBase CurrentTask;
}
