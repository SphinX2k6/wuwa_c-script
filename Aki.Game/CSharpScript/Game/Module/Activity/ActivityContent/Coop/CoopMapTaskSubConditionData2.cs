using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068ED RID: 26861
	public class CoopMapTaskSubConditionData2 : CoopSubConditionDataBase
	{
		// Token: 0x06043003 RID: 274435 RVA: 0x0105210C File Offset: 0x0105030C
		public CoopMapTaskSubConditionData2(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle4 ?? "");
		}

		// Token: 0x06043004 RID: 274436 RVA: 0x01052155 File Offset: 0x01050355
		public override bool IsShowJumpBtn()
		{
			return true;
		}

		// Token: 0x06043005 RID: 274437 RVA: 0x01052158 File Offset: 0x01050358
		public override bool IsTaskDone()
		{
			return this.IsTask4Done;
		}

		// Token: 0x06043006 RID: 274438 RVA: 0x01052160 File Offset: 0x01050360
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.IsTask4Done = data.LevelPlay2Done;
		}

		// Token: 0x06043007 RID: 274439 RVA: 0x01052170 File Offset: 0x01050370
		public override void OnJumpClick()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			if (coopTaskConfigById != null && coopTaskConfigById.Value.LevelId2 != 0 && coopTaskConfigById.Value.TraceMarkId4 != 0)
			{
				base.JumpMapMark(coopTaskConfigById.Value.LevelId2, coopTaskConfigById.Value.TraceMarkId4);
			}
		}

		// Token: 0x04022E21 RID: 142881
		public bool IsTask4Done;
	}
}
