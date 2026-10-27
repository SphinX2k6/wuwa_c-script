using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F74 RID: 24436
	public class ActivityConditionView : CommonConditionView
	{
		// Token: 0x0603E077 RID: 254071 RVA: 0x00EF9C5B File Offset: 0x00EF7E5B
		[NullableContext(1)]
		public ActivityConditionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603E078 RID: 254072 RVA: 0x00EF9C64 File Offset: 0x00EF7E64
		protected override void OnStart()
		{
			ActivityConditionGroupData activityConditionGroupData = this.OpenParam as ActivityConditionGroupData;
			this.ActivityId = activityConditionGroupData.ActivityId;
			if (this.ActivityId == 0)
			{
				return;
			}
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(this.ActivityId);
			if (activityById == null)
			{
				return;
			}
			ActivityModel.Instance.SendActivityLockConditionLogData(activityById);
			List<IActivityConditionData> activityConditionData = ActivityModel.Instance.GetActivityConditionData(activityById);
			if (activityById.HasPreOpenCondition())
			{
				this.ConditionGroupData = new ConditionGroupData(activityById.PreOpenConditionGroupId, activityConditionData, activityById.LocalConfig.Value.Name, true);
			}
			else
			{
				this.ConditionGroupData = new ConditionGroupData(activityById.ConditionGroupId, activityConditionData, activityById.LocalConfig.Value.Name, false);
			}
			this.TextIdMap["FinishAllConditionOpen"] = "ActivityNotOpen_Tips01";
			this.TextIdMap["FinishAnyConditionOpen"] = "ActivityNotOpen_Tips02";
			this.TextIdMap["FinishAllConditionPreOpen"] = "ActivityNotPreOpen_Tips01";
			this.TextIdMap["FinishAnyConditionPreOpen"] = "ActivityNotPreOpen_Tips02";
			base.CreateConditionLayout();
		}

		// Token: 0x04020646 RID: 132678
		private int ActivityId;
	}
}
