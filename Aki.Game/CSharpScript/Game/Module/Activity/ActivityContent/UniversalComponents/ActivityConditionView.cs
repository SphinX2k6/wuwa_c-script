using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F5B RID: 20315
	public class ActivityConditionView : CommonConditionView
	{
		// Token: 0x06033011 RID: 208913 RVA: 0x00E4B943 File Offset: 0x00E49B43
		[NullableContext(1)]
		public ActivityConditionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033012 RID: 208914 RVA: 0x00E4B94C File Offset: 0x00E49B4C
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

		// Token: 0x0401B118 RID: 110872
		private int ActivityId;
	}
}
