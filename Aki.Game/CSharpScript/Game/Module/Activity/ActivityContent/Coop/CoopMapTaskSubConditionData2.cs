using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200583D RID: 22589
	public class CoopMapTaskSubConditionData2 : CoopSubConditionDataBase
	{
		// Token: 0x06037B5B RID: 228187 RVA: 0x00F93734 File Offset: 0x00F91934
		public CoopMapTaskSubConditionData2(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle4 ?? "");
		}

		// Token: 0x06037B5C RID: 228188 RVA: 0x00F9377D File Offset: 0x00F9197D
		public override bool IsShowJumpBtn()
		{
			return true;
		}

		// Token: 0x06037B5D RID: 228189 RVA: 0x00F93780 File Offset: 0x00F91980
		public override bool IsTaskDone()
		{
			return this.IsTask4Done;
		}

		// Token: 0x06037B5E RID: 228190 RVA: 0x00F93788 File Offset: 0x00F91988
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.IsTask4Done = data.LevelPlay2Done;
		}

		// Token: 0x06037B5F RID: 228191 RVA: 0x00F93798 File Offset: 0x00F91998
		public override void OnJumpClick()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			if (coopTaskConfigById != null && coopTaskConfigById.Value.LevelId2 != 0 && coopTaskConfigById.Value.TraceMarkId4 != 0)
			{
				base.JumpMapMark(coopTaskConfigById.Value.LevelId2, coopTaskConfigById.Value.TraceMarkId4);
			}
		}

		// Token: 0x0401D67D RID: 120445
		public bool IsTask4Done;
	}
}
