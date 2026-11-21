using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000568 RID: 1384
[NullableContext(1)]
[Nullable(0)]
public class TaskStateResolver : IStaticVariableResetter
{
	// Token: 0x060042DD RID: 17117 RVA: 0x00173F92 File Offset: 0x00172192
	static TaskStateResolver()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskStateResolver.CreateStaticDefaultValue), new Action(TaskStateResolver.ResetStaticDefaultValue));
	}

	// Token: 0x060042DE RID: 17118 RVA: 0x00173FB4 File Offset: 0x001721B4
	public static void CreateStaticDefaultValue()
	{
		TaskStateResolver.TaskState = new Dictionary<ActivityTaskState, EActivityTaskState>
		{
			{
				ActivityTaskState.ActivityTaskRunning,
				EActivityTaskState.Active
			},
			{
				ActivityTaskState.ActivityTaskFinish,
				EActivityTaskState.FinishedAndUnclaimed
			},
			{
				ActivityTaskState.ActivityTaskTaken,
				EActivityTaskState.FinishedAndClaimed
			}
		};
		TaskStateResolver.ConditionState = new Dictionary<ConditionTaskState, EActivityTaskState>
		{
			{
				ConditionTaskState.ConditionTaskRunning,
				EActivityTaskState.Active
			},
			{
				ConditionTaskState.ConditionTaskFinish,
				EActivityTaskState.FinishedAndUnclaimed
			},
			{
				ConditionTaskState.ConditionTaskTaken,
				EActivityTaskState.FinishedAndClaimed
			}
		};
		TaskStateResolver.TrackMoonTargetState = new Dictionary<TrackMoonTargetState, EActivityTaskState>
		{
			{
				Aki.Protocol.TrackMoonTargetState.TrackMoonTargetRunning,
				EActivityTaskState.Active
			},
			{
				Aki.Protocol.TrackMoonTargetState.TrackMoonTargetFinish,
				EActivityTaskState.FinishedAndUnclaimed
			},
			{
				Aki.Protocol.TrackMoonTargetState.TrackMoonTargetTaken,
				EActivityTaskState.FinishedAndClaimed
			}
		};
	}

	// Token: 0x060042DF RID: 17119 RVA: 0x00174027 File Offset: 0x00172227
	public static void ResetStaticDefaultValue()
	{
		TaskStateResolver.TaskState = null;
		TaskStateResolver.ConditionState = null;
		TaskStateResolver.TrackMoonTargetState = null;
	}

	// Token: 0x0400345D RID: 13405
	public static Dictionary<ActivityTaskState, EActivityTaskState> TaskState;

	// Token: 0x0400345E RID: 13406
	public static Dictionary<ConditionTaskState, EActivityTaskState> ConditionState;

	// Token: 0x0400345F RID: 13407
	public static Dictionary<TrackMoonTargetState, EActivityTaskState> TrackMoonTargetState;
}
