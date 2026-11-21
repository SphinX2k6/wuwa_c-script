using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x02002F66 RID: 12134
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TaskLockItem : TaskItemBase<MapTravelLockAreaData>
	{
		// Token: 0x0601CBCE RID: 117710 RVA: 0x008C57ED File Offset: 0x008C39ED
		public TaskLockItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0601CBCF RID: 117711 RVA: 0x008C57F8 File Offset: 0x008C39F8
		public void Refresh(MapTravelLockAreaData taskData)
		{
			this.TaskData = taskData;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LevelGeneralCommons.GetConditionGroupHintText(taskData.ConditionGroupId) ?? "", Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			this.ButtonItem.SetUiActive(taskData.JumpId > 0);
			base.GetItem(6).SetUIActive(taskData.JumpId == 0);
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x0601CBD0 RID: 117712 RVA: 0x008C5879 File Offset: 0x008C3A79
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId > 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}
	}
}
