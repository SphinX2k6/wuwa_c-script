using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;

namespace ActivityNamespace.MapTravel.MapTravelSubViewTravelTask
{
	// Token: 0x020044D9 RID: 17625
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class TaskLockItem : TaskItemBase<MapTravelLockAreaData>
	{
		// Token: 0x0602D690 RID: 186000 RVA: 0x00A3FB89 File Offset: 0x00A3DD89
		public TaskLockItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0602D691 RID: 186001 RVA: 0x00A3FB94 File Offset: 0x00A3DD94
		public void Refresh(MapTravelLockAreaData taskData)
		{
			this.TaskData = taskData;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LevelGeneralCommons.GetConditionGroupHintText(taskData.ConditionGroupId) ?? "", Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			this.ButtonItem.SetUiActive(taskData.JumpId > 0);
			base.GetItem(6).SetUIActive(taskData.JumpId == 0);
			base.GetItem(5).SetUIActive(true);
		}

		// Token: 0x0602D692 RID: 186002 RVA: 0x00A3FC15 File Offset: 0x00A3DE15
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId > 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}
	}
}
