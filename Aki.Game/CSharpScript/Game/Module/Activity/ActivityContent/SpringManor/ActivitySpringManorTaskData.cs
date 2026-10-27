using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006039 RID: 24633
	public class ActivitySpringManorTaskData
	{
		// Token: 0x0603E5BE RID: 255422 RVA: 0x00F0FC9C File Offset: 0x00F0DE9C
		[NullableContext(1)]
		public void Refresh(ConditionTask taskData)
		{
			this.Status = TaskStateResolver.ConditionState[taskData.Status];
			this.Current = taskData.Current;
			this.Target = taskData.Target;
			if (this.Id != taskData.Id)
			{
				SpringFestivalReward? springFestivalReward;
				this.Sort = ((SpringManorConfig.Instance.GetRewardTaskConfigById(taskData.Id) != null) ? springFestivalReward.GetValueOrDefault().Sort : 1);
			}
			this.Id = taskData.Id;
		}

		// Token: 0x04020921 RID: 133409
		public int Id;

		// Token: 0x04020922 RID: 133410
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x04020923 RID: 133411
		public int Current;

		// Token: 0x04020924 RID: 133412
		public int Target;

		// Token: 0x04020925 RID: 133413
		public int Sort;
	}
}
