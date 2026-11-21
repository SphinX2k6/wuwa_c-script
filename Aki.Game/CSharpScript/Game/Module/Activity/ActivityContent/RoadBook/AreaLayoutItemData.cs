using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200516C RID: 20844
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaLayoutItemData
	{
		// Token: 0x0603410B RID: 213259 RVA: 0x00E90AD6 File Offset: 0x00E8ECD6
		public AreaLayoutItemData(bool isTitle, RoadBookAreaData areaData = null, ActivityTaskData taskData = null)
		{
			this.IsTitle = isTitle;
			this.AreaData = areaData;
			this.TaskData = taskData;
		}

		// Token: 0x0401B925 RID: 112933
		public bool IsTitle;

		// Token: 0x0401B926 RID: 112934
		public RoadBookAreaData AreaData;

		// Token: 0x0401B927 RID: 112935
		public ActivityTaskData TaskData;

		// Token: 0x0401B928 RID: 112936
		public float? ExtraHeight;
	}
}
