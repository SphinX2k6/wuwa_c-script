using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FB7 RID: 20407
	public class ActivitySpringManorTaskData
	{
		// Token: 0x06033282 RID: 209538 RVA: 0x00E56A60 File Offset: 0x00E54C60
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

		// Token: 0x0401B24E RID: 111182
		public int Id;

		// Token: 0x0401B24F RID: 111183
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401B250 RID: 111184
		public int Current;

		// Token: 0x0401B251 RID: 111185
		public int Target;

		// Token: 0x0401B252 RID: 111186
		public int Sort;
	}
}
