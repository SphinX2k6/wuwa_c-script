using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000569 RID: 1385
public class TaskStateToRewardStateResolver : IStaticVariableResetter
{
	// Token: 0x060042E1 RID: 17121 RVA: 0x00174043 File Offset: 0x00172243
	static TaskStateToRewardStateResolver()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskStateToRewardStateResolver.CreateStaticDefaultValue), new Action(TaskStateToRewardStateResolver.ResetStaticDefaultValue));
	}

	// Token: 0x060042E2 RID: 17122 RVA: 0x00174062 File Offset: 0x00172262
	public static void CreateStaticDefaultValue()
	{
		TaskStateToRewardStateResolver.Value = new Dictionary<EActivityTaskState, EActivityRewardState>
		{
			{
				EActivityTaskState.Active,
				EActivityRewardState.Disabled
			},
			{
				EActivityTaskState.FinishedAndUnclaimed,
				EActivityRewardState.Enable
			},
			{
				EActivityTaskState.FinishedAndClaimed,
				EActivityRewardState.Claimed
			}
		};
	}

	// Token: 0x060042E3 RID: 17123 RVA: 0x00174086 File Offset: 0x00172286
	public static void ResetStaticDefaultValue()
	{
		TaskStateToRewardStateResolver.Value = null;
	}

	// Token: 0x04003460 RID: 13408
	[Nullable(1)]
	public static Dictionary<EActivityTaskState, EActivityRewardState> Value;
}
