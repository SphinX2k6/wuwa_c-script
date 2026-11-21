using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005167 RID: 20839
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoadBookTaskLockItem : RoadBookTaskItemBase<RoadBookLockAreaData>
	{
		// Token: 0x06034103 RID: 213251 RVA: 0x00E90894 File Offset: 0x00E8EA94
		public RoadBookTaskLockItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x06034104 RID: 213252 RVA: 0x00E908A0 File Offset: 0x00E8EAA0
		public override void Refresh(RoadBookLockAreaData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LevelGeneralCommons.GetConditionGroupHintText(taskData.ConditionGroupId) ?? "", Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			this.ButtonItem.SetUiActive(taskData.JumpId > 0);
			base.GetItem(6).SetUIActive(taskData.JumpId == 0);
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x06034105 RID: 213253 RVA: 0x00E90921 File Offset: 0x00E8EB21
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}

		// Token: 0x0401B90B RID: 112907
		protected new RoadBookLockAreaData TaskData;
	}
}
