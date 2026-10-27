using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010B5 RID: 4277
public class TaskStateToRewardStateResolver : IStaticVariableResetter
{
	// Token: 0x06006F4B RID: 28491 RVA: 0x0016B6CB File Offset: 0x001698CB
	static TaskStateToRewardStateResolver()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskStateToRewardStateResolver.CreateStaticDefaultValue), new Action(TaskStateToRewardStateResolver.ResetStaticDefaultValue));
	}

	// Token: 0x06006F4C RID: 28492 RVA: 0x0016B6EA File Offset: 0x001698EA
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

	// Token: 0x06006F4D RID: 28493 RVA: 0x0016B70E File Offset: 0x0016990E
	public static void ResetStaticDefaultValue()
	{
		TaskStateToRewardStateResolver.Value = null;
	}

	// Token: 0x040033C7 RID: 13255
	[Nullable(1)]
	public static Dictionary<EActivityTaskState, EActivityRewardState> Value;
}
