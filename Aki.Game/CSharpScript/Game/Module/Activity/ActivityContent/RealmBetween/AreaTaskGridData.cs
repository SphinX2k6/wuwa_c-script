using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006292 RID: 25234
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaTaskGridData : MultiTemplateGridDataBase<IAreaTaskItemData, AreaTaskItem>
	{
		// Token: 0x0603F7E2 RID: 260066 RVA: 0x00F59C8B File Offset: 0x00F57E8B
		public AreaTaskGridData(ActivityTaskData taskData, RealmBetweenAreaData areaData, ActivityRealmBetweenData activity)
		{
			base.Data = new IAreaTaskItemData
			{
				TaskData = taskData,
				AreaData = areaData
			};
			this.Activity = activity;
		}

		// Token: 0x0603F7E3 RID: 260067 RVA: 0x00F59CB3 File Offset: 0x00F57EB3
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x0603F7E4 RID: 260068 RVA: 0x00F59CB6 File Offset: 0x00F57EB6
		public override AreaTaskItem CreateProxy()
		{
			return new AreaTaskItem(this.Activity);
		}

		// Token: 0x04021309 RID: 135945
		private readonly ActivityRealmBetweenData Activity;
	}
}
