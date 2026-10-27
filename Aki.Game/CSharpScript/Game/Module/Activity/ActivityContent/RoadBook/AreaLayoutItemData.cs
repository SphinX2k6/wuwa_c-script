using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061EE RID: 25070
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaLayoutItemData
	{
		// Token: 0x0603F44A RID: 259146 RVA: 0x00F49B7E File Offset: 0x00F47D7E
		public AreaLayoutItemData(bool isTitle, RoadBookAreaData areaData = null, ActivityTaskData taskData = null)
		{
			this.IsTitle = isTitle;
			this.AreaData = areaData;
			this.TaskData = taskData;
		}

		// Token: 0x04020FF6 RID: 135158
		public bool IsTitle;

		// Token: 0x04020FF7 RID: 135159
		public RoadBookAreaData AreaData;

		// Token: 0x04020FF8 RID: 135160
		public ActivityTaskData TaskData;

		// Token: 0x04020FF9 RID: 135161
		public float? ExtraHeight;
	}
}
