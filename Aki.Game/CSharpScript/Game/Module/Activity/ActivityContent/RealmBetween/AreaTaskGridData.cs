using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02005210 RID: 21008
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class AreaTaskGridData : MultiTemplateGridDataBase<IAreaTaskItemData, AreaTaskItem>
	{
		// Token: 0x060344A3 RID: 214179 RVA: 0x00EA0BE7 File Offset: 0x00E9EDE7
		public AreaTaskGridData(ActivityTaskData taskData, RealmBetweenAreaData areaData, ActivityRealmBetweenData activity)
		{
			base.Data = new IAreaTaskItemData
			{
				TaskData = taskData,
				AreaData = areaData
			};
			this.Activity = activity;
		}

		// Token: 0x060344A4 RID: 214180 RVA: 0x00EA0C0F File Offset: 0x00E9EE0F
		public override int GetTemplateIndex()
		{
			return 1;
		}

		// Token: 0x060344A5 RID: 214181 RVA: 0x00EA0C12 File Offset: 0x00E9EE12
		public override AreaTaskItem CreateProxy()
		{
			return new AreaTaskItem(this.Activity);
		}

		// Token: 0x0401BC38 RID: 113720
		private readonly ActivityRealmBetweenData Activity;
	}
}
