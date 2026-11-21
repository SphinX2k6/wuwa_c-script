using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005203 RID: 20995
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RealmBetweenTaskLockItem : RealmBetweenTaskItemBase<RealmBetweenLockAreaData>
	{
		// Token: 0x06034467 RID: 214119 RVA: 0x00E9F93E File Offset: 0x00E9DB3E
		public RealmBetweenTaskLockItem(ActivityRealmBetweenData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x06034468 RID: 214120 RVA: 0x00E9F948 File Offset: 0x00E9DB48
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

		// Token: 0x06034469 RID: 214121 RVA: 0x00E9F9EC File Offset: 0x00E9DBEC
		protected override void OnClickedButton()
		{
			if (this.TaskData.JumpId != 0)
			{
				SkipTaskManager.RunByConfigId(this.TaskData.JumpId, null);
			}
		}

		// Token: 0x0401BBFD RID: 113661
		protected new RealmBetweenLockAreaData TaskData;
	}
}
