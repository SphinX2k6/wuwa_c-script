using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006285 RID: 25221
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskLockItem : RealmBetweenTaskItemBase<RealmBetweenLockAreaData>
	{
		// Token: 0x0603F7A6 RID: 260006 RVA: 0x00F589E2 File Offset: 0x00F56BE2
		public RealmBetweenTaskLockItem(ActivityRealmBetweenData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F7A7 RID: 260007 RVA: 0x00F589EC File Offset: 0x00F56BEC
		public override void Refresh(RealmBetweenLockAreaData taskData, bool isSelected, int gridIndex)
		{
			this.TaskData = taskData;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), LevelGeneralCommons.GetConditionGroupHintText(taskData.ConditionGroupId) ?? "", Array.Empty<object>());
			base.GetText(1).SetUIActive(false);
			this.ButtonItem.SetUiActive(taskData.JumpId > 0);
			base.GetItem(6).SetUIActive(taskData.JumpId == 0);
			base.GetItem(5).SetUIActive(false);
			this.RewardButtonItem.SetUiActive(false);
			GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(new List<IItemGridData>(), null, false);
		}

		// Token: 0x0603F7A8 RID: 260008 RVA: 0x00F58A90 File Offset: 0x00F56C90
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}

		// Token: 0x040212CE RID: 135886
		protected new RealmBetweenLockAreaData TaskData;
	}
}
