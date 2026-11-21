using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200583C RID: 22588
	public class CoopMapTaskSubConditionData1 : CoopSubConditionDataBase
	{
		// Token: 0x06037B56 RID: 228182 RVA: 0x00F93660 File Offset: 0x00F91860
		public CoopMapTaskSubConditionData1(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.Title = (coopTaskConfigById.Value.TaskTitle3 ?? "");
		}

		// Token: 0x06037B57 RID: 228183 RVA: 0x00F936A9 File Offset: 0x00F918A9
		public override bool IsShowJumpBtn()
		{
			return true;
		}

		// Token: 0x06037B58 RID: 228184 RVA: 0x00F936AC File Offset: 0x00F918AC
		public override bool IsTaskDone()
		{
			return this.IsTask3Done;
		}

		// Token: 0x06037B59 RID: 228185 RVA: 0x00F936B4 File Offset: 0x00F918B4
		[NullableContext(1)]
		public override void RefreshData(CoopTaskCompleteInfo data)
		{
			this.IsTask3Done = data.LevelPlay1Done;
		}

		// Token: 0x06037B5A RID: 228186 RVA: 0x00F936C4 File Offset: 0x00F918C4
		public override void OnJumpClick()
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(this.Id);
			if (coopTaskConfigById != null && coopTaskConfigById.Value.LevelId1 != 0 && coopTaskConfigById.Value.TraceMarkId3 != 0)
			{
				base.JumpMapMark(coopTaskConfigById.Value.LevelId1, coopTaskConfigById.Value.TraceMarkId3);
			}
		}

		// Token: 0x0401D67C RID: 120444
		public bool IsTask3Done;
	}
}
