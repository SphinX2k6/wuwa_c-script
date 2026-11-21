using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005841 RID: 22593
	public class CoopTimeMapTaskSubConditionData : CoopSubConditionDataBase
	{
		// Token: 0x06037B6D RID: 228205 RVA: 0x00F93B4C File Offset: 0x00F91D4C
		public CoopTimeMapTaskSubConditionData(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle5 ?? "");
		}

		// Token: 0x06037B6E RID: 228206 RVA: 0x00F93B98 File Offset: 0x00F91D98
		public override bool IsTaskDone()
		{
			if (this.UnlockTime == 0L)
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return (double)this.UnlockTime <= serverTime;
		}

		// Token: 0x06037B6F RID: 228207 RVA: 0x00F93BC7 File Offset: 0x00F91DC7
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.UnlockTime = data.UnLockTime;
		}

		// Token: 0x0401D685 RID: 120453
		public long UnlockTime;
	}
}
