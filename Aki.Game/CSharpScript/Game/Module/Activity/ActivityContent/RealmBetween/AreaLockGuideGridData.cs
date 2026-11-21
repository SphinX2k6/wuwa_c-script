using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005211 RID: 21009
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaLockGuideGridData : MultiTemplateGridDataBase<IAreaTaskItemData, AreaTaskItem>
	{
		// Token: 0x060344A6 RID: 214182 RVA: 0x00EA0C20 File Offset: 0x00E9EE20
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

		// Token: 0x060344A7 RID: 214183 RVA: 0x00EA0CBB File Offset: 0x00E9EEBB
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060344A8 RID: 214184 RVA: 0x00EA0CBE File Offset: 0x00E9EEBE
		public override AreaTaskItem CreateProxy()
		{
			return new AreaTaskItem(this.Activity);
		}

		// Token: 0x0401BC39 RID: 113721
		private readonly ActivityRealmBetweenData Activity;
	}
}
