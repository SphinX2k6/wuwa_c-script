using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006293 RID: 25235
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaLockGuideGridData : MultiTemplateGridDataBase<IAreaTaskItemData, AreaTaskItem>
	{
		// Token: 0x0603F7E5 RID: 260069 RVA: 0x00F59CC4 File Offset: 0x00F57EC4
		public AreaLockGuideGridData(RealmBetweenAreaData areaData, ActivityRealmBetweenData activity)
		{
			RealmBetweenArea? areaConfig = ActivityRealmBetweenConfig.Instance.GetAreaConfig(areaData.AreaId);
			int inConditionGroupId = (areaConfig != null) ? areaConfig.GetValueOrDefault().UnLockCondition : 0;
			base.Data = new IAreaTaskItemData
			{
				AreaData = areaData,
				TaskData = null,
				UnlockJumpId = new int?((areaConfig != null) ? areaConfig.GetValueOrDefault().UnlockAccessId : 0),
				UnlockHintText = (LevelGeneralCommons.GetConditionGroupHintText(inConditionGroupId) ?? "")
			};
			this.Activity = activity;
		}

		// Token: 0x0603F7E6 RID: 260070 RVA: 0x00F59D5F File Offset: 0x00F57F5F
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603F7E7 RID: 260071 RVA: 0x00F59D62 File Offset: 0x00F57F62
		public override AreaTaskItem CreateProxy()
		{
			return new AreaTaskItem(this.Activity);
		}

		// Token: 0x0402130A RID: 135946
		private readonly ActivityRealmBetweenData Activity;
	}
}
