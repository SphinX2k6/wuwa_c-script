using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E9 RID: 25065
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskLockItem : RoadBookTaskItemBase<RoadBookLockAreaData>
	{
		// Token: 0x0603F442 RID: 259138 RVA: 0x00F4993C File Offset: 0x00F47B3C
		public RoadBookTaskLockItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F443 RID: 259139 RVA: 0x00F49948 File Offset: 0x00F47B48
		public override void Refresh(RoadBookLockAreaData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LevelGeneralCommons.GetConditionGroupHintText(taskData.ConditionGroupId) ?? "", Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			this.ButtonItem.SetUiActive(taskData.JumpId > 0);
			base.GetItem(6).SetUIActive(taskData.JumpId == 0);
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x0603F444 RID: 259140 RVA: 0x00F499C9 File Offset: 0x00F47BC9
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}

		// Token: 0x04020FDC RID: 135132
		protected new RoadBookLockAreaData TaskData;
	}
}
