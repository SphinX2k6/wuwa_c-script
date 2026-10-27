using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068F1 RID: 26865
	public class CoopTimeMapTaskSubConditionData : CoopSubConditionDataBase
	{
		// Token: 0x06043015 RID: 274453 RVA: 0x01052524 File Offset: 0x01050724
		public CoopTimeMapTaskSubConditionData(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle5 ?? "");
		}

		// Token: 0x06043016 RID: 274454 RVA: 0x01052570 File Offset: 0x01050770
		public override bool IsTaskDone()
		{
			if (this.UnlockTime == 0L)
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return (double)this.UnlockTime <= serverTime;
		}

		// Token: 0x06043017 RID: 274455 RVA: 0x0105259F File Offset: 0x0105079F
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.UnlockTime = data.UnLockTime;
		}

		// Token: 0x04022E29 RID: 142889
		public long UnlockTime;
	}
}
