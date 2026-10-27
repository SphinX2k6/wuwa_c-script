using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068EC RID: 26860
	public class CoopMapTaskSubConditionData1 : CoopSubConditionDataBase
	{
		// Token: 0x06042FFE RID: 274430 RVA: 0x01052038 File Offset: 0x01050238
		public CoopMapTaskSubConditionData1(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle3 ?? "");
		}

		// Token: 0x06042FFF RID: 274431 RVA: 0x01052081 File Offset: 0x01050281
		public override bool IsShowJumpBtn()
		{
			return true;
		}

		// Token: 0x06043000 RID: 274432 RVA: 0x01052084 File Offset: 0x01050284
		public override bool IsTaskDone()
		{
			return this.IsTask3Done;
		}

		// Token: 0x06043001 RID: 274433 RVA: 0x0105208C File Offset: 0x0105028C
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.IsTask3Done = data.LevelPlay1Done;
		}

		// Token: 0x06043002 RID: 274434 RVA: 0x0105209C File Offset: 0x0105029C
		public override void OnJumpClick()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			if (coopTaskConfigById != null && coopTaskConfigById.Value.LevelId1 != 0 && coopTaskConfigById.Value.TraceMarkId3 != 0)
			{
				base.JumpMapMark(coopTaskConfigById.Value.LevelId1, coopTaskConfigById.Value.TraceMarkId3);
			}
		}

		// Token: 0x04022E20 RID: 142880
		public bool IsTask3Done;
	}
}
