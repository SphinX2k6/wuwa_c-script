using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020010B4 RID: 4276
[NullableContext(1)]
[Nullable(0)]
public class TaskStateResolver : IStaticVariableResetter
{
	// Token: 0x06006F47 RID: 28487 RVA: 0x0016B61A File Offset: 0x0016981A
	static TaskStateResolver()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskStateResolver.CreateStaticDefaultValue), new Action(TaskStateResolver.ResetStaticDefaultValue));
	}

	// Token: 0x06006F48 RID: 28488 RVA: 0x0016B63C File Offset: 0x0016983C
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

	// Token: 0x06006F49 RID: 28489 RVA: 0x0016B6AF File Offset: 0x001698AF
	public static void ResetStaticDefaultValue()
	{
		TaskStateResolver.TaskState = null;
		TaskStateResolver.ConditionState = null;
		TaskStateResolver.TrackMoonTargetState = null;
	}

	// Token: 0x040033C4 RID: 13252
	public static Dictionary<ActivityTaskState, EActivityTaskState> TaskState;

	// Token: 0x040033C5 RID: 13253
	public static Dictionary<ConditionTaskState, EActivityTaskState> ConditionState;

	// Token: 0x040033C6 RID: 13254
	public static Dictionary<TrackMoonTargetState, EActivityTaskState> TrackMoonTargetState;
}
